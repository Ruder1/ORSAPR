namespace HangersPlugin
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainTextLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.InnerRadiusLabel = new System.Windows.Forms.Label();
            this.OuterRadiusLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.InnerHeightLabel = new System.Windows.Forms.Label();
            this.RecessRadiusLabel = new System.Windows.Forms.Label();
            this.LengthCenterRecessLabel = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.InnerRadiusTextBox = new System.Windows.Forms.TextBox();
            this.OuterRadiusTextBox = new System.Windows.Forms.TextBox();
            this.InnerHeightTextBox = new System.Windows.Forms.TextBox();
            this.RecessRadiusTextBox = new System.Windows.Forms.TextBox();
            this.LengthCenterRecessTextBox = new System.Windows.Forms.TextBox();
            this.BuildButton = new System.Windows.Forms.Button();
            this.HeightToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.LengthToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.WidthToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.InnerRadiusToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.OuterRadiusToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.InnerHeightToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.RecessRadiusToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.LengthCenterRecessToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // MainTextLabel
            // 
            this.MainTextLabel.AutoSize = true;
            this.MainTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainTextLabel.Location = new System.Drawing.Point(12, 9);
            this.MainTextLabel.Name = "MainTextLabel";
            this.MainTextLabel.Size = new System.Drawing.Size(281, 20);
            this.MainTextLabel.TabIndex = 0;
            this.MainTextLabel.Text = "Write the input data for Hangers below";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightLabel.Location = new System.Drawing.Point(12, 49);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(100, 20);
            this.HeightLabel.TabIndex = 1;
            this.HeightLabel.Text = "Height (mm):";
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LengthLabel.Location = new System.Drawing.Point(12, 75);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(103, 20);
            this.LengthLabel.TabIndex = 2;
            this.LengthLabel.Text = "Length (mm):";
            // 
            // InnerRadiusLabel
            // 
            this.InnerRadiusLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.InnerRadiusLabel.AutoSize = true;
            this.InnerRadiusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InnerRadiusLabel.Location = new System.Drawing.Point(12, 127);
            this.InnerRadiusLabel.Name = "InnerRadiusLabel";
            this.InnerRadiusLabel.Size = new System.Drawing.Size(144, 20);
            this.InnerRadiusLabel.TabIndex = 3;
            this.InnerRadiusLabel.Text = "Inner Radius (mm):";
            // 
            // OuterRadiusLabel
            // 
            this.OuterRadiusLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.OuterRadiusLabel.AutoSize = true;
            this.OuterRadiusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OuterRadiusLabel.Location = new System.Drawing.Point(12, 205);
            this.OuterRadiusLabel.Name = "OuterRadiusLabel";
            this.OuterRadiusLabel.Size = new System.Drawing.Size(147, 20);
            this.OuterRadiusLabel.TabIndex = 4;
            this.OuterRadiusLabel.Text = "Outer Radius (mm):";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WidthLabel.Location = new System.Drawing.Point(12, 101);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(94, 20);
            this.WidthLabel.TabIndex = 5;
            this.WidthLabel.Text = "Width (mm):";
            // 
            // InnerHeightLabel
            // 
            this.InnerHeightLabel.AutoSize = true;
            this.InnerHeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InnerHeightLabel.Location = new System.Drawing.Point(12, 179);
            this.InnerHeightLabel.Name = "InnerHeightLabel";
            this.InnerHeightLabel.Size = new System.Drawing.Size(206, 20);
            this.InnerHeightLabel.TabIndex = 6;
            this.InnerHeightLabel.Text = "Inner Height Hangers (mm):";
            // 
            // RecessRadiusLabel
            // 
            this.RecessRadiusLabel.AutoSize = true;
            this.RecessRadiusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecessRadiusLabel.Location = new System.Drawing.Point(12, 153);
            this.RecessRadiusLabel.Name = "RecessRadiusLabel";
            this.RecessRadiusLabel.Size = new System.Drawing.Size(161, 20);
            this.RecessRadiusLabel.TabIndex = 7;
            this.RecessRadiusLabel.Text = "Recess Radius (mm):";
            // 
            // LengthCenterRecessLabel
            // 
            this.LengthCenterRecessLabel.AutoSize = true;
            this.LengthCenterRecessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LengthCenterRecessLabel.Location = new System.Drawing.Point(12, 231);
            this.LengthCenterRecessLabel.Name = "LengthCenterRecessLabel";
            this.LengthCenterRecessLabel.Size = new System.Drawing.Size(274, 20);
            this.LengthCenterRecessLabel.TabIndex = 8;
            this.LengthCenterRecessLabel.Text = "Length from center to recesses (mm):";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.AccessibleDescription = "";
            this.HeightTextBox.Location = new System.Drawing.Point(332, 51);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(71, 20);
            this.HeightTextBox.TabIndex = 9;
            this.HeightToolTip.SetToolTip(this.HeightTextBox, "Height of Hangers must be between: 200 - 230");
            this.HeightTextBox.TextChanged += new System.EventHandler(this.HeightTextBox_TextChanged);
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Location = new System.Drawing.Point(332, 77);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(71, 20);
            this.LengthTextBox.TabIndex = 10;
            this.LengthToolTip.SetToolTip(this.LengthTextBox, "Length of Hangers must be between: 390 - 470");
            this.LengthTextBox.TextChanged += new System.EventHandler(this.LengthTextBox_TextChanged);
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(332, 103);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(71, 20);
            this.WidthTextBox.TabIndex = 11;
            this.WidthToolTip.SetToolTip(this.WidthTextBox, "Width of Hangers must be between: 4 - 6");
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // InnerRadiusTextBox
            // 
            this.InnerRadiusTextBox.Location = new System.Drawing.Point(332, 129);
            this.InnerRadiusTextBox.Name = "InnerRadiusTextBox";
            this.InnerRadiusTextBox.Size = new System.Drawing.Size(71, 20);
            this.InnerRadiusTextBox.TabIndex = 12;
            this.InnerRadiusToolTip.SetToolTip(this.InnerRadiusTextBox, "Inner Radius of Hangers must be between: 15 - 25");
            this.InnerRadiusTextBox.TextChanged += new System.EventHandler(this.InnerRadiusTextBox_TextChanged);
            // 
            // OuterRadiusTextBox
            // 
            this.OuterRadiusTextBox.Enabled = false;
            this.OuterRadiusTextBox.Location = new System.Drawing.Point(332, 205);
            this.OuterRadiusTextBox.Name = "OuterRadiusTextBox";
            this.OuterRadiusTextBox.Size = new System.Drawing.Size(71, 20);
            this.OuterRadiusTextBox.TabIndex = 13;
            this.OuterRadiusToolTip.SetToolTip(this.OuterRadiusTextBox, "The outer radius is built according to the dependence: Inner Radius + 10");
            // 
            // InnerHeightTextBox
            // 
            this.InnerHeightTextBox.Enabled = false;
            this.InnerHeightTextBox.Location = new System.Drawing.Point(332, 181);
            this.InnerHeightTextBox.Name = "InnerHeightTextBox";
            this.InnerHeightTextBox.Size = new System.Drawing.Size(71, 20);
            this.InnerHeightTextBox.TabIndex = 14;
            this.InnerHeightToolTip.SetToolTip(this.InnerHeightTextBox, "The inner height is built according to the dependence: (Height-1)/2");
            // 
            // RecessRadiusTextBox
            // 
            this.RecessRadiusTextBox.Location = new System.Drawing.Point(332, 155);
            this.RecessRadiusTextBox.Name = "RecessRadiusTextBox";
            this.RecessRadiusTextBox.Size = new System.Drawing.Size(71, 20);
            this.RecessRadiusTextBox.TabIndex = 15;
            this.RecessRadiusToolTip.SetToolTip(this.RecessRadiusTextBox, "Recess radius  must  be between: 3 - 4");
            this.RecessRadiusTextBox.TextChanged += new System.EventHandler(this.RecessRadiusTextBox_TextChanged);
            // 
            // LengthCenterRecessTextBox
            // 
            this.LengthCenterRecessTextBox.Enabled = false;
            this.LengthCenterRecessTextBox.Location = new System.Drawing.Point(332, 233);
            this.LengthCenterRecessTextBox.Name = "LengthCenterRecessTextBox";
            this.LengthCenterRecessTextBox.Size = new System.Drawing.Size(71, 20);
            this.LengthCenterRecessTextBox.TabIndex = 16;
            this.LengthCenterRecessToolTip.SetToolTip(this.LengthCenterRecessTextBox, "Length from center to recess is built according to the dependence: Length * 3/4");
            // 
            // BuildButton
            // 
            this.BuildButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuildButton.Location = new System.Drawing.Point(328, 277);
            this.BuildButton.Name = "BuildButton";
            this.BuildButton.Size = new System.Drawing.Size(75, 26);
            this.BuildButton.TabIndex = 17;
            this.BuildButton.Text = "Build";
            this.BuildButton.UseVisualStyleBackColor = true;
            this.BuildButton.Click += new System.EventHandler(this.BuildButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 315);
            this.Controls.Add(this.BuildButton);
            this.Controls.Add(this.LengthCenterRecessTextBox);
            this.Controls.Add(this.RecessRadiusTextBox);
            this.Controls.Add(this.InnerHeightTextBox);
            this.Controls.Add(this.OuterRadiusTextBox);
            this.Controls.Add(this.InnerRadiusTextBox);
            this.Controls.Add(this.WidthTextBox);
            this.Controls.Add(this.LengthTextBox);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.LengthCenterRecessLabel);
            this.Controls.Add(this.RecessRadiusLabel);
            this.Controls.Add(this.InnerHeightLabel);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.OuterRadiusLabel);
            this.Controls.Add(this.InnerRadiusLabel);
            this.Controls.Add(this.LengthLabel);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.MainTextLabel);
            this.Name = "MainForm";
            this.Text = "Hangers For Clothes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainTextLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.Label InnerRadiusLabel;
        private System.Windows.Forms.Label OuterRadiusLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label InnerHeightLabel;
        private System.Windows.Forms.Label RecessRadiusLabel;
        private System.Windows.Forms.Label LengthCenterRecessLabel;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.TextBox LengthTextBox;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.TextBox InnerRadiusTextBox;
        private System.Windows.Forms.TextBox OuterRadiusTextBox;
        private System.Windows.Forms.TextBox InnerHeightTextBox;
        private System.Windows.Forms.TextBox RecessRadiusTextBox;
        private System.Windows.Forms.TextBox LengthCenterRecessTextBox;
        private System.Windows.Forms.Button BuildButton;
        private System.Windows.Forms.ToolTip HeightToolTip;
        private System.Windows.Forms.ToolTip LengthToolTip;
        private System.Windows.Forms.ToolTip WidthToolTip;
        private System.Windows.Forms.ToolTip InnerRadiusToolTip;
        private System.Windows.Forms.ToolTip OuterRadiusToolTip;
        private System.Windows.Forms.ToolTip InnerHeightToolTip;
        private System.Windows.Forms.ToolTip RecessRadiusToolTip;
        private System.Windows.Forms.ToolTip LengthCenterRecessToolTip;
    }
}

