namespace ClassHandler;

public class ClientCase
{
    public int Id { get; set; }
    public int DiagnoseId { get; set; }
    public DateTime Created { get; set; }

    public ClientCase(int id, int diagnoseId) //creation of ClientCase
    {
        Id = id;
        DiagnoseId = diagnoseId;
        Created = DateTime.Now;
    }

    public ClientCase() //load of ClientCase
    {

    }



}