namespace Library
{
    partial class FormMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonBooks = new System.Windows.Forms.Button();
            this.buttonLibra = new System.Windows.Forms.Button();
            this.buttonReader = new System.Windows.Forms.Button();
            this.buttonBookPlace = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelHello = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBooks
            // 
            this.buttonBooks.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonBooks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBooks.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBooks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(11)))), ((int)(((byte)(18)))));
            this.buttonBooks.Location = new System.Drawing.Point(34, 133);
            this.buttonBooks.Margin = new System.Windows.Forms.Padding(10);
            this.buttonBooks.Name = "buttonBooks";
            this.buttonBooks.Padding = new System.Windows.Forms.Padding(2);
            this.buttonBooks.Size = new System.Drawing.Size(200, 35);
            this.buttonBooks.TabIndex = 0;
            this.buttonBooks.Text = "Книги";
            this.buttonBooks.UseVisualStyleBackColor = false;
            this.buttonBooks.Click += new System.EventHandler(this.buttonBooks_Click);
            // 
            // buttonLibra
            // 
            this.buttonLibra.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonLibra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLibra.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLibra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(11)))), ((int)(((byte)(18)))));
            this.buttonLibra.Location = new System.Drawing.Point(34, 350);
            this.buttonLibra.Margin = new System.Windows.Forms.Padding(10);
            this.buttonLibra.Name = "buttonLibra";
            this.buttonLibra.Padding = new System.Windows.Forms.Padding(2);
            this.buttonLibra.Size = new System.Drawing.Size(200, 35);
            this.buttonLibra.TabIndex = 1;
            this.buttonLibra.Text = "Библиотекари";
            this.buttonLibra.UseVisualStyleBackColor = false;
            this.buttonLibra.Click += new System.EventHandler(this.buttonLibra_Click);
            // 
            // buttonReader
            // 
            this.buttonReader.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonReader.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReader.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(11)))), ((int)(((byte)(18)))));
            this.buttonReader.Location = new System.Drawing.Point(34, 282);
            this.buttonReader.Margin = new System.Windows.Forms.Padding(10);
            this.buttonReader.Name = "buttonReader";
            this.buttonReader.Padding = new System.Windows.Forms.Padding(2);
            this.buttonReader.Size = new System.Drawing.Size(200, 35);
            this.buttonReader.TabIndex = 2;
            this.buttonReader.Text = "Читатели";
            this.buttonReader.UseVisualStyleBackColor = false;
            this.buttonReader.Click += new System.EventHandler(this.buttonReader_Click);
            // 
            // buttonBookPlace
            // 
            this.buttonBookPlace.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonBookPlace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBookPlace.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBookPlace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(11)))), ((int)(((byte)(18)))));
            this.buttonBookPlace.Location = new System.Drawing.Point(34, 209);
            this.buttonBookPlace.Margin = new System.Windows.Forms.Padding(10);
            this.buttonBookPlace.Name = "buttonBookPlace";
            this.buttonBookPlace.Padding = new System.Windows.Forms.Padding(2);
            this.buttonBookPlace.Size = new System.Drawing.Size(200, 35);
            this.buttonBookPlace.TabIndex = 3;
            this.buttonBookPlace.Text = "Выдача книг";
            this.buttonBookPlace.UseVisualStyleBackColor = false;
            this.buttonBookPlace.Click += new System.EventHandler(this.buttonBookPlace_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Library.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(34, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHello.Location = new System.Drawing.Point(30, 103);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(67, 20);
            this.labelHello.TabIndex = 10;
            this.labelHello.Text = "Привет";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(266, 417);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonBookPlace);
            this.Controls.Add(this.buttonReader);
            this.Controls.Add(this.buttonLibra);
            this.Controls.Add(this.buttonBooks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBooks;
        private System.Windows.Forms.Button buttonLibra;
        private System.Windows.Forms.Button buttonReader;
        private System.Windows.Forms.Button buttonBookPlace;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelHello;
    }
}

