Imports System.Data.SqlClient

Public Class Stok
    Private Sub Stok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GirisTarihiDTP.Value = Today
    End Sub

    Private Sub ListeleBtn_Click(sender As Object, e As EventArgs) Handles ListeleBtn.Click
        Listele()
    End Sub

    Sub Listele()
        Dim dt As New DataTable
        Using sqlbaglanti As New SqlConnection(SqlBaglantiCumlesi)
            Dim sorgu As String = "SELECT * FROM Stoklar"
            Dim adaptor As New SqlDataAdapter(sorgu, sqlbaglanti)
            adaptor.Fill(dt)
            StokDGV.DataSource = dt
        End Using
    End Sub

    Sub Temizle()
        StokIDTBox.Text = ""
        MalzemeIdTBox.Text = ""
        MalzemeAdiTBox.Text = ""
        BirimTBox.Text = ""
        GirenMiktarTBox.Text = ""
        GirisTarihiDTP.Value = DateTime.Now
        CikanMiktarTBox.Text = ""
        CikisTarihiDTP.Value = DateTime.Now
        KalanStokTBox.Text = ""
    End Sub

    Private Sub EkleBtn_Click(sender As Object, e As EventArgs) Handles EkleBtn.Click
        Using sqlbaglanti As New SqlConnection(SqlBaglantiCumlesi)
            Try
                sqlbaglanti.Open()
                If MalzemeIdTBox.Text <> "" And MalzemeAdiTBox.Text <> "" And BirimTBox.Text <> "" Then
                    Dim kalanStok As Integer = 0
                    Dim sorgu As String = "SELECT ISNULL(SUM(GirenMiktar), 0) AS TotalGirenMiktar, ISNULL(SUM(CikanMiktar), 0) AS TotalCikanMiktar FROM Stok WHERE MalzemeID = @MalzemeID"
                    Dim komut As New SqlCommand(sorgu, sqlbaglanti)
                    komut.Parameters.AddWithValue("@MalzemeID", MalzemeIdTBox.Text)

                    Dim reader As SqlDataReader = komut.ExecuteReader()
                    If reader.Read() Then
                        Dim totalGirenMiktar As Integer = Convert.ToInt32(reader("TotalGirenMiktar"))
                        Dim totalCikanMiktar As Integer = Convert.ToInt32(reader("TotalCikanMiktar"))
                        kalanStok = totalGirenMiktar - totalCikanMiktar
                    End If
                    reader.Close()

                    Dim sorguEkle As String = "INSERT INTO Stoklar (MalzemeID, MalzemeAdi, Birim, GirenMiktar, GirisTarihi, CikanMiktar, CikisTarihi, KalanStokMiktari) VALUES (@MalzemeID, @MalzemeAdi, @Birim, @GirenMiktar, @GirisTarihi, @CikanMiktar, @CikisTarihi, @KalanStokMiktari)"
                    Dim komutEkle As New SqlCommand(sorguEkle, sqlbaglanti)
                    komutEkle.Parameters.AddWithValue("@MalzemeID", MalzemeIdTBox.Text)
                    komutEkle.Parameters.AddWithValue("@MalzemeAdi", MalzemeAdiTBox.Text)
                    komutEkle.Parameters.AddWithValue("@Birim", BirimTBox.Text)
                    komutEkle.Parameters.AddWithValue("@GirisTarihi", GirisTarihiDTP.Value)
                    komutEkle.Parameters.AddWithValue("@CikisTarihi", CikisTarihiDTP.Value)

                    If GirenMiktarTBox.Text <> "" Then
                        komutEkle.Parameters.AddWithValue("@GirenMiktar", GirenMiktarTBox.Text)
                        komutEkle.Parameters.AddWithValue("@CikanMiktar", 0)
                        kalanStok += Convert.ToInt32(GirenMiktarTBox.Text)
                    ElseIf CikanMiktarTBox.Text <> "" Then
                        komutEkle.Parameters.AddWithValue("@CikanMiktar", CikanMiktarTBox.Text)
                        komutEkle.Parameters.AddWithValue("@GirenMiktar", 0)
                        kalanStok -= Convert.ToInt32(CikanMiktarTBox.Text)
                    End If
                    komutEkle.Parameters.AddWithValue("@KalanStokMiktari", kalanStok)

                    komutEkle.ExecuteNonQuery()
                    Listele()
                    Temizle()
                Else
                    MessageBox.Show("Malzeme bilgileri eksik.", "Uyarı")
                End If
            Catch ex As Exception
                MessageBox.Show("İşlemde bir hata oluştu. " & ex.Message, "Uyarı")
            End Try
        End Using
    End Sub

    Private Sub StokDGV_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles StokDGV.CellDoubleClick
        StokIDTBox.Text = StokDGV.CurrentRow.Cells("StokID").Value.ToString()
        MalzemeIdTBox.Text = StokDGV.CurrentRow.Cells("MalzemeID").Value.ToString()
        MalzemeAdiTBox.Text = StokDGV.CurrentRow.Cells("MalzemeAdi").Value.ToString()
        BirimTBox.Text = StokDGV.CurrentRow.Cells("Birim").Value.ToString()
        GirenMiktarTBox.Text = StokDGV.CurrentRow.Cells("GirenMiktar").Value.ToString()
        GirisTarihiDTP.Text = StokDGV.CurrentRow.Cells("GirisTarihi").Value.ToString()
        CikanMiktarTBox.Text = StokDGV.CurrentRow.Cells("CikanMiktar").Value.ToString()
        CikisTarihiDTP.Text = StokDGV.CurrentRow.Cells("CikisTarihi").Value.ToString()
        KalanStokTBox.Text = StokDGV.CurrentRow.Cells("KalanStokMiktari").Value.ToString()
    End Sub

    Private Sub MalzemeAraBtn_Click(sender As Object, e As EventArgs) Handles MalzemeAraBtn.Click
        Try
            Dim dt As New DataTable
            Using sqlbaglanti As New SqlConnection(SqlBaglantiCumlesi)
                Dim sorgu As String = "SELECT * FROM Stoklar WHERE MalzemeAdi LIKE  '%" & MalzemeAraTBox.Text & "%'"
                Dim adaptor As New SqlDataAdapter(sorgu, sqlbaglanti)
                adaptor.Fill(dt)
                StokDGV.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Hata " & ex.Message, "Uyarı")
        End Try
    End Sub

    Private Sub GuncelleBtn_Click(sender As Object, e As EventArgs) Handles GuncelleBtn.Click
        Try
            If MalzemeIdTBox.Text <> "" And MalzemeAdiTBox.Text <> "" And BirimTBox.Text <> "" Then
                Using sqlbaglanti As New SqlConnection(SqlBaglantiCumlesi)
                    sqlbaglanti.Open()

                    ' Önce mevcut stok miktarını alalım
                    Dim mevcutStok As Integer = 0
                    Dim sorguMevcutStok As String = "SELECT ISNULL(SUM(GirenMiktar - CikanMiktar), 0) AS MevcutStok FROM Stoklar WHERE MalzemeID = @MalzemeID"
                    Dim komutMevcutStok As New SqlCommand(sorguMevcutStok, sqlbaglanti)
                    komutMevcutStok.Parameters.AddWithValue("@MalzemeID", MalzemeIdTBox.Text)
                    Dim readerMevcutStok As SqlDataReader = komutMevcutStok.ExecuteReader()
                    If readerMevcutStok.Read() Then
                        mevcutStok = Convert.ToInt32(readerMevcutStok("MevcutStok"))
                    End If
                    readerMevcutStok.Close()

                    ' Giren veya çıkan miktarı alalım
                    Dim girenMiktar As Integer = 0
                    Dim cikanMiktar As Integer = 0
                    If GirenMiktarTBox.Text <> "" AndAlso IsNumeric(GirenMiktarTBox.Text) Then
                        girenMiktar = Convert.ToInt32(GirenMiktarTBox.Text)
                    End If
                    If CikanMiktarTBox.Text <> "" AndAlso IsNumeric(CikanMiktarTBox.Text) Then
                        cikanMiktar = Convert.ToInt32(CikanMiktarTBox.Text)
                    End If

                    ' Güncelleme sorgusunu hazırlayalım
                    Dim updateSorgu As String = "UPDATE Stok SET MalzemeID = @MalzemeID, MalzemeAdi = @MalzemeAdi, Birim = @Birim, GirenMiktar = @GirenMiktar, CikanMiktar = @CikanMiktar, KalanStokMiktari = @KalanStokMiktari WHERE MalzemeID = @MalzemeID"
                    Dim updateKomut As New SqlCommand(updateSorgu, sqlbaglanti)
                    updateKomut.Parameters.AddWithValue("@MalzemeID", MalzemeIdTBox.Text)
                    updateKomut.Parameters.AddWithValue("@MalzemeAdi", MalzemeAdiTBox.Text)
                    updateKomut.Parameters.AddWithValue("@Birim", BirimTBox.Text)
                    updateKomut.Parameters.AddWithValue("@GirenMiktar", girenMiktar)
                    updateKomut.Parameters.AddWithValue("@CikanMiktar", cikanMiktar)
                    updateKomut.Parameters.AddWithValue("@KalanStokMiktari", mevcutStok + girenMiktar - cikanMiktar)
                    updateKomut.ExecuteNonQuery()

                    Listele()
                    Temizle()
                End Using
            Else
                MessageBox.Show("Malzeme bilgileri eksik.", "Uyarı")
            End If
        Catch ex As Exception
            MessageBox.Show("Güncelleme işleminde bir hata oluştu. " & ex.Message, "Uyarı")
        End Try
    End Sub

    Private Sub TemizleBtn_Click(sender As Object, e As EventArgs) Handles TemizleBtn.Click
        Temizle()
    End Sub


End Class