namespace App1
{
    partial class Form1
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
            this.tbVardas = new System.Windows.Forms.TextBox();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVardas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbVardas
            // 
            this.tbVardas.Location = new System.Drawing.Point(79, 12);
            this.tbVardas.Name = "tbVardas";
            this.tbVardas.Size = new System.Drawing.Size(100, 26);
            this.tbVardas.TabIndex = 0;
            this.tbVardas.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(17, 89);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(162, 232);
            this.tbOutput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vardas";
            // 
            // btnVardas
            // 
            this.btnVardas.Location = new System.Drawing.Point(17, 44);
            this.btnVardas.Name = "btnVardas";
            this.btnVardas.Size = new System.Drawing.Size(162, 39);
            this.btnVardas.TabIndex = 3;
            this.btnVardas.Text = "Vardas";
            this.btnVardas.UseVisualStyleBackColor = true;
            this.btnVardas.Click += new System.EventHandler(this.btnVardas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVardas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.tbVardas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbVardas;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVardas;
    }
}

