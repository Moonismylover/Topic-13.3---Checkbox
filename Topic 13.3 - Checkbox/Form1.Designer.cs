namespace Topic_13._3___Checkbox
{
    partial class FormCheckDemo
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
            this.lblinstruction = new System.Windows.Forms.Label();
            this.chkStarTrek = new System.Windows.Forms.CheckBox();
            this.chkStarWars = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblinstruction
            // 
            this.lblinstruction.AutoSize = true;
            this.lblinstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinstruction.Location = new System.Drawing.Point(13, 13);
            this.lblinstruction.Name = "lblinstruction";
            this.lblinstruction.Size = new System.Drawing.Size(242, 24);
            this.lblinstruction.TabIndex = 0;
            this.lblinstruction.Text = "Please make a selection:";
            // 
            // chkStarTrek
            // 
            this.chkStarTrek.AutoSize = true;
            this.chkStarTrek.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkStarTrek.Location = new System.Drawing.Point(17, 55);
            this.chkStarTrek.Name = "chkStarTrek";
            this.chkStarTrek.Size = new System.Drawing.Size(146, 30);
            this.chkStarTrek.TabIndex = 1;
            this.chkStarTrek.Text = "I like Star Trek";
            this.chkStarTrek.UseVisualStyleBackColor = true;
            // 
            // chkStarWars
            // 
            this.chkStarWars.AutoSize = true;
            this.chkStarWars.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkStarWars.Location = new System.Drawing.Point(190, 55);
            this.chkStarWars.Name = "chkStarWars";
            this.chkStarWars.Size = new System.Drawing.Size(153, 30);
            this.chkStarWars.TabIndex = 2;
            this.chkStarWars.Text = "I like Star Wars";
            this.chkStarWars.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Californian FB", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(17, 100);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(326, 36);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(17, 157);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(75, 22);
            this.lblResults.TabIndex = 4;
            this.lblResults.Text = "Results: ";
            // 
            // FormCheckDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 193);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.chkStarWars);
            this.Controls.Add(this.chkStarTrek);
            this.Controls.Add(this.lblinstruction);
            this.Name = "FormCheckDemo";
            this.Text = "CheckBox Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblinstruction;
        private System.Windows.Forms.CheckBox chkStarTrek;
        private System.Windows.Forms.CheckBox chkStarWars;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblResults;
    }
}

