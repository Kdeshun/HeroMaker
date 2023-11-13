namespace HeroMaker1
{
    partial class ListofHeros
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
            this.lbListofHeros = new System.Windows.Forms.ListBox();
            this.tbListofHeros = new System.Windows.Forms.TextBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbListofHeros
            // 
            this.lbListofHeros.FormattingEnabled = true;
            this.lbListofHeros.Location = new System.Drawing.Point(26, 42);
            this.lbListofHeros.Name = "lbListofHeros";
            this.lbListofHeros.Size = new System.Drawing.Size(271, 368);
            this.lbListofHeros.TabIndex = 0;
            this.lbListofHeros.SelectedIndexChanged += new System.EventHandler(this.lbListofHeros_SelectedIndexChanged);
            // 
            // tbListofHeros
            // 
            this.tbListofHeros.Location = new System.Drawing.Point(303, 120);
            this.tbListofHeros.Multiline = true;
            this.tbListofHeros.Name = "tbListofHeros";
            this.tbListofHeros.Size = new System.Drawing.Size(384, 290);
            this.tbListofHeros.TabIndex = 1;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(313, 42);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 2;
            this.btnSort.Text = "A<--->Z";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(503, 41);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ListofHeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.tbListofHeros);
            this.Controls.Add(this.lbListofHeros);
            this.Name = "ListofHeros";
            this.Text = "ListofHeros";
            this.Load += new System.EventHandler(this.ListofHeros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbListofHeros;
        private System.Windows.Forms.TextBox tbListofHeros;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnDelete;
    }
}