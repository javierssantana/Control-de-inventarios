<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        PictureBox1 = New PictureBox()
        DataGridView1 = New DataGridView()
        btn_Modificar = New Button()
        btn_Cancelar = New Button()
        btn_Eliminar = New Button()
        btn_Añadir = New Button()
        btn_Buscar = New Button()
        OpenFileDialog1 = New OpenFileDialog()
        btn_CargarImagen = New Button()
        btn_Inicio = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        GroupBox1 = New GroupBox()
        ToolTip1 = New ToolTip(components)
        GroupBox2 = New GroupBox()
        MenuStrip1 = New MenuStrip()
        AcerceDe = New ToolStripMenuItem()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(19, 38)
        TextBox1.Margin = New Padding(3, 4, 3, 4)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(134, 27)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(19, 91)
        TextBox2.Margin = New Padding(3, 4, 3, 4)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(133, 27)
        TextBox2.TabIndex = 1
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(18, 148)
        TextBox3.Margin = New Padding(3, 4, 3, 4)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(134, 27)
        TextBox3.TabIndex = 2
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.MediumSlateBlue
        PictureBox1.Location = New Point(18, 198)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(243, 252)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridView1.BackgroundColor = Color.SlateBlue
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Cursor = Cursors.Hand
        DataGridView1.Location = New Point(26, 301)
        DataGridView1.Margin = New Padding(3, 4, 3, 4)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(560, 252)
        DataGridView1.TabIndex = 4
        ' 
        ' btn_Modificar
        ' 
        btn_Modificar.BackColor = Color.Turquoise
        btn_Modificar.Cursor = Cursors.Hand
        btn_Modificar.Location = New Point(115, 66)
        btn_Modificar.Margin = New Padding(3, 4, 3, 4)
        btn_Modificar.Name = "btn_Modificar"
        btn_Modificar.Size = New Size(86, 31)
        btn_Modificar.TabIndex = 5
        btn_Modificar.Text = "Modificar"
        btn_Modificar.UseVisualStyleBackColor = False
        ' 
        ' btn_Cancelar
        ' 
        btn_Cancelar.BackColor = Color.White
        btn_Cancelar.Cursor = Cursors.Hand
        btn_Cancelar.Location = New Point(451, 64)
        btn_Cancelar.Margin = New Padding(3, 4, 3, 4)
        btn_Cancelar.Name = "btn_Cancelar"
        btn_Cancelar.Size = New Size(86, 31)
        btn_Cancelar.TabIndex = 6
        btn_Cancelar.Text = "Limpiar"
        btn_Cancelar.UseVisualStyleBackColor = False
        ' 
        ' btn_Eliminar
        ' 
        btn_Eliminar.BackColor = Color.Red
        btn_Eliminar.Cursor = Cursors.Hand
        btn_Eliminar.Location = New Point(358, 66)
        btn_Eliminar.Margin = New Padding(3, 4, 3, 4)
        btn_Eliminar.Name = "btn_Eliminar"
        btn_Eliminar.Size = New Size(86, 31)
        btn_Eliminar.TabIndex = 7
        btn_Eliminar.Text = "Eliminar"
        btn_Eliminar.UseVisualStyleBackColor = False
        ' 
        ' btn_Añadir
        ' 
        btn_Añadir.BackColor = Color.LimeGreen
        btn_Añadir.Cursor = Cursors.Hand
        btn_Añadir.Location = New Point(23, 66)
        btn_Añadir.Margin = New Padding(3, 4, 3, 4)
        btn_Añadir.Name = "btn_Añadir"
        btn_Añadir.Size = New Size(86, 31)
        btn_Añadir.TabIndex = 8
        btn_Añadir.Text = "Añadir"
        btn_Añadir.UseVisualStyleBackColor = False
        ' 
        ' btn_Buscar
        ' 
        btn_Buscar.BackColor = Color.LimeGreen
        btn_Buscar.Cursor = Cursors.Hand
        btn_Buscar.Location = New Point(186, 35)
        btn_Buscar.Margin = New Padding(3, 4, 3, 4)
        btn_Buscar.Name = "btn_Buscar"
        btn_Buscar.Size = New Size(86, 31)
        btn_Buscar.TabIndex = 9
        btn_Buscar.Text = "Buscar"
        btn_Buscar.UseVisualStyleBackColor = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' btn_CargarImagen
        ' 
        btn_CargarImagen.AutoSize = True
        btn_CargarImagen.BackColor = Color.LimeGreen
        btn_CargarImagen.Cursor = Cursors.Hand
        btn_CargarImagen.Location = New Point(84, 467)
        btn_CargarImagen.Margin = New Padding(3, 4, 3, 4)
        btn_CargarImagen.Name = "btn_CargarImagen"
        btn_CargarImagen.Size = New Size(120, 33)
        btn_CargarImagen.TabIndex = 10
        btn_CargarImagen.Text = "Cargar Imagen"
        btn_CargarImagen.UseVisualStyleBackColor = False
        ' 
        ' btn_Inicio
        ' 
        btn_Inicio.BackColor = Color.RoyalBlue
        btn_Inicio.Cursor = Cursors.Hand
        btn_Inicio.Location = New Point(23, 27)
        btn_Inicio.Margin = New Padding(3, 4, 3, 4)
        btn_Inicio.Name = "btn_Inicio"
        btn_Inicio.Size = New Size(86, 31)
        btn_Inicio.TabIndex = 11
        btn_Inicio.Text = "Inicio"
        btn_Inicio.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(19, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(173, 20)
        Label1.TabIndex = 12
        Label1.Text = "Código del Componente"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(18, 67)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 20)
        Label2.TabIndex = 13
        Label2.Text = "Nombre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(19, 125)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 20)
        Label3.TabIndex = 14
        Label3.Text = "Cantidad"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.CornflowerBlue
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(btn_CargarImagen)
        GroupBox1.Controls.Add(btn_Buscar)
        GroupBox1.Controls.Add(PictureBox1)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Location = New Point(592, 34)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.Size = New Size(281, 519)
        GroupBox1.TabIndex = 15
        GroupBox1.TabStop = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.CornflowerBlue
        GroupBox2.Controls.Add(btn_Inicio)
        GroupBox2.Controls.Add(btn_Añadir)
        GroupBox2.Controls.Add(btn_Eliminar)
        GroupBox2.Controls.Add(btn_Cancelar)
        GroupBox2.Controls.Add(btn_Modificar)
        GroupBox2.Location = New Point(26, 159)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(548, 108)
        GroupBox2.TabIndex = 16
        GroupBox2.TabStop = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {AcerceDe})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(896, 24)
        MenuStrip1.TabIndex = 17
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' AcerceDe
        ' 
        AcerceDe.Name = "AcerceDe"
        AcerceDe.Size = New Size(71, 20)
        AcerceDe.Text = "Acerca de"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.Tomato
        BackgroundImage = My.Resources.Resources.azul
        ClientSize = New Size(896, 566)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(DataGridView1)
        Controls.Add(MenuStrip1)
        Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        Name = "Form1"
        Text = "Componentes de Electrónica"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_Modificar As Button
    Friend WithEvents btn_Cancelar As Button
    Friend WithEvents btn_Eliminar As Button
    Friend WithEvents btn_Añadir As Button
    Friend WithEvents btn_Buscar As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btn_CargarImagen As Button
    Friend WithEvents btn_Inicio As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AcerceDe As ToolStripMenuItem

End Class
