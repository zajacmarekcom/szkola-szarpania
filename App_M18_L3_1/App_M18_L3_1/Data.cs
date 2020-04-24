namespace App_M18_L3_1
{
    enum Status
    {
        New,
        Processing,
        Closed
    }

    class Data
    {
        public Data(int id, string name, decimal amount)
        {
            Status = Status.New;
            Id = id;
            Name = name;
            Amount = amount;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public Status Status { get; set; }

        public void StartProcessing()
        {
            Status = Status.Processing;
        }

        public void Close()
        {
            if (Status == Status.Processing)
            {
                Status = Status.Closed;
            }
        }
    }
}
