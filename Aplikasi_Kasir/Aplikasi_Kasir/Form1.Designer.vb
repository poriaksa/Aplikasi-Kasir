<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Label1 = New Label()
        cmbbarang = New ComboBox()
        txtharga = New TextBox()
        txtjumlah = New TextBox()
        txtsubtotal = New TextBox()
        barang = New Label()
        harga = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        btnsubtotal = New Button()
        txtdiskon = New TextBox()
        txttotal = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        btnreset = New Button()
        btntutupaplikasi = New Button()
        btntotal = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Timer1 = New Timer(components)
        Label9 = New Label()
        Label10 = New Label()
        btnprint = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(344, 32)
        Label1.TabIndex = 0
        Label1.Text = "TOKO BUKU PORLAK GORGA"
        ' 
        ' cmbbarang
        ' 
        cmbbarang.FormattingEnabled = True
        cmbbarang.Items.AddRange(New Object() {"Kertas A4", "Kertas F4", "Kertas Kalkir", "Buku Gambar", "Buku Agenda", "Buku Cetak Pemrograman Visual"})
        cmbbarang.Location = New Point(175, 87)
        cmbbarang.Name = "cmbbarang"
        cmbbarang.RightToLeft = RightToLeft.No
        cmbbarang.Size = New Size(219, 23)
        cmbbarang.TabIndex = 1
        ' 
        ' txtharga
        ' 
        txtharga.Location = New Point(175, 136)
        txtharga.Name = "txtharga"
        txtharga.RightToLeft = RightToLeft.No
        txtharga.Size = New Size(100, 23)
        txtharga.TabIndex = 2
        ' 
        ' txtjumlah
        ' 
        txtjumlah.Location = New Point(175, 181)
        txtjumlah.Name = "txtjumlah"
        txtjumlah.RightToLeft = RightToLeft.No
        txtjumlah.Size = New Size(100, 23)
        txtjumlah.TabIndex = 3
        ' 
        ' txtsubtotal
        ' 
        txtsubtotal.Location = New Point(175, 224)
        txtsubtotal.Name = "txtsubtotal"
        txtsubtotal.RightToLeft = RightToLeft.No
        txtsubtotal.Size = New Size(100, 23)
        txtsubtotal.TabIndex = 4
        ' 
        ' barang
        ' 
        barang.AutoSize = True
        barang.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        barang.Location = New Point(93, 88)
        barang.Name = "barang"
        barang.Size = New Size(61, 17)
        barang.TabIndex = 5
        barang.Text = "BARANG"
        ' 
        ' harga
        ' 
        harga.AutoSize = True
        harga.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        harga.Location = New Point(93, 142)
        harga.Name = "harga"
        harga.Size = New Size(53, 17)
        harga.TabIndex = 6
        harga.Text = "HARGA"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(93, 184)
        Label4.Name = "Label4"
        Label4.Size = New Size(61, 17)
        Label4.TabIndex = 7
        Label4.Text = "JUMLAH"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(93, 225)
        Label5.Name = "Label5"
        Label5.Size = New Size(76, 17)
        Label5.TabIndex = 8
        Label5.Text = "SUB TOTAL"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(93, 297)
        Label6.Name = "Label6"
        Label6.Size = New Size(57, 17)
        Label6.TabIndex = 9
        Label6.Text = "DISKON"
        ' 
        ' btnsubtotal
        ' 
        btnsubtotal.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnsubtotal.Location = New Point(175, 253)
        btnsubtotal.Name = "btnsubtotal"
        btnsubtotal.Size = New Size(85, 23)
        btnsubtotal.TabIndex = 10
        btnsubtotal.Text = "SUB TOTAL"
        btnsubtotal.UseVisualStyleBackColor = True
        ' 
        ' txtdiskon
        ' 
        txtdiskon.Location = New Point(160, 296)
        txtdiskon.Name = "txtdiskon"
        txtdiskon.RightToLeft = RightToLeft.No
        txtdiskon.Size = New Size(100, 23)
        txtdiskon.TabIndex = 11
        ' 
        ' txttotal
        ' 
        txttotal.Location = New Point(160, 336)
        txttotal.Name = "txttotal"
        txttotal.RightToLeft = RightToLeft.No
        txttotal.Size = New Size(100, 23)
        txttotal.TabIndex = 12
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(93, 339)
        Label7.Name = "Label7"
        Label7.Size = New Size(48, 17)
        Label7.TabIndex = 13
        Label7.Text = "TOTAL"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(619, 93)
        Label8.Name = "Label8"
        Label8.Size = New Size(57, 17)
        Label8.TabIndex = 14
        Label8.Text = "DISKON"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RadioButton1.Location = New Point(619, 113)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(49, 19)
        RadioButton1.TabIndex = 15
        RadioButton1.TabStop = True
        RadioButton1.Text = "15%"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RadioButton2.Location = New Point(619, 136)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(49, 19)
        RadioButton2.TabIndex = 16
        RadioButton2.TabStop = True
        RadioButton2.Text = "10%"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RadioButton3.Location = New Point(619, 161)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(121, 19)
        RadioButton3.TabIndex = 17
        RadioButton3.TabStop = True
        RadioButton3.Text = "HARGA NORMAL"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' btnreset
        ' 
        btnreset.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnreset.Location = New Point(334, 387)
        btnreset.Name = "btnreset"
        btnreset.Size = New Size(75, 23)
        btnreset.TabIndex = 18
        btnreset.Text = "RESET"
        btnreset.UseVisualStyleBackColor = True
        ' 
        ' btntutupaplikasi
        ' 
        btntutupaplikasi.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btntutupaplikasi.Location = New Point(539, 387)
        btntutupaplikasi.Name = "btntutupaplikasi"
        btntutupaplikasi.Size = New Size(123, 23)
        btntutupaplikasi.TabIndex = 19
        btntutupaplikasi.Text = "TUTUP APLIKASI"
        btntutupaplikasi.UseVisualStyleBackColor = True
        ' 
        ' btntotal
        ' 
        btntotal.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btntotal.Location = New Point(175, 365)
        btntotal.Name = "btntotal"
        btntotal.Size = New Size(75, 23)
        btntotal.TabIndex = 20
        btntotal.Text = "TOTAL"
        btntotal.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(619, 26)
        Label2.Name = "Label2"
        Label2.RightToLeft = RightToLeft.No
        Label2.Size = New Size(43, 15)
        Label2.TabIndex = 21
        Label2.Text = "Label2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(510, 26)
        Label3.Name = "Label3"
        Label3.RightToLeft = RightToLeft.No
        Label3.Size = New Size(43, 15)
        Label3.TabIndex = 22
        Label3.Text = "Label3"
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1000
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(515, 9)
        Label9.Name = "Label9"
        Label9.RightToLeft = RightToLeft.No
        Label9.Size = New Size(49, 15)
        Label9.TabIndex = 23
        Label9.Text = "Tanggal"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(619, 9)
        Label10.Name = "Label10"
        Label10.RightToLeft = RightToLeft.No
        Label10.Size = New Size(44, 15)
        Label10.TabIndex = 24
        Label10.Text = "Waktu"
        ' 
        ' btnprint
        ' 
        btnprint.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnprint.Location = New Point(430, 387)
        btnprint.Name = "btnprint"
        btnprint.Size = New Size(84, 23)
        btnprint.TabIndex = 19
        btnprint.Text = "PRINT"
        btnprint.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(797, 420)
        Controls.Add(btnprint)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(btntotal)
        Controls.Add(btntutupaplikasi)
        Controls.Add(btnreset)
        Controls.Add(RadioButton3)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(txttotal)
        Controls.Add(txtdiskon)
        Controls.Add(btnsubtotal)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(harga)
        Controls.Add(barang)
        Controls.Add(txtsubtotal)
        Controls.Add(txtjumlah)
        Controls.Add(txtharga)
        Controls.Add(cmbbarang)
        Controls.Add(Label1)
        Name = "Form1"
        RightToLeft = RightToLeft.Yes
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmbbarang As ComboBox
    Friend WithEvents txtharga As TextBox
    Friend WithEvents txtjumlah As TextBox
    Friend WithEvents txtsubtotal As TextBox
    Friend WithEvents barang As Label
    Friend WithEvents harga As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnsubtotal As Button
    Friend WithEvents txtdiskon As TextBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents btnreset As Button
    Friend WithEvents btntutupaplikasi As Button
    Friend WithEvents btntotal As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnprint As Button

End Class
