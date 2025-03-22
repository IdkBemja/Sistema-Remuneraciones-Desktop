namespace Sistema_Remuneraciones.app.utils
{
    partial class CustomMessageBox
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
            lblmessage = new Label();
            SuspendLayout();
            // 
            // lblmessage
            // 
            lblmessage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblmessage.AutoSize = true;
            lblmessage.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblmessage.Location = new Point(12, 37);
            lblmessage.Name = "lblmessage";
            lblmessage.RightToLeft = RightToLeft.No;
            lblmessage.Size = new Size(53, 15);
            lblmessage.TabIndex = 0;
            lblmessage.Text = "message";
            lblmessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CustomMessageBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 90);
            ControlBox = false;
            Controls.Add(lblmessage);
            MaximumSize = new Size(328, 129);
            MinimumSize = new Size(328, 129);
            Name = "CustomMessageBox";
            Text = "Title";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblmessage;
    }
}