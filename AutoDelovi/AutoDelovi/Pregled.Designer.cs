namespace AutoDelovi
{
    partial class Pregled
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.b_search = new System.Windows.Forms.Button();
            this.rb_katbr = new System.Windows.Forms.RadioButton();
            this.rb_kateg = new System.Windows.Forms.RadioButton();
            this.cb_kateg = new System.Windows.Forms.ComboBox();
            this.txt_katbr = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(860, 581);
            this.dataGridView1.TabIndex = 0;
            // 
            // b_search
            // 
            this.b_search.Location = new System.Drawing.Point(508, 8);
            this.b_search.Name = "b_search";
            this.b_search.Size = new System.Drawing.Size(103, 23);
            this.b_search.TabIndex = 1;
            this.b_search.Text = "Tragaj";
            this.b_search.UseVisualStyleBackColor = true;
            this.b_search.Click += new System.EventHandler(this.B_search_Click);
            // 
            // rb_katbr
            // 
            this.rb_katbr.AutoSize = true;
            this.rb_katbr.Location = new System.Drawing.Point(12, 12);
            this.rb_katbr.Name = "rb_katbr";
            this.rb_katbr.Size = new System.Drawing.Size(88, 17);
            this.rb_katbr.TabIndex = 2;
            this.rb_katbr.Text = "Kataloski broj";
            this.rb_katbr.UseVisualStyleBackColor = true;
            this.rb_katbr.CheckedChanged += new System.EventHandler(this.Rb_katbr_CheckedChanged);
            // 
            // rb_kateg
            // 
            this.rb_kateg.AutoSize = true;
            this.rb_kateg.Location = new System.Drawing.Point(253, 12);
            this.rb_kateg.Name = "rb_kateg";
            this.rb_kateg.Size = new System.Drawing.Size(72, 17);
            this.rb_kateg.TabIndex = 4;
            this.rb_kateg.Text = "Kategorija";
            this.rb_kateg.UseVisualStyleBackColor = true;
            this.rb_kateg.CheckedChanged += new System.EventHandler(this.Rb_kateg_CheckedChanged);
            // 
            // cb_kateg
            // 
            this.cb_kateg.DisplayMember = "1";
            this.cb_kateg.FormattingEnabled = true;
            this.cb_kateg.Location = new System.Drawing.Point(331, 12);
            this.cb_kateg.Name = "cb_kateg";
            this.cb_kateg.Size = new System.Drawing.Size(121, 21);
            this.cb_kateg.TabIndex = 5;
            this.cb_kateg.ValueMember = "d";
            // 
            // txt_katbr
            // 
            this.txt_katbr.Location = new System.Drawing.Point(106, 11);
            this.txt_katbr.Name = "txt_katbr";
            this.txt_katbr.Size = new System.Drawing.Size(121, 20);
            this.txt_katbr.TabIndex = 6;
            this.txt_katbr.Text = "1111";
            // 
            // Pregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 641);
            this.Controls.Add(this.txt_katbr);
            this.Controls.Add(this.cb_kateg);
            this.Controls.Add(this.rb_kateg);
            this.Controls.Add(this.rb_katbr);
            this.Controls.Add(this.b_search);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 680);
            this.MinimumSize = new System.Drawing.Size(900, 680);
            this.Name = "Pregled";
            this.ShowIcon = false;
            this.Text = "P r e g l e d";
            this.Load += new System.EventHandler(this.Pregled_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button b_search;
        private System.Windows.Forms.RadioButton rb_katbr;
        private System.Windows.Forms.RadioButton rb_kateg;
        private System.Windows.Forms.ComboBox cb_kateg;
        private System.Windows.Forms.TextBox txt_katbr;
    }
}