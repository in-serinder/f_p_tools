Public Class mainf
    Dim w, i As Integer

    Private click_d As Boolean = False
    Private ctr_addr As Point
    Private mos_addr As Point
    '
    Dim info1 As New Process()

    '
    'input
    Private Sub systeam_info(sender As Object, e As System.Diagnostics.Process)
        Dim info1 As New Process()
        info1.StartInfo.FileName = "info.exe"
        info1.StartInfo.Arguments = "ipconfig"
        info1.StartInfo.UseShellExecute = False
        info1.StartInfo.RedirectStandardOutput = True
        Dim shellput As String = info1.StandardOutput.ReadToEnd()
        info1.WaitForExit()

    End Sub
    Private Sub mainf_mousedown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown '鼠标按下时
        Me.click_d = True
        Me.ctr_addr = New Point(e.X, e.Y) 'adr
    End Sub
    Private Sub mainf_mousemove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove '移动ctr
        mos_addr = New Point(e.X, e.Y)
        If Me.click_d = True Then
            Me.Location = PointToScreen(mos_addr) - Me.ctr_addr
        End If
    End Sub
    Private Sub mainf_mouseup(sender As Object, e As EventArgs) Handles Me.MouseUp '抬起
        Me.click_d = False
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles pv.Click
       
        for1.BringToFront()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles exit1.Click
        End
    End Sub

    Private Sub mainf_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        End
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        i = i + 1
        If i Mod 2 = 1 Then
            Me.WindowState = 2
        Else
            Me.WindowState = 0
        End If


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.WindowState = 1
    End Sub

    Private Sub find_Click(sender As Object, e As EventArgs) Handles find.Click
        
        for2.BringToFront()
    End Sub

    Private Sub for2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

   

    Private Sub pwd_Click(sender As Object, e As EventArgs) Handles pwd.Click
        for3.BringToFront()
    End Sub

    Private Sub tool_Click(sender As Object, e As EventArgs) Handles tool.Click
        for4.BringToFront()
    End Sub

    Private Sub interr_Click(sender As Object, e As EventArgs) Handles interr.Click
        for5.BringToFront()
    End Sub

    Private Sub bat_Click(sender As Object, e As EventArgs) Handles bat.Click
        for6.BringToFront()
    End Sub

    Private Sub zip_Click(sender As Object, e As EventArgs) Handles zip.Click
        for7.BringToFront()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Shell("taskmgr.exe")
    End Sub

    Private Sub for6_Paint(sender As Object, e As PaintEventArgs) Handles for6.Paint

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        info1.StartInfo.FileName = "cmd.exe" ' 设置子程序的名称
        info1.StartInfo.Arguments = "ipconfig" ' 设置子程序的参数
        info1.StartInfo.UseShellExecute = False
        info1.StartInfo.RedirectStandardOutput = True ' 设置标准输出流重定向
        info1.Start()
        Dim output As String = info1.StandardOutput.ReadToEnd()
        TextBox1.Text = output

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim shellput As String = info1.StandardOutput.ReadToEnd()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

    End Sub
End Class

