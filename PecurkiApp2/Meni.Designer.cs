namespace PecurkiApp2
{
    partial class Meni
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Meni));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.информацииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.нарачкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ценаНаОткупToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видовиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.одјаваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.информацииToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.видНаГабиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.нарачкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ценаНаОткупToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.одјаваToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.информацииToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(150, 26);
            // 
            // информацииToolStripMenuItem
            // 
            this.информацииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.нарачкаToolStripMenuItem});
            this.информацииToolStripMenuItem.Name = "информацииToolStripMenuItem";
            this.информацииToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.информацииToolStripMenuItem.Text = "Информации";
            // 
            // нарачкаToolStripMenuItem
            // 
            this.нарачкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ценаНаОткупToolStripMenuItem});
            this.нарачкаToolStripMenuItem.Name = "нарачкаToolStripMenuItem";
            this.нарачкаToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.нарачкаToolStripMenuItem.Text = "Нарачка";
            // 
            // ценаНаОткупToolStripMenuItem
            // 
            this.ценаНаОткупToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.видовиToolStripMenuItem});
            this.ценаНаОткупToolStripMenuItem.Name = "ценаНаОткупToolStripMenuItem";
            this.ценаНаОткупToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.ценаНаОткупToolStripMenuItem.Text = "Цена на Откуп";
            // 
            // видовиToolStripMenuItem
            // 
            this.видовиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.одјаваToolStripMenuItem});
            this.видовиToolStripMenuItem.Name = "видовиToolStripMenuItem";
            this.видовиToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.видовиToolStripMenuItem.Text = "Видови";
            // 
            // одјаваToolStripMenuItem
            // 
            this.одјаваToolStripMenuItem.Name = "одјаваToolStripMenuItem";
            this.одјаваToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.одјаваToolStripMenuItem.Text = "Одјава";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.информацииToolStripMenuItem1,
            this.видНаГабиToolStripMenuItem,
            this.нарачкиToolStripMenuItem,
            this.ценаНаОткупToolStripMenuItem1,
            this.одјаваToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(789, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // информацииToolStripMenuItem1
            // 
            this.информацииToolStripMenuItem1.Name = "информацииToolStripMenuItem1";
            this.информацииToolStripMenuItem1.Size = new System.Drawing.Size(97, 20);
            this.информацииToolStripMenuItem1.Text = "Информации ";
            this.информацииToolStripMenuItem1.Click += new System.EventHandler(this.Informacii_Click);
            // 
            // видНаГабиToolStripMenuItem
            // 
            this.видНаГабиToolStripMenuItem.Name = "видНаГабиToolStripMenuItem";
            this.видНаГабиToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.видНаГабиToolStripMenuItem.Text = "Вид на габи";
            this.видНаГабиToolStripMenuItem.Click += new System.EventHandler(this.Vid_Click);
            // 
            // нарачкиToolStripMenuItem
            // 
            this.нарачкиToolStripMenuItem.Name = "нарачкиToolStripMenuItem";
            this.нарачкиToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.нарачкиToolStripMenuItem.Text = "Нарачки";
            this.нарачкиToolStripMenuItem.Click += new System.EventHandler(this.Naracki_Click);
            // 
            // ценаНаОткупToolStripMenuItem1
            // 
            this.ценаНаОткупToolStripMenuItem1.Name = "ценаНаОткупToolStripMenuItem1";
            this.ценаНаОткупToolStripMenuItem1.Size = new System.Drawing.Size(99, 20);
            this.ценаНаОткупToolStripMenuItem1.Text = "Цена на Откуп";
            this.ценаНаОткупToolStripMenuItem1.Click += new System.EventHandler(this.Cena_Click);
            // 
            // одјаваToolStripMenuItem1
            // 
            this.одјаваToolStripMenuItem1.Name = "одјаваToolStripMenuItem1";
            this.одјаваToolStripMenuItem1.Size = new System.Drawing.Size(55, 20);
            this.одјаваToolStripMenuItem1.Text = "Одјава";
            this.одјаваToolStripMenuItem1.Click += new System.EventHandler(this.Odjava_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(668, 388);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 27);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(789, 394);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Meni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(789, 420);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Meni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главно Мени";
            this.Load += new System.EventHandler(this.Meni_Load);
            this.contextMenuStrip2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem информацииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem нарачкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ценаНаОткупToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видовиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem одјаваToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem информацииToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem видНаГабиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem нарачкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ценаНаОткупToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem одјаваToolStripMenuItem1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}