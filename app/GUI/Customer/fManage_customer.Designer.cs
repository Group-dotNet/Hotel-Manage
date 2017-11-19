namespace app.GUI.Customer
{
    partial class fManage_customer
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.ptb_export = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ptb_print = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lb_name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lb_sex = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.lb_company = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lb_passport = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lb_address = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lb_phone = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lb_email = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_export)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_print)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel16.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 512);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel16);
            this.panel4.Controls.Add(this.panel13);
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(310, 54);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(652, 455);
            this.panel4.TabIndex = 2;
            // 
            // panel13
            // 
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel13.Controls.Add(this.ptb_export);
            this.panel13.Controls.Add(this.label4);
            this.panel13.Controls.Add(this.ptb_print);
            this.panel13.Location = new System.Drawing.Point(4, 4);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(643, 36);
            this.panel13.TabIndex = 1;
            // 
            // ptb_export
            // 
            this.ptb_export.BackgroundImage = global::app.Properties.Resources.export;
            this.ptb_export.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_export.Image = global::app.Properties.Resources.print1600;
            this.ptb_export.InitialImage = global::app.Properties.Resources.print1600;
            this.ptb_export.Location = new System.Drawing.Point(565, 3);
            this.ptb_export.Name = "ptb_export";
            this.ptb_export.Size = new System.Drawing.Size(28, 28);
            this.ptb_export.TabIndex = 2;
            this.ptb_export.TabStop = false;
            this.ptb_export.Click += new System.EventHandler(this.pictureBox1_Click_1);
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
            // ptb_print
            // 
            this.ptb_print.BackgroundImage = global::app.Properties.Resources.print1600;
            this.ptb_print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_print.Image = global::app.Properties.Resources.print1600;
            this.ptb_print.InitialImage = global::app.Properties.Resources.print1600;
            this.ptb_print.Location = new System.Drawing.Point(599, 3);
            this.ptb_print.Name = "ptb_print";
            this.ptb_print.Size = new System.Drawing.Size(28, 28);
            this.ptb_print.TabIndex = 0;
            this.ptb_print.TabStop = false;
            this.ptb_print.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 360);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel15);
            this.panel3.Controls.Add(this.panel14);
            this.panel3.Controls.Add(this.panel12);
            this.panel3.Location = new System.Drawing.Point(4, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 456);
            this.panel3.TabIndex = 1;
            // 
            // panel15
            // 
            this.panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel15.Controls.Add(this.panel5);
            this.panel15.Controls.Add(this.panel6);
            this.panel15.Controls.Add(this.panel11);
            this.panel15.Controls.Add(this.panel7);
            this.panel15.Controls.Add(this.panel8);
            this.panel15.Controls.Add(this.panel10);
            this.panel15.Controls.Add(this.panel9);
            this.panel15.Location = new System.Drawing.Point(4, 32);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(288, 353);
            this.panel15.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lb_name);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(4, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(281, 41);
            this.panel5.TabIndex = 1;
            // 
            // lb_name
            // 
            this.lb_name.Location = new System.Drawing.Point(96, 11);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(179, 16);
            this.lb_name.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lb_sex);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(4, 50);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(281, 41);
            this.panel6.TabIndex = 2;
            // 
            // lb_sex
            // 
            this.lb_sex.Location = new System.Drawing.Point(96, 11);
            this.lb_sex.Name = "lb_sex";
            this.lb_sex.Size = new System.Drawing.Size(179, 16);
            this.lb_sex.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sex:";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.lb_company);
            this.panel11.Controls.Add(this.label16);
            this.panel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel11.Location = new System.Drawing.Point(4, 308);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(281, 41);
            this.panel11.TabIndex = 3;
            // 
            // lb_company
            // 
            this.lb_company.Location = new System.Drawing.Point(96, 11);
            this.lb_company.Name = "lb_company";
            this.lb_company.Size = new System.Drawing.Size(179, 16);
            this.lb_company.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 11);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 16);
            this.label16.TabIndex = 0;
            this.label16.Text = "Company:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lb_passport);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.Location = new System.Drawing.Point(4, 97);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(281, 41);
            this.panel7.TabIndex = 2;
            // 
            // lb_passport
            // 
            this.lb_passport.Location = new System.Drawing.Point(99, 11);
            this.lb_passport.Name = "lb_passport";
            this.lb_passport.Size = new System.Drawing.Size(176, 16);
            this.lb_passport.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Passport:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.lb_address);
            this.panel8.Controls.Add(this.label10);
            this.panel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.Location = new System.Drawing.Point(4, 144);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(281, 64);
            this.panel8.TabIndex = 2;
            // 
            // lb_address
            // 
            this.lb_address.Location = new System.Drawing.Point(96, 11);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(179, 42);
            this.lb_address.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Address:";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.lb_phone);
            this.panel10.Controls.Add(this.label14);
            this.panel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel10.Location = new System.Drawing.Point(4, 261);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(281, 41);
            this.panel10.TabIndex = 3;
            // 
            // lb_phone
            // 
            this.lb_phone.Location = new System.Drawing.Point(96, 11);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(179, 16);
            this.lb_phone.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "Phone:";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.lb_email);
            this.panel9.Controls.Add(this.label12);
            this.panel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel9.Location = new System.Drawing.Point(4, 214);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(281, 41);
            this.panel9.TabIndex = 2;
            // 
            // lb_email
            // 
            this.lb_email.Location = new System.Drawing.Point(96, 11);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(179, 16);
            this.lb_email.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Email:";
            // 
            // panel14
            // 
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel14.Controls.Add(this.label2);
            this.panel14.Location = new System.Drawing.Point(4, 3);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(288, 26);
            this.panel14.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Sienna;
            this.label2.Location = new System.Drawing.Point(99, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Information";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            this.panel12.Location = new System.Drawing.Point(4, 394);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(291, 57);
            this.panel12.TabIndex = 4;
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
            this.btn_back.Location = new System.Drawing.Point(230, 4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(48, 48);
            this.btn_back.TabIndex = 3;
            this.btn_back.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.BackgroundImage = global::app.Properties.Resources.delete_icon;
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
            // 
            // btn_edit
            // 
            this.btn_edit.BackgroundImage = global::app.Properties.Resources.edit_icon;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(958, 43);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(388, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Customer";
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.btn_search);
            this.panel16.Controls.Add(this.txt_search);
            this.panel16.Location = new System.Drawing.Point(4, 46);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(643, 38);
            this.panel16.TabIndex = 2;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(337, 9);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(210, 20);
            this.txt_search.TabIndex = 0;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(553, 7);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // fManage_customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 536);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Sienna;
            this.Name = "fManage_customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fManage_customer";
            this.Load += new System.EventHandler(this.fManage_customer_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_export)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_print)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label lb_company;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label lb_phone;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lb_address;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lb_passport;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lb_sex;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.PictureBox ptb_print;
        private System.Windows.Forms.PictureBox ptb_export;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
    }
}