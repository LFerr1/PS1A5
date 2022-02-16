namespace ExemploAula1
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
            this.btnPlusOne = new System.Windows.Forms.Button();
            this.txtCount = new System.Windows.Forms.Label();
            this.btnLess = new System.Windows.Forms.Button();
            this.btnPlusTwo = new System.Windows.Forms.Button();
            this.btnPlusThree = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputOne = new System.Windows.Forms.TextBox();
            this.inputTwo = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rdoAdd = new System.Windows.Forms.RadioButton();
            this.rdoSub = new System.Windows.Forms.RadioButton();
            this.rdoDiv = new System.Windows.Forms.RadioButton();
            this.rdoMlt = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Counter: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnPlusOne
            // 
            this.btnPlusOne.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlusOne.ForeColor = System.Drawing.Color.Black;
            this.btnPlusOne.Location = new System.Drawing.Point(185, 36);
            this.btnPlusOne.Name = "btnPlusOne";
            this.btnPlusOne.Size = new System.Drawing.Size(150, 40);
            this.btnPlusOne.TabIndex = 1;
            this.btnPlusOne.Text = "+ 1";
            this.btnPlusOne.UseVisualStyleBackColor = true;
            this.btnPlusOne.Click += new System.EventHandler(this.BtnPlusOne_Click);
            // 
            // txtCount
            // 
            this.txtCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCount.AutoSize = true;
            this.txtCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCount.ForeColor = System.Drawing.Color.White;
            this.txtCount.Location = new System.Drawing.Point(101, 9);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(21, 24);
            this.txtCount.TabIndex = 6;
            this.txtCount.Text = "0";
            this.txtCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txtCount.Click += new System.EventHandler(this.TxtCount_Click);
            // 
            // btnLess
            // 
            this.btnLess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLess.ForeColor = System.Drawing.Color.Black;
            this.btnLess.Location = new System.Drawing.Point(13, 36);
            this.btnLess.Name = "btnLess";
            this.btnLess.Size = new System.Drawing.Size(150, 40);
            this.btnLess.TabIndex = 0;
            this.btnLess.Text = "- 1";
            this.btnLess.UseVisualStyleBackColor = true;
            this.btnLess.Click += new System.EventHandler(this.BtnLess_Click);
            // 
            // btnPlusTwo
            // 
            this.btnPlusTwo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlusTwo.ForeColor = System.Drawing.Color.Black;
            this.btnPlusTwo.Location = new System.Drawing.Point(13, 91);
            this.btnPlusTwo.Name = "btnPlusTwo";
            this.btnPlusTwo.Size = new System.Drawing.Size(151, 40);
            this.btnPlusTwo.TabIndex = 4;
            this.btnPlusTwo.Text = "+ 2";
            this.btnPlusTwo.UseVisualStyleBackColor = true;
            this.btnPlusTwo.Click += new System.EventHandler(this.BtnPlusTwo_Click);
            // 
            // btnPlusThree
            // 
            this.btnPlusThree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlusThree.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnPlusThree.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPlusThree.ForeColor = System.Drawing.Color.Black;
            this.btnPlusThree.Location = new System.Drawing.Point(185, 91);
            this.btnPlusThree.Name = "btnPlusThree";
            this.btnPlusThree.Size = new System.Drawing.Size(150, 40);
            this.btnPlusThree.TabIndex = 5;
            this.btnPlusThree.Text = "+ 3";
            this.btnPlusThree.UseVisualStyleBackColor = true;
            this.btnPlusThree.Click += new System.EventHandler(this.BtnPlusThree_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Número 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Número 2: ";
            // 
            // inputOne
            // 
            this.inputOne.ForeColor = System.Drawing.Color.Black;
            this.inputOne.Location = new System.Drawing.Point(13, 237);
            this.inputOne.Name = "inputOne";
            this.inputOne.Size = new System.Drawing.Size(322, 20);
            this.inputOne.TabIndex = 10;
            // 
            // inputTwo
            // 
            this.inputTwo.ForeColor = System.Drawing.Color.Black;
            this.inputTwo.Location = new System.Drawing.Point(13, 294);
            this.inputTwo.Name = "inputTwo";
            this.inputTwo.Size = new System.Drawing.Size(322, 20);
            this.inputTwo.TabIndex = 11;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.ForeColor = System.Drawing.Color.White;
            this.result.Location = new System.Drawing.Point(12, 437);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(90, 20);
            this.result.TabIndex = 12;
            this.result.Text = "Resultado: ";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(13, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(322, 24);
            this.button1.TabIndex = 13;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // rdoAdd
            // 
            this.rdoAdd.AutoSize = true;
            this.rdoAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAdd.ForeColor = System.Drawing.Color.White;
            this.rdoAdd.Location = new System.Drawing.Point(13, 335);
            this.rdoAdd.Name = "rdoAdd";
            this.rdoAdd.Size = new System.Drawing.Size(76, 24);
            this.rdoAdd.TabIndex = 14;
            this.rdoAdd.TabStop = true;
            this.rdoAdd.Text = "Adição";
            this.rdoAdd.UseVisualStyleBackColor = true;
            // 
            // rdoSub
            // 
            this.rdoSub.AutoSize = true;
            this.rdoSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSub.ForeColor = System.Drawing.Color.White;
            this.rdoSub.Location = new System.Drawing.Point(185, 335);
            this.rdoSub.Name = "rdoSub";
            this.rdoSub.Size = new System.Drawing.Size(101, 24);
            this.rdoSub.TabIndex = 15;
            this.rdoSub.TabStop = true;
            this.rdoSub.Text = "Subtração";
            this.rdoSub.UseVisualStyleBackColor = true;
            // 
            // rdoDiv
            // 
            this.rdoDiv.AutoSize = true;
            this.rdoDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDiv.ForeColor = System.Drawing.Color.White;
            this.rdoDiv.Location = new System.Drawing.Point(185, 363);
            this.rdoDiv.Name = "rdoDiv";
            this.rdoDiv.Size = new System.Drawing.Size(78, 24);
            this.rdoDiv.TabIndex = 17;
            this.rdoDiv.TabStop = true;
            this.rdoDiv.Text = "Divisão";
            this.rdoDiv.UseVisualStyleBackColor = true;
            // 
            // rdoMlt
            // 
            this.rdoMlt.AutoSize = true;
            this.rdoMlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMlt.ForeColor = System.Drawing.Color.White;
            this.rdoMlt.Location = new System.Drawing.Point(13, 363);
            this.rdoMlt.Name = "rdoMlt";
            this.rdoMlt.Size = new System.Drawing.Size(118, 24);
            this.rdoMlt.TabIndex = 18;
            this.rdoMlt.TabStop = true;
            this.rdoMlt.Text = "Multiplicação";
            this.rdoMlt.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "Calculadora";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(347, 581);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rdoMlt);
            this.Controls.Add(this.rdoDiv);
            this.Controls.Add(this.rdoSub);
            this.Controls.Add(this.rdoAdd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.inputTwo);
            this.Controls.Add(this.inputOne);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPlusThree);
            this.Controls.Add(this.btnPlusTwo);
            this.Controls.Add(this.btnLess);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.btnPlusOne);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Counter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPlusOne;
        private System.Windows.Forms.Label txtCount;
        private System.Windows.Forms.Button btnLess;
        private System.Windows.Forms.Button btnPlusTwo;
        private System.Windows.Forms.Button btnPlusThree;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputOne;
        private System.Windows.Forms.TextBox inputTwo;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdoAdd;
        private System.Windows.Forms.RadioButton rdoSub;
        private System.Windows.Forms.RadioButton rdoDiv;
        private System.Windows.Forms.RadioButton rdoMlt;
        private System.Windows.Forms.Label label4;
    }
}

