namespace Temp_Show2
{
    partial class Connect_Test
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
            this.保存 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 保存
            // 
            this.保存.Location = new System.Drawing.Point(149, 240);
            this.保存.Name = "保存";
            this.保存.Size = new System.Drawing.Size(94, 29);
            this.保存.TabIndex = 0;
            this.保存.Text = "button1";
            this.保存.UseVisualStyleBackColor = true;
            // 
            // Connect_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 367);
            this.Controls.Add(this.保存);
            this.Name = "Connect_Test";
            this.Text = "Connect_Test";
            this.ResumeLayout(false);

        }

        #endregion

        private Button 保存;
    }
}