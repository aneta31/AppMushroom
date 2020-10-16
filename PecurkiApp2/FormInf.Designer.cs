namespace PecurkiApp2
{
    partial class FormInf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInf));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.општиИнформацииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.здравјеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.спортИРекреацијаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рецептиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.другоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.општиИнформацииToolStripMenuItem,
            this.другоToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // општиИнформацииToolStripMenuItem
            // 
            this.општиИнформацииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.здравјеToolStripMenuItem,
            this.спортИРекреацијаToolStripMenuItem,
            this.рецептиToolStripMenuItem});
            this.општиИнформацииToolStripMenuItem.Name = "општиИнформацииToolStripMenuItem";
            this.општиИнформацииToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.општиИнформацииToolStripMenuItem.Text = "Општи информации";
            // 
            // здравјеToolStripMenuItem
            // 
            this.здравјеToolStripMenuItem.Name = "здравјеToolStripMenuItem";
            this.здравјеToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.здравјеToolStripMenuItem.Text = "Здравје";
            this.здравјеToolStripMenuItem.Click += new System.EventHandler(this.Zdravje_Click);
            // 
            // спортИРекреацијаToolStripMenuItem
            // 
            this.спортИРекреацијаToolStripMenuItem.Name = "спортИРекреацијаToolStripMenuItem";
            this.спортИРекреацијаToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.спортИРекреацијаToolStripMenuItem.Text = "Спорт и рекреација";
            this.спортИРекреацијаToolStripMenuItem.Click += new System.EventHandler(this.Sport_Click);
            // 
            // рецептиToolStripMenuItem
            // 
            this.рецептиToolStripMenuItem.Name = "рецептиToolStripMenuItem";
            this.рецептиToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.рецептиToolStripMenuItem.Text = "Рецепти";
            this.рецептиToolStripMenuItem.Click += new System.EventHandler(this.Recepti_Click);
            // 
            // другоToolStripMenuItem
            // 
            this.другоToolStripMenuItem.Name = "другоToolStripMenuItem";
            this.другоToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.другоToolStripMenuItem.Text = "Фотографии";
            this.другоToolStripMenuItem.Click += new System.EventHandler(this.Sliki_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(640, 418);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(148, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 376);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FormInf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormInf";
            this.Text = "Информации";
            this.Load += new System.EventHandler(this.FormInf_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem општиИнформацииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem здравјеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem спортИРекреацијаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рецептиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem другоToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}