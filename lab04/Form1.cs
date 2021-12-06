using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace lab04
{
    public partial class Form1 : Form
    {
        List<Model> models;
        int workersNumber;
        Controller controller;

        public Form1()
        {
            InitializeComponent();
            models = new List<Model>();
            controller = new Controller();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            if (dataGridView1.Rows.Count - 1 != 1 && textBoxWorkersNumber.Text != "")
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    models.Add(new Model(dataGridView1.Rows[i].Cells[0].Value.ToString(),
                        Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value),
                        Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value)));
                }

                workersNumber = Convert.ToInt32(textBoxWorkersNumber.Text);
                labelGeneralEstimation.Text = labelGeneralEstimation.Text + controller.Solve(models, workersNumber);

                for (int i = 0; i < controller.outputModels.Count; i++)
                {
                    dataGridView2.Rows.Add();
                    dataGridView2.Rows[i].Cells[0].Value = controller.outputModels[i].ApplicationNumber;
                    dataGridView2.Rows[i].Cells[1].Value = controller.outputModels[i].Estimation;
                    dataGridView2.Rows[i].Cells[2].Value = controller.outputModels[i].RequiredWorkersNumber;
                }
            }
            else if (dataGridView1.Rows.Count - 1 == 1)
                MessageBox.Show("Количество заявок должно быть больше одного!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Введите общее число добровольцев!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            labelGeneralEstimation.Text = "Общая оценка: ";
            textBoxWorkersNumber.Clear();
        }
    }
}
