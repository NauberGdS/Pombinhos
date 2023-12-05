namespace Pombinhos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblNome1 = new System.Windows.Forms.Label();
            this.lblNome2 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txbNome1 = new System.Windows.Forms.TextBox();
            this.txbNome2 = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblPorcent = new System.Windows.Forms.Label();
            this.lblcomb = new System.Windows.Forms.Label();
            this.lblSugest = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome1
            // 
            this.lblNome1.AutoSize = true;
            this.lblNome1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNome1.Location = new System.Drawing.Point(16, 60);
            this.lblNome1.Name = "lblNome1";
            this.lblNome1.Size = new System.Drawing.Size(163, 21);
            this.lblNome1.TabIndex = 0;
            this.lblNome1.Text = "Nome do pombo:";
            // 
            // lblNome2
            // 
            this.lblNome2.AutoSize = true;
            this.lblNome2.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNome2.Location = new System.Drawing.Point(16, 113);
            this.lblNome2.Name = "lblNome2";
            this.lblNome2.Size = new System.Drawing.Size(167, 21);
            this.lblNome2.TabIndex = 1;
            this.lblNome2.Text = "Nome da pomba:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Black;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Harrington", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCalcular.Location = new System.Drawing.Point(185, 152);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(85, 34);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txbNome1
            // 
            this.txbNome1.BackColor = System.Drawing.Color.LightCoral;
            this.txbNome1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNome1.Location = new System.Drawing.Point(185, 60);
            this.txbNome1.Name = "txbNome1";
            this.txbNome1.Size = new System.Drawing.Size(176, 22);
            this.txbNome1.TabIndex = 3;
            // 
            // txbNome2
            // 
            this.txbNome2.BackColor = System.Drawing.Color.LightCoral;
            this.txbNome2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNome2.Location = new System.Drawing.Point(185, 113);
            this.txbNome2.Name = "txbNome2";
            this.txbNome2.Size = new System.Drawing.Size(176, 22);
            this.txbNome2.TabIndex = 4;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitulo.Location = new System.Drawing.Point(95, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(266, 21);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Calculadora dos Pombinhos";
            // 
            // lblPorcent
            // 
            this.lblPorcent.AutoSize = true;
            this.lblPorcent.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcent.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPorcent.Location = new System.Drawing.Point(16, 268);
            this.lblPorcent.Name = "lblPorcent";
            this.lblPorcent.Size = new System.Drawing.Size(138, 21);
            this.lblPorcent.TabIndex = 6;
            this.lblPorcent.Text = "Porcentagem:";
            // 
            // lblcomb
            // 
            this.lblcomb.AutoSize = true;
            this.lblcomb.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcomb.ForeColor = System.Drawing.SystemColors.Control;
            this.lblcomb.Location = new System.Drawing.Point(16, 229);
            this.lblcomb.Name = "lblcomb";
            this.lblcomb.Size = new System.Drawing.Size(138, 21);
            this.lblcomb.TabIndex = 7;
            this.lblcomb.Text = "Combincação:";
            // 
            // lblSugest
            // 
            this.lblSugest.AutoSize = true;
            this.lblSugest.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSugest.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSugest.Location = new System.Drawing.Point(16, 305);
            this.lblSugest.Name = "lblSugest";
            this.lblSugest.Size = new System.Drawing.Size(96, 21);
            this.lblSugest.TabIndex = 8;
            this.lblSugest.Text = "Sugestão:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(283, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(481, 343);
            this.Controls.Add(this.lblSugest);
            this.Controls.Add(this.lblcomb);
            this.Controls.Add(this.lblPorcent);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txbNome2);
            this.Controls.Add(this.txbNome1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblNome2);
            this.Controls.Add(this.lblNome1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Formula dos Pombinhos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome1;
        private System.Windows.Forms.Label lblNome2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txbNome1;
        private System.Windows.Forms.TextBox txbNome2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblPorcent;
        private System.Windows.Forms.Label lblcomb;
        private System.Windows.Forms.Label lblSugest;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

