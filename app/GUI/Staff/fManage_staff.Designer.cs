namespace app.GUI.Staff
{
    partial class fManage_staff
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgv_staff = new System.Windows.Forms.DataGridView();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_details = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lb_position = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lb_name = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_change_password = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ptb_export = new System.Windows.Forms.PictureBox();
            this.ptb_print = new System.Windows.Forms.PictureBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel17 = new System.Windows.Forms.Panel();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.cb_search = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff)).BeginInit();
            this.panel13.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_export)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_print)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel17.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 528);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(4, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(970, 462);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.panel17);
            this.panel5.Controls.Add(this.dgv_staff);
            this.panel5.Controls.Add(this.panel13);
            this.panel5.Location = new System.Drawing.Point(304, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(663, 455);
            this.panel5.TabIndex = 1;
            // 
            // dgv_staff
            // 
            this.dgv_staff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_staff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv_staff.Location = new System.Drawing.Point(3, 88);
            this.dgv_staff.Name = "dgv_staff";
            this.dgv_staff.Size = new System.Drawing.Size(655, 364);
            this.dgv_staff.TabIndex = 3;
            this.dgv_staff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_staff_CellClick);
            // 
            // panel13
            // 
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel13.Controls.Add(this.ptb_export);
            this.panel13.Controls.Add(this.label4);
            this.panel13.Controls.Add(this.ptb_print);
            this.panel13.Location = new System.Drawing.Point(3, 4);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(655, 36);
            this.panel13.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Total record:";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel12);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel14);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(6, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(292, 455);
            this.panel4.TabIndex = 0;
            // 
            // panel12
            // 
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Controls.Add(this.btn_refresh);
            this.panel12.Controls.Add(this.btn_back);
            this.panel12.Controls.Add(this.btn_delete);
            this.panel12.Controls.Add(this.btn_edit);
            this.panel12.Controls.Add(this.btn_add);
            this.panel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel12.Location = new System.Drawing.Point(3, 393);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(283, 57);
            this.panel12.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.button1);
            this.panel6.Controls.Add(this.btn_change_password);
            this.panel6.Controls.Add(this.btn_details);
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(4, 45);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(282, 328);
            this.panel6.TabIndex = 7;
            // 
            // btn_details
            // 
            this.btn_details.Location = new System.Drawing.Point(2, 255);
            this.btn_details.Name = "btn_details";
            this.btn_details.Size = new System.Drawing.Size(270, 31);
            this.btn_details.TabIndex = 5;
            this.btn_details.Text = "See details";
            this.btn_details.UseVisualStyleBackColor = true;
            this.btn_details.Click += new System.EventHandler(this.btn_details_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.lb_position);
            this.panel8.Controls.Add(this.lb);
            this.panel8.Location = new System.Drawing.Point(2, 211);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(270, 38);
            this.panel8.TabIndex = 3;
            // 
            // lb_position
            // 
            this.lb_position.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_position.Location = new System.Drawing.Point(94, 7);
            this.lb_position.Name = "lb_position";
            this.lb_position.Size = new System.Drawing.Size(163, 28);
            this.lb_position.TabIndex = 1;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(3, 9);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(68, 16);
            this.lb.TabIndex = 0;
            this.lb.Text = "Position:";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.lb_name);
            this.panel9.Controls.Add(this.label6);
            this.panel9.Location = new System.Drawing.Point(2, 167);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(270, 38);
            this.panel9.TabIndex = 2;
            // 
            // lb_name
            // 
            this.lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(94, 7);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(163, 29);
            this.lb_name.TabIndex = 1;
            this.lb_name.Click += new System.EventHandler(this.lb_name_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Name:";
            // 
            // panel14
            // 
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel14.Controls.Add(this.label2);
            this.panel14.Location = new System.Drawing.Point(3, 3);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(283, 36);
            this.panel14.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(80, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Information";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(976, 49);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(429, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Staff";
            // 
            // btn_change_password
            // 
            this.btn_change_password.Location = new System.Drawing.Point(3, 292);
            this.btn_change_password.Name = "btn_change_password";
            this.btn_change_password.Size = new System.Drawing.Size(132, 31);
            this.btn_change_password.TabIndex = 6;
            this.btn_change_password.Text = "Change pass";
            this.btn_change_password.UseVisualStyleBackColor = true;
            this.btn_change_password.Click += new System.EventHandler(this.btn_change_password_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "Change role";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ptb_export
            // 
            this.ptb_export.BackgroundImage = global::app.Properties.Resources.export;
            this.ptb_export.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_export.Image = global::app.Properties.Resources.print1600;
            this.ptb_export.InitialImage = global::app.Properties.Resources.print1600;
            this.ptb_export.Location = new System.Drawing.Point(578, 3);
            this.ptb_export.Name = "ptb_export";
            this.ptb_export.Size = new System.Drawing.Size(28, 28);
            this.ptb_export.TabIndex = 2;
            this.ptb_export.TabStop = false;
            // 
            // ptb_print
            // 
            this.ptb_print.BackgroundImage = global::app.Properties.Resources.print1600;
            this.ptb_print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_print.Image = global::app.Properties.Resources.print1600;
            this.ptb_print.InitialImage = global::app.Properties.Resources.print1600;
            this.ptb_print.Location = new System.Drawing.Point(612, 3);
            this.ptb_print.Name = "ptb_print";
            this.ptb_print.Size = new System.Drawing.Size(28, 28);
            this.ptb_print.TabIndex = 0;
            this.ptb_print.TabStop = false;
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackgroundImage = global::app.Properties.Resources.refresh_icon;
            this.btn_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_refresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.ForeColor = System.Drawing.Color.Black;
            this.btn_refresh.Location = new System.Drawing.Point(3, 3);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(48, 48);
            this.btn_refresh.TabIndex = 4;
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackgroundImage = global::app.Properties.Resources.home_icon;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.ForeColor = System.Drawing.Color.Black;
            this.btn_back.Location = new System.Drawing.Point(219, 4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(48, 48);
            this.btn_back.TabIndex = 3;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackgroundImage = global::app.Properties.Resources.ban1;
            this.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.ForeColor = System.Drawing.Color.Black;
            this.btn_delete.Location = new System.Drawing.Point(165, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(48, 48);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackgroundImage = global::app.Properties.Resources.refresh_passwords_512;
            this.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.ForeColor = System.Drawing.Color.Black;
            this.btn_edit.Location = new System.Drawing.Point(111, 3);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(48, 48);
            this.btn_edit.TabIndex = 1;
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackgroundImage = global::app.Properties.Resources.add_icon;
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.ForeColor = System.Drawing.Color.Black;
            this.btn_add.Location = new System.Drawing.Point(57, 4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(48, 48);
            this.btn_add.TabIndex = 0;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(76, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "username";
            this.Column1.HeaderText = "Username";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "name";
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "sex";
            this.Column3.HeaderText = "Sex";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "phone";
            this.Column4.HeaderText = "Phone";
            this.Column4.Name = "Column4";
            // 
            // panel17
            // 
            this.panel17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel17.Controls.Add(this.btn_search);
            this.panel17.Controls.Add(this.txt_search);
            this.panel17.Controls.Add(this.cb_search);
            this.panel17.Location = new System.Drawing.Point(3, 42);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(655, 40);
            this.panel17.TabIndex = 5;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(567, 6);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(348, 8);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(213, 20);
            this.txt_search.TabIndex = 1;
            // 
            // cb_search
            // 
            this.cb_search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_search.FormattingEnabled = true;
            this.cb_search.Items.AddRange(new object[] {
            "ID Reservation",
            "ID Room",
            "Customer",
            "Staff",
            "Start date",
            "End date"});
            this.cb_search.Location = new System.Drawing.Point(221, 8);
            this.cb_search.Name = "cb_search";
            this.cb_search.Size = new System.Drawing.Size(121, 21);
            this.cb_search.TabIndex = 0;
            // 
            // fManage_staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 536);
            this.Controls.Add(this.panel1);
            this.Name = "fManage_staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fManage_staff";
            this.Load += new System.EventHandler(this.fManage_staff_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_staff)).EndInit();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_export)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_print)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.PictureBox ptb_export;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox ptb_print;
        private System.Windows.Forms.DataGridView dgv_staff;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_details;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lb_position;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_change_password;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.ComboBox cb_search;
    }
}