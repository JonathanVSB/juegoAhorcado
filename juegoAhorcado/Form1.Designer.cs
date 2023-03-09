namespace juegoAhorcado
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.clockLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.juegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiempoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nivelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dificilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idiomaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puntuaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aparienciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inviernoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bosqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajustesPredeterminadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TimePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.selecIdiomaLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TimePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(484, 158);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(304, 157);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // clockLabel
            // 
            this.clockLabel.AutoSize = true;
            this.clockLabel.BackColor = System.Drawing.Color.Transparent;
            this.clockLabel.Font = new System.Drawing.Font("MS PGothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockLabel.Location = new System.Drawing.Point(3, 0);
            this.clockLabel.Name = "clockLabel";
            this.clockLabel.Size = new System.Drawing.Size(74, 27);
            this.clockLabel.TabIndex = 0;
            this.clockLabel.Text = "TIME";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tag = "timeGame";
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.juegoToolStripMenuItem,
            this.opcionesToolStripMenuItem,
            this.puntuaciónToolStripMenuItem,
            this.otrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // juegoToolStripMenuItem
            // 
            this.juegoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.juegoToolStripMenuItem.Name = "juegoToolStripMenuItem";
            this.juegoToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.juegoToolStripMenuItem.Text = "Juego";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiempoToolStripMenuItem,
            this.medidaToolStripMenuItem,
            this.nivelToolStripMenuItem,
            this.idiomaToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // tiempoToolStripMenuItem
            // 
            this.tiempoToolStripMenuItem.Name = "tiempoToolStripMenuItem";
            this.tiempoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tiempoToolStripMenuItem.Text = "Tiempo";
            this.tiempoToolStripMenuItem.Click += new System.EventHandler(this.tiempoToolStripMenuItem_Click);
            // 
            // medidaToolStripMenuItem
            // 
            this.medidaToolStripMenuItem.Name = "medidaToolStripMenuItem";
            this.medidaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.medidaToolStripMenuItem.Text = "Medida";
            this.medidaToolStripMenuItem.Click += new System.EventHandler(this.medidaToolStripMenuItem_Click);
            // 
            // nivelToolStripMenuItem
            // 
            this.nivelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facilToolStripMenuItem,
            this.normalToolStripMenuItem,
            this.dificilToolStripMenuItem});
            this.nivelToolStripMenuItem.Name = "nivelToolStripMenuItem";
            this.nivelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nivelToolStripMenuItem.Text = "Nivel";
            // 
            // facilToolStripMenuItem
            // 
            this.facilToolStripMenuItem.Name = "facilToolStripMenuItem";
            this.facilToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.facilToolStripMenuItem.Text = "Facil";
            this.facilToolStripMenuItem.Click += new System.EventHandler(this.facilToolStripMenuItem_Click);
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.normalToolStripMenuItem.Text = "Normal";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
            // 
            // dificilToolStripMenuItem
            // 
            this.dificilToolStripMenuItem.Name = "dificilToolStripMenuItem";
            this.dificilToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dificilToolStripMenuItem.Text = "Dificil";
            this.dificilToolStripMenuItem.Click += new System.EventHandler(this.dificilToolStripMenuItem_Click);
            // 
            // idiomaToolStripMenuItem
            // 
            this.idiomaToolStripMenuItem.Name = "idiomaToolStripMenuItem";
            this.idiomaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.idiomaToolStripMenuItem.Text = "Idioma";
            this.idiomaToolStripMenuItem.Click += new System.EventHandler(this.idiomaToolStripMenuItem_Click);
            // 
            // puntuaciónToolStripMenuItem
            // 
            this.puntuaciónToolStripMenuItem.Name = "puntuaciónToolStripMenuItem";
            this.puntuaciónToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.puntuaciónToolStripMenuItem.Text = "Puntuación";
            // 
            // otrosToolStripMenuItem
            // 
            this.otrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aparienciaToolStripMenuItem,
            this.ajustesPredeterminadosToolStripMenuItem});
            this.otrosToolStripMenuItem.Name = "otrosToolStripMenuItem";
            this.otrosToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.otrosToolStripMenuItem.Text = "Otros";
            // 
            // aparienciaToolStripMenuItem
            // 
            this.aparienciaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inviernoToolStripMenuItem,
            this.bosqueToolStripMenuItem});
            this.aparienciaToolStripMenuItem.Name = "aparienciaToolStripMenuItem";
            this.aparienciaToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.aparienciaToolStripMenuItem.Text = "Apariencia";
            // 
            // inviernoToolStripMenuItem
            // 
            this.inviernoToolStripMenuItem.Name = "inviernoToolStripMenuItem";
            this.inviernoToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.inviernoToolStripMenuItem.Text = "Invierno";
            this.inviernoToolStripMenuItem.Click += new System.EventHandler(this.inviernoToolStripMenuItem_Click_1);
            // 
            // bosqueToolStripMenuItem
            // 
            this.bosqueToolStripMenuItem.Name = "bosqueToolStripMenuItem";
            this.bosqueToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.bosqueToolStripMenuItem.Text = "Bosque";
            this.bosqueToolStripMenuItem.Click += new System.EventHandler(this.bosqueToolStripMenuItem_Click);
            // 
            // ajustesPredeterminadosToolStripMenuItem
            // 
            this.ajustesPredeterminadosToolStripMenuItem.Name = "ajustesPredeterminadosToolStripMenuItem";
            this.ajustesPredeterminadosToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.ajustesPredeterminadosToolStripMenuItem.Text = "Ajustes predeterminados";
            this.ajustesPredeterminadosToolStripMenuItem.Click += new System.EventHandler(this.ajustesPredeterminadosToolStripMenuItem_Click_1);
            // 
            // textBoxPanel
            // 
            this.textBoxPanel.BackColor = System.Drawing.Color.Transparent;
            this.textBoxPanel.Location = new System.Drawing.Point(77, 349);
            this.textBoxPanel.Name = "textBoxPanel";
            this.textBoxPanel.Size = new System.Drawing.Size(525, 61);
            this.textBoxPanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(53, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(409, 268);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // TimePanel
            // 
            this.TimePanel.BackColor = System.Drawing.Color.Transparent;
            this.TimePanel.Controls.Add(this.clockLabel);
            this.TimePanel.Location = new System.Drawing.Point(654, 47);
            this.TimePanel.Name = "TimePanel";
            this.TimePanel.Size = new System.Drawing.Size(87, 37);
            this.TimePanel.TabIndex = 4;
            // 
            // selecIdiomaLabel
            // 
            this.selecIdiomaLabel.AutoSize = true;
            this.selecIdiomaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selecIdiomaLabel.Location = new System.Drawing.Point(84, 331);
            this.selecIdiomaLabel.Name = "selecIdiomaLabel";
            this.selecIdiomaLabel.Size = new System.Drawing.Size(51, 15);
            this.selecIdiomaLabel.TabIndex = 5;
            this.selecIdiomaLabel.Text = "Idioma";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selecIdiomaLabel);
            this.Controls.Add(this.TimePanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JUEGO AHORCADO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Salir);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TimePanel.ResumeLayout(false);
            this.TimePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem juegoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiempoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nivelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dificilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idiomaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puntuaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aparienciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajustesPredeterminadosToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel textBoxPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label clockLabel;
        public System.Windows.Forms.FlowLayoutPanel TimePanel;
        private System.Windows.Forms.ToolStripMenuItem inviernoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bosqueToolStripMenuItem;
        private System.Windows.Forms.Label selecIdiomaLabel;
    }
}

