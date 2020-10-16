namespace PecurkiApp2
{
    partial class FormVid
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aplikacijaPecurkiDataSet = new PecurkiApp2.AplikacijaPecurkiDataSet();
            this.aplikacijaPecurkiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aplikacijaPecurkiDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplikacijaPecurkiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplikacijaPecurkiDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplikacijaPecurkiDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(184, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(347, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(43, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Избери име на \r\nпечурка:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(587, 173);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // aplikacijaPecurkiDataSet
            // 
            this.aplikacijaPecurkiDataSet.DataSetName = "AplikacijaPecurkiDataSet";
            this.aplikacijaPecurkiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aplikacijaPecurkiDataSetBindingSource
            // 
            this.aplikacijaPecurkiDataSetBindingSource.DataSource = this.aplikacijaPecurkiDataSet;
            this.aplikacijaPecurkiDataSetBindingSource.Position = 0;
            // 
            // aplikacijaPecurkiDataSetBindingSource1
            // 
            this.aplikacijaPecurkiDataSetBindingSource1.DataSource = this.aplikacijaPecurkiDataSet;
            this.aplikacijaPecurkiDataSetBindingSource1.Position = 0;
            // 
            // FormVid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(617, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "FormVid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vidovi Pecurki";
            this.Load += new System.EventHandler(this.FormVid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplikacijaPecurkiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplikacijaPecurkiDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplikacijaPecurkiDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource aplikacijaPecurkiDataSetBindingSource;
        private AplikacijaPecurkiDataSet aplikacijaPecurkiDataSet;
        private System.Windows.Forms.BindingSource aplikacijaPecurkiDataSetBindingSource1;
    }
}