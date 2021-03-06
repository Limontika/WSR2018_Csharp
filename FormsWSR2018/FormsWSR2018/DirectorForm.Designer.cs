﻿namespace FormsWSR2018
{
    partial class DirectorForm
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
            this.buttonAccountingTools = new System.Windows.Forms.Button();
            this.buttonAccountingIngredients = new System.Windows.Forms.Button();
            this.buttonPlansShopFloor = new System.Windows.Forms.Button();
            this.buttonOrdersList = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAccountingTools
            // 
            this.buttonAccountingTools.Location = new System.Drawing.Point(12, 21);
            this.buttonAccountingTools.Name = "buttonAccountingTools";
            this.buttonAccountingTools.Size = new System.Drawing.Size(400, 50);
            this.buttonAccountingTools.TabIndex = 0;
            this.buttonAccountingTools.Text = "Учёт инструментов";
            this.buttonAccountingTools.UseVisualStyleBackColor = true;
            this.buttonAccountingTools.Click += new System.EventHandler(this.buttonAccountingTools_Click);
            // 
            // buttonAccountingIngredients
            // 
            this.buttonAccountingIngredients.Location = new System.Drawing.Point(12, 91);
            this.buttonAccountingIngredients.Name = "buttonAccountingIngredients";
            this.buttonAccountingIngredients.Size = new System.Drawing.Size(400, 50);
            this.buttonAccountingIngredients.TabIndex = 1;
            this.buttonAccountingIngredients.Text = "Учет ингридиентов и украшений";
            this.buttonAccountingIngredients.UseVisualStyleBackColor = true;
            this.buttonAccountingIngredients.Click += new System.EventHandler(this.buttonAccountingIngredients_Click);
            // 
            // buttonPlansShopFloor
            // 
            this.buttonPlansShopFloor.Location = new System.Drawing.Point(12, 161);
            this.buttonPlansShopFloor.Name = "buttonPlansShopFloor";
            this.buttonPlansShopFloor.Size = new System.Drawing.Size(400, 50);
            this.buttonPlansShopFloor.TabIndex = 2;
            this.buttonPlansShopFloor.Text = "Планы цехов";
            this.buttonPlansShopFloor.UseVisualStyleBackColor = true;
            this.buttonPlansShopFloor.Click += new System.EventHandler(this.buttonPlansShopFloor_Click);
            // 
            // buttonOrdersList
            // 
            this.buttonOrdersList.Location = new System.Drawing.Point(12, 231);
            this.buttonOrdersList.Name = "buttonOrdersList";
            this.buttonOrdersList.Size = new System.Drawing.Size(400, 50);
            this.buttonOrdersList.TabIndex = 3;
            this.buttonOrdersList.Text = "Список заказов";
            this.buttonOrdersList.UseVisualStyleBackColor = true;
            this.buttonOrdersList.Click += new System.EventHandler(this.buttonOrdersList_Click);
            // 
            // buttonReport
            // 
            this.buttonReport.Location = new System.Drawing.Point(12, 301);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(400, 50);
            this.buttonReport.TabIndex = 4;
            this.buttonReport.Text = "Отчёты";
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(452, 21);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(100, 50);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // DirectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 361);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.buttonOrdersList);
            this.Controls.Add(this.buttonPlansShopFloor);
            this.Controls.Add(this.buttonAccountingIngredients);
            this.Controls.Add(this.buttonAccountingTools);
            this.Name = "DirectorForm";
            this.Text = "Экран директора";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAccountingTools;
        private System.Windows.Forms.Button buttonAccountingIngredients;
        private System.Windows.Forms.Button buttonPlansShopFloor;
        private System.Windows.Forms.Button buttonOrdersList;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.Button buttonExit;
    }
}