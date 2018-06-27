namespace JedzonGO
{
    partial class Main_Form
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.add_button = new System.Windows.Forms.Button();
            this.LastMealLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.losu_button = new System.Windows.Forms.Button();
            this.about_button = new System.Windows.Forms.Button();
            this.history_button = new System.Windows.Forms.Button();
            this.list_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.add_button.Location = new System.Drawing.Point(12, 269);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(301, 48);
            this.add_button.TabIndex = 1;
            this.add_button.Text = "Dodaj Danie";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // LastMealLabel
            // 
            this.LastMealLabel.BackColor = System.Drawing.Color.White;
            this.LastMealLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LastMealLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LastMealLabel.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LastMealLabel.Location = new System.Drawing.Point(0, 471);
            this.LastMealLabel.Name = "LastMealLabel";
            this.LastMealLabel.Size = new System.Drawing.Size(325, 35);
            this.LastMealLabel.TabIndex = 2;
            this.LastMealLabel.Text = "Nazwa jedzonka";
            this.LastMealLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(-4, 448);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ostatnio Zjedzono";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // losu_button
            // 
            this.losu_button.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.losu_button.Location = new System.Drawing.Point(12, 161);
            this.losu_button.Name = "losu_button";
            this.losu_button.Size = new System.Drawing.Size(301, 48);
            this.losu_button.TabIndex = 4;
            this.losu_button.Text = "Losu Losu";
            this.losu_button.UseVisualStyleBackColor = true;
            this.losu_button.Click += new System.EventHandler(this.losu_button_Click);
            // 
            // about_button
            // 
            this.about_button.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.about_button.Location = new System.Drawing.Point(12, 323);
            this.about_button.Name = "about_button";
            this.about_button.Size = new System.Drawing.Size(301, 48);
            this.about_button.TabIndex = 5;
            this.about_button.Text = "O Programie";
            this.about_button.UseVisualStyleBackColor = true;
            this.about_button.Click += new System.EventHandler(this.about_button_Click);
            // 
            // history_button
            // 
            this.history_button.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.history_button.Location = new System.Drawing.Point(12, 377);
            this.history_button.Name = "history_button";
            this.history_button.Size = new System.Drawing.Size(301, 48);
            this.history_button.TabIndex = 6;
            this.history_button.Text = "Historia";
            this.history_button.UseVisualStyleBackColor = true;
            this.history_button.Click += new System.EventHandler(this.help_button_Click);
            // 
            // list_button
            // 
            this.list_button.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.list_button.Location = new System.Drawing.Point(12, 215);
            this.list_button.Name = "list_button";
            this.list_button.Size = new System.Drawing.Size(301, 48);
            this.list_button.TabIndex = 7;
            this.list_button.Text = "Spis Dań";
            this.list_button.UseVisualStyleBackColor = true;
            this.list_button.Click += new System.EventHandler(this.list_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JedzonGO.Properties.Resources.Napis;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 506);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.list_button);
            this.Controls.Add(this.history_button);
            this.Controls.Add(this.about_button);
            this.Controls.Add(this.losu_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LastMealLabel);
            this.Controls.Add(this.add_button);
            this.Font = new System.Drawing.Font("Tw Cen MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Form";
            this.Text = "JedzonGO";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Label LastMealLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button losu_button;
        private System.Windows.Forms.Button about_button;
        private System.Windows.Forms.Button history_button;
        private System.Windows.Forms.Button list_button;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

