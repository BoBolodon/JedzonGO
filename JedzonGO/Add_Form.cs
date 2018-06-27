using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace JedzonGO
{
    public partial class Add_Form : Form
    {
        public Add_Form()
        {
            InitializeComponent();
        }

        string picturepath;

        private void addIngredient_button_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(ingredient_textBox.Text))
            {
                MessageBox.Show("Brak nazwy skłądnika","Błąd");
            }
            else
            {
                string ingredient;
                ingredient = ingredient_textBox.Text;
                listBox1.Items.Add(ingredient);
                ingredient_textBox.Clear();
            }
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void addMeal_button_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(name_textBox.Text)/*&& listBox1.Items.Count == 0*/)
            {
                //MessageBox.Show("Brak nazwy dania i składników", "Błąd");
                MessageBox.Show("Brak nazwy dania", "Błąd");
            }

            else
            {
                string name = name_textBox.Text;
                string path = @".\Meals\"+name+".txt";
                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        foreach(var listBoxItem in listBox1.Items)
                        sw.WriteLine(listBoxItem);

                        if(!string.IsNullOrWhiteSpace(picturepath))
                        {
                            //MessageBox.Show(picturepath);
                            File.Copy(picturepath, @".\Meals\" + name + ".jpg");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Takie danie już istnieje", "Błąd");
                }
            }
            this.Close();
        }

        private void picture_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "d:\\";
            openFileDialog1.Filter = "pliki obrazów (*.jpg)|*.jpg";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    System.IO.StreamReader sr = new
                    System.IO.StreamReader(openFileDialog1.FileName);
                    //MessageBox.Show(openFileDialog1.FileName);
                    picturepath = openFileDialog1.FileName;
                    sr.Close();
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.ImageLocation = picturepath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
    }
}
