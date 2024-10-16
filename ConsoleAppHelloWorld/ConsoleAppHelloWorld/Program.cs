// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");




//1.  Writing to the console
Write("Hello ");
Write("World");
Write("!");

WriteLine();
WriteLine();

WriteLine("Hello World!");
WriteLine();



/* *******************************************
 * 2.
*/

//Reading from the console (user input)
int age; 
string? firstname;

//Reading STRING  from the console (user input)
Write("Enter your firstname: ");
firstname = ReadLine();

WriteLine("Hello " + firstname);




/* *******************************************
 * 3.
 * 
*/ 
//Reading INTEGER  from the console (user input)
Write("Enter your age: ");

// Converted string to int
age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Hello " + firstname + ". " );
Console.WriteLine("You are " + age + " year(s) old!");





/* *******************************************
 * 4.
*/
string? dateOfBirthStg;

//Reading DATE from the console (user input)
Write("Please enter date of birth in format DD/MM/YYYY: ");
dateOfBirthStg = ReadLine();

// Converted string to DATE
//NOTE: Invalid date will raise an exception
DateTime dateOfBirth = DateTime.ParseExact(dateOfBirthStg, "dd/MM/yyyy", DateTimeFormatInfo.InvariantInfo);
Console.WriteLine(dateOfBirth + " is a valid date.");

