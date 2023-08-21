using System.Security.Cryptography.X509Certificates;

namespace TP24.Services.Models;

public class PayloadRequest
{
    public int Id { get; set; }
    public string Reference { get; set; }
    public string CurrencyCode { get; set; }
    public string IssueDate { get; set; }
    public double OpeningValue { get; set; }
    public double PaidValue { get; set; }
    public DateTime DueDate { get; set; }
    public string ClosedDAte { get; set; }
    public bool Cancelled { get; set; }
    public string DebtorName { get; set; }
    public string DebtorReference { get; set; }
    public string DebtorAddress1 { get; set; }
    public string DebtorAddress2 { get; set; }
    public string DebtorTown { get; set; }
    public string DebtorState { get; set; }
    public string DebtorZip { get; set; }
    public string DebtorCountryCode { get; set; }
    public string DebtorRegistrationNumber { get; set; }
}