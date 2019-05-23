namespace Security
{
    partial class fWorkers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fWorkers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.pMenuBottom = new System.Windows.Forms.Panel();
            this.tbMoney = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpStartWork = new System.Windows.Forms.DateTimePicker();
            this.fourStars = new System.Windows.Forms.PictureBox();
            this.fiveStars = new System.Windows.Forms.PictureBox();
            this.twoStars = new System.Windows.Forms.PictureBox();
            this.threeStars = new System.Windows.Forms.PictureBox();
            this.oneStar = new System.Windows.Forms.PictureBox();
            this.lRank = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbGun = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCar = new System.Windows.Forms.TextBox();
            this.lNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFIO = new System.Windows.Forms.TextBox();
            this.lFIO = new System.Windows.Forms.Label();
            this.User_photo = new System.Windows.Forms.PictureBox();
            this.forPhoto = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvWorkers = new System.Windows.Forms.DataGridView();
            this.addBtn = new System.Windows.Forms.Button();
            this.pMenuTop = new System.Windows.Forms.Panel();
            this.excelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.pMenuBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fourStars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiveStars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoStars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.threeStars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oneStar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.User_photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkers)).BeginInit();
            this.pMenuTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "user_logo.png");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(330, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Дата начала работы в фирме";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(329, 337);
            this.tbPhone.MaxLength = 11;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(278, 27);
            this.tbPhone.TabIndex = 7;
            this.tbPhone.TextChanged += new System.EventHandler(this.tbFIO_TextChanged);
            this.tbPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPhone_KeyPress);
            // 
            // pMenuBottom
            // 
            this.pMenuBottom.Controls.Add(this.tbMoney);
            this.pMenuBottom.Controls.Add(this.label6);
            this.pMenuBottom.Controls.Add(this.dtpStartWork);
            this.pMenuBottom.Controls.Add(this.fourStars);
            this.pMenuBottom.Controls.Add(this.fiveStars);
            this.pMenuBottom.Controls.Add(this.twoStars);
            this.pMenuBottom.Controls.Add(this.threeStars);
            this.pMenuBottom.Controls.Add(this.oneStar);
            this.pMenuBottom.Controls.Add(this.lRank);
            this.pMenuBottom.Controls.Add(this.label5);
            this.pMenuBottom.Controls.Add(this.tbPhone);
            this.pMenuBottom.Controls.Add(this.label2);
            this.pMenuBottom.Controls.Add(this.tbGun);
            this.pMenuBottom.Controls.Add(this.label4);
            this.pMenuBottom.Controls.Add(this.tbCar);
            this.pMenuBottom.Controls.Add(this.lNumber);
            this.pMenuBottom.Controls.Add(this.label3);
            this.pMenuBottom.Controls.Add(this.tbFIO);
            this.pMenuBottom.Controls.Add(this.lFIO);
            this.pMenuBottom.Controls.Add(this.User_photo);
            this.pMenuBottom.Controls.Add(this.forPhoto);
            this.pMenuBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pMenuBottom.Location = new System.Drawing.Point(0, 404);
            this.pMenuBottom.Name = "pMenuBottom";
            this.pMenuBottom.Size = new System.Drawing.Size(675, 518);
            this.pMenuBottom.TabIndex = 22;
            // 
            // tbMoney
            // 
            this.tbMoney.Location = new System.Drawing.Point(329, 469);
            this.tbMoney.MaxLength = 6;
            this.tbMoney.Name = "tbMoney";
            this.tbMoney.Size = new System.Drawing.Size(278, 27);
            this.tbMoney.TabIndex = 59;
            this.tbMoney.TextChanged += new System.EventHandler(this.tbFIO_TextChanged);
            this.tbMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPhone_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(328, 445);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 21);
            this.label6.TabIndex = 58;
            this.label6.Text = "Зарплата (в рублях)";
            // 
            // dtpStartWork
            // 
            this.dtpStartWork.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartWork.Location = new System.Drawing.Point(328, 408);
            this.dtpStartWork.Name = "dtpStartWork";
            this.dtpStartWork.Size = new System.Drawing.Size(277, 27);
            this.dtpStartWork.TabIndex = 57;
            this.dtpStartWork.ValueChanged += new System.EventHandler(this.tbFIO_TextChanged);
            // 
            // fourStars
            // 
            this.fourStars.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fourStars.Image = ((System.Drawing.Image)(resources.GetObject("fourStars.Image")));
            this.fourStars.Location = new System.Drawing.Point(481, 122);
            this.fourStars.Name = "fourStars";
            this.fourStars.Size = new System.Drawing.Size(43, 40);
            this.fourStars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fourStars.TabIndex = 52;
            this.fourStars.TabStop = false;
            this.fourStars.Click += new System.EventHandler(this.oneStar_Click);
            this.fourStars.MouseEnter += new System.EventHandler(this.oneStar_MouseEnter);
            this.fourStars.MouseLeave += new System.EventHandler(this.oneStar_MouseLeave);
            // 
            // fiveStars
            // 
            this.fiveStars.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fiveStars.Image = ((System.Drawing.Image)(resources.GetObject("fiveStars.Image")));
            this.fiveStars.Location = new System.Drawing.Point(530, 122);
            this.fiveStars.Name = "fiveStars";
            this.fiveStars.Size = new System.Drawing.Size(43, 40);
            this.fiveStars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fiveStars.TabIndex = 53;
            this.fiveStars.TabStop = false;
            this.fiveStars.Click += new System.EventHandler(this.oneStar_Click);
            this.fiveStars.MouseEnter += new System.EventHandler(this.oneStar_MouseEnter);
            this.fiveStars.MouseLeave += new System.EventHandler(this.oneStar_MouseLeave);
            // 
            // twoStars
            // 
            this.twoStars.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.twoStars.Image = ((System.Drawing.Image)(resources.GetObject("twoStars.Image")));
            this.twoStars.Location = new System.Drawing.Point(383, 122);
            this.twoStars.Name = "twoStars";
            this.twoStars.Size = new System.Drawing.Size(43, 40);
            this.twoStars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.twoStars.TabIndex = 54;
            this.twoStars.TabStop = false;
            this.twoStars.Click += new System.EventHandler(this.oneStar_Click);
            this.twoStars.MouseEnter += new System.EventHandler(this.oneStar_MouseEnter);
            this.twoStars.MouseLeave += new System.EventHandler(this.oneStar_MouseLeave);
            // 
            // threeStars
            // 
            this.threeStars.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.threeStars.Image = ((System.Drawing.Image)(resources.GetObject("threeStars.Image")));
            this.threeStars.Location = new System.Drawing.Point(432, 122);
            this.threeStars.Name = "threeStars";
            this.threeStars.Size = new System.Drawing.Size(43, 40);
            this.threeStars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.threeStars.TabIndex = 55;
            this.threeStars.TabStop = false;
            this.threeStars.Click += new System.EventHandler(this.oneStar_Click);
            this.threeStars.MouseEnter += new System.EventHandler(this.oneStar_MouseEnter);
            this.threeStars.MouseLeave += new System.EventHandler(this.oneStar_MouseLeave);
            // 
            // oneStar
            // 
            this.oneStar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.oneStar.Image = ((System.Drawing.Image)(resources.GetObject("oneStar.Image")));
            this.oneStar.Location = new System.Drawing.Point(334, 122);
            this.oneStar.Name = "oneStar";
            this.oneStar.Size = new System.Drawing.Size(43, 40);
            this.oneStar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.oneStar.TabIndex = 56;
            this.oneStar.TabStop = false;
            this.oneStar.Click += new System.EventHandler(this.oneStar_Click);
            this.oneStar.MouseEnter += new System.EventHandler(this.oneStar_MouseEnter);
            this.oneStar.MouseLeave += new System.EventHandler(this.oneStar_MouseLeave);
            // 
            // lRank
            // 
            this.lRank.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lRank.AutoSize = true;
            this.lRank.Location = new System.Drawing.Point(593, 122);
            this.lRank.Name = "lRank";
            this.lRank.Size = new System.Drawing.Size(19, 21);
            this.lRank.TabIndex = 51;
            this.lRank.Text = "0";
            this.lRank.Visible = false;
            this.lRank.TextChanged += new System.EventHandler(this.tbFIO_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Номер телефона";
            // 
            // tbGun
            // 
            this.tbGun.Location = new System.Drawing.Point(329, 270);
            this.tbGun.MaxLength = 12;
            this.tbGun.Name = "tbGun";
            this.tbGun.Size = new System.Drawing.Size(277, 27);
            this.tbGun.TabIndex = 3;
            this.tbGun.TextChanged += new System.EventHandler(this.tbFIO_TextChanged);
            this.tbGun.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCar_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Номер табельного оружия";
            // 
            // tbCar
            // 
            this.tbCar.Location = new System.Drawing.Point(328, 202);
            this.tbCar.MaxLength = 12;
            this.tbCar.Name = "tbCar";
            this.tbCar.Size = new System.Drawing.Size(277, 27);
            this.tbCar.TabIndex = 3;
            this.tbCar.TextChanged += new System.EventHandler(this.tbFIO_TextChanged);
            this.tbCar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCar_KeyPress);
            // 
            // lNumber
            // 
            this.lNumber.AutoSize = true;
            this.lNumber.Location = new System.Drawing.Point(330, 178);
            this.lNumber.Name = "lNumber";
            this.lNumber.Size = new System.Drawing.Size(141, 21);
            this.lNumber.TabIndex = 2;
            this.lNumber.Text = "Номер машины";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ранг";
            // 
            // tbFIO
            // 
            this.tbFIO.Location = new System.Drawing.Point(329, 47);
            this.tbFIO.Name = "tbFIO";
            this.tbFIO.Size = new System.Drawing.Size(278, 27);
            this.tbFIO.TabIndex = 3;
            this.tbFIO.TextChanged += new System.EventHandler(this.tbFIO_TextChanged);
            this.tbFIO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFIO_KeyPress);
            // 
            // lFIO
            // 
            this.lFIO.AutoSize = true;
            this.lFIO.Location = new System.Drawing.Point(330, 23);
            this.lFIO.Name = "lFIO";
            this.lFIO.Size = new System.Drawing.Size(50, 21);
            this.lFIO.TabIndex = 2;
            this.lFIO.Text = "ФИО";
            // 
            // User_photo
            // 
            this.User_photo.Location = new System.Drawing.Point(33, 23);
            this.User_photo.Name = "User_photo";
            this.User_photo.Size = new System.Drawing.Size(258, 226);
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
            // dgvWorkers
            // 
            this.dgvWorkers.AllowUserToAddRows = false;
            this.dgvWorkers.AllowUserToDeleteRows = false;
            this.dgvWorkers.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWorkers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkers.Location = new System.Drawing.Point(11, 132);
            this.dgvWorkers.Name = "dgvWorkers";
            this.dgvWorkers.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWorkers.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvWorkers.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvWorkers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWorkers.Size = new System.Drawing.Size(652, 242);
            this.dgvWorkers.TabIndex = 18;
            this.dgvWorkers.SelectionChanged += new System.EventHandler(this.dgvWorkers_SelectionChanged);
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
            this.saveBtn.Location = new System.Drawing.Point(353, -1);
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
            this.delBtn.Size = new System.Drawing.Size(227, 65);
            this.delBtn.TabIndex = 5;
            this.delBtn.Text = "Удалить/Отменить";
            this.delBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // fWorkers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 922);
            this.Controls.Add(this.pMenuBottom);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvWorkers);
            this.Controls.Add(this.pMenuTop);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "fWorkers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Security | Сотрудники";
            this.pMenuBottom.ResumeLayout(false);
            this.pMenuBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fourStars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiveStars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoStars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.threeStars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oneStar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.User_photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkers)).EndInit();
            this.pMenuTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Panel pMenuBottom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCar;
        private System.Windows.Forms.Label lNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFIO;
        private System.Windows.Forms.Label lFIO;
        private System.Windows.Forms.PictureBox User_photo;
        private System.Windows.Forms.Label forPhoto;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvWorkers;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Panel pMenuTop;
        private System.Windows.Forms.Button excelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.PictureBox fourStars;
        private System.Windows.Forms.PictureBox fiveStars;
        private System.Windows.Forms.PictureBox twoStars;
        private System.Windows.Forms.PictureBox threeStars;
        private System.Windows.Forms.PictureBox oneStar;
        private System.Windows.Forms.Label lRank;
        private System.Windows.Forms.TextBox tbGun;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMoney;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpStartWork;
    }
}