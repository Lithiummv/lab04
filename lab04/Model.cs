namespace lab04
{
    class Model
    {
        public string ApplicationNumber { get; set; }
        public double Estimation { get; set; }
        public int RequiredWorkersNumber { get; set; }

        public Model(string applicationNumber, double estimation, int requiredWorkersNumber)
        {
            ApplicationNumber = applicationNumber;
            Estimation = estimation;
            RequiredWorkersNumber = requiredWorkersNumber;
        }
    }
}