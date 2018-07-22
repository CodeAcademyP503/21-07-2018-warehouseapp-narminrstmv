namespace ShopMenecment
{
    partial class Xutor1
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
            this.btnhesabla = new System.Windows.Forms.Button();
            this.magazaaadi = new System.Windows.Forms.Label();
            this.checkBoxXutor1 = new System.Windows.Forms.CheckBox();
            this.BTNLOGOUT = new System.Windows.Forms.Button();
            this.DGWAdmin = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGWAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnhesabla
            // 
            this.btnhesabla.Location = new System.Drawing.Point(767, 302);
            this.btnhesabla.Name = "btnhesabla";
            this.btnhesabla.Size = new System.Drawing.Size(75, 23);
            this.btnhesabla.TabIndex = 9;
            this.btnhesabla.Text = "Hesabla";
            this.btnhesabla.UseVisualStyleBackColor = true;
            // 
            // magazaaadi
            // 
            this.magazaaadi.AutoSize = true;
            this.magazaaadi.Location = new System.Drawing.Point(863, 111);
            this.magazaaadi.Name = "magazaaadi";
            this.magazaaadi.Size = new System.Drawing.Size(62, 13);
            this.magazaaadi.TabIndex = 8;
            this.magazaaadi.Text = "Mağaza adı";
            // 
            // checkBoxXutor1
            // 
            this.checkBoxXutor1.AutoSize = true;
            this.checkBoxXutor1.Location = new System.Drawing.Point(866, 141);
            this.checkBoxXutor1.Name = "checkBoxXutor1";
            this.checkBoxXutor1.Size = new System.Drawing.Size(57, 17);
            this.checkBoxXutor1.TabIndex = 7;
            this.checkBoxXutor1.Text = "Xutor1";
            this.checkBoxXutor1.UseVisualStyleBackColor = true;
            // 
            // BTNLOGOUT
            // 
            this.BTNLOGOUT.Location = new System.Drawing.Point(850, 21);
            this.BTNLOGOUT.Name = "BTNLOGOUT";
            this.BTNLOGOUT.Size = new System.Drawing.Size(75, 23);
            this.BTNLOGOUT.TabIndex = 6;
            this.BTNLOGOUT.Text = "Log out";
            this.BTNLOGOUT.UseVisualStyleBackColor = true;
            this.BTNLOGOUT.Click += new System.EventHandler(this.BTNLOGOUT_Click_1);
            // 
            // DGWAdmin
            // 
            this.DGWAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGWAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column5});
            this.DGWAdmin.Location = new System.Drawing.Point(12, 111);
            this.DGWAdmin.Name = "DGWAdmin";
            this.DGWAdmin.Size = new System.Drawing.Size(830, 167);
            this.DGWAdmin.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ad";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Soyad";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Vəzifə";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Əmək haqqı";
            this.Column4.Name = "Column4";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Plan";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Bonus";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Yekun";
            this.Column8.Name = "Column8";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Dövriyyə";
            this.Column5.Name = "Column5";
            // 
            // Xutor1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 496);
            this.Controls.Add(this.btnhesabla);
            this.Controls.Add(this.magazaaadi);
            this.Controls.Add(this.checkBoxXutor1);
            this.Controls.Add(this.BTNLOGOUT);
            this.Controls.Add(this.DGWAdmin);
            this.Name = "Xutor1";
            this.Text = "Xutor1";
            this.Load += new System.EventHandler(this.Xutor1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGWAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnhesabla;
        private System.Windows.Forms.Label magazaaadi;
        private System.Windows.Forms.CheckBox checkBoxXutor1;
        private System.Windows.Forms.Button BTNLOGOUT;
        private System.Windows.Forms.DataGridView DGWAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}