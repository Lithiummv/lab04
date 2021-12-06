using System;
using System.Collections.Generic;

namespace lab04
{
    class Controller
    {
        public List<Model> outputModels;//Список выбранных заявок
        double[][,] generalMatrix; //Массив полученных матриц

        public Controller()
        {
            outputModels = new List<Model>();
        }

        public double Solve(List<Model> models, int workersNumber)
        {
            outputModels.Clear();
            double[,] matrix = solveMatrix(models, workersNumber, models[0]);
            Output(models, workersNumber);
            return matrix[workersNumber, 3];
        }

        private double[,] solveMatrix(List<Model> models, int workersNumber, Model model)
        {
            generalMatrix = new double[models.Count][,];
            double[,] matrix = new double[workersNumber + 1, 5];

            if (models.IndexOf(model) == 0)
            {
                //Таблица для первого этапа этапа
                int i = workersNumber;
                matrix[i, 0] = i;
                double[,] nextMatrix = solveMatrix(models, workersNumber, models[models.IndexOf(model) + 1]);
                matrix[i, 1] = nextMatrix[i, 3];
                if (matrix[i, 0] - model.RequiredWorkersNumber < 0)
                    matrix[i, 2] = -1;
                else if (nextMatrix[i - model.RequiredWorkersNumber, 2] == -1)
                    matrix[i, 2] = model.Estimation;
                else
                    matrix[i, 2] = model.Estimation + nextMatrix[i - model.RequiredWorkersNumber, 3];
                matrix[i, 3] = Math.Max(matrix[i, 1], matrix[i, 2]);
                if (matrix[i, 1] == matrix[i, 3])
                    matrix[i, 4] = 0;
                else
                    matrix[i, 4] = 1;
                generalMatrix[models.IndexOf(model)] = matrix;
                return matrix;
            }
            else if (models.IndexOf(model) == models.Count - 1)
            {
                //Таблица для последнего этапа
                for (int i = 0; i <= workersNumber; i++)
                {
                    matrix[i, 0] = i;
                    matrix[i, 1] = 0;
                    if (matrix[i, 0] - model.RequiredWorkersNumber < 0)
                        matrix[i, 2] = -1;
                    else
                        matrix[i, 2] = model.Estimation;
                    matrix[i, 3] = Math.Max(matrix[i, 1], matrix[i, 2]);
                    if (matrix[i, 1] == matrix[i, 3])
                        matrix[i, 4] = 0;
                    else
                        matrix[i, 4] = 1;
                }
                generalMatrix[models.IndexOf(model)] = matrix;
                return matrix;
            }
            else
            {
                //Таблица для промежуточного этапа
                double[,] nextMatrix = solveMatrix(models, workersNumber, models[models.IndexOf(model) + 1]);
                for (int i = 0; i <= workersNumber; i++)
                {
                    matrix[i, 0] = i;
                    matrix[i, 1] = nextMatrix[i, 3];
                    if (matrix[i, 0] - model.RequiredWorkersNumber < 0)
                        matrix[i, 2] = -1;
                    else if (nextMatrix[i - model.RequiredWorkersNumber, 2] == -1)
                        matrix[i, 2] = model.Estimation;
                    else
                        matrix[i, 2] = model.Estimation + nextMatrix[i - model.RequiredWorkersNumber, 3];
                    matrix[i, 3] = Math.Max(matrix[i, 1], matrix[i, 2]);
                    if (matrix[i, 1] == matrix[i, 3])
                        matrix[i, 4] = 0;
                    else
                        matrix[i, 4] = 1;
                }

                generalMatrix[models.IndexOf(model)] = matrix;
                return matrix;
            }
        }

        private void Output(List<Model> models, int workersNumber)
        {
            foreach (Model model in models)
            {
                if (models.IndexOf(model) == 0)
                {
                    if (generalMatrix[models.IndexOf(model)][workersNumber, 4] == 1)
                    {
                        outputModels.Add(model);
                        workersNumber -= model.RequiredWorkersNumber;
                    }
                }

                if (generalMatrix[models.IndexOf(model)][workersNumber, 4] == 1)
                {
                    outputModels.Add(model);
                    workersNumber -= model.RequiredWorkersNumber;
                }
            }
        }
    }
}
