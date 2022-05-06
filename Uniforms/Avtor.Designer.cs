namespace Uniforms
{
    partial class Avtor
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_entry = new System.Windows.Forms.Button();
            this.lb_password = new System.Windows.Forms.Label();
            this.lb_login = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.btn_reg = new System.Windows.Forms.Button();
            this.lb_zagolovok = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lb_check = new System.Windows.Forms.Label();
            this.lb_check_password = new System.Windows.Forms.Label();
            this.lb_check_login = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_entry
            // 
            this.btn_entry.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_entry.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_entry.Location = new System.Drawing.Point(388, 69);
            this.btn_entry.Name = "btn_entry";
            this.btn_entry.Size = new System.Drawing.Size(124, 36);
            this.btn_entry.TabIndex = 0;
            this.btn_entry.Text = "Войти";
            this.btn_entry.UseVisualStyleBackColor = false;
            this.btn_entry.Click += new System.EventHandler(this.btn_entry_Click);
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_password.Location = new System.Drawing.Point(34, 131);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(65, 23);
            this.lb_password.TabIndex = 1;
            this.lb_password.Text = "Пароль";
            // 
            // lb_login
            // 
            this.lb_login.AutoSize = true;
            this.lb_login.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_login.Location = new System.Drawing.Point(46, 78);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(53, 23);
            this.lb_login.TabIndex = 2;
            this.lb_login.Text = "Логин";
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_password.Location = new System.Drawing.Point(112, 128);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '•';
            this.tb_password.Size = new System.Drawing.Size(217, 29);
            this.tb_password.TabIndex = 3;
            // 
            // tb_login
            // 
            this.tb_login.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_login.Location = new System.Drawing.Point(112, 75);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(217, 29);
            this.tb_login.TabIndex = 5;
            // 
            // btn_reg
            // 
            this.btn_reg.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_reg.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_reg.Location = new System.Drawing.Point(388, 128);
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.Size = new System.Drawing.Size(124, 36);
            this.btn_reg.TabIndex = 6;
            this.btn_reg.Text = "Регистрация";
            this.btn_reg.UseVisualStyleBackColor = false;
            this.btn_reg.Click += new System.EventHandler(this.btn_reg_Click);
            // 
            // lb_zagolovok
            // 
            this.lb_zagolovok.AutoSize = true;
            this.lb_zagolovok.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_zagolovok.Location = new System.Drawing.Point(179, 9);
            this.lb_zagolovok.Name = "lb_zagolovok";
            this.lb_zagolovok.Size = new System.Drawing.Size(223, 40);
            this.lb_zagolovok.TabIndex = 7;
            this.lb_zagolovok.Text = "Авторизация";
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_exit.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_exit.Location = new System.Drawing.Point(388, 186);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(124, 36);
            this.btn_exit.TabIndex = 8;
            this.btn_exit.Text = "Выход";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lb_check
            // 
            this.lb_check.AutoSize = true;
            this.lb_check.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_check.ForeColor = System.Drawing.Color.Red;
            this.lb_check.Location = new System.Drawing.Point(174, 174);
            this.lb_check.Name = "lb_check";
            this.lb_check.Size = new System.Drawing.Size(155, 23);
            this.lb_check.TabIndex = 9;
            this.lb_check.Text = "Заполните все поля";
            // 
            // lb_check_password
            // 
            this.lb_check_password.AutoSize = true;
            this.lb_check_password.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_check_password.ForeColor = System.Drawing.Color.Red;
            this.lb_check_password.Location = new System.Drawing.Point(187, 174);
            this.lb_check_password.Name = "lb_check_password";
            this.lb_check_password.Size = new System.Drawing.Size(142, 23);
            this.lb_check_password.TabIndex = 11;
            this.lb_check_password.Text = "Неверный пароль";
            // 
            // lb_check_login
            // 
            this.lb_check_login.AutoSize = true;
            this.lb_check_login.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_check_login.ForeColor = System.Drawing.Color.Red;
            this.lb_check_login.Location = new System.Drawing.Point(232, 174);
            this.lb_check_login.Name = "lb_check_login";
            this.lb_check_login.Size = new System.Drawing.Size(97, 23);
            this.lb_check_login.TabIndex = 10;
            this.lb_check_login.Text = "Логин занят";
            // 
            // Avtor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(574, 251);
            this.Controls.Add(this.lb_check_password);
            this.Controls.Add(this.lb_check_login);
            this.Controls.Add(this.lb_check);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lb_zagolovok);
            this.Controls.Add(this.btn_reg);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.lb_login);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.btn_entry);
            this.MaximumSize = new System.Drawing.Size(590, 290);
            this.MinimumSize = new System.Drawing.Size(590, 290);
            this.Name = "Avtor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_entry;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Label lb_login;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.Button btn_reg;
        private System.Windows.Forms.Label lb_zagolovok;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lb_check;
        private System.Windows.Forms.Label lb_check_password;
        private System.Windows.Forms.Label lb_check_login;
    }
}

