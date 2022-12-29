namespace ClassHandler;

public class Case : IEntityHelper//: UltraClass
{
    public static int CaseId { get; set; }
    public static int DiagnoseId { get; set; }
    public static DateTime ClientCaseCreated { get; set; }

    public Case() : base(int caseid) //int caseId, int diagnoseId : base()
    {

    }





}