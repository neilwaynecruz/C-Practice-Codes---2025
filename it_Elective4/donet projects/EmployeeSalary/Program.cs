
// Employee Salary Machine
// Created by Cruz, Neil Wayne T. at Rola, Charlie Magne J.


Console.Clear(); // clear the terminal screen para sa mas malinis na output.

Console.WriteLine("\n=====================================");
Console.WriteLine("      EMPLOYEE SALARY MACHINE");
Console.WriteLine("=====================================");


int employeeCount = 0;

// Uulit ang prompt hanggang makapaglagay ng valid na bilang ng employees.
while (employeeCount <= 0)
{
    Console.Write("Enter number of employees: ");
    string? employeeCountInput = Console.ReadLine();

    if (int.TryParse(employeeCountInput, out int enteredEmployeeCount)
        && enteredEmployeeCount > 0)
    {
        employeeCount = enteredEmployeeCount;
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a positive whole number.\n");
    }
}

// I-process ang details at salary ng bawat employee isa-isa.
for (int employeeNumber = 1; employeeNumber <= employeeCount; employeeNumber++)
{
    Console.WriteLine($"\n===== EMPLOYEE #{employeeNumber} =====");

    string employeeName = "";

    // Hindi pwedeng blank or may leading whitespaces yung pangalan para kumpleto ang payslip details.
    while (string.IsNullOrWhiteSpace(employeeName))
    {
        Console.Write("Enter Employee Name: ");
        employeeName = Console.ReadLine() ?? "";

        if (string.IsNullOrWhiteSpace(employeeName))
        {
            Console.WriteLine("Employee name is required. Please enter a valid name.");
        }
    }

    string employeePosition = "";
    decimal selectedHourlyRate = 0m;
    bool isValidPosition = false;

    // Base sa position, dito kinukuha ang tamang hourly rate.
    while (!isValidPosition)
    {
        Console.Write("Enter Position (Manager/Supervisor/Staff/Intern): ");
        string? positionInput = Console.ReadLine();
        string position = positionInput?.Trim().ToLower() ?? "";

        if (position == "manager")
        {
            employeePosition = "Manager";
            selectedHourlyRate = 500.00m;
            isValidPosition = true;
        }
        else if (position == "supervisor")
        {
            employeePosition = "Supervisor";
            selectedHourlyRate = 350.00m;
            isValidPosition = true;
        }
        else if (position == "staff")
        {
            employeePosition = "Staff";
            selectedHourlyRate = 250.00m;
            isValidPosition = true;
        }
        else if (position == "intern")
        {
            employeePosition = "Intern";
            selectedHourlyRate = 150.00m;
            isValidPosition = true;
        }
        else
        {
            Console.WriteLine("Invalid position!");
            Console.WriteLine("Please enter Manager, Supervisor, Staff, or Intern.\n");
        }
    }

    int hoursWorked = -1;

    // accepted LANG and zero o positive na working hours.
    while (hoursWorked < 0)
    {
        Console.Write("Enter Hours Worked: ");
        string? hoursWorkedInput = Console.ReadLine();

        if (int.TryParse(hoursWorkedInput, out int enteredHoursWorked)
            && enteredHoursWorked >= 0)
        {
            hoursWorked = enteredHoursWorked;
        }
        else
        {
            Console.WriteLine("Invalid number of hours.");
            Console.WriteLine("Please enter a valid number.\n");
        }
    }

    // Basic salary: total hours worked multiplied by hourly rate.
    decimal salary = hoursWorked * selectedHourlyRate;

    // Ipakita ang final details at computed salary ng employee.
    Console.WriteLine("\n===== EMPLOYEE PAYSLIP =====");
    Console.WriteLine($"Employee Name: {employeeName}");
    Console.WriteLine($"Position: {employeePosition}");
    Console.WriteLine($"Hours Worked: {hoursWorked}");
    Console.WriteLine($"Hourly Rate: {selectedHourlyRate:C2}");
    Console.WriteLine($"Salary: {salary:C2}");

    
}

Console.WriteLine("\n=====================================\npress any key to exit...");
Console.ReadKey();
