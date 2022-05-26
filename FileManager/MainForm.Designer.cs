namespace FileManager
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LunguageName = new System.Windows.Forms.TextBox();
            this.SerchButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.CountOfBooks = new System.Windows.Forms.TextBox();
            this.listViewBooks = new System.Windows.Forms.ListView();
            this.Title = new System.Windows.Forms.ColumnHeader();
            this.Author = new System.Windows.Forms.ColumnHeader();
            this.Price = new System.Windows.Forms.ColumnHeader();
            this.Date = new System.Windows.Forms.ColumnHeader();
            this.Rating = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // LunguageName
            // 
            this.LunguageName.AutoCompleteCustomSource.AddRange(new string[] {
            "JavaScript",
            "Java",
            "Python",
            "C Sharp",
            "Ruby",
            "Fortran",
            "Perl",
            "Kotlin",
            "PHP",
            "lua",
            "Haskell",
            "Go"});
            this.LunguageName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.LunguageName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.LunguageName.Location = new System.Drawing.Point(13, 14);
            this.LunguageName.Name = "LunguageName";
            this.LunguageName.Size = new System.Drawing.Size(974, 27);
            this.LunguageName.TabIndex = 0;
            // 
            // SerchButton
            // 
            this.SerchButton.Location = new System.Drawing.Point(1124, 12);
            this.SerchButton.Name = "SerchButton";
            this.SerchButton.Size = new System.Drawing.Size(94, 29);
            this.SerchButton.TabIndex = 2;
            this.SerchButton.Text = "Найти";
            this.SerchButton.UseVisualStyleBackColor = true;
            this.SerchButton.Click += new System.EventHandler(this.SerchButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(1124, 506);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(94, 82);
            this.SettingsButton.TabIndex = 8;
            this.SettingsButton.Text = "Настройки";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // CountOfBooks
            // 
            this.CountOfBooks.Location = new System.Drawing.Point(993, 14);
            this.CountOfBooks.Name = "CountOfBooks";
            this.CountOfBooks.Size = new System.Drawing.Size(125, 27);
            this.CountOfBooks.TabIndex = 9;
            // 
            // listViewBooks
            // 
            this.listViewBooks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.Author,
            this.Price,
            this.Date,
            this.Rating});
            this.listViewBooks.Location = new System.Drawing.Point(13, 61);
            this.listViewBooks.Name = "listViewBooks";
            this.listViewBooks.Size = new System.Drawing.Size(1105, 527);
            this.listViewBooks.TabIndex = 10;
            this.listViewBooks.UseCompatibleStateImageBehavior = false;
            this.listViewBooks.View = System.Windows.Forms.View.Details;
            this.listViewBooks.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewBooks_ColumnClick);
            this.listViewBooks.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listViewBooks.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewBooks_MouseDoubleClick);
            // 
            // Title
            // 
            this.Title.Text = "Название";
            this.Title.Width = 500;
            // 
            // Author
            // 
            this.Author.Text = "Автор";
            this.Author.Width = 300;
            // 
            // Price
            // 
            this.Price.Text = "Цена";
            this.Price.Width = 80;
            // 
            // Date
            // 
            this.Date.Text = "Дата";
            this.Date.Width = 100;
            // 
            // Rating
            // 
            this.Rating.Text = "Оценка";
            this.Rating.Width = 80;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 600);
            this.Controls.Add(this.listViewBooks);
            this.Controls.Add(this.CountOfBooks);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.SerchButton);
            this.Controls.Add(this.LunguageName);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "MainForm";
            this.Text = "FFManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox LunguageName;
        private Button SerchButton;
        private Button SettingsButton;
        private TextBox CountOfBooks;
        private ListView listViewBooks;
        private ColumnHeader Title;
        private ColumnHeader Author;
        private ColumnHeader Price;
        private ColumnHeader Date;
        private ColumnHeader Rating;
    }
}