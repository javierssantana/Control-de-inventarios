Public Class DatabaseFunctions
    Private connectionString As String = "Data Source=DESKTOP-7K1HMM5\SQLEXPRESS;Initial Catalog=componentes;Integrated Security=True"

    ' Función para mostrar todos los productos
    Public Function Mostrar_Todos_Productos() As DataTable
        Dim table As New DataTable()
        Try
            Using connection As New SqlConnection(connectionString)
                Using cmd As New SqlCommand("SP_MostrarTodosProductos", connection)
                    cmd.CommandType = CommandType.StoredProcedure

                    connection.Open()
                    Using adapter As New SqlDataAdapter(cmd)
                        adapter.Fill(table)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return table
    End Function

    ' Función para buscar un producto
    Public Function Buscar_Producto(ByVal data As Propiedades) As DataTable
        Dim table As New DataTable()
        Try
            Using connection As New SqlConnection(connectionString)
                Using cmd As New SqlCommand("SP_BuscarProducto", connection)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@CodProd", data.cod_prod)

                    connection.Open()
                    Using adapter As New SqlDataAdapter(cmd)
                        adapter.Fill(table)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return table
    End Function

    ' Función para añadir un producto
    Public Function Añadir_Producto(ByVal data As Propiedades) As Boolean
        Try
            Using connection As New SqlConnection(connectionString)
                Using cmd As New SqlCommand("SP_AñadirProducto", connection)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@NumComp", data.cod_prod)
                    cmd.Parameters.AddWithValue("@Nombre", data.nombre)
                    cmd.Parameters.AddWithValue("@Existencias", data.existencias)
                    cmd.Parameters.AddWithValue("@Imagen", data.imagen)

                    connection.Open()
                    cmd.ExecuteNonQuery()
                    connection.Close()
                    Return True
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    ' Función para eliminar un producto
    Public Function Eliminar_Producto(ByVal data As Propiedades) As Boolean
        Try
            Using connection As New SqlConnection(connectionString)
                Using cmd As New SqlCommand("SP_EliminarProducto", connection)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@CodProd", data.cod_prod)

                    connection.Open()
                    cmd.ExecuteNonQuery()
                    connection.Close()
                    Return True
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    ' Función para modificar un producto
    Public Function Modificar_Producto(ByVal data As Propiedades) As Boolean
        Try
            Using connection As New SqlConnection(connectionString)
                Using cmd As New SqlCommand("SP_ModificarProducto", connection)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@CodProd", data.cod_prod)
                    cmd.Parameters.AddWithValue("@Nombre", data.nombre)
                    cmd.Parameters.AddWithValue("@Existencias", data.existencias)
                    cmd.Parameters.AddWithValue("@Imagen", data.imagen)

                    connection.Open()
                    cmd.ExecuteNonQuery()
                    connection.Close()
                    Return True
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
