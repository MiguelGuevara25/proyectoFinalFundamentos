namespace Trabajofinal_Fundamentos
{
    partial class Form7
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dispon_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.espacios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dispon_id,
            this.Column1,
            this.Column2,
            this.fecha_inicio,
            this.espacios});
            this.dataGridView1.Location = new System.Drawing.Point(32, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(708, 321);
            this.dataGridView1.TabIndex = 13;
            // 
            // dispon_id
            // 
            this.dispon_id.HeaderText = "Orden";
            this.dispon_id.Name = "dispon_id";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tipo";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Precio";
            this.Column2.Name = "Column2";
            this.Column2.Width = 140;
            // 
            // fecha_inicio
            // 
            this.fecha_inicio.HeaderText = "Disponibilidad";
            this.fecha_inicio.Name = "fecha_inicio";
            this.fecha_inicio.Width = 140;
            // 
            // espacios
            // 
            this.espacios.HeaderText = "Espacios";
            this.espacios.Name = "espacios";
            this.espacios.Width = 140;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(478, 564);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 36);
            this.button3.TabIndex = 12;
            this.button3.Text = "Pagar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(32, 564);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 36);
            this.button2.TabIndex = 11;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 491);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(28, 448);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "¿Desea agregar un acompañante?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(234, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lista de dispobilidad";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Trabajofinal_Fundamentos.Properties.Resources.Hotal_Hilton2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(703, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 53);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 618);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form7";
            this.Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dispon_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn espacios;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}