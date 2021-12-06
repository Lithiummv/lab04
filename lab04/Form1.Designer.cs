
namespace lab04
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ApplicationNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estimation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequiredWorkersNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxWorkersNumber = new System.Windows.Forms.TextBox();
            this.btnSolve = new System.Windows.Forms.Button();
            this.labelGeneralEstimation = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ApplicationNumberOutput = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstimationOutput = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequiredWorkersNumberOutput = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ApplicationNumber,
            this.Estimation,
            this.RequiredWorkersNumber});
            this.dataGridView1.Location = new System.Drawing.Point(15, 17);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(429, 258);
            this.dataGridView1.TabIndex = 0;
            // 
            // ApplicationNumber
            // 
            this.ApplicationNumber.HeaderText = "№ заявки";
            this.ApplicationNumber.MinimumWidth = 6;
            this.ApplicationNumber.Name = "ApplicationNumber";
            this.ApplicationNumber.Width = 125;
            // 
            // Estimation
            // 
            this.Estimation.HeaderText = "Оценка";
            this.Estimation.MinimumWidth = 6;
            this.Estimation.Name = "Estimation";
            this.Estimation.Width = 125;
            // 
            // RequiredWorkersNumber
            // 
            this.RequiredWorkersNumber.HeaderText = "Необходимое количество добровольцев";
            this.RequiredWorkersNumber.MinimumWidth = 6;
            this.RequiredWorkersNumber.Name = "RequiredWorkersNumber";
            this.RequiredWorkersNumber.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(450, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Общее количество добровольцев:";
            // 
            // textBoxWorkersNumber
            // 
            this.textBoxWorkersNumber.Location = new System.Drawing.Point(450, 41);
            this.textBoxWorkersNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxWorkersNumber.Name = "textBoxWorkersNumber";
            this.textBoxWorkersNumber.Size = new System.Drawing.Size(114, 27);
            this.textBoxWorkersNumber.TabIndex = 2;
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(15, 283);
            this.btnSolve.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(86, 31);
            this.btnSolve.TabIndex = 3;
            this.btnSolve.Text = "Решить";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // labelGeneralEstimation
            // 
            this.labelGeneralEstimation.AutoSize = true;
            this.labelGeneralEstimation.Location = new System.Drawing.Point(450, 321);
            this.labelGeneralEstimation.Name = "labelGeneralEstimation";
            this.labelGeneralEstimation.Size = new System.Drawing.Size(118, 20);
            this.labelGeneralEstimation.TabIndex = 5;
            this.labelGeneralEstimation.Text = "Общая оценка: ";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ApplicationNumberOutput,
            this.EstimationOutput,
            this.RequiredWorkersNumberOutput});
            this.dataGridView2.Location = new System.Drawing.Point(12, 321);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(429, 267);
            this.dataGridView2.TabIndex = 6;
            // 
            // ApplicationNumberOutput
            // 
            this.ApplicationNumberOutput.HeaderText = "№ заявки";
            this.ApplicationNumberOutput.MinimumWidth = 6;
            this.ApplicationNumberOutput.Name = "ApplicationNumberOutput";
            this.ApplicationNumberOutput.ReadOnly = true;
            this.ApplicationNumberOutput.Width = 125;
            // 
            // EstimationOutput
            // 
            this.EstimationOutput.HeaderText = "Оценка";
            this.EstimationOutput.MinimumWidth = 6;
            this.EstimationOutput.Name = "EstimationOutput";
            this.EstimationOutput.ReadOnly = true;
            this.EstimationOutput.Width = 125;
            // 
            // RequiredWorkersNumberOutput
            // 
            this.RequiredWorkersNumberOutput.HeaderText = "Необходимое количество добровольцев";
            this.RequiredWorkersNumberOutput.MinimumWidth = 6;
            this.RequiredWorkersNumberOutput.Name = "RequiredWorkersNumberOutput";
            this.RequiredWorkersNumberOutput.ReadOnly = true;
            this.RequiredWorkersNumberOutput.Width = 125;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(651, 559);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 29);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 600);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.labelGeneralEstimation);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.textBoxWorkersNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Задача о загрузке";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApplicationNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estimation;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequiredWorkersNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxWorkersNumber;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Label labelGeneralEstimation;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApplicationNumberOutput;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstimationOutput;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequiredWorkersNumberOutput;
        private System.Windows.Forms.Button btnClear;
    }
}

