Public Class Form1
    Dim indo, usa As String
#Region "messages"
    'Hallo Shifu.. Selamat mengembangkan..
    'Hak karyanya jangan dihilangkan ya.. Terimakasih..
#End Region
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.TextAlign = HorizontalAlignment.Center

        '///////// VARIABLE /////////'
        indo = "Indonesia (IDR)"
        usa = "USA (Dolar)"
        '//////////////////////////'

        With cmb_dari.Items  '// Combobox Dari
            .Add(usa) 'index 0
            .Add(indo) 'index 1
        End With

        With cmb_ke.Items '// Combobox Ke
            .Add(indo) ' index 0
            .Add(usa) ' index 1
        End With
    End Sub

    Private Sub btnConvert(sender As Object, e As EventArgs) Handles Button1.Click
        'penjelasan
        ' 1 dolar = 14350rb (rupiah)

        If TextBox1.Text = "" Then
            MessageBox.Show(
                            "Value belum dimasukan!", "", MessageBoxButtons.OK,
                                                                MessageBoxIcon.Error
                                )
            TextBox1.Focus()
        ElseIf Not IsNumeric(TextBox1.Text) Then
            MessageBox.Show(
                            "Numberic!!!", "", MessageBoxButtons.OK,
                                                                MessageBoxIcon.Error
                            )
            TextBox1.Clear()
            TextBox1.Focus()
        ElseIf cmb_dari.Text = "" Or
                        cmb_ke.Text = "" Then
            MessageBox.Show(
                            "Anda Belum memilih data" & vbNewLine & "Silahkan memilih data yang ingin di Convert!",
                            "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation
                            )
        ElseIf cmb_dari.Text = usa And cmb_ke.Text = usa Or
             cmb_dari.Text = indo And cmb_ke.Text = indo Then
            MessageBox.Show(
                            "Data Tidak Boleh Sama!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation
                            )
        Else

            Dim dolar = 14100, tampil As Integer
            Dim _double = 1, _tampil As Double '// < convert 0,

            If cmb_dari.SelectedIndex = 0 And cmb_ke.SelectedIndex = 0 Then
                tampil = Val(TextBox1.Text) * dolar
                MsgBox(
                        "Hasil Conversi dari " & usa & " > " & indo & vbNewLine &
                        tampil & " Rupiah", MsgBoxStyle.Information, ""
                        )
            ElseIf cmb_dari.SelectedIndex = 1 And cmb_ke.SelectedIndex = 1 Then
                _tampil = _double / Val(TextBox1.Text)
                MsgBox(
                       "Hasil Conversi dari " & indo & " > " & usa & vbNewLine _
                       & _tampil & " Dolar", MsgBoxStyle.Information, ""
                        )
            End If
        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("https://www.facebook.com/PoetralesanA")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://www.github.com/PoetralesanA")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        MsgBox("./PoetralesanA", MsgBoxStyle.Information, "n00b Coderz")
    End Sub
End Class
