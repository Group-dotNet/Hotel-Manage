namespace app.GUI.Reservation
{
    partial class fAdd_reservation
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.btn_del_all = new System.Windows.Forms.Button();
            this.lb_number_total_people = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lv_reservation_room = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flp_room = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lb_floor = new System.Windows.Forms.Label();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_prew = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.dtp_endate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.cb_group = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.nud_people = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.cb_customer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_people)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 510);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.panel14);
            this.panel5.Controls.Add(this.flp_room);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Location = new System.Drawing.Point(362, 44);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(623, 463);
            this.panel5.TabIndex = 3;
            // 
            // panel14
            // 
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel14.Controls.Add(this.panel15);
            this.panel14.Controls.Add(this.lv_reservation_room);
            this.panel14.Location = new System.Drawing.Point(3, 305);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(617, 155);
            this.panel14.TabIndex = 3;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.btn_del_all);
            this.panel15.Controls.Add(this.lb_number_total_people);
            this.panel15.Controls.Add(this.label8);
            this.panel15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel15.Location = new System.Drawing.Point(495, 3);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(116, 147);
            this.panel15.TabIndex = 1;
            // 
            // btn_del_all
            // 
            this.btn_del_all.Location = new System.Drawing.Point(3, 99);
            this.btn_del_all.Name = "btn_del_all";
            this.btn_del_all.Size = new System.Drawing.Size(113, 45);
            this.btn_del_all.TabIndex = 2;
            this.btn_del_all.Text = "Delete All";
            this.btn_del_all.UseVisualStyleBackColor = true;
            this.btn_del_all.Click += new System.EventHandler(this.btn_del_all_Click);
            // 
            // lb_number_total_people
            // 
            this.lb_number_total_people.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_number_total_people.Location = new System.Drawing.Point(3, 38);
            this.lb_number_total_people.Name = "lb_number_total_people";
            this.lb_number_total_people.Size = new System.Drawing.Size(110, 44);
            this.lb_number_total_people.TabIndex = 1;
            this.lb_number_total_people.Text = "10";
            this.lb_number_total_people.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_number_total_people.Click += new System.EventHandler(this.number_total_people_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Total people";
            // 
            // lv_reservation_room
            // 
            this.lv_reservation_room.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lv_reservation_room.Location = new System.Drawing.Point(3, 3);
            this.lv_reservation_room.Name = "lv_reservation_room";
            this.lv_reservation_room.Size = new System.Drawing.Size(486, 147);
            this.lv_reservation_room.TabIndex = 0;
            this.lv_reservation_room.UseCompatibleStateImageBehavior = false;
            this.lv_reservation_room.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Room";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Floor";
            this.columnHeader5.Width = 41;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Order";
            this.columnHeader6.Width = 39;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kind of room";
            this.columnHeader2.Width = 176;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            this.columnHeader3.Width = 111;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "People";
            this.columnHeader4.Width = 53;
            // 
            // flp_room
            // 
            this.flp_room.Location = new System.Drawing.Point(3, 38);
            this.flp_room.Name = "flp_room";
            this.flp_room.Size = new System.Drawing.Size(617, 261);
            this.flp_room.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lb_floor);
            this.panel4.Controls.Add(this.btn_next);
            this.panel4.Controls.Add(this.btn_prew);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(617, 29);
            this.panel4.TabIndex = 1;
            // 
            // lb_floor
            // 
            this.lb_floor.AutoSize = true;
            this.lb_floor.Location = new System.Drawing.Point(294, 9);
            this.lb_floor.Name = "lb_floor";
            this.lb_floor.Size = new System.Drawing.Size(39, 13);
            this.lb_floor.TabIndex = 2;
            this.lb_floor.Text = "Floor 1";
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(539, 3);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 1;
            this.btn_next.Text = "Next >>";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_prew
            // 
            this.btn_prew.Location = new System.Drawing.Point(3, 3);
            this.btn_prew.Name = "btn_prew";
            this.btn_prew.Size = new System.Drawing.Size(75, 23);
            this.btn_prew.TabIndex = 0;
            this.btn_prew.Text = "<< Prew";
            this.btn_prew.UseVisualStyleBackColor = true;
            this.btn_prew.Click += new System.EventHandler(this.btn_prew_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(3, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(353, 463);
            this.panel3.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.btn_cancel);
            this.panel8.Controls.Add(this.btn_ok);
            this.panel8.Location = new System.Drawing.Point(4, 375);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(342, 85);
            this.panel8.TabIndex = 2;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(182, 19);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(119, 46);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(27, 19);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(119, 46);
            this.btn_ok.TabIndex = 0;
            this.btn_ok.Text = "Add";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.panel12);
            this.panel7.Controls.Add(this.panel11);
            this.panel7.Controls.Add(this.panel10);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Location = new System.Drawing.Point(4, 47);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(342, 210);
            this.panel7.TabIndex = 1;
            // 
            // panel12
            // 
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Controls.Add(this.dtp_endate);
            this.panel12.Controls.Add(this.label6);
            this.panel12.Location = new System.Drawing.Point(4, 156);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(333, 45);
            this.panel12.TabIndex = 4;
            // 
            // dtp_endate
            // 
            this.dtp_endate.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.dtp_endate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_endate.Location = new System.Drawing.Point(110, 9);
            this.dtp_endate.Name = "dtp_endate";
            this.dtp_endate.Size = new System.Drawing.Size(212, 24);
            this.dtp_endate.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "End date:";
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.cb_group);
            this.panel11.Controls.Add(this.label5);
            this.panel11.Location = new System.Drawing.Point(4, 105);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(333, 45);
            this.panel11.TabIndex = 3;
            // 
            // cb_group
            // 
            this.cb_group.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_group.FormattingEnabled = true;
            this.cb_group.Items.AddRange(new object[] {
            "False",
            "True"});
            this.cb_group.Location = new System.Drawing.Point(110, 11);
            this.cb_group.Name = "cb_group";
            this.cb_group.Size = new System.Drawing.Size(212, 26);
            this.cb_group.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Group:";
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.nud_people);
            this.panel10.Controls.Add(this.label4);
            this.panel10.Location = new System.Drawing.Point(4, 54);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(333, 45);
            this.panel10.TabIndex = 3;
            // 
            // nud_people
            // 
            this.nud_people.Location = new System.Drawing.Point(110, 10);
            this.nud_people.Name = "nud_people";
            this.nud_people.Size = new System.Drawing.Size(212, 24);
            this.nud_people.TabIndex = 1;
            this.nud_people.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_people.ValueChanged += new System.EventHandler(this.nud_people_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "People:";
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.linkLabel1);
            this.panel9.Controls.Add(this.cb_customer);
            this.panel9.Controls.Add(this.label3);
            this.panel9.Location = new System.Drawing.Point(4, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(333, 45);
            this.panel9.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(286, 14);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(36, 18);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Add";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // cb_customer
            // 
            this.cb_customer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_customer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_customer.FormattingEnabled = true;
            this.cb_customer.Location = new System.Drawing.Point(110, 11);
            this.cb_customer.Name = "cb_customer";
            this.cb_customer.Size = new System.Drawing.Size(170, 26);
            this.cb_customer.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Customer:";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label2);
            this.panel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(343, 38);
            this.panel6.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Information";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(982, 35);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(419, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Reservation";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.cancelToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(111, 48);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.cancelToolStripMenuItem.Text = "Cancel";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // fAdd_reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 511);
            this.Controls.Add(this.panel1);
            this.Name = "fAdd_reservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fAdd_reservation";
            this.Load += new System.EventHandler(this.fAdd_reservation_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_people)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.ComboBox cb_group;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox cb_customer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown nud_people;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button btn_del_all;
        private System.Windows.Forms.Label lb_number_total_people;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView lv_reservation_room;
        private System.Windows.Forms.FlowLayoutPanel flp_room;
        private System.Windows.Forms.Label lb_floor;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_prew;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dtp_endate;
    }
}