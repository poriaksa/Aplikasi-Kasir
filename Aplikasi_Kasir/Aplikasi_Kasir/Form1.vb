Imports System.Drawing.Printing

Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub cmbbarang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbarang.SelectedIndexChanged
        If cmbbarang.Text = "Kertas A4" Then
            txtharga.Text = 60000
        ElseIf cmbbarang.Text = "Kertas F4" Then
            txtharga.Text = 65000
        ElseIf cmbbarang.Text = "Kertas Kalkir" Then
            txtharga.Text = 120000
        ElseIf cmbbarang.Text = "Buku Gambar" Then
            txtharga.Text = 25000
        ElseIf cmbbarang.Text = "Buku Agenda" Then
            txtharga.Text = 150000
        ElseIf cmbbarang.Text = "Buku Cetak Pemrograman Visual" Then
            txtharga.Text = 250000
        End If


    End Sub
    Private Sub txtharga_TextChanged(sender As Object, e As EventArgs) Handles txtharga.TextChanged

    End Sub

    Private Sub txtsubtotal_TextChanged(sender As Object, e As EventArgs) Handles txtsubtotal.TextChanged

    End Sub

    Private Sub btnsubtotal_Click(sender As Object, e As EventArgs) Handles btnsubtotal.Click
        txtsubtotal.Text = txtharga.Text * txtjumlah.Text

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            txtdiskon.Text = 15
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            txtdiskon.Text = 10
        End If

    End Sub

    Private Sub btntotal_Click(sender As Object, e As EventArgs) Handles btntotal.Click
        txttotal.Text = txtsubtotal.Text - (txtsubtotal.Text * txtdiskon.Text) / 100
    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        cmbbarang.Text = ""
        txtharga.Text = ""
        txtjumlah.Text = ""
        txtsubtotal.Text = ""
        txtdiskon.Text = ""
        txttotal.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False


    End Sub

    Private Sub btntutupaplikasi_Click(sender As Object, e As EventArgs) Handles btntutupaplikasi.Click
        Me.Close()

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            txtdiskon.Text = 0
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = TimeOfDay
        Label3.Text = Today

    End Sub

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        Dim printDoc As New PrintDocument

        AddHandler printDoc.PrintPage, AddressOf PrintPageHandler
        Dim printDialog As New PrintDialog
        printDialog.Document = printDoc

        If printDialog.ShowDialog = DialogResult.OK Then
           
            printDoc.Print()


            printDoc.Print()



        End If
    End Sub

    Private Sub PrintPageHandler(sender As Object, e As PrintPageEventArgs)
        Dim printcontent As String = "Daftar/Kwitansi Belanja Toko Buku Porlak Gorga:" & vbCrLf &
            "Barang: " & cmbbarang.Text & vbCrLf &
            "Harga: " & txtharga.Text & vbCrLf &
            "Jumlah: " & txtjumlah.Text & vbCrLf &
            "Subtotal: " & txtsubtotal.Text & vbCrLf &
            "Diskon: " & txtdiskon.Text & vbCrLf &
            "Total: " & txttotal.Text & vbCrLf &
            "Waktu: " & Label2.Text & vbCrLf &
            "Tanggal: " & Label3.Text()

        e.Graphics.DrawString(printcontent, New Font("Arial", 12), Brushes.Black, 10, 10)


    End Sub
End Class
