namespace Library
{
    partial class FormBookPlace
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
            this.labelBook = new System.Windows.Forms.Label();
            this.labelReader = new System.Windows.Forms.Label();
            this.labelLibrarian = new System.Windows.Forms.Label();
            this.comboBoxBook = new System.Windows.Forms.ComboBox();
            this.comboBoxReader = new System.Windows.Forms.ComboBox();
            this.comboBoxLibrarian = new System.Windows.Forms.ComboBox();
            this.listViewBookPlace = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBook
            // 
            this.labelBook.AutoSize = true;
            this.labelBook.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBook.Location = new System.Drawing.Point(20, 17);
            this.labelBook.Name = "labelBook";
            this.labelBook.Size = new System.Drawing.Size(138, 20);
            this.labelBook.TabIndex = 0;
            this.labelBook.Text = "Выберите книгу";
            // 
            // labelReader
            // 
            this.labelReader.AutoSize = true;
            this.labelReader.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReader.Location = new System.Drawing.Point(20, 80);
            this.labelReader.Name = "labelReader";
            this.labelReader.Size = new System.Drawing.Size(163, 20);
            this.labelReader.TabIndex = 1;
            this.labelReader.Text = "Выберите читателя";
            this.labelReader.Click += new System.EventHandler(this.labelReader_Click);
            // 
            // labelLibrarian
            // 
            this.labelLibrarian.AutoSize = true;
            this.labelLibrarian.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLibrarian.Location = new System.Drawing.Point(236, 18);
            this.labelLibrarian.Name = "labelLibrarian";
            this.labelLibrarian.Size = new System.Drawing.Size(206, 20);
            this.labelLibrarian.TabIndex = 2;
            this.labelLibrarian.Text = "Выберите библиотекаря";
            this.labelLibrarian.Click += new System.EventHandler(this.labelLibrarian_Click);
            // 
            // comboBoxBook
            // 
            this.comboBoxBook.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxBook.FormattingEnabled = true;
            this.comboBoxBook.Location = new System.Drawing.Point(24, 41);
            this.comboBoxBook.Name = "comboBoxBook";
            this.comboBoxBook.Size = new System.Drawing.Size(194, 24);
            this.comboBoxBook.TabIndex = 4;
            // 
            // comboBoxReader
            // 
            this.comboBoxReader.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxReader.FormattingEnabled = true;
            this.comboBoxReader.Location = new System.Drawing.Point(24, 104);
            this.comboBoxReader.Name = "comboBoxReader";
            this.comboBoxReader.Size = new System.Drawing.Size(194, 24);
            this.comboBoxReader.TabIndex = 5;
            this.comboBoxReader.SelectedIndexChanged += new System.EventHandler(this.comboBoxReader_SelectedIndexChanged);
            // 
            // comboBoxLibrarian
            // 
            this.comboBoxLibrarian.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxLibrarian.FormattingEnabled = true;
            this.comboBoxLibrarian.Location = new System.Drawing.Point(240, 41);
            this.comboBoxLibrarian.Name = "comboBoxLibrarian";
            this.comboBoxLibrarian.Size = new System.Drawing.Size(194, 24);
            this.comboBoxLibrarian.TabIndex = 6;
            this.comboBoxLibrarian.SelectedIndexChanged += new System.EventHandler(this.comboBoxLibrarian_SelectedIndexChanged);
            // 
            // listViewBookPlace
            // 
            this.listViewBookPlace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(158)))), ((int)(((byte)(159)))));
            this.listViewBookPlace.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listViewBookPlace.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewBookPlace.FullRowSelect = true;
            this.listViewBookPlace.GridLines = true;
            this.listViewBookPlace.HideSelection = false;
            this.listViewBookPlace.Location = new System.Drawing.Point(24, 141);
            this.listViewBookPlace.MultiSelect = false;
            this.listViewBookPlace.Name = "listViewBookPlace";
            this.listViewBookPlace.Size = new System.Drawing.Size(580, 219);
            this.listViewBookPlace.TabIndex = 8;
            this.listViewBookPlace.UseCompatibleStateImageBehavior = false;
            this.listViewBookPlace.View = System.Windows.Forms.View.Details;
            this.listViewBookPlace.SelectedIndexChanged += new System.EventHandler(this.listViewBookPlace_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID книги";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Название";
            this.columnHeader2.Width = 74;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Автор";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID читателя";
            this.columnHeader4.Width = 89;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ФИО читателя";
            this.columnHeader5.Width = 93;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ID библиотекаря";
            this.columnHeader6.Width = 89;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ФИО библиотекаря";
            this.columnHeader7.Width = 106;
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDel.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(11)))), ((int)(((byte)(18)))));
            this.buttonDel.Location = new System.Drawing.Point(504, 378);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(15);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(100, 30);
            this.buttonDel.TabIndex = 25;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEdit.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(11)))), ((int)(((byte)(18)))));
            this.buttonEdit.Location = new System.Drawing.Point(369, 378);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(15);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(100, 30);
            this.buttonEdit.TabIndex = 24;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(11)))), ((int)(((byte)(18)))));
            this.buttonAdd.Location = new System.Drawing.Point(235, 378);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(15);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 30);
            this.buttonAdd.TabIndex = 23;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Library.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(440, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // FormBookPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(619, 431);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewBookPlace);
            this.Controls.Add(this.comboBoxLibrarian);
            this.Controls.Add(this.comboBoxReader);
            this.Controls.Add(this.comboBoxBook);
            this.Controls.Add(this.labelLibrarian);
            this.Controls.Add(this.labelReader);
            this.Controls.Add(this.labelBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormBookPlace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выдача книг";
            this.Load += new System.EventHandler(this.FormBookPlace_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBook;
        private System.Windows.Forms.Label labelReader;
        private System.Windows.Forms.Label labelLibrarian;
        private System.Windows.Forms.ComboBox comboBoxBook;
        private System.Windows.Forms.ComboBox comboBoxReader;
        private System.Windows.Forms.ComboBox comboBoxLibrarian;
        private System.Windows.Forms.ListView listViewBookPlace;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}