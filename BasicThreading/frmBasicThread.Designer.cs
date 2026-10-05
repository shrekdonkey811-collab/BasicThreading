namespace BasicThreading
{
    partial class frmBasicThread
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

        // Removed GetRunbtn1 helper; InitializeComponent will wire events using the runbtn field.

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titlecard = new Label();
            runbtn = new Button();
            SuspendLayout();
            // 
            // titlecard
            // 
            titlecard.AutoSize = true;
            titlecard.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titlecard.Location = new Point(45, 46);
            titlecard.Margin = new Padding(4, 0, 4, 0);
            titlecard.Name = "titlecard";
            titlecard.Size = new Size(369, 45);
            titlecard.TabIndex = 0;
            titlecard.Text = "-Before starting thread-";
            // 
            // runbtn
            // 
            runbtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            runbtn.Location = new Point(144, 121);
            runbtn.Margin = new Padding(4);
            runbtn.Name = "runbtn";
            runbtn.Size = new Size(150, 46);
            runbtn.TabIndex = 1;
            runbtn.Text = "Run";
            runbtn.UseVisualStyleBackColor = true;
            runbtn.Click += runbtn_Click;
            // 
            // frmBasicThread
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 204);
            Controls.Add(runbtn);
            Controls.Add(titlecard);
            Margin = new Padding(4);
            Name = "frmBasicThread";
            Text = "Basic Thread";
            Load += frmBasicThread_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titlecard;
        private Button runbtn;
    }
}
