using Excel=Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace ExportacionExceldeDBC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnBusca.Image = Image.FromFile("..\\..\\resources\\buscar.png");
            btnExporta.Image = Image.FromFile("..\\..\\resources\\excel.png");
        }

   private void wait(int seconds) {
            for (int i = 0; i<=seconds * 100;i++) {
                System.Threading.Thread.Sleep(10);
                System.Windows.Forms.Application.DoEvents();
        }
    }
        private void Form1_Load(object sender, EventArgs e)
        {        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            this.ventascat.Fill(this.northwindDataSet.Ventas);
            btnExporta.Enabled = true;
        }
        private void btnExporta_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialogoGuardar = new SaveFileDialog();
            dialogoGuardar.Filter = "Hoja de cálculo de Microsoft Excel (*.xlsx)|*.xlsx";
            if (dialogoGuardar.ShowDialog() != DialogResult.OK) {
                return;
            }
            else {
                Excel.Application aplicacion;
                Excel.Workbook libros_trabajo;
                Excel.Worksheet hoja_trabajo;
                aplicacion = new Excel.Application();

                libros_trabajo = aplicacion.Workbooks.Open(Path.GetFullPath("..\\..\\resources\\") + "Plantilla.xlsx");
                hoja_trabajo = libros_trabajo.Worksheets[1];
                int renglones  = DGV.Rows.Count;
                if (renglones != 0)
                {
                    if (renglones > 1)
                    {
                        for (int i = 1; i <= renglones; i++)
                        {
                            hoja_trabajo.ListObjects[1].ListRows.AddEx();
                        }
                    }
                    int a = 3;
                    foreach (DataGridViewRow renglon in DGV.Rows)
                    {
                        hoja_trabajo.Cells[a, 1] = renglon.Cells[0].Value.ToString();
                        hoja_trabajo.Cells[a, 2] = renglon.Cells[1].Value.ToString();
                        hoja_trabajo.Cells[a, 3] = renglon.Cells[2].Value.ToString();
                        a = a + 1;
                    }
                    libros_trabajo.SaveAs(dialogoGuardar.FileName);
                    wait(3);
                    libros_trabajo.Close();
                    wait(3);
                    libros_trabajo = aplicacion.Workbooks.Open(dialogoGuardar.FileName);
                    wait(3);
                    libros_trabajo.Save();
                    wait(3);
                    aplicacion.Visible = true;
                    MessageBox.Show("Archivo creado");
                }
                else
                {
                    MessageBox.Show("No hay registros para exportar");
                }
        }
        }
    }
}
