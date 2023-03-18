
namespace EmprestimoLivros.VIEW
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
            this.GrdLivros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GrdLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdLivros
            // 
            this.GrdLivros.AllowUserToAddRows = false;
            this.GrdLivros.AllowUserToDeleteRows = false;
            this.GrdLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdLivros.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GrdLivros.Location = new System.Drawing.Point(0, 141);
            this.GrdLivros.Name = "GrdLivros";
            this.GrdLivros.ReadOnly = true;
            this.GrdLivros.RowTemplate.Height = 25;
            this.GrdLivros.Size = new System.Drawing.Size(800, 309);
            this.GrdLivros.TabIndex = 0;
            this.GrdLivros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdLivros_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GrdLivros);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdLivros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GrdLivros;
    }
}

