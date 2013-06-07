namespace WindowsFormsApplication4
{
    partial class Login
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxPw = new System.Windows.Forms.TextBox();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelNotice = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "PLEASE LOGIN";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "STAFF ID:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "PASSWORD:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(180, 103);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(175, 20);
            this.textBoxId.TabIndex = 6;
            this.textBoxId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxPw
            // 
            this.textBoxPw.Location = new System.Drawing.Point(181, 151);
            this.textBoxPw.Name = "textBoxPw";
            this.textBoxPw.PasswordChar = '*';
            this.textBoxPw.Size = new System.Drawing.Size(174, 20);
            this.textBoxPw.TabIndex = 7;
            this.textBoxPw.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Location = new System.Drawing.Point(50, 196);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(119, 22);
            this.buttonLogIn.TabIndex = 8;
            this.buttonLogIn.Text = "Log In";
            this.buttonLogIn.UseVisualStyleBackColor = true;
            this.buttonLogIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(208, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 9;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 21);
            this.button1.TabIndex = 10;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // labelNotice
            // 
            this.labelNotice.AutoSize = true;
            this.labelNotice.ForeColor = System.Drawing.Color.Red;
            this.labelNotice.Location = new System.Drawing.Point(47, 253);
            this.labelNotice.Name = "labelNotice";
            this.labelNotice.Size = new System.Drawing.Size(44, 13);
            this.labelNotice.TabIndex = 11;
            this.labelNotice.Text = "(Notice)";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackgroundImage = global::WindowsFormsApplication4.Properties.Resources.gauze;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.labelNotice);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.buttonLogIn);
            this.groupBox1.Controls.Add(this.textBoxPw);
            this.groupBox1.Controls.Add(this.textBoxId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(462, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 308);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LOG IN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(392, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Only Staff should login to TAKE ATTENDANCE  and VIEW STUDENT DETAILS.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(527, 456);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "(For ADMINISTRATOR MAINTENANCE please click here)";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Location = new System.Drawing.Point(599, 472);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 29);
            this.button2.TabIndex = 15;
            this.button2.Text = "ADMIN LOGIN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication4.Properties.Resources.graph1;
            this.ClientSize = new System.Drawing.Size(1257, 513);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Login";
            this.Text = "ATTENDANCE SYSTEM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxPw;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelNotice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
    }
}

