Imports System.IO
Imports System.Text

Public Class FormInicio

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        FileOpen(1, "./passwords.txt", OpenMode.Input)
        Dim a As String = vbNull
        Dim iniciado As Boolean = False
        While Not EOF(1)
            Input(1, a)
            Dim palabras() As String = a.Split(":")
            If palabras(0).ToLower.Equals(txtUsario.Text.ToLower) Then
                If palabras(1).ToLower.Equals(txtContra.Text.ToLower) Then
                    iniciado = True
                    MsgBox("Acaba de conectar como: " + palabras(0))
                    Exit While
                End If
            End If
        End While
        If iniciado = False Then
            MsgBox("Usuario o conraseña incorrecto.")
        End If
        FileClose(1)
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtUsario.Clear()
        txtContra.Clear()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub timerFechaHora_Tick(sender As Object, e As EventArgs) Handles timerFechaHora.Tick
        lblFechaHora.Text = Date.Now
    End Sub

    Private Sub FormInicio_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblFechaHora.Text = Date.Now

        If Not File.Exists("./passwords.txt") Then
            Dim fs As FileStream = File.Create("./passwords.txt")
            'vbCrLf es un salto de línea para la visualización e impresión
            Dim porDefecto As Byte() = New UTF8Encoding(True).GetBytes("admin:admin" + vbCrLf + "empleado:empleado")
            fs.Write(porDefecto, 0, porDefecto.Length)
            fs.Close()
        End If
    End Sub
End Class