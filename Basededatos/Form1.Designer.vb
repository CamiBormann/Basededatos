<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtRut = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtCiudad = New System.Windows.Forms.TextBox()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.No = New System.Windows.Forms.RadioButton()
        Me.Femenino = New System.Windows.Forms.RadioButton()
        Me.Masculino = New System.Windows.Forms.RadioButton()
        Me.cbComuna = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtRut
        '
        Me.txtRut.Location = New System.Drawing.Point(74, 53)
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Size = New System.Drawing.Size(168, 24)
        Me.txtRut.TabIndex = 0
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(74, 101)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(168, 24)
        Me.txtNombre.TabIndex = 1
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(74, 161)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(168, 24)
        Me.txtApellido.TabIndex = 2
        '
        'txtCiudad
        '
        Me.txtCiudad.Location = New System.Drawing.Point(74, 366)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(168, 24)
        Me.txtCiudad.TabIndex = 3
        '
        'txtObservacion
        '
        Me.txtObservacion.Location = New System.Drawing.Point(91, 425)
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(151, 24)
        Me.txtObservacion.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(88, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Ejemplo: 123569885"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Rut"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 18)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Apellidos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Nombres"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 306)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Comuna"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.No)
        Me.GroupBox1.Controls.Add(Me.Femenino)
        Me.GroupBox1.Controls.Add(Me.Masculino)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 220)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(331, 59)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sexo :"
        '
        'No
        '
        Me.No.AutoSize = True
        Me.No.Location = New System.Drawing.Point(221, 24)
        Me.No.Name = "No"
        Me.No.Size = New System.Drawing.Size(104, 22)
        Me.No.TabIndex = 2
        Me.No.TabStop = True
        Me.No.Text = "No especifíca"
        Me.No.UseVisualStyleBackColor = True
        '
        'Femenino
        '
        Me.Femenino.AutoSize = True
        Me.Femenino.Location = New System.Drawing.Point(115, 24)
        Me.Femenino.Name = "Femenino"
        Me.Femenino.Size = New System.Drawing.Size(77, 22)
        Me.Femenino.TabIndex = 1
        Me.Femenino.TabStop = True
        Me.Femenino.Text = "Femenino"
        Me.Femenino.UseVisualStyleBackColor = True
        '
        'Masculino
        '
        Me.Masculino.AutoSize = True
        Me.Masculino.Location = New System.Drawing.Point(6, 24)
        Me.Masculino.Name = "Masculino"
        Me.Masculino.Size = New System.Drawing.Size(80, 22)
        Me.Masculino.TabIndex = 0
        Me.Masculino.TabStop = True
        Me.Masculino.Text = "Masculino"
        Me.Masculino.UseVisualStyleBackColor = True
        '
        'cbComuna
        '
        Me.cbComuna.ForeColor = System.Drawing.Color.Purple
        Me.cbComuna.FormattingEnabled = True
        Me.cbComuna.Location = New System.Drawing.Point(74, 306)
        Me.cbComuna.Name = "cbComuna"
        Me.cbComuna.Size = New System.Drawing.Size(168, 26)
        Me.cbComuna.TabIndex = 11
        Me.cbComuna.Text = "(Seleccione Comuna)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 372)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 18)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Ciudad"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 428)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 18)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Observación"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(261, 48)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(82, 34)
        Me.BtnBuscar.TabIndex = 14
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(94, 478)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(148, 34)
        Me.BtnGuardar.TabIndex = 15
        Me.BtnGuardar.Text = "Guardar MySql"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Basededatos.My.Resources.Resources.images
        Me.PictureBox3.Location = New System.Drawing.Point(248, 108)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 51)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 18
        Me.PictureBox3.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(352, 529)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbComuna)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtObservacion)
        Me.Controls.Add(Me.txtCiudad)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtRut)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Purple
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso y Búsqueda Masiva"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtRut As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtCiudad As TextBox
    Friend WithEvents txtObservacion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents No As RadioButton
    Friend WithEvents Femenino As RadioButton
    Friend WithEvents Masculino As RadioButton
    Friend WithEvents cbComuna As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents PictureBox3 As PictureBox
End Class
