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
            Back_panel = new TableLayoutPanel();
            Menu_panel = new TableLayoutPanel();
            Main_page = new TableLayoutPanel();
            textBox1 = new TextBox();
            Back_panel.SuspendLayout();
            Main_page.SuspendLayout();
            SuspendLayout();
            // 
            // Back_panel
            // 
            Back_panel.AutoSize = true;
            Back_panel.ColumnCount = 2;
            Back_panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            Back_panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            Back_panel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            Back_panel.Controls.Add(Menu_panel, 0, 0);
            Back_panel.Controls.Add(Main_page, 1, 0);
            Back_panel.Location = new Point(0, 0);
            Back_panel.Name = "Back_panel";
            Back_panel.RowCount = 1;
            Back_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Back_panel.Size = new Size(1154, 632);
            Back_panel.TabIndex = 0;
            // 
            // Menu_panel
            // 
            Menu_panel.BackColor = Color.FromArgb(47, 49, 62);
            Menu_panel.ColumnCount = 1;
            Menu_panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Menu_panel.Location = new Point(3, 3);
            Menu_panel.Name = "Menu_panel";
            Menu_panel.RowCount = 6;
            Menu_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 13F));
            Menu_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            Menu_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            Menu_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            Menu_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            Menu_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 55F));
            Menu_panel.Size = new Size(167, 626);
            Menu_panel.TabIndex = 0;
            // 
            // Main_page
            // 
            Main_page.BackColor = Color.FromArgb(28, 30, 40);
            Main_page.ColumnCount = 1;
            Main_page.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Main_page.Controls.Add(textBox1, 0, 0);
            Main_page.Location = new Point(176, 3);
            Main_page.Name = "Main_page";
            Main_page.RowCount = 2;
            Main_page.RowStyles.Add(new RowStyle(SizeType.Percent, 13F));
            Main_page.RowStyles.Add(new RowStyle(SizeType.Percent, 87F));
            Main_page.Size = new Size(975, 626);
            Main_page.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(47, 49, 62);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.ForeColor = SystemColors.Window;
            textBox1.Location = new Point(14, 14);
            textBox1.Margin = new Padding(14, 14, 3, 3);
            textBox1.MinimumSize = new Size(800, 50);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(800, 50);
            textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 27, 36);
            ClientSize = new Size(1154, 630);
            Controls.Add(Back_panel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Back_panel.ResumeLayout(false);
            Main_page.ResumeLayout(false);
            Main_page.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel Back_panel;
        private TableLayoutPanel Menu_panel;
        private TableLayoutPanel Main_page;
        private TextBox textBox1;
    }
}
