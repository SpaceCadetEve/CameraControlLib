namespace CameraController
{
    partial class CameraControlSlider
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.valueTrackbar = new System.Windows.Forms.TrackBar();
            this.presetEnabledCheckbox = new System.Windows.Forms.CheckBox();
            this.modeSelector = new System.Windows.Forms.ComboBox();
            this.propertyName = new System.Windows.Forms.Label();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.valueTrackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // valueTrackbar
            // 
            this.valueTrackbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valueTrackbar.Location = new System.Drawing.Point(354, 0);
            this.valueTrackbar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.valueTrackbar.Minimum = 1;
            this.valueTrackbar.Name = "valueTrackbar";
            this.valueTrackbar.Size = new System.Drawing.Size(610, 114);
            this.valueTrackbar.TabIndex = 0;
            this.valueTrackbar.Value = 1;
            this.valueTrackbar.Scroll += new System.EventHandler(this.valueTrackbar_Scroll);
            // 
            // presetEnabledCheckbox
            // 
            this.presetEnabledCheckbox.AutoSize = true;
            this.presetEnabledCheckbox.Location = new System.Drawing.Point(304, 14);
            this.presetEnabledCheckbox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.presetEnabledCheckbox.Name = "presetEnabledCheckbox";
            this.presetEnabledCheckbox.Size = new System.Drawing.Size(34, 33);
            this.presetEnabledCheckbox.TabIndex = 1;
            this.presetEnabledCheckbox.UseVisualStyleBackColor = true;
            // 
            // modeSelector
            // 
            this.modeSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.modeSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modeSelector.FormattingEnabled = true;
            this.modeSelector.Location = new System.Drawing.Point(1122, 7);
            this.modeSelector.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.modeSelector.Name = "modeSelector";
            this.modeSelector.Size = new System.Drawing.Size(188, 39);
            this.modeSelector.TabIndex = 2;
            this.modeSelector.SelectionChangeCommitted += new System.EventHandler(this.modeSelector_SelectionChangeCommitted);
            // 
            // propertyName
            // 
            this.propertyName.Location = new System.Drawing.Point(-8, 14);
            this.propertyName.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.propertyName.Name = "propertyName";
            this.propertyName.Size = new System.Drawing.Size(296, 76);
            this.propertyName.TabIndex = 3;
            this.propertyName.Text = "<Camera Property Name>";
            this.propertyName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // valueTextBox
            // 
            this.valueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.valueTextBox.Location = new System.Drawing.Point(1011, 7);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(100, 38);
            this.valueTextBox.TabIndex = 4;
            this.valueTextBox.TextChanged += new System.EventHandler(this.valueTextBox_TextChanged);
            this.valueTextBox.Leave += new System.EventHandler(this.valueTextBox_LostFocus);
            // 
            // CameraControlSlider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(this.propertyName);
            this.Controls.Add(this.modeSelector);
            this.Controls.Add(this.presetEnabledCheckbox);
            this.Controls.Add(this.valueTrackbar);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "CameraControlSlider";
            this.Size = new System.Drawing.Size(1325, 91);
            ((System.ComponentModel.ISupportInitialize)(this.valueTrackbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar valueTrackbar;
        private System.Windows.Forms.CheckBox presetEnabledCheckbox;
        private System.Windows.Forms.ComboBox modeSelector;
        private System.Windows.Forms.Label propertyName;
        private System.Windows.Forms.TextBox valueTextBox;
    }
}
