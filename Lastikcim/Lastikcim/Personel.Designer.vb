<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Personel
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Personel))
        Me.TemizleBtn = New System.Windows.Forms.Button()
        Me.ListeleBtn = New System.Windows.Forms.Button()
        Me.GuncelleBtn = New System.Windows.Forms.Button()
        Me.EkleBtn = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.AraTBox = New System.Windows.Forms.TextBox()
        Me.PersonelAraBtn = New System.Windows.Forms.Button()
        Me.StokDGV = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AdTBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CalısanIDTBox = New System.Windows.Forms.TextBox()
        Me.PozisyonTBox = New System.Windows.Forms.TextBox()
        Me.TelefonTBox = New System.Windows.Forms.TextBox()
        Me.SoyadTBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.StokDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TemizleBtn
        '
        Me.TemizleBtn.Image = CType(resources.GetObject("TemizleBtn.Image"), System.Drawing.Image)
        Me.TemizleBtn.Location = New System.Drawing.Point(246, 450)
        Me.TemizleBtn.Name = "TemizleBtn"
        Me.TemizleBtn.Size = New System.Drawing.Size(69, 67)
        Me.TemizleBtn.TabIndex = 54
        Me.TemizleBtn.Text = "Temizle"
        Me.TemizleBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.TemizleBtn.UseVisualStyleBackColor = True
        '
        'ListeleBtn
        '
        Me.ListeleBtn.Image = CType(resources.GetObject("ListeleBtn.Image"), System.Drawing.Image)
        Me.ListeleBtn.Location = New System.Drawing.Point(353, 450)
        Me.ListeleBtn.Name = "ListeleBtn"
        Me.ListeleBtn.Size = New System.Drawing.Size(69, 67)
        Me.ListeleBtn.TabIndex = 53
        Me.ListeleBtn.Text = "Listele"
        Me.ListeleBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.ListeleBtn.UseVisualStyleBackColor = True
        '
        'GuncelleBtn
        '
        Me.GuncelleBtn.Image = CType(resources.GetObject("GuncelleBtn.Image"), System.Drawing.Image)
        Me.GuncelleBtn.Location = New System.Drawing.Point(134, 450)
        Me.GuncelleBtn.Name = "GuncelleBtn"
        Me.GuncelleBtn.Size = New System.Drawing.Size(69, 67)
        Me.GuncelleBtn.TabIndex = 52
        Me.GuncelleBtn.Text = "Güncelle"
        Me.GuncelleBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.GuncelleBtn.UseVisualStyleBackColor = True
        '
        'EkleBtn
        '
        Me.EkleBtn.Image = CType(resources.GetObject("EkleBtn.Image"), System.Drawing.Image)
        Me.EkleBtn.Location = New System.Drawing.Point(24, 450)
        Me.EkleBtn.Name = "EkleBtn"
        Me.EkleBtn.Size = New System.Drawing.Size(69, 67)
        Me.EkleBtn.TabIndex = 51
        Me.EkleBtn.Text = "Ekle"
        Me.EkleBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.EkleBtn.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(439, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 16)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Personel Adı : "
        '
        'AraTBox
        '
        Me.AraTBox.Location = New System.Drawing.Point(545, 74)
        Me.AraTBox.Name = "AraTBox"
        Me.AraTBox.Size = New System.Drawing.Size(325, 22)
        Me.AraTBox.TabIndex = 49
        '
        'PersonelAraBtn
        '
        Me.PersonelAraBtn.Location = New System.Drawing.Point(886, 70)
        Me.PersonelAraBtn.Name = "PersonelAraBtn"
        Me.PersonelAraBtn.Size = New System.Drawing.Size(82, 26)
        Me.PersonelAraBtn.TabIndex = 48
        Me.PersonelAraBtn.Text = "Ara"
        Me.PersonelAraBtn.UseVisualStyleBackColor = True
        '
        'StokDGV
        '
        Me.StokDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.StokDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StokDGV.Location = New System.Drawing.Point(442, 102)
        Me.StokDGV.Name = "StokDGV"
        Me.StokDGV.RowHeadersWidth = 51
        Me.StokDGV.RowTemplate.Height = 24
        Me.StokDGV.Size = New System.Drawing.Size(526, 395)
        Me.StokDGV.TabIndex = 47
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AdTBox)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.CalısanIDTBox)
        Me.GroupBox1.Controls.Add(Me.PozisyonTBox)
        Me.GroupBox1.Controls.Add(Me.TelefonTBox)
        Me.GroupBox1.Controls.Add(Me.SoyadTBox)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 102)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 342)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        '
        'AdTBox
        '
        Me.AdTBox.Location = New System.Drawing.Point(191, 85)
        Me.AdTBox.Name = "AdTBox"
        Me.AdTBox.Size = New System.Drawing.Size(100, 22)
        Me.AdTBox.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(85, 85)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 16)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Adı :"
        '
        'CalısanIDTBox
        '
        Me.CalısanIDTBox.Location = New System.Drawing.Point(191, 221)
        Me.CalısanIDTBox.Name = "CalısanIDTBox"
        Me.CalısanIDTBox.Size = New System.Drawing.Size(100, 22)
        Me.CalısanIDTBox.TabIndex = 11
        '
        'PozisyonTBox
        '
        Me.PozisyonTBox.Location = New System.Drawing.Point(191, 187)
        Me.PozisyonTBox.Name = "PozisyonTBox"
        Me.PozisyonTBox.Size = New System.Drawing.Size(100, 22)
        Me.PozisyonTBox.TabIndex = 9
        '
        'TelefonTBox
        '
        Me.TelefonTBox.Location = New System.Drawing.Point(191, 153)
        Me.TelefonTBox.Name = "TelefonTBox"
        Me.TelefonTBox.Size = New System.Drawing.Size(100, 22)
        Me.TelefonTBox.TabIndex = 8
        '
        'SoyadTBox
        '
        Me.SoyadTBox.Location = New System.Drawing.Point(191, 119)
        Me.SoyadTBox.Name = "SoyadTBox"
        Me.SoyadTBox.Size = New System.Drawing.Size(100, 22)
        Me.SoyadTBox.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(85, 225)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Çalışan ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(85, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Pozisyonu:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(85, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Telefonu:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(85, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Soyadı:"
        '
        'Personel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1016, 544)
        Me.Controls.Add(Me.TemizleBtn)
        Me.Controls.Add(Me.ListeleBtn)
        Me.Controls.Add(Me.GuncelleBtn)
        Me.Controls.Add(Me.EkleBtn)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.AraTBox)
        Me.Controls.Add(Me.PersonelAraBtn)
        Me.Controls.Add(Me.StokDGV)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Personel"
        Me.Text = "Personel"
        CType(Me.StokDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TemizleBtn As Button
    Friend WithEvents ListeleBtn As Button
    Friend WithEvents GuncelleBtn As Button
    Friend WithEvents EkleBtn As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents AraTBox As TextBox
    Friend WithEvents PersonelAraBtn As Button
    Friend WithEvents StokDGV As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents AdTBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents CalısanIDTBox As TextBox
    Friend WithEvents PozisyonTBox As TextBox
    Friend WithEvents TelefonTBox As TextBox
    Friend WithEvents SoyadTBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
