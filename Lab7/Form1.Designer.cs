namespace Lab7
{
    partial class Form1
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
            this.enterDistanceLabel = new System.Windows.Forms.Label();
            this.priceIsLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.milesTextbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enterDistanceLabel
            // 
            this.enterDistanceLabel.AutoSize = true;
            this.enterDistanceLabel.Location = new System.Drawing.Point(45, 20);
            this.enterDistanceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.enterDistanceLabel.Name = "enterDistanceLabel";
            this.enterDistanceLabel.Size = new System.Drawing.Size(149, 17);
            this.enterDistanceLabel.TabIndex = 0;
            this.enterDistanceLabel.Text = "Enter distance (miles):";
            // 
            // priceIsLabel
            // 
            this.priceIsLabel.AutoSize = true;
            this.priceIsLabel.Location = new System.Drawing.Point(147, 85);
            this.priceIsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceIsLabel.Name = "priceIsLabel";
            this.priceIsLabel.Size = new System.Drawing.Size(44, 17);
            this.priceIsLabel.TabIndex = 1;
            this.priceIsLabel.Text = "Price:";
            // 
            // priceLabel
            // 
            this.priceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceLabel.Location = new System.Drawing.Point(200, 84);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(133, 24);
            this.priceLabel.TabIndex = 2;
            // 
            // milesTextbox
            // 
            this.milesTextbox.Location = new System.Drawing.Point(200, 16);
            this.milesTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.milesTextbox.Name = "milesTextbox";
            this.milesTextbox.Size = new System.Drawing.Size(132, 22);
            this.milesTextbox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 134);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 177);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.milesTextbox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.priceIsLabel);
            this.Controls.Add(this.enterDistanceLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterDistanceLabel;
        private System.Windows.Forms.Label priceIsLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox milesTextbox;
        private System.Windows.Forms.Button button1;
    }
}

