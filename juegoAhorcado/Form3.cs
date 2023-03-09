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
    public partial class Form_Idioma : Form
    {
        public Form_Idioma()
        {
            InitializeComponent();

            buttonApply.BackgroundImage = showGameImage("./Resources/sell.png");
        }
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
        private void buttonApply_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Salir(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
