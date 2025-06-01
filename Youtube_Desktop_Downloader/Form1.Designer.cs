namespace Youtube_Desktop_Downloader
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
            Connection_check = new Panel();
            label1 = new Label();
            connection_label = new Label();
            Connection_check.SuspendLayout();
            SuspendLayout();
            // 
            // Connection_check
            // 
            Connection_check.Controls.Add(connection_label);
            Connection_check.Controls.Add(label1);
            Connection_check.Location = new Point(1, 2);
            Connection_check.Name = "Connection_check";
            Connection_check.Size = new Size(797, 449);
            Connection_check.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.AppStarting;
            label1.Font = new Font("Lucida Sans Unicode", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(241, 259);
            label1.Name = "label1";
            label1.Size = new Size(321, 93);
            label1.TabIndex = 0;
            label1.Text = "Sprawdzanie połączenia..\r\n\r\n\r\n";
            // 
            // connection_label
            // 
            connection_label.AutoSize = true;
            connection_label.Font = new Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            connection_label.Location = new Point(399, 242);
            connection_label.Name = "connection_label";
            connection_label.Size = new Size(0, 17);
            connection_label.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 450);
            Controls.Add(Connection_check);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Connection_check.ResumeLayout(false);
            Connection_check.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Connection_check;
        private Label label1;
        private Label connection_label;
    }
}
