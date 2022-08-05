namespace Joc
{
    partial class Joc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Joc));
            this.Jucator = new System.Windows.Forms.PictureBox();
            this.Miscare_background = new System.Windows.Forms.Timer(this.components);
            this.Miscare_Stanga = new System.Windows.Forms.Timer(this.components);
            this.Miscare_Dreapta = new System.Windows.Forms.Timer(this.components);
            this.Miscare_Sus = new System.Windows.Forms.Timer(this.components);
            this.Miscare_Jos = new System.Windows.Forms.Timer(this.components);
            this.Miscare_glont = new System.Windows.Forms.Timer(this.components);
            this.Miscare_inamici = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.Miscare_glont_inamici = new System.Windows.Forms.Timer(this.components);
            this.scorelbl = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.levelbl = new System.Windows.Forms.Label();
            this.utilizatoriBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new Aurora_sees_fire.Database1DataSet1();
            this.utilizatoriTableAdapter1 = new Aurora_sees_fire.Database1DataSet1TableAdapters.UtilizatoriTableAdapter();
            this.tableAdapterManager1 = new Aurora_sees_fire.Database1DataSet1TableAdapters.TableAdapterManager();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Jucator)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // Jucator
            // 
            this.Jucator.BackColor = System.Drawing.Color.Transparent;
            this.Jucator.Image = ((System.Drawing.Image)(resources.GetObject("Jucator.Image")));
            this.Jucator.Location = new System.Drawing.Point(553, 442);
            this.Jucator.Margin = new System.Windows.Forms.Padding(4);
            this.Jucator.Name = "Jucator";
            this.Jucator.Size = new System.Drawing.Size(75, 126);
            this.Jucator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Jucator.TabIndex = 0;
            this.Jucator.TabStop = false;
            // 
            // Miscare_background
            // 
            this.Miscare_background.Enabled = true;
            this.Miscare_background.Interval = 10;
            this.Miscare_background.Tick += new System.EventHandler(this.Miscare_Background_Tick);
            // 
            // Miscare_Stanga
            // 
            this.Miscare_Stanga.Interval = 5;
            this.Miscare_Stanga.Tick += new System.EventHandler(this.Miscare_Stanga_Tick);
            // 
            // Miscare_Dreapta
            // 
            this.Miscare_Dreapta.Interval = 5;
            this.Miscare_Dreapta.Tick += new System.EventHandler(this.Miscare_Dreapta_Tick);
            // 
            // Miscare_Sus
            // 
            this.Miscare_Sus.Enabled = true;
            this.Miscare_Sus.Interval = 5;
            // 
            // Miscare_Jos
            // 
            this.Miscare_Jos.Enabled = true;
            this.Miscare_Jos.Interval = 5;
            // 
            // Miscare_glont
            // 
            this.Miscare_glont.Enabled = true;
            this.Miscare_glont.Interval = 10;
            this.Miscare_glont.Tick += new System.EventHandler(this.Miscare_glont_Tick);
            // 
            // Miscare_inamici
            // 
            this.Miscare_inamici.Enabled = true;
            this.Miscare_inamici.Tick += new System.EventHandler(this.Miscare_inamici_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(95, 52);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "IESIRE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(430, 253);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(319, 142);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PAUZA";
            this.groupBox1.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Location = new System.Drawing.Point(430, 114);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(319, 142);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GAME OVER";
            this.groupBox2.Visible = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Transparent;
            this.button4.Location = new System.Drawing.Point(100, 52);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 47);
            this.button4.TabIndex = 3;
            this.button4.Text = "IESIRE";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.MouseEnter += new System.EventHandler(this.button4_MouseEnter);
            this.button4.MouseHover += new System.EventHandler(this.button4_MouseHover);
            // 
            // Miscare_glont_inamici
            // 
            this.Miscare_glont_inamici.Enabled = true;
            this.Miscare_glont_inamici.Interval = 20;
            this.Miscare_glont_inamici.Tick += new System.EventHandler(this.Miscare_glont_inamici_Tick);
            // 
            // scorelbl
            // 
            this.scorelbl.AutoSize = true;
            this.scorelbl.BackColor = System.Drawing.Color.Transparent;
            this.scorelbl.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorelbl.ForeColor = System.Drawing.SystemColors.Window;
            this.scorelbl.Location = new System.Drawing.Point(147, 9);
            this.scorelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scorelbl.Name = "scorelbl";
            this.scorelbl.Size = new System.Drawing.Size(0, 53);
            this.scorelbl.TabIndex = 3;
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.Color.Transparent;
            this.score.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.ForeColor = System.Drawing.SystemColors.Window;
            this.score.Location = new System.Drawing.Point(14, 16);
            this.score.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(105, 49);
            this.score.TabIndex = 4;
            this.score.Text = "SCORE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(14, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 49);
            this.label1.TabIndex = 5;
            this.label1.Text = "LEVEL";
            // 
            // levelbl
            // 
            this.levelbl.AutoSize = true;
            this.levelbl.BackColor = System.Drawing.Color.Transparent;
            this.levelbl.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelbl.ForeColor = System.Drawing.SystemColors.Window;
            this.levelbl.Location = new System.Drawing.Point(139, 63);
            this.levelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.levelbl.Name = "levelbl";
            this.levelbl.Size = new System.Drawing.Size(0, 53);
            this.levelbl.TabIndex = 6;
            // 
            // utilizatoriBindingSource1
            // 
            this.utilizatoriBindingSource1.DataMember = "Utilizatori";
            this.utilizatoriBindingSource1.DataSource = this.database1DataSet1;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // utilizatoriTableAdapter1
            // 
            this.utilizatoriTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = Aurora_sees_fire.Database1DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.UtilizatoriTableAdapter = this.utilizatoriTableAdapter1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1040, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1084, 22);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1128, 22);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1128, 519);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(36, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(1127, 519);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(36, 33);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(1128, 519);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(36, 33);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 12;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Visible = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(1127, 519);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(36, 33);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 13;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Visible = false;
            // 
            // Joc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1176, 558);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.levelbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.score);
            this.Controls.Add(this.scorelbl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Jucator);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(900, 500);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1194, 605);
            this.MinimumSize = new System.Drawing.Size(1194, 605);
            this.Name = "Joc";
            this.Text = "  Aurora sees fire";
            this.TransparencyKey = System.Drawing.Color.LightPink;
            this.Load += new System.EventHandler(this.Joc_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Joc_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Joc_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Jucator)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Jucator;
        private System.Windows.Forms.Timer Miscare_background;
        private System.Windows.Forms.Timer Miscare_Stanga;
        private System.Windows.Forms.Timer Miscare_Dreapta;
        private System.Windows.Forms.Timer Miscare_Sus;
        private System.Windows.Forms.Timer Miscare_Jos;
        private System.Windows.Forms.Timer Miscare_glont;
        private System.Windows.Forms.Timer Miscare_inamici;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer Miscare_glont_inamici;
        private System.Windows.Forms.Label scorelbl;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label levelbl;
        private System.Windows.Forms.BindingSource utilizatoriBindingSource1;
        private Aurora_sees_fire.Database1DataSet1 database1DataSet1;
        private Aurora_sees_fire.Database1DataSet1TableAdapters.UtilizatoriTableAdapter utilizatoriTableAdapter1;
        private Aurora_sees_fire.Database1DataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}