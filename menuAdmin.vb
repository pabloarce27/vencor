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
#Region "Gestiones"
    Private Sub BGestion_Click(sender As Object, e As EventArgs) Handles BGestion.Click
        showSubmenu(SubMenu1)
    End Sub

    Private Sub BProductos_Click(sender As Object, e As EventArgs) Handles BProductos.Click
        abrirFormHijo(New Productos())
        hideSubmenu()
    End Sub

    Private Sub BEmpleados_Click(sender As Object, e As EventArgs) Handles BEmpleados.Click
        abrirFormHijo(New Empleados())
        hideSubmenu()
    End Sub

    Private Sub BClientes_Click(sender As Object, e As EventArgs) Handles BClientes.Click
        abrirFormHijo(New Clientes())
        hideSubmenu()
    End Sub
#End Region
#Region "SubMenu 2"
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        showSubmenu(SubMenu2)
    End Sub

#End Region
#Region "SubMenu 3"
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        showSubmenu(SubMenu3)
    End Sub
#End Region



    'Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
    '    'codigo de accion'
    '    hideSubmenu()
    'End Sub
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