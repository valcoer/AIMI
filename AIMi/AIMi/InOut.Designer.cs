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
            this.outputWindow = new System.Windows.Forms.Label();
            this.inputWindow = new System.Windows.Forms.TextBox();
            this.YesButton = new System.Windows.Forms.Button();
            this.noButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputWindow
            // 
            this.outputWindow.AutoSize = true;
            this.outputWindow.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.outputWindow.Location = new System.Drawing.Point(73, 179);
            this.outputWindow.Name = "outputWindow";
            this.outputWindow.Size = new System.Drawing.Size(131, 13);
            this.outputWindow.TabIndex = 1;
            this.outputWindow.Text = "my responses appear here";
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
            this.YesButton.Text = "Yes!";
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
            // InOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.YesButton);
            this.Controls.Add(this.inputWindow);
            this.Controls.Add(this.outputWindow);
            this.Name = "InOut";
            this.Text = "AIMind";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label outputWindow;
        private System.Windows.Forms.TextBox inputWindow;
        private System.Windows.Forms.Button YesButton;
        private System.Windows.Forms.Button noButton;

    }
}

