namespace Proiect_PBD
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalculare = new System.Windows.Forms.Button();
            this.txtNrleg = new System.Windows.Forms.TextBox();
            this.txtDisciplina = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Disciplina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nr legitimatie";
            // 
            // btnCalculare
            // 
            this.btnCalculare.Location = new System.Drawing.Point(202, 214);
            this.btnCalculare.Name = "btnCalculare";
            this.btnCalculare.Size = new System.Drawing.Size(137, 38);
            this.btnCalculare.TabIndex = 2;
            this.btnCalculare.Text = "Calculare";
            this.btnCalculare.UseVisualStyleBackColor = true;
            this.btnCalculare.Click += new System.EventHandler(this.btnCalculare_Click);
            // 
            // txtNrleg
            // 
            this.txtNrleg.Location = new System.Drawing.Point(139, 69);
            this.txtNrleg.Name = "txtNrleg";
            this.txtNrleg.Size = new System.Drawing.Size(380, 22);
            this.txtNrleg.TabIndex = 3;
            // 
            // txtDisciplina
            // 
            this.txtDisciplina.Location = new System.Drawing.Point(139, 137);
            this.txtDisciplina.Name = "txtDisciplina";
            this.txtDisciplina.Size = new System.Drawing.Size(380, 22);
            this.txtDisciplina.TabIndex = 4;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 305);
            this.Controls.Add(this.txtDisciplina);
            this.Controls.Add(this.txtNrleg);
            this.Controls.Add(this.btnCalculare);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalculare;
        private System.Windows.Forms.TextBox txtNrleg;
        private System.Windows.Forms.TextBox txtDisciplina;
    }
}