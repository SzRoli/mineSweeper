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
            this.text_Name_Box = new System.Windows.Forms.TextBox();
            this.add_Name = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_Name_Box
            // 
            this.text_Name_Box.Location = new System.Drawing.Point(22, 34);
            this.text_Name_Box.Name = "text_Name_Box";
            this.text_Name_Box.Size = new System.Drawing.Size(100, 20);
            this.text_Name_Box.TabIndex = 0;
            this.text_Name_Box.Tag = "nameBox";
            
            // 
            // add_Name
            // 
            this.add_Name.Location = new System.Drawing.Point(33, 77);
            this.add_Name.Name = "add_Name";
            this.add_Name.Size = new System.Drawing.Size(75, 23);
            this.add_Name.TabIndex = 1;
            this.add_Name.Tag = "addName";
            this.add_Name.Text = "Ok";
            this.add_Name.UseVisualStyleBackColor = true;
            this.add_Name.Click += new System.EventHandler(this.button1_Click);
            // 
            // GameEnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(162, 138);
            this.Controls.Add(this.add_Name);
            this.Controls.Add(this.text_Name_Box);
            this.Name = "GameEnd";
            this.Text = "GameEnd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_Name_Box;
        private System.Windows.Forms.Button add_Name;
    }
}