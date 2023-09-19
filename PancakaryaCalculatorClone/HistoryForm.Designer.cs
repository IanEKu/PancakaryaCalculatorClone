namespace PancakaryaCalculatorClone
{
    partial class HistoryForm
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
            historyPanel = new Panel();
            deleteHistory = new Button();
            SuspendLayout();
            // 
            // historyPanel
            // 
            historyPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            historyPanel.AutoScroll = true;
            historyPanel.Location = new Point(1, 0);
            historyPanel.MinimumSize = new Size(372, 268);
            historyPanel.Name = "historyPanel";
            historyPanel.Size = new Size(372, 268);
            historyPanel.TabIndex = 0;
            // 
            // deleteHistory
            // 
            deleteHistory.BackgroundImage = Properties.Resources.bin_png;
            deleteHistory.BackgroundImageLayout = ImageLayout.Zoom;
            deleteHistory.Location = new Point(1, 263);
            deleteHistory.Name = "deleteHistory";
            deleteHistory.Size = new Size(372, 38);
            deleteHistory.TabIndex = 1;
            deleteHistory.UseVisualStyleBackColor = true;
            deleteHistory.Click += deleteHistory_Click;
            // 
            // HistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 302);
            Controls.Add(deleteHistory);
            Controls.Add(historyPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "HistoryForm";
            ShowIcon = false;
            Text = "History";
            ResumeLayout(false);
        }

        #endregion

        private Panel historyPanel;
        private Button deleteHistory;
    }
}