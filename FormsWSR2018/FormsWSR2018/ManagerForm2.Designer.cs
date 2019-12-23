namespace FormsWSR2018
{
    partial class ManagerForm2
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
            this.buttonAccountingIngredients = new System.Windows.Forms.Button();
            this.buttonOrdersList = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAccountingIngredients
            // 
            this.buttonAccountingIngredients.Location = new System.Drawing.Point(200, 20);
            this.buttonAccountingIngredients.Name = "buttonAccountingIngredients";
            this.buttonAccountingIngredients.Size = new System.Drawing.Size(400, 90);
            this.buttonAccountingIngredients.TabIndex = 0;
            this.buttonAccountingIngredients.Text = "Учет ингридиентов и украшений";
            this.buttonAccountingIngredients.UseVisualStyleBackColor = true;
            this.buttonAccountingIngredients.Click += new System.EventHandler(this.buttonAccountingIngredients_Click);
            // 
            // buttonOrdersList
            // 
            this.buttonOrdersList.Location = new System.Drawing.Point(200, 130);
            this.buttonOrdersList.Name = "buttonOrdersList";
            this.buttonOrdersList.Size = new System.Drawing.Size(400, 90);
            this.buttonOrdersList.TabIndex = 1;
            this.buttonOrdersList.Text = "Список заказов";
            this.buttonOrdersList.UseVisualStyleBackColor = true;
            this.buttonOrdersList.Click += new System.EventHandler(this.buttonOrdersList_Click);
            // 
            // buttonReport
            // 
            this.buttonReport.Location = new System.Drawing.Point(200, 240);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(400, 90);
            this.buttonReport.TabIndex = 2;
            this.buttonReport.Text = "Отчёты";
            this.buttonReport.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(640, 20);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(100, 90);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // ManagerForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.buttonOrdersList);
            this.Controls.Add(this.buttonAccountingIngredients);
            this.Name = "ManagerForm2";
            this.Text = "Менеджер по закупкам";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAccountingIngredients;
        private System.Windows.Forms.Button buttonOrdersList;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.Button buttonExit;
    }
}