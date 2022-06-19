
namespace GenyiIdiotWinFormsApp
{
    partial class AddQuestionForm
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
            this.questionsStarageLabel = new System.Windows.Forms.Label();
            this.questionStorageButton = new System.Windows.Forms.Button();
            this.textQuestionLabel = new System.Windows.Forms.Label();
            this.answerQuestionLabel = new System.Windows.Forms.Label();
            this.addQuestionButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.textQuestionTextBox = new System.Windows.Forms.TextBox();
            this.answerQuestionTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // questionsStarageLabel
            // 
            this.questionsStarageLabel.AutoSize = true;
            this.questionsStarageLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.questionsStarageLabel.Location = new System.Drawing.Point(302, 27);
            this.questionsStarageLabel.Name = "questionsStarageLabel";
            this.questionsStarageLabel.Size = new System.Drawing.Size(178, 23);
            this.questionsStarageLabel.TabIndex = 0;
            this.questionsStarageLabel.Text = "Посмотреть вопросы";
            // 
            // questionStorageButton
            // 
            this.questionStorageButton.Location = new System.Drawing.Point(340, 53);
            this.questionStorageButton.Name = "questionStorageButton";
            this.questionStorageButton.Size = new System.Drawing.Size(107, 47);
            this.questionStorageButton.TabIndex = 1;
            this.questionStorageButton.Text = "Посмотреть";
            this.questionStorageButton.UseVisualStyleBackColor = true;
            this.questionStorageButton.Click += new System.EventHandler(this.questionStorageButton_Click);
            // 
            // textQuestionLabel
            // 
            this.textQuestionLabel.AutoSize = true;
            this.textQuestionLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textQuestionLabel.Location = new System.Drawing.Point(75, 146);
            this.textQuestionLabel.Name = "textQuestionLabel";
            this.textQuestionLabel.Size = new System.Drawing.Size(144, 23);
            this.textQuestionLabel.TabIndex = 2;
            this.textQuestionLabel.Text = "Введите вопрос: ";
            // 
            // answerQuestionLabel
            // 
            this.answerQuestionLabel.AutoSize = true;
            this.answerQuestionLabel.Location = new System.Drawing.Point(75, 233);
            this.answerQuestionLabel.Name = "answerQuestionLabel";
            this.answerQuestionLabel.Size = new System.Drawing.Size(185, 20);
            this.answerQuestionLabel.TabIndex = 3;
            this.answerQuestionLabel.Text = "Введите ответ на вопрос:";
            // 
            // addQuestionButton
            // 
            this.addQuestionButton.Location = new System.Drawing.Point(275, 376);
            this.addQuestionButton.Name = "addQuestionButton";
            this.addQuestionButton.Size = new System.Drawing.Size(113, 51);
            this.addQuestionButton.TabIndex = 4;
            this.addQuestionButton.Text = "ДОБАВИТЬ";
            this.addQuestionButton.UseVisualStyleBackColor = true;
            this.addQuestionButton.Click += new System.EventHandler(this.addQuestionButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(413, 376);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(113, 51);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "НАЗАД";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // textQuestionTextBox
            // 
            this.textQuestionTextBox.Location = new System.Drawing.Point(75, 187);
            this.textQuestionTextBox.Name = "textQuestionTextBox";
            this.textQuestionTextBox.Size = new System.Drawing.Size(519, 27);
            this.textQuestionTextBox.TabIndex = 6;
            // 
            // answerQuestionTextBox
            // 
            this.answerQuestionTextBox.Location = new System.Drawing.Point(75, 276);
            this.answerQuestionTextBox.Name = "answerQuestionTextBox";
            this.answerQuestionTextBox.Size = new System.Drawing.Size(519, 27);
            this.answerQuestionTextBox.TabIndex = 7;
            // 
            // AddQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.answerQuestionTextBox);
            this.Controls.Add(this.textQuestionTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.addQuestionButton);
            this.Controls.Add(this.answerQuestionLabel);
            this.Controls.Add(this.textQuestionLabel);
            this.Controls.Add(this.questionStorageButton);
            this.Controls.Add(this.questionsStarageLabel);
            this.KeyPreview = true;
            this.Name = "AddQuestionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddQuestionForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionsStarageLabel;
        private System.Windows.Forms.Button questionStorageButton;
        private System.Windows.Forms.Label textQuestionLabel;
        private System.Windows.Forms.Label answerQuestionLabel;
        private System.Windows.Forms.Button addQuestionButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox textQuestionTextBox;
        private System.Windows.Forms.TextBox answerQuestionTextBox;
    }
}