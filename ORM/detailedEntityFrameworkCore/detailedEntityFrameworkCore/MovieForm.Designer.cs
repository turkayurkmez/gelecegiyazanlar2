
namespace detailedEntityFrameworkCore
{
    partial class MovieForm
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.dateTimePublishDate = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownDuration = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRating = new System.Windows.Forms.NumericUpDown();
            this.comboBoxDirector = new System.Windows.Forms.ComboBox();
            this.listBoxPlayers = new System.Windows.Forms.ListBox();
            this.buttonAddMovie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRating)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(47, 42);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // dateTimePublishDate
            // 
            this.dateTimePublishDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePublishDate.Location = new System.Drawing.Point(47, 69);
            this.dateTimePublishDate.Name = "dateTimePublishDate";
            this.dateTimePublishDate.Size = new System.Drawing.Size(120, 20);
            this.dateTimePublishDate.TabIndex = 1;
            // 
            // numericUpDownDuration
            // 
            this.numericUpDownDuration.Location = new System.Drawing.Point(47, 96);
            this.numericUpDownDuration.Name = "numericUpDownDuration";
            this.numericUpDownDuration.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownDuration.TabIndex = 2;
            // 
            // numericUpDownRating
            // 
            this.numericUpDownRating.Location = new System.Drawing.Point(47, 122);
            this.numericUpDownRating.Name = "numericUpDownRating";
            this.numericUpDownRating.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownRating.TabIndex = 3;
            // 
            // comboBoxDirector
            // 
            this.comboBoxDirector.FormattingEnabled = true;
            this.comboBoxDirector.Location = new System.Drawing.Point(47, 149);
            this.comboBoxDirector.Name = "comboBoxDirector";
            this.comboBoxDirector.Size = new System.Drawing.Size(120, 21);
            this.comboBoxDirector.TabIndex = 4;
            // 
            // listBoxPlayers
            // 
            this.listBoxPlayers.FormattingEnabled = true;
            this.listBoxPlayers.Location = new System.Drawing.Point(263, 42);
            this.listBoxPlayers.Name = "listBoxPlayers";
            this.listBoxPlayers.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxPlayers.Size = new System.Drawing.Size(219, 147);
            this.listBoxPlayers.TabIndex = 5;
            // 
            // buttonAddMovie
            // 
            this.buttonAddMovie.Location = new System.Drawing.Point(181, 241);
            this.buttonAddMovie.Name = "buttonAddMovie";
            this.buttonAddMovie.Size = new System.Drawing.Size(119, 23);
            this.buttonAddMovie.TabIndex = 6;
            this.buttonAddMovie.Text = "Film ekle";
            this.buttonAddMovie.UseVisualStyleBackColor = true;
            this.buttonAddMovie.Click += new System.EventHandler(this.buttonAddMovie_Click);
            // 
            // MovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 309);
            this.Controls.Add(this.buttonAddMovie);
            this.Controls.Add(this.listBoxPlayers);
            this.Controls.Add(this.comboBoxDirector);
            this.Controls.Add(this.numericUpDownRating);
            this.Controls.Add(this.numericUpDownDuration);
            this.Controls.Add(this.dateTimePublishDate);
            this.Controls.Add(this.textBoxName);
            this.Name = "MovieForm";
            this.Text = "MovieForm";
            this.Load += new System.EventHandler(this.MovieForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.DateTimePicker dateTimePublishDate;
        private System.Windows.Forms.NumericUpDown numericUpDownDuration;
        private System.Windows.Forms.NumericUpDown numericUpDownRating;
        private System.Windows.Forms.ComboBox comboBoxDirector;
        private System.Windows.Forms.ListBox listBoxPlayers;
        private System.Windows.Forms.Button buttonAddMovie;
    }
}