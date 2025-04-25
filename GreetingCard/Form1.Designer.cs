namespace GreetingCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.yesButton = new System.Windows.Forms.Button();
            this.noButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yesButton
            // 
            this.yesButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.yesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yesButton.Font = new System.Drawing.Font("Edwardian Script ITC", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesButton.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.yesButton.Location = new System.Drawing.Point(50, 481);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(111, 77);
            this.yesButton.TabIndex = 0;
            this.yesButton.Text = "Yes";
            this.yesButton.UseVisualStyleBackColor = false;
            this.yesButton.Visible = false;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // noButton
            // 
            this.noButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.noButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noButton.Font = new System.Drawing.Font("Edwardian Script ITC", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noButton.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.noButton.Location = new System.Drawing.Point(325, 481);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(111, 77);
            this.noButton.TabIndex = 1;
            this.noButton.Text = "No";
            this.noButton.UseVisualStyleBackColor = false;
            this.noButton.Visible = false;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(502, 583);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.yesButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Happy Valentine\'s Day!";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Button noButton;
    }
}

