namespace ClassHandler;

public class ClientCase : UltraClass
{
    public int Id { get; set; }
    public int DiagnoseId { get; set; }
    public DateTime Created { get; set; }

    public ClientCase(int id, int diagnoseId) : base()//creation of ClientCase
    {
        Id = id;
        DiagnoseId = diagnoseId;
        Created = DateTime.Now;
    }

    public ClientCase() //load of ClientCase
    {

    }



}