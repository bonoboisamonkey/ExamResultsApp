namespace LessonsForm
{
    partial class FinalForm
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
            this.list_exams = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // list_exams
            // 
            this.list_exams.HideSelection = false;
            this.list_exams.Location = new System.Drawing.Point(80, 115);
            this.list_exams.Name = "list_exams";
            this.list_exams.Size = new System.Drawing.Size(490, 293);
            this.list_exams.TabIndex = 0;
            this.list_exams.UseCompatibleStateImageBehavior = false;
            this.list_exams.View = System.Windows.Forms.View.List;
            // 
            // FinalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 458);
            this.Controls.Add(this.list_exams);
            this.Name = "FinalForm";
            this.Text = "FinalForm";
            this.Load += new System.EventHandler(this.FinalForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView list_exams;
    }
}