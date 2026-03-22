using Small_Bank;

List<IReportable> Report = new List<IReportable>();
SavingsAccount s1 = new("fayez", 5000);
CurrentAccount c1 = new("zahree", 10000);
Loan l1 = new("noor", 50000);
Report.Add(s1);
Report.Add(c1);
Report.Add(l1);
foreach (IReportable t in Report) 

{
    Console.WriteLine(t.ToString());


}