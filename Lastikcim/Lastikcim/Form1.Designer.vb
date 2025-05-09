<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MüşteriİşlemleriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SatışİşlemleriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StokİşlemleriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonelİşlemleriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÇıkışToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MüşteriİşlemleriToolStripMenuItem, Me.SatışİşlemleriToolStripMenuItem, Me.StokİşlemleriToolStripMenuItem, Me.PersonelİşlemleriToolStripMenuItem, Me.ÇıkışToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1191, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MüşteriİşlemleriToolStripMenuItem
        '
        Me.MüşteriİşlemleriToolStripMenuItem.Image = CType(resources.GetObject("MüşteriİşlemleriToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MüşteriİşlemleriToolStripMenuItem.Name = "MüşteriİşlemleriToolStripMenuItem"
        Me.MüşteriİşlemleriToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.MüşteriİşlemleriToolStripMenuItem.Text = "Müşteri İşlemleri"
        '
        'SatışİşlemleriToolStripMenuItem
        '
        Me.SatışİşlemleriToolStripMenuItem.Image = CType(resources.GetObject("SatışİşlemleriToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SatışİşlemleriToolStripMenuItem.Name = "SatışİşlemleriToolStripMenuItem"
        Me.SatışİşlemleriToolStripMenuItem.Size = New System.Drawing.Size(134, 24)
        Me.SatışİşlemleriToolStripMenuItem.Text = "Satış İşlemleri"
        '
        'StokİşlemleriToolStripMenuItem
        '
        Me.StokİşlemleriToolStripMenuItem.Image = CType(resources.GetObject("StokİşlemleriToolStripMenuItem.Image"), System.Drawing.Image)
        Me.StokİşlemleriToolStripMenuItem.Name = "StokİşlemleriToolStripMenuItem"
        Me.StokİşlemleriToolStripMenuItem.Size = New System.Drawing.Size(132, 24)
        Me.StokİşlemleriToolStripMenuItem.Text = "Stok İşlemleri"
        '
        'PersonelİşlemleriToolStripMenuItem
        '
        Me.PersonelİşlemleriToolStripMenuItem.Image = CType(resources.GetObject("PersonelİşlemleriToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PersonelİşlemleriToolStripMenuItem.Name = "PersonelİşlemleriToolStripMenuItem"
        Me.PersonelİşlemleriToolStripMenuItem.Size = New System.Drawing.Size(158, 24)
        Me.PersonelİşlemleriToolStripMenuItem.Text = "Personel İşlemleri"
        '
        'ÇıkışToolStripMenuItem
        '
        Me.ÇıkışToolStripMenuItem.Image = CType(resources.GetObject("ÇıkışToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ÇıkışToolStripMenuItem.Name = "ÇıkışToolStripMenuItem"
        Me.ÇıkışToolStripMenuItem.Size = New System.Drawing.Size(73, 24)
        Me.ÇıkışToolStripMenuItem.Text = "Çıkış"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1191, 357)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MüşteriİşlemleriToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SatışİşlemleriToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StokİşlemleriToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PersonelİşlemleriToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ÇıkışToolStripMenuItem As ToolStripMenuItem
End Class
