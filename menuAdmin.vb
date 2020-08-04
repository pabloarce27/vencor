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

#Region "botones"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        showSubmenu(SubMenu1)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        showSubmenu(SubMenu2)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        showSubmenu(SubMenu3)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        abrirFormHijo(New prueba1())
        hideSubmenu()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'codigo de accion'
        hideSubmenu()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'codigo de accion'
        hideSubmenu()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        abrirFormHijo(New prueba2())
        hideSubmenu()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'codigo de accion'
        hideSubmenu()
    End Sub
#End Region

    Private currentForm As Form = Nothing
    Private Sub abrirFormHijo(childForm As Form)
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelFormHijos.Controls.Add(childForm)
        PanelFormHijos.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub PanelFormHijos_Paint(sender As Object, e As PaintEventArgs) Handles PanelFormHijos.Paint

    End Sub
End Class