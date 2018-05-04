namespace EscribeRegistro
{
    partial class fmrPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudBoca = new System.Windows.Forms.NumericUpDown();
            this.nudOjos = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOjos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor boca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor ojos:";
            // 
            // nudBoca
            // 
            this.nudBoca.Location = new System.Drawing.Point(100, 89);
            this.nudBoca.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudBoca.Name = "nudBoca";
            this.nudBoca.Size = new System.Drawing.Size(61, 22);
            this.nudBoca.TabIndex = 2;
            this.nudBoca.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBoca.ValueChanged += new System.EventHandler(this.nudBoca_ValueChanged);
            // 
            // nudOjos
            // 
            this.nudOjos.Location = new System.Drawing.Point(100, 133);
            this.nudOjos.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudOjos.Name = "nudOjos";
            this.nudOjos.Size = new System.Drawing.Size(61, 22);
            this.nudOjos.TabIndex = 3;
            this.nudOjos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudOjos.ValueChanged += new System.EventHandler(this.nudOjos_ValueChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 63);
            this.label3.TabIndex = 4;
            this.label3.Text = "Al cambiar los valores se escriben los nuevos valores en el archivo D:\\Compartido" +
    "\\Compartido.dat";
            // 
            // fmrPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 180);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudOjos);
            this.Controls.Add(this.nudBoca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(287, 225);
            this.MinimumSize = new System.Drawing.Size(287, 225);
            this.Name = "fmrPrincipal";
            this.Text = "Escribe a archivo";
            ((System.ComponentModel.ISupportInitialize)(this.nudBoca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOjos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudBoca;
        private System.Windows.Forms.NumericUpDown nudOjos;
        private System.Windows.Forms.Label label3;
    }
}

