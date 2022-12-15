namespace ClassHandler;

public class Diagnose
{
    public int DiagnoseId { get; set; }
    public string DiagnoseName { get; set; }
    public string DiagnoseFounder { get; set; }

    public Diagnose(string diagnoseName, string diagnoseFounder) //Only if legit Diagnose is found, invented or made up.
    {

    }

    public Diagnose() //Else only to load from db
    {

    }
}