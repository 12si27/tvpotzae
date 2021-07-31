Imports System.Net
Imports System.IO

Public Class Form1
    Dim buttondefault = 69
    Dim buttonactive = 120
    Dim down_btdefault As Color = Color.FromArgb(148, 187, 41)
    Dim down_btactive As Color = Color.FromArgb(178, 206, 101)
    Dim anicomplete = False
    Dim isdebug = False

    Dim loc As Point

    Dim col() = {255, 255, 255, 255, 255, 255}
    Dim goalcolor() = {buttondefault, buttondefault, buttondefault, buttondefault, buttondefault, buttondefault}
    Dim fademode() = {1, 1, 1, 1, 1, 1}

    Dim currentpage As Integer = 1 '탐색 페이지
    Dim source As String 'json 해싱 string
    Dim tmplist As ListViewItem '처리용 임시 리스트

    '===== 탐색 변수 =====
    Dim issearching = False '탐색상태
    Dim searchingtype As Integer = 0 '탐색종류 (팟, 플레이리스트)
    Dim potname As String = Nothing '팟 이름
    Dim potimage As Bitmap = Nothing '팟 썸네일

    '===== 복사 변수 =====
    Dim copyingNum As Integer = 0
    Dim copyingchecked As Boolean = False
    Dim copyingdelay As Integer = 150


    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim i = 1

        If col(i) > buttonactive Then
            col(i) = col(i) - 5
            BTB2.BackColor = Color.FromArgb(col(i), col(i), col(i))
            GoTo stopani2
        End If

        If Not fademode(i) = 0 Then
            If fademode(i) = 1 Then
                If col(i) <= goalcolor(i) Then
                    fademode(i) = 0
                    col(i) = goalcolor(i)
                    GoTo stopani2
                End If

                col(i) = col(i) - 5

            ElseIf fademode(i) = 2 Then
                If col(i) >= buttonactive Then
                    col(i) = goalcolor(i)
                    fademode(i) = 1
                End If

                col(i) = col(i) + 5

                If col(i) >= goalcolor(i) Then
                    fademode(i) = 0
                    col(i) = goalcolor(i)
                    GoTo stopani2
                End If
            End If
stopani2:
            If Not col(i) >= 255 Then
                BTB1.BackColor = Color.FromArgb(col(i), col(i), col(i))
            End If
        End If

        i += 1

        If col(i) > buttonactive Then
            col(i) = col(i) - 5
            BTB1.BackColor = Color.FromArgb(col(i), col(i), col(i))
            GoTo stopani3
        End If

        If Not fademode(i) = 0 Then
            If fademode(i) = 1 Then
                If col(i) <= goalcolor(i) Then
                    fademode(i) = 0
                    col(i) = goalcolor(i)
                    GoTo stopani3
                End If

                col(i) = col(i) - 5

            ElseIf fademode(i) = 2 Then
                If col(i) >= buttonactive Then
                    col(i) = goalcolor(i)
                    fademode(i) = 1
                End If

                col(i) = col(i) + 5

                If col(i) >= goalcolor(i) Then
                    fademode(i) = 0
                    col(i) = goalcolor(i)
                    GoTo stopani3
                End If
            End If
stopani3:
            If Not col(i) >= 255 Then
                BTB2.BackColor = Color.FromArgb(col(i), col(i), col(i))
            End If
        End If
    End Sub

    Private Sub BTB1_MouseEnter(sender As Object, e As EventArgs) Handles BTB1.MouseEnter, BT1.MouseEnter
        goalcolor(1) = buttonactive
        fademode(1) = 2
    End Sub

    Private Sub BTB1_MouseLeave(sender As Object, e As EventArgs) Handles BTB1.MouseLeave, BT1.MouseLeave
        goalcolor(1) = buttondefault
        fademode(1) = 1
    End Sub

    Private Sub BTB2_MouseEnter(sender As Object, e As EventArgs) Handles BTB2.MouseEnter, BT2.MouseEnter
        goalcolor(2) = buttonactive
        fademode(2) = 2
    End Sub

    Private Sub BTB2_MouseLeave(sender As Object, e As EventArgs) Handles BTB2.MouseLeave, BT2.MouseLeave
        goalcolor(2) = buttondefault
        fademode(2) = 1
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BTB1.BackColor = Color.White
        BTB2.BackColor = Color.White
        BT1.Location = New Point((BTB1.Width - BT1.Width) / 2, (BTB1.Height - BT1.Height) / 2)
        BT2.Location = New Point((BTB2.Width - BT2.Width) / 2, (BTB2.Height - BT2.Height) / 2)
        SearchTypeComboBox1.SelectedIndex = 0
    End Sub

    Private Sub BT1_Click(sender As Object, e As EventArgs) Handles BT1.Click, BTB1.Click
        If issearching = False Then
            tmplist = Nothing
            ListView1.Items.Clear()
            currentpage = 1

            TextBox1.Enabled = False
            Panel1.Visible = True
            issearching = True
            BT1.Text = "탐색 중단"
            PotNameLabel.Visible = False
            Finder.RunWorkerAsync()
        Else
            currentpage = 1
            TextBox1.Enabled = True
            Panel1.Visible = False
            Finder.CancelAsync()
            BT1.Text = "다시 탐색"
            issearching = False
        End If
    End Sub

    Public Sub SpecialmidReturn(ByRef total As String, ByVal first As String, ByVal last As String, ByVal first2 As String, ByVal last2 As String, ByVal targetlist As ListView)
        If total.Contains(first) And total.Contains(first2) Then
            Dim tmptotal = total
            Dim count = 0

            Dim tmptotal2 = total
            Dim count2 = 0

ret:
            If tmptotal.Contains(first) = True And tmptotal2.Contains(first2) = True Then

                Dim FirstStart As Long = tmptotal.IndexOf(first) + first.Length + 1
                Dim FirstStart2 As Long = tmptotal2.IndexOf(first2) + first2.Length + 1

                tmplist = targetlist.Items.Add((Trim(Mid$(tmptotal, FirstStart, tmptotal.Substring(FirstStart).IndexOf(last) + 1))))
                tmplist.SubItems.Add((Trim(Mid$(tmptotal2, FirstStart2, tmptotal2.Substring(FirstStart2).IndexOf(last2) + 1))))

                tmptotal = Mid(tmptotal, FirstStart, tmptotal.Length)
                tmptotal2 = Mid(tmptotal2, FirstStart2, tmptotal2.Length)

                GoTo ret

            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        For i = 0 To ListView1.Items.Count - 1
            ListView1.Items(i).Checked = CheckBox1.Checked
        Next
    End Sub

    Private Sub ListView1_ItemChecked(sender As Object, e As ItemCheckedEventArgs) Handles ListView1.ItemChecked
        CheckBox1.Text = "모두 선택 (" + ListView1.CheckedItems.Count.ToString + " 개 선택됨)"
    End Sub

    Private Sub Label3_Paint(sender As Object, e As PaintEventArgs) Handles Label3.Paint
        Label3.Location = New Point(Label3.Location.X, (Panel1.Height - Label3.Height) / 2)
    End Sub

    Private Sub BT1_Paint(sender As Object, e As PaintEventArgs) Handles BT1.Paint
        BT1.Location = New Point((BTB1.Width - BT1.Width) / 2, (BTB1.Height - BT1.Height) / 2)
    End Sub

    Private Sub AddEvent()
        If copyingNum < ListView1.Items.Count Then
            If ListView1.Items(copyingNum).Checked = True Then

                Dim tmp = "http://tvpot.daum.net/mypot/View.do?clipid=" + ListView1.Items(copyingNum).SubItems(1).Text
                CopyState.Text = "값 복사중..."
                EpiState.Text = ListView1.Items(copyingNum).Text

                Try
                    Clipboard.Clear()
                    Clipboard.SetDataObject(tmp, True, 100, 100)
                Catch
                    MsgBox("클립보드에 접근할 수 없습니다. 의심되는 프로그램을 종료한 후 다시 시도해 주세요.", vbCritical)
                    GoTo finished
                End Try

            End If
            copyingNum += 1
        Else
finished:
        End If
    End Sub

    Private Sub QuickAddEvent()
        Dim TMPCOPY As String = Nothing
        For i = 0 To ListView1.CheckedItems.Count - 1
            TMPCOPY += "http://tvpot.daum.net/mypot/View.do?clipid=" + ListView1.CheckedItems(i).SubItems(1).Text + vbCr
        Next

        Form2.RichTextBox1.Text = TMPCOPY
        Form2.Show()
    End Sub

    Private Sub BT2_Click(sender As Object, e As EventArgs) Handles BT2.Click, BTB2.Click
        Dim cancel As Boolean = False '취소여부

        If IsProcessRunning("Utube-DL") = False And My.Settings.dontcheck = False Then
            If MsgBox("비디오 다운로더가 실행되어 있지 않은 것 같습니다." + vbCr _
                      + "대신 실행해 드릴까요?", vbYesNo + vbInformation) = vbYes Then
                cancel = True

                Dim downpath = DownloaderIsInstalled() '설치여부 체크, exe경로 탐색

                If downpath = "{ERROR}" Then
                    MsgBox("다운로더를 찾을 수 없습니다." + vbCr _
                           + "프로그램 우측 하단의 초록색 버튼을 눌러" + vbCr + "(재)설치를 해 보시기 바랍니다.", vbCritical)
                Else
                    Process.Start(downpath)
                    MsgBox("실행되었습니다." + vbCr _
                           + "'클립보드로 부터 자동 시작'을 체크한 뒤 다시 시도해주세요.", vbInformation)
                End If
            Else
                If MsgBox("그럼 다운로더의 실행 여부와 상관없이 복사 진행을 하시겠습니까?", vbYesNo + vbInformation) = vbNo Then
                    cancel = True
                End If
            End If
        ElseIf ListView1.CheckedItems.Count > 30 Then
            If MsgBox("현재 상당히 많은 동영상이 선택되어 있습니다." + vbCr _
                      + "30개 이상의 비디오를 동시에 받을 경우 오히려 다운로드가" _
                      + vbCr + "불안정해질 수 있으므로 나눠 백업하시는 것을 권장합니다." _
                      + vbCr + "(또한 100개 이상의 목록을 추가하면 프로그램이 멈출 수 있습니다!)" _
                      + vbCr + vbCr + "그래도 계속 하시겠습니까?", vbYesNo + vbInformation) = vbNo Then
                cancel = True
            Else
                If ListView1.CheckedItems.Count > 100 Then
                    If MsgBox("아니 그래도 100개가 넘는데... 정말로 하실건가요?", vbYesNo + vbQuestion) = vbYes Then
                        MsgBox("정 원하신다면 어쩔 수 없죠..." + vbCr + vbCr _
                      + "팁을 하나 드리자면 혹시 다운로드 중 진전이 없거나" + vbCr _
                      + "프로그램이 먹통이 됐다면 좌측 하단의 '다운로더 강제로 " + vbCr _
                      + "죽이기'를 클릭해 주세요.", vbOKOnly + vbInformation)
                    Else
                        cancel = True
                    End If
                End If
            End If
        End If

        If cancel = False Then
            If My.Settings.oldcopyway Then
                PanelOne.Visible = False
                PanelTwo.Visible = True
                BTB2.Visible = False
                DelayPrepare()
                PotThumbLoad.RunWorkerAsync()
            Else
                QuickAddEvent()
            End If
        End If

    End Sub

    Public Function IsProcessRunning(name As String) As Boolean
        'here we're going to get a list of all running processes on
        'the computer
        For Each clsProcess As Process In Process.GetProcesses()
            If clsProcess.ProcessName.StartsWith(name) Then
                'process found so it's running so return true
                Return True
            End If
        Next
        'process not found, return false
        Return False
    End Function

    Public Function DownloaderIsInstalled() As String
        Try
            Dim path = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Moo0"

            Dim dir As New DirectoryInfo(path)
            Dim files As FileInfo() = dir.GetFiles("Utube-DL.exe", SearchOption.AllDirectories)
            Return files(0).FullName

        Catch
            Return "{ERROR}"
        End Try
    End Function


    Private Sub CopyState_Paint(sender As Object, e As PaintEventArgs) Handles CopyState.Paint, EpiState.Paint
        CopyState.Location = New Point((PanelTwo.Width - CopyState.Width) / 2, CopyState.Location.Y)
        EpiState.Location = New Point((PanelTwo.Width - EpiState.Width) / 2, EpiState.Location.Y)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i = 0 To ListView1.SelectedItems.Count - 1
            ListView1.SelectedItems(i).Checked = True
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For i = 0 To ListView1.SelectedItems.Count - 1
            ListView1.SelectedItems(i).Checked = False
        Next
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Finder.DoWork
        Select Case searchingtype
            Case 0
                source = getHTML("http://tvpot.daum.net/mypot/json/GetClipInfo.do?ownerid=" + TextBox1.Text + "&size=48&init=false&order=date&page=" + currentpage.ToString)
            Case 1
                source = getHTML("http://tvpot.daum.net/mypot/json/GetClipInfo.do?size=48&init=false&order=date&playlistid=" + TextBox1.Text + "&page=" + currentpage.ToString)
        End Select
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles Finder.RunWorkerCompleted
        If source.Contains("""title""") And issearching = True Then
            SpecialmidReturn(source, """title"":""", """,""plain_title""", ",""id"":", ",""", ListView1)
            Label3.Text = "목록 탐색 작업중..." + vbCr + "(" + ListView1.Items.Count.ToString + " 개 찾음)"
            currentpage += 1
            Finder.RunWorkerAsync()
            ListView1.Items(ListView1.Items.Count - 1).EnsureVisible() '가장 아래로
        Else
            Label3.Text = "목록 탐색 작업중..."
            BT1.Text = "다시 탐색"
            TextBox1.Enabled = True
            issearching = False
            Panel1.Visible = False
        End If

        If source.Contains("""name"":""") Then
            PotNameLabel.Text = "게시자 : " + midReturn(source, """name"":""", """")
            PotNameLabel.Location = New Point(PotNamePanel.Width - PotNameLabel.Width, PotNameLabel.Location.Y)
            PotNameLabel.Visible = True
        End If

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Finder.RunWorkerAsync()
    End Sub

    Private Sub DelayPrepare() 'HTML조사 백그라운드 워커 이전에 반드시 실행필요!!!!!
        Dim isitfailed = False

        searchingtype = SearchTypeComboBox1.SelectedIndex
        copyingdelay = My.Settings.copy_delay

        Try
            copyingchecked = ListView1.Items(copyingNum).Checked
        Catch
            isitfailed = True
        End Try

        If isitfailed Then
            MsgBox("완료되었습니다." + vbCr + "Moo0 비디오 다운로더에 누락된 항목이 없는지 확인해 주세요.", vbInformation)
            PanelOne.Visible = True
            PanelTwo.Visible = False
            copyingNum = 0
            BTB2.Visible = True
        Else
            AddDelay.RunWorkerAsync()
        End If
    End Sub

    Private Sub AddDelay_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles AddDelay.DoWork
        If copyingchecked = True Then
            Threading.Thread.Sleep(copyingdelay)
        End If
    End Sub

    Private Sub AddDelay_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles AddDelay.RunWorkerCompleted
        AddEvent()
        DelayPrepare()
    End Sub

    Private Sub SearchTypeComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SearchTypeComboBox1.SelectedIndexChanged
        searchingtype = SearchTypeComboBox1.SelectedIndex
    End Sub

    Private Sub PotThumbLoad_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles PotThumbLoad.DoWork
        If Not source = Nothing Then
            If source.ToString.Contains("""profile_img_url"":""") Then
                Dim Imgurl As String = midReturn(source, """profile_img_url"":""", """")
                Dim tClient As WebClient = New WebClient
                potimage = Bitmap.FromStream(New MemoryStream(tClient.DownloadData(Imgurl)))
            Else
                potimage = Nothing
            End If
        End If
    End Sub

    Private Sub PotThumbLoad_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles PotThumbLoad.RunWorkerCompleted
        PotThumb.BackgroundImage = potimage
    End Sub

    Private Sub PotNameLabel_Click(sender As Object, e As EventArgs) Handles PotNameLabel.Click
        If Not source = Nothing Then

            Dim potinfo As String = Nothing
            Dim page As Integer = 1

            Dim tmpsource As String = getHTML("http://tvpot.daum.net/best/PotRanking.do?page=" + page.ToString)

            Do While tmpsource.Contains("<td class=""mypot"">")
                page += 1
                tmpsource = getHTML("http://tvpot.daum.net/best/PotRanking.do?page=" + page.ToString)
            Loop

            tmpsource = getHTML("http://tvpot.daum.net/best/PotRanking.do?page=" + (page - 1).ToString)

            Dim first = "<td class=""rank""><strong>"
            Dim last = "</strong>"

            Dim potname = midReturn(source, """name"":""", """")

            Dim rank = Nothing

            Try
                tmpsource = getHTML("http://tvpot.daum.net/best/PotRanking.do?q=" + potname)
                rank = midReturn(tmpsource, "<td class=""rank""><strong>", "</strong>")
            Catch
                rank = "(순위권 밖)"
            End Try

            Dim ownerid = midReturn(source, "ownerid"":""", """,")
            tmpsource = getHTML("http://tvpot.daum.net/mypot/json/GetClipInfo.do?ownerid=" & ownerid)

            potinfo += "팟 이름 : " + potname + vbCr
            potinfo += "팟 영상 개수 : " + midReturn(tmpsource, """total_count"":", ",") + vbCr
            potinfo += "구독자 수 : " + midReturn(tmpsource, """subscriber_cnt"":", ",") + vbCr
            potinfo += "순위 : " + rank + "위" + vbCr

            If IsNumeric(rank) Then
                potinfo += "현재 해당 팟(" + potname + ") 은 상위 " + Mid((rank / 10).ToString, 1, 5) + "% 입니다." + vbCr

                Dim grade As String = Nothing
                Select Case (rank / 10)
                    Case Is < 5
                        grade = "tv팟계의 공중파"
                    Case Is < 10
                        grade = "매우 유명한"
                    Case Is < 20
                        grade = "꽤나 유명한"
                    Case Is < 40
                        grade = "그럭저럭 알려진"
                    Case Is < 60
                        grade = "전형적인 자막 제작"
                    Case Is < 80
                        grade = "조금 시들시들한"
                    Case Else
                        grade = "인기가 있지도 없지도 않은"
                End Select
                grade += " 채널"

                potinfo += "채널 평가 : [" + grade + "] 이군요."
            Else
                potinfo += "현재 해당 팟은 순위권 밖에 있습니다." + vbCr
            End If

            MsgBox(potinfo, vbInformation)

        End If
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        If MsgBox("다운로드가 모두 취소, 중단됩니다!" + vbCr + "(또한 모든 콘솔(cmd)이 정지됩니다)" + vbCr + vbCr + "계속하시겠습니까?", vbYesNo + vbQuestion, "경고!") = vbYes Then
            Shell("taskkill /f /im youtube-dl.exe")
            Shell("taskkill /f /im conhost.exe")
            If MsgBox("다운로드 프로그램도 같이 죽일까요?", vbYesNo + vbQuestion) = vbYes Then Shell("taskkill /f /im Utube-DL.exe")
        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Options.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim downpath = DownloaderIsInstalled() '설치여부 체크, exe경로 탐색

        If downpath = "{ERROR}" Then
            MsgBox("해당 프로그램을 다운로드 하고 설치한 뒤 실행해 주세요.", vbInformation)
            Process.Start("http://www.moo0.com/software/YouTube/download/free/")
        Else
            If MsgBox("이미 설치된 것 같은데... 한번 실행해 볼까요?", vbYesNo + vbQuestion) = vbYes Then
                Dim iserror = False
                Try
                    Process.Start(downpath)
                Catch ex As Exception
                    iserror = True
                    MsgBox("이상하다.. 실행이 또 안되네요." + vbCr + "재설치를 해 봐야 할 것 같네요.", vbInformation)
                    If MsgBox("다운로드 페이지로 들어갈까요?", vbYesNo + vbQuestion) = vbYes Then
                        MsgBox("해당 프로그램을 다운로드 하고 설치한 뒤 실행해 주세요.", vbInformation)
                        Process.Start("http://www.moo0.com/software/YouTube/download/free/")
                    End If
                End Try

                If iserror = False Then MsgBox("실행되었습니다." + vbCr _
                                                 + "'클립보드로 부터 자동 시작'을 체크한 뒤 다시 시도해주세요.", vbInformation)
            Else
                If MsgBox("그럼 다운로드 페이지로 들어갈까요?", vbYesNo + vbQuestion) = vbYes Then
                    MsgBox("해당 프로그램을 다운로드 하고 설치한 뒤 실행해 주세요.", vbInformation)
                    Process.Start("http://www.moo0.com/software/YouTube/download/free/")
                End If
            End If
        End If

    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.BackColor = down_btdefault
    End Sub

    Private Sub PictureBox2_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox2.MouseEnter
        PictureBox2.BackColor = down_btactive
    End Sub
End Class
