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

namespace juegoAhorcado
{
    public partial class Form_Time : Form
    {
        public Form_Time()
        {
            InitializeComponent();


            buttonApply.BackgroundImage = showGameImage("./Resources/sell.png");
        }

        /// <summary>
        /// Carga imagen de la ruta indicada
        /// Controla posibles errores con la ruta del objeto
        /// Si no hay ningun error, devuelve la imagen indicada
        /// </summary>
        public Image showGameImage(String ruta)
        {
            Image image;
            if (ruta.Equals("nada"))
            {
                image = null;
            }
            else
            {
                try
                {
                    image = Image.FromFile(ruta);
                    return image;
                }
                catch (FileNotFoundException ex)
                {

                    throw;
                }


            }

            return image;


        }

        public void buttonApply_Click(object sender, EventArgs e)
        {
            //Form1 form1 = new Form1();
            Close();

        }

        private void cerrarAjuste(object sender, FormClosedEventArgs e)
        {
            Close();

        }

        private void salir(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            

        }
    }
}
