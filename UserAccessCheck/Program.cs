Console.Write("Enter username: ");
string username = Console.ReadLine() ?? "";

Console.Write("Enter password: ");
string password = Console.ReadLine() ?? "";

Console.Write("Enter user id: ");
uint userId = uint.Parse(Console.ReadLine() ?? "0");

bool userIsAdmin = userId > 65536;
bool usernameValid = username.Length >= 3;
bool passwordContainsSpecial = password.Contains('$') || password.Contains('[') || password.Contains('@');
bool passwordValid = false;

if (userIsAdmin)
{
    passwordValid = password.Length >= 20 && passwordContainsSpecial;
}
else
{
    passwordValid = password.Length >= 16 && passwordContainsSpecial;
}


if (usernameValid && passwordValid)
{
    Console.WriteLine("Both username and password are valid.");
}
else
{
    Console.WriteLine("Username or password is not valid.");
}