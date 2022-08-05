namespace Aurora_sees_fire
{
    partial class MeniuJoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeniuJoc));
            this.play = new System.Windows.Forms.Button();
            this.titlu = new System.Windows.Forms.Label();
            this.despre = new System.Windows.Forms.Button();
            this.instructiuni = new System.Windows.Forms.Button();
            this.iesire = new System.Windows.Forms.Button();
            this.autentificare_utilizatori = new System.Windows.Forms.Button();
            this.panou_control_utilizatori = new System.Windows.Forms.Button();
            this.database1DataSet = new Aurora_sees_fire.Database1DataSet();
            this.utilizatoriTableAdapter = new Aurora_sees_fire.Database1DataSetTableAdapters.UtilizatoriTableAdapter();
            this.utilizatoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new Aurora_sees_fire.Database1DataSetTableAdapters.TableAdapterManager();
            this.autentificare_administratori = new System.Windows.Forms.Button();
            this.utilizatoriBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new Aurora_sees_fire.Database1DataSet1();
            this.utilizatoriTableAdapter1 = new Aurora_sees_fire.Database1DataSet1TableAdapters.UtilizatoriTableAdapter();
            this.tableAdapterManager1 = new Aurora_sees_fire.Database1DataSet1TableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.Color.Transparent;
            this.play.FlatAppearance.BorderSize = 0;
            this.play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play.Font = new System.Drawing.Font("Microsoft Uighur", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play.ForeColor = System.Drawing.SystemColors.Window;
            this.play.Location = new System.Drawing.Point(530, 259);
            this.play.Margin = new System.Windows.Forms.Padding(0);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(134, 50);
            this.play.TabIndex = 8;
            this.play.Text = "PLAY";
            this.play.UseVisualStyleBackColor = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // titlu
            // 
            this.titlu.AutoSize = true;
            this.titlu.BackColor = System.Drawing.Color.Transparent;
            this.titlu.Font = new System.Drawing.Font("Microsoft Uighur", 55.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlu.ForeColor = System.Drawing.SystemColors.Window;
            this.titlu.Location = new System.Drawing.Point(353, 155);
            this.titlu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titlu.Name = "titlu";
            this.titlu.Size = new System.Drawing.Size(445, 120);
            this.titlu.TabIndex = 7;
            this.titlu.Text = "Aurora sees fire";
            this.titlu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // despre
            // 
            this.despre.BackColor = System.Drawing.Color.Transparent;
            this.despre.FlatAppearance.BorderSize = 0;
            this.despre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.despre.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.despre.ForeColor = System.Drawing.SystemColors.Window;
            this.despre.Location = new System.Drawing.Point(900, 21);
            this.despre.Margin = new System.Windows.Forms.Padding(0);
            this.despre.Name = "despre";
            this.despre.Size = new System.Drawing.Size(127, 44);
            this.despre.TabIndex = 6;
            this.despre.Text = "DESPRE";
            this.despre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.despre.UseVisualStyleBackColor = false;
            this.despre.Click += new System.EventHandler(this.despre_Click);
            // 
            // instructiuni
            // 
            this.instructiuni.BackColor = System.Drawing.Color.Transparent;
            this.instructiuni.FlatAppearance.BorderSize = 0;
            this.instructiuni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instructiuni.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructiuni.ForeColor = System.Drawing.SystemColors.Window;
            this.instructiuni.Location = new System.Drawing.Point(136, 25);
            this.instructiuni.Margin = new System.Windows.Forms.Padding(0);
            this.instructiuni.Name = "instructiuni";
            this.instructiuni.Size = new System.Drawing.Size(205, 50);
            this.instructiuni.TabIndex = 2;
            this.instructiuni.Text = "INSTRUCTIUNI";
            this.instructiuni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.instructiuni.UseVisualStyleBackColor = false;
            this.instructiuni.Click += new System.EventHandler(this.instructiuni_Click);
            // 
            // iesire
            // 
            this.iesire.BackColor = System.Drawing.Color.Transparent;
            this.iesire.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iesire.BackgroundImage")));
            this.iesire.FlatAppearance.BorderSize = 0;
            this.iesire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iesire.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iesire.ForeColor = System.Drawing.Color.Transparent;
            this.iesire.Location = new System.Drawing.Point(64, 500);
            this.iesire.Margin = new System.Windows.Forms.Padding(4);
            this.iesire.Name = "iesire";
            this.iesire.Size = new System.Drawing.Size(128, 37);
            this.iesire.TabIndex = 9;
            this.iesire.Text = "IESIRE";
            this.iesire.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iesire.UseVisualStyleBackColor = false;
            this.iesire.Click += new System.EventHandler(this.iesire_Click);
            // 
            // autentificare_utilizatori
            // 
            this.autentificare_utilizatori.BackColor = System.Drawing.Color.Transparent;
            this.autentificare_utilizatori.FlatAppearance.BorderSize = 0;
            this.autentificare_utilizatori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.autentificare_utilizatori.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autentificare_utilizatori.ForeColor = System.Drawing.SystemColors.Window;
            this.autentificare_utilizatori.Location = new System.Drawing.Point(683, 451);
            this.autentificare_utilizatori.Margin = new System.Windows.Forms.Padding(4);
            this.autentificare_utilizatori.Name = "autentificare_utilizatori";
            this.autentificare_utilizatori.Size = new System.Drawing.Size(440, 39);
            this.autentificare_utilizatori.TabIndex = 10;
            this.autentificare_utilizatori.Text = "AUTENTIFICARE UTILIZATORI";
            this.autentificare_utilizatori.UseVisualStyleBackColor = false;
            this.autentificare_utilizatori.Click += new System.EventHandler(this.autentificare_utilizatori_Click);
            // 
            // panou_control_utilizatori
            // 
            this.panou_control_utilizatori.BackColor = System.Drawing.Color.Transparent;
            this.panou_control_utilizatori.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panou_control_utilizatori.FlatAppearance.BorderSize = 0;
            this.panou_control_utilizatori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.panou_control_utilizatori.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panou_control_utilizatori.ForeColor = System.Drawing.Color.White;
            this.panou_control_utilizatori.Location = new System.Drawing.Point(361, 28);
            this.panou_control_utilizatori.Margin = new System.Windows.Forms.Padding(4);
            this.panou_control_utilizatori.Name = "panou_control_utilizatori";
            this.panou_control_utilizatori.Size = new System.Drawing.Size(460, 47);
            this.panou_control_utilizatori.TabIndex = 11;
            this.panou_control_utilizatori.Text = "PANOU CONTROL UTILIZATORI";
            this.panou_control_utilizatori.UseVisualStyleBackColor = false;
            this.panou_control_utilizatori.Visible = false;
            this.panou_control_utilizatori.Click += new System.EventHandler(this.panou_control_utilizatori_Click);
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // utilizatoriTableAdapter
            // 
            this.utilizatoriTableAdapter.ClearBeforeFill = true;
            // 
            // utilizatoriBindingSource
            // 
            this.utilizatoriBindingSource.DataMember = "Utilizatori";
            this.utilizatoriBindingSource.DataSource = this.database1DataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Aurora_sees_fire.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtilizatoriTableAdapter = this.utilizatoriTableAdapter;
            // 
            // autentificare_administratori
            // 
            this.autentificare_administratori.BackColor = System.Drawing.Color.Transparent;
            this.autentificare_administratori.FlatAppearance.BorderSize = 0;
            this.autentificare_administratori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.autentificare_administratori.Font = new System.Drawing.Font("Microsoft Uighur", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autentificare_administratori.ForeColor = System.Drawing.SystemColors.Window;
            this.autentificare_administratori.Location = new System.Drawing.Point(840, 498);
            this.autentificare_administratori.Margin = new System.Windows.Forms.Padding(4);
            this.autentificare_administratori.Name = "autentificare_administratori";
            this.autentificare_administratori.Size = new System.Drawing.Size(268, 47);
            this.autentificare_administratori.TabIndex = 12;
            this.autentificare_administratori.Text = "AUTENTIFICARE ADMINISTRATORI";
            this.autentificare_administratori.UseVisualStyleBackColor = false;
            this.autentificare_administratori.Click += new System.EventHandler(this.autentificare_administratori_Click);
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
            // MeniuJoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1176, 558);
            this.Controls.Add(this.autentificare_administratori);
            this.Controls.Add(this.panou_control_utilizatori);
            this.Controls.Add(this.autentificare_utilizatori);
            this.Controls.Add(this.iesire);
            this.Controls.Add(this.play);
            this.Controls.Add(this.titlu);
            this.Controls.Add(this.despre);
            this.Controls.Add(this.instructiuni);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(900, 500);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1194, 605);
            this.MinimumSize = new System.Drawing.Size(1194, 605);
            this.Name = "MeniuJoc";
            this.Text = "Aurora sees fire";
            this.Load += new System.EventHandler(this.Meniu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button instructiuni;
        private System.Windows.Forms.Button despre;
        private System.Windows.Forms.Label titlu;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button iesire;
        private System.Windows.Forms.Button autentificare_utilizatori;
        private System.Windows.Forms.Button panou_control_utilizatori;
        private Database1DataSet database1DataSet;
        private Database1DataSetTableAdapters.UtilizatoriTableAdapter utilizatoriTableAdapter;
        private System.Windows.Forms.BindingSource utilizatoriBindingSource;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button autentificare_administratori;
        private System.Windows.Forms.BindingSource utilizatoriBindingSource1;
        private Database1DataSet1 database1DataSet1;
        private Database1DataSet1TableAdapters.UtilizatoriTableAdapter utilizatoriTableAdapter1;
        private Database1DataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
    }
}

