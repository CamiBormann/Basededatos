Imports MySql.Data.MySqlClient
Public Class Form1
    Dim connectionString As String = "Server=localhost;Database=registropersonas;User ID='root';Password='';"

    Public Function Consulta() As List(Of Comuna)
        Dim listacomuna As New List(Of comuna)
        Using conexion As New MySqlConnection(connectionString)
            Try
                conexion.Open()
                Dim query As String = "SELECT * FROM comuna"
                Dim cmd As New MySqlCommand(query, conexion)
                'cmd.Connection = conexion
                Dim resultado As MySqlDataReader
                resultado = cmd.ExecuteReader
                While (resultado.Read())
                    Dim comunas As New Comuna With {
                        .ComunaID = Convert.ToInt32(resultado("ComunaID")),
                        .NombreComuna = Convert.ToString(resultado("NombreComuna"))
                    }
                    listacomuna.Add(comunas)
                End While
                conexion.Close()
            Catch ex As Exception
                conexion.Close()
            End Try
        End Using
        Return listacomuna
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim listado = Consulta()
        For Each item As Comuna In listado
            cbComuna.Items.Insert(item.ComunaID - 1, item.NombreComuna)
        Next
    End Sub

    Public Function GetPersona(RUT As String) As Persona
        Dim persona As New Persona
        Using conexion As New MySqlConnection(connectionString)
            Try
                conexion.Open()
                Dim query As String = "SELECT * FROM personas WHERE RUT= @RUT"
                Dim cmd As New MySqlCommand(query, conexion)
                'cmd.Connection = conexion
                cmd.Parameters.AddWithValue("@RUT", RUT)
                Dim resultado As MySqlDataReader
                resultado = cmd.ExecuteReader
                While (resultado.Read())
                    persona.RUT = Convert.ToString(resultado("RUT"))
                    persona.Nombre = Convert.ToString(resultado("Nombre"))
                    persona.Apellido = Convert.ToString(resultado("Apellido"))
                    persona.Sexo = Convert.ToString(resultado("Sexo"))
                    persona.Comuna = Convert.ToString(resultado("Comuna"))
                    persona.Ciudad = Convert.ToString(resultado("Ciudad"))
                    persona.Observacion = Convert.ToString(resultado("Observacion"))
                End While
                conexion.Close()
            Catch ex As Exception
                conexion.Close()
            End Try
        End Using

        Return persona
    End Function

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim rut As String = txtRut.Text
        If String.IsNullOrWhiteSpace(rut) Then
            MessageBox.Show("Debe escribir un RUT, antes de realizar una búsqueda!!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        HabilitarDeshabilitar(False)
        Dim persona As Persona = GetPersona(rut)
        If Not String.IsNullOrWhiteSpace(persona.RUT) Then
            txtRut.Text = persona.RUT
            txtNombre.Text = persona.Nombre
            txtApellido.Text = persona.Apellido
            cbComuna.SelectedItem = persona.Comuna
            txtCiudad.Text = persona.Ciudad
            txtObservacion.Text = persona.Observacion
            Select Case persona.Sexo
                Case "Masculino"
                    M.Checked = True
                Case "Femenino"
                    F.Checked = True
                Case "No especifica"
                    N.Checked = True
                Case Else
                    M.Checked = False
                    F.Checked = False
                    N.Checked = False
            End Select

        Else
            Dim respuesta As Int32 = MessageBox.Show("¿Desea registrarse?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If respuesta = vbYes Then
                HabilitarDeshabilitar(True)
                LimpiarI()
            End If

            Return

        End If

    End Sub

    Sub HabilitarDeshabilitar(ByVal a As Boolean)
        txtNombre.Enabled = a
        txtApellido.Enabled = a
        cbComuna.Enabled = a
        txtCiudad.Enabled = a
        txtObservacion.Enabled = a
        M.Enabled = a
        F.Enabled = a
        N.Enabled = a
        BtnGuardar.Enabled = a
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim rut As String = txtRut.Text
        Dim nombre As String = txtNombre.Text
        Dim apellido As String = txtApellido.Text
        Dim sexo As String
        If M.Checked Then
            sexo = "Masculino"
        ElseIf F.Checked Then
            sexo = "Femenino"
        ElseIf N.Checked Then
            sexo = "No especifica"
        Else
            MessageBox.Show("Por favor, seleccione el sexo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim comuna As String = cbComuna.SelectedItem?.ToString()
        Dim ciudad As String = txtCiudad.Text
        Dim observacion As String = txtObservacion.Text

        If String.IsNullOrWhiteSpace(rut) Or String.IsNullOrWhiteSpace(nombre) Or String.IsNullOrWhiteSpace(apellido) Or String.IsNullOrWhiteSpace(comuna) Then
            MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using conexion As New MySqlConnection(connectionString)
            Try
                conexion.Open()
                Dim query As String = "INSERT INTO Personas (RUT, Nombre, Apellido, Sexo, Comuna, Ciudad, Observacion) " &
                                    "VALUES (@rut, @nombre, @apellido, @sexo, @comuna, @ciudad, @observacion)"
                Dim cmd As New MySqlCommand(query, conexion)
                'cmd.Connection = conexion
                cmd.Parameters.AddWithValue("@rut", rut)
                cmd.Parameters.AddWithValue("@nombre", nombre)
                cmd.Parameters.AddWithValue("@apellido", apellido)
                cmd.Parameters.AddWithValue("@sexo", sexo)
                cmd.Parameters.AddWithValue("@comuna", comuna)
                cmd.Parameters.AddWithValue("@ciudad", ciudad)
                cmd.Parameters.AddWithValue("@observacion", observacion)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Datos guardados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                conexion.Close()
            Catch ex As Exception
                conexion.Close()
            End Try
        End Using
        Limpiar()
    End Sub

    Sub Limpiar()
        txtRut.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtCiudad.Clear()
        txtObservacion.Clear()
        M.Checked = False
        F.Checked = False
        N.Checked = False
        cbComuna.SelectedIndex = -1
        txtRut.Focus()
        HabilitarDeshabilitar(True)
    End Sub

    Sub LimpiarI()
        txtNombre.Clear()
        txtApellido.Clear()
        txtCiudad.Clear()
        txtObservacion.Clear()
        M.Checked = False
        F.Checked = False
        N.Checked = False
        cbComuna.SelectedIndex = -1
        txtRut.Focus()
        HabilitarDeshabilitar(True)
    End Sub




End Class


Public Class Comuna
    Private _comunaID As Integer
    Private _nombreComuna As String

    Public Property ComunaID As Integer
        Get
            Return _comunaID
        End Get
        Set(value As Integer)
            _comunaID = value
        End Set
    End Property

    Public Property NombreComuna As String
        Get
            Return _nombreComuna
        End Get
        Set(value As String)
            _nombreComuna = value
        End Set
    End Property
End Class

Public Class Persona
    Private _rUT As String
    Private _nombre As String
    Private _apellido As String
    Private _sexo As String
    Private _comuna As String
    Private _ciudad As String
    Private _observacion As String

    Public Property RUT As String
        Get
            Return _rUT
        End Get
        Set(value As String)
            _rUT = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Apellido As String
        Get
            Return _apellido
        End Get
        Set(value As String)
            _apellido = value
        End Set
    End Property

    Public Property Sexo As String
        Get
            Return _sexo
        End Get
        Set(value As String)
            _sexo = value
        End Set
    End Property

    Public Property Comuna As String
        Get
            Return _comuna
        End Get
        Set(value As String)
            _comuna = value
        End Set
    End Property

    Public Property Ciudad As String
        Get
            Return _ciudad
        End Get
        Set(value As String)
            _ciudad = value
        End Set
    End Property

    Public Property Observacion As String
        Get
            Return _observacion
        End Get
        Set(value As String)
            _observacion = value
        End Set
    End Property
End Class