namespace AutoDelovi
{
    partial class Glavna
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
            this.cmb_jedmer = new System.Windows.Forms.ComboBox();
            this.cmb_katego = new System.Windows.Forms.ComboBox();
            this.cmb_proizv = new System.Windows.Forms.ComboBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_jedmer = new System.Windows.Forms.Label();
            this.lbl_kat = new System.Windows.Forms.Label();
            this.lbl_proizv = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_first = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.txt_katbr = new System.Windows.Forms.TextBox();
            this.lbl_katbr = new System.Windows.Forms.Label();
            this.lbl_oebr = new System.Windows.Forms.Label();
            this.txt_oebr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_kol = new System.Windows.Forms.TextBox();
            this.lbl_naziv = new System.Windows.Forms.Label();
            this.txt_naziv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_bruto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_rabat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_pdv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_cena = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_neto = new System.Windows.Forms.TextBox();
            this.b_pregled = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_jedmer
            // 
            this.cmb_jedmer.FormattingEnabled = true;
            this.cmb_jedmer.Location = new System.Drawing.Point(91, 163);
            this.cmb_jedmer.Name = "cmb_jedmer";
            this.cmb_jedmer.Size = new System.Drawing.Size(318, 21);
            this.cmb_jedmer.TabIndex = 0;
            // 
            // cmb_katego
            // 
            this.cmb_katego.FormattingEnabled = true;
            this.cmb_katego.Location = new System.Drawing.Point(91, 219);
            this.cmb_katego.Name = "cmb_katego";
            this.cmb_katego.Size = new System.Drawing.Size(318, 21);
            this.cmb_katego.TabIndex = 1;
            // 
            // cmb_proizv
            // 
            this.cmb_proizv.FormattingEnabled = true;
            this.cmb_proizv.Location = new System.Drawing.Point(91, 246);
            this.cmb_proizv.Name = "cmb_proizv";
            this.cmb_proizv.Size = new System.Drawing.Size(318, 21);
            this.cmb_proizv.TabIndex = 2;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(63, 66);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(18, 13);
            this.lbl_id.TabIndex = 4;
            this.lbl_id.Text = "ID";
            // 
            // lbl_jedmer
            // 
            this.lbl_jedmer.AutoSize = true;
            this.lbl_jedmer.Location = new System.Drawing.Point(9, 171);
            this.lbl_jedmer.Name = "lbl_jedmer";
            this.lbl_jedmer.Size = new System.Drawing.Size(72, 13);
            this.lbl_jedmer.TabIndex = 5;
            this.lbl_jedmer.Text = "Jedinica mere";
            // 
            // lbl_kat
            // 
            this.lbl_kat.AutoSize = true;
            this.lbl_kat.Location = new System.Drawing.Point(27, 227);
            this.lbl_kat.Name = "lbl_kat";
            this.lbl_kat.Size = new System.Drawing.Size(54, 13);
            this.lbl_kat.TabIndex = 6;
            this.lbl_kat.Text = "Kategorija";
            // 
            // lbl_proizv
            // 
            this.lbl_proizv.AutoSize = true;
            this.lbl_proizv.Location = new System.Drawing.Point(19, 254);
            this.lbl_proizv.Name = "lbl_proizv";
            this.lbl_proizv.Size = new System.Drawing.Size(62, 13);
            this.lbl_proizv.TabIndex = 7;
            this.lbl_proizv.Text = "Proizvodjac";
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(91, 59);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(318, 20);
            this.txt_id.TabIndex = 9;
            // 
            // btn_first
            // 
            this.btn_first.Location = new System.Drawing.Point(22, 485);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(75, 23);
            this.btn_first.TabIndex = 10;
            this.btn_first.Text = "<<";
            this.btn_first.UseVisualStyleBackColor = true;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.Location = new System.Drawing.Point(22, 446);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(75, 23);
            this.btn_prev.TabIndex = 11;
            this.btn_prev.Text = "<";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(103, 465);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 23);
            this.btn_insert.TabIndex = 12;
            this.btn_insert.Text = "Dodaj";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(184, 465);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 13;
            this.btn_update.Text = "Izmeni";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(265, 465);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 14;
            this.btn_delete.Text = "Brisi";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(346, 446);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 15;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_last
            // 
            this.btn_last.Location = new System.Drawing.Point(346, 485);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(75, 23);
            this.btn_last.TabIndex = 16;
            this.btn_last.Text = ">>";
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // txt_katbr
            // 
            this.txt_katbr.Location = new System.Drawing.Point(91, 85);
            this.txt_katbr.Name = "txt_katbr";
            this.txt_katbr.Size = new System.Drawing.Size(318, 20);
            this.txt_katbr.TabIndex = 17;
            // 
            // lbl_katbr
            // 
            this.lbl_katbr.AutoSize = true;
            this.lbl_katbr.Location = new System.Drawing.Point(11, 92);
            this.lbl_katbr.Name = "lbl_katbr";
            this.lbl_katbr.Size = new System.Drawing.Size(70, 13);
            this.lbl_katbr.TabIndex = 18;
            this.lbl_katbr.Text = "Kataloski broj";
            // 
            // lbl_oebr
            // 
            this.lbl_oebr.AutoSize = true;
            this.lbl_oebr.Location = new System.Drawing.Point(39, 118);
            this.lbl_oebr.Name = "lbl_oebr";
            this.lbl_oebr.Size = new System.Drawing.Size(42, 13);
            this.lbl_oebr.TabIndex = 20;
            this.lbl_oebr.Text = "OE broj";
            // 
            // txt_oebr
            // 
            this.txt_oebr.Location = new System.Drawing.Point(91, 111);
            this.txt_oebr.Name = "txt_oebr";
            this.txt_oebr.Size = new System.Drawing.Size(318, 20);
            this.txt_oebr.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Kolicina";
            // 
            // txt_kol
            // 
            this.txt_kol.Location = new System.Drawing.Point(91, 190);
            this.txt_kol.Name = "txt_kol";
            this.txt_kol.Size = new System.Drawing.Size(318, 20);
            this.txt_kol.TabIndex = 21;
            // 
            // lbl_naziv
            // 
            this.lbl_naziv.AutoSize = true;
            this.lbl_naziv.Location = new System.Drawing.Point(47, 144);
            this.lbl_naziv.Name = "lbl_naziv";
            this.lbl_naziv.Size = new System.Drawing.Size(34, 13);
            this.lbl_naziv.TabIndex = 24;
            this.lbl_naziv.Text = "Naziv";
            // 
            // txt_naziv
            // 
            this.txt_naziv.Location = new System.Drawing.Point(91, 137);
            this.txt_naziv.Name = "txt_naziv";
            this.txt_naziv.Size = new System.Drawing.Size(318, 20);
            this.txt_naziv.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Bruto cena";
            // 
            // txt_bruto
            // 
            this.txt_bruto.Location = new System.Drawing.Point(91, 273);
            this.txt_bruto.Name = "txt_bruto";
            this.txt_bruto.Size = new System.Drawing.Size(318, 20);
            this.txt_bruto.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Rabat (%)";
            // 
            // txt_rabat
            // 
            this.txt_rabat.Location = new System.Drawing.Point(91, 299);
            this.txt_rabat.Name = "txt_rabat";
            this.txt_rabat.Size = new System.Drawing.Size(318, 20);
            this.txt_rabat.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "PDV (%)";
            // 
            // txt_pdv
            // 
            this.txt_pdv.Location = new System.Drawing.Point(91, 325);
            this.txt_pdv.Name = "txt_pdv";
            this.txt_pdv.Size = new System.Drawing.Size(318, 20);
            this.txt_pdv.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Cena";
            // 
            // txt_cena
            // 
            this.txt_cena.Enabled = false;
            this.txt_cena.Location = new System.Drawing.Point(91, 377);
            this.txt_cena.Name = "txt_cena";
            this.txt_cena.Size = new System.Drawing.Size(318, 20);
            this.txt_cena.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Neto cena";
            // 
            // txt_neto
            // 
            this.txt_neto.Enabled = false;
            this.txt_neto.Location = new System.Drawing.Point(91, 351);
            this.txt_neto.Name = "txt_neto";
            this.txt_neto.Size = new System.Drawing.Size(318, 20);
            this.txt_neto.TabIndex = 31;
            // 
            // b_pregled
            // 
            this.b_pregled.Location = new System.Drawing.Point(300, 12);
            this.b_pregled.Name = "b_pregled";
            this.b_pregled.Size = new System.Drawing.Size(127, 23);
            this.b_pregled.TabIndex = 35;
            this.b_pregled.Text = "Pregled";
            this.b_pregled.UseVisualStyleBackColor = true;
            this.b_pregled.Click += new System.EventHandler(this.b_pregled_Click);
            // 
            // Glavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 541);
            this.Controls.Add(this.b_pregled);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_cena);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_neto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_pdv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_rabat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_bruto);
            this.Controls.Add(this.lbl_naziv);
            this.Controls.Add(this.txt_naziv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_kol);
            this.Controls.Add(this.lbl_oebr);
            this.Controls.Add(this.txt_oebr);
            this.Controls.Add(this.lbl_katbr);
            this.Controls.Add(this.txt_katbr);
            this.Controls.Add(this.btn_last);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.btn_prev);
            this.Controls.Add(this.btn_first);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_proizv);
            this.Controls.Add(this.lbl_kat);
            this.Controls.Add(this.lbl_jedmer);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.cmb_proizv);
            this.Controls.Add(this.cmb_katego);
            this.Controls.Add(this.cmb_jedmer);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(455, 580);
            this.MinimumSize = new System.Drawing.Size(455, 580);
            this.Name = "Glavna";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A r t i k l i";
            this.Load += new System.EventHandler(this.Glavna_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_jedmer;
        private System.Windows.Forms.ComboBox cmb_katego;
        private System.Windows.Forms.ComboBox cmb_proizv;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_jedmer;
        private System.Windows.Forms.Label lbl_kat;
        private System.Windows.Forms.Label lbl_proizv;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.TextBox txt_katbr;
        private System.Windows.Forms.Label lbl_katbr;
        private System.Windows.Forms.Label lbl_oebr;
        private System.Windows.Forms.TextBox txt_oebr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_kol;
        private System.Windows.Forms.Label lbl_naziv;
        private System.Windows.Forms.TextBox txt_naziv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_bruto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_rabat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_pdv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_cena;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_neto;
        private System.Windows.Forms.Button b_pregled;
    }
}

