
namespace Lab006.Lab00
{
    partial class Telaprincipal
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
            this.lblValor2 = new System.Windows.Forms.Label();
            this.lblValor1 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblValor3 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.nudValor2 = new System.Windows.Forms.NumericUpDown();
            this.nudValor1 = new System.Windows.Forms.NumericUpDown();
            this.nudValor3 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblValor2
            // 
            this.lblValor2.AutoSize = true;
            this.lblValor2.Location = new System.Drawing.Point(95, 125);
            this.lblValor2.Name = "lblValor2";
            this.lblValor2.Size = new System.Drawing.Size(42, 15);
            this.lblValor2.TabIndex = 0;
            this.lblValor2.Text = "Valor 2";
            // 
            // lblValor1
            // 
            this.lblValor1.AutoSize = true;
            this.lblValor1.Location = new System.Drawing.Point(95, 68);
            this.lblValor1.Name = "lblValor1";
            this.lblValor1.Size = new System.Drawing.Size(42, 15);
            this.lblValor1.TabIndex = 1;
            this.lblValor1.Text = "Valor 1";
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblResultado.Location = new System.Drawing.Point(391, 68);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(283, 145);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValor3
            // 
            this.lblValor3.AutoSize = true;
            this.lblValor3.Location = new System.Drawing.Point(95, 190);
            this.lblValor3.Name = "lblValor3";
            this.lblValor3.Size = new System.Drawing.Size(42, 15);
            this.lblValor3.TabIndex = 3;
            this.lblValor3.Text = "Valor 3";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(164, 245);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(120, 38);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // nudValor2
            // 
            this.nudValor2.Location = new System.Drawing.Point(164, 125);
            this.nudValor2.Name = "nudValor2";
            this.nudValor2.Size = new System.Drawing.Size(120, 23);
            this.nudValor2.TabIndex = 8;
            // 
            // nudValor1
            // 
            this.nudValor1.Location = new System.Drawing.Point(164, 66);
            this.nudValor1.Name = "nudValor1";
            this.nudValor1.Size = new System.Drawing.Size(120, 23);
            this.nudValor1.TabIndex = 9;
            // 
            // nudValor3
            // 
            this.nudValor3.Location = new System.Drawing.Point(164, 188);
            this.nudValor3.Name = "nudValor3";
            this.nudValor3.Size = new System.Drawing.Size(120, 23);
            this.nudValor3.TabIndex = 10;
            // 
            // Telaprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nudValor3);
            this.Controls.Add(this.nudValor1);
            this.Controls.Add(this.nudValor2);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblValor3);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblValor1);
            this.Controls.Add(this.lblValor2);
            this.Name = "Telaprincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Calculo";
            this.Load += new System.EventHandler(this.Telaprincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudValor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValor2;
        private System.Windows.Forms.Label lblValor1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblValor3;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.NumericUpDown nudValor2;
        private System.Windows.Forms.NumericUpDown nudValor1;
        private System.Windows.Forms.NumericUpDown nudValor3;
    }
}