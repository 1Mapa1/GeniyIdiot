
namespace GenyiIdiotWinFormsApp
{
    partial class RemoveQuestionForm
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
            this.questionStorageLabel = new System.Windows.Forms.Label();
            this.questionStorageButton = new System.Windows.Forms.Button();
            this.removeQuestionLabel = new System.Windows.Forms.Label();
            this.removeQuestionTextBox = new System.Windows.Forms.TextBox();
            this.removeQuestionButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionStorageLabel
            // 
            this.questionStorageLabel.AutoSize = true;
            this.questionStorageLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.questionStorageLabel.Location = new System.Drawing.Point(327, 21);
            this.questionStorageLabel.Name = "questionStorageLabel";
            this.questionStorageLabel.Size = new System.Drawing.Size(178, 23);
            this.questionStorageLabel.TabIndex = 0;
            this.questionStorageLabel.Text = "Посмотреть вопросы";
            // 
            // questionStorageButton
            // 
            this.questionStorageButton.Location = new System.Drawing.Point(353, 47);
            this.questionStorageButton.Name = "questionStorageButton";
            this.questionStorageButton.Size = new System.Drawing.Size(123, 50);
            this.questionStorageButton.TabIndex = 1;
            this.questionStorageButton.Text = "Посмотреть";
            this.questionStorageButton.UseVisualStyleBackColor = true;
            this.questionStorageButton.Click += new System.EventHandler(this.questionStorageButton_Click);
            // 
            // removeQuestionLabel
            // 
            this.removeQuestionLabel.AutoSize = true;
            this.removeQuestionLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.removeQuestionLabel.Location = new System.Drawing.Point(53, 163);
            this.removeQuestionLabel.Name = "removeQuestionLabel";
            this.removeQuestionLabel.Size = new System.Drawing.Size(301, 23);
            this.removeQuestionLabel.TabIndex = 2;
            this.removeQuestionLabel.Text = "Введите номер удаляемого вопроса:";
            // 
            // removeQuestionTextBox
            // 
            this.removeQuestionTextBox.Location = new System.Drawing.Point(53, 200);
            this.removeQuestionTextBox.Name = "removeQuestionTextBox";
            this.removeQuestionTextBox.Size = new System.Drawing.Size(301, 27);
            this.removeQuestionTextBox.TabIndex = 3;
            // 
            // removeQuestionButton
            // 
            this.removeQuestionButton.Location = new System.Drawing.Point(265, 361);
            this.removeQuestionButton.Name = "removeQuestionButton";
            this.removeQuestionButton.Size = new System.Drawing.Size(125, 55);
            this.removeQuestionButton.TabIndex = 4;
            this.removeQuestionButton.Text = "УДАЛИТЬ";
            this.removeQuestionButton.UseVisualStyleBackColor = true;
            this.removeQuestionButton.Click += new System.EventHandler(this.removeQuestionButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(415, 361);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(125, 55);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "НАЗАД";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // RemoveQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.removeQuestionButton);
            this.Controls.Add(this.removeQuestionTextBox);
            this.Controls.Add(this.removeQuestionLabel);
            this.Controls.Add(this.questionStorageButton);
            this.Controls.Add(this.questionStorageLabel);
            this.KeyPreview = true;
            this.Name = "RemoveQuestionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RemoveQuestionForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionStorageLabel;
        private System.Windows.Forms.Button questionStorageButton;
        private System.Windows.Forms.Label removeQuestionLabel;
        private System.Windows.Forms.TextBox removeQuestionTextBox;
        private System.Windows.Forms.Button removeQuestionButton;
        private System.Windows.Forms.Button exitButton;
    }
}