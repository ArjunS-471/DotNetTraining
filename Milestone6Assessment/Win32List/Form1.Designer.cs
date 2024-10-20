namespace Win32List
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private ListView ListViewItems;
        private Button button1;
        private Button button2;

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
            ListViewItems = new ListView();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // ListViewItems
            // 
            ListViewItems.Location = new Point(12, 12);
            ListViewItems.MultiSelect = false;
            ListViewItems.Name = "ListViewItems";
            ListViewItems.Size = new Size(189, 255);
            ListViewItems.TabIndex = 0;
            ListViewItems.UseCompatibleStateImageBehavior = false;
            ListViewItems.View = View.List;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(226, 12);
            button1.Name = "button1";
            button1.Size = new Size(154, 65);
            button1.TabIndex = 1;
            button1.Text = "Add Item";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(226, 98);
            button2.Name = "button2";
            button2.Size = new Size(154, 67);
            button2.TabIndex = 2;
            button2.Text = "Remove item";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 282);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(ListViewItems);
            Name = "Form1";
            Text = "Item list";
            ResumeLayout(false);
        }

        #endregion
    }
}