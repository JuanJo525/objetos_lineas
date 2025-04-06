using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace objetos_lineas
{
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
        }

        private void btn_dibujar_Click(object sender, EventArgs e)
        {
            int x1, y1, x2, y2;

            

            if (txt_X1.Text == "" || txt_X2.Text == "" || txt_Y1.Text == "" || txt_Y2.Text == "") 
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
            else
            {
                x1 = int.Parse(txt_X1.Text);
                y1 = int.Parse(txt_Y1.Text);
                x2 = int.Parse(txt_X2.Text);
                y2 = int.Parse(txt_Y2.Text);

                if (x1 < 0 || x2 < 0 || y1 < 0 || y2 < 0)
                {
                    MessageBox.Show("Los valores deben ser positivos");
                }
                else
                {
                    int alto = this.Height;
                    int ancho = this.Width;
                    
                    if (x1 > ancho || x2 > ancho)
                    {
                        MessageBox.Show("El valor de X no puede ser mayor que el ancho del formulario: " + ancho );
                        return;
                    }
                    if (y1 > alto || y2 > alto)
                    {
                        MessageBox.Show("El valor de Y no puede ser mayor que el alto del formulario: " + alto);
                        return;
                    }


                    Cls_Lineas linea = new Cls_Lineas(x1, y1, x2, y2);
                    linea.DibujarLinea(CreateGraphics());

                    lbl_CantiadL.Text = "Cantidad de lineas: " + Cls_Lineas.totalLineas.ToString();
                    txt_X1.Clear();
                    txt_X2.Clear();
                    txt_Y1.Clear();
                    txt_Y2.Clear();
                }
            }

           

            
        }
    }
}
