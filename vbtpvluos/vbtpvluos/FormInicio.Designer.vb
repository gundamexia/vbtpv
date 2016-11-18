<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.txtUsario = New System.Windows.Forms.TextBox()
        Me.txtContra = New System.Windows.Forms.TextBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblContra = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lblTiempo = New System.Windows.Forms.Label()
        Me.lblFechaHora = New System.Windows.Forms.Label()
        Me.timerFechaHora = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btnIniciar
        '
        Me.btnIniciar.Location = New System.Drawing.Point(61, 139)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(100, 30)
        Me.btnIniciar.TabIndex = 0
        Me.btnIniciar.Text = "Iniciar sesión"
        Me.btnIniciar.UseVisualStyleBackColor = True
        '
        'txtUsario
        '
        Me.txtUsario.Location = New System.Drawing.Point(115, 48)
        Me.txtUsario.Name = "txtUsario"
        Me.txtUsario.Size = New System.Drawing.Size(172, 20)
        Me.txtUsario.TabIndex = 1
        '
        'txtContra
        '
        Me.txtContra.Location = New System.Drawing.Point(115, 90)
        Me.txtContra.Name = "txtContra"
        Me.txtContra.Size = New System.Drawing.Size(172, 20)
        Me.txtContra.TabIndex = 2
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(167, 139)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(100, 30)
        Me.btnLimpiar.TabIndex = 3
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(40, 51)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(46, 13)
        Me.lblUsuario.TabIndex = 4
        Me.lblUsuario.Text = "Usuario:"
        '
        'lblContra
        '
        Me.lblContra.AutoSize = True
        Me.lblContra.Location = New System.Drawing.Point(40, 93)
        Me.lblContra.Name = "lblContra"
        Me.lblContra.Size = New System.Drawing.Size(64, 13)
        Me.lblContra.TabIndex = 5
        Me.lblContra.Text = "Contraseña:"
        '
        'btnSalir
        '
        Me.btnSalir.AutoSize = True
        Me.btnSalir.Location = New System.Drawing.Point(293, 188)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(37, 23)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'lblTiempo
        '
        Me.lblTiempo.AutoSize = True
        Me.lblTiempo.Location = New System.Drawing.Point(40, 18)
        Me.lblTiempo.Name = "lblTiempo"
        Me.lblTiempo.Size = New System.Drawing.Size(72, 13)
        Me.lblTiempo.TabIndex = 7
        Me.lblTiempo.Text = "Fecha y hora:"
        '
        'lblFechaHora
        '
        Me.lblFechaHora.AutoSize = True
        Me.lblFechaHora.Location = New System.Drawing.Point(112, 18)
        Me.lblFechaHora.Name = "lblFechaHora"
        Me.lblFechaHora.Size = New System.Drawing.Size(34, 13)
        Me.lblFechaHora.TabIndex = 8
        Me.lblFechaHora.Text = "fecha"
        '
        'timerFechaHora
        '
        Me.timerFechaHora.Enabled = True
        Me.timerFechaHora.Interval = 1000
        '
        'FormInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 223)
        Me.Controls.Add(Me.lblFechaHora)
        Me.Controls.Add(Me.lblTiempo)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblContra)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.txtContra)
        Me.Controls.Add(Me.txtUsario)
        Me.Controls.Add(Me.btnIniciar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormInicio"
        Me.Text = "Iniciar sesión"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnIniciar As System.Windows.Forms.Button
    Friend WithEvents txtUsario As System.Windows.Forms.TextBox
    Friend WithEvents txtContra As System.Windows.Forms.TextBox
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents lblContra As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents lblTiempo As System.Windows.Forms.Label
    Friend WithEvents lblFechaHora As System.Windows.Forms.Label
    Friend WithEvents timerFechaHora As System.Windows.Forms.Timer
End Class
