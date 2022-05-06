namespace Uniforms
{
    partial class Sotrudniki
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.cb_filtr = new System.Windows.Forms.ComboBox();
            this.lb_zagolovok = new System.Windows.Forms.Label();
            this.tb_filtr = new System.Windows.Forms.TextBox();
            this.btn_find = new System.Windows.Forms.Button();
            this.lb_filtr = new System.Windows.Forms.Label();
            this.lb_value = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(48, 154);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(704, 288);
            this.dataGridView.TabIndex = 0;
            // 
            // cb_filtr
            // 
            this.cb_filtr.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_filtr.FormattingEnabled = true;
            this.cb_filtr.Location = new System.Drawing.Point(48, 104);
            this.cb_filtr.Name = "cb_filtr";
            this.cb_filtr.Size = new System.Drawing.Size(181, 31);
            this.cb_filtr.TabIndex = 1;
            // 
            // lb_zagolovok
            // 
            this.lb_zagolovok.AutoSize = true;
            this.lb_zagolovok.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_zagolovok.Location = new System.Drawing.Point(306, 9);
            this.lb_zagolovok.Name = "lb_zagolovok";
            this.lb_zagolovok.Size = new System.Drawing.Size(176, 42);
            this.lb_zagolovok.TabIndex = 8;
            this.lb_zagolovok.Text = "Сотрудники";
            // 
            // tb_filtr
            // 
            this.tb_filtr.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_filtr.Location = new System.Drawing.Point(262, 104);
            this.tb_filtr.Name = "tb_filtr";
            this.tb_filtr.Size = new System.Drawing.Size(335, 29);
            this.tb_filtr.TabIndex = 9;
            // 
            // btn_find
            // 
            this.btn_find.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_find.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_find.Location = new System.Drawing.Point(628, 100);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(124, 36);
            this.btn_find.TabIndex = 10;
            this.btn_find.Text = "Найти";
            this.btn_find.UseVisualStyleBackColor = false;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // lb_filtr
            // 
            this.lb_filtr.AutoSize = true;
            this.lb_filtr.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_filtr.Location = new System.Drawing.Point(44, 74);
            this.lb_filtr.Name = "lb_filtr";
            this.lb_filtr.Size = new System.Drawing.Size(85, 23);
            this.lb_filtr.TabIndex = 11;
            this.lb_filtr.Text = "Фильтр по";
            // 
            // lb_value
            // 
            this.lb_value.AutoSize = true;
            this.lb_value.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_value.Location = new System.Drawing.Point(258, 73);
            this.lb_value.Name = "lb_value";
            this.lb_value.Size = new System.Drawing.Size(81, 23);
            this.lb_value.TabIndex = 12;
            this.lb_value.Text = "Значение";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_add.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_add.Location = new System.Drawing.Point(518, 457);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(234, 36);
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "Добавить сотрудника";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_back.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_back.Location = new System.Drawing.Point(48, 457);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(90, 36);
            this.btn_back.TabIndex = 14;
            this.btn_back.Text = "Назад";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Sotrudniki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(804, 511);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lb_value);
            this.Controls.Add(this.lb_filtr);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.tb_filtr);
            this.Controls.Add(this.lb_zagolovok);
            this.Controls.Add(this.cb_filtr);
            this.Controls.Add(this.dataGridView);
            this.MaximumSize = new System.Drawing.Size(820, 550);
            this.MinimumSize = new System.Drawing.Size(820, 550);
            this.Name = "Sotrudniki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_sotrudniki";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sotrudniki_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ComboBox cb_filtr;
        private System.Windows.Forms.Label lb_zagolovok;
        private System.Windows.Forms.TextBox tb_filtr;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.Label lb_filtr;
        private System.Windows.Forms.Label lb_value;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_back;
    }
}