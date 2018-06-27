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
    public partial class History_Form : Form
    {
        public History_Form()
        {
            InitializeComponent();
            ShowHistory();
        }

        public void ShowHistory()
        {
            foreach (string line in File.ReadLines(@".\History.txt").Reverse())
            {
                listBox1.Items.Add(line);
            }
        }
    }
}
