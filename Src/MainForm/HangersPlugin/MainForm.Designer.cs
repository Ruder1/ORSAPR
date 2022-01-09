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
            this.BuildBracingPantsLabel = new System.Windows.Forms.Label();
            this.BracingPantsComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // MainTextLabel
            // 
            this.MainTextLabel.AutoSize = true;
            this.MainTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainTextLabel.Location = new System.Drawing.Point(16, 11);
            this.MainTextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MainTextLabel.Name = "MainTextLabel";
            this.MainTextLabel.Size = new System.Drawing.Size(342, 25);
            this.MainTextLabel.TabIndex = 0;
            this.MainTextLabel.Text = "Write the input data for Hangers below";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightLabel.Location = new System.Drawing.Point(16, 60);
            this.HeightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(125, 25);
            this.HeightLabel.TabIndex = 1;
            this.HeightLabel.Text = "Height (mm):";
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LengthLabel.Location = new System.Drawing.Point(16, 92);
            this.LengthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(129, 25);
            this.LengthLabel.TabIndex = 2;
            this.LengthLabel.Text = "Length (mm):";
            // 
            // InnerRadiusLabel
            // 
            this.InnerRadiusLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.InnerRadiusLabel.AutoSize = true;
            this.InnerRadiusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InnerRadiusLabel.Location = new System.Drawing.Point(16, 156);
            this.InnerRadiusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InnerRadiusLabel.Name = "InnerRadiusLabel";
            this.InnerRadiusLabel.Size = new System.Drawing.Size(178, 25);
            this.InnerRadiusLabel.TabIndex = 3;
            this.InnerRadiusLabel.Text = "Inner Radius (mm):";
            // 
            // OuterRadiusLabel
            // 
            this.OuterRadiusLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.OuterRadiusLabel.AutoSize = true;
            this.OuterRadiusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OuterRadiusLabel.Location = new System.Drawing.Point(16, 280);
            this.OuterRadiusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OuterRadiusLabel.Name = "OuterRadiusLabel";
            this.OuterRadiusLabel.Size = new System.Drawing.Size(183, 25);
            this.OuterRadiusLabel.TabIndex = 4;
            this.OuterRadiusLabel.Text = "Outer Radius (mm):";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WidthLabel.Location = new System.Drawing.Point(16, 124);
            this.WidthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(120, 25);
            this.WidthLabel.TabIndex = 5;
            this.WidthLabel.Text = "Width (mm):";
            // 
            // InnerHeightLabel
            // 
            this.InnerHeightLabel.AutoSize = true;
            this.InnerHeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InnerHeightLabel.Location = new System.Drawing.Point(16, 248);
            this.InnerHeightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InnerHeightLabel.Name = "InnerHeightLabel";
            this.InnerHeightLabel.Size = new System.Drawing.Size(253, 25);
            this.InnerHeightLabel.TabIndex = 6;
            this.InnerHeightLabel.Text = "Inner Height Hangers (mm):";
            // 
            // RecessRadiusLabel
            // 
            this.RecessRadiusLabel.AutoSize = true;
            this.RecessRadiusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecessRadiusLabel.Location = new System.Drawing.Point(16, 188);
            this.RecessRadiusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RecessRadiusLabel.Name = "RecessRadiusLabel";
            this.RecessRadiusLabel.Size = new System.Drawing.Size(199, 25);
            this.RecessRadiusLabel.TabIndex = 7;
            this.RecessRadiusLabel.Text = "Recess Radius (mm):";
            // 
            // LengthCenterRecessLabel
            // 
            this.LengthCenterRecessLabel.AutoSize = true;
            this.LengthCenterRecessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LengthCenterRecessLabel.Location = new System.Drawing.Point(16, 312);
            this.LengthCenterRecessLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LengthCenterRecessLabel.Name = "LengthCenterRecessLabel";
            this.LengthCenterRecessLabel.Size = new System.Drawing.Size(336, 25);
            this.LengthCenterRecessLabel.TabIndex = 8;
            this.LengthCenterRecessLabel.Text = "Length from center to recesses (mm):";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.AccessibleDescription = "";
            this.HeightTextBox.Location = new System.Drawing.Point(443, 63);
            this.HeightTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(93, 22);
            this.HeightTextBox.TabIndex = 9;
            this.HeightTextBox.Text = "230";
            this.HeightToolTip.SetToolTip(this.HeightTextBox, "Height of Hangers must be between: 200 - 230");
            this.HeightTextBox.TextChanged += new System.EventHandler(this.HeightTextBox_TextChanged);
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Location = new System.Drawing.Point(443, 95);
            this.LengthTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(93, 22);
            this.LengthTextBox.TabIndex = 10;
            this.LengthTextBox.Text = "390";
            this.LengthToolTip.SetToolTip(this.LengthTextBox, "Length of Hangers must be between: 390 - 470");
            this.LengthTextBox.TextChanged += new System.EventHandler(this.LengthTextBox_TextChanged);
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(443, 127);
            this.WidthTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(93, 22);
            this.WidthTextBox.TabIndex = 11;
            this.WidthTextBox.Text = "5";
            this.WidthToolTip.SetToolTip(this.WidthTextBox, "Width of Hangers must be between: 4 - 6");
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // InnerRadiusTextBox
            // 
            this.InnerRadiusTextBox.Location = new System.Drawing.Point(443, 159);
            this.InnerRadiusTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.InnerRadiusTextBox.Name = "InnerRadiusTextBox";
            this.InnerRadiusTextBox.Size = new System.Drawing.Size(93, 22);
            this.InnerRadiusTextBox.TabIndex = 12;
            this.InnerRadiusTextBox.Text = "15";
            this.InnerRadiusToolTip.SetToolTip(this.InnerRadiusTextBox, "Inner Radius of Hangers must be between: 15 - 20");
            this.InnerRadiusTextBox.TextChanged += new System.EventHandler(this.InnerRadiusTextBox_TextChanged);
            // 
            // OuterRadiusTextBox
            // 
            this.OuterRadiusTextBox.Enabled = false;
            this.OuterRadiusTextBox.Location = new System.Drawing.Point(443, 280);
            this.OuterRadiusTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.OuterRadiusTextBox.Name = "OuterRadiusTextBox";
            this.OuterRadiusTextBox.Size = new System.Drawing.Size(93, 22);
            this.OuterRadiusTextBox.TabIndex = 13;
            this.OuterRadiusTextBox.Text = "30";
            this.OuterRadiusToolTip.SetToolTip(this.OuterRadiusTextBox, "The outer radius is built according to the dependence: Inner Radius + 15");
            // 
            // InnerHeightTextBox
            // 
            this.InnerHeightTextBox.Enabled = false;
            this.InnerHeightTextBox.Location = new System.Drawing.Point(443, 251);
            this.InnerHeightTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.InnerHeightTextBox.Name = "InnerHeightTextBox";
            this.InnerHeightTextBox.Size = new System.Drawing.Size(93, 22);
            this.InnerHeightTextBox.TabIndex = 14;
            this.InnerHeightTextBox.Text = "110";
            this.InnerHeightToolTip.SetToolTip(this.InnerHeightTextBox, "The inner height is built according to the dependence: (Height-1)/2");
            // 
            // RecessRadiusTextBox
            // 
            this.RecessRadiusTextBox.Location = new System.Drawing.Point(443, 191);
            this.RecessRadiusTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.RecessRadiusTextBox.Name = "RecessRadiusTextBox";
            this.RecessRadiusTextBox.Size = new System.Drawing.Size(93, 22);
            this.RecessRadiusTextBox.TabIndex = 15;
            this.RecessRadiusTextBox.Text = "3";
            this.RecessRadiusToolTip.SetToolTip(this.RecessRadiusTextBox, "Recess radius  must  be between: 3 - 4");
            this.RecessRadiusTextBox.TextChanged += new System.EventHandler(this.RecessRadiusTextBox_TextChanged);
            // 
            // LengthCenterRecessTextBox
            // 
            this.LengthCenterRecessTextBox.Enabled = false;
            this.LengthCenterRecessTextBox.Location = new System.Drawing.Point(443, 315);
            this.LengthCenterRecessTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.LengthCenterRecessTextBox.Name = "LengthCenterRecessTextBox";
            this.LengthCenterRecessTextBox.Size = new System.Drawing.Size(93, 22);
            this.LengthCenterRecessTextBox.TabIndex = 16;
            this.LengthCenterRecessTextBox.Text = "130";
            this.LengthCenterRecessToolTip.SetToolTip(this.LengthCenterRecessTextBox, "Length from center to recess is built according to the dependence: Length * 3/4");
            // 
            // BuildButton
            // 
            this.BuildButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuildButton.Location = new System.Drawing.Point(436, 370);
            this.BuildButton.Margin = new System.Windows.Forms.Padding(4);
            this.BuildButton.Name = "BuildButton";
            this.BuildButton.Size = new System.Drawing.Size(100, 32);
            this.BuildButton.TabIndex = 17;
            this.BuildButton.Text = "Build";
            this.BuildButton.UseVisualStyleBackColor = true;
            this.BuildButton.Click += new System.EventHandler(this.BuildButton_Click);
            // 
            // BuildBracingPantsLabel
            // 
            this.BuildBracingPantsLabel.AutoSize = true;
            this.BuildBracingPantsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuildBracingPantsLabel.Location = new System.Drawing.Point(16, 216);
            this.BuildBracingPantsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BuildBracingPantsLabel.Name = "BuildBracingPantsLabel";
            this.BuildBracingPantsLabel.Size = new System.Drawing.Size(200, 25);
            this.BuildBracingPantsLabel.TabIndex = 18;
            this.BuildBracingPantsLabel.Text = "Build Bracing of pants";
            // 
            // BracingPantsComboBox
            // 
            this.BracingPantsComboBox.FormattingEnabled = true;
            this.BracingPantsComboBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.BracingPantsComboBox.Location = new System.Drawing.Point(443, 220);
            this.BracingPantsComboBox.Name = "BracingPantsComboBox";
            this.BracingPantsComboBox.Size = new System.Drawing.Size(93, 24);
            this.BracingPantsComboBox.TabIndex = 19;
            this.BracingPantsComboBox.Text = "No";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 415);
            this.Controls.Add(this.BracingPantsComboBox);
            this.Controls.Add(this.BuildBracingPantsLabel);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(569, 462);
            this.MinimumSize = new System.Drawing.Size(569, 462);
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
        private System.Windows.Forms.Label BuildBracingPantsLabel;
        private System.Windows.Forms.ComboBox BracingPantsComboBox;
    }
}

