namespace SimpleDatebaseAccess
{
    partial class EntityBuilderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntityBuilderForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_language = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ClassName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_savePath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_quoteUrl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_stuff = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_reg = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richCode = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.cbo_reg);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_stuff);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_quoteUrl);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txt_savePath);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_ClassName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbo_language);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.ForeColor = System.Drawing.Color.Gray;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuration information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择语言 :";
            // 
            // cbo_language
            // 
            this.cbo_language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_language.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_language.FormattingEnabled = true;
            this.cbo_language.Location = new System.Drawing.Point(115, 30);
            this.cbo_language.Name = "cbo_language";
            this.cbo_language.Size = new System.Drawing.Size(179, 28);
            this.cbo_language.TabIndex = 1;
            this.cbo_language.SelectedIndexChanged += new System.EventHandler(this.cbo_language_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "类名 :";
            // 
            // txt_ClassName
            // 
            this.txt_ClassName.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_ClassName.ForeColor = System.Drawing.Color.Teal;
            this.txt_ClassName.Location = new System.Drawing.Point(362, 29);
            this.txt_ClassName.Name = "txt_ClassName";
            this.txt_ClassName.Size = new System.Drawing.Size(171, 31);
            this.txt_ClassName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "保存路径 :";
            // 
            // txt_savePath
            // 
            this.txt_savePath.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_savePath.ForeColor = System.Drawing.Color.Teal;
            this.txt_savePath.Location = new System.Drawing.Point(115, 69);
            this.txt_savePath.Name = "txt_savePath";
            this.txt_savePath.Size = new System.Drawing.Size(535, 27);
            this.txt_savePath.TabIndex = 5;
            this.txt_savePath.Text = "C:/";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(654, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "浏览...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_quoteUrl
            // 
            this.txt_quoteUrl.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_quoteUrl.ForeColor = System.Drawing.Color.Gray;
            this.txt_quoteUrl.Location = new System.Drawing.Point(115, 102);
            this.txt_quoteUrl.Name = "txt_quoteUrl";
            this.txt_quoteUrl.Size = new System.Drawing.Size(187, 31);
            this.txt_quoteUrl.TabIndex = 8;
            this.txt_quoteUrl.Text = "namespace/package";
            this.txt_quoteUrl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_quoteUrl_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(32, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "引用地址 :";
            // 
            // txt_stuff
            // 
            this.txt_stuff.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_stuff.ForeColor = System.Drawing.Color.Teal;
            this.txt_stuff.Location = new System.Drawing.Point(584, 29);
            this.txt_stuff.Name = "txt_stuff";
            this.txt_stuff.Size = new System.Drawing.Size(171, 31);
            this.txt_stuff.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(536, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "后缀 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(308, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "属性名规则 :";
            // 
            // cbo_reg
            // 
            this.cbo_reg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_reg.FormattingEnabled = true;
            this.cbo_reg.Location = new System.Drawing.Point(406, 104);
            this.cbo_reg.Name = "cbo_reg";
            this.cbo_reg.Size = new System.Drawing.Size(179, 28);
            this.cbo_reg.TabIndex = 12;
            this.cbo_reg.SelectedIndexChanged += new System.EventHandler(this.cbo_reg_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richCode);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.ForeColor = System.Drawing.Color.Gray;
            this.groupBox2.Location = new System.Drawing.Point(0, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(768, 598);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Entity object code generation";
            // 
            // richCode
            // 
            this.richCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richCode.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richCode.Location = new System.Drawing.Point(3, 23);
            this.richCode.Name = "richCode";
            this.richCode.ReadOnly = true;
            this.richCode.Size = new System.Drawing.Size(762, 572);
            this.richCode.TabIndex = 0;
            this.richCode.Text = "Click the \' generate \' button to load the entity class code...\n\n";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(654, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 31);
            this.button2.TabIndex = 13;
            this.button2.Text = "生成  ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // EntityBuilderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 736);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EntityBuilderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entity Builder";
            this.Load += new System.EventHandler(this.EntityBuilderForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_language;
        private System.Windows.Forms.TextBox txt_ClassName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_savePath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_quoteUrl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_stuff;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbo_reg;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richCode;
        private System.Windows.Forms.Button button2;
    }
}