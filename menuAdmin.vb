Public Class menuAdmin
    Private Sub menuAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideSubmenu()

    End Sub

    Private Sub hideSubmenu()
        SubMenu1.Visible = False
        SubMenu2.Visible = False
        SubMenu3.Visible = False


    End Sub

    Private Sub showSubmenu(submenu As Panel)
        If submenu.Visible = False Then
            hideSubmenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        showSubmenu(SubMenu1)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        showSubmenu(SubMenu2)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        showSubmenu(SubMenu3)
    End Sub
End Class