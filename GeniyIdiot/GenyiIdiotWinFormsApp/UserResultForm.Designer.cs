
namespace GenyiIdiotWinFormsApp
{
    partial class UserResultForm
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
            this.userResultLabel = new System.Windows.Forms.Label();
            this.columLabel = new System.Windows.Forms.Label();
            this.backMenuButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.countRightAnswerLabel = new System.Windows.Forms.Label();
            this.diagnoseLabel = new System.Windows.Forms.Label();
            this.nameUserLabel = new System.Windows.Forms.Label();
            this.rigthAnswerLabel = new System.Windows.Forms.Label();
            this.diagnosesLabel = new System.Windows.Forms.Label();
            this.userResultDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.userResultDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // userResultLabel
            // 
            this.userResultLabel.AutoSize = true;
            this.userResultLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userResultLabel.Location = new System.Drawing.Point(321, 154);
            this.userResultLabel.Name = "userResultLabel";
            this.userResultLabel.Size = new System.Drawing.Size(0, 28);
            this.userResultLabel.TabIndex = 0;
            // 
            // columLabel
            // 
            this.columLabel.AutoSize = true;
            this.columLabel.Location = new System.Drawing.Point(38, 41);
            this.columLabel.Name = "columLabel";
            this.columLabel.Size = new System.Drawing.Size(50, 20);
            this.columLabel.TabIndex = 1;
            this.columLabel.Text = "label1";
            // 
            // backMenuButton
            // 
            this.backMenuButton.Location = new System.Drawing.Point(187, 412);
            this.backMenuButton.Name = "backMenuButton";
            this.backMenuButton.Size = new System.Drawing.Size(94, 29);
            this.backMenuButton.TabIndex = 2;
            this.backMenuButton.Text = "НАЗАД";
            this.backMenuButton.UseVisualStyleBackColor = true;
            this.backMenuButton.Click += new System.EventHandler(this.backMenuButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(68, 111);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 20);
            this.nameLabel.TabIndex = 3;
            // 
            // countRightAnswerLabel
            // 
            this.countRightAnswerLabel.AutoSize = true;
            this.countRightAnswerLabel.Location = new System.Drawing.Point(156, 111);
            this.countRightAnswerLabel.Name = "countRightAnswerLabel";
            this.countRightAnswerLabel.Size = new System.Drawing.Size(0, 20);
            this.countRightAnswerLabel.TabIndex = 4;
            // 
            // diagnoseLabel
            // 
            this.diagnoseLabel.AutoSize = true;
            this.diagnoseLabel.Location = new System.Drawing.Point(250, 111);
            this.diagnoseLabel.Name = "diagnoseLabel";
            this.diagnoseLabel.Size = new System.Drawing.Size(0, 20);
            this.diagnoseLabel.TabIndex = 5;
            // 
            // nameUserLabel
            // 
            this.nameUserLabel.AutoSize = true;
            this.nameUserLabel.Location = new System.Drawing.Point(38, 91);
            this.nameUserLabel.Name = "nameUserLabel";
            this.nameUserLabel.Size = new System.Drawing.Size(0, 20);
            this.nameUserLabel.TabIndex = 6;
            // 
            // rigthAnswerLabel
            // 
            this.rigthAnswerLabel.AutoSize = true;
            this.rigthAnswerLabel.Location = new System.Drawing.Point(165, 91);
            this.rigthAnswerLabel.Name = "rigthAnswerLabel";
            this.rigthAnswerLabel.Size = new System.Drawing.Size(0, 20);
            this.rigthAnswerLabel.TabIndex = 7;
            // 
            // diagnosesLabel
            // 
            this.diagnosesLabel.AutoSize = true;
            this.diagnosesLabel.Location = new System.Drawing.Point(321, 91);
            this.diagnosesLabel.Name = "diagnosesLabel";
            this.diagnosesLabel.Size = new System.Drawing.Size(0, 20);
            this.diagnosesLabel.TabIndex = 8;
            // 
            // userResultDataGridView
            // 
            this.userResultDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.userResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userResultDataGridView.Location = new System.Drawing.Point(12, 12);
            this.userResultDataGridView.Name = "userResultDataGridView";
            this.userResultDataGridView.RowHeadersWidth = 51;
            this.userResultDataGridView.RowTemplate.Height = 29;
            this.userResultDataGridView.Size = new System.Drawing.Size(452, 354);
            this.userResultDataGridView.TabIndex = 9;
            // 
            // UserResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(476, 453);
            this.Controls.Add(this.userResultDataGridView);
            this.Controls.Add(this.diagnosesLabel);
            this.Controls.Add(this.rigthAnswerLabel);
            this.Controls.Add(this.nameUserLabel);
            this.Controls.Add(this.diagnoseLabel);
            this.Controls.Add(this.countRightAnswerLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.backMenuButton);
            this.Controls.Add(this.columLabel);
            this.Controls.Add(this.userResultLabel);
            this.Name = "UserResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.UserResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userResultDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userResultLabel;
        private System.Windows.Forms.Label columLabel;
        private System.Windows.Forms.Button backMenuButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label countRightAnswerLabel;
        private System.Windows.Forms.Label diagnoseLabel;
        private System.Windows.Forms.Label nameUserLabel;
        private System.Windows.Forms.Label rigthAnswerLabel;
        private System.Windows.Forms.Label diagnosesLabel;
        private System.Windows.Forms.DataGridView userResultDataGridView;
    }
}