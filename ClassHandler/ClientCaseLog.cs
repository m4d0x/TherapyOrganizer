namespace ClassHandler;

public class ClientCaseLog : UltraClass//ultraclass containing parts of each table
{
    
    //public int CCLogId { get; set; }
    public string ClientFirstName { get; set; }
    public string ClientLastName { get; set; }
    public int ClientCaseId { get; set; }
    public int DiagnoseId { get; set; }
    public string DiagnoseName { get; set; }
    public int CaseLogId { get; set; }
    public string CaseLogText { get; set; }
    
    public ClientCaseLog() : base(int diagnoseId, string diagnoseName, string)
    {

    }




}