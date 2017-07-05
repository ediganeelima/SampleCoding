public class Store
{
    protected int StoreID { get; set; }
    protected string StoreName { get; set; }
    protected OperationHours OperatingHours { get; set; }

    public Store(string storeName, OperationHours operatingHours, int storeID ){
        StoreID = storeID;
        StoreName = storeName ?? "NoNameStore";

        if (operatingHours == null)
            throw new ArgumentNullException("Operating Hours is null");

        OperatingHours = operatingHours;
    }

    public string OperationHours()
    {
        return this.OperatingHours.ToString();
    }

    public override string ToString()
    {
        StringBuilder me = new StringBuilder();
        me.AppendLine(string.Format("Store {0}  ID {1}", StoreName, StoreID ));
        me.AppendLine("Hours Of Operation:");
        me.AppendLine(OperationHours());

        return me.ToString();
    }
}