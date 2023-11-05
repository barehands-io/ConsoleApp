// See https://aka.ms/new-console-template for more information

namespace consoleApp;

class Program
{
    static void Main(string[] args)
    {

        // Create an instance of the User class and use it
        User user = new User();
        user.PrintMessage();
        
        user.PrintUsers();
        
        Company company = new Company();

        ExcelReader reader = new ExcelReader();
        
        string filePath = @"uploads/company.xlsx";
        
        // Check if the file exists
        if (File.Exists(filePath))
        {
            Console.WriteLine("The file exists.");
            // You can now proceed to use the file
        }
        else
        {
            Console.WriteLine("The file does not exist.");
            // Handle the case when the file is not found
        }
        
        reader.ReadExcelFile(filePath);
        
        company.PrintCompanies();
    }
}