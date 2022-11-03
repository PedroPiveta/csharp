namespace aula60
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_teste = new System.Windows.Forms.Button();
            this.lb_teste = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_teste
            // 
            this.btn_teste.BackColor = System.Drawing.Color.Black;
            this.btn_teste.ForeColor = System.Drawing.Color.Red;
            this.btn_teste.Location = new System.Drawing.Point(82, 112);
            this.btn_teste.Name = "btn_teste";
            this.btn_teste.Size = new System.Drawing.Size(89, 46);
            this.btn_teste.TabIndex = 0;
            this.btn_teste.Text = "Teste";
            this.btn_teste.UseVisualStyleBackColor = false;
            // 
            // lb_teste
            // 
            this.lb_teste.AutoSize = true;
            this.lb_teste.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_teste.Location = new System.Drawing.Point(118, 85);
            this.lb_teste.Name = "lb_teste";
            this.lb_teste.Size = new System.Drawing.Size(43, 21);
            this.lb_teste.TabIndex = 1;
            this.lb_teste.Text = "wow";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(82, 176);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(100, 23);
            this.tb_nome.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(603, 401);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.lb_teste);
            this.Controls.Add(this.btn_teste);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Curso de C#";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_teste;
        private Label lb_teste;
        private TextBox tb_nome;
    }
}