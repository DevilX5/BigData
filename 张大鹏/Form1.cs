using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HTML=HtmlAgilityPack;

namespace 张大鹏
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "选择模版";
            ofd.Filter = "所有文件(*.*)|*.*";
            ofd.FilterIndex = 1;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = ofd.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //var filePath = textBox1.Text;
            var filePath =@"C:\Users\DX\Desktop\五级地理区域2017-12-04.htm";
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read))
            {
                var doc = new HTML.HtmlDocument();
                doc.Load(fs, Encoding.Default);
                var tables = doc.DocumentNode.Descendants("table");
            }
            ClearMemory();
        }

        protected void ClearMemory()
        {
            GC.Collect();
            GC.WaitForFullGCComplete();
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
