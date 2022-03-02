using static System.Math;

// 1.
Console.WriteLine($"Hello Theodore!");

// 2.
int a = 475;
int b = 184;

Console.WriteLine(a + b);
Console.WriteLine((double)a / b);

// 3.
Console.WriteLine(-1 + 5 * 6);
Console.WriteLine(38 + 5 % 7);
Console.WriteLine(14 + -3.0 * 6 / 7);
Console.WriteLine(2 + 13.0 / 6 * 6 + Sqrt(7));
Console.WriteLine((Pow(6, 4) + Pow(5, 7)) / (9 % 4));

// 4.
int age = 22;
string gender = "female";
Console.WriteLine($"You are {gender} and look younger than {age}.");

// 5.
int seconds = 184184184;
AnalyzeDatePartsHandWritten(seconds, out int minutes, out int hours, out int days, out int years);
DisplayDateParts(seconds, minutes, hours, days, years);

// 6.
AnalyzeDatePartsNetLibraries(seconds, out minutes, out hours, out days, out years);
DisplayDateParts(seconds, minutes, hours, days, years);

// 7.
double celsius = -40;

Console.WriteLine($"{celsius} °C is {CelsiusToKelvin(celsius)} °K.");
Console.WriteLine($"{celsius} °C is {CelsiusToFahrenheit(celsius)} °F.");

// Utility code for 5. and 6.
static void AnalyzeDatePartsHandWritten(int seconds, out int minutes, out int hours, out int days, out int years)
{
    int remainingSeconds;

    const int totalSecondsInYear = 365 * 24 * 60 * 60;
    years = seconds / totalSecondsInYear;
    remainingSeconds = seconds % totalSecondsInYear;

    const int totalSecondsInDay = 24 * 60 * 60;
    days = remainingSeconds / totalSecondsInDay;
    remainingSeconds %= totalSecondsInDay;

    const int totalSecondsInHour = 60 * 60;
    hours = remainingSeconds / totalSecondsInHour;
    int remainingMinutes = remainingSeconds % totalSecondsInHour;

    const int totalSecondsInMinute = 60;
    minutes = remainingMinutes / totalSecondsInMinute;
}

static void AnalyzeDatePartsNetLibraries(int seconds, out int minutes, out int hours, out int days, out int years)
{
    TimeSpan timeSpan = TimeSpan.FromSeconds(seconds);

    years = timeSpan.Days / 365;
    days = timeSpan.Days % 365;
    hours = timeSpan.Hours;
    minutes = timeSpan.Minutes;
}

static void DisplayDateParts(int seconds, int minutes, int hours, int days, int years)
{
    Console.WriteLine($"{seconds} second{Pluralize(seconds)} {Pluralize(seconds, "are", "is")} equal to" +
$" {years} year{Pluralize(years)}, {days} day{Pluralize(years)}, {hours} hour{Pluralize(years)} and {minutes} minute{Pluralize(years)}.");

    static string Pluralize(int value, string plural = "s", string singular = "") =>
        value is 1 ? singular : plural;
}

// Utility code for 7.
static double CelsiusToKelvin(double celsius) => celsius + 273.15;

static double CelsiusToFahrenheit(double celsius) => FusedMultiplyAdd(celsius, 1.8, 32);
