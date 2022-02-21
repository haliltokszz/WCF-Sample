using EmployeeServiceReference;

EmployeeServiceClient client = new EmployeeServiceClient();
Console.WriteLine("Please enter an EmployeeId between 1 to 4");
int employeeId = Convert.ToInt32(Console.ReadLine());
var employee = await client.GetEmployeeAsync(employeeId);
var employeeIsWorkingString = employee.IsWorking ? $"Yes. {employee.Name} {employee.Surname} is working" :
    $"No. {employee.Name} {employee.Surname} is resting";
Console.WriteLine(employeeIsWorkingString);