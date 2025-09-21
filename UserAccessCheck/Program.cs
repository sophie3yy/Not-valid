Console.Write("Enter username: ");
string username = Console.ReadLine() ?? "";

Console.Write("Enter password: ");
string password = Console.ReadLine() ?? "";

bool usernameValid = username.Length >= 3;   // bruger .Length
bool passwordValid = password.Contains('s'); // bruger .Contains('s')

if (usernameValid && passwordValid)
{
    Console.WriteLine("Both username and password are valid.");
}
else
{
    Console.WriteLine("Username or password is not valid.");
}