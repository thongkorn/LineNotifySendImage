' / --------------------------------------------------------------------------------
' / Developer : Mr.Surapon Yodsanga (Thongkorn Tubtimkrob)
' / eMail : thongkorn@hotmail.com
' / URL: http://www.g2gnet.com (Khon Kaen - Thailand)
' / Facebook: https://www.facebook.com/g2gnet (For Thailand)
' / Facebook: https://www.facebook.com/commonindy (Worldwide)
' / More Info: http://www.g2gsoft.com
' /
' / Purpose: Line Notify and upload images with VB.NET (2010)
' / Microsoft Visual Basic .NET (2010)
' /
' / This is open source code under @Copyleft by Thongkorn Tubtimkrob.
' / You can modify and/or distribute without to inform the developer.
' / --------------------------------------------------------------------------------
Imports System.Net
Imports System.Text
Imports System.IO

'// ดาวน์โหลด cURL สำหรับ Windows ทั้ง 32 บิตและ 64 บิต
'// https://curl.haxx.se/windows/

Public Class frmLineNotify
    Dim streamPic As Stream     '// Use Steam instead IO.
    Dim PicturePath As String = MyPath(Application.StartupPath) & "Images\"
    '//
    Dim FullPathFileName As String = String.Empty
    '// เปลี่ยน TOKEN ที่นี่ที่เดียว
    Const strToken As String = "TOKEN"

    Private Sub frmLineNotify_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        System.Net.ServicePointManager.SecurityProtocol = DirectCast(3072, System.Net.SecurityProtocolType)
        txtMessage.Text = "ทดสอบการส่ง Line Notify จากคุณทองก้อน ทับทิมกรอบ"
        picData.Image = Image.FromFile(PicturePath & "NoImage.gif")
    End Sub

    Private Sub btnSend_Click(sender As System.Object, e As System.EventArgs) Handles btnSend.Click
        If String.IsNullOrEmpty(txtMessage.Text.Trim) Then
            MessageBox.Show("Nothing message to send.", "Report Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        Try
            Cursor.Current = Cursors.WaitCursor
            System.Net.ServicePointManager.Expect100Continue = False
            Dim Request = DirectCast(WebRequest.Create("https://notify-api.line.me/api/notify"), HttpWebRequest)
            '// Message to Line.
            Dim LineMessage = String.Format("message={0}", txtMessage.Text & vbCrLf & "วันที่ - เวลา : " & FormatDateTime(Now(), DateFormat.GeneralDate))
            '// หากต้องการส่ง Sticker ออกไปด้วย
            '// List of available stickers ... https://developers.line.biz/en/docs/messaging-api/sticker-list/
            LineMessage += "&stickerPackageId=1" & "&stickerId=109"

            Dim MyData = Encoding.UTF8.GetBytes(LineMessage)
            Request.Method = "POST"
            '// Initialize
            With Request
                .ContentType = "application/x-www-form-urlencoded"
                .ContentLength = MyData.Length
                '// Change your Token and don't cut "Bearer".
                .Headers.Add("Authorization", "Bearer " & strToken)
                .AllowWriteStreamBuffering = True
                .KeepAlive = False
                .Credentials = CredentialCache.DefaultCredentials
            End With
            '//
            Using Stream = Request.GetRequestStream()
                Stream.Write(MyData, 0, MyData.Length)
            End Using
            Dim response = DirectCast(Request.GetResponse(), HttpWebResponse)
            Dim responseString = New StreamReader(response.GetResponseStream()).ReadToEnd()

            '//
            If FullPathFileName.Trim <> "" Or FullPathFileName.Length <> 0 Then Call SendPicture()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cursor.Current = Cursors.Default
            MessageBox.Show("ส่งข้อความและรูปภาพ Line Notify เรียบร้อย.", "รายงานสถานะ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Sub SendPicture()
        '// Format
        '// " -X POST -H "Authorization: Bearer TOKEN" -F "message=Send Picture" -F "imageFile=@D:\Sample.jpg" https://notify-api.line.me/api/notify"
        Try
            Dim arg As String = String.Empty
            arg &= " -X POST -H "
            arg &= """Authorization: Bearer " & strToken & """"
            arg &= " -F ""message=" & "Send Picture" & """"
            arg &= " -F ""imageFile=@" & FullPathFileName.Trim & """ https://notify-api.line.me/api/notify"
            ShellandWait("curl.exe", arg)
            '//
            picData.Image = Image.FromFile(PicturePath & "NoImage.gif")
            FullPathFileName = String.Empty
        Catch ex As Exception
            MessageBox.Show("Error", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub ShellandWait(ByVal ProcessPath As String, ByVal Arguments As String)
        Dim objProcess As System.Diagnostics.Process
        Try
            objProcess = New System.Diagnostics.Process()
            objProcess.StartInfo.Arguments = Arguments
            objProcess.StartInfo.FileName = ProcessPath
            objProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            objProcess.Start()
            Application.DoEvents()
            objProcess.WaitForExit()
            Application.DoEvents()
            Console.WriteLine(objProcess.ExitCode.ToString())
            objProcess.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmLineNotify_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
        GC.SuppressFinalize(Me)
        Application.Exit()
    End Sub

    Private Sub btnBrowse_Click(sender As System.Object, e As System.EventArgs) Handles btnBrowse.Click
        Dim dlgImage As OpenFileDialog = New OpenFileDialog()

        ' / Open File Dialog
        With dlgImage
            '.InitialDirectory = PicturePath 'PicturePath
            .Title = "Select your image file"
            .Filter = "Image (*.jpg;*.png;*.gif;*.bmp)|*.jpg;*.png;*.gif;*.bmp"
            .FilterIndex = 1
            .RestoreDirectory = True
        End With
        '/ Select OK after Browse ...
        If dlgImage.ShowDialog() = DialogResult.OK Then
            FullPathFileName = dlgImage.FileName
            picData.Image = Image.FromFile(FullPathFileName)
        End If
    End Sub

    ' / -----------------------------------------------------------------------------
    ' / Use Steam instead IO.
    ' / -----------------------------------------------------------------------------
    Sub ShowPicture(PicName As String)
        Dim imgDB As Image
        ' Get the name of the image file.
        If PicName.ToString <> "" Then
            ' Verify that the image file meets the specified location.
            If System.IO.File.Exists(PicturePath & PicName.ToString) Then
                '/ Because when deleting the image file is locked, it can not be removed.
                '/ The file is closed after the image is loaded, so you can delete the file if you need.
                streamPic = File.OpenRead(PicturePath & PicName.ToString)
                imgDB = Image.FromStream(streamPic)
                picData.Image = imgDB
            Else
                '/ No images.
                streamPic = File.OpenRead(PicturePath & "NoImage.gif")
                imgDB = Image.FromStream(streamPic)
                picData.Image = imgDB
            End If

            ' Is null
        Else
            streamPic = File.OpenRead(PicturePath & "NoImage.gif")
            imgDB = Image.FromStream(streamPic)
            picData.Image = imgDB
        End If
        '//
        streamPic.Dispose()
    End Sub

    ' / Get my project path
    ' / AppPath = C:\My Project\bin\debug
    ' / Replace "\bin\debug" with "\"
    ' / Return : C:\My Project\
    Function MyPath(ByVal AppPath As String) As String
        '/ MessageBox.Show(AppPath);
        AppPath = AppPath.ToLower()
        '/ Return Value
        MyPath = AppPath.Replace("\bin\debug", "\").Replace("\bin\release", "\").Replace("\bin\x86\debug", "\").Replace("\bin\x86\release", "\")
        '// If not found folder then put the \ (BackSlash) at the end.
        If Microsoft.VisualBasic.Right(MyPath, 1) <> Chr(92) Then MyPath = MyPath & Chr(92)
    End Function

    Private Sub btnDeleteImg_Click(sender As System.Object, e As System.EventArgs) Handles btnDeleteImg.Click
        picData.Image = Image.FromFile(PicturePath & "NoImage.gif")
        FullPathFileName = String.Empty
    End Sub
End Class
