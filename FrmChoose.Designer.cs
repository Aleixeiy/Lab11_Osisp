namespace Intellector
{
    partial class FrmChoose
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
            this.ListMoves = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ListMoves
            // 
            this.ListMoves.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListMoves.FormattingEnabled = true;
            this.ListMoves.ItemHeight = 33;
            this.ListMoves.Location = new System.Drawing.Point(12, 12);
            this.ListMoves.Name = "ListMoves";
            this.ListMoves.Size = new System.Drawing.Size(134, 169);
            this.ListMoves.TabIndex = 0;
            // 
            // FrmChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(157, 190);
            this.Controls.Add(this.ListMoves);
            this.Name = "FrmChoose";
            this.Text = "FrmChoose";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox ListMoves;
    }
}