namespace consoleApp;

using ClosedXML.Excel;

public class ExcelReader
{

    public void ReadExcelFile(string filePath)

    {
        using (var workbook = new XLWorkbook(filePath))
        {
            
            var worksheet = workbook.Worksheet(1);
            
            var range = worksheet.RangeUsed();

            for (int row = 1; row <= range.RowCount(); row++)
            {
                // Iterate over the range's columns


                for (int col = 1; col <= range.ColumnCount(); col++)
                {
                    // Get the cell at the current row and column

                    var cell = range.Cell(row, col);
                    
                    // Read the cell's value and convert it to a string
                    var cellValue = cell.Value.ToString();
                    
                    
                    // print the cell value to the console
                    
                    Console.WriteLine($"Cell {row},{col}: {cellValue}");
                    
                    
                    
                }

            
              
            }
          
        }
    }
    
    
}