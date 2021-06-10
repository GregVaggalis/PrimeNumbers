
namespace InterviewProject
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPanel = new System.Windows.Forms.Panel();
            this.IntContainer = new System.Windows.Forms.RichTextBox();
            this.TogglePrimes = new System.Windows.Forms.CheckBox();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.IntContainer);
            this.MainPanel.Location = new System.Drawing.Point(12, 66);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(628, 349);
            this.MainPanel.TabIndex = 0;
            // 
            // IntContainer
            // 
            this.IntContainer.BackColor = System.Drawing.SystemColors.Menu;
            this.IntContainer.Cursor = System.Windows.Forms.Cursors.Default;
            this.IntContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IntContainer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IntContainer.Location = new System.Drawing.Point(0, 0);
            this.IntContainer.Name = "IntContainer";
            this.IntContainer.ReadOnly = true;
            this.IntContainer.Size = new System.Drawing.Size(628, 349);
            this.IntContainer.TabIndex = 0;
            this.IntContainer.Text = "";
            // 
            // TogglePrimes
            // 
            this.TogglePrimes.AutoSize = true;
            this.TogglePrimes.Location = new System.Drawing.Point(12, 421);
            this.TogglePrimes.Name = "TogglePrimes";
            this.TogglePrimes.Size = new System.Drawing.Size(62, 19);
            this.TogglePrimes.TabIndex = 1;
            this.TogglePrimes.Text = "Primes";
            this.TogglePrimes.UseVisualStyleBackColor = true;
            this.TogglePrimes.CheckedChanged += new System.EventHandler(this.TogglePrimes_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 490);
            this.Controls.Add(this.TogglePrimes);
            this.Controls.Add(this.MainPanel);
            this.Name = "MainForm";
            this.Text = "Prime Integer Finder";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.RichTextBox IntContainer;
        private System.Windows.Forms.CheckBox TogglePrimes;
    }
}

