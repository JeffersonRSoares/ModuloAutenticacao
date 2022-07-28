namespace ModuloAutenticacao.Desktop
{
    partial class TelaAutenticacao
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
            this.txtlogin = new System.Windows.Forms.Label();
            this.txtsenha = new System.Windows.Forms.Label();
            this.textLogin = new System.Windows.Forms.TextBox();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtlogin
            // 
            this.txtlogin.AutoSize = true;
            this.txtlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlogin.Location = new System.Drawing.Point(179, 110);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(48, 20);
            this.txtlogin.TabIndex = 0;
            this.txtlogin.Text = "Login";
            this.txtlogin.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtsenha
            // 
            this.txtsenha.AutoSize = true;
            this.txtsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsenha.Location = new System.Drawing.Point(171, 149);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(56, 20);
            this.txtsenha.TabIndex = 1;
            this.txtsenha.Text = "Senha";
            // 
            // textLogin
            // 
            this.textLogin.Location = new System.Drawing.Point(233, 112);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(254, 20);
            this.textLogin.TabIndex = 2;
            this.textLogin.TextChanged += new System.EventHandler(this.textlogin_TextChanged);
            // 
            // textSenha
            // 
            this.textSenha.Location = new System.Drawing.Point(233, 151);
            this.textSenha.Name = "textSenha";
            this.textSenha.Size = new System.Drawing.Size(254, 20);
            this.textSenha.TabIndex = 3;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(233, 216);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(254, 23);
            this.btnEntrar.TabIndex = 4;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // TelaAutenticacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(719, 338);
            this.ControlBox = false;
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.textSenha);
            this.Controls.Add(this.textLogin);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.txtlogin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaAutenticacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modulo Autenticacao - Desktop";
            this.Load += new System.EventHandler(this.TelaAutenticacao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtlogin;
        private System.Windows.Forms.Label txtsenha;
        private System.Windows.Forms.TextBox textLogin;
        private System.Windows.Forms.TextBox textSenha;
        private System.Windows.Forms.Button btnEntrar;
    }
}

