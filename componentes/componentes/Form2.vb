Public Class Form2

    ' Configuración del Label para mostrar misión, visión y valores
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarLabel()
    End Sub

    Private Sub ConfigurarLabel()
        Label1.AutoSize = False
        Label1.Size = New Size(450, 490) ' Ajusta estas dimensiones según tus necesidades
        Label1.Text = "Misión: Nuestra misión es facilitar la gestión y el seguimiento de los componentes electrónicos para estudiantes de ingeniería, proporcionando una herramienta intuitiva y eficiente que permite organizar y acceder a la información de manera rápida y precisa. Queremos apoyar el aprendizaje práctico y contribuir al éxito académico de nuestros usuarios mediante la tecnología y la innovación." & vbCrLf & vbCrLf &
                      "Visión: Aspiramos a ser una plataforma para la gestión de componentes electrónicos en el ámbito educativo, reconocida por su facilidad de uso, funcionalidad y capacidad para potenciar el aprendizaje de los estudiantes de ingeniería. Buscamos crear un entorno donde los estudiantes puedan enfocarse en sus proyectos y experimentos sin preocuparse por la logística de sus componentes, fomentando así la creatividad y la innovación." & vbCrLf & vbCrLf &
                      "Valores: 1. Innovación: Estamos comprometidos con la innovación constante para ofrecer las herramientas más avanzadas y relevantes que faciliten el aprendizaje y la gestión de recursos." & vbCrLf &
                      "2. Accesibilidad: Creamos soluciones intuitivas y accesibles para todos los estudiantes, independientemente de su nivel de experiencia o conocimiento técnico." & vbCrLf &
                      "3. Calidad: Valoramos la calidad en cada aspecto de nuestra aplicación, asegurándonos de que sea fiable y eficaz para satisfacer las necesidades de nuestros usuarios." & vbCrLf &
                      "4. Compromiso: Estamos dedicados a apoyar el éxito académico de los estudiantes de ingeniería, brindándoles recursos y herramientas que enriquezcan su experiencia educativa."

        Label1.Font = New Font("Arial", 10, FontStyle.Regular)
        Label1.TextAlign = ContentAlignment.TopLeft
        Label1.Padding = New Padding(10)
    End Sub
End Class
