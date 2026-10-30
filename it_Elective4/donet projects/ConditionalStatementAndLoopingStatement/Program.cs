// ============================================================================
// CONDITIONAL STATEMENTS AND LOOPING STATEMENTS
// Dito makikita ang if/else, switch, logical operators, control statements,
// at iba't ibang loops. Bawat section ay may maliit na example para madaling sundan.
// ============================================================================

// ---------------------------------------------------------------------------
// 1. SETTINGS USED BY THE PROGRAM
// Nilagay natin dito para isang place lang ang babaguhin kung may update.
// ---------------------------------------------------------------------------
const decimal AdultAge = 18m;
const int LoopStart = 0;
const int LoopLimit = 5;
const int StopLoopAt = 3;
const int SampleLoopLimit = 3;

// ---------------------------------------------------------------------------
// 2. GET AND VALIDATE THE AGE INPUT
// Kukunin muna ang input as text, then iche-check kung valid na number ito.
// ---------------------------------------------------------------------------
Console.Write("Enter your age: ");
string? ageInput = Console.ReadLine();

// TryParse ang ginagamit para hindi mag-crash ang program kapag letters ang input.
if (!decimal.TryParse(ageInput, out decimal age))
{
    Console.WriteLine("Invalid input. Please enter a valid number for age.");
    return; // RETURN: Walang valid age, so dito na agad matatapos ang program.
}

// Ipapakita lang nito kung anong data type ang gamit sa age variable.
Console.WriteLine(age.GetType().Name);

// ---------------------------------------------------------------------------
// 3. IF / ELSE IF / ELSE EXAMPLE
// Same age check ito, written using the usual if-else structure.
// ---------------------------------------------------------------------------
Console.WriteLine("\n--- IF / ELSE IF / ELSE ---");

if (age < 0)
{
    Console.WriteLine("Invalid Age");
}
else if (age < AdultAge)
{
    Console.WriteLine($"Age: {age} | You're a minor now");
}
else
{
    Console.WriteLine($"Age: {age} | You're an adult now");
}

// ---------------------------------------------------------------------------
// 4. SWITCH STATEMENT EXAMPLE
// Same result as the if-else block above, but this time switch ang gamit.
// ---------------------------------------------------------------------------
Console.WriteLine("\n--- SWITCH STATEMENT ---");

switch (age)
{
    case < 0:
        Console.WriteLine("Invalid Age");
        break;

    case < AdultAge:
        Console.WriteLine($"Age: {age} | You're a minor now");
        break;

    default:
        Console.WriteLine($"Age: {age} | You're an adult now");
        break;
}

// ---------------------------------------------------------------------------
// 5. LOGICAL OPERATORS
// Logical operators ang gamit kapag pinagsasama o binabaliktad ang true/false.
// && means AND, || means OR, at ! means NOT.
// ---------------------------------------------------------------------------
Console.WriteLine("\n--- LOGICAL OPERATORS ---");

bool hasSchoolId = true;
bool hasPaidActivityFee = false;

// AND: parehong kailangang true para makasali.
bool canJoinActivity = hasSchoolId && hasPaidActivityFee;

// OR: kahit isa lang ang true, magiging true ang result.
bool needsToSettleFee = !hasPaidActivityFee || !hasSchoolId;

// NOT: binabaliktad nito ang value. true magiging false, at vice versa.
bool hasNotPaidActivityFee = !hasPaidActivityFee;

Console.WriteLine($"Has school ID: {hasSchoolId}");
Console.WriteLine($"Has paid activity fee: {hasPaidActivityFee}");
Console.WriteLine($"Can join activity (AND): {canJoinActivity}");
Console.WriteLine($"Needs to settle fee or show ID (OR): {needsToSettleFee}");
Console.WriteLine($"Has not paid the activity fee (NOT): {hasNotPaidActivityFee}");

// ---------------------------------------------------------------------------
// 6. WHILE LOOP
// Inuulit ng while loop ang code HABANG true pa ang condition.
// ---------------------------------------------------------------------------
Console.WriteLine("\n--- WHILE LOOP ---");

int countdown = SampleLoopLimit;

while (countdown > 0)
{
    Console.WriteLine($"Countdown: {countdown}");
    countdown--; // Important: binabago natin ang value para hindi maging infinite loop.
}

// ---------------------------------------------------------------------------
// 7. DO-WHILE LOOP
// Sa do-while, mauuna munang tumakbo ang code bago i-check ang condition.
// Kaya guaranteed na at least once itong mag-e-execute.
// ---------------------------------------------------------------------------
Console.WriteLine("\n--- DO-WHILE LOOP ---");

int doWhileNumber = 1;

do
{
    Console.WriteLine($"Current number: {doWhileNumber}");
    doWhileNumber++;
}
while (doWhileNumber <= SampleLoopLimit);

// ---------------------------------------------------------------------------
// 8. FOR LOOP WITH BREAK
// BREAK ang control statement na ginagamit para huminto agad sa loop.
// Maglo-loop from 0 hanggang 4, pero hihinto agad kapag umabot sa 3.
// ---------------------------------------------------------------------------
Console.WriteLine("\n--- FOR LOOP WITH BREAK ---");

for (int i = LoopStart; i < LoopLimit; i++)
{
    if (i == StopLoopAt)
    {
        Console.WriteLine($"Breaking the loop at i = {StopLoopAt}");
        break; // Lalabas agad sa loop kapag ang value ni i ay 3.
    }

    Console.WriteLine($"Current value of i: {i}");
}

// ---------------------------------------------------------------------------
// 9. FOR LOOP WITH CONTINUE
// CONTINUE ang control statement na ginagamit para i-skip ang current iteration.
// Sa example na ito, isi-skip natin ang even numbers at ipi-print lang ang odd.
// ---------------------------------------------------------------------------
Console.WriteLine("\n--- FOR LOOP WITH CONTINUE ---");

for (int number = 1; number <= LoopLimit; number++)
{
    if (number % 2 == 0)
    {
        Console.WriteLine($"Skipping even number: {number}");
        continue; // Skip the code below, then proceed sa next number.
    }

    Console.WriteLine($"Odd number: {number}");
}

// ---------------------------------------------------------------------------
// 10. NESTED FOR LOOP
// Ang nested loop ay loop sa loob ng isa pang loop.
// Dito, ginagamit ito para gumawa ng simple 3 x 3 multiplication table.
// ---------------------------------------------------------------------------
Console.WriteLine("\n--- NESTED FOR LOOP: MULTIPLICATION TABLE ---");

for (int row = 1; row <= SampleLoopLimit; row++)
{
    for (int column = 1; column <= SampleLoopLimit; column++)
    {
        Console.Write($"{row * column,4}");
    }

    Console.WriteLine(); // Lipat sa next row pagkatapos matapos ang inner loop.
}

// ---------------------------------------------------------------------------
// 11. FOREACH LOOP
// foreach ang madaling gamitin kapag gusto lang basahin lahat ng items sa array.
// Hindi na kailangan manual gumawa ng counter tulad ng i++.
// ---------------------------------------------------------------------------
Console.WriteLine("\n--- FOREACH LOOP ---");

string[] subjects = { "English", "Mathematics", "Science" };

foreach (string subject in subjects)
{
    Console.WriteLine($"Subject: {subject}");
}

// ---------------------------------------------------------------------------
// 12. CONTROL STATEMENTS QUICK GUIDE
// Summary ito ng control statements na nagamit sa program.
// ---------------------------------------------------------------------------
Console.WriteLine("\n--- CONTROL STATEMENTS QUICK GUIDE ---");
Console.WriteLine("break    - hinihinto agad ang loop.");
Console.WriteLine("continue - nilalaktawan ang current loop iteration.");
Console.WriteLine("return   - tinatapos ang current method o program.");
Console.WriteLine("if/switch - pinipili kung anong code ang tatakbo based sa condition.");

Console.WriteLine("\nPress any key to exit...");
Console.ReadKey(); // Hintay muna ng key press bago magsara ang console window.

Console.WriteLine("\n--- Grade Checker ---");

Console.Write("Enter your grade (0-100): ");
String? input = Console.ReadLine();


// Validate the input to ensure it's a valid decimal number
if(!decimal.TryParse(input, out decimal gradeInput))
{
    Console.WriteLine("Invalid input. Please enter a valid number for grade.");
    return;   
}

if (gradeInput < 0 || gradeInput > 100)
{
    Console.WriteLine("Invalid grade. Please enter a number between 0 and 100.");
}
else if (gradeInput >= 90)
{
    Console.WriteLine("Grade: Excellent");
}
else if (gradeInput >= 85)
{
    Console.WriteLine("Grade: Very Good");
}
else if (gradeInput >= 80)
{
    Console.WriteLine("Grade: Good");
}
else if (gradeInput >= 75)
{
    Console.WriteLine("Grade: Passed");
}
else
{
    Console.WriteLine("Grade: Failed");
}

Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();
Console.WriteLine("\n\n");
