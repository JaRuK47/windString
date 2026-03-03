namespace stringautotast
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            firstWord = new TextBox();
            secondWord = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(325, 143);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Готоува";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // firstWord
            // 
            firstWord.Location = new Point(171, 127);
            firstWord.Name = "firstWord";
            firstWord.Size = new Size(125, 27);
            firstWord.TabIndex = 1;
            // 
            // secondWord
            // 
            secondWord.Location = new Point(171, 160);
            secondWord.Name = "secondWord";
            secondWord.Size = new Size(125, 27);
            secondWord.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 132);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 3;
            label1.Text = "Слово 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 160);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 4;
            label2.Text = "Слово 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(502, 100);
            label3.TabIndex = 5;
            label3.Text = resources.GetString("label3.Text");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 205);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(secondWord);
            Controls.Add(firstWord);
            Controls.Add(button1);
            Name = "Form1";
            Text = "String задание";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox firstWord;
        private TextBox secondWord;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
