namespace Minesweeper
{
    partial class GameEnd
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.Bevitel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(82, 61);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 0;
            this.nameBox.Tag = "nameBox";
            // 
            // Bevitel
            // 
            this.Bevitel.Location = new System.Drawing.Point(91, 107);
            this.Bevitel.Name = "Bevitel";
            this.Bevitel.Size = new System.Drawing.Size(75, 23);
            this.Bevitel.TabIndex = 1;
            this.Bevitel.Tag = "Bevitel";
            this.Bevitel.Text = "Bevitel";
            this.Bevitel.UseVisualStyleBackColor = true;
            this.Bevitel.Click += new System.EventHandler(this.Bevitel_Click);
            // 
            // GameEnd
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Bevitel);
            this.Controls.Add(this.nameBox);
            this.Name = "GameEnd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_Name_Box;
        private System.Windows.Forms.Button add_Name;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button Bevitel;
    }
}