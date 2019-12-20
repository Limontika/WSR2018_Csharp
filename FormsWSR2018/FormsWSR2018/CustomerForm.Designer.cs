namespace FormsWSR2018
{
    partial class CustomerForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOrdersList = new System.Windows.Forms.Button();
            this.buttonCreateOrder = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOrdersList
            // 
            this.buttonOrdersList.Location = new System.Drawing.Point(200, 20);
            this.buttonOrdersList.Name = "buttonOrdersList";
            this.buttonOrdersList.Size = new System.Drawing.Size(400, 80);
            this.buttonOrdersList.TabIndex = 0;
            this.buttonOrdersList.Text = "Список заказов";
            this.buttonOrdersList.UseVisualStyleBackColor = true;
            // 
            // buttonCreateOrder
            // 
            this.buttonCreateOrder.Location = new System.Drawing.Point(200, 120);
            this.buttonCreateOrder.Name = "buttonCreateOrder";
            this.buttonCreateOrder.Size = new System.Drawing.Size(400, 80);
            this.buttonCreateOrder.TabIndex = 1;
            this.buttonCreateOrder.Text = "Оформить заказ";
            this.buttonCreateOrder.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(200, 220);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(400, 80);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonCreateOrder);
            this.Controls.Add(this.buttonOrdersList);
            this.Name = "CustomerForm";
            this.Text = "Экран заказчика";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOrdersList;
        private System.Windows.Forms.Button buttonCreateOrder;
        private System.Windows.Forms.Button buttonExit;
    }
}

