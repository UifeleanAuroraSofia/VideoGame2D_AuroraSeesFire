
namespace Aurora_sees_fire
{
    partial class Autentificare
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.confirmare_logare = new System.Windows.Forms.Button();
            this.nu_am_cont = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.titlu = new System.Windows.Forms.Label();
            this.database1DataSet = new Aurora_sees_fire.Database1DataSet();
            this.utilizatoriTableAdapter = new Aurora_sees_fire.Database1DataSetTableAdapters.UtilizatoriTableAdapter();
            this.utilizatoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new Aurora_sees_fire.Database1DataSetTableAdapters.TableAdapterManager();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.confirmare_logare);
            this.panel1.Controls.Add(this.nu_am_cont);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.titlu);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 287);
            this.panel1.TabIndex = 0;
            // 
            // confirmare_logare
            // 
            this.confirmare_logare.FlatAppearance.BorderSize = 0;
            this.confirmare_logare.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.confirmare_logare.Font = new System.Drawing.Font("Microsoft Uighur", 18F);
            this.confirmare_logare.ForeColor = System.Drawing.SystemColors.Window;
            this.confirmare_logare.Location = new System.Drawing.Point(132, 193);
            this.confirmare_logare.Margin = new System.Windows.Forms.Padding(4);
            this.confirmare_logare.Name = "confirmare_logare";
            this.confirmare_logare.Size = new System.Drawing.Size(137, 48);
            this.confirmare_logare.TabIndex = 6;
            this.confirmare_logare.Text = "Confirmare";
            this.confirmare_logare.UseVisualStyleBackColor = true;
            this.confirmare_logare.Click += new System.EventHandler(this.confirmare_logare_Click);
            // 
            // nu_am_cont
            // 
            this.nu_am_cont.AutoSize = true;
            this.nu_am_cont.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nu_am_cont.ForeColor = System.Drawing.SystemColors.Window;
            this.nu_am_cont.Location = new System.Drawing.Point(15, 250);
            this.nu_am_cont.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nu_am_cont.Name = "nu_am_cont";
            this.nu_am_cont.Size = new System.Drawing.Size(109, 37);
            this.nu_am_cont.TabIndex = 5;
            this.nu_am_cont.Text = "Nu am cont";
            this.nu_am_cont.Click += new System.EventHandler(this.nu_am_cont_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(15, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 40);
            this.label3.TabIndex = 4;
            this.label3.Text = "Parola";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(132, 129);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(221, 32);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(132, 75);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 32);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(15, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // titlu
            // 
            this.titlu.AutoSize = true;
            this.titlu.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlu.ForeColor = System.Drawing.SystemColors.Window;
            this.titlu.Location = new System.Drawing.Point(103, 16);
            this.titlu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titlu.Name = "titlu";
            this.titlu.Size = new System.Drawing.Size(185, 43);
            this.titlu.TabIndex = 0;
            this.titlu.Text = "Logheaza-te aici :)";
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
            // Autentificare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Aurora_sees_fire.Properties.Resources.autentificare_inregistrare;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(440, 320);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(400, 300);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(440, 320);
            this.MinimumSize = new System.Drawing.Size(440, 320);
            this.Name = "Autentificare";
            this.Text = "Autentificare";
            this.Load += new System.EventHandler(this.Autentificare_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label titlu;
        private System.Windows.Forms.Button confirmare_logare;
        private System.Windows.Forms.Label nu_am_cont;
        private Database1DataSet database1DataSet;
        private Database1DataSetTableAdapters.UtilizatoriTableAdapter utilizatoriTableAdapter;
        private System.Windows.Forms.BindingSource utilizatoriBindingSource;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}