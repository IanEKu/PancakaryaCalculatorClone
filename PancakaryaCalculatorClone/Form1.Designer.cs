namespace PancakaryaCalculatorClone
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tableLayoutPanel1 = new TableLayoutPanel();
            btn0 = new Button();
            plusmin = new Button();
            add = new Button();
            comma = new Button();
            clearAll = new Button();
            modus = new Button();
            clearEntry = new Button();
            deleteBtn = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            divide = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            times = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            minus = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            button20 = new Button();
            button21 = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            count = new Button();
            button23 = new Button();
            history = new Button();
            resultLabel = new TextBox();
            topLabel = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(btn0, 0, 4);
            tableLayoutPanel1.Controls.Add(plusmin, 0, 4);
            tableLayoutPanel1.Controls.Add(add, 0, 4);
            tableLayoutPanel1.Controls.Add(comma, 0, 4);
            tableLayoutPanel1.Controls.Add(clearAll, 2, 0);
            tableLayoutPanel1.Controls.Add(modus, 0, 0);
            tableLayoutPanel1.Controls.Add(clearEntry, 1, 0);
            tableLayoutPanel1.Controls.Add(deleteBtn, 3, 0);
            tableLayoutPanel1.Controls.Add(btn7, 0, 1);
            tableLayoutPanel1.Controls.Add(btn8, 1, 1);
            tableLayoutPanel1.Controls.Add(btn9, 2, 1);
            tableLayoutPanel1.Controls.Add(divide, 3, 1);
            tableLayoutPanel1.Controls.Add(btn4, 0, 2);
            tableLayoutPanel1.Controls.Add(btn5, 1, 2);
            tableLayoutPanel1.Controls.Add(btn6, 2, 2);
            tableLayoutPanel1.Controls.Add(times, 3, 2);
            tableLayoutPanel1.Controls.Add(btn1, 0, 3);
            tableLayoutPanel1.Controls.Add(btn2, 1, 3);
            tableLayoutPanel1.Controls.Add(btn3, 2, 3);
            tableLayoutPanel1.Controls.Add(minus, 3, 3);
            tableLayoutPanel1.Location = new Point(3, 78);
            tableLayoutPanel1.MaximumSize = new Size(365, 350);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(365, 350);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btn0
            // 
            btn0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn0.BackColor = SystemColors.Control;
            btn0.FlatAppearance.BorderColor = Color.Black;
            btn0.FlatStyle = FlatStyle.Flat;
            btn0.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn0.ForeColor = SystemColors.ControlText;
            btn0.Location = new Point(94, 283);
            btn0.Name = "btn0";
            btn0.Size = new Size(85, 64);
            btn0.TabIndex = 20;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // plusmin
            // 
            plusmin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            plusmin.BackColor = SystemColors.Control;
            plusmin.FlatAppearance.BorderColor = Color.Black;
            plusmin.FlatStyle = FlatStyle.Flat;
            plusmin.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            plusmin.ForeColor = SystemColors.ControlText;
            plusmin.Location = new Point(3, 283);
            plusmin.Name = "plusmin";
            plusmin.Size = new Size(85, 64);
            plusmin.TabIndex = 19;
            plusmin.Text = "+/-";
            plusmin.UseVisualStyleBackColor = false;
            plusmin.Click += plusmin_Click;
            // 
            // add
            // 
            add.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            add.BackColor = SystemColors.Control;
            add.BackgroundImageLayout = ImageLayout.Zoom;
            add.FlatStyle = FlatStyle.Flat;
            add.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            add.ForeColor = SystemColors.ControlDarkDark;
            add.Location = new Point(276, 283);
            add.Name = "add";
            add.Size = new Size(86, 64);
            add.TabIndex = 18;
            add.Text = "+";
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click;
            // 
            // comma
            // 
            comma.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comma.BackColor = SystemColors.Control;
            comma.FlatAppearance.BorderColor = Color.Black;
            comma.FlatStyle = FlatStyle.Flat;
            comma.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            comma.ForeColor = SystemColors.ControlText;
            comma.Location = new Point(185, 283);
            comma.Name = "comma";
            comma.Size = new Size(85, 64);
            comma.TabIndex = 17;
            comma.Text = ",";
            comma.UseVisualStyleBackColor = false;
            comma.Click += comma_Click;
            // 
            // clearAll
            // 
            clearAll.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            clearAll.BackColor = SystemColors.Control;
            clearAll.BackgroundImageLayout = ImageLayout.Zoom;
            clearAll.FlatStyle = FlatStyle.Flat;
            clearAll.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            clearAll.ForeColor = SystemColors.ControlDarkDark;
            clearAll.Location = new Point(185, 3);
            clearAll.Name = "clearAll";
            clearAll.Size = new Size(85, 64);
            clearAll.TabIndex = 3;
            clearAll.Text = "C";
            clearAll.UseVisualStyleBackColor = false;
            clearAll.Click += clearAll_Click;
            // 
            // modus
            // 
            modus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            modus.BackColor = SystemColors.Control;
            modus.BackgroundImageLayout = ImageLayout.Zoom;
            modus.FlatStyle = FlatStyle.Flat;
            modus.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            modus.ForeColor = SystemColors.ControlDarkDark;
            modus.Location = new Point(3, 3);
            modus.Name = "modus";
            modus.Size = new Size(85, 64);
            modus.TabIndex = 1;
            modus.Text = "%";
            modus.UseVisualStyleBackColor = false;
            modus.Click += modus_Click;
            // 
            // clearEntry
            // 
            clearEntry.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            clearEntry.BackColor = SystemColors.Control;
            clearEntry.BackgroundImageLayout = ImageLayout.Zoom;
            clearEntry.FlatStyle = FlatStyle.Flat;
            clearEntry.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            clearEntry.ForeColor = SystemColors.ControlDarkDark;
            clearEntry.Location = new Point(94, 3);
            clearEntry.Name = "clearEntry";
            clearEntry.Size = new Size(85, 64);
            clearEntry.TabIndex = 2;
            clearEntry.Text = "CE";
            clearEntry.UseVisualStyleBackColor = false;
            clearEntry.Click += clearEntry_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            deleteBtn.BackColor = SystemColors.Control;
            deleteBtn.BackgroundImage = Properties.Resources.delete_png;
            deleteBtn.BackgroundImageLayout = ImageLayout.Zoom;
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            deleteBtn.ForeColor = SystemColors.ControlDarkDark;
            deleteBtn.Location = new Point(276, 3);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(86, 64);
            deleteBtn.TabIndex = 4;
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // btn7
            // 
            btn7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn7.BackColor = SystemColors.Control;
            btn7.FlatAppearance.BorderColor = Color.Black;
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn7.ForeColor = SystemColors.ControlText;
            btn7.Location = new Point(3, 73);
            btn7.Name = "btn7";
            btn7.Size = new Size(85, 64);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn8.BackColor = SystemColors.Control;
            btn8.FlatAppearance.BorderColor = Color.Black;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn8.ForeColor = SystemColors.ControlText;
            btn8.Location = new Point(94, 73);
            btn8.Name = "btn8";
            btn8.Size = new Size(85, 64);
            btn8.TabIndex = 6;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn9.BackColor = SystemColors.Control;
            btn9.FlatAppearance.BorderColor = Color.Black;
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn9.ForeColor = SystemColors.ControlText;
            btn9.Location = new Point(185, 73);
            btn9.Name = "btn9";
            btn9.Size = new Size(85, 64);
            btn9.TabIndex = 8;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // divide
            // 
            divide.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            divide.BackColor = SystemColors.Control;
            divide.BackgroundImageLayout = ImageLayout.Zoom;
            divide.FlatStyle = FlatStyle.Flat;
            divide.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            divide.ForeColor = SystemColors.ControlDarkDark;
            divide.Location = new Point(276, 73);
            divide.Name = "divide";
            divide.Size = new Size(86, 64);
            divide.TabIndex = 5;
            divide.Text = "/";
            divide.UseVisualStyleBackColor = false;
            divide.Click += divide_Click;
            // 
            // btn4
            // 
            btn4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn4.BackColor = SystemColors.Control;
            btn4.FlatAppearance.BorderColor = Color.Black;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn4.ForeColor = SystemColors.ControlText;
            btn4.Location = new Point(3, 143);
            btn4.Name = "btn4";
            btn4.Size = new Size(85, 64);
            btn4.TabIndex = 9;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn5.BackColor = SystemColors.Control;
            btn5.FlatAppearance.BorderColor = Color.Black;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn5.ForeColor = SystemColors.ControlText;
            btn5.Location = new Point(94, 143);
            btn5.Name = "btn5";
            btn5.Size = new Size(85, 64);
            btn5.TabIndex = 10;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn6.BackColor = SystemColors.Control;
            btn6.FlatAppearance.BorderColor = Color.Black;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn6.ForeColor = SystemColors.ControlText;
            btn6.Location = new Point(185, 143);
            btn6.Name = "btn6";
            btn6.Size = new Size(85, 64);
            btn6.TabIndex = 11;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // times
            // 
            times.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            times.BackColor = SystemColors.Control;
            times.BackgroundImageLayout = ImageLayout.Zoom;
            times.FlatStyle = FlatStyle.Flat;
            times.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            times.ForeColor = SystemColors.ControlDarkDark;
            times.Location = new Point(276, 143);
            times.Name = "times";
            times.Size = new Size(86, 64);
            times.TabIndex = 12;
            times.Text = "X";
            times.UseVisualStyleBackColor = false;
            times.Click += times_Click;
            // 
            // btn1
            // 
            btn1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn1.BackColor = SystemColors.Control;
            btn1.FlatAppearance.BorderColor = Color.Black;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn1.ForeColor = SystemColors.ControlText;
            btn1.Location = new Point(3, 213);
            btn1.Name = "btn1";
            btn1.Size = new Size(85, 64);
            btn1.TabIndex = 13;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn2.BackColor = SystemColors.Control;
            btn2.FlatAppearance.BorderColor = Color.Black;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn2.ForeColor = SystemColors.ControlText;
            btn2.Location = new Point(94, 213);
            btn2.Name = "btn2";
            btn2.Size = new Size(85, 64);
            btn2.TabIndex = 14;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn3.BackColor = SystemColors.Control;
            btn3.FlatAppearance.BorderColor = Color.Black;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn3.ForeColor = SystemColors.ControlText;
            btn3.Location = new Point(185, 213);
            btn3.Name = "btn3";
            btn3.Size = new Size(85, 64);
            btn3.TabIndex = 15;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // minus
            // 
            minus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            minus.BackColor = SystemColors.Control;
            minus.BackgroundImageLayout = ImageLayout.Zoom;
            minus.FlatStyle = FlatStyle.Flat;
            minus.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            minus.ForeColor = SystemColors.ControlDarkDark;
            minus.Location = new Point(276, 213);
            minus.Name = "minus";
            minus.Size = new Size(86, 64);
            minus.TabIndex = 16;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = false;
            minus.Click += minus_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(button20, 0, 4);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // button20
            // 
            button20.BackColor = SystemColors.Control;
            button20.FlatStyle = FlatStyle.Popup;
            button20.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button20.ForeColor = SystemColors.ControlText;
            button20.Location = new Point(3, 83);
            button20.Name = "button20";
            button20.Size = new Size(44, 14);
            button20.TabIndex = 20;
            button20.Text = "%";
            button20.UseVisualStyleBackColor = false;
            // 
            // button21
            // 
            button21.BackColor = SystemColors.Control;
            button21.FlatStyle = FlatStyle.Popup;
            button21.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button21.ForeColor = SystemColors.ControlText;
            button21.Location = new Point(3, 3);
            button21.Name = "button21";
            button21.Size = new Size(44, 65);
            button21.TabIndex = 19;
            button21.Text = "%";
            button21.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.BackColor = Color.Transparent;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Controls.Add(count, 0, 0);
            tableLayoutPanel3.Controls.Add(button23, 0, 0);
            tableLayoutPanel3.Controls.Add(history, 0, 0);
            tableLayoutPanel3.Location = new Point(4, 431);
            tableLayoutPanel3.MaximumSize = new Size(365, 56);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(364, 56);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // count
            // 
            count.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            count.BackColor = SystemColors.Control;
            count.BackgroundImageLayout = ImageLayout.Zoom;
            count.FlatStyle = FlatStyle.Flat;
            count.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            count.ForeColor = SystemColors.ControlDarkDark;
            count.Location = new Point(245, 3);
            count.Name = "count";
            count.Size = new Size(116, 50);
            count.TabIndex = 22;
            count.Text = "=";
            count.UseVisualStyleBackColor = false;
            count.Click += count_Click;
            // 
            // button23
            // 
            button23.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button23.BackColor = SystemColors.Control;
            button23.BackgroundImage = Properties.Resources.info_png;
            button23.BackgroundImageLayout = ImageLayout.Zoom;
            button23.FlatStyle = FlatStyle.Flat;
            button23.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button23.ForeColor = SystemColors.ControlDarkDark;
            button23.Location = new Point(124, 3);
            button23.Name = "button23";
            button23.Size = new Size(115, 50);
            button23.TabIndex = 21;
            button23.UseVisualStyleBackColor = false;
            button23.Click += information_Click;
            // 
            // history
            // 
            history.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            history.BackColor = SystemColors.Control;
            history.BackgroundImage = Properties.Resources.history_png;
            history.BackgroundImageLayout = ImageLayout.Zoom;
            history.FlatStyle = FlatStyle.Flat;
            history.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            history.ForeColor = SystemColors.ControlDarkDark;
            history.Location = new Point(3, 3);
            history.Name = "history";
            history.Size = new Size(115, 50);
            history.TabIndex = 20;
            history.UseVisualStyleBackColor = false;
            history.Click += history_Click;
            // 
            // resultLabel
            // 
            resultLabel.BackColor = SystemColors.Control;
            resultLabel.BorderStyle = BorderStyle.None;
            resultLabel.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            resultLabel.Location = new Point(7, 25);
            resultLabel.MaxLength = 18;
            resultLabel.Name = "resultLabel";
            resultLabel.ReadOnly = true;
            resultLabel.RightToLeft = RightToLeft.No;
            resultLabel.ShortcutsEnabled = false;
            resultLabel.Size = new Size(358, 47);
            resultLabel.TabIndex = 4;
            resultLabel.TextAlign = HorizontalAlignment.Right;
            // 
            // topLabel
            // 
            topLabel.BackColor = SystemColors.Control;
            topLabel.BorderStyle = BorderStyle.None;
            topLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            topLabel.Location = new Point(7, 2);
            topLabel.MaxLength = 18;
            topLabel.Name = "topLabel";
            topLabel.ReadOnly = true;
            topLabel.RightToLeft = RightToLeft.No;
            topLabel.ShortcutsEnabled = false;
            topLabel.Size = new Size(358, 32);
            topLabel.TabIndex = 5;
            topLabel.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(370, 489);
            Controls.Add(topLabel);
            Controls.Add(resultLabel);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Opacity = 0.95D;
            Text = "Calculator";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Button clearAll;
        private Button modus;
        private Button clearEntry;
        private Button deleteBtn;
        private Button btn0;
        private Button plusmin;
        private Button add;
        private Button comma;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button divide;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button times;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button minus;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button20;
        private Button button21;
        private TableLayoutPanel tableLayoutPanel3;
        private Button count;
        private Button button23;
        private Button history;
        private TextBox resultLabel;
        private TextBox topLabel;
    }
}