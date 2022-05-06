namespace Uniforms
{
    partial class Uniforms
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
            this.lb_zagolovok = new System.Windows.Forms.Label();
            this.lb_filtr = new System.Windows.Forms.Label();
            this.btn_find = new System.Windows.Forms.Button();
            this.cb_filtr = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tb_filtr = new System.Windows.Forms.TextBox();
            this.lb_value = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_give = new System.Windows.Forms.Button();
            this.btn_change = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_zagolovok
            // 
            this.lb_zagolovok.AutoSize = true;
            this.lb_zagolovok.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_zagolovok.Location = new System.Drawing.Point(311, 9);
            this.lb_zagolovok.Name = "lb_zagolovok";
            this.lb_zagolovok.Size = new System.Drawing.Size(188, 42);
            this.lb_zagolovok.TabIndex = 9;
            this.lb_zagolovok.Text = "Спецодежда";
            // 
            // lb_filtr
            // 
            this.lb_filtr.AutoSize = true;
            this.lb_filtr.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_filtr.Location = new System.Drawing.Point(46, 73);
            this.lb_filtr.Name = "lb_filtr";
            this.lb_filtr.Size = new System.Drawing.Size(85, 23);
            this.lb_filtr.TabIndex = 17;
            this.lb_filtr.Text = "Фильтр по";
            // 
            // btn_find
            // 
            this.btn_find.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_find.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_find.Location = new System.Drawing.Point(630, 99);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(124, 36);
            this.btn_find.TabIndex = 16;
            this.btn_find.Text = "Найти";
            this.btn_find.UseVisualStyleBackColor = false;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // cb_filtr
            // 
            this.cb_filtr.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_filtr.FormattingEnabled = true;
            this.cb_filtr.Location = new System.Drawing.Point(50, 103);
            this.cb_filtr.Name = "cb_filtr";
            this.cb_filtr.Size = new System.Drawing.Size(181, 31);
            this.cb_filtr.TabIndex = 14;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(50, 153);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(704, 288);
            this.dataGridView.TabIndex = 13;
            // 
            // tb_filtr
            // 
            this.tb_filtr.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_filtr.Location = new System.Drawing.Point(264, 103);
            this.tb_filtr.Name = "tb_filtr";
            this.tb_filtr.Size = new System.Drawing.Size(335, 29);
            this.tb_filtr.TabIndex = 15;
            // 
            // lb_value
            // 
            this.lb_value.AutoSize = true;
            this.lb_value.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_value.Location = new System.Drawing.Point(260, 72);
            this.lb_value.Name = "lb_value";
            this.lb_value.Size = new System.Drawing.Size(81, 23);
            this.lb_value.TabIndex = 18;
            this.lb_value.Text = "Значение";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_back.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_back.Location = new System.Drawing.Point(50, 486);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(90, 36);
            this.btn_back.TabIndex = 20;
            this.btn_back.Text = "Назад";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_add.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_add.Location = new System.Drawing.Point(520, 562);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(234, 36);
            this.btn_add.TabIndex = 19;
            this.btn_add.Text = "Добавить одежду";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_give
            // 
            this.btn_give.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_give.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_give.Location = new System.Drawing.Point(520, 465);
            this.btn_give.Name = "btn_give";
            this.btn_give.Size = new System.Drawing.Size(234, 36);
            this.btn_give.TabIndex = 21;
            this.btn_give.Text = "Выдать одежду";
            this.btn_give.UseVisualStyleBackColor = false;
            this.btn_give.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_change
            // 
            this.btn_change.BackColor = System.Drawing.Color.PapayaWhip;
            this.btn_change.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_change.Location = new System.Drawing.Point(520, 515);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(234, 36);
            this.btn_change.TabIndex = 22;
            this.btn_change.Text = "Принять одежду";
            this.btn_change.UseVisualStyleBackColor = false;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // Uniforms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(834, 611);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.btn_give);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lb_value);
            this.Controls.Add(this.lb_filtr);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.tb_filtr);
            this.Controls.Add(this.cb_filtr);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.lb_zagolovok);
            this.MaximumSize = new System.Drawing.Size(850, 650);
            this.MinimumSize = new System.Drawing.Size(850, 650);
            this.Name = "Uniforms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uniforms";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Uniforms_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_zagolovok;
        private System.Windows.Forms.Label lb_filtr;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.ComboBox cb_filtr;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox tb_filtr;
        private System.Windows.Forms.Label lb_value;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_give;
        private System.Windows.Forms.Button btn_change;
    }
}