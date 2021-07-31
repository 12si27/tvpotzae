Module DataGet

    Public Function midReturn(ByRef total As String, ByVal first As String, ByVal last As String)
        If total.Contains(first) Then
            Dim FirstStart As Long = total.IndexOf(first) + first.Length + 1
            Return Trim(Mid$(total, FirstStart, total.Substring(FirstStart).IndexOf(last) + 1))
        Else
            Return ErrorToString("{ERROR}")
        End If
    End Function

    Public Function multiplemidReturn(ByRef total As String, ByVal first As String, ByVal last As String)
        If total.Contains(first) Then
            Dim tmptotal = total
            Dim res As String = Nothing
            Dim count = 0

ret:
            If tmptotal.Contains(first) = True Then
                Dim FirstStart As Long = tmptotal.IndexOf(first) + first.Length + 1
                res += (Trim(Mid$(tmptotal, FirstStart, tmptotal.Substring(FirstStart).IndexOf(last) + 1))) + vbCr
                tmptotal = Mid(tmptotal, FirstStart, tmptotal.Length)
                GoTo ret
            End If

            Return res
        Else
            Return ErrorToString("{ERROR}")
        End If
    End Function

    Public Function getHTML(url As String) ''신HTML GET 명령어
        Try
            Dim clie As New System.Net.WebClient()
            clie.Encoding = System.Text.Encoding.UTF8
            Dim sourceString As String = clie.DownloadString(url)
            Return sourceString
        Catch
            Return "{ERROR}"
        End Try
    End Function
End Module
