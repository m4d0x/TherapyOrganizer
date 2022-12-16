namespace ClassHandler;

public abstract class UltraClass
{
    // Handles user and client props generally
    public static int Id { get; set; }

    public static string? FullName { get; set; } // covers all classes in need
    public static string? LastName { get; set; } // covers all classes in need
    public static string? Address { get; set; } // at this point clinic only
    public static string? City { get; set; } // at this point clinic only
    public static string? Occupation { get; set; }  // covers client only
    public static string? Email { get; set; } // covers all classes in need
    public static string? PassWord { get; set; } // covers all classes in need
    public static int PhoneNumber { get; set; } // covers all classes in need

    // Handles CaseId for both clients, cases, case_logs, users etc


    // Handles CaseLogs for each client case
    public static int CaseLogId { get; set; } // FK from case
    public static string? CaseLogText { get; set; } // only written and read by "users" without Admin Accessability
    public static int DiagnoseId { get; set; } // FK from diagnoses
    public static int CaseId { get; set; } // FK belonging to both case_log and client

    // Handles booking properties for each client 
    public static int BookingId { get; set; } // to tie user, client and treatment date together and to extract booking
    public static int ClientId { get; set; } // FK from client
    public static int UserId { get; set; } // FK from user

    public static string? Name { get; set; } // more specifically for diagnose name
    public static string? Founder { get; set; } // Name of diagnose founder

    // Handles Times for some tables
    public static DateTime Created { get; set; } // case & case_log
    public static DateTime TreatmentDate { get; set; } // booking


    public UltraClass()
    {

    }










}