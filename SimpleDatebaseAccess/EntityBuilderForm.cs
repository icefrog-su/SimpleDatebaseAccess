using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleDatebaseAccess
{
    public partial class EntityBuilderForm : Form
    {
        private string tableName;
        private const string JAVA = "Java";
        private const string CS = "C#";
        public EntityBuilderForm(string tabName)
        {
            InitializeComponent();
            this.tableName = tabName;
        }

        private void EntityBuilderForm_Load(object sender, EventArgs e)
        {
            cbo_language.Items.Add(JAVA);
            cbo_language.Items.Add(CS);
            cbo_language.SelectedIndex = 0;

            cbo_reg.Items.Add("按照数据库字段命名");
            cbo_reg.Items.Add("首字母大写命名");
            cbo_reg.Items.Add("全大写");
            cbo_reg.Items.Add("全小写");
            cbo_reg.SelectedIndex = 0;

            txt_ClassName.Text = this.tableName;
            txt_stuff.Text = ".java";

            
        }

        private void cbo_language_SelectedIndexChanged(object sender, EventArgs e)
        {
            string className = txt_ClassName.Text;
            if (cbo_language.SelectedIndex == 0)
            {
                txt_stuff.Text = className+".java";
                txt_quoteUrl.Text = "import org.user.project";
            }
            else if (cbo_language.SelectedIndex == 1)
            {
                txt_stuff.Text = className + ".cs";
                txt_quoteUrl.Text = "namespace ProjectName";
            }
        }

        private void txt_quoteUrl_MouseClick(object sender, MouseEventArgs e)
        {
            txt_quoteUrl.SelectAll();
            txt_quoteUrl.Focus();
        }

        private void cbo_reg_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbo_reg.Items.Add("按照数据库字段命名");
            //cbo_reg.Items.Add("首字母大写命名");
            //cbo_reg.Items.Add("全大写");
            //cbo_reg.Items.Add("全小写");
            if (cbo_reg.SelectedIndex == 0)
            {
                txt_ClassName.Text = this.tableName;
                if (cbo_language.SelectedIndex == 0)
                    txt_stuff.Text = txt_ClassName.Text + ".java";
                else if(cbo_language.SelectedIndex == 1)
                    txt_stuff.Text = txt_ClassName.Text + ".cs";
            }
            else if(cbo_reg.SelectedIndex == 1)
            {
                string className = txt_ClassName.Text;
                if (className.Length == 1)
                {
                    txt_ClassName.Text = className.ToUpper();
                }
                else if (className.Length > 1)
                {
                    //student
                    string head = className.Substring(0,1);
                    Console.WriteLine("截取到的第一个字符为:"+head);
                    string body = className.Substring(1,className.Length-1);
                    Console.WriteLine("尾部："+body);
                    string result = head.ToUpper() + body.ToLower();
                    Console.WriteLine("结果:"+result);
                    txt_ClassName.Text = result;
                }
                if (cbo_language.SelectedIndex == 0)
                    txt_stuff.Text = txt_ClassName.Text + ".java";
                else if (cbo_language.SelectedIndex == 1)
                    txt_stuff.Text = txt_ClassName.Text + ".cs";
            }
            else if(cbo_reg.SelectedIndex == 2){
                txt_ClassName.Text = txt_ClassName.Text.ToUpper();
                if (cbo_language.SelectedIndex == 0)
                    txt_stuff.Text = txt_ClassName.Text + ".java";
                else if (cbo_language.SelectedIndex == 1)
                    txt_stuff.Text = txt_ClassName.Text + ".cs";
            }
            else if(cbo_reg.SelectedIndex == 3)
            {
                txt_ClassName.Text = txt_ClassName.Text.ToLower();
                if (cbo_language.SelectedIndex == 0)
                    txt_stuff.Text = txt_ClassName.Text + ".java";
                else if (cbo_language.SelectedIndex == 1)
                    txt_stuff.Text = txt_ClassName.Text + ".cs";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            DialogResult dr = folder.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.Cancel)
                return;
            string path = folder.SelectedPath;
            txt_savePath.Text = path;
        }
    }
}
