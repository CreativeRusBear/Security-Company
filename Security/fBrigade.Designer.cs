namespace Security
{
    partial class fBrigade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fBrigade));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.excelBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.pMenuTop = new System.Windows.Forms.Panel();
            this.saveBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBrigade = new System.Windows.Forms.DataGridView();
            this.lNumber = new System.Windows.Forms.Label();
            this.pMenuBottom = new System.Windows.Forms.Panel();
            this.workersBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpCall = new System.Windows.Forms.DateTimePicker();
            this.tbCause = new System.Windows.Forms.TextBox();
            this.tbCrashes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbService = new System.Windows.Forms.ComboBox();
            this.pMenuTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrigade)).BeginInit();
            this.pMenuBottom.SuspendLayout();
            this.SuspendLayout();
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
            this.pMenuTop.TabIndex = 24;
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
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(221, 86);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(442, 27);
            this.tbSearch.TabIndex = 26;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "Поиск";
            // 
            // dgvBrigade
            // 
            this.dgvBrigade.AllowUserToAddRows = false;
            this.dgvBrigade.AllowUserToDeleteRows = false;
            this.dgvBrigade.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBrigade.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBrigade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBrigade.Location = new System.Drawing.Point(11, 132);
            this.dgvBrigade.Name = "dgvBrigade";
            this.dgvBrigade.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBrigade.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvBrigade.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBrigade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBrigade.Size = new System.Drawing.Size(652, 242);
            this.dgvBrigade.TabIndex = 23;
            this.dgvBrigade.SelectionChanged += new System.EventHandler(this.dgvBrigade_SelectionChanged);
            // 
            // lNumber
            // 
            this.lNumber.AutoSize = true;
            this.lNumber.Location = new System.Drawing.Point(337, 31);
            this.lNumber.Name = "lNumber";
            this.lNumber.Size = new System.Drawing.Size(117, 21);
            this.lNumber.TabIndex = 2;
            this.lNumber.Text = "Проишествия";
            // 
            // pMenuBottom
            // 
            this.pMenuBottom.Controls.Add(this.workersBtn);
            this.pMenuBottom.Controls.Add(this.label6);
            this.pMenuBottom.Controls.Add(this.dtpCall);
            this.pMenuBottom.Controls.Add(this.tbCause);
            this.pMenuBottom.Controls.Add(this.tbCrashes);
            this.pMenuBottom.Controls.Add(this.pictureBox1);
            this.pMenuBottom.Controls.Add(this.label5);
            this.pMenuBottom.Controls.Add(this.label2);
            this.pMenuBottom.Controls.Add(this.lNumber);
            this.pMenuBottom.Controls.Add(this.cbService);
            this.pMenuBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pMenuBottom.Location = new System.Drawing.Point(0, 408);
            this.pMenuBottom.Name = "pMenuBottom";
            this.pMenuBottom.Size = new System.Drawing.Size(675, 515);
            this.pMenuBottom.TabIndex = 27;
            // 
            // workersBtn
            // 
            this.workersBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.workersBtn.FlatAppearance.BorderSize = 0;
            this.workersBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.workersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.workersBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workersBtn.ForeColor = System.Drawing.Color.White;
            this.workersBtn.Location = new System.Drawing.Point(27, 421);
            this.workersBtn.Name = "workersBtn";
            this.workersBtn.Size = new System.Drawing.Size(278, 42);
            this.workersBtn.TabIndex = 57;
            this.workersBtn.Text = "Работа с сотрудниками";
            this.workersBtn.UseVisualStyleBackColor = false;
            this.workersBtn.Click += new System.EventHandler(this.workersBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(340, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 21);
            this.label6.TabIndex = 55;
            this.label6.Text = "Дата вызова";
            // 
            // dtpCall
            // 
            this.dtpCall.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCall.Location = new System.Drawing.Point(344, 436);
            this.dtpCall.Name = "dtpCall";
            this.dtpCall.Size = new System.Drawing.Size(277, 27);
            this.dtpCall.TabIndex = 54;
            this.dtpCall.ValueChanged += new System.EventHandler(this.tbCrashes_TextChanged);
            // 
            // tbCause
            // 
            this.tbCause.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCause.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCause.Location = new System.Drawing.Point(338, 195);
            this.tbCause.Multiline = true;
            this.tbCause.Name = "tbCause";
            this.tbCause.Size = new System.Drawing.Size(278, 87);
            this.tbCause.TabIndex = 52;
            this.tbCause.TextChanged += new System.EventHandler(this.tbCrashes_TextChanged);
            // 
            // tbCrashes
            // 
            this.tbCrashes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCrashes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCrashes.Location = new System.Drawing.Point(338, 55);
            this.tbCrashes.Multiline = true;
            this.tbCrashes.Name = "tbCrashes";
            this.tbCrashes.Size = new System.Drawing.Size(278, 87);
            this.tbCrashes.TabIndex = 52;
            this.tbCrashes.TextChanged += new System.EventHandler(this.tbCrashes_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Услуга";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Причина вызова";
            // 
            // cbService
            // 
            this.cbService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbService.FormattingEnabled = true;
            this.cbService.Location = new System.Drawing.Point(341, 362);
            this.cbService.Name = "cbService";
            this.cbService.Size = new System.Drawing.Size(278, 29);
            this.cbService.TabIndex = 4;
            this.cbService.SelectedIndexChanged += new System.EventHandler(this.tbCrashes_TextChanged);
            // 
            // fBrigade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 923);
            this.Controls.Add(this.pMenuTop);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBrigade);
            this.Controls.Add(this.pMenuBottom);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "fBrigade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Security | Бригада";
            this.Load += new System.EventHandler(this.fBrigade_Load);
            this.pMenuTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrigade)).EndInit();
            this.pMenuBottom.ResumeLayout(false);
            this.pMenuBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button excelBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Panel pMenuTop;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBrigade;
        private System.Windows.Forms.Label lNumber;
        private System.Windows.Forms.Panel pMenuBottom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCrashes;
        private System.Windows.Forms.TextBox tbCause;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbService;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpCall;
        private System.Windows.Forms.Button workersBtn;
    }
}