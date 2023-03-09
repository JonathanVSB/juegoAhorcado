namespace juegoAhorcado
{
    partial class Form_Idioma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.idiomaLabel = new System.Windows.Forms.Label();
            this.buttonApply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Castellano",
            "Catalan",
            "Ingles"});
            this.comboBox1.Location = new System.Drawing.Point(81, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            
            // 
            // idiomaLabel
            // 
            this.idiomaLabel.AutoSize = true;
            this.idiomaLabel.Location = new System.Drawing.Point(78, 43);
            this.idiomaLabel.Name = "idiomaLabel";
            this.idiomaLabel.Size = new System.Drawing.Size(131, 13);
            this.idiomaLabel.TabIndex = 1;
            this.idiomaLabel.Text = "SELECCIONA EL IDIOMA";
            // 
            // buttonApply
            // 
            this.buttonApply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApply.Location = new System.Drawing.Point(74, 136);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(135, 42);
            this.buttonApply.TabIndex = 2;
            this.buttonApply.Text = "APLICAR";
            this.buttonApply.UseCompatibleTextRendering = true;
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // Form_Idioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 207);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.idiomaLabel);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_Idioma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Idioma";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Salir);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label idiomaLabel;
        private System.Windows.Forms.Button buttonApply;
        public System.Windows.Forms.ComboBox comboBox1;
    }
}