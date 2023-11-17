

int year = 2024;
bool is_leap = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
Console.WriteLine(is_leap);
 
