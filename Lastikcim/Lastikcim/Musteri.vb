Imports System.Data.SqlClient

Public Class Musteri

    Private Sub ListeleBtn_Click(sender As Object, e As EventArgs) Handles ListeleBtn.Click
        Listele()
    End Sub
    Private Sub EkleBtn_Click(sender As Object, e As EventArgs) Handles EkleBtn.Click
        If AdiTBox.Text <> "" And SoyadiTBox.Text <> "" And TelefonTBox.Text <> "" Then
            Dim sqlbaglanti As New SqlConnection(SqlBaglantiCumlesi)
            Dim sorgu As String = "insert into Musteri values('" + AdiTBox.Text + "', '" + SoyadiTBox.Text + "','" + TelefonTBox.Text + "')"
            Dim komut As New SqlCommand(sorgu, sqlbaglanti)
            sqlbaglanti.Open()
            komut.ExecuteNonQuery()
            sqlbaglanti.Close()
            Listele()
            Temizle()
        Else
            MessageBox.Show("Girilen boş değer ekleme yapılamadı. ", "Uyarı")
        End If
    End Sub
    Sub Listele()
        Dim dt As New DataTable
        Dim sqlbaglanti As New SqlConnection(SqlBaglantiCumlesi)
        Dim sorgu As String = "select * from Musteri"
        Dim adaptor As New SqlDataAdapter(sorgu, sqlbaglanti)
        adaptor.Fill(dt)
        MusteriDGV.DataSource = dt
    End Sub
    Sub Temizle()
        AdiTBox.Text = ""
        SoyadiTBox.Text = ""
        TelefonTBox.Text = ""
        MusteriidTbox.Text = ""
    End Sub
    Private Sub TemizleBtn_Click(sender As Object, e As EventArgs) Handles TemizleBtn.Click
        Temizle()
    End Sub
    Private Sub GuncelleBtn_Click(sender As Object, e As EventArgs) Handles GuncelleBtn.Click
        Dim sqlbaglanti As New SqlConnection(SqlBaglantiCumlesi)
        Dim sorgu As String = "Update Musteri set Ad= '" & AdiTBox.Text & "', Soyad= '" & SoyadiTBox.Text & "',Telefon= '" & TelefonTBox.Text & "' where  MusteriID= '" & Integer.Parse(MusteriidTbox.Text) & "'"
        Dim komut As New SqlCommand(sorgu, sqlbaglanti)
        sqlbaglanti.Open()
        komut.ExecuteNonQuery()
        sqlbaglanti.Close()
        Listele()
        Temizle()
    End Sub

    Private Sub MusteriDGV_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles MusteriDGV.CellDoubleClick
        MusteriidTbox.Text = MusteriDGV.CurrentRow.Cells("MusteriID").Value.ToString()
        AdiTBox.Text = MusteriDGV.CurrentRow.Cells("Ad").Value.ToString()
        SoyadiTBox.Text = MusteriDGV.CurrentRow.Cells("Soyad").Value.ToString()
        TelefonTBox.Text = MusteriDGV.CurrentRow.Cells("Telefon").Value.ToString()
        EpostaTBox.Text = MusteriDGV.CurrentRow.Cells("Eposta").Value.ToString()

    End Sub

    Private Sub MusteriAraBtn_Click(sender As Object, e As EventArgs) Handles MusteriAraBtn.Click
        Dim dt As New DataTable
        Dim sqlbaglanti As New SqlConnection(SqlBaglantiCumlesi)
        Dim sorgu As String = "SELECT * FROM Musteriler WHERE Ad + ' ' + Soyad LIKE '%" & MusteriAraTBox.Text & "%'"
        Dim adaptor As New SqlDataAdapter(sorgu, sqlbaglanti)
        adaptor.Fill(dt)
        MusteriDGV.DataSource = dt
    End Sub
End Class