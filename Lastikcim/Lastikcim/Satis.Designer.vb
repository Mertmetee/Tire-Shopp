<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Satis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Satis))
        Me.TemizleBtn = New System.Windows.Forms.Button()
        Me.ListeleBtn = New System.Windows.Forms.Button()
        Me.GuncelleBtn = New System.Windows.Forms.Button()
        Me.EkleBtn = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MalzemeAraTBox = New System.Windows.Forms.TextBox()
        Me.MalzemeAraBtn = New System.Windows.Forms.Button()
        Me.StokDGV = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.StokIDTBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.KalanStokTBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CikisTarihiDTP = New System.Windows.Forms.DateTimePicker()
        Me.GirisTarihiDTP = New System.Windows.Forms.DateTimePicker()
        Me.CikanMiktarTBox = New System.Windows.Forms.TextBox()
        Me.BirimTBox = New System.Windows.Forms.TextBox()
        Me.MalzemeAdiTBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.StokDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TemizleBtn
        '
        Me.TemizleBtn.Image = CType(resources.GetObject("TemizleBtn.Image"), System.Drawing.Image)
        Me.TemizleBtn.Location = New System.Drawing.Point(250, 424)
        Me.TemizleBtn.Name = "TemizleBtn"
        Me.TemizleBtn.Size = New System.Drawing.Size(69, 67)
        Me.TemizleBtn.TabIndex = 45
        Me.TemizleBtn.Text = "Temizle"
        Me.TemizleBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.TemizleBtn.UseVisualStyleBackColor = True
        '
        'ListeleBtn
        '
        Me.ListeleBtn.Image = CType(resources.GetObject("ListeleBtn.Image"), System.Drawing.Image)
        Me.ListeleBtn.Location = New System.Drawing.Point(357, 424)
        Me.ListeleBtn.Name = "ListeleBtn"
        Me.ListeleBtn.Size = New System.Drawing.Size(69, 67)
        Me.ListeleBtn.TabIndex = 44
        Me.ListeleBtn.Text = "Listele"
        Me.ListeleBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.ListeleBtn.UseVisualStyleBackColor = True
        '
        'GuncelleBtn
        '
        Me.GuncelleBtn.Image = CType(resources.GetObject("GuncelleBtn.Image"), System.Drawing.Image)
        Me.GuncelleBtn.Location = New System.Drawing.Point(138, 424)
        Me.GuncelleBtn.Name = "GuncelleBtn"
        Me.GuncelleBtn.Size = New System.Drawing.Size(69, 67)
        Me.GuncelleBtn.TabIndex = 43
        Me.GuncelleBtn.Text = "Güncelle"
        Me.GuncelleBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.GuncelleBtn.UseVisualStyleBackColor = True
        '
        'EkleBtn
        '
        Me.EkleBtn.Image = CType(resources.GetObject("EkleBtn.Image"), System.Drawing.Image)
        Me.EkleBtn.Location = New System.Drawing.Point(28, 424)
        Me.EkleBtn.Name = "EkleBtn"
        Me.EkleBtn.Size = New System.Drawing.Size(69, 67)
        Me.EkleBtn.TabIndex = 42
        Me.EkleBtn.Text = "Ekle"
        Me.EkleBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.EkleBtn.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(445, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 16)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = " Adı : "
        '
        'MalzemeAraTBox
        '
        Me.MalzemeAraTBox.Location = New System.Drawing.Point(551, 48)
        Me.MalzemeAraTBox.Name = "MalzemeAraTBox"
        Me.MalzemeAraTBox.Size = New System.Drawing.Size(325, 22)
        Me.MalzemeAraTBox.TabIndex = 40
        '
        'MalzemeAraBtn
        '
        Me.MalzemeAraBtn.Location = New System.Drawing.Point(892, 44)
        Me.MalzemeAraBtn.Name = "MalzemeAraBtn"
        Me.MalzemeAraBtn.Size = New System.Drawing.Size(82, 26)
        Me.MalzemeAraBtn.TabIndex = 39
        Me.MalzemeAraBtn.Text = "Ara"
        Me.MalzemeAraBtn.UseVisualStyleBackColor = True
        '
        'StokDGV
        '
        Me.StokDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.StokDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StokDGV.Location = New System.Drawing.Point(448, 76)
        Me.StokDGV.Name = "StokDGV"
        Me.StokDGV.RowHeadersWidth = 51
        Me.StokDGV.RowTemplate.Height = 24
        Me.StokDGV.Size = New System.Drawing.Size(526, 415)
        Me.StokDGV.TabIndex = 38
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.StokIDTBox)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.KalanStokTBox)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.CikisTarihiDTP)
        Me.GroupBox1.Controls.Add(Me.GirisTarihiDTP)
        Me.GroupBox1.Controls.Add(Me.CikanMiktarTBox)
        Me.GroupBox1.Controls.Add(Me.BirimTBox)
        Me.GroupBox1.Controls.Add(Me.MalzemeAdiTBox)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 342)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        '
        'StokIDTBox
        '
        Me.StokIDTBox.Location = New System.Drawing.Point(147, 58)
        Me.StokIDTBox.Name = "StokIDTBox"
        Me.StokIDTBox.Size = New System.Drawing.Size(100, 22)
        Me.StokIDTBox.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(19, 61)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 16)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "StokID :"
        '
        'KalanStokTBox
        '
        Me.KalanStokTBox.Location = New System.Drawing.Point(147, 280)
        Me.KalanStokTBox.Name = "KalanStokTBox"
        Me.KalanStokTBox.Size = New System.Drawing.Size(100, 22)
        Me.KalanStokTBox.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 289)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 16)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Kalan Stok Miktarı:"
        '
        'CikisTarihiDTP
        '
        Me.CikisTarihiDTP.Location = New System.Drawing.Point(147, 243)
        Me.CikisTarihiDTP.Name = "CikisTarihiDTP"
        Me.CikisTarihiDTP.Size = New System.Drawing.Size(200, 22)
        Me.CikisTarihiDTP.TabIndex = 13
        '
        'GirisTarihiDTP
        '
        Me.GirisTarihiDTP.Location = New System.Drawing.Point(147, 206)
        Me.GirisTarihiDTP.Name = "GirisTarihiDTP"
        Me.GirisTarihiDTP.Size = New System.Drawing.Size(200, 22)
        Me.GirisTarihiDTP.TabIndex = 12
        '
        'CikanMiktarTBox
        '
        Me.CikanMiktarTBox.Location = New System.Drawing.Point(147, 169)
        Me.CikanMiktarTBox.Name = "CikanMiktarTBox"
        Me.CikanMiktarTBox.Size = New System.Drawing.Size(100, 22)
        Me.CikanMiktarTBox.TabIndex = 11
        '
        'BirimTBox
        '
        Me.BirimTBox.Location = New System.Drawing.Point(147, 95)
        Me.BirimTBox.Name = "BirimTBox"
        Me.BirimTBox.Size = New System.Drawing.Size(100, 22)
        Me.BirimTBox.TabIndex = 9
        '
        'MalzemeAdiTBox
        '
        Me.MalzemeAdiTBox.Location = New System.Drawing.Point(147, 132)
        Me.MalzemeAdiTBox.Name = "MalzemeAdiTBox"
        Me.MalzemeAdiTBox.Size = New System.Drawing.Size(100, 22)
        Me.MalzemeAdiTBox.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 251)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Çıkış Tarihi : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 213)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Giriş Tarihi : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Çıkan Miktar :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Birim :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Malzeme Adı :"
        '
        'Satis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1021, 533)
        Me.Controls.Add(Me.TemizleBtn)
        Me.Controls.Add(Me.ListeleBtn)
        Me.Controls.Add(Me.GuncelleBtn)
        Me.Controls.Add(Me.EkleBtn)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.MalzemeAraTBox)
        Me.Controls.Add(Me.MalzemeAraBtn)
        Me.Controls.Add(Me.StokDGV)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Satis"
        Me.Text = "Satis"
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
    Friend WithEvents MalzemeAraTBox As TextBox
    Friend WithEvents MalzemeAraBtn As Button
    Friend WithEvents StokDGV As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents StokIDTBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents KalanStokTBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents CikisTarihiDTP As DateTimePicker
    Friend WithEvents GirisTarihiDTP As DateTimePicker
    Friend WithEvents CikanMiktarTBox As TextBox
    Friend WithEvents BirimTBox As TextBox
    Friend WithEvents MalzemeAdiTBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
