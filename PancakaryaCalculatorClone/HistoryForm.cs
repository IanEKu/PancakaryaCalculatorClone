using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PancakaryaCalculatorClone
{
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
            int topOffset = 12;
            MaximizeBox = false;
            for (int i = 0; i < Data.historyList.Count; i++)
            {
                string history = Data.historyList[i];
                string result = history.Split(' ').Last();

                GroupBox dataGb = new GroupBox();
                TextBox calculationTb = new TextBox();
                TextBox resultTb = new TextBox();
                // 
                // dataGb
                // 
                dataGb.Location = new Point(12, topOffset);
                dataGb.Name = $"dataGb{i}";
                dataGb.Size = new Size(350, 109);
                dataGb.TabIndex = 0;
                dataGb.TabStop = false;
                dataGb.Text = $"Data {i + 1}";
                // 
                // calculationTb
                // 
                calculationTb.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                calculationTb.BackColor = SystemColors.Control;
                calculationTb.BorderStyle = BorderStyle.None;
                calculationTb.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
                calculationTb.ForeColor = SystemColors.WindowFrame;
                calculationTb.Location = new Point(6, 18);
                calculationTb.Name = $"calculationTb{i}";
                calculationTb.Size = new Size(338, 32);
                calculationTb.TabIndex = 0;
                calculationTb.ReadOnly = true;
                calculationTb.Text = history.Remove(history.IndexOf('=') + 1);
                calculationTb.TextAlign = HorizontalAlignment.Right;
                // 
                // resultTb
                // 
                resultTb.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                resultTb.BackColor = SystemColors.Control;
                resultTb.BorderStyle = BorderStyle.None;
                resultTb.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
                resultTb.Location = new Point(6, 47);
                resultTb.Name = $"resultTb{i}";
                resultTb.Size = new Size(338, 47);
                resultTb.TabIndex = 1;
                calculationTb.ReadOnly = true;
                resultTb.Text = result;
                resultTb.TextAlign = HorizontalAlignment.Right;

                dataGb.Controls.Add(calculationTb);
                dataGb.Controls.Add(resultTb);

                historyPanel.Controls.Add(dataGb);
                topOffset += dataGb.Height + 12;
            }
        }

        private void deleteHistory_Click(object sender, EventArgs e)
        {
            Data.historyList.Clear();
            historyPanel.Controls.Clear();
        }
    }
}
