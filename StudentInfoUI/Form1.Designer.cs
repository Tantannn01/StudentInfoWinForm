namespace StudentInfoUI
{
    partial class Form1
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
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.cmbAcadLevel = new System.Windows.Forms.ComboBox();
            this.cmbEmail = new System.Windows.Forms.ComboBox();
            this.txt_Email = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txt_Firstname = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txt_Middlename = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txt_Lastname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Red;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(711, 70);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(84, 38);
            this.btn_Delete.TabIndex = 25;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.Lime;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(607, 70);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(87, 38);
            this.btn_Update.TabIndex = 24;
            this.btn_Update.Text = "Edit";
            this.btn_Update.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(35, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(225, 29);
            this.label10.TabIndex = 23;
            this.label10.Text = "Student Informtion";
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(125, 78);
            this.txt_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(234, 30);
            this.txt_search.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(35, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Search";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.btn_Add);
            this.panel1.Controls.Add(this.btn_Save);
            this.panel1.Controls.Add(this.btn_Cancel);
            this.panel1.Controls.Add(this.cmbSection);
            this.panel1.Controls.Add(this.cmbGender);
            this.panel1.Controls.Add(this.cmbAcadLevel);
            this.panel1.Controls.Add(this.cmbEmail);
            this.panel1.Controls.Add(this.txt_Email);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtFirstName);
            this.panel1.Controls.Add(this.txt_Firstname);
            this.panel1.Controls.Add(this.txtMiddleName);
            this.panel1.Controls.Add(this.txt_Middlename);
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Controls.Add(this.txt_Lastname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(888, 126);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 431);
            this.panel1.TabIndex = 26;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(228, 13);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(87, 38);
            this.btn_Add.TabIndex = 29;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(178, 375);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(87, 38);
            this.btn_Save.TabIndex = 28;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(290, 375);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(87, 38);
            this.btn_Cancel.TabIndex = 29;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            // 
            // cmbSection
            // 
            this.cmbSection.FormattingEnabled = true;
            this.cmbSection.Location = new System.Drawing.Point(240, 248);
            this.cmbSection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(137, 24);
            this.cmbSection.TabIndex = 18;
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(240, 168);
            this.cmbGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(137, 24);
            this.cmbGender.TabIndex = 17;
            // 
            // cmbAcadLevel
            // 
            this.cmbAcadLevel.FormattingEnabled = true;
            this.cmbAcadLevel.Location = new System.Drawing.Point(24, 248);
            this.cmbAcadLevel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbAcadLevel.Name = "cmbAcadLevel";
            this.cmbAcadLevel.Size = new System.Drawing.Size(137, 24);
            this.cmbAcadLevel.TabIndex = 16;
            // 
            // cmbEmail
            // 
            this.cmbEmail.FormattingEnabled = true;
            this.cmbEmail.Location = new System.Drawing.Point(32, 326);
            this.cmbEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEmail.Name = "cmbEmail";
            this.cmbEmail.Size = new System.Drawing.Size(295, 24);
            this.cmbEmail.TabIndex = 15;
            // 
            // txt_Email
            // 
            this.txt_Email.AutoSize = true;
            this.txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(20, 295);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(56, 20);
            this.txt_Email.TabIndex = 13;
            this.txt_Email.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(243, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Section";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Academic Level";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(243, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gender";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(246, 95);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(131, 22);
            this.txtFirstName.TabIndex = 6;
            // 
            // txt_Firstname
            // 
            this.txt_Firstname.AutoSize = true;
            this.txt_Firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Firstname.Location = new System.Drawing.Point(243, 69);
            this.txt_Firstname.Name = "txt_Firstname";
            this.txt_Firstname.Size = new System.Drawing.Size(102, 20);
            this.txt_Firstname.TabIndex = 5;
            this.txt_Firstname.Text = "First Name";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(24, 168);
            this.txtMiddleName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(131, 22);
            this.txtMiddleName.TabIndex = 4;
            // 
            // txt_Middlename
            // 
            this.txt_Middlename.AutoSize = true;
            this.txt_Middlename.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Middlename.Location = new System.Drawing.Point(20, 142);
            this.txt_Middlename.Name = "txt_Middlename";
            this.txt_Middlename.Size = new System.Drawing.Size(107, 20);
            this.txt_Middlename.TabIndex = 3;
            this.txt_Middlename.Text = "Middle Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(24, 95);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(131, 22);
            this.txtLastName.TabIndex = 2;
            // 
            // txt_Lastname
            // 
            this.txt_Lastname.AutoSize = true;
            this.txt_Lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Lastname.Location = new System.Drawing.Point(20, 69);
            this.txt_Lastname.Name = "txt_Lastname";
            this.txt_Lastname.Size = new System.Drawing.Size(100, 20);
            this.txt_Lastname.TabIndex = 1;
            this.txt_Lastname.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Informtion";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView.Location = new System.Drawing.Point(12, 139);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(783, 366);
            this.dataGridView.TabIndex = 27;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Last Name";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Fist Name";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Middle Name";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Gender";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Section";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Year Level";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Email";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.DimGray;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(888, 63);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(398, 45);
            this.txtSearch.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1316, 588);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label9);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbSection;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.ComboBox cmbAcadLevel;
        private System.Windows.Forms.ComboBox cmbEmail;
        private System.Windows.Forms.Label txt_Email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label txt_Firstname;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label txt_Middlename;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label txt_Lastname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txtSearch;
    }
}

