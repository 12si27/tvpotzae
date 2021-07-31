Public Class Options

    '커스텀 컨트롤박스 시작
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

    Private Sub Clipboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim showx = Form1.Location.X + Form1.Size.Width / 2 - Me.Size.Width / 2
        Dim showy = Form1.Location.Y + Form1.Size.Height / 2 - Me.Size.Height / 2
        Me.SetDesktopLocation(showx, showy)

        Try
            NumericUpDown2.Value = My.Settings.copy_delay
            CheckBox1.Checked = My.Settings.oldcopyway
            CheckBox3.Checked = My.Settings.dontcheck
        Catch
            MsgBox("설정 값에 문제가 있습니다. 기본값으로 초기화합니다.")
            NumericUpDown2.Value = 150
            CheckBox1.Checked = False
            CheckBox3.Checked = False
        End Try

        If CheckBox1.Checked Then
            Label3.Enabled = True
            Label6.Enabled = True
            NumericUpDown2.Enabled = True
        Else
            Label3.Enabled = False
            Label6.Enabled = False
            NumericUpDown2.Enabled = False
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.copy_delay = NumericUpDown2.Value
        My.Settings.oldcopyway = CheckBox1.Checked
        My.Settings.dontcheck = CheckBox3.Checked
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        NumericUpDown2.Value = 150
        CheckBox1.Checked = False
        CheckBox3.Checked = False

        MsgBox("'적용' 버튼을 눌러 설정을 저장해 주세요.", vbInformation)
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("http://lis.anipotdb.ze.am/")
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Label3.Enabled = True
            Label6.Enabled = True
            NumericUpDown2.Enabled = True
        Else
            Label3.Enabled = False
            Label6.Enabled = False
            NumericUpDown2.Enabled = False
        End If
    End Sub
End Class