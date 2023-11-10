namespace RegEx_Morfolojik_Analiz_App
{
    partial class AnalysisResultsForm
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
            this.lstAnalysisResults = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstAnalysisResults
            // 
            this.lstAnalysisResults.FormattingEnabled = true;
            this.lstAnalysisResults.ItemHeight = 20;
            this.lstAnalysisResults.Location = new System.Drawing.Point(42, 29);
            this.lstAnalysisResults.Name = "lstAnalysisResults";
            this.lstAnalysisResults.Size = new System.Drawing.Size(697, 364);
            this.lstAnalysisResults.TabIndex = 0;
            // 
            // AnalysisResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstAnalysisResults);
            this.Name = "AnalysisResultsForm";
            this.Text = "AnalysisResultsForm";
            this.Load += new System.EventHandler(this.AnalysisResultsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstAnalysisResults;
    }
}