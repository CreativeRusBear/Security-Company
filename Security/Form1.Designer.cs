namespace Security
{
    partial class fMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.clientsBtn = new System.Windows.Forms.Button();
            this.contrantsBtn = new System.Windows.Forms.Button();
            this.pMenu = new System.Windows.Forms.Panel();
            this.workerBtn = new System.Windows.Forms.Button();
            this.serviceBtn = new System.Windows.Forms.Button();
            this.brigadeBtn = new System.Windows.Forms.Button();
            this.pMenuBottom = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lRole = new System.Windows.Forms.Label();
            this.lLog = new System.Windows.Forms.Label();
            this.pMenu.SuspendLayout();
            this.pMenuBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // clientsBtn
            // 
            this.clientsBtn.FlatAppearance.BorderSize = 0;
            this.clientsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientsBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientsBtn.ForeColor = System.Drawing.Color.White;
            this.clientsBtn.Image = ((System.Drawing.Image)(resources.GetObject("clientsBtn.Image")));
            this.clientsBtn.Location = new System.Drawing.Point(233, 0);
            this.clientsBtn.Name = "clientsBtn";
            this.clientsBtn.Size = new System.Drawing.Size(225, 62);
            this.clientsBtn.TabIndex = 5;
            this.clientsBtn.Text = "    Клиенты";
            this.clientsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.clientsBtn.UseVisualStyleBackColor = true;
            this.clientsBtn.Click += new System.EventHandler(this.clientsBtn_Click);
            // 
            // contrantsBtn
            // 
            this.contrantsBtn.FlatAppearance.BorderSize = 0;
            this.contrantsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contrantsBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contrantsBtn.ForeColor = System.Drawing.Color.White;
            this.contrantsBtn.Image = ((System.Drawing.Image)(resources.GetObject("contrantsBtn.Image")));
            this.contrantsBtn.Location = new System.Drawing.Point(0, -1);
            this.contrantsBtn.Name = "contrantsBtn";
            this.contrantsBtn.Size = new System.Drawing.Size(231, 62);
            this.contrantsBtn.TabIndex = 4;
            this.contrantsBtn.Text = "   Договор";
            this.contrantsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.contrantsBtn.UseVisualStyleBackColor = true;
            this.contrantsBtn.Click += new System.EventHandler(this.contrantsBtn_Click);
            // 
            // pMenu
            // 
            this.pMenu.Controls.Add(this.workerBtn);
            this.pMenu.Controls.Add(this.serviceBtn);
            this.pMenu.Controls.Add(this.clientsBtn);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pMenu.Location = new System.Drawing.Point(0, 0);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(689, 64);
            this.pMenu.TabIndex = 6;
            // 
            // workerBtn
            // 
            this.workerBtn.FlatAppearance.BorderSize = 0;
            this.workerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.workerBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workerBtn.ForeColor = System.Drawing.Color.White;
            this.workerBtn.Image = ((System.Drawing.Image)(resources.GetObject("workerBtn.Image")));
            this.workerBtn.Location = new System.Drawing.Point(0, 0);
            this.workerBtn.Name = "workerBtn";
            this.workerBtn.Size = new System.Drawing.Size(227, 62);
            this.workerBtn.TabIndex = 7;
            this.workerBtn.Text = "    Сотрудники";
            this.workerBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.workerBtn.UseVisualStyleBackColor = true;
            this.workerBtn.Click += new System.EventHandler(this.workerBtn_Click);
            // 
            // serviceBtn
            // 
            this.serviceBtn.FlatAppearance.BorderSize = 0;
            this.serviceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serviceBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serviceBtn.ForeColor = System.Drawing.Color.White;
            this.serviceBtn.Image = ((System.Drawing.Image)(resources.GetObject("serviceBtn.Image")));
            this.serviceBtn.Location = new System.Drawing.Point(455, 0);
            this.serviceBtn.Name = "serviceBtn";
            this.serviceBtn.Size = new System.Drawing.Size(239, 62);
            this.serviceBtn.TabIndex = 6;
            this.serviceBtn.Text = "   Услуги";
            this.serviceBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.serviceBtn.UseVisualStyleBackColor = true;
            this.serviceBtn.Click += new System.EventHandler(this.serviceBtn_Click);
            // 
            // brigadeBtn
            // 
            this.brigadeBtn.FlatAppearance.BorderSize = 0;
            this.brigadeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brigadeBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brigadeBtn.ForeColor = System.Drawing.Color.White;
            this.brigadeBtn.Image = ((System.Drawing.Image)(resources.GetObject("brigadeBtn.Image")));
            this.brigadeBtn.Location = new System.Drawing.Point(462, 0);
            this.brigadeBtn.Name = "brigadeBtn";
            this.brigadeBtn.Size = new System.Drawing.Size(227, 62);
            this.brigadeBtn.TabIndex = 8;
            this.brigadeBtn.Text = "    Бригада";
            this.brigadeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.brigadeBtn.UseVisualStyleBackColor = true;
            this.brigadeBtn.Click += new System.EventHandler(this.brigadeBtn_Click);
            // 
            // pMenuBottom
            // 
            this.pMenuBottom.Controls.Add(this.contrantsBtn);
            this.pMenuBottom.Controls.Add(this.brigadeBtn);
            this.pMenuBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pMenuBottom.Location = new System.Drawing.Point(0, 446);
            this.pMenuBottom.Name = "pMenuBottom";
            this.pMenuBottom.Size = new System.Drawing.Size(689, 64);
            this.pMenuBottom.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(224, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 227);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lRole
            // 
            this.lRole.AutoSize = true;
            this.lRole.Location = new System.Drawing.Point(289, 393);
            this.lRole.Name = "lRole";
            this.lRole.Size = new System.Drawing.Size(100, 21);
            this.lRole.TabIndex = 11;
            this.lRole.Text = "Должность:";
            // 
            // lLog
            // 
            this.lLog.AutoSize = true;
            this.lLog.Location = new System.Drawing.Point(303, 355);
            this.lLog.Name = "lLog";
            this.lLog.Size = new System.Drawing.Size(61, 21);
            this.lLog.TabIndex = 12;
            this.lLog.Text = "Логин:";
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(689, 510);
            this.Controls.Add(this.lLog);
            this.Controls.Add(this.lRole);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pMenuBottom);
            this.Controls.Add(this.pMenu);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Security | Главное меню";
            this.pMenu.ResumeLayout(false);
            this.pMenuBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button clientsBtn;
        private System.Windows.Forms.Button contrantsBtn;
        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Button serviceBtn;
        private System.Windows.Forms.Button brigadeBtn;
        private System.Windows.Forms.Button workerBtn;
        private System.Windows.Forms.Panel pMenuBottom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lRole;
        private System.Windows.Forms.Label lLog;
    }
}

