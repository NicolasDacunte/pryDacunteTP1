using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryDacunteTP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tlpAzul.ColumnCount = 20;
            tlpAzul.ColumnStyles.Clear();
            for (int i = 0; i < 10; i++)
            {
                tlpAzul.ColumnStyles.Add(new ColumnStyle(SizeType.Percent,
                (float)10));
            }

            tlpVerde.ColumnCount = 20;
            tlpVerde.ColumnStyles.Clear();
            for (int i = 0; i < 10; i++)
            {
                tlpVerde.ColumnStyles.Add(new ColumnStyle(SizeType.Percent,
                (float)10));
            }

            // panel contenedor para poner en una celda
            Panel panelAsiento = new Panel();
            int nro = 1; // número que tendrá el asiento
                         // crear el PictureBox
            PictureBox pic = new PictureBox();
            // agregar la imagen desde un archivo
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Image = pryDacunteTP1.Properties.Resources.azul;
            // agregar el pictureBox al panel
            panelAsiento.Controls.Add(pic);
            // crear el Label
            Label lbl = new Label();
            // asignar el texto a mostrar
            lbl.Text = nro.ToString();
            // agregar el Label al panel
            panelAsiento.Controls.Add(lbl);
            // agregar el panel al TableLayoutPanel en la fila 0, columna 0
            tlpAzul.Controls.Add(panelAsiento, 0, 0);

        }


    }
}
