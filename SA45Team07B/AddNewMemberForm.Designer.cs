namespace SA45Team07B
{
    partial class AddNewMemberForm
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
            this.textBoxMemberID = new System.Windows.Forms.TextBox();
            this.labelMemberID = new System.Windows.Forms.Label();
            this.labelMemberName = new System.Windows.Forms.Label();
            this.textBoxMemberName = new System.Windows.Forms.TextBox();
            this.labelMemberType = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelContactNumber = new System.Windows.Forms.Label();
            this.labelSchoolID = new System.Windows.Forms.Label();
            this.labelFacultyCode = new System.Windows.Forms.Label();
            this.textBoxContactNumber = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.errorProviderMemberName = new System.Windows.Forms.ErrorProvider(this.components);
            this.comboBoxMemberType = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxSchoolID = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxFacultyName = new System.Windows.Forms.ComboBox();
            this.errorProviderEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderSchoolID = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderContactNumber = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelStar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProviderMemberType = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderFacultyName = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMemberName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSchoolID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderContactNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMemberType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFacultyName)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            // textBoxMemberID
            // 
            this.textBoxMemberID.Location = new System.Drawing.Point(190, 29);
            this.textBoxMemberID.Margin = new System.Windows.Forms.Padding(8);
            this.textBoxMemberID.Name = "textBoxMemberID";
            this.textBoxMemberID.ReadOnly = true;
            this.textBoxMemberID.Size = new System.Drawing.Size(362, 29);
            this.textBoxMemberID.TabIndex = 10;
            this.textBoxMemberID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxes_KeyDown);
            // 
            // labelMemberID
            // 
            this.labelMemberID.AutoSize = true;
            this.labelMemberID.BackColor = System.Drawing.Color.Transparent;
            this.labelMemberID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelMemberID.Location = new System.Drawing.Point(27, 32);
            this.labelMemberID.Margin = new System.Windows.Forms.Padding(8);
            this.labelMemberID.Name = "labelMemberID";
            this.labelMemberID.Size = new System.Drawing.Size(91, 21);
            this.labelMemberID.TabIndex = 11;
            this.labelMemberID.Text = "Member ID:";
            // 
            // labelMemberName
            // 
            this.labelMemberName.AutoSize = true;
            this.labelMemberName.BackColor = System.Drawing.Color.Transparent;
            this.labelMemberName.Location = new System.Drawing.Point(27, 122);
            this.labelMemberName.Margin = new System.Windows.Forms.Padding(8);
            this.labelMemberName.Name = "labelMemberName";
            this.labelMemberName.Size = new System.Drawing.Size(118, 21);
            this.labelMemberName.TabIndex = 14;
            this.labelMemberName.Text = "Member Name:";
            // 
            // textBoxMemberName
            // 
            this.textBoxMemberName.Location = new System.Drawing.Point(190, 119);
            this.textBoxMemberName.Margin = new System.Windows.Forms.Padding(8);
            this.textBoxMemberName.Name = "textBoxMemberName";
            this.textBoxMemberName.Size = new System.Drawing.Size(362, 29);
            this.textBoxMemberName.TabIndex = 12;
            this.textBoxMemberName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxes_KeyDown);
            this.textBoxMemberName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxes_KeyPress);
            this.textBoxMemberName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxMemberName_Validating);
            this.textBoxMemberName.Validated += new System.EventHandler(this.textBoxes_Validated);
            // 
            // labelMemberType
            // 
            this.labelMemberType.AutoSize = true;
            this.labelMemberType.BackColor = System.Drawing.Color.Transparent;
            this.labelMemberType.Location = new System.Drawing.Point(27, 167);
            this.labelMemberType.Margin = new System.Windows.Forms.Padding(8);
            this.labelMemberType.Name = "labelMemberType";
            this.labelMemberType.Size = new System.Drawing.Size(108, 21);
            this.labelMemberType.TabIndex = 17;
            this.labelMemberType.Text = "Member Type:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Location = new System.Drawing.Point(27, 302);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(8);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(51, 21);
            this.labelEmail.TabIndex = 19;
            this.labelEmail.Text = "Email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(368, 200);
            this.label8.Margin = new System.Windows.Forms.Padding(8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 21);
            this.label8.TabIndex = 22;
            // 
            // labelContactNumber
            // 
            this.labelContactNumber.AutoSize = true;
            this.labelContactNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelContactNumber.Location = new System.Drawing.Point(27, 257);
            this.labelContactNumber.Margin = new System.Windows.Forms.Padding(8);
            this.labelContactNumber.Name = "labelContactNumber";
            this.labelContactNumber.Size = new System.Drawing.Size(128, 21);
            this.labelContactNumber.TabIndex = 23;
            this.labelContactNumber.Text = "Contact Number:";
            // 
            // labelSchoolID
            // 
            this.labelSchoolID.AutoSize = true;
            this.labelSchoolID.BackColor = System.Drawing.Color.Transparent;
            this.labelSchoolID.Location = new System.Drawing.Point(28, 80);
            this.labelSchoolID.Margin = new System.Windows.Forms.Padding(8);
            this.labelSchoolID.Name = "labelSchoolID";
            this.labelSchoolID.Size = new System.Drawing.Size(79, 21);
            this.labelSchoolID.TabIndex = 24;
            this.labelSchoolID.Text = "School ID:";
            // 
            // labelFacultyCode
            // 
            this.labelFacultyCode.AutoSize = true;
            this.labelFacultyCode.BackColor = System.Drawing.Color.Transparent;
            this.labelFacultyCode.Location = new System.Drawing.Point(28, 212);
            this.labelFacultyCode.Margin = new System.Windows.Forms.Padding(8);
            this.labelFacultyCode.Name = "labelFacultyCode";
            this.labelFacultyCode.Size = new System.Drawing.Size(107, 21);
            this.labelFacultyCode.TabIndex = 25;
            this.labelFacultyCode.Text = "Faculty Name:";
            // 
            // textBoxContactNumber
            // 
            this.textBoxContactNumber.Location = new System.Drawing.Point(190, 254);
            this.textBoxContactNumber.Margin = new System.Windows.Forms.Padding(8);
            this.textBoxContactNumber.Name = "textBoxContactNumber";
            this.textBoxContactNumber.Size = new System.Drawing.Size(362, 29);
            this.textBoxContactNumber.TabIndex = 15;
            this.textBoxContactNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxes_KeyDown);
            this.textBoxContactNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxes_KeyPress);
            this.textBoxContactNumber.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxContactNumber_Validating);
            this.textBoxContactNumber.Validated += new System.EventHandler(this.textBoxes_Validated);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(190, 299);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(8);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(362, 29);
            this.textBoxEmail.TabIndex = 16;
            this.textBoxEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxes_KeyDown);
            this.textBoxEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxes_KeyPress);
            this.textBoxEmail.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmail_Validating);
            this.textBoxEmail.Validated += new System.EventHandler(this.textBoxes_Validated);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.White;
            this.buttonAdd.Enabled = false;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Location = new System.Drawing.Point(332, 357);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(8);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(102, 56);
            this.buttonAdd.TabIndex = 18;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.White;
            this.buttonCancel.CausesValidation = false;
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.buttonCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Location = new System.Drawing.Point(450, 357);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(8);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(102, 56);
            this.buttonCancel.TabIndex = 19;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // errorProviderMemberName
            // 
            this.errorProviderMemberName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderMemberName.ContainerControl = this;
            // 
            // comboBoxMemberType
            // 
            this.comboBoxMemberType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMemberType.FormattingEnabled = true;
            this.comboBoxMemberType.Items.AddRange(new object[] {
            "Undergraduate Student",
            "Graduate Student",
            "Academic Staff",
            "Admin Staff"});
            this.comboBoxMemberType.Location = new System.Drawing.Point(190, 164);
            this.comboBoxMemberType.Margin = new System.Windows.Forms.Padding(8);
            this.comboBoxMemberType.Name = "comboBoxMemberType";
            this.comboBoxMemberType.Size = new System.Drawing.Size(362, 29);
            this.comboBoxMemberType.TabIndex = 13;
            this.comboBoxMemberType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxes_KeyDown);
            this.comboBoxMemberType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxes_KeyPress);
            this.comboBoxMemberType.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxMemberType_Validating);
            // 
            // maskedTextBoxSchoolID
            // 
            this.maskedTextBoxSchoolID.Location = new System.Drawing.Point(190, 74);
            this.maskedTextBoxSchoolID.Margin = new System.Windows.Forms.Padding(8);
            this.maskedTextBoxSchoolID.Mask = "000000000";
            this.maskedTextBoxSchoolID.Name = "maskedTextBoxSchoolID";
            this.maskedTextBoxSchoolID.Size = new System.Drawing.Size(362, 29);
            this.maskedTextBoxSchoolID.TabIndex = 11;
            this.maskedTextBoxSchoolID.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.maskedTextBoxSchoolID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxes_KeyDown);
            this.maskedTextBoxSchoolID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxes_KeyPress);
            this.maskedTextBoxSchoolID.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTextBoxSchoolID_Validating);
            this.maskedTextBoxSchoolID.Validated += new System.EventHandler(this.textBoxes_Validated);
            // 
            // comboBoxFacultyName
            // 
            this.comboBoxFacultyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFacultyName.FormattingEnabled = true;
            this.comboBoxFacultyName.Items.AddRange(new object[] {
            "Arts and Social Sciences",
            "Business and Accountancy",
            "Computing",
            "Engineering",
            "Law",
            "Medicine",
            "Science",
            "Systems Science"});
            this.comboBoxFacultyName.Location = new System.Drawing.Point(190, 209);
            this.comboBoxFacultyName.Margin = new System.Windows.Forms.Padding(8);
            this.comboBoxFacultyName.Name = "comboBoxFacultyName";
            this.comboBoxFacultyName.Size = new System.Drawing.Size(362, 29);
            this.comboBoxFacultyName.TabIndex = 14;
            this.comboBoxFacultyName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxes_KeyDown);
            this.comboBoxFacultyName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxes_KeyPress);
            this.comboBoxFacultyName.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxFacultyName_Validating);
            // 
            // errorProviderEmail
            // 
            this.errorProviderEmail.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderEmail.ContainerControl = this;
            // 
            // errorProviderSchoolID
            // 
            this.errorProviderSchoolID.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderSchoolID.ContainerControl = this;
            // 
            // errorProviderContactNumber
            // 
            this.errorProviderContactNumber.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderContactNumber.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(111, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(150, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "*";
            // 
            // labelStar
            // 
            this.labelStar.AutoSize = true;
            this.labelStar.BackColor = System.Drawing.Color.Transparent;
            this.labelStar.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStar.ForeColor = System.Drawing.Color.Red;
            this.labelStar.Location = new System.Drawing.Point(140, 167);
            this.labelStar.Margin = new System.Windows.Forms.Padding(8);
            this.labelStar.Name = "labelStar";
            this.labelStar.Size = new System.Drawing.Size(12, 13);
            this.labelStar.TabIndex = 29;
            this.labelStar.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(140, 212);
            this.label4.Margin = new System.Windows.Forms.Padding(8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(80, 302);
            this.label6.Margin = new System.Windows.Forms.Padding(8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "*";
            // 
            // errorProviderMemberType
            // 
            this.errorProviderMemberType.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderMemberType.ContainerControl = this;
            // 
            // errorProviderFacultyName
            // 
            this.errorProviderFacultyName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderFacultyName.ContainerControl = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 544);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.statusStrip1.Size = new System.Drawing.Size(635, 26);
            this.statusStrip1.TabIndex = 33;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(104, 21);
            this.toolStripStatusLabel1.Text = "Add Member.";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.labelMemberID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxMemberID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labelMemberName);
            this.groupBox1.Controls.Add(this.labelStar);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.textBoxMemberName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelMemberType);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelEmail);
            this.groupBox1.Controls.Add(this.comboBoxFacultyName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.maskedTextBoxSchoolID);
            this.groupBox1.Controls.Add(this.labelContactNumber);
            this.groupBox1.Controls.Add(this.comboBoxMemberType);
            this.groupBox1.Controls.Add(this.labelSchoolID);
            this.groupBox1.Controls.Add(this.buttonCancel);
            this.groupBox1.Controls.Add(this.labelFacultyCode);
            this.groupBox1.Controls.Add(this.textBoxContactNumber);
            this.groupBox1.Controls.Add(this.textBoxEmail);
            this.groupBox1.Location = new System.Drawing.Point(12, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 439);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // AddNewMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(635, 570);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddNewMember";
            this.Text = "Add Member";
            this.Load += new System.EventHandler(this.AddNewMember_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.statusStrip1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMemberName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSchoolID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderContactNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMemberType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFacultyName)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMemberID;
        private System.Windows.Forms.Label labelMemberID;
        private System.Windows.Forms.Label labelMemberName;
        private System.Windows.Forms.TextBox textBoxMemberName;
        private System.Windows.Forms.Label labelMemberType;
        private System.Windows.Forms.Label labelFacultyCode;
        private System.Windows.Forms.Label labelSchoolID;
        private System.Windows.Forms.Label labelContactNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxContactNumber;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ErrorProvider errorProviderMemberName;
        private System.Windows.Forms.ComboBox comboBoxMemberType;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSchoolID;
        private System.Windows.Forms.ComboBox comboBoxFacultyName;
        private System.Windows.Forms.ErrorProvider errorProviderEmail;
        private System.Windows.Forms.ErrorProvider errorProviderSchoolID;
        private System.Windows.Forms.ErrorProvider errorProviderContactNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelStar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProviderMemberType;
        private System.Windows.Forms.ErrorProvider errorProviderFacultyName;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
