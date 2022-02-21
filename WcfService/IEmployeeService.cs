using System.ServiceModel;

namespace WcfService
{
    [ServiceContract]
    public interface IEmployeeService
    {
        [OperationContract]
        Employee GetEmployee(int id);
        [OperationContract]
        bool EmployeeIsWorking(int id);
    }
}
