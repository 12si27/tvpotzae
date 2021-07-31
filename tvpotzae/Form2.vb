Public Class Form2
    '커스텀 컨트롤박스 시작
    Dim loc As Point
    Dim activedcolor As Color = Color.FromArgb(0, 176, 255)
    Dim disabledcolor As Color = Color.FromArgb(96, 96, 96)

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            loc = e.Location
        End If
    End Sub

    Private Sub PictureBox1_MouseMove_1(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += e.Location - loc
        End If
    End Sub

    Private Sub bt_close_Click(sender As Object, e As EventArgs) Handles bt_close.Click
        Me.Close()
    End Sub

    Private Sub bt_min_Click(sender As Object, e As EventArgs) Handles bt_min.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub bt_min_MouseEnter(sender As Object, e As EventArgs) Handles bt_min.MouseEnter
        bt_min.BackColor = Color.FromArgb(69, 69, 69)
    End Sub

    Private Sub bt_min_MouseLeave(sender As Object, e As EventArgs) Handles bt_min.MouseLeave
        bt_min.BackColor = Color.FromArgb(120, 120, 120)
    End Sub

    Private Sub bt_close_MouseEnter(sender As Object, e As EventArgs) Handles bt_close.MouseEnter
        bt_close.BackColor = Color.FromArgb(69, 69, 69)
    End Sub

    Private Sub bt_close_MouseLeave(sender As Object, e As EventArgs) Handles bt_close.MouseLeave
        bt_close.BackColor = Color.FromArgb(120, 120, 120)
    End Sub
    '커스텀 컨트롤박스 끝

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim showx = Form1.Location.X + Form1.Size.Width / 2 - Me.Size.Width / 2
        Dim showy = Form1.Location.Y + Form1.Size.Height / 2 - Me.Size.Height / 2
        Me.SetDesktopLocation(showx, showy)

        RichTextBox1.SelectAll()
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub RichTextBox1_Enter(sender As Object, e As EventArgs) Handles RichTextBox1.Enter
        CopyBoxBackPanel.BackColor = activedcolor
    End Sub

    Private Sub RichTextBox1_Leave(sender As Object, e As EventArgs) Handles RichTextBox1.Leave
        CopyBoxBackPanel.BackColor = disabledcolor
    End Sub

    Private Sub Label4_Paint(sender As Object, e As PaintEventArgs) Handles WarnLabel.Paint
        WarnLabel.Location = New Point((Me.Width - WarnLabel.Width) / 2, WarnLabel.Location.Y)
    End Sub
End Class