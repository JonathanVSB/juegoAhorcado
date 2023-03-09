using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace juegoAhorcado
{

    public partial class Form1 : Form
    {

        //======================== LISTAS ==================
        //Lista con letras del Abecedario
        List<string> abecedario = new List<string> { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "Ñ", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

        //Lista que contiene las palabras a adivinar
        public List<string> words = new List<string>();

        //Lista de Textboxes para alamcenar la palabra secreta
        List<TextBox> listTextBox = new List<TextBox>();

        //Lista[] de refuerzo para usar en caso de ser necesario
        char[] listaAuxiliar;

        //=================================================

        //=================== VARIABLES DE JUEGO =============

        //Random para elegir aleatoriamente la palabra
        Random random = new Random();

        //Variable de intentos para controlar el juego
        int intentos = 0;

        //Varaibel de aciertos que tiene el jugador
        int aciertos = 0;

        //Tiempo por defecto estbalecido en el juego
        int defaultTime = 60;

        //Valiable que servira de contador para el cronometro
        public int playTime;

        //variable para controlar si el modo invierno esta activado
        bool invierno = false;

        //variable para controlar si el modo Bosque esta activado
        bool bosque = false;

        //=================================================

        //============IMAGENES ESTÁTICAS===================

        String backgroundImage = "./Resources/Background.png";

        String pierdeBackground = "./Resources/medieval_castle.jpg";
        String coldBackground = "./Resources/paisaje-nevado.jpg";

        String forestBackground = "./Resources/bosque.jpg";

        String iceCube = "./Resources/ice-cube.png";
        String woods = "./Resources/madera.png";

        String rutaPalabras = "./palabras-español.txt";

        //=================================================

        //============ SONIDOS DEL JUEGO ==================

        String victorysong = "./gamemusic/saul-goodman-better-call-saul.wav";
        String correctsound = "./gamemusic/coin_1.wav";
        String almostDead = "./gamemusic/la-vas-a-matar-perro-.wav";
        String errorsound = "./gamemusic/im-a-gnome-meme-sound-effect-woo.wav";
        String gameover = "./gamemusic/73-Game-Over.wav";
        String stopTime = "./gamemusic/time-stop.wav";

        //=================================================

        

        Form_Time formTime = new Form_Time();


        public Form1()
        {
            InitializeComponent();

            //Cargamos las palabras de juego por defecto en español
            words = fillWords(rutaPalabras, 0);
            displayIdioma(0);
            showBackground();
            playTime = defaultTime;
            startGame(words);
        }
        /// <summary>
        /// Funcion encargada de inciar el juego.
        /// Genera una palabra automaticamente usando un aleatorio.
        /// Crea un apnel para el teclado de juego.
        /// En caso de que previamente existeran  los borraria y genraria unos nuevos.
        /// </summary>
        public void startGame(List<string> words)
        {
            // Boolean playing = true;

            if (playTime == 0)
            {
                playTime = defaultTime;
            }
            //else
            //{
            //    playTime = playTime;
            //}

            intentos = 0;
            aciertos = 0;

            nuevoToolStripMenuItem.Enabled = false;
            //Generamos una palabra aleatoriamente con un método
            String S_Word = generateWord(words, random);

            pictureBox1.Image = showGameImage("nada");
            pictureBox1.Visible = true;

            showBackground();
            listTextBox = crearTextbox(S_Word);
            nuevoToolStripMenuItem.Enabled = false;


            createKeyboard(abecedario, flowLayoutPanel1);
            flowLayoutPanel1.Visible = true;
            flowLayoutPanel1.Enabled = true;


            timer1.Start();

        }
        /// <summary>
        /// Vacia el Flow layout panel de posible información
        /// rellena el Flow layout panel con los botenes que haran de teclado al juego
        /// </summary>
        /// <param name="abecedario"></param>
        /// <param name="flowLayoutPanel1"></param>
        private void createKeyboard(List<string> abecedario, FlowLayoutPanel flowLayoutPanel1)
        {
            flowLayoutPanel1.Controls.Clear();
            int a = 0;
            foreach (string x in abecedario)
            {
                Button btn = new Button();
                btn.Location = new System.Drawing.Point(30 + a, 60);
                a += 40;
                btn.Size = new System.Drawing.Size(30, 30);
                btn.Text = x;
                btn.Click += Compara;
                btn.FlatStyle = FlatStyle.Popup;
                btn.BackColor = Color.White;
                flowLayoutPanel1.Controls.Add(btn);

                if (invierno == true)
                {
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    btn.BackgroundImage = showGameImage(iceCube);
                }
                else if (bosque == true)
                {
                    btn.BackgroundImageLayout = ImageLayout.Stretch;

                    btn.BackgroundImage = showGameImage(woods);
                }

            }


        }

        /// <summary>
        /// Carga una imagen desde la ruta que se le muestre y la pone de fondo
        /// Controla la excepcion al cargar la foto.
        /// </summary>
        /// <param name="ruta"></param>
        private void showBackground()
        {
            string ruta = "";
            if (invierno == true)
            {
                ruta = coldBackground;
            }
            else if (bosque == true)
            {
                ruta = forestBackground;
            }
            

            else
            {
                ruta = backgroundImage;

            }

            try
            {
                this.BackgroundImage = Image.FromFile(ruta);

            }
            catch (FileNotFoundException ex)
            {

                throw;
            }


        }
        /// <summary>
        /// Recibe el nombre de un objeto SoundPlayer
        /// Controla posibles errores con la ruta del objeto
        /// Si no hay ningun error, reproduce el sonido indicado
        /// </summary>
        /// <param name="name"></param>
        private void playGameSound(String name)
        {
            try
            {
                SoundPlayer song = new SoundPlayer(name);
                song.Play();
            }
            catch (FileNotFoundException ex)
            {

                throw;
            }
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

        /// <summary>
        /// recibe la palabra secreta con la que se jugará
        /// Separa la palabra en una lista [] de chars con cada letra de la palbra
        /// Crea una lista de textboxes para rellenar con las letras de la palabra 
        /// Limpia la lista de loq ue pudiese haber previamente
        /// </summary>
        /// <param name="S_Word"></param>
        /// <returns>Lista de textboxes</returns>
        private List<TextBox> crearTextbox(string S_Word)
        {
            List<TextBox> listTextBox = new List<TextBox>();


            textBoxPanel.Controls.Clear();
            int a = 0;
            char[] secretWord = S_Word.ToCharArray(0, S_Word.Length);

            listaAuxiliar = secretWord;

            for (int i = 0; i < S_Word.Length; i++)
            {


                TextBox textbox = new TextBox();
                textbox.Location = new System.Drawing.Point(100 + a, 350);

                a += 40;
                //textbox.Si
                textbox.Size = new System.Drawing.Size(30, 60);
                textbox.Font = new Font(textbox.Font, FontStyle.Bold);
                textbox.Width = 30;
                textbox.Height = 190;
                textbox.Font = new Font("Tahoma", 17, FontStyle.Bold);
                textbox.BorderStyle = BorderStyle.FixedSingle;
                textbox.TextAlign = HorizontalAlignment.Center;
                textbox.ReadOnly = true;

                // textbox.Text = secretWord[i].ToString();
                textbox.ForeColor = System.Drawing.Color.Black;


                if (invierno == true)
                {
                    textbox.BackColor = Color.Turquoise;
                }
                else if (bosque == true)
                {
                    textbox.BackColor = Color.ForestGreen;
                    textbox.BorderStyle = BorderStyle.Fixed3D;
                }
                else
                {
                    textbox.BackColor = System.Drawing.Color.White;
                }


                listTextBox.Add(textbox);

                textBoxPanel.Controls.Add(textbox);
            }

            return listTextBox;
        }

        /// <summary>
        /// Usa random para elegir un numero.
        /// El numero aleatorio será utilizado para elegir una palbra de la lista Words
        /// </summary>
        /// <param name="words"></param>
        /// <param name="random"></param>
        /// <returns> devuelve la plabra con la que se jugará </returns>
        private string generateWord(List<string> words, Random random)
        {
            String palabra;
            int num = random.Next(0, (words.Count));
            palabra = words[num];
            return palabra;
        }
        /// <summary>
        /// Rellena la lista words con las palabras que estaran en el juego.
        /// TODO
        /// Estas palabras mas adelante seran reemplazadas por un documento de texto
        /// </summary>
        private List<string> fillWords(String path, int num)
        {
            List<string> words = new List<string>();

            try
            {
                StreamReader lector = null;
                if (File.Exists(path))
                {
                    lector = new StreamReader(File.OpenRead(path));
                    while (!lector.EndOfStream)
                    {
                        String line = lector.ReadLine();
                        //label1.Text = linea.Split(',')[0];
                        words.Add(line.Split(',')[num]);

                    }
                }


            }
            catch (Exception) { }
            return words;
        }


        /// <summary>
        /// Temporizador del juego. 
        /// intervalo = 1000 (1seg)
        /// cada segundo la variable de tiempo decrece en uno y la muestra en el label clockLabel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            playTime--;

            clockLabel.Text = playTime.ToString();



            if (playTime < 11)
            {
                clockLabel.ForeColor = Color.Red;
            }
            else
            {
                clockLabel.ForeColor = Color.Black;
            }

            if (playTime == 4)
            {
                playGameSound(stopTime);

            }
            if (playTime == 0)
            {

                timer1.Enabled = false;
                hasLost();

            }
        }

        /// <summary>
        /// Reinicia el juego una vez terminada una partida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //PlayTime = 60;
            //clockLabel.Text = "TIME";

            //changeTime(60);
            SoundPlayer sound = new SoundPlayer();
            sound.Stop();

            startGame(words);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="v"></param>
        public void changeTime(int v)
        {
            TimePanel.Controls.Clear();
            playTime = v;

            TimePanel.Controls.Add(clockLabel);
            clockLabel.Text = playTime.ToString();
        }

        /// <summary>
        /// Cuando detecta un clic a un boton del teclado
        /// Revisa si la letra correspondiente al clic es igual a alguna de las letras de la palabra a adivinar
        /// Si encuentra coincidencias 
        /// --- desactiva ese boton y rellena los textbox correspondientes
        /// --- aumenta los aciertos.
        /// --- Reproduce el sonido de aciertos
        /// Si no encuentra concidencias cambia la imagen del PictureBox
        /// --- desactiva el boton
        /// --- aumenta los fallos
        /// --- Reproduce el sonido de fallar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Compara(object sender, EventArgs e)

        {

            Button btn = (Button)sender;
            btn.BackColor = Color.Red;

            btn.Enabled = false;
            int cont = 0;

            for (int i = 0; i < listaAuxiliar.Length; i++)
            {
                if (btn.Text.Equals(listaAuxiliar[i].ToString()))
                {
                    listTextBox[i].Text = listaAuxiliar[i].ToString();

                    //playing = true;
                    playGameSound(correctsound);
                    aciertos++;

                }
                else
                {
                    cont++;
                }

                if (cont == listTextBox.Count)
                {

                    playGameSound(errorsound);
                    intentos++;

                    string numImage = intentos.ToString();

                    pictureBox1.Image = showGameImage("./Resources/" + numImage + ".png");
                }

                if (invierno == true)
                {
                    btn.BackgroundImageLayout = ImageLayout.None;

                }
                else if (bosque == true)
                {
                    btn.BackgroundImageLayout = ImageLayout.None;
                }

                checkGameSate(aciertos, intentos);

            }
        }

        /// <summary>
        /// Comprueba el estado del juego en base a los aciertos e intentos
        /// si los aciertos son iguales a la suma total de letras de la palabra a adivinar, llama a la funcion ganador
        /// Si los intentos son iguales a 10 y los aciertos son menos que la suma de letras de la plabra a adivinar, llama a funcion de perder
        /// </summary>
        /// <param name="aciertos"></param>
        private void checkGameSate(int aciertos, int intentos)
        {
            if (intentos == 10)
            {
                hasLost();
            }
            else if (aciertos == listTextBox.Count)
            {
                hasWin();

            }
        }

        /// <summary>
        /// Funcion que controla los eventos si el usuario pierde
        /// Detiene el tiempo de temporizador
        /// Rellena las letras que falten y pone el fondo del textbox en rojo
        /// Reproduce la canción correspondiente
        /// Oculta el panel del teclado y el picturebox
        /// Muestra el message box correspondiente.
        /// Activa el boton de Restart.
        /// </summary>
        private void hasLost()
        {
            timer1.Stop();
            for (int i = 0; i < listTextBox.Count; i++)
            {
                if (listTextBox[i].Text.Equals(""))
                {
                    listTextBox[i].Text = listaAuxiliar[i].ToString();
                    listTextBox[i].BackColor = Color.Red;
                }
            }


            playGameSound(gameover);
            this.BackgroundImage = Image.FromFile(pierdeBackground);
            pictureBox1.Visible = false;

            flowLayoutPanel1.Enabled = false;
            flowLayoutPanel1.Visible = false;

            MessageBox.Show("Has perdido...");
            nuevoToolStripMenuItem.Enabled = true;
            playTime = 0;


        }

        /// <summary>
        /// Detiene el temporizador
        /// Si no hay ningun error reproduce la cancion de victoria
        /// Muestra el message box de victoria
        /// Desactiva el flowLayoutPanel1 (El teclado de juego)
        /// Activa el boton de Restart
        /// </summary>
        private void hasWin()
        {
            //timer1.Enabled = false;
            timer1.Stop();
            playGameSound(victorysong);
            aciertos = -1;

            flowLayoutPanel1.Enabled = false;
            nuevoToolStripMenuItem.Enabled = true;

            DialogResult res = MessageBox.Show("", "LO LOGRASTE!!", MessageBoxButtons.OK);

            if (res == DialogResult.OK)
            {
                playTime = 0;
            }
        }

        /// <summary>
        /// Controla la salida del programa.
        /// Si el usuario intenta cerrar la ventana, 
        /// El tiempo se pausa
        /// Se le muestra un cuadro de dialogo con 2 opciones donde se le pregunta si quiere salir 
        /// si el Usuario devuelve la opcion Yes. se cerrará la ventanay el juego
        /// si el usuario devuelve No, continuará el juego y el cronometro volverá funcionar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        #region metodos menu
        private void Salir(object sender, FormClosingEventArgs e)
        {
            String aviso = "Estás seguro de que quieres salir ?";
            timer1.Stop();

            DialogResult res = MessageBox.Show(aviso, "", MessageBoxButtons.YesNo);

            if (res == DialogResult.No)
            {
                timer1.Start();
                e.Cancel = true;
            }


        }
        /// <summary>
        /// Controla la salida de juego desde el menu
        /// cuando el usuario selecciona la opcion salir desde el menu, se llamará al metodo Salir()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Llama al form del tiempo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tiempoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            timer1.Enabled = false;
            //timer1.Stop();
            if (formTime.ShowDialog() == DialogResult.OK)
            {
                playTime = (int)formTime.numericUpDown1.Value;
                nuevoToolStripMenuItem_Click(sender, e);

            }
            
            TimePanel.Controls.Clear();

            defaultTime = (int)formTime.numericUpDown1.Value;
            changeTime(defaultTime);

        }

        #endregion

        /// <summary>
        /// Devuelve el juego a sus ajustes predeterminados.
        /// El tiempo vuelve a 60 segundos
        /// Las palabras de juego seran entre 10 y 5 
        /// El fondo de pantalla fuelve a ser el normal.
        /// reiniciaremos el juego
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ajustesPredeterminadosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            playTime = 60;
            words = Medida(2);
            displayIdioma(0);
            invierno = false;
            bosque = false;
            TimePanel.BackColor = Color.Transparent;
            startGame(words);
        }

        /// <summary>
        /// Cambia la apariencia del juego a invierno
        /// Reestablece el tiempo de inicio de juego
        /// activa la variable Bosque para hacerle saber al resto de metodos como crear teclados y textboxes del juego
        /// modifica el panel del tiempo para darle un color mas adecuado con el fondo
        /// reinicia el juego.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void inviernoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            changeTime(defaultTime);
            invierno = true;
            bosque = false;
            TimePanel.BackColor = Color.Transparent;
            nuevoToolStripMenuItem_Click(sender, e);

        }

        /// <summary>
        /// cambia la apariencia del juego a modo bosque
        /// Reestablece el tiempo de inicio de juego
        /// activa la variable Bosque para hacerle saber al resto de metodos como crear teclados y textboxes del juego
        /// modifica el panel del tiempo para darle un color mas adecuado con el fondo
        /// reinicia el juego.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bosqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeTime(playTime);
            invierno = false;
            bosque = true;
            TimePanel.BackColor = Color.LightGreen;
            nuevoToolStripMenuItem_Click(sender, e);

        }

        /// <summary>
        /// Establede el idioma de las palabras que seran usadas en el juego
        /// Muestra un nuevo form que da a elegir. la eleccion del usuario se traducirá a un int que se usara para identificar el idioma
        /// Si la respuesta dada por el usuarion no es correcta, se mantendrá el idioma por defecto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void idiomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Idioma form_Idioma = new Form_Idioma();
            timer1.Stop();
            int result = 0;

            if (form_Idioma.ShowDialog() == DialogResult.OK)
            {
                if (form_Idioma.comboBox1.Text.Equals("Ingles"))
                {

                    result = 2;
                }
                else if (form_Idioma.comboBox1.Text.Equals("Catalan"))
                {

                    result = 1;
                }
                else
                {
                    result = 0;
                }

            }

            
            displayIdioma(result);
            words = fillWords(rutaPalabras, result);
            changeTime(defaultTime);
            nuevoToolStripMenuItem_Click(sender, e);

        }

        /// <summary>
        /// Muestra al usuario, el idioma actual de juego
        /// con el valor de la variable int especificada, cambiara el nombre del idioma en el label 
        /// </summary>
        /// <param name="result"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void displayIdioma(int result)
        {
            string idioma = "";

            if (result == 2)
            {
                idioma = "Ingles";
            }
            else if (result == 1)
            {
                idioma = "Catalan";
            }
            else
            {
                idioma = "Castellano";
            }


            selecIdiomaLabel.Text = "IDIOMA: " + idioma;
        }

        /// <summary>
        /// Funcion llama al formulario de cabiar la medida de las palabras
        /// recoge la respuesta del formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void medidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Tamaño form_Tamaño = new Form_Tamaño();
            timer1.Stop();
            int num = 0;
            if (form_Tamaño.ShowDialog() == DialogResult.OK)
            {
                if (form_Tamaño.radioButton1.Checked)
                {
                    num = 1;
                }
                else if (form_Tamaño.radioButton2.Checked)
                {
                    num = 2;
                }
                else 
                {
                    num = 3;
                }
            }

            
            words= Medida(num);
            changeTime(defaultTime);
            nuevoToolStripMenuItem_Click(sender, e);

        }

        /// <summary>
        /// Rellena la lista de palabras con las palabras 
        /// segun la opcion indicada con el num,
        /// devolverá palabras del idioma que este seleccionado.
        /// </summary>
        /// <param name="num"></param>
        /// <returns>lista con el numero de plabras deseado</returns>
        private List<String> Medida(int num)
        {
            words.Clear();
            int idioma = 0;

            if (selecIdiomaLabel.Equals("IDIOMA: Castellano"))
            {
                idioma = 0;
            }
            else if (selecIdiomaLabel.Equals("IDIOMA: Catalan"))
            {
                idioma = 1;
            }
            else if (selecIdiomaLabel.Equals("IDIOMA: Ingles"))
            {
                idioma = 2;
            }

            List<string> palabras = new List<string>();

            if (num==1)
            {
                foreach (string item in fillWords(rutaPalabras,idioma))
                {
                    if (item.Length<5)
                    {

                        palabras.Add(item);
                    }
                }
            }
            else if (num == 2)
            {
                foreach (string item in fillWords(rutaPalabras, idioma))
                {
                    if (item.Length<10 && item.Length>5)
                    {
                     palabras.Add(item);
                    }
                }
            }
            else 
            {
                foreach (string item in fillWords(rutaPalabras, idioma))
                {

                    if (item.Length >10)
                    {
                        palabras.Add(item);
                    }

                }
            }

            return palabras;
            
            
        }

        /// <summary>
        /// Abriremos un fichero del sistema para leerlo y jugar con las palabras que contenga.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            timer1.Start();
            words.Clear();

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.DefaultExt = "txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            timer1.Start();
            MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
            words = fillWords(filePath, 0);
            changeTime(defaultTime);
            nuevoToolStripMenuItem_Click(sender, e);
        }

        /// <summary>
        /// Modo facil del juego
        /// el tiempo sera el 90 segundos
        /// El jugador solo usará palabras de menos de 5 letras
        /// reinicio juego
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void facilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeTime(90);
            words = Medida(1);
            startGame(words);

        }

        /// <summary>
        /// El juego volverá ajustes predeterminados ya que este esel modo normal por defecto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ajustesPredeterminadosToolStripMenuItem_Click_1(sender, e);

        }

        /// <summary>
        /// El tiempo será 20 segundos
        /// El jugador solo jugará con palabras de mas de 10 letras
        /// El usuario solo jugará con palabras en ingles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dificilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            displayIdioma(2);
            changeTime(20);
            
            words = Medida(3);
            startGame(words);

        }
    }
}
