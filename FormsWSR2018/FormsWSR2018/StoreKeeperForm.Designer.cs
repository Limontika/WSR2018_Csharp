namespace FormsWSR2018
{
    partial class StoreKeeperForm
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
            this.buttonProductSpecification = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAccountingIngredients
            // 
            this.buttonAccountingIngredients.Location = new System.Drawing.Point(12, 12);
            this.buttonAccountingIngredients.Name = "buttonAccountingIngredients";
            this.buttonAccountingIngredients.Size = new System.Drawing.Size(400, 90);
            this.buttonAccountingIngredients.TabIndex = 0;
            this.buttonAccountingIngredients.Text = "Учет ингридиентов и украшений (only read)";
            this.buttonAccountingIngredients.UseVisualStyleBackColor = true;
            this.buttonAccountingIngredients.Click += new System.EventHandler(this.buttonAccountingIngredients_Click);
            // 
            // buttonOrdersList
            // 
            this.buttonOrdersList.Location = new System.Drawing.Point(12, 122);
            this.buttonOrdersList.Name = "buttonOrdersList";
            this.buttonOrdersList.Size = new System.Drawing.Size(400, 90);
            this.buttonOrdersList.TabIndex = 1;
            this.buttonOrdersList.Text = "Список заказов";
            this.buttonOrdersList.UseVisualStyleBackColor = true;
            this.buttonOrdersList.Click += new System.EventHandler(this.buttonOrdersList_Click);
            // 
            // buttonProductSpecification
            // 
            this.buttonProductSpecification.Location = new System.Drawing.Point(12, 232);
            this.buttonProductSpecification.Name = "buttonProductSpecification";
            this.buttonProductSpecification.Size = new System.Drawing.Size(400, 90);
            this.buttonProductSpecification.TabIndex = 2;
            this.buttonProductSpecification.Text = "Спецификация изделий";
            this.buttonProductSpecification.UseVisualStyleBackColor = true;
            this.buttonProductSpecification.Click += new System.EventHandler(this.buttonProductSpecification_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(418, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(100, 90);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // StoreKeeperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 327);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonProductSpecification);
            this.Controls.Add(this.buttonOrdersList);
            this.Controls.Add(this.buttonAccountingIngredients);
            this.Name = "StoreKeeperForm";
            this.Text = "Экран мастера";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAccountingIngredients;
        private System.Windows.Forms.Button buttonOrdersList;
        private System.Windows.Forms.Button buttonProductSpecification;
        private System.Windows.Forms.Button buttonExit;
    }
}