namespace FormsWSR2018
{
    partial class ListsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.decoration = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonPlus1 = new System.Windows.Forms.Button();
            this.buttonMinus1 = new System.Windows.Forms.Button();
            this.buttonPlus2 = new System.Windows.Forms.Button();
            this.buttonMinus2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ингридиенты";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(750, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // decoration
            // 
            this.decoration.AutoSize = true;
            this.decoration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.decoration.Location = new System.Drawing.Point(24, 230);
            this.decoration.Name = "decoration";
            this.decoration.Size = new System.Drawing.Size(94, 20);
            this.decoration.TabIndex = 2;
            this.decoration.Text = "Украшения";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(20, 260);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(750, 150);
            this.dataGridView2.TabIndex = 3;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(680, 420);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(90, 30);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // buttonPlus1
            // 
            this.buttonPlus1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonPlus1.Location = new System.Drawing.Point(620, 15);
            this.buttonPlus1.Name = "buttonPlus1";
            this.buttonPlus1.Size = new System.Drawing.Size(50, 25);
            this.buttonPlus1.TabIndex = 5;
            this.buttonPlus1.Text = "+";
            this.buttonPlus1.UseVisualStyleBackColor = true;
            // 
            // buttonMinus1
            // 
            this.buttonMinus1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonMinus1.Location = new System.Drawing.Point(680, 15);
            this.buttonMinus1.Name = "buttonMinus1";
            this.buttonMinus1.Size = new System.Drawing.Size(50, 25);
            this.buttonMinus1.TabIndex = 6;
            this.buttonMinus1.Text = "-";
            this.buttonMinus1.UseVisualStyleBackColor = true;
            // 
            // buttonPlus2
            // 
            this.buttonPlus2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonPlus2.Location = new System.Drawing.Point(620, 225);
            this.buttonPlus2.Name = "buttonPlus2";
            this.buttonPlus2.Size = new System.Drawing.Size(50, 25);
            this.buttonPlus2.TabIndex = 7;
            this.buttonPlus2.Text = "+";
            this.buttonPlus2.UseVisualStyleBackColor = true;
            // 
            // buttonMinus2
            // 
            this.buttonMinus2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonMinus2.Location = new System.Drawing.Point(680, 225);
            this.buttonMinus2.Name = "buttonMinus2";
            this.buttonMinus2.Size = new System.Drawing.Size(50, 25);
            this.buttonMinus2.TabIndex = 8;
            this.buttonMinus2.Text = "-";
            this.buttonMinus2.UseVisualStyleBackColor = true;
            // 
            // ListsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.buttonMinus2);
            this.Controls.Add(this.buttonPlus2);
            this.Controls.Add(this.buttonMinus1);
            this.Controls.Add(this.buttonPlus1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.decoration);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "ListsForm";
            this.Text = "Форма списков";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label decoration;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonPlus1;
        private System.Windows.Forms.Button buttonMinus1;
        private System.Windows.Forms.Button buttonPlus2;
        private System.Windows.Forms.Button buttonMinus2;
    }
}