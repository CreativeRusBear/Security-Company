namespace Security
{
    partial class fClients
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fClients));
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.addBtn = new System.Windows.Forms.Button();
            this.pMenuTop = new System.Windows.Forms.Panel();
            this.excelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.pMenuBottom = new System.Windows.Forms.Panel();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpBithday = new System.Windows.Forms.DateTimePicker();
            this.tbNum = new System.Windows.Forms.TextBox();
            this.lNumber = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSeries = new System.Windows.Forms.TextBox();
            this.lSeries = new System.Windows.Forms.Label();
            this.cbService = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFIO = new System.Windows.Forms.TextBox();
            this.lFIO = new System.Windows.Forms.Label();
            this.User_photo = new System.Windows.Forms.PictureBox();
            this.forPhoto = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.pMenuTop.SuspendLayout();
            this.pMenuBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.User_photo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            this.dgvClients.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Location = new System.Drawing.Point(11, 132);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClients.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvClients.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClients.Size = new System.Drawing.Size(652, 242);
            this.dgvClients.TabIndex = 13;
            this.dgvClients.SelectionChanged += new System.EventHandler(this.dgvClients_SelectionChanged);
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
            this.pMenuTop.TabIndex = 14;
            // 
            // excelBtn
            // 
            this.excelBtn.FlatAppearance.BorderSize = 0;
            this.excelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excelBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.excelBtn.ForeColor = System.Drawing.Color.White;
            this.excelBtn.Location = new System.Drawing.Point(488, -1);
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
            this.saveBtn.Location = new System.Drawing.Point(350, 0);
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
            this.delBtn.Size = new System.Drawing.Size(230, 65);
            this.delBtn.TabIndex = 5;
            this.delBtn.Text = "Удалить/Отменить";
            this.delBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Поиск";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(221, 86);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(442, 27);
            this.tbSearch.TabIndex = 16;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // pMenuBottom
            // 
            this.pMenuBottom.Controls.Add(this.tbEmail);
            this.pMenuBottom.Controls.Add(this.label5);
            this.pMenuBottom.Controls.Add(this.tbPhone);
            this.pMenuBottom.Controls.Add(this.label2);
            this.pMenuBottom.Controls.Add(this.dtpBithday);
            this.pMenuBottom.Controls.Add(this.tbNum);
            this.pMenuBottom.Controls.Add(this.lNumber);
            this.pMenuBottom.Controls.Add(this.label4);
            this.pMenuBottom.Controls.Add(this.tbSeries);
            this.pMenuBottom.Controls.Add(this.lSeries);
            this.pMenuBottom.Controls.Add(this.cbService);
            this.pMenuBottom.Controls.Add(this.label3);
            this.pMenuBottom.Controls.Add(this.tbFIO);
            this.pMenuBottom.Controls.Add(this.lFIO);
            this.pMenuBottom.Controls.Add(this.User_photo);
            this.pMenuBottom.Controls.Add(this.forPhoto);
            this.pMenuBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pMenuBottom.Location = new System.Drawing.Point(0, 413);
            this.pMenuBottom.Name = "pMenuBottom";
            this.pMenuBottom.Size = new System.Drawing.Size(675, 461);
            this.pMenuBottom.TabIndex = 17;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(333, 403);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(278, 27);
            this.tbEmail.TabIndex = 7;
            this.tbEmail.TextChanged += new System.EventHandler(this.tbFIO_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Эл. почта";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(333, 332);
            this.tbPhone.MaxLength = 11;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(278, 27);
            this.tbPhone.TabIndex = 7;
            this.tbPhone.TextChanged += new System.EventHandler(this.tbFIO_TextChanged);
            this.tbPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSeries_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Номер телефона";
            // 
            // dtpBithday
            // 
            this.dtpBithday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBithday.Location = new System.Drawing.Point(335, 264);
            this.dtpBithday.Name = "dtpBithday";
            this.dtpBithday.Size = new System.Drawing.Size(277, 27);
            this.dtpBithday.TabIndex = 5;
            this.dtpBithday.ValueChanged += new System.EventHandler(this.tbFIO_TextChanged);
            // 
            // tbNum
            // 
            this.tbNum.Location = new System.Drawing.Point(471, 190);
            this.tbNum.MaxLength = 6;
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(141, 27);
            this.tbNum.TabIndex = 3;
            this.tbNum.TextChanged += new System.EventHandler(this.tbFIO_TextChanged);
            this.tbNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSeries_KeyPress);
            // 
            // lNumber
            // 
            this.lNumber.AutoSize = true;
            this.lNumber.Location = new System.Drawing.Point(469, 166);
            this.lNumber.Name = "lNumber";
            this.lNumber.Size = new System.Drawing.Size(66, 21);
            this.lNumber.TabIndex = 2;
            this.lNumber.Text = "Номер";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "День Рождения";
            // 
            // tbSeries
            // 
            this.tbSeries.Location = new System.Drawing.Point(333, 190);
            this.tbSeries.MaxLength = 4;
            this.tbSeries.Name = "tbSeries";
            this.tbSeries.Size = new System.Drawing.Size(108, 27);
            this.tbSeries.TabIndex = 3;
            this.tbSeries.TextChanged += new System.EventHandler(this.tbFIO_TextChanged);
            this.tbSeries.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSeries_KeyPress);
            // 
            // lSeries
            // 
            this.lSeries.AutoSize = true;
            this.lSeries.Location = new System.Drawing.Point(331, 166);
            this.lSeries.Name = "lSeries";
            this.lSeries.Size = new System.Drawing.Size(61, 21);
            this.lSeries.TabIndex = 2;
            this.lSeries.Text = "Серия";
            // 
            // cbService
            // 
            this.cbService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbService.FormattingEnabled = true;
            this.cbService.Location = new System.Drawing.Point(334, 114);
            this.cbService.Name = "cbService";
            this.cbService.Size = new System.Drawing.Size(278, 29);
            this.cbService.TabIndex = 4;
            this.cbService.SelectedIndexChanged += new System.EventHandler(this.cbService_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Выбранная услуга";
            // 
            // tbFIO
            // 
            this.tbFIO.Location = new System.Drawing.Point(334, 42);
            this.tbFIO.Name = "tbFIO";
            this.tbFIO.Size = new System.Drawing.Size(278, 27);
            this.tbFIO.TabIndex = 3;
            this.tbFIO.TextChanged += new System.EventHandler(this.tbFIO_TextChanged);
            this.tbFIO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFIO_KeyPress);
            // 
            // lFIO
            // 
            this.lFIO.AutoSize = true;
            this.lFIO.Location = new System.Drawing.Point(337, 18);
            this.lFIO.Name = "lFIO";
            this.lFIO.Size = new System.Drawing.Size(50, 21);
            this.lFIO.TabIndex = 2;
            this.lFIO.Text = "ФИО";
            // 
            // User_photo
            // 
            this.User_photo.Location = new System.Drawing.Point(49, 18);
            this.User_photo.Name = "User_photo";
            this.User_photo.Size = new System.Drawing.Size(233, 214);
            this.User_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.User_photo.TabIndex = 0;
            this.User_photo.TabStop = false;
            this.User_photo.DoubleClick += new System.EventHandler(this.User_photo_DoubleClick);
            // 
            // forPhoto
            // 
            this.forPhoto.AutoSize = true;
            this.forPhoto.Location = new System.Drawing.Point(66, 110);
            this.forPhoto.Name = "forPhoto";
            this.forPhoto.Size = new System.Drawing.Size(57, 21);
            this.forPhoto.TabIndex = 1;
            this.forPhoto.Text = "label2";
            this.forPhoto.Visible = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "user_logo.png");
            // 
            // fClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 874);
            this.Controls.Add(this.pMenuBottom);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvClients);
            this.Controls.Add(this.pMenuTop);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "fClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Security | Клиенты";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.pMenuTop.ResumeLayout(false);
            this.pMenuBottom.ResumeLayout(false);
            this.pMenuBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.User_photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Panel pMenuTop;
        private System.Windows.Forms.Button excelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Panel pMenuBottom;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox User_photo;
        private System.Windows.Forms.DateTimePicker dtpBithday;
        private System.Windows.Forms.TextBox tbNum;
        private System.Windows.Forms.Label lNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSeries;
        private System.Windows.Forms.Label lSeries;
        private System.Windows.Forms.ComboBox cbService;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFIO;
        private System.Windows.Forms.Label lFIO;
        private System.Windows.Forms.Label forPhoto;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label2;
    }
}