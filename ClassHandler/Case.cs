namespace ClassHandler;

public class Case : UltraClass
{
    public static int Id { get; set; }
    public static int DiagnoseId { get; set; }
    public static DateTime Created { get; set; }

    public Case(int caseId, int diagnoseId) : base()
    {

        CaseId = caseId;
        DiagnoseId = diagnoseId;

    }





}