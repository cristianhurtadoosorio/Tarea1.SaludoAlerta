namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnt1 = new System.Windows.Forms.TextBox();
            this.txtnt3 = new System.Windows.Forms.TextBox();
            this.txtnt2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RESULTADO_PROMEDIO = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROMEDIO DE NOTAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "INGRESAR NOTA 3:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(160, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "INGRESAR NOTA 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(160, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "INGRESAR NOTA 1:";
            // 
            // txtnt1
            // 
            this.txtnt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnt1.Location = new System.Drawing.Point(396, 86);
            this.txtnt1.Name = "txtnt1";
            this.txtnt1.Size = new System.Drawing.Size(100, 31);
            this.txtnt1.TabIndex = 4;
            this.txtnt1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtnt3
            // 
            this.txtnt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnt3.Location = new System.Drawing.Point(396, 176);
            this.txtnt3.Name = "txtnt3";
            this.txtnt3.Size = new System.Drawing.Size(100, 31);
            this.txtnt3.TabIndex = 5;
            this.txtnt3.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtnt2
            // 
            this.txtnt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnt2.Location = new System.Drawing.Point(396, 129);
            this.txtnt2.Name = "txtnt2";
            this.txtnt2.Size = new System.Drawing.Size(100, 31);
            this.txtnt2.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(160, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "PROMEDIO :";
            // 
            // RESULTADO_PROMEDIO
            // 
            this.RESULTADO_PROMEDIO.AutoSize = true;
            this.RESULTADO_PROMEDIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RESULTADO_PROMEDIO.Location = new System.Drawing.Point(331, 262);
            this.RESULTADO_PROMEDIO.Name = "RESULTADO_PROMEDIO";
            this.RESULTADO_PROMEDIO.Size = new System.Drawing.Size(302, 29);
            this.RESULTADO_PROMEDIO.TabIndex = 8;
            this.RESULTADO_PROMEDIO.Text = "RESULTADO_PROMEDIO";
            this.RESULTADO_PROMEDIO.Visible = false;
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(565, 205);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(190, 40);
            this.btncalcular.TabIndex = 9;
            this.btncalcular.Text = "CÁLCULAR";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.RESULTADO_PROMEDIO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtnt2);
            this.Controls.Add(this.txtnt3);
            this.Controls.Add(this.txtnt1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnt1;
        private System.Windows.Forms.TextBox txtnt3;
        private System.Windows.Forms.TextBox txtnt2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label RESULTADO_PROMEDIO;
        private System.Windows.Forms.Button btncalcular;
    }
}

