namespace NLMK.Client.Forms
{
    partial class ClientForm
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
            DividentTextBox = new TextBox();
            label1 = new Label();
            DividerTextBox = new TextBox();
            label2 = new Label();
            QuotientTextBox = new TextBox();
            label3 = new Label();
            Calculate = new Button();
            PictureBox = new PictureBox();
            InfoLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)PictureBox).BeginInit();
            SuspendLayout();
            // 
            // DividentTextBox
            // 
            DividentTextBox.Location = new Point(12, 30);
            DividentTextBox.MaxLength = 5;
            DividentTextBox.Name = "DividentTextBox";
            DividentTextBox.Size = new Size(267, 23);
            DividentTextBox.TabIndex = 0;
            DividentTextBox.KeyPress += DividentTextBox_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 1;
            label1.Text = "Делимое";
            // 
            // DividerTextBox
            // 
            DividerTextBox.Location = new Point(12, 77);
            DividerTextBox.MaxLength = 5;
            DividerTextBox.Name = "DividerTextBox";
            DividerTextBox.Size = new Size(267, 23);
            DividerTextBox.TabIndex = 0;
            DividerTextBox.KeyPress += DividertextBox_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 56);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Делитель";
            // 
            // QuotientTextBox
            // 
            QuotientTextBox.Location = new Point(12, 165);
            QuotientTextBox.MaxLength = 5;
            QuotientTextBox.Name = "QuotientTextBox";
            QuotientTextBox.ReadOnly = true;
            QuotientTextBox.Size = new Size(267, 23);
            QuotientTextBox.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 144);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 1;
            label3.Text = "Частное";
            // 
            // Calculate
            // 
            Calculate.Location = new Point(12, 208);
            Calculate.Name = "Calculate";
            Calculate.Size = new Size(267, 23);
            Calculate.TabIndex = 2;
            Calculate.Text = "Калькулировать";
            Calculate.UseVisualStyleBackColor = true;
            Calculate.Click += Calculate_Click;
            // 
            // PictureBox
            // 
            PictureBox.Image = Properties.Resources.information;
            PictureBox.Location = new Point(119, 115);
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new Size(35, 35);
            PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox.TabIndex = 3;
            PictureBox.TabStop = false;
            PictureBox.Visible = false;
            // 
            // InfoLabel
            // 
            InfoLabel.AutoSize = true;
            InfoLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            InfoLabel.Location = new Point(160, 126);
            InfoLabel.Name = "InfoLabel";
            InfoLabel.Size = new Size(183, 17);
            InfoLabel.TabIndex = 4;
            InfoLabel.Text = "Идет обращение к серверу...";
            InfoLabel.Visible = false;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 243);
            Controls.Add(InfoLabel);
            Controls.Add(PictureBox);
            Controls.Add(Calculate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(QuotientTextBox);
            Controls.Add(DividerTextBox);
            Controls.Add(DividentTextBox);
            MaximumSize = new Size(453, 282);
            MinimumSize = new Size(453, 282);
            Name = "ClientForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)PictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox DividentTextBox;
        private Label label1;
        private TextBox DividerTextBox;
        private Label label2;
        private TextBox QuotientTextBox;
        private Label label3;
        private Button Calculate;
        private PictureBox PictureBox;
        private Label InfoLabel;
    }
}