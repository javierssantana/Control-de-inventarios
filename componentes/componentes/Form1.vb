Imports System.Data
Imports System.Data.SqlClient

Public Class Form1
    Dim connectionString As String = "Data Source=DESKTOP-7K1HMM5\SQLEXPRESS;Initial Catalog=componentes;Integrated Security=True"

    ' Cargar todos los productos al iniciar la aplicación
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarTodosLosProductos()

        ToolTip1.SetToolTip(TextBox1, "Ingrese el código del producto (4 caracteres).")
        ToolTip1.SetToolTip(TextBox2, "Ingrese el nombre del producto.")
        ToolTip1.SetToolTip(TextBox3, "Ingrese la cantidad de existencias.")
        ToolTip1.SetToolTip(PictureBox1, "Haga clic para cargar una imagen del producto.")


    End Sub

    ' Función para cargar todos los productos
    Private Sub CargarTodosLosProductos()
        Try
            Dim func As New DatabaseFunctions()
            Dim productos As DataTable = func.Mostrar_Todos_Productos()
            DataGridView1.DataSource = productos
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' Botón para cargar una imagen
    Private Sub btn_CargarImagen_Click(sender As Object, e As EventArgs) Handles btn_CargarImagen.Click
        OpenFileDialog1.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    ' Botón para buscar un producto
    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            MessageBox.Show("Ingrese un código de producto válido", "Buscar Producto", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim data As New Propiedades()
            data.cod_prod = TextBox1.Text

            Dim func As New DatabaseFunctions()
            Dim producto As DataTable = func.Buscar_Producto(data)

            If producto.Rows.Count > 0 Then
                DataGridView1.DataSource = producto
                MessageBox.Show("Producto encontrado correctamente", "Buscar Producto")
            Else
                DataGridView1.DataSource = Nothing
                MessageBox.Show("Producto no encontrado", "Buscar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' Botón para añadir un producto
    Private Sub btn_Añadir_Click(sender As Object, e As EventArgs) Handles btn_Añadir.Click
        Dim campos As New Dictionary(Of String, String) From {
            {"num_comp", TextBox1.Text},
            {"nombre", TextBox2.Text},
            {"existencias", TextBox3.Text}
        }

        If Not ValidarDatos.Validar(campos) Then
            Return
        End If

        Try
            Dim data As New Propiedades()
            data.cod_prod = TextBox1.Text
            data.nombre = TextBox2.Text
            data.existencias = Integer.Parse(TextBox3.Text)
            data.imagen = ImageConverter.ToByteArray(PictureBox1.Image)

            Dim func As New DatabaseFunctions()
            If func.Añadir_Producto(data) Then
                MessageBox.Show("Producto añadido correctamente", "Añadir Producto")
                LimpiarCampos()
                CargarTodosLosProductos()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' Función para limpiar los campos del formulario
    Private Sub LimpiarCampos()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        PictureBox1.Image = Nothing
    End Sub

    ' Botón para eliminar un producto
    Private Sub btn_Eliminar_Click(sender As Object, e As EventArgs) Handles btn_Eliminar.Click
        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            MessageBox.Show("Ingrese un código de producto válido", "Eliminar Producto", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("¿Seguro que desea eliminar este producto?", "Eliminar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Try
                Dim data As New Propiedades()
                data.cod_prod = TextBox1.Text

                Dim func As New DatabaseFunctions()
                If func.Eliminar_Producto(data) Then
                    MessageBox.Show("Producto eliminado correctamente", "Eliminar Producto")
                    LimpiarCampos()
                    CargarTodosLosProductos()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    ' Botón para modificar un producto
    Private Sub btn_Modificar_Click(sender As Object, e As EventArgs) Handles btn_Modificar.Click
        Dim campos As New Dictionary(Of String, String) From {
            {"num_comp", TextBox1.Text},
            {"nombre", TextBox2.Text},
            {"existencias", TextBox3.Text}
        }

        If Not ValidarDatos.Validar(campos) Then
            Return
        End If

        Try
            Dim data As New Propiedades()
            data.cod_prod = TextBox1.Text
            data.nombre = TextBox2.Text
            data.existencias = Integer.Parse(TextBox3.Text)

            ' Convierte la imagen sólo si hay una imagen en el PictureBox
            If PictureBox1.Image IsNot Nothing Then
                data.imagen = ImageConverter.ToByteArray(PictureBox1.Image)
            Else
                data.imagen = Nothing
            End If

            Dim func As New DatabaseFunctions()
            If func.Modificar_Producto(data) Then
                MessageBox.Show("Producto modificado correctamente", "Modificar Producto")
                CargarTodosLosProductos()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' Botón para cancelar la operación
    Private Sub btn_Cancelar_Click(sender As Object, e As EventArgs) Handles btn_Cancelar.Click
        LimpiarCampos()
    End Sub

    ' Evento para mostrar datos e imagen al hacer clic en un registro del DataGridView
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            TextBox1.Text = row.Cells("num_comp").Value.ToString()
            TextBox2.Text = row.Cells("nombre").Value.ToString()
            TextBox3.Text = row.Cells("existencias").Value.ToString()

            If Not IsDBNull(row.Cells("imagen").Value) Then
                Dim imageData As Byte() = CType(row.Cells("imagen").Value, Byte())
                Using ms As New System.IO.MemoryStream(imageData)
                    PictureBox1.Image = Image.FromStream(ms)
                End Using
            Else
                PictureBox1.Image = Nothing
            End If
        End If
    End Sub

    ' Botón de inicio para mostrar todos los productos
    Private Sub btn_Inicio_Click(sender As Object, e As EventArgs) Handles btn_Inicio.Click
        CargarTodosLosProductos()
    End Sub

    Private Sub AcerceDe_Click(sender As Object, e As EventArgs) Handles AcerceDe.Click

        Dim Form2 As New Form2()
        Form2.Show()
    End Sub
End Class
