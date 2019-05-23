namespace Security
{
    partial class fContracts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fContracts));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbService = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.pMenuBottom = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDateEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpDateStart = new System.Windows.Forms.DateTimePicker();
            this.tbNum = new System.Windows.Forms.TextBox();
            this.lNumber = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPeriod = new System.Windows.Forms.TextBox();
            this.lSeries = new System.Windows.Forms.Label();
            this.cbClients = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMonth = new System.Windows.Forms.TextBox();
            this.lFIO = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvContracts = new System.Windows.Forms.DataGridView();
            this.addBtn = new System.Windows.Forms.Button();
            this.pMenuTop = new System.Windows.Forms.Panel();
            this.excelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.pMenuBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).BeginInit();
            this.pMenuTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbService
            // 
            this.tbService.Enabled = false;
            this.tbService.Location = new System.Drawing.Point(339, 195);
            this.tbService.Name = "tbService";
            this.tbService.Size = new System.Drawing.Size(278, 27);
            this.tbService.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Услуга";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(339, 422);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(278, 27);
            this.tbAddress.TabIndex = 7;
            this.tbAddress.TextChanged += new System.EventHandler(this.tbNum_TextChanged);
            this.tbAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAddress_KeyPress);
            // 
            // pMenuBottom
            // 
            this.pMenuBottom.Controls.Add(this.pictureBox1);
            this.pMenuBottom.Controls.Add(this.tbService);
            this.pMenuBottom.Controls.Add(this.label5);
            this.pMenuBottom.Controls.Add(this.tbAddress);
            this.pMenuBottom.Controls.Add(this.label6);
            this.pMenuBottom.Controls.Add(this.label2);
            this.pMenuBottom.Controls.Add(this.dtpDateEnd);
            this.pMenuBottom.Controls.Add(this.dtpDateStart);
            this.pMenuBottom.Controls.Add(this.tbNum);
            this.pMenuBottom.Controls.Add(this.lNumber);
            this.pMenuBottom.Controls.Add(this.label4);
            this.pMenuBottom.Controls.Add(this.tbPeriod);
            this.pMenuBottom.Controls.Add(this.lSeries);
            this.pMenuBottom.Controls.Add(this.cbClients);
            this.pMenuBottom.Controls.Add(this.label3);
            this.pMenuBottom.Controls.Add(this.tbMonth);
            this.pMenuBottom.Controls.Add(this.lFIO);
            this.pMenuBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pMenuBottom.Location = new System.Drawing.Point(0, 411);
            this.pMenuBottom.Name = "pMenuBottom";
            this.pMenuBottom.Size = new System.Drawing.Size(675, 461);
            this.pMenuBottom.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(337, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Дата рассторжения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Дата заключения";
            // 
            // dtpDateEnd
            // 
            this.dtpDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateEnd.Location = new System.Drawing.Point(341, 346);
            this.dtpDateEnd.Name = "dtpDateEnd";
            this.dtpDateEnd.Size = new System.Drawing.Size(277, 27);
            this.dtpDateEnd.TabIndex = 5;
            this.dtpDateEnd.ValueChanged += new System.EventHandler(this.tbNum_TextChanged);
            // 
            // dtpDateStart
            // 
            this.dtpDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateStart.Location = new System.Drawing.Point(339, 268);
            this.dtpDateStart.Name = "dtpDateStart";
            this.dtpDateStart.Size = new System.Drawing.Size(277, 27);
            this.dtpDateStart.TabIndex = 5;
            this.dtpDateStart.ValueChanged += new System.EventHandler(this.tbNum_TextChanged);
            // 
            // tbNum
            // 
            this.tbNum.Location = new System.Drawing.Point(339, 55);
            this.tbNum.MaxLength = 2;
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(278, 27);
            this.tbNum.TabIndex = 3;
            this.tbNum.TextChanged += new System.EventHandler(this.tbNum_TextChanged);
            this.tbNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNum_KeyPress);
            // 
            // lNumber
            // 
            this.lNumber.AutoSize = true;
            this.lNumber.Location = new System.Drawing.Point(337, 31);
            this.lNumber.Name = "lNumber";
            this.lNumber.Size = new System.Drawing.Size(144, 21);
            this.lNumber.TabIndex = 2;
            this.lNumber.Text = "Номер договора";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Цена в месяц";
            // 
            // tbPeriod
            // 
            this.tbPeriod.Location = new System.Drawing.Point(25, 422);
            this.tbPeriod.MaxLength = 12;
            this.tbPeriod.Name = "tbPeriod";
            this.tbPeriod.Size = new System.Drawing.Size(278, 27);
            this.tbPeriod.TabIndex = 3;
            this.tbPeriod.TextChanged += new System.EventHandler(this.tbNum_TextChanged);
            this.tbPeriod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNum_KeyPress);
            // 
            // lSeries
            // 
            this.lSeries.AutoSize = true;
            this.lSeries.Location = new System.Drawing.Point(28, 398);
            this.lSeries.Name = "lSeries";
            this.lSeries.Size = new System.Drawing.Size(222, 21);
            this.lSeries.TabIndex = 2;
            this.lSeries.Text = "Стоимость за весь период";
            // 
            // cbClients
            // 
            this.cbClients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClients.FormattingEnabled = true;
            this.cbClients.Location = new System.Drawing.Point(339, 122);
            this.cbClients.Name = "cbClients";
            this.cbClients.Size = new System.Drawing.Size(278, 29);
            this.cbClients.TabIndex = 4;
            this.cbClients.SelectedIndexChanged += new System.EventHandler(this.tbNum_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Клиент";
            // 
            // tbMonth
            // 
            this.tbMonth.Location = new System.Drawing.Point(25, 346);
            this.tbMonth.MaxLength = 8;
            this.tbMonth.Name = "tbMonth";
            this.tbMonth.Size = new System.Drawing.Size(278, 27);
            this.tbMonth.TabIndex = 3;
            this.tbMonth.TextChanged += new System.EventHandler(this.tbNum_TextChanged);
            this.tbMonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNum_KeyPress);
            // 
            // lFIO
            // 
            this.lFIO.AutoSize = true;
            this.lFIO.Location = new System.Drawing.Point(337, 398);
            this.lFIO.Name = "lFIO";
            this.lFIO.Size = new System.Drawing.Size(181, 21);
            this.lFIO.TabIndex = 2;
            this.lFIO.Text = "Адрес обслуживания";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(221, 86);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(442, 27);
            this.tbSearch.TabIndex = 21;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Поиск";
            // 
            // dgvContracts
            // 
            this.dgvContracts.AllowUserToAddRows = false;
            this.dgvContracts.AllowUserToDeleteRows = false;
            this.dgvContracts.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContracts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContracts.Location = new System.Drawing.Point(11, 132);
            this.dgvContracts.Name = "dgvContracts";
            this.dgvContracts.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContracts.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvContracts.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvContracts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContracts.Size = new System.Drawing.Size(652, 242);
            this.dgvContracts.TabIndex = 18;
            this.dgvContracts.SelectionChanged += new System.EventHandler(this.dgvContracts_SelectionChanged);
            // 
            // addBtn
            // 
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(0, -1);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(133, 65);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "Добавить";
            this.addBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // pMenuTop
            // 
            this.pMenuTop.Controls.Add(this.excelBtn);
            this.pMenuTop.Controls.Add(this.saveBtn);
            this.pMenuTop.Controls.Add(this.delBtn);
            this.pMenuTop.Controls.Add(this.addBtn);
            this.pMenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pMenuTop.Location = new System.Drawing.Point(0, 0);
            this.pMenuTop.Name = "pMenuTop";
            this.pMenuTop.Size = new System.Drawing.Size(675, 64);
            this.pMenuTop.TabIndex = 19;
            // 
            // excelBtn
            // 
            this.excelBtn.FlatAppearance.BorderSize = 0;
            this.excelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excelBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.excelBtn.ForeColor = System.Drawing.Color.White;
            this.excelBtn.Location = new System.Drawing.Point(488, 0);
            this.excelBtn.Name = "excelBtn";
            this.excelBtn.Size = new System.Drawing.Size(187, 65);
            this.excelBtn.TabIndex = 7;
            this.excelBtn.Text = "Вывести в Excel";
            this.excelBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.excelBtn.UseVisualStyleBackColor = true;
            this.excelBtn.Click += new System.EventHandler(this.excelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(354, 0);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(142, 65);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.FlatAppearance.BorderSize = 0;
            this.delBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delBtn.ForeColor = System.Drawing.Color.White;
            this.delBtn.Location = new System.Drawing.Point(129, -1);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(229, 65);
            this.delBtn.TabIndex = 5;
            this.delBtn.Text = "Удалить/Отменить";
            this.delBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // fContracts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 872);
            this.Controls.Add(this.pMenuBottom);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvContracts);
            this.Controls.Add(this.pMenuTop);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "fContracts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Security | Договоры";
            this.pMenuBottom.ResumeLayout(false);
            this.pMenuBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).EndInit();
            this.pMenuTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbService;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Panel pMenuBottom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDateStart;
        private System.Windows.Forms.TextBox tbNum;
        private System.Windows.Forms.Label lNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPeriod;
        private System.Windows.Forms.Label lSeries;
        private System.Windows.Forms.ComboBox cbClients;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMonth;
        private System.Windows.Forms.Label lFIO;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvContracts;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Panel pMenuTop;
        private System.Windows.Forms.Button excelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDateEnd;
    }
}