Public Class Form1
    Private Sub MüşteriİşlemleriToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MüşteriİşlemleriToolStripMenuItem.Click
        Musteri.ShowDialog(Me)
    End Sub

    Private Sub SatışİşlemleriToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SatışİşlemleriToolStripMenuItem.Click
        Satis.ShowDialog(Me)
    End Sub

    Private Sub StokİşlemleriToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StokİşlemleriToolStripMenuItem.Click
        Stok.ShowDialog(Me)
    End Sub

    Private Sub PersonelİşlemleriToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonelİşlemleriToolStripMenuItem.Click
        Personel.ShowDialog(Me)
    End Sub

    Private Sub ÇıkışToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÇıkışToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub BağlanToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        Musteri.ShowDialog(Me)

    End Sub
End Class
