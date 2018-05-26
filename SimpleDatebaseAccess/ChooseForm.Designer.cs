namespace SimpleDatebaseAccess
{
    partial class ChooseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_tips = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_db = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_dbname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lb_ConnectionDataSouece = new System.Windows.Forms.Label();
            this.lb_ConnectionTimeOut = new System.Windows.Forms.Label();
            this.lb_ConnectionURL = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_ConnectionDatabaseVersion = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_tips);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbo_db);
            this.groupBox1.ForeColor = System.Drawing.Color.Silver;
            this.groupBox1.Location = new System.Drawing.Point(2, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database";
            // 
            // lb_tips
            // 
            this.lb_tips.AutoSize = true;
            this.lb_tips.ForeColor = System.Drawing.Color.Teal;
            this.lb_tips.Location = new System.Drawing.Point(475, 24);
            this.lb_tips.Name = "lb_tips";
            this.lb_tips.Size = new System.Drawing.Size(194, 20);
            this.lb_tips.TabIndex = 8;
            this.lb_tips.Text = "Please choose database...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(2, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Configure next to operate on database:";
            // 
            // cbo_db
            // 
            this.cbo_db.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_db.FormattingEnabled = true;
            this.cbo_db.Location = new System.Drawing.Point(304, 21);
            this.cbo_db.Name = "cbo_db";
            this.cbo_db.Size = new System.Drawing.Size(165, 28);
            this.cbo_db.TabIndex = 2;
            this.cbo_db.SelectedIndexChanged += new System.EventHandler(this.cbo_db_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_url);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lb_dbname);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.ForeColor = System.Drawing.Color.Silver;
            this.groupBox2.Location = new System.Drawing.Point(2, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(685, 124);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connect information";
            // 
            // txt_url
            // 
            this.txt_url.Location = new System.Drawing.Point(224, 70);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(433, 27);
            this.txt_url.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(84, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Connection URL :";
            // 
            // lb_dbname
            // 
            this.lb_dbname.AutoSize = true;
            this.lb_dbname.ForeColor = System.Drawing.Color.Gray;
            this.lb_dbname.Location = new System.Drawing.Point(224, 33);
            this.lb_dbname.Name = "lb_dbname";
            this.lb_dbname.Size = new System.Drawing.Size(80, 20);
            this.lb_dbname.TabIndex = 5;
            this.lb_dbname.Text = "Loading...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(65, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choose\'s database :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lb_ConnectionDataSouece);
            this.groupBox3.Controls.Add(this.lb_ConnectionTimeOut);
            this.groupBox3.Controls.Add(this.lb_ConnectionURL);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.ForeColor = System.Drawing.Color.Silver;
            this.groupBox3.Location = new System.Drawing.Point(2, 206);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(685, 137);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Test Connection";
            // 
            // lb_ConnectionDataSouece
            // 
            this.lb_ConnectionDataSouece.AutoSize = true;
            this.lb_ConnectionDataSouece.ForeColor = System.Drawing.Color.Gray;
            this.lb_ConnectionDataSouece.Location = new System.Drawing.Point(237, 100);
            this.lb_ConnectionDataSouece.Name = "lb_ConnectionDataSouece";
            this.lb_ConnectionDataSouece.Size = new System.Drawing.Size(71, 20);
            this.lb_ConnectionDataSouece.TabIndex = 11;
            this.lb_ConnectionDataSouece.Text = "Uncheck";
            // 
            // lb_ConnectionTimeOut
            // 
            this.lb_ConnectionTimeOut.AutoSize = true;
            this.lb_ConnectionTimeOut.ForeColor = System.Drawing.Color.Gray;
            this.lb_ConnectionTimeOut.Location = new System.Drawing.Point(237, 61);
            this.lb_ConnectionTimeOut.Name = "lb_ConnectionTimeOut";
            this.lb_ConnectionTimeOut.Size = new System.Drawing.Size(71, 20);
            this.lb_ConnectionTimeOut.TabIndex = 10;
            this.lb_ConnectionTimeOut.Text = "Uncheck";
            // 
            // lb_ConnectionURL
            // 
            this.lb_ConnectionURL.AutoSize = true;
            this.lb_ConnectionURL.ForeColor = System.Drawing.Color.Gray;
            this.lb_ConnectionURL.Location = new System.Drawing.Point(237, 23);
            this.lb_ConnectionURL.Name = "lb_ConnectionURL";
            this.lb_ConnectionURL.Size = new System.Drawing.Size(71, 20);
            this.lb_ConnectionURL.TabIndex = 9;
            this.lb_ConnectionURL.Text = "Uncheck";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(110, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Data Source :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(52, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Connection Timeout :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(84, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Connection URL :";
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(592, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 30);
            this.button2.TabIndex = 0;
            this.button2.Text = "Test";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(594, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Done";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(-2, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "DBVersion :";
            // 
            // lb_ConnectionDatabaseVersion
            // 
            this.lb_ConnectionDatabaseVersion.AutoSize = true;
            this.lb_ConnectionDatabaseVersion.ForeColor = System.Drawing.Color.Gray;
            this.lb_ConnectionDatabaseVersion.Location = new System.Drawing.Point(83, 343);
            this.lb_ConnectionDatabaseVersion.Name = "lb_ConnectionDatabaseVersion";
            this.lb_ConnectionDatabaseVersion.Size = new System.Drawing.Size(71, 20);
            this.lb_ConnectionDatabaseVersion.TabIndex = 12;
            this.lb_ConnectionDatabaseVersion.Text = "Uncheck";
            // 
            // ChooseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(694, 383);
            this.Controls.Add(this.lb_ConnectionDatabaseVersion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChooseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose database and configuration";
            this.Load += new System.EventHandler(this.ChooseForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_db;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_dbname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.Label lb_tips;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_ConnectionDatabaseVersion;
        private System.Windows.Forms.Label lb_ConnectionDataSouece;
        private System.Windows.Forms.Label lb_ConnectionTimeOut;
        private System.Windows.Forms.Label lb_ConnectionURL;

    }
}