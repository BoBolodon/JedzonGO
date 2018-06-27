using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace JedzonGO
{
    public partial class List_Form : Form
    {
        public List_Form()
        {
            InitializeComponent();
            ShowList();
        }

        public void ShowList()
        {
            string[] list = Directory.GetFiles(@".\Meals", "*.txt");

            foreach (string name in list)
            {
                listBox1.Items.Add(Path.GetFileNameWithoutExtension(name));
            }
        }


    }
}
