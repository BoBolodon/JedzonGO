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
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
            OdswiezOstatnie();
        }

        private void ShowMain(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void losu_button_Click(object sender, EventArgs e)
        {
            string name;
            name =Losuj();

            while(name == LastMealLabel.Text)
            {
                //MessageBox.Show(name);
                name = Losuj();
            }
            //MessageBox.Show(name);
            Meal_Form Meal = new Meal_Form();
            Meal.ShowMeal(name);
            Meal.Show();
            this.Hide();
            Meal.FormClosing += ShowMain;
        }
        public string Losuj()
        {
            string[] list = Directory.GetFiles(@".\Meals", "*.txt");
            Random rnd = new Random();
            int r = rnd.Next(list.Length);
            string name = (Path.GetFileNameWithoutExtension((string)list[r]));
            return name;
        }


        private void add_button_Click(object sender, EventArgs e)
        {
            Add_Form Add = new Add_Form();
            Add.Show();
            this.Hide();
            Add.FormClosing += ShowMain;
        }

        private void about_button_Click(object sender, EventArgs e)
        {
            About_Form About = new About_Form();
            About.Show();
            this.Hide();
            About.FormClosing += ShowMain;
        }

        private void help_button_Click(object sender, EventArgs e)
        {
            History_Form History = new History_Form();
            History.Show();
            this.Hide();
            History.FormClosing += ShowMain;
        }

        private void list_button_Click(object sender, EventArgs e)
        {
            List_Form List = new List_Form();
            List.Show();
            this.Hide();
            List.FormClosing += ShowMain;
        }

        public void OdswiezOstatnie()
        {
            string path = @".\History.txt";

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    LastMealLabel.Text = "---------";

                }
            }
            else
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    LastMealLabel.Text = File.ReadLines(@".\History.txt").Last();
                }
            }
        }
    }
}
