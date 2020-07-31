<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class menuAdmin
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PanelMenuLateral = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelMenuLateral.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMenuLateral
        '
        Me.PanelMenuLateral.Controls.Add(Me.Panel1)
        Me.PanelMenuLateral.Controls.Add(Me.Button1)
        Me.PanelMenuLateral.Controls.Add(Me.PanelLogo)
        Me.PanelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenuLateral.ForeColor = System.Drawing.Color.Silver
        Me.PanelMenuLateral.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenuLateral.Name = "PanelMenuLateral"
        Me.PanelMenuLateral.Size = New System.Drawing.Size(250, 714)
        Me.PanelMenuLateral.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(0, 95)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(250, 45)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Principal"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(250, 95)
        Me.PanelLogo.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 140)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(250, 163)
        Me.Panel1.TabIndex = 2
        '
        'menuAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1132, 714)
        Me.Controls.Add(Me.PanelMenuLateral)
        Me.ForeColor = System.Drawing.Color.Silver
        Me.Name = "menuAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "menuAdmin"
        Me.PanelMenuLateral.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenuLateral As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents Panel1 As Panel
End Class
