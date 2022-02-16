namespace Exercicio1
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputNome = new System.Windows.Forms.TextBox();
            this.upper = new System.Windows.Forms.RadioButton();
            this.lower = new System.Windows.Forms.RadioButton();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite seu nome:";
            // 
            // inputNome
            // 
            this.inputNome.ForeColor = System.Drawing.Color.Black;
            this.inputNome.Location = new System.Drawing.Point(16, 41);
            this.inputNome.Name = "inputNome";
            this.inputNome.Size = new System.Drawing.Size(255, 20);
            this.inputNome.TabIndex = 1;
            this.inputNome.TextChanged += new System.EventHandler(this.InputNome_TextChanged);
            // 
            // upper
            // 
            this.upper.AutoSize = true;
            this.upper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upper.ForeColor = System.Drawing.Color.White;
            this.upper.Location = new System.Drawing.Point(16, 86);
            this.upper.Name = "upper";
            this.upper.Size = new System.Drawing.Size(105, 24);
            this.upper.TabIndex = 2;
            this.upper.TabStop = true;
            this.upper.Text = "Uppercase";
            this.upper.UseVisualStyleBackColor = true;
            this.upper.CheckedChanged += new System.EventHandler(this.Upper_CheckedChanged);
            // 
            // lower
            // 
            this.lower.AutoSize = true;
            this.lower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lower.ForeColor = System.Drawing.Color.White;
            this.lower.Location = new System.Drawing.Point(138, 86);
            this.lower.Name = "lower";
            this.lower.Size = new System.Drawing.Size(104, 24);
            this.lower.TabIndex = 3;
            this.lower.TabStop = true;
            this.lower.Text = "Lowercase";
            this.lower.UseVisualStyleBackColor = true;
            this.lower.CheckedChanged += new System.EventHandler(this.Lower_CheckedChanged);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.ForeColor = System.Drawing.Color.White;
            this.result.Location = new System.Drawing.Point(12, 131);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(101, 20);
            this.result.TabIndex = 4;
            this.result.Text = "Resultado: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(385, 634);
            this.Controls.Add(this.result);
            this.Controls.Add(this.lower);
            this.Controls.Add(this.upper);
            this.Controls.Add(this.inputNome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputNome;
        private System.Windows.Forms.RadioButton upper;
        private System.Windows.Forms.RadioButton lower;
        private System.Windows.Forms.Label result;
    }
}

