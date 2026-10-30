
// Created by: Neil Wayne Cruz, Charlie Magne Rola - BSIT 4-2

Console.WriteLine("=====================================================");
Console.WriteLine(" LOAN ELIGIBILITY AND RISK ASSESSMENT SYSTEM");
Console.WriteLine("=====================================================");


// 1. INPUTS AND VALIDATION
// Kapag invalid ang isang input, hihinto muna ang program para hindi mali ang
// magiging loan assessment.


Console.Write("Enter applicant age: ");
if (!int.TryParse(Console.ReadLine(), out int age) || age < 0)
{
    Console.WriteLine("Invalid age. Please enter a valid whole number.");
    return;
}

Console.Write("Enter monthly income: ");
if (!decimal.TryParse(Console.ReadLine(), out decimal monthlyIncome) || monthlyIncome <= 0)
{
    Console.WriteLine("Invalid monthly income. Please enter an amount greater than zero.");
    return;
}

Console.Write("Enter employment status (Employed/Self-Employed/Unemployed): ");
string employmentStatus = Console.ReadLine() ?? "";
employmentStatus = employmentStatus.Trim().ToLower();
string employmentStatusDisplay;

if (employmentStatus == "employed")
{
    employmentStatusDisplay = "Employed";
}
else if (employmentStatus == "self-employed")
{
    employmentStatusDisplay = "Self-Employed";
}
else if (employmentStatus == "unemployed")
{
    employmentStatusDisplay = "Unemployed";
}
else
{
    Console.WriteLine("Invalid employment status.");
    return;
}

Console.Write("Enter years employed or in business: ");
if (!decimal.TryParse(Console.ReadLine(), out decimal yearsEmployed) || yearsEmployed < 0)
{
    Console.WriteLine("Invalid years employed. Please enter zero or a positive number.");
    return;
}

Console.Write("Enter credit score (300 to 850): ");
if (!int.TryParse(Console.ReadLine(), out int creditScore)
    || creditScore < 300
    || creditScore > 850)
{
    Console.WriteLine("Invalid credit score. Please enter a score from 300 to 850.");
    return;
}

Console.Write("Enter existing monthly debt: ");
if (!decimal.TryParse(Console.ReadLine(), out decimal existingMonthlyDebt)
    || existingMonthlyDebt < 0)
{
    Console.WriteLine("Invalid monthly debt. Please enter zero or a positive amount.");
    return;
}

Console.Write("Enter requested loan amount: ");
if (!decimal.TryParse(Console.ReadLine(), out decimal requestedLoanAmount)
    || requestedLoanAmount <= 0)
{
    Console.WriteLine("Invalid requested loan amount. Please enter an amount greater than zero.");
    return;
}

// Dalawang flags ang gamit para maalala kung may rejection o manual review.
// Sa final result, rejection ang laging may pinaka-highest priority.

bool isRejected = false; // flags
bool needsManualReview = false;  // flags
string rejectionReason = "";
string manualReviewReason = "";


// 2. INITIAL ELIGIBILITY
// Sinusunod ang order ng age at income rules sa problem.


if (age < 18)
{
    isRejected = true;
    rejectionReason = "Applicant is younger than 18.";
}
else if (age >= 18 && age <= 20)
{
    // Sa age 18 to 20, parehong kailangan ma-meet ang income at credit score.
    if (monthlyIncome < 50000m || creditScore < 750)
    {
        isRejected = true;
        rejectionReason = "Age 18 to 20 needs at least ₱50,000 income and 750 credit score.";
    }
}
else if (age > 65)
{
    needsManualReview = true;
    manualReviewReason = "Applicant is older than 65.";
}

// Separate ito para kahit manual review ang age, puwede pa ring ma-reject
// kapag below ₱15,000 ang income. Rejection ang mas mataas na priority.

if (monthlyIncome < 15000m)
{
    isRejected = true;

    if (rejectionReason == "")
    {
        rejectionReason = "Monthly income is below ₱15,000.";
    }
}


// 3. EMPLOYMENT ASSESSMENT


if (employmentStatus == "employed")
{
    if (yearsEmployed < 1m)
    {
        if (monthlyIncome >= 40000m)
        {
            needsManualReview = true;

            if (manualReviewReason == "")
            {
                manualReviewReason = "Employed applicant has less than 1 year of employment.";
            }
        }
        else
        {
            isRejected = true;

            if (rejectionReason == "")
            {
                rejectionReason = "Employed applicant has less than 1 year of employment and income is below ₱40,000.";
            }
        }
    }
}
else if (employmentStatus == "self-employed")
{
    if (yearsEmployed < 2m)
    {
        if (monthlyIncome >= 40000m)
        {
            needsManualReview = true;

            if (manualReviewReason == "")
            {
                manualReviewReason = "Self-employed applicant has less than 2 years in business.";
            }
        }
        else
        {
            isRejected = true;

            if (rejectionReason == "")
            {
                rejectionReason = "Self-employed applicant has less than 2 years in business and income is below ₱40,000.";
            }
        }
    }
}
else
{
    // Dito papasok ang Unemployed dahil na-validate na ito sa input section.
    isRejected = true;

    if (rejectionReason == "")
    {
        rejectionReason = "Unemployed applicants are automatically rejected.";
    }
}


// 4. CREDIT RISK CLASSIFICATION
// Una ay label ng score, then iche-check kung reject o manual review ito.


string creditClassification;

if (creditScore >= 750)
{
    creditClassification = "Excellent";
}
else if (creditScore >= 700)
{
    creditClassification = "Good";
}
else if (creditScore >= 650)
{
    creditClassification = "Fair";
}
else if (creditScore >= 600)
{
    creditClassification = "Poor";
    needsManualReview = true;

    if (manualReviewReason == "")
    {
        manualReviewReason = "Credit score is in the Poor range (600 to 649).";
    }
}
else
{
    creditClassification = "Very Poor";
    isRejected = true;

    if (rejectionReason == "")
    {
        rejectionReason = "Credit score is below 600.";
    }
}

// 5. DEBT-TO-INCOME RATIO (DTI)
// Formula: existing monthly debt / monthly income x 100


decimal debtToIncomeRatio = (existingMonthlyDebt / monthlyIncome) * 100m;
string dtiRisk;

if (debtToIncomeRatio <= 30m)
{
    dtiRisk = "Low Risk";
}
else if (debtToIncomeRatio <= 40m)
{
    dtiRisk = "Moderate Risk";
}
else if (debtToIncomeRatio <= 50m)
{
    dtiRisk = "High Risk";
    needsManualReview = true;

    if (manualReviewReason == "")
    {
        manualReviewReason = "DTI is above 40% up to 50%.";
    }
}
else
{
    dtiRisk = "Very High Risk";
    isRejected = true;

    if (rejectionReason == "")
    {
        rejectionReason = "DTI is above 50%.";
    }
}


// 6. LOAN AMOUNT ASSESSMENT
// Kinukuha kung ilang beses ang requested loan kumpara sa monthly income.


decimal loanToIncomeMultiple = requestedLoanAmount / monthlyIncome;
string loanAmountAssessment;

if (loanToIncomeMultiple <= 5m)
{
    loanAmountAssessment = "Eligible for standard assessment";
}
else if (loanToIncomeMultiple <= 10m)
{
    // Loan na 5x hanggang 10x needs good credit at low DTI.
    if (creditScore >= 700 && debtToIncomeRatio <= 30m)
    {
        loanAmountAssessment = "Passed the 5x to 10x loan requirement";
    }
    else
    {
        loanAmountAssessment = "Did not meet the 5x to 10x loan requirement";
        isRejected = true;

        if (rejectionReason == "")
        {
            rejectionReason = "Loan above 5 times monthly income needs credit score 700+ and DTI of 30% or less.";
        }
    }
}
else
{
    loanAmountAssessment = "Requested loan is above 10 times monthly income";
    isRejected = true;

    if (rejectionReason == "")
    {
        rejectionReason = "Requested loan is above 10 times the monthly income.";
    }
}

// 7. FINAL DECISION
// Rejection > Manual Review > Approval ang priority, as required.

string finalDecision;
string finalReason;

if (isRejected)
{
    finalDecision = "LOAN REJECTED";
    finalReason = rejectionReason;
}
else if (needsManualReview)
{
    finalDecision = "FOR MANUAL REVIEW";
    finalReason = manualReviewReason;
}
else
{
    finalDecision = "LOAN APPROVED";
    finalReason = "Applicant passed all loan assessment rules.";
}


// 8. SUMMARY 


Console.WriteLine("\n=====================================================");
Console.WriteLine("                 APPLICANT LOAN SUMMARY");
Console.WriteLine("=====================================================");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Monthly Income: {monthlyIncome:C2}");
Console.WriteLine($"Employment Status: {employmentStatusDisplay}");
Console.WriteLine($"Years Employed / In Business: {yearsEmployed:N1}");
Console.WriteLine($"Credit Score: {creditScore} ({creditClassification})");
Console.WriteLine($"Existing Monthly Debt: {existingMonthlyDebt:C2}");
Console.WriteLine($"DTI: {debtToIncomeRatio:N2}% ({dtiRisk})");
Console.WriteLine($"Requested Loan Amount: {requestedLoanAmount:C2}");
Console.WriteLine($"Loan Multiple: {loanToIncomeMultiple:N2}x monthly income");
Console.WriteLine($"Loan Assessment: {loanAmountAssessment}");
Console.WriteLine("-----------------------------------------------------");
Console.WriteLine($"FINAL DECISION: {finalDecision}");
Console.WriteLine($"REASON: {finalReason}");
Console.WriteLine("=====================================================");
