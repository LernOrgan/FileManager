namespace FileManager
{
    partial class CopyForm
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
            this.OkButton = new System.Windows.Forms.Button();
            this.WayOfCopiedFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(197, 103);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(84, 29);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // WayOfCopiedFile
            // 
            this.WayOfCopiedFile.Location = new System.Drawing.Point(12, 58);
            this.WayOfCopiedFile.Name = "WayOfCopiedFile";
            this.WayOfCopiedFile.Size = new System.Drawing.Size(460, 27);
            this.WayOfCopiedFile.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите полный путь папки, куда вы хотите скопировать файл:";
            // 
            // CopyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 153);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WayOfCopiedFile);
            this.Controls.Add(this.OkButton);
            this.Name = "CopyForm";
            this.Text = "Копирование файла";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button OkButton;
        private TextBox WayOfCopiedFile;
        private Label label1;
    }
}