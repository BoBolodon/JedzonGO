namespace JedzonGO
{
    partial class Add_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Form));
            this.label2 = new System.Windows.Forms.Label();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ingredient_textBox = new System.Windows.Forms.TextBox();
            this.addIngredient_button = new System.Windows.Forms.Button();
            this.addMeal_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.picture_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nazwa dania";
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(108, 9);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(198, 25);
            this.name_textBox.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(8, 75);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(298, 232);
            this.listBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Składniki";
            // 
            // ingredient_textBox
            // 
            this.ingredient_textBox.Location = new System.Drawing.Point(8, 355);
            this.ingredient_textBox.Name = "ingredient_textBox";
            this.ingredient_textBox.Size = new System.Drawing.Size(162, 25);
            this.ingredient_textBox.TabIndex = 5;
            // 
            // addIngredient_button
            // 
            this.addIngredient_button.Location = new System.Drawing.Point(186, 355);
            this.addIngredient_button.Name = "addIngredient_button";
            this.addIngredient_button.Size = new System.Drawing.Size(120, 25);
            this.addIngredient_button.TabIndex = 6;
            this.addIngredient_button.Text = "Dodaj składnik";
            this.addIngredient_button.UseVisualStyleBackColor = true;
            this.addIngredient_button.Click += new System.EventHandler(this.addIngredient_button_Click);
            // 
            // addMeal_button
            // 
            this.addMeal_button.Location = new System.Drawing.Point(7, 469);
            this.addMeal_button.Name = "addMeal_button";
            this.addMeal_button.Size = new System.Drawing.Size(121, 36);
            this.addMeal_button.TabIndex = 7;
            this.addMeal_button.Text = "Dodaj Danie";
            this.addMeal_button.UseVisualStyleBackColor = true;
            this.addMeal_button.Click += new System.EventHandler(this.addMeal_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(8, 313);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(120, 25);
            this.clear_button.TabIndex = 8;
            this.clear_button.Text = "Wyczyść listę";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(186, 313);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(120, 25);
            this.delete_button.TabIndex = 9;
            this.delete_button.Text = "Usuń składnik";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // picture_button
            // 
            this.picture_button.Location = new System.Drawing.Point(8, 407);
            this.picture_button.Name = "picture_button";
            this.picture_button.Size = new System.Drawing.Size(121, 36);
            this.picture_button.TabIndex = 10;
            this.picture_button.Text = "Dodaj Zdjęcie";
            this.picture_button.UseVisualStyleBackColor = true;
            this.picture_button.Click += new System.EventHandler(this.picture_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(186, 407);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 98);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Add_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(318, 516);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picture_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.addMeal_button);
            this.Controls.Add(this.addIngredient_button);
            this.Controls.Add(this.ingredient_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Add_Form";
            this.Text = "Dodaj danie";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ingredient_textBox;
        private System.Windows.Forms.Button addIngredient_button;
        private System.Windows.Forms.Button addMeal_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button picture_button;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}