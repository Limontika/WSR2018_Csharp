namespace FormsWSR2018
{
    partial class ManagerForm
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
            this.buttonCreateOrder = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAccountingIngredients
            // 
            this.buttonAccountingIngredients.Location = new System.Drawing.Point(4, 12);
            this.buttonAccountingIngredients.Name = "buttonAccountingIngredients";
            this.buttonAccountingIngredients.Size = new System.Drawing.Size(400, 60);
            this.buttonAccountingIngredients.TabIndex = 0;
            this.buttonAccountingIngredients.Text = "Учет ингридиентов и украшений (only read)";
            this.buttonAccountingIngredients.UseVisualStyleBackColor = true;
            this.buttonAccountingIngredients.Click += new System.EventHandler(this.buttonAccountingIngredients_Click);
            // 
            // buttonOrdersList
            // 
            this.buttonOrdersList.Location = new System.Drawing.Point(4, 92);
            this.buttonOrdersList.Name = "buttonOrdersList";
            this.buttonOrdersList.Size = new System.Drawing.Size(400, 60);
            this.buttonOrdersList.TabIndex = 1;
            this.buttonOrdersList.Text = "Список заказов";
            this.buttonOrdersList.UseVisualStyleBackColor = true;
            this.buttonOrdersList.Click += new System.EventHandler(this.buttonOrdersList_Click);
            // 
            // buttonCreateOrder
            // 
            this.buttonCreateOrder.Location = new System.Drawing.Point(4, 172);
            this.buttonCreateOrder.Name = "buttonCreateOrder";
            this.buttonCreateOrder.Size = new System.Drawing.Size(400, 60);
            this.buttonCreateOrder.TabIndex = 2;
            this.buttonCreateOrder.Text = "Оформить заказ";
            this.buttonCreateOrder.UseVisualStyleBackColor = true;
            this.buttonCreateOrder.Click += new System.EventHandler(this.buttonCreateOrder_Click);
            // 
            // buttonReport
            // 
            this.buttonReport.Location = new System.Drawing.Point(4, 252);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(400, 60);
            this.buttonReport.TabIndex = 3;
            this.buttonReport.Text = "Отчёты";
            this.buttonReport.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(444, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 60);
            this.button4.TabIndex = 4;
            this.button4.Text = "Выход";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 317);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.buttonCreateOrder);
            this.Controls.Add(this.buttonOrdersList);
            this.Controls.Add(this.buttonAccountingIngredients);
            this.Name = "ManagerForm";
            this.Text = "Менеджер по работе с клиентами";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAccountingIngredients;
        private System.Windows.Forms.Button buttonOrdersList;
        private System.Windows.Forms.Button buttonCreateOrder;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.Button button4;
    }
}