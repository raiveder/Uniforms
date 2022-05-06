namespace Uniforms
{
    partial class Reg
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
            this.lb_check_login = new System.Windows.Forms.Label();
            this.lb_check = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lb_zagolovok = new System.Windows.Forms.Label();
            this.btn_reg = new System.Windows.Forms.Button();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lb_login = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_check_login
            // 
            this.lb_check_login.AutoSize = true;
            this.lb_check_login.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_check_login.ForeColor = System.Drawing.Color.Red;
            this.lb_check_login.Location = new System.Drawing.Point(232, 173);
            this.lb_check_login.Name = "lb_check_login";
            this.lb_check_login.Size = new System.Drawing.Size(97, 23);
            this.lb_check_login.TabIndex = 22;
            this.lb_check_login.Text = "Логин занят";
            // 
            // lb_check
            // 
            this.lb_check.AutoSize = true;
            this.lb_check.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_check.ForeColor = System.Drawing.Color.Red;
            this.lb_check.Location = new System.Drawing.Point(174, 173);
            this.lb_check.Name = "lb_check";
            this.lb_check.Size = new System.Drawing.Size(155, 23);
            this.lb_check.TabIndex = 21;
            this.lb_check.Text = "Заполните все поля";
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_exit.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_exit.Location = new System.Drawing.Point(388, 185);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(124, 36);
            this.btn_exit.TabIndex = 20;
            this.btn_exit.Text = "Выход";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lb_zagolovok
            // 
            this.lb_zagolovok.AutoSize = true;
            this.lb_zagolovok.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_zagolovok.Location = new System.Drawing.Point(183, 9);
            this.lb_zagolovok.Name = "lb_zagolovok";
            this.lb_zagolovok.Size = new System.Drawing.Size(219, 40);
            this.lb_zagolovok.TabIndex = 19;
            this.lb_zagolovok.Text = "Регистрация";
            // 
            // btn_reg
            // 
            this.btn_reg.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_reg.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_reg.Location = new System.Drawing.Point(388, 70);
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.Size = new System.Drawing.Size(124, 36);
            this.btn_reg.TabIndex = 18;
            this.btn_reg.Text = "Регистрация";
            this.btn_reg.UseVisualStyleBackColor = false;
            this.btn_reg.Click += new System.EventHandler(this.btn_reg_Click);
            // 
            // tb_login
            // 
            this.tb_login.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_login.Location = new System.Drawing.Point(112, 74);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(217, 29);
            this.tb_login.TabIndex = 17;
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_password.Location = new System.Drawing.Point(112, 127);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(217, 29);
            this.tb_password.TabIndex = 16;
            // 
            // lb_login
            // 
            this.lb_login.AutoSize = true;
            this.lb_login.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_login.Location = new System.Drawing.Point(46, 77);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(53, 23);
            this.lb_login.TabIndex = 15;
            this.lb_login.Text = "Логин";
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_password.Location = new System.Drawing.Point(34, 130);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(65, 23);
            this.lb_password.TabIndex = 14;
            this.lb_password.Text = "Пароль";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_back.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_back.Location = new System.Drawing.Point(388, 130);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(124, 36);
            this.btn_back.TabIndex = 13;
            this.btn_back.Text = "Назад";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(574, 251);
            this.Controls.Add(this.lb_check_login);
            this.Controls.Add(this.lb_check);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lb_zagolovok);
            this.Controls.Add(this.btn_reg);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.lb_login);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.btn_back);
            this.MaximumSize = new System.Drawing.Size(590, 290);
            this.MinimumSize = new System.Drawing.Size(590, 290);
            this.Name = "Reg";
            this.Text = "Reg";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Reg_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_check_login;
        private System.Windows.Forms.Label lb_check;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lb_zagolovok;
        private System.Windows.Forms.Button btn_reg;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label lb_login;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Button btn_back;
    }
}