
namespace GenyiIdiotWinFormsApp
{
    partial class MenuForm
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
            this.resultLabel = new System.Windows.Forms.Label();
            this.userResultsButton = new System.Windows.Forms.Button();
            this.addQuestionButton = new System.Windows.Forms.Button();
            this.questionStoragebutton = new System.Windows.Forms.Button();
            this.removeQuestionButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.againPassButton = new System.Windows.Forms.Button();
            this.exitTestButton = new System.Windows.Forms.Button();
            this.userResultLabel = new System.Windows.Forms.Label();
            this.questionStorageLabel = new System.Windows.Forms.Label();
            this.addQuestionLabel = new System.Windows.Forms.Label();
            this.removeQuestionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultLabel.Location = new System.Drawing.Point(37, 53);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(598, 33);
            this.resultLabel.TabIndex = 0;
            this.resultLabel.Text = "Количество правильных ответов:  . Ваш диагноз:";
            // 
            // userResultsButton
            // 
            this.userResultsButton.Location = new System.Drawing.Point(133, 179);
            this.userResultsButton.Name = "userResultsButton";
            this.userResultsButton.Size = new System.Drawing.Size(140, 43);
            this.userResultsButton.TabIndex = 1;
            this.userResultsButton.Text = "Посмотреть";
            this.userResultsButton.UseVisualStyleBackColor = true;
            this.userResultsButton.Click += new System.EventHandler(this.userResultsButton_Click);
            // 
            // addQuestionButton
            // 
            this.addQuestionButton.Location = new System.Drawing.Point(564, 179);
            this.addQuestionButton.Name = "addQuestionButton";
            this.addQuestionButton.Size = new System.Drawing.Size(140, 43);
            this.addQuestionButton.TabIndex = 2;
            this.addQuestionButton.Text = "Добавить";
            this.addQuestionButton.UseVisualStyleBackColor = true;
            this.addQuestionButton.Click += new System.EventHandler(this.addQuestionButton_Click);
            // 
            // questionStoragebutton
            // 
            this.questionStoragebutton.Location = new System.Drawing.Point(133, 268);
            this.questionStoragebutton.Name = "questionStoragebutton";
            this.questionStoragebutton.Size = new System.Drawing.Size(140, 43);
            this.questionStoragebutton.TabIndex = 3;
            this.questionStoragebutton.Text = "Посмотреть";
            this.questionStoragebutton.UseVisualStyleBackColor = true;
            this.questionStoragebutton.Click += new System.EventHandler(this.questionStoragebutton_Click);
            // 
            // removeQuestionButton
            // 
            this.removeQuestionButton.Location = new System.Drawing.Point(564, 268);
            this.removeQuestionButton.Name = "removeQuestionButton";
            this.removeQuestionButton.Size = new System.Drawing.Size(140, 43);
            this.removeQuestionButton.TabIndex = 4;
            this.removeQuestionButton.Text = "Удалить";
            this.removeQuestionButton.UseVisualStyleBackColor = true;
            this.removeQuestionButton.Click += new System.EventHandler(this.removeQuestionButton_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(431, 412);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(8, 8);
            this.button5.TabIndex = 5;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // againPassButton
            // 
            this.againPassButton.Location = new System.Drawing.Point(364, 359);
            this.againPassButton.Name = "againPassButton";
            this.againPassButton.Size = new System.Drawing.Size(135, 47);
            this.againPassButton.TabIndex = 6;
            this.againPassButton.Text = "Пройти снова";
            this.againPassButton.UseVisualStyleBackColor = true;
            this.againPassButton.Click += new System.EventHandler(this.againPassButton_Click);
            // 
            // exitTestButton
            // 
            this.exitTestButton.Location = new System.Drawing.Point(364, 412);
            this.exitTestButton.Name = "exitTestButton";
            this.exitTestButton.Size = new System.Drawing.Size(135, 51);
            this.exitTestButton.TabIndex = 7;
            this.exitTestButton.Text = "Закончить тест";
            this.exitTestButton.UseVisualStyleBackColor = true;
            this.exitTestButton.Click += new System.EventHandler(this.exitTestButton_Click);
            // 
            // userResultLabel
            // 
            this.userResultLabel.AutoSize = true;
            this.userResultLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userResultLabel.Location = new System.Drawing.Point(37, 153);
            this.userResultLabel.Name = "userResultLabel";
            this.userResultLabel.Size = new System.Drawing.Size(355, 23);
            this.userResultLabel.TabIndex = 8;
            this.userResultLabel.Text = "Посмотреть результаты прохождения теста";
            // 
            // questionStorageLabel
            // 
            this.questionStorageLabel.AutoSize = true;
            this.questionStorageLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.questionStorageLabel.Location = new System.Drawing.Point(87, 242);
            this.questionStorageLabel.Name = "questionStorageLabel";
            this.questionStorageLabel.Size = new System.Drawing.Size(244, 23);
            this.questionStorageLabel.TabIndex = 9;
            this.questionStorageLabel.Text = "Посмотреть список вопросов";
            // 
            // addQuestionLabel
            // 
            this.addQuestionLabel.AutoSize = true;
            this.addQuestionLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addQuestionLabel.Location = new System.Drawing.Point(534, 153);
            this.addQuestionLabel.Name = "addQuestionLabel";
            this.addQuestionLabel.Size = new System.Drawing.Size(205, 23);
            this.addQuestionLabel.TabIndex = 10;
            this.addQuestionLabel.Text = "Добавить вопрос к тесту";
            // 
            // removeQuestionLabel
            // 
            this.removeQuestionLabel.AutoSize = true;
            this.removeQuestionLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.removeQuestionLabel.Location = new System.Drawing.Point(534, 242);
            this.removeQuestionLabel.Name = "removeQuestionLabel";
            this.removeQuestionLabel.Size = new System.Drawing.Size(203, 23);
            this.removeQuestionLabel.TabIndex = 11;
            this.removeQuestionLabel.Text = "Удалить вопрос из теста";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(873, 489);
            this.Controls.Add(this.removeQuestionLabel);
            this.Controls.Add(this.addQuestionLabel);
            this.Controls.Add(this.questionStorageLabel);
            this.Controls.Add(this.userResultLabel);
            this.Controls.Add(this.exitTestButton);
            this.Controls.Add(this.againPassButton);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.removeQuestionButton);
            this.Controls.Add(this.questionStoragebutton);
            this.Controls.Add(this.addQuestionButton);
            this.Controls.Add(this.userResultsButton);
            this.Controls.Add(this.resultLabel);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button userResultsButton;
        private System.Windows.Forms.Button addQuestionButton;
        private System.Windows.Forms.Button questionStoragebutton;
        private System.Windows.Forms.Button removeQuestionButton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button againPassButton;
        private System.Windows.Forms.Button exitTestButton;
        private System.Windows.Forms.Label userResultLabel;
        private System.Windows.Forms.Label questionStorageLabel;
        private System.Windows.Forms.Label addQuestionLabel;
        private System.Windows.Forms.Label removeQuestionLabel;
    }
}