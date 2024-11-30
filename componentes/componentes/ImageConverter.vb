Public Class ImageConverter
    Public Shared Function ToByteArray(image As Image) As Byte()
        Using ms As New System.IO.MemoryStream()
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Png) ' PNG para compresión
            Return ms.ToArray()
        End Using
    End Function
End Class


