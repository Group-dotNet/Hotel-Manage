namespace app.GUI.Room
{
    partial class fManage_room
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cb_fittel = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pn_room = new System.Windows.Forms.FlowLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lb_num_floor = new System.Windows.Forms.Label();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.ptb_export = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ptb_print = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.lb_people = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.lb_type_room = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.lb_end_date = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.lb_startdate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lb_reservation = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_details = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lb_name = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_datetime = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_export)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_print)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 533);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel13);
            this.panel4.Location = new System.Drawing.Point(314, 59);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(665, 471);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.pn_room);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Location = new System.Drawing.Point(4, 46);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(654, 422);
            this.panel5.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.lb_datetime);
            this.panel6.Controls.Add(this.cb_fittel);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Location = new System.Drawing.Point(4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(647, 33);
            this.panel6.TabIndex = 3;
            // 
            // cb_fittel
            // 
            this.cb_fittel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_fittel.FormattingEnabled = true;
            this.cb_fittel.Items.AddRange(new object[] {
            "All room",
            "Room is emty",
            "Room is lock"});
            this.cb_fittel.Location = new System.Drawing.Point(434, 5);
            this.cb_fittel.Name = "cb_fittel";
            this.cb_fittel.Size = new System.Drawing.Size(202, 21);
            this.cb_fittel.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(396, 8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Fittel:";
            // 
            // pn_room
            // 
            this.pn_room.AutoScroll = true;
            this.pn_room.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_room.Location = new System.Drawing.Point(4, 43);
            this.pn_room.Name = "pn_room";
            this.pn_room.Size = new System.Drawing.Size(647, 314);
            this.pn_room.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.lb_num_floor);
            this.panel7.Controls.Add(this.btn_next);
            this.panel7.Controls.Add(this.btn_prev);
            this.panel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.Location = new System.Drawing.Point(4, 363);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(647, 54);
            this.panel7.TabIndex = 1;
            // 
            // lb_num_floor
            // 
            this.lb_num_floor.Location = new System.Drawing.Point(269, 18);
            this.lb_num_floor.Name = "lb_num_floor";
            this.lb_num_floor.Size = new System.Drawing.Size(115, 17);
            this.lb_num_floor.TabIndex = 2;
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(523, 3);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(112, 46);
            this.btn_next.TabIndex = 1;
            this.btn_next.Text = "Floor Next >>";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.Location = new System.Drawing.Point(10, 3);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(112, 46);
            this.btn_prev.TabIndex = 0;
            this.btn_prev.Text = "<< Floor Prev";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // panel13
            // 
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel13.Controls.Add(this.ptb_export);
            this.panel13.Controls.Add(this.label4);
            this.panel13.Controls.Add(this.ptb_print);
            this.panel13.Location = new System.Drawing.Point(3, 3);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(655, 36);
            this.panel13.TabIndex = 3;
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
            this.ptb_print.Location = new System.Drawing.Point(612, 3);
            this.ptb_print.Name = "ptb_print";
            this.ptb_print.Size = new System.Drawing.Size(28, 28);
            this.ptb_print.TabIndex = 0;
            this.ptb_print.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel12);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel14);
            this.panel3.Location = new System.Drawing.Point(4, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(304, 471);
            this.panel3.TabIndex = 3;
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
            this.panel12.Location = new System.Drawing.Point(5, 408);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(294, 57);
            this.panel12.TabIndex = 9;
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
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
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
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.panel17);
            this.panel8.Controls.Add(this.panel16);
            this.panel8.Controls.Add(this.panel15);
            this.panel8.Controls.Add(this.panel11);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.btn_details);
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.Location = new System.Drawing.Point(5, 45);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(294, 357);
            this.panel8.TabIndex = 8;
            // 
            // panel17
            // 
            this.panel17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel17.Controls.Add(this.lb_people);
            this.panel17.Controls.Add(this.label14);
            this.panel17.Location = new System.Drawing.Point(3, 238);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(286, 41);
            this.panel17.TabIndex = 3;
            // 
            // lb_people
            // 
            this.lb_people.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_people.Location = new System.Drawing.Point(120, 7);
            this.lb_people.Name = "lb_people";
            this.lb_people.Size = new System.Drawing.Size(163, 25);
            this.lb_people.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "People:";
            // 
            // panel16
            // 
            this.panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel16.Controls.Add(this.lb_type_room);
            this.panel16.Controls.Add(this.label12);
            this.panel16.Location = new System.Drawing.Point(3, 191);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(286, 41);
            this.panel16.TabIndex = 3;
            // 
            // lb_type_room
            // 
            this.lb_type_room.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_type_room.Location = new System.Drawing.Point(120, 7);
            this.lb_type_room.Name = "lb_type_room";
            this.lb_type_room.Size = new System.Drawing.Size(163, 25);
            this.lb_type_room.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Type room:";
            // 
            // panel15
            // 
            this.panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel15.Controls.Add(this.lb_end_date);
            this.panel15.Controls.Add(this.label10);
            this.panel15.Location = new System.Drawing.Point(3, 144);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(286, 41);
            this.panel15.TabIndex = 3;
            // 
            // lb_end_date
            // 
            this.lb_end_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_end_date.Location = new System.Drawing.Point(120, 7);
            this.lb_end_date.Name = "lb_end_date";
            this.lb_end_date.Size = new System.Drawing.Size(163, 25);
            this.lb_end_date.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "End date:";
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.lb_startdate);
            this.panel11.Controls.Add(this.label8);
            this.panel11.Location = new System.Drawing.Point(3, 97);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(286, 41);
            this.panel11.TabIndex = 3;
            // 
            // lb_startdate
            // 
            this.lb_startdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_startdate.Location = new System.Drawing.Point(120, 7);
            this.lb_startdate.Name = "lb_startdate";
            this.lb_startdate.Size = new System.Drawing.Size(163, 25);
            this.lb_startdate.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Start date:";
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.lb_reservation);
            this.panel9.Controls.Add(this.label5);
            this.panel9.Location = new System.Drawing.Point(3, 50);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(286, 41);
            this.panel9.TabIndex = 3;
            // 
            // lb_reservation
            // 
            this.lb_reservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_reservation.Location = new System.Drawing.Point(120, 7);
            this.lb_reservation.Name = "lb_reservation";
            this.lb_reservation.Size = new System.Drawing.Size(163, 25);
            this.lb_reservation.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = " Reservation:";
            // 
            // btn_details
            // 
            this.btn_details.Location = new System.Drawing.Point(3, 311);
            this.btn_details.Name = "btn_details";
            this.btn_details.Size = new System.Drawing.Size(286, 41);
            this.btn_details.TabIndex = 5;
            this.btn_details.Text = "See details";
            this.btn_details.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.lb_name);
            this.panel10.Controls.Add(this.label6);
            this.panel10.Location = new System.Drawing.Point(3, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(286, 41);
            this.panel10.TabIndex = 2;
            // 
            // lb_name
            // 
            this.lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(120, 7);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(163, 25);
            this.lb_name.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Customer:";
            // 
            // panel14
            // 
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel14.Controls.Add(this.label2);
            this.panel14.Location = new System.Drawing.Point(5, 3);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(294, 36);
            this.panel14.TabIndex = 7;
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
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(393, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Room";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.toolStripMenuItem1.Text = "Add Service";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(136, 22);
            this.toolStripMenuItem2.Text = "Add Stuff";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // lb_datetime
            // 
            this.lb_datetime.AutoSize = true;
            this.lb_datetime.Location = new System.Drawing.Point(19, 9);
            this.lb_datetime.Name = "lb_datetime";
            this.lb_datetime.Size = new System.Drawing.Size(49, 13);
            this.lb_datetime.TabIndex = 2;
            this.lb_datetime.Text = "Datetime";
            // 
            // fManage_room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 536);
            this.Controls.Add(this.panel1);
            this.Name = "fManage_room";
            this.Text = "fManage_room";
            this.Load += new System.EventHandler(this.fManage_room_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_export)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_print)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.PictureBox ptb_export;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox ptb_print;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btn_details;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label lb_people;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label lb_type_room;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label lb_end_date;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label lb_startdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lb_reservation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel pn_room;
        private System.Windows.Forms.Label lb_num_floor;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cb_fittel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Label lb_datetime;
    }
}