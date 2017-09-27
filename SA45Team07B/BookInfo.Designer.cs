namespace SA45Team07B
{
    partial class BookInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mtbISBN = new System.Windows.Forms.MaskedTextBox();
            this.mtbYear = new System.Windows.Forms.MaskedTextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblEd = new System.Windows.Forms.Label();
            this.txtbEd = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtbPrice = new System.Windows.Forms.TextBox();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblSubjectName = new System.Windows.Forms.Label();
            this.lblCallNum = new System.Windows.Forms.Label();
            this.txtbCallNum = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtbAuthor = new System.Windows.Forms.TextBox();
            this.lblBkTitle = new System.Windows.Forms.Label();
            this.txtbBkTitle = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblBkId = new System.Windows.Forms.Label();
            this.txtbBkId = new System.Windows.Forms.TextBox();
            this.btnFindBk = new System.Windows.Forms.Button();
            this.txtbPublisher = new System.Windows.Forms.TextBox();
            this.txtbSubjectName = new System.Windows.Forms.TextBox();
            this.dgvAvail = new System.Windows.Forms.DataGridView();
            this.RFID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Availability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateBorrowed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BorrowedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbxBasicInfo = new System.Windows.Forms.GroupBox();
            this.gbxAvail = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvail)).BeginInit();
            this.gbxBasicInfo.SuspendLayout();
            this.gbxAvail.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtbISBN
            // 
            this.mtbISBN.Location = new System.Drawing.Point(650, 45);
            this.mtbISBN.Mask = "0000000000000";
            this.mtbISBN.Name = "mtbISBN";
            this.mtbISBN.ReadOnly = true;
            this.mtbISBN.RejectInputOnFirstFailure = true;
            this.mtbISBN.Size = new System.Drawing.Size(304, 29);
            this.mtbISBN.TabIndex = 22;
            // 
            // mtbYear
            // 
            this.mtbYear.Location = new System.Drawing.Point(650, 278);
            this.mtbYear.Mask = "0000";
            this.mtbYear.Name = "mtbYear";
            this.mtbYear.ReadOnly = true;
            this.mtbYear.Size = new System.Drawing.Size(100, 29);
            this.mtbYear.TabIndex = 30;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.BackColor = System.Drawing.Color.Transparent;
            this.lblYear.Location = new System.Drawing.Point(522, 281);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(115, 21);
            this.lblYear.TabIndex = 81;
            this.lblYear.Text = "Published Year:";
            // 
            // lblEd
            // 
            this.lblEd.AutoSize = true;
            this.lblEd.BackColor = System.Drawing.Color.Transparent;
            this.lblEd.Location = new System.Drawing.Point(522, 233);
            this.lblEd.Name = "lblEd";
            this.lblEd.Size = new System.Drawing.Size(61, 21);
            this.lblEd.TabIndex = 72;
            this.lblEd.Text = "Edition:";
            // 
            // txtbEd
            // 
            this.txtbEd.Location = new System.Drawing.Point(650, 230);
            this.txtbEd.Name = "txtbEd";
            this.txtbEd.ReadOnly = true;
            this.txtbEd.Size = new System.Drawing.Size(304, 29);
            this.txtbEd.TabIndex = 28;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Location = new System.Drawing.Point(36, 281);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(47, 21);
            this.lblPrice.TabIndex = 70;
            this.lblPrice.Text = "Price:";
            // 
            // txtbPrice
            // 
            this.txtbPrice.Location = new System.Drawing.Point(163, 278);
            this.txtbPrice.Name = "txtbPrice";
            this.txtbPrice.ReadOnly = true;
            this.txtbPrice.Size = new System.Drawing.Size(82, 29);
            this.txtbPrice.TabIndex = 29;
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.BackColor = System.Drawing.Color.Transparent;
            this.lblPublisher.Location = new System.Drawing.Point(36, 188);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(78, 21);
            this.lblPublisher.TabIndex = 68;
            this.lblPublisher.Text = "Publisher:";
            // 
            // lblSubjectName
            // 
            this.lblSubjectName.AutoSize = true;
            this.lblSubjectName.BackColor = System.Drawing.Color.Transparent;
            this.lblSubjectName.Location = new System.Drawing.Point(522, 188);
            this.lblSubjectName.Name = "lblSubjectName";
            this.lblSubjectName.Size = new System.Drawing.Size(110, 21);
            this.lblSubjectName.TabIndex = 67;
            this.lblSubjectName.Text = "Subject Name:";
            // 
            // lblCallNum
            // 
            this.lblCallNum.AutoSize = true;
            this.lblCallNum.BackColor = System.Drawing.Color.Transparent;
            this.lblCallNum.Location = new System.Drawing.Point(36, 233);
            this.lblCallNum.Name = "lblCallNum";
            this.lblCallNum.Size = new System.Drawing.Size(101, 21);
            this.lblCallNum.TabIndex = 66;
            this.lblCallNum.Text = "Call Number:";
            // 
            // txtbCallNum
            // 
            this.txtbCallNum.Location = new System.Drawing.Point(163, 230);
            this.txtbCallNum.Name = "txtbCallNum";
            this.txtbCallNum.ReadOnly = true;
            this.txtbCallNum.Size = new System.Drawing.Size(302, 29);
            this.txtbCallNum.TabIndex = 27;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.BackColor = System.Drawing.Color.Transparent;
            this.lblAuthor.Location = new System.Drawing.Point(36, 142);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(61, 21);
            this.lblAuthor.TabIndex = 64;
            this.lblAuthor.Text = "Author:";
            // 
            // txtbAuthor
            // 
            this.txtbAuthor.Location = new System.Drawing.Point(163, 139);
            this.txtbAuthor.Name = "txtbAuthor";
            this.txtbAuthor.ReadOnly = true;
            this.txtbAuthor.Size = new System.Drawing.Size(853, 29);
            this.txtbAuthor.TabIndex = 24;
            // 
            // lblBkTitle
            // 
            this.lblBkTitle.AutoSize = true;
            this.lblBkTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblBkTitle.Location = new System.Drawing.Point(36, 95);
            this.lblBkTitle.Name = "lblBkTitle";
            this.lblBkTitle.Size = new System.Drawing.Size(81, 21);
            this.lblBkTitle.TabIndex = 62;
            this.lblBkTitle.Text = "Book Title:";
            // 
            // txtbBkTitle
            // 
            this.txtbBkTitle.Location = new System.Drawing.Point(163, 92);
            this.txtbBkTitle.Name = "txtbBkTitle";
            this.txtbBkTitle.ReadOnly = true;
            this.txtbBkTitle.Size = new System.Drawing.Size(853, 29);
            this.txtbBkTitle.TabIndex = 23;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.BackColor = System.Drawing.Color.Transparent;
            this.lblISBN.Location = new System.Drawing.Point(519, 48);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(47, 21);
            this.lblISBN.TabIndex = 60;
            this.lblISBN.Text = "ISBN:";
            // 
            // lblBkId
            // 
            this.lblBkId.AutoSize = true;
            this.lblBkId.BackColor = System.Drawing.Color.Transparent;
            this.lblBkId.Location = new System.Drawing.Point(36, 48);
            this.lblBkId.Name = "lblBkId";
            this.lblBkId.Size = new System.Drawing.Size(63, 21);
            this.lblBkId.TabIndex = 59;
            this.lblBkId.Text = "BookID:";
            // 
            // txtbBkId
            // 
            this.txtbBkId.Location = new System.Drawing.Point(163, 43);
            this.txtbBkId.Name = "txtbBkId";
            this.txtbBkId.ReadOnly = true;
            this.txtbBkId.Size = new System.Drawing.Size(188, 29);
            this.txtbBkId.TabIndex = 20;
            // 
            // btnFindBk
            // 
            this.btnFindBk.BackColor = System.Drawing.Color.White;
            this.btnFindBk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFindBk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFindBk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFindBk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindBk.Location = new System.Drawing.Point(372, 43);
            this.btnFindBk.Name = "btnFindBk";
            this.btnFindBk.Size = new System.Drawing.Size(31, 27);
            this.btnFindBk.TabIndex = 21;
            this.btnFindBk.Text = "...";
            this.btnFindBk.UseVisualStyleBackColor = false;
            this.btnFindBk.Click += new System.EventHandler(this.btnFindBk_Click);
            // 
            // txtbPublisher
            // 
            this.txtbPublisher.Location = new System.Drawing.Point(163, 185);
            this.txtbPublisher.Name = "txtbPublisher";
            this.txtbPublisher.ReadOnly = true;
            this.txtbPublisher.Size = new System.Drawing.Size(302, 29);
            this.txtbPublisher.TabIndex = 25;
            // 
            // txtbSubjectName
            // 
            this.txtbSubjectName.Location = new System.Drawing.Point(650, 185);
            this.txtbSubjectName.Name = "txtbSubjectName";
            this.txtbSubjectName.ReadOnly = true;
            this.txtbSubjectName.Size = new System.Drawing.Size(304, 29);
            this.txtbSubjectName.TabIndex = 26;
            // 
            // dgvAvail
            // 
            this.dgvAvail.AllowUserToAddRows = false;
            this.dgvAvail.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvAvail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAvail.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAvail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAvail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RFID,
            this.Availability,
            this.DateBorrowed,
            this.DueDate,
            this.BorrowedBy});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAvail.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvAvail.GridColor = System.Drawing.Color.White;
            this.dgvAvail.Location = new System.Drawing.Point(166, 23);
            this.dgvAvail.Name = "dgvAvail";
            this.dgvAvail.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAvail.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvAvail.RowHeadersWidth = 4;
            this.dgvAvail.RowTemplate.Height = 23;
            this.dgvAvail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAvail.Size = new System.Drawing.Size(727, 170);
            this.dgvAvail.TabIndex = 31;
            // 
            // RFID
            // 
            this.RFID.DataPropertyName = "RFID";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.RFID.DefaultCellStyle = dataGridViewCellStyle3;
            this.RFID.HeaderText = "RFID";
            this.RFID.Name = "RFID";
            this.RFID.ReadOnly = true;
            this.RFID.Width = 120;
            // 
            // Availability
            // 
            this.Availability.DataPropertyName = "Availability";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Availability.DefaultCellStyle = dataGridViewCellStyle4;
            this.Availability.HeaderText = "Availability";
            this.Availability.Name = "Availability";
            this.Availability.ReadOnly = true;
            this.Availability.Width = 120;
            // 
            // DateBorrowed
            // 
            this.DateBorrowed.DataPropertyName = "DateBorrowed";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DateBorrowed.DefaultCellStyle = dataGridViewCellStyle5;
            this.DateBorrowed.HeaderText = "Date Borrowed";
            this.DateBorrowed.Name = "DateBorrowed";
            this.DateBorrowed.ReadOnly = true;
            this.DateBorrowed.Width = 150;
            // 
            // DueDate
            // 
            this.DueDate.DataPropertyName = "DueDate";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DueDate.DefaultCellStyle = dataGridViewCellStyle6;
            this.DueDate.HeaderText = "Due Date";
            this.DueDate.Name = "DueDate";
            this.DueDate.ReadOnly = true;
            this.DueDate.Width = 150;
            // 
            // BorrowedBy
            // 
            this.BorrowedBy.DataPropertyName = "BorrowedBy";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BorrowedBy.DefaultCellStyle = dataGridViewCellStyle7;
            this.BorrowedBy.HeaderText = "Last Borrowed Member ID";
            this.BorrowedBy.Name = "BorrowedBy";
            this.BorrowedBy.ReadOnly = true;
            this.BorrowedBy.Width = 180;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(508, 657);
            this.btnClose.Margin = new System.Windows.Forms.Padding(7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(97, 38);
            this.btnClose.TabIndex = 32;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gbxBasicInfo
            // 
            this.gbxBasicInfo.BackColor = System.Drawing.Color.Transparent;
            this.gbxBasicInfo.Controls.Add(this.mtbISBN);
            this.gbxBasicInfo.Controls.Add(this.txtbSubjectName);
            this.gbxBasicInfo.Controls.Add(this.mtbYear);
            this.gbxBasicInfo.Controls.Add(this.lblISBN);
            this.gbxBasicInfo.Controls.Add(this.txtbEd);
            this.gbxBasicInfo.Controls.Add(this.txtbPublisher);
            this.gbxBasicInfo.Controls.Add(this.txtbBkId);
            this.gbxBasicInfo.Controls.Add(this.lblYear);
            this.gbxBasicInfo.Controls.Add(this.btnFindBk);
            this.gbxBasicInfo.Controls.Add(this.lblEd);
            this.gbxBasicInfo.Controls.Add(this.lblSubjectName);
            this.gbxBasicInfo.Controls.Add(this.lblPrice);
            this.gbxBasicInfo.Controls.Add(this.lblBkId);
            this.gbxBasicInfo.Controls.Add(this.txtbPrice);
            this.gbxBasicInfo.Controls.Add(this.lblBkTitle);
            this.gbxBasicInfo.Controls.Add(this.lblAuthor);
            this.gbxBasicInfo.Controls.Add(this.txtbCallNum);
            this.gbxBasicInfo.Controls.Add(this.lblCallNum);
            this.gbxBasicInfo.Controls.Add(this.lblPublisher);
            this.gbxBasicInfo.Controls.Add(this.txtbBkTitle);
            this.gbxBasicInfo.Controls.Add(this.txtbAuthor);
            this.gbxBasicInfo.Location = new System.Drawing.Point(22, 81);
            this.gbxBasicInfo.Name = "gbxBasicInfo";
            this.gbxBasicInfo.Size = new System.Drawing.Size(1045, 343);
            this.gbxBasicInfo.TabIndex = 100;
            this.gbxBasicInfo.TabStop = false;
            this.gbxBasicInfo.Text = "Book Details";
            // 
            // gbxAvail
            // 
            this.gbxAvail.BackColor = System.Drawing.Color.Transparent;
            this.gbxAvail.Controls.Add(this.dgvAvail);
            this.gbxAvail.Location = new System.Drawing.Point(23, 430);
            this.gbxAvail.Name = "gbxAvail";
            this.gbxAvail.Size = new System.Drawing.Size(1044, 211);
            this.gbxAvail.TabIndex = 97;
            this.gbxAvail.TabStop = false;
            this.gbxAvail.Text = "Availability";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 709);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1154, 22);
            this.statusStrip1.TabIndex = 101;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(153, 17);
            this.toolStripStatusLabel1.Text = "Please select a book to view";
            // 
            // BookInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.ClientSize = new System.Drawing.Size(1154, 731);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbxBasicInfo);
            this.Controls.Add(this.gbxAvail);
            this.Name = "BookInfo";
            this.Text = "View Book Details";
            this.Controls.SetChildIndex(this.gbxAvail, 0);
            this.Controls.SetChildIndex(this.gbxBasicInfo, 0);
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.statusStrip1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvail)).EndInit();
            this.gbxBasicInfo.ResumeLayout(false);
            this.gbxBasicInfo.PerformLayout();
            this.gbxAvail.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox mtbISBN;
        private System.Windows.Forms.MaskedTextBox mtbYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblEd;
        private System.Windows.Forms.TextBox txtbEd;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtbPrice;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblSubjectName;
        private System.Windows.Forms.Label lblCallNum;
        private System.Windows.Forms.TextBox txtbCallNum;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtbAuthor;
        private System.Windows.Forms.Label lblBkTitle;
        private System.Windows.Forms.TextBox txtbBkTitle;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblBkId;
        private System.Windows.Forms.TextBox txtbBkId;
        private System.Windows.Forms.Button btnFindBk;
        private System.Windows.Forms.TextBox txtbPublisher;
        private System.Windows.Forms.TextBox txtbSubjectName;
        private System.Windows.Forms.DataGridView dgvAvail;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gbxBasicInfo;
        private System.Windows.Forms.GroupBox gbxAvail;
        private System.Windows.Forms.DataGridViewTextBoxColumn RFID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Availability;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateBorrowed;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BorrowedBy;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}
