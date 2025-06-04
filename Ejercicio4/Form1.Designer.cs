namespace Ejercicio4
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
            this.ResultText = new System.Windows.Forms.TextBox();
            this.FirstText = new System.Windows.Forms.TextBox();
            this.SecundText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ResultText
            // 
            this.ResultText.Location = new System.Drawing.Point(255, 195);
            this.ResultText.Name = "ResultText";
            this.ResultText.Size = new System.Drawing.Size(175, 35);
            this.ResultText.TabIndex = 0;
            // 
            // FirstText
            // 
            this.FirstText.Location = new System.Drawing.Point(255, 98);
            this.FirstText.Name = "FirstText";
            this.FirstText.Size = new System.Drawing.Size(175, 35);
            this.FirstText.TabIndex = 1;
            this.FirstText.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // SecundText
            // 
            this.SecundText.Location = new System.Drawing.Point(255, 145);
            this.SecundText.Name = "SecundText";
            this.SecundText.Size = new System.Drawing.Size(175, 35);
            this.SecundText.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 87);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "First Number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Secund Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Result";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SecundText);
            this.Controls.Add(this.FirstText);
            this.Controls.Add(this.ResultText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ResultText;
        private System.Windows.Forms.TextBox FirstText;
        private System.Windows.Forms.TextBox SecundText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

