namespace BookThing3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lOut = new System.Windows.Forms.TextBox();
            this.bOut = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Refrence Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Linear";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Binary";
            // 
            // lOut
            // 
            this.lOut.Location = new System.Drawing.Point(124, 137);
            this.lOut.Name = "lOut";
            this.lOut.Size = new System.Drawing.Size(327, 20);
            this.lOut.TabIndex = 4;
            // 
            // bOut
            // 
            this.bOut.Location = new System.Drawing.Point(124, 177);
            this.bOut.Name = "bOut";
            this.bOut.Size = new System.Drawing.Size(327, 20);
            this.bOut.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::BookThing3.Properties.Resources._9915b39a365d77d780c53ecce570a433a389aae4;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(472, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 305);
            this.button1.TabIndex = 8;
            this.button1.Text = "GO!!!!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.Location = new System.Drawing.Point(124, 15);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(327, 98);
            this.outputLabel.TabIndex = 10;
            this.outputLabel.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BookThing3.Properties.Resources._900_Art_Design_Works_Fractal_Art_III;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bOut);
            this.Controls.Add(this.lOut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lOut;
        private System.Windows.Forms.TextBox bOut;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox outputLabel;
    }
}

