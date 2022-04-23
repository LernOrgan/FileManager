namespace FileManager
{
    partial class Form1
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
            this.FileWay = new System.Windows.Forms.TextBox();
            this.ListOfDirectories = new System.Windows.Forms.ListBox();
            this.SerchButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.RenameButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.CompressButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FileWay
            // 
            this.FileWay.Location = new System.Drawing.Point(13, 14);
            this.FileWay.Name = "FileWay";
            this.FileWay.Size = new System.Drawing.Size(740, 27);
            this.FileWay.TabIndex = 0;
            // 
            // ListOfDirectories
            // 
            this.ListOfDirectories.FormattingEnabled = true;
            this.ListOfDirectories.ItemHeight = 20;
            this.ListOfDirectories.Location = new System.Drawing.Point(12, 65);
            this.ListOfDirectories.Name = "ListOfDirectories";
            this.ListOfDirectories.Size = new System.Drawing.Size(740, 384);
            this.ListOfDirectories.TabIndex = 1;
            this.ListOfDirectories.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListOfDirectories_MouseClick);
            this.ListOfDirectories.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListOfDirectories_MouseDoubleClick);
            // 
            // SerchButton
            // 
            this.SerchButton.Location = new System.Drawing.Point(759, 12);
            this.SerchButton.Name = "SerchButton";
            this.SerchButton.Size = new System.Drawing.Size(94, 29);
            this.SerchButton.TabIndex = 2;
            this.SerchButton.Text = "Найти";
            this.SerchButton.UseVisualStyleBackColor = true;
            this.SerchButton.Click += new System.EventHandler(this.SerchButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(758, 65);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(220, 45);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // RenameButton
            // 
            this.RenameButton.Location = new System.Drawing.Point(758, 120);
            this.RenameButton.Name = "RenameButton";
            this.RenameButton.Size = new System.Drawing.Size(220, 50);
            this.RenameButton.TabIndex = 4;
            this.RenameButton.Text = "Переименовать";
            this.RenameButton.UseVisualStyleBackColor = true;
            this.RenameButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RenameButton_MouseClick);
            // 
            // CopyButton
            // 
            this.CopyButton.Location = new System.Drawing.Point(758, 179);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(220, 50);
            this.CopyButton.TabIndex = 5;
            this.CopyButton.Text = "Копировать";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(885, 10);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(94, 29);
            this.BackButton.TabIndex = 6;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CompressButton
            // 
            this.CompressButton.Location = new System.Drawing.Point(759, 244);
            this.CompressButton.Name = "CompressButton";
            this.CompressButton.Size = new System.Drawing.Size(220, 50);
            this.CompressButton.TabIndex = 7;
            this.CompressButton.Text = "Архивировать";
            this.CompressButton.UseVisualStyleBackColor = true;
            this.CompressButton.Click += new System.EventHandler(this.CompressButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 500);
            this.Controls.Add(this.CompressButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.RenameButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.SerchButton);
            this.Controls.Add(this.ListOfDirectories);
            this.Controls.Add(this.FileWay);
            this.Name = "Form1";
            this.Text = "FFManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox FileWay;
        private ListBox ListOfDirectories;
        private Button SerchButton;
        private Button DeleteButton;
        private Button RenameButton;
        private Button CopyButton;
        private Button BackButton;
        private Button CompressButton;
    }
}