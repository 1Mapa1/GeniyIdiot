
namespace GenyiIdiotWinFormsApp
{
    partial class MainForm
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
            this.nameGameLabel = new System.Windows.Forms.Label();
            this.nameUserLabel = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.startGameButton = new System.Windows.Forms.Button();
            this.warningLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameGameLabel
            // 
            this.nameGameLabel.AutoSize = true;
            this.nameGameLabel.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameGameLabel.ForeColor = System.Drawing.Color.Green;
            this.nameGameLabel.Location = new System.Drawing.Point(239, 39);
            this.nameGameLabel.Name = "nameGameLabel";
            this.nameGameLabel.Size = new System.Drawing.Size(321, 57);
            this.nameGameLabel.TabIndex = 0;
            this.nameGameLabel.Text = "Гений-Идиот";
            // 
            // nameUserLabel
            // 
            this.nameUserLabel.AutoSize = true;
            this.nameUserLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameUserLabel.Location = new System.Drawing.Point(98, 179);
            this.nameUserLabel.Name = "nameUserLabel";
            this.nameUserLabel.Size = new System.Drawing.Size(198, 27);
            this.nameUserLabel.TabIndex = 1;
            this.nameUserLabel.Text = "Введите свое имя:";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(320, 179);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(342, 27);
            this.userNameTextBox.TabIndex = 2;
            // 
            // startGameButton
            // 
            this.startGameButton.BackColor = System.Drawing.Color.GreenYellow;
            this.startGameButton.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startGameButton.Location = new System.Drawing.Point(274, 265);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(261, 50);
            this.startGameButton.TabIndex = 3;
            this.startGameButton.Text = "НАЧАТЬ";
            this.startGameButton.UseVisualStyleBackColor = false;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.warningLabel.Location = new System.Drawing.Point(274, 351);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(269, 25);
            this.warningLabel.TabIndex = 4;
            this.warningLabel.Text = "На ответ есть всего 10 скенд!";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(802, 453);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.startGameButton);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.nameUserLabel);
            this.Controls.Add(this.nameGameLabel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameGameLabel;
        private System.Windows.Forms.Label nameUserLabel;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.Label warningLabel;
    }
}