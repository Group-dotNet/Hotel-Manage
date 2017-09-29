namespace app
{
    partial class fChange_pass
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
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_change = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txt_check_match = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_pass_new = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_pass_old = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_error_check_match = new System.Windows.Forms.Label();
            this.lb_error_pass_new = new System.Windows.Forms.Label();
            this.lb_error_pass_old = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 345);
            this.panel1.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btn_back);
            this.panel7.Controls.Add(this.btn_change);
            this.panel7.Location = new System.Drawing.Point(4, 297);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(357, 37);
            this.panel7.TabIndex = 3;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(246, 0);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(95, 34);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_change
            // 
            this.btn_change.Location = new System.Drawing.Point(143, 0);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(95, 34);
            this.btn_change.TabIndex = 4;
            this.btn_change.Text = "Change";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lb_error_check_match);
            this.panel6.Controls.Add(this.txt_check_match);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(4, 237);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(357, 54);
            this.panel6.TabIndex = 2;
            // 
            // txt_check_match
            // 
            this.txt_check_match.AcceptsTab = true;
            this.txt_check_match.Location = new System.Drawing.Point(143, 11);
            this.txt_check_match.Name = "txt_check_match";
            this.txt_check_match.Size = new System.Drawing.Size(198, 26);
            this.txt_check_match.TabIndex = 3;
            this.txt_check_match.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Check match:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lb_error_pass_new);
            this.panel5.Controls.Add(this.txt_pass_new);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(4, 177);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(357, 54);
            this.panel5.TabIndex = 2;
            // 
            // txt_pass_new
            // 
            this.txt_pass_new.Location = new System.Drawing.Point(143, 11);
            this.txt_pass_new.Name = "txt_pass_new";
            this.txt_pass_new.Size = new System.Drawing.Size(198, 26);
            this.txt_pass_new.TabIndex = 2;
            this.txt_pass_new.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Password new:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lb_error_pass_old);
            this.panel4.Controls.Add(this.txt_pass_old);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(4, 114);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(357, 57);
            this.panel4.TabIndex = 2;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // txt_pass_old
            // 
            this.txt_pass_old.Location = new System.Drawing.Point(143, 11);
            this.txt_pass_old.Name = "txt_pass_old";
            this.txt_pass_old.Size = new System.Drawing.Size(198, 26);
            this.txt_pass_old.TabIndex = 1;
            this.txt_pass_old.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password old:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_username);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(4, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(357, 57);
            this.panel3.TabIndex = 1;
            // 
            // txt_username
            // 
            this.txt_username.Enabled = false;
            this.txt_username.Location = new System.Drawing.Point(143, 11);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(198, 26);
            this.txt_username.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(357, 42);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change password";
            // 
            // lb_error_check_match
            // 
            this.lb_error_check_match.AutoSize = true;
            this.lb_error_check_match.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_error_check_match.ForeColor = System.Drawing.Color.Red;
            this.lb_error_check_match.Location = new System.Drawing.Point(140, 40);
            this.lb_error_check_match.Name = "lb_error_check_match";
            this.lb_error_check_match.Size = new System.Drawing.Size(0, 13);
            this.lb_error_check_match.TabIndex = 4;
            // 
            // lb_error_pass_new
            // 
            this.lb_error_pass_new.AutoSize = true;
            this.lb_error_pass_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_error_pass_new.ForeColor = System.Drawing.Color.Red;
            this.lb_error_pass_new.Location = new System.Drawing.Point(140, 40);
            this.lb_error_pass_new.Name = "lb_error_pass_new";
            this.lb_error_pass_new.Size = new System.Drawing.Size(0, 13);
            this.lb_error_pass_new.TabIndex = 5;
            // 
            // lb_error_pass_old
            // 
            this.lb_error_pass_old.AutoSize = true;
            this.lb_error_pass_old.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_error_pass_old.ForeColor = System.Drawing.Color.Red;
            this.lb_error_pass_old.Location = new System.Drawing.Point(140, 40);
            this.lb_error_pass_old.Name = "lb_error_pass_old";
            this.lb_error_pass_old.Size = new System.Drawing.Size(0, 13);
            this.lb_error_pass_old.TabIndex = 6;
            // 
            // fChange_pass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 356);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "fChange_pass";
            this.Text = "fChange_pass";
            this.Load += new System.EventHandler(this.fChange_pass_Load);
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txt_check_match;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txt_pass_new;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_pass_old;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lb_error_check_match;
        private System.Windows.Forms.Label lb_error_pass_new;
        private System.Windows.Forms.Label lb_error_pass_old;
    }
}