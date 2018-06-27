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
    public partial class Meal_Form : Form
    {
        public Meal_Form()
        {
            InitializeComponent();
        }

        string name_jem;
        public void ShowMeal(string name)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            string pictureplaceholder = @".\Meals\" +"placeholder"+ ".png";
            string path = @".\Meals\" + name + ".txt";
            string picturepath = @".\Meals\" + name + ".jpg";

            if (!File.Exists(path))
            {
                MessageBox.Show("Brak pliku przepisu", "Błąd");
            }
            else
            {
                if (File.Exists(picturepath))
                {
                    pictureBox1.ImageLocation = picturepath;
                }
                else
                {
                    pictureBox1.ImageLocation = pictureplaceholder;
                }

                name_label.Text = name;
                string[] lines = File.ReadAllLines(path);
                listBox1.Items.AddRange(lines);

                name_jem = name;
            }
        }

        private void eat_button_Click(object sender, EventArgs e)
        {
            string path = @".\History.txt";

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(name_jem);

                }
            }

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(name_jem);

            }

            Main_Form Main = (Main_Form)Application.OpenForms["Main_Form"];
            Main.OdswiezOstatnie();
            this.Close();
        }
    }
}

