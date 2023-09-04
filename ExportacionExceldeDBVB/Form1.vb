Imports System.IO
Imports System.Security.Cryptography
Imports Microsoft.Office.Interop

Public Class Form1
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        btnBusca.Image = Image.FromFile("..\\..\\resources\\buscar.png")
        btnExporta.Image = Image.FromFile("..\\..\\resources\\excel.png")
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub btnBusca_Click(sender As Object, e As EventArgs) Handles btnBusca.Click
        Me.VentasporVentascat.Fill(Me.NorthwindDataSet.VentasPorcat)
        btnExporta.Enabled = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExporta_Click(sender As Object, e As EventArgs) Handles btnExporta.Click
        Dim dialogoGuardar As SaveFileDialog = New SaveFileDialog()
        dialogoGuardar.Filter = "Hoja de cálculo de Microsoft Excel (*.xlsx)|*.xlsx"
        If (dialogoGuardar.ShowDialog() <> DialogResult.OK) Then
            Return
        Else
            Dim aplicacion As Excel.Application
            Dim libros_trabajo As Excel.Workbook
            Dim hoja_trabajo As Excel.Worksheet
            aplicacion = New Excel.Application()

            libros_trabajo = aplicacion.Workbooks.Open(Path.GetFullPath("..\\..\\resources\\") + "Plantilla.xlsx")
            hoja_trabajo = libros_trabajo.Worksheets(1)
            'hoja_trabajo.EnableSelection = Microsoft.Office.Interop.Excel.XlEnableSelection.xlNoSelection
            Dim renglones As Integer = DGV.Rows.Count
            If renglones <> 0 Then
                If renglones > 1 Then
                    For i As Integer = 1 To renglones
                        hoja_trabajo.ListObjects(1).ListRows.AddEx()
                    Next
                End If
                Dim a As Integer = 3
                For Each renglon As DataGridViewRow In DGV.Rows
                    hoja_trabajo.Cells(a, 1) = renglon.Cells(0).Value.ToString()
                    hoja_trabajo.Cells(a, 2) = renglon.Cells(1).Value.ToString()
                    hoja_trabajo.Cells(a, 3) = renglon.Cells(2).Value.ToString()
                    a = a + 1
                Next
                libros_trabajo.SaveAs(dialogoGuardar.FileName)
                wait(3)
                libros_trabajo.Close()
                wait(3)
                libros_trabajo = aplicacion.Workbooks.Open(dialogoGuardar.FileName)
                wait(3)
                libros_trabajo.Save()
                wait(3)
                aplicacion.Visible = True
                MessageBox.Show("Archivo creado")
            Else
                MessageBox.Show("No hay registros para exportar")
            End If
        End If
        'libros_trabajo.SaveAs(dialogoGuardar.FileName)
        'MessageBox.Show("Archivo creado")
        'For Each row In DGV.Rows

        'Next
    End Sub
    Private Sub wait(ByVal seconds As Integer) 'suspende la ejecucion un tiempo especifico de segundos
        For i As Integer = 0 To seconds * 100 'realiza el conteo de segundos por 100 para hacerlos equivalentes a la cantidad de milisegundos a esperar
            System.Threading.Thread.Sleep(10) 'suspende la ejecucion 10 milisegundos
            Application.DoEvents() 'procesa lo que esta en espera
        Next
    End Sub
End Class
