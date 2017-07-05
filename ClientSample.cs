public static void Main(string[] args)
    {
        OperationHours opsHours = new OperationHours();
        opsHours.Add(new StoreTimes(DayOfWeek.Monday, "1000", "1800"));
        //....
        opsHours.Add(new StoreTimes(DayOfWeek.Thrusday, "1000", "1900"));
        //....
        opsHours.Add(new StoreTimes(DayOfWeek.Sunday, null, null));

        Store myStore = new Store("myStore", opsHours, 1);
        Console.WriteLine(CostingTons.ToString());
        Console.ReadLine();
  }