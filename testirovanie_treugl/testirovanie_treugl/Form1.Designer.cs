namespace testirovanie_treugl
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.l_text = new System.Windows.Forms.Label();
            this.f_side = new System.Windows.Forms.TextBox();
            this.s_side = new System.Windows.Forms.TextBox();
            this.t_side = new System.Windows.Forms.TextBox();
            this.b_check = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.92398F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.07602F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 147F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.tableLayoutPanel1.Controls.Add(this.l_text, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.f_side, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.s_side, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.t_side, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.b_check, 2, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.7747F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.2253F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 208F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(874, 593);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // l_text
            // 
            this.l_text.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.l_text, 4);
            this.l_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_text.Location = new System.Drawing.Point(162, 158);
            this.l_text.Name = "l_text";
            this.l_text.Size = new System.Drawing.Size(560, 72);
            this.l_text.TabIndex = 0;
            this.l_text.Text = "Введите стороны треугольника";
            this.l_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // f_side
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.f_side, 2);
            this.f_side.Dock = System.Windows.Forms.DockStyle.Fill;
            this.f_side.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f_side.Location = new System.Drawing.Point(3, 253);
            this.f_side.MaxLength = 9;
            this.f_side.Multiline = true;
            this.f_side.Name = "f_side";
            this.f_side.Size = new System.Drawing.Size(294, 34);
            this.f_side.TabIndex = 1;
            this.f_side.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.f_side.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f_side_KeyPress);
            // 
            // s_side
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.s_side, 2);
            this.s_side.Dock = System.Windows.Forms.DockStyle.Fill;
            this.s_side.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.s_side.Location = new System.Drawing.Point(303, 253);
            this.s_side.MaxLength = 9;
            this.s_side.Multiline = true;
            this.s_side.Name = "s_side";
            this.s_side.Size = new System.Drawing.Size(286, 34);
            this.s_side.TabIndex = 2;
            this.s_side.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.s_side.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f_side_KeyPress);
            // 
            // t_side
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.t_side, 2);
            this.t_side.Dock = System.Windows.Forms.DockStyle.Fill;
            this.t_side.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.t_side.Location = new System.Drawing.Point(595, 253);
            this.t_side.MaxLength = 9;
            this.t_side.Multiline = true;
            this.t_side.Name = "t_side";
            this.t_side.Size = new System.Drawing.Size(276, 34);
            this.t_side.TabIndex = 3;
            this.t_side.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t_side.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.f_side_KeyPress);
            // 
            // b_check
            // 
            this.b_check.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.b_check, 2);
            this.b_check.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_check.Location = new System.Drawing.Point(303, 326);
            this.b_check.Name = "b_check";
            this.b_check.Size = new System.Drawing.Size(286, 55);
            this.b_check.TabIndex = 4;
            this.b_check.Text = "Проверить";
            this.b_check.UseVisualStyleBackColor = false;
            this.b_check.Click += new System.EventHandler(this.b_check_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(874, 593);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Треугольник";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label l_text;
        private System.Windows.Forms.TextBox f_side;
        private System.Windows.Forms.TextBox s_side;
        private System.Windows.Forms.TextBox t_side;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button b_check;
    }
}

