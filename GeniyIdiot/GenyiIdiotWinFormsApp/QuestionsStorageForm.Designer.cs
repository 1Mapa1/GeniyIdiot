
namespace GenyiIdiotWinFormsApp
{
    partial class QuestionsStorageForm
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
            this.columLabel = new System.Windows.Forms.Label();
            this.textQuestionLabel = new System.Windows.Forms.Label();
            this.answerQuestionLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.numberQuestionLabel = new System.Windows.Forms.Label();
            this.questionStorageDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.questionStorageDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // columLabel
            // 
            this.columLabel.AutoSize = true;
            this.columLabel.Location = new System.Drawing.Point(45, 45);
            this.columLabel.Name = "columLabel";
            this.columLabel.Size = new System.Drawing.Size(50, 20);
            this.columLabel.TabIndex = 0;
            this.columLabel.Text = "label1";
            // 
            // textQuestionLabel
            // 
            this.textQuestionLabel.AutoSize = true;
            this.textQuestionLabel.Location = new System.Drawing.Point(54, 114);
            this.textQuestionLabel.Name = "textQuestionLabel";
            this.textQuestionLabel.Size = new System.Drawing.Size(0, 20);
            this.textQuestionLabel.TabIndex = 1;
            // 
            // answerQuestionLabel
            // 
            this.answerQuestionLabel.AutoSize = true;
            this.answerQuestionLabel.Location = new System.Drawing.Point(617, 114);
            this.answerQuestionLabel.Name = "answerQuestionLabel";
            this.answerQuestionLabel.Size = new System.Drawing.Size(0, 20);
            this.answerQuestionLabel.TabIndex = 2;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(361, 392);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(94, 29);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "НАЗАД";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // numberQuestionLabel
            // 
            this.numberQuestionLabel.AutoSize = true;
            this.numberQuestionLabel.Location = new System.Drawing.Point(25, 110);
            this.numberQuestionLabel.Name = "numberQuestionLabel";
            this.numberQuestionLabel.Size = new System.Drawing.Size(0, 20);
            this.numberQuestionLabel.TabIndex = 4;
            // 
            // questionStorageDataGridView
            // 
            this.questionStorageDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.questionStorageDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.questionStorageDataGridView.GridColor = System.Drawing.Color.DarkGray;
            this.questionStorageDataGridView.Location = new System.Drawing.Point(12, 12);
            this.questionStorageDataGridView.Name = "questionStorageDataGridView";
            this.questionStorageDataGridView.RowHeadersWidth = 51;
            this.questionStorageDataGridView.RowTemplate.Height = 29;
            this.questionStorageDataGridView.Size = new System.Drawing.Size(804, 346);
            this.questionStorageDataGridView.TabIndex = 5;
            // 
            // QuestionsStorageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(828, 450);
            this.Controls.Add(this.questionStorageDataGridView);
            this.Controls.Add(this.numberQuestionLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.answerQuestionLabel);
            this.Controls.Add(this.textQuestionLabel);
            this.Controls.Add(this.columLabel);
            this.Name = "QuestionsStorageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.QuestionsStorageForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.questionStorageDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label columLabel;
        private System.Windows.Forms.Label textQuestionLabel;
        private System.Windows.Forms.Label answerQuestionLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label numberQuestionLabel;
        private System.Windows.Forms.DataGridView questionStorageDataGridView;
    }
}