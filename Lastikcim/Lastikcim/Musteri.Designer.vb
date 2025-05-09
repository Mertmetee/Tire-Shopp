<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Musteri
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Musteri))
        Me.TemizleBtn = New System.Windows.Forms.Button()
        Me.ListeleBtn = New System.Windows.Forms.Button()
        Me.GuncelleBtn = New System.Windows.Forms.Button()
        Me.EkleBtn = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MusteriAraTBox = New System.Windows.Forms.TextBox()
        Me.MusteriAraBtn = New System.Windows.Forms.Button()
        Me.MusteriDGV = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AdiTBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GirisTarihiDTP = New System.Windows.Forms.DateTimePicker()
        Me.EpostaTBox = New System.Windows.Forms.TextBox()
        Me.MusteriidTbox = New System.Windows.Forms.TextBox()
        Me.TelefonTBox = New System.Windows.Forms.TextBox()
        Me.SoyadiTBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.MusteriDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TemizleBtn
        '
        Me.TemizleBtn.Image = CType(resources.GetObject("TemizleBtn.Image"), System.Drawing.Image)
        Me.TemizleBtn.Location = New System.Drawing.Point(238, 427)
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
        Me.ListeleBtn.Location = New System.Drawing.Point(345, 427)
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
        Me.GuncelleBtn.Location = New System.Drawing.Point(126, 427)
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
        Me.EkleBtn.Location = New System.Drawing.Point(16, 427)
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
        Me.Label8.Location = New System.Drawing.Point(431, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 16)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Adı Soyadı:"
        '
        'MusteriAraTBox
        '
        Me.MusteriAraTBox.Location = New System.Drawing.Point(537, 51)
        Me.MusteriAraTBox.Name = "MusteriAraTBox"
        Me.MusteriAraTBox.Size = New System.Drawing.Size(325, 22)
        Me.MusteriAraTBox.TabIndex = 49
        '
        'MusteriAraBtn
        '
        Me.MusteriAraBtn.Location = New System.Drawing.Point(878, 47)
        Me.MusteriAraBtn.Name = "MusteriAraBtn"
        Me.MusteriAraBtn.Size = New System.Drawing.Size(82, 26)
        Me.MusteriAraBtn.TabIndex = 48
        Me.MusteriAraBtn.Text = "Ara"
        Me.MusteriAraBtn.UseVisualStyleBackColor = True
        '
        'MusteriDGV
        '
        Me.MusteriDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MusteriDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MusteriDGV.Location = New System.Drawing.Point(434, 79)
        Me.MusteriDGV.Name = "MusteriDGV"
        Me.MusteriDGV.RowHeadersWidth = 51
        Me.MusteriDGV.RowTemplate.Height = 24
        Me.MusteriDGV.Size = New System.Drawing.Size(526, 395)
        Me.MusteriDGV.TabIndex = 47
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AdiTBox)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.GirisTarihiDTP)
        Me.GroupBox1.Controls.Add(Me.EpostaTBox)
        Me.GroupBox1.Controls.Add(Me.MusteriidTbox)
        Me.GroupBox1.Controls.Add(Me.TelefonTBox)
        Me.GroupBox1.Controls.Add(Me.SoyadiTBox)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 342)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        '
        'AdiTBox
        '
        Me.AdiTBox.Location = New System.Drawing.Point(147, 39)
        Me.AdiTBox.Name = "AdiTBox"
        Me.AdiTBox.Size = New System.Drawing.Size(100, 22)
        Me.AdiTBox.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(21, 45)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 16)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Adı:"
        '
        'GirisTarihiDTP
        '
        Me.GirisTarihiDTP.Location = New System.Drawing.Point(147, 208)
        Me.GirisTarihiDTP.Name = "GirisTarihiDTP"
        Me.GirisTarihiDTP.Size = New System.Drawing.Size(200, 22)
        Me.GirisTarihiDTP.TabIndex = 12
        '
        'EpostaTBox
        '
        Me.EpostaTBox.Location = New System.Drawing.Point(147, 144)
        Me.EpostaTBox.Name = "EpostaTBox"
        Me.EpostaTBox.Size = New System.Drawing.Size(100, 22)
        Me.EpostaTBox.TabIndex = 10
        '
        'MusteriidTbox
        '
        Me.MusteriidTbox.Location = New System.Drawing.Point(147, 174)
        Me.MusteriidTbox.Name = "MusteriidTbox"
        Me.MusteriidTbox.Size = New System.Drawing.Size(100, 22)
        Me.MusteriidTbox.TabIndex = 9
        '
        'TelefonTBox
        '
        Me.TelefonTBox.Location = New System.Drawing.Point(147, 105)
        Me.TelefonTBox.Name = "TelefonTBox"
        Me.TelefonTBox.Size = New System.Drawing.Size(100, 22)
        Me.TelefonTBox.TabIndex = 8
        '
        'SoyadiTBox
        '
        Me.SoyadiTBox.Location = New System.Drawing.Point(147, 72)
        Me.SoyadiTBox.Name = "SoyadiTBox"
        Me.SoyadiTBox.Size = New System.Drawing.Size(100, 22)
        Me.SoyadiTBox.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Giriş Tarihi : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Müşteri ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Eposta :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Telefonu"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Soyadı:"
        '
        'Musteri
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1089, 587)
        Me.Controls.Add(Me.TemizleBtn)
        Me.Controls.Add(Me.ListeleBtn)
        Me.Controls.Add(Me.GuncelleBtn)
        Me.Controls.Add(Me.EkleBtn)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.MusteriAraTBox)
        Me.Controls.Add(Me.MusteriAraBtn)
        Me.Controls.Add(Me.MusteriDGV)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Musteri"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Musteri"
        CType(Me.MusteriDGV, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents MusteriAraTBox As TextBox
    Friend WithEvents MusteriAraBtn As Button
    Friend WithEvents MusteriDGV As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents AdiTBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GirisTarihiDTP As DateTimePicker
    Friend WithEvents EpostaTBox As TextBox
    Friend WithEvents MusteriidTbox As TextBox
    Friend WithEvents TelefonTBox As TextBox
    Friend WithEvents SoyadiTBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
