// ============================================================================
// JOHN DOE PAYROLL CALCULATOR
// Simple payroll calculator ito para makita natin, step by step, kung paano
// kinukuha ang regular pay, overtime pay, deductions, tax, at final salary ni John.
// Tip: Basahin lang from top to bottom para madaling sundan ang flow.
// ============================================================================

// ---------------------------------------------------------------------------
// 1. EMPLOYEE INFORMATION
// Basic details lang ni employee. Pinagsasama natin ito mamaya para mabuo ang name.
// ---------------------------------------------------------------------------
string firstName = "John";
char middleInitial = 'T';
string lastName = "Doe";

string employeeFullName = $"{firstName} {middleInitial}. {lastName}";

// ---------------------------------------------------------------------------
// 2. PAYROLL INPUTS
// Dito nakalagay ang mga values na pwedeng palitan kapag may bagong salary details.
// example, kung nagbago ang daily rate o overtime hours, dito lang mag-update.
// ---------------------------------------------------------------------------

// decimal ang gamit sa pera para mas accurate ang computation ng currency.
decimal dailyPayRate = 700.80m; // Daily rate ni John.
int workingDaysPerMonth = 20;   // Bilang ng days na pinasok niya this month.

// Ito naman ang overtime details ni John for this month.
decimal overtimePayRatePerHour = 218.67m; // Bayad kada isang OT hour.
int overtimeHoursWorked = 18;             // Total OT hours na na-render niya.

// Fixed government contributions ito every month.
// Important: sa regular salary lang sila ibabawas, hindi sa overtime pay.
decimal sssDeduction = 152.70m;        // SSS contribution.
decimal pagIbigDeduction = 80.80m;     // Pag-IBIG contribution.
decimal philHealthDeduction = 100.00m; // PhilHealth contribution.

// 10% tax ito. Sa code, 0.10 ang katumbas ng 10%.
decimal incomeTaxRate = 0.10m;

// ---------------------------------------------------------------------------
// 3. REGULAR SALARY CALCULATION
// Formula: daily pay × number of days na pumasok si John.
// Ito ang regular salary niya bago pa bawasan ng kahit anong deduction.
// ---------------------------------------------------------------------------
decimal regularMonthlySalary = dailyPayRate * workingDaysPerMonth;

// ---------------------------------------------------------------------------
// 4. OVERTIME CALCULATION
// Formula: overtime rate per hour × total overtime hours.
// Separate muna ito sa regular salary para clear kung magkano ang OT pay.
// ---------------------------------------------------------------------------
decimal totalOvertimePay = overtimePayRatePerHour * overtimeHoursWorked;

// ---------------------------------------------------------------------------
// 5. GOVERNMENT CONTRIBUTIONS
// Pagsasamahin muna ang SSS, Pag-IBIG, at PhilHealth.
// Reminder: regular salary lang ang babawasan nito; hindi gagalawin ang OT pay.
// ---------------------------------------------------------------------------
decimal totalGovernmentContributions = sssDeduction + pagIbigDeduction + philHealthDeduction;

decimal regularPayAfterContributions = regularMonthlySalary - totalGovernmentContributions;

// ---------------------------------------------------------------------------
// 6. TAX AND FINAL NET SALARY
// Pagkatapos ng government contributions, idagdag natin ang overtime pay.
// Then, saka lang kukunin ang 10% tax mula sa combined amount.
// Ang matitira ang final take-home salary ni John.
// ---------------------------------------------------------------------------
decimal taxablePay = regularPayAfterContributions + totalOvertimePay;
decimal incomeTaxDeduction = taxablePay * incomeTaxRate;
decimal finalTakeHomeSalary = taxablePay - incomeTaxDeduction;

// ---------------------------------------------------------------------------
// 7. PAYROLL SUMMARY
// Ito ang final output para madaling makita ni John ang buong computation.
// ---------------------------------------------------------------------------
Console.WriteLine("================================================");
Console.WriteLine("             JOHN DOE PAYROLL SUMMARY");
Console.WriteLine("================================================");
Console.WriteLine($"Employee: {employeeFullName}");
Console.WriteLine();

Console.WriteLine("REGULAR SALARY");
Console.WriteLine($"Daily pay rate: {dailyPayRate:C2}");
Console.WriteLine($"Working days: {workingDaysPerMonth}");
Console.WriteLine($"Regular monthly salary: {regularMonthlySalary:C2}");
Console.WriteLine();

Console.WriteLine("OVERTIME PAY");
Console.WriteLine($"Overtime rate per hour: {overtimePayRatePerHour:C2}");
Console.WriteLine($"Overtime hours worked: {overtimeHoursWorked}");
Console.WriteLine($"Total overtime pay: {totalOvertimePay:C2}");
Console.WriteLine();

Console.WriteLine("GOVERNMENT CONTRIBUTIONS (REGULAR SALARY ONLY)");
Console.WriteLine($"SSS: {sssDeduction:C2}");
Console.WriteLine($"Pag-IBIG: {pagIbigDeduction:C2}");
Console.WriteLine($"PhilHealth: {philHealthDeduction:C2}");
Console.WriteLine($"Total contributions: {totalGovernmentContributions:C2}");
Console.WriteLine($"Regular pay after contributions: {regularPayAfterContributions:C2}");
Console.WriteLine();

Console.WriteLine("FINAL CALCULATION");
Console.WriteLine($"Taxable pay (regular pay + overtime): {taxablePay:C2}");
Console.WriteLine($"Income tax (10%): {incomeTaxDeduction:C2}");
Console.WriteLine("------------------------------------------------");
Console.WriteLine($"FINAL TAKE-HOME SALARY: {finalTakeHomeSalary:C2}");
Console.WriteLine("================================================");
