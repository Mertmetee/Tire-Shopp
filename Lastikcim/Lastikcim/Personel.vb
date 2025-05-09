Imports System.Data.SqlClient
Public Class Personel
    Private Sub ListeleBtn_Click(sender As Object, e As EventArgs) Handles ListeleBtn.Click
        Listele()
    End Sub

    Private Sub EkleBtn_Click(sender As Object, e As EventArgs) Handles EkleBtn.Click
        If AdTBox.Text <> "" And SoyadTBox.Text <> "" And PozisyonTBox.Text <> "" And TelefonTBox.Text <> "" Then
            Dim sqlbaglanti As New SqlConnection(SqlBaglantiCumlesi)
            Dim sorgu As String = "insert into Calısanlar values('" + AdTBox.Text + "', '" + SoyadTBox.Text + "', '" + PozisyonTBox.Text + "','" + TelefonTBox.Text + "')"
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
        Dim sorgu As String = "select * from Calısanlar"
        Dim adaptor As New SqlDataAdapter(sorgu, sqlbaglanti)
        adaptor.Fill(dt)
        StokDGV.DataSource = dt
    End Sub


    Sub Temizle()
        AdTBox.Text = ""
        SoyadTBox.Text = ""
        TelefonTBox.Text = ""
        PozisyonTBox.Text = ""
        CalısanIDTBox.Text = ""
    End Sub
    Private Sub TemizleBtn_Click(sender As Object, e As EventArgs) Handles TemizleBtn.Click
        Temizle()
    End Sub

    Private Sub GuncelleBtn_Click(sender As Object, e As EventArgs) Handles GuncelleBtn.Click
        Dim sqlbaglanti As New SqlConnection(SqlBaglantiCumlesi)
        Dim sorgu As String = "Update Calısanlar set Ad= '" & AdTBox.Text & "', Soyad= '" & SoyadTBox.Text & "',Pozisyon= '" & PozisyonTBox.Text & "',Telefon= '" & TelefonTBox.Text & "' where  PersonelID= '" & Integer.Parse(CalısanIDTBox.Text) & "'"
        Dim komut As New SqlCommand(sorgu, sqlbaglanti)
        sqlbaglanti.Open()
        komut.ExecuteNonQuery()
        sqlbaglanti.Close()
        Listele()
        Temizle()
    End Sub
    Private Sub StokDGV_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles StokDGV.CellDoubleClick
        CalısanIDTBox.Text = StokDGV.CurrentRow.Cells("CalısanID").Value.ToString()
        AdTBox.Text = StokDGV.CurrentRow.Cells("Ad").Value.ToString()
        SoyadTBox.Text = StokDGV.CurrentRow.Cells("Soyad").Value.ToString()
        PozisyonTBox.Text = StokDGV.CurrentRow.Cells("Pozisyon").Value.ToString()
        TelefonTBox.Text = StokDGV.CurrentRow.Cells("Telefon").Value.ToString()
    End Sub
    Private Sub PersonelAraBtn_Click(sender As Object, e As EventArgs) Handles PersonelAraBtn.Click
        Dim dt As New DataTable
        Dim sqlbaglanti As New SqlConnection(SqlBaglantiCumlesi)
        Dim sorgu As String = "SELECT * FROM Calısanlar WHERE Ad + ' ' + Soyad LIKE '%" & AraTBox.Text & "%'"
        Dim adaptor As New SqlDataAdapter(sorgu, sqlbaglanti)
        adaptor.Fill(dt)
        StokDGV.DataSource = dt
    End Sub
End Class