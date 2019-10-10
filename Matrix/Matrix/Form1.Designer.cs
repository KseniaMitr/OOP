namespace Matrix
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.matr1 = new System.Windows.Forms.DataGridView();
            this.matr2 = new System.Windows.Forms.DataGridView();
            this.matrResult = new System.Windows.Forms.DataGridView();
            this.butExit = new System.Windows.Forms.Button();
            this.butSum = new System.Windows.Forms.Button();
            this.butUmnog = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.butTran1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.razmM = new System.Windows.Forms.TextBox();
            this.sizeMatr = new System.Windows.Forms.Button();
            this.no = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.butTran2 = new System.Windows.Forms.Button();
            this.butTran3 = new System.Windows.Forms.Button();
            this.fillRandomValues1 = new System.Windows.Forms.Button();
            this.fillRandomValues2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.matr1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matr2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrResult)).BeginInit();
            this.SuspendLayout();
            // 
            // matr1
            // 
            this.matr1.AllowDrop = true;
            this.matr1.AllowUserToAddRows = false;
            this.matr1.AllowUserToOrderColumns = true;
            this.matr1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.matr1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.matr1.DefaultCellStyle = dataGridViewCellStyle1;
            this.matr1.Location = new System.Drawing.Point(29, 139);
            this.matr1.MultiSelect = false;
            this.matr1.Name = "matr1";
            this.matr1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.matr1.RowTemplate.Height = 24;
            this.matr1.Size = new System.Drawing.Size(345, 345);
            this.matr1.TabIndex = 0;
            this.matr1.Tag = "1";
            // 
            // matr2
            // 
            this.matr2.AllowUserToAddRows = false;
            this.matr2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.matr2.DefaultCellStyle = dataGridViewCellStyle2;
            this.matr2.Location = new System.Drawing.Point(441, 139);
            this.matr2.Name = "matr2";
            this.matr2.RowTemplate.Height = 24;
            this.matr2.Size = new System.Drawing.Size(345, 345);
            this.matr2.TabIndex = 1;
            this.matr2.Tag = "2";
            // 
            // matrResult
            // 
            this.matrResult.AllowUserToAddRows = false;
            this.matrResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.matrResult.DefaultCellStyle = dataGridViewCellStyle3;
            this.matrResult.Enabled = false;
            this.matrResult.Location = new System.Drawing.Point(855, 139);
            this.matrResult.Name = "matrResult";
            this.matrResult.RowTemplate.Height = 24;
            this.matrResult.Size = new System.Drawing.Size(345, 345);
            this.matrResult.TabIndex = 2;
            this.matrResult.Tag = "3";
            // 
            // butExit
            // 
            this.butExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butExit.Location = new System.Drawing.Point(1124, 504);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(100, 46);
            this.butExit.TabIndex = 3;
            this.butExit.Text = "EXIT";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // butSum
            // 
            this.butSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butSum.Location = new System.Drawing.Point(379, 218);
            this.butSum.Name = "butSum";
            this.butSum.Size = new System.Drawing.Size(57, 94);
            this.butSum.TabIndex = 4;
            this.butSum.Text = "+";
            this.butSum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butSum.UseVisualStyleBackColor = true;
            this.butSum.Click += new System.EventHandler(this.butSum_Click);
            // 
            // butUmnog
            // 
            this.butUmnog.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butUmnog.Location = new System.Drawing.Point(378, 318);
            this.butUmnog.Name = "butUmnog";
            this.butUmnog.Size = new System.Drawing.Size(59, 98);
            this.butUmnog.TabIndex = 6;
            this.butUmnog.Text = "*";
            this.butUmnog.UseVisualStyleBackColor = true;
            this.butUmnog.Click += new System.EventHandler(this.butUmnog_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Первая матрица";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(560, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Вторая матрица";
            // 
            // butTran1
            // 
            this.butTran1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butTran1.Location = new System.Drawing.Point(378, 139);
            this.butTran1.Name = "butTran1";
            this.butTran1.Size = new System.Drawing.Size(32, 38);
            this.butTran1.TabIndex = 10;
            this.butTran1.Text = "!";
            this.butTran1.UseVisualStyleBackColor = true;
            this.butTran1.Click += new System.EventHandler(this.butTran1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(991, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Результат";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(345, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(305, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Введите размерность матриц:";
            // 
            // razmM
            // 
            this.razmM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.razmM.Location = new System.Drawing.Point(670, 42);
            this.razmM.Name = "razmM";
            this.razmM.Size = new System.Drawing.Size(100, 30);
            this.razmM.TabIndex = 15;
            this.razmM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.razmM_KeyPress);
            // 
            // sizeMatr
            // 
            this.sizeMatr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sizeMatr.Location = new System.Drawing.Point(784, 40);
            this.sizeMatr.Name = "sizeMatr";
            this.sizeMatr.Size = new System.Drawing.Size(75, 36);
            this.sizeMatr.TabIndex = 16;
            this.sizeMatr.Text = "OK";
            this.sizeMatr.UseVisualStyleBackColor = true;
            this.sizeMatr.Click += new System.EventHandler(this.sizeMatr_Click);
            // 
            // no
            // 
            this.no.AutoSize = true;
            this.no.Location = new System.Drawing.Point(652, 79);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(172, 17);
            this.no.TabIndex = 17;
            this.no.Text = "Введите число больше 0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 662);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "label5";
            // 
            // butTran2
            // 
            this.butTran2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butTran2.Location = new System.Drawing.Point(790, 139);
            this.butTran2.Name = "butTran2";
            this.butTran2.Size = new System.Drawing.Size(32, 38);
            this.butTran2.TabIndex = 19;
            this.butTran2.Text = "!";
            this.butTran2.UseVisualStyleBackColor = true;
            this.butTran2.Click += new System.EventHandler(this.butTran2_Click);
            // 
            // butTran3
            // 
            this.butTran3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butTran3.Location = new System.Drawing.Point(1202, 139);
            this.butTran3.Name = "butTran3";
            this.butTran3.Size = new System.Drawing.Size(32, 38);
            this.butTran3.TabIndex = 20;
            this.butTran3.Text = "!";
            this.butTran3.UseVisualStyleBackColor = true;
            this.butTran3.Click += new System.EventHandler(this.butTran3_Click);
            // 
            // fillRandomValues1
            // 
            this.fillRandomValues1.Location = new System.Drawing.Point(29, 490);
            this.fillRandomValues1.Name = "fillRandomValues1";
            this.fillRandomValues1.Size = new System.Drawing.Size(345, 31);
            this.fillRandomValues1.TabIndex = 21;
            this.fillRandomValues1.Text = "заполнить случайными числами";
            this.fillRandomValues1.UseVisualStyleBackColor = true;
            this.fillRandomValues1.Click += new System.EventHandler(this.fillRandomValues1_Click);
            // 
            // fillRandomValues2
            // 
            this.fillRandomValues2.Location = new System.Drawing.Point(441, 490);
            this.fillRandomValues2.Name = "fillRandomValues2";
            this.fillRandomValues2.Size = new System.Drawing.Size(345, 31);
            this.fillRandomValues2.TabIndex = 23;
            this.fillRandomValues2.Text = "заполнить случайными числами";
            this.fillRandomValues2.UseVisualStyleBackColor = true;
            this.fillRandomValues2.Click += new System.EventHandler(this.fillRandomValues2_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(792, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 304);
            this.label6.TabIndex = 24;
            this.label6.Text = "=";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 562);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fillRandomValues2);
            this.Controls.Add(this.fillRandomValues1);
            this.Controls.Add(this.butTran3);
            this.Controls.Add(this.butTran2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.no);
            this.Controls.Add(this.sizeMatr);
            this.Controls.Add(this.razmM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.butTran1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butUmnog);
            this.Controls.Add(this.butSum);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.matrResult);
            this.Controls.Add(this.matr2);
            this.Controls.Add(this.matr1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matrix";
            ((System.ComponentModel.ISupportInitialize)(this.matr1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matr2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView matr1;
        private System.Windows.Forms.DataGridView matr2;
        private System.Windows.Forms.DataGridView matrResult;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Button butSum;
        private System.Windows.Forms.Button butUmnog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butTran1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox razmM;
        private System.Windows.Forms.Button sizeMatr;
        private System.Windows.Forms.Label no;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button butTran2;
        private System.Windows.Forms.Button butTran3;
        private System.Windows.Forms.Button fillRandomValues1;
        private System.Windows.Forms.Button fillRandomValues2;
        private System.Windows.Forms.Label label6;
    }
}

