namespace AIMind
{
    partial class InOut
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
            this.lblOutputLabel = new System.Windows.Forms.Label();
            this.inputWindow = new System.Windows.Forms.TextBox();
            this.YesButton = new System.Windows.Forms.Button();
            this.noButton = new System.Windows.Forms.Button();
            this.btnListVocabulary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOutputLabel
            // 
            this.lblOutputLabel.AutoSize = true;
            this.lblOutputLabel.Location = new System.Drawing.Point(73, 179);
            this.lblOutputLabel.Name = "lblOutputLabel";
            this.lblOutputLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblOutputLabel.Size = new System.Drawing.Size(131, 13);
            this.lblOutputLabel.TabIndex = 1;
            this.lblOutputLabel.Text = "my responses appear here";
            // 
            // inputWindow
            // 
            this.inputWindow.Location = new System.Drawing.Point(13, 13);
            this.inputWindow.Name = "inputWindow";
            this.inputWindow.Size = new System.Drawing.Size(259, 20);
            this.inputWindow.TabIndex = 2;
            this.inputWindow.Text = "type here";
            this.inputWindow.TextChanged += new System.EventHandler(this.inputWindow_TextChanged);
            // 
            // YesButton
            // 
            this.YesButton.Location = new System.Drawing.Point(13, 227);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(75, 23);
            this.YesButton.TabIndex = 3;
            this.YesButton.Text = "Yes";
            this.YesButton.UseVisualStyleBackColor = true;
            this.YesButton.Visible = false;
            this.YesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // noButton
            // 
            this.noButton.Location = new System.Drawing.Point(196, 227);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(75, 23);
            this.noButton.TabIndex = 4;
            this.noButton.Text = "No";
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.Visible = false;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // btnListVocabulary
            // 
            this.btnListVocabulary.Location = new System.Drawing.Point(196, 39);
            this.btnListVocabulary.Name = "btnListVocabulary";
            this.btnListVocabulary.Size = new System.Drawing.Size(75, 74);
            this.btnListVocabulary.TabIndex = 5;
            this.btnListVocabulary.Text = "List Vocabulary";
            this.btnListVocabulary.UseVisualStyleBackColor = true;
            this.btnListVocabulary.Click += new System.EventHandler(this.btnListVocabulary_Click);
            // 
            // InOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnListVocabulary);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.YesButton);
            this.Controls.Add(this.inputWindow);
            this.Controls.Add(this.lblOutputLabel);
            this.Name = "InOut";
            this.Text = "AIMind";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOutputLabel;
        private System.Windows.Forms.TextBox inputWindow;
        private System.Windows.Forms.Button YesButton;
        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.Button btnListVocabulary;

    }
}

