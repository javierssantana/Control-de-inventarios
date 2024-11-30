Public Class ValidarDatos
    Public Shared Function Validar(campos As Dictionary(Of String, String)) As Boolean
        ' Verifica que todos los campos de texto estén llenos
        For Each campo In campos
            If String.IsNullOrWhiteSpace(campo.Value) Then
                MessageBox.Show($"Por favor, complete el campo {campo.Key}.", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If
        Next

        ' Verifica que el campo de existencias sea un número entero válido
        Dim existencias As Integer
        If Not Integer.TryParse(campos("existencias"), existencias) Then
            MessageBox.Show("La existencia debe ser un número.", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function
End Class
