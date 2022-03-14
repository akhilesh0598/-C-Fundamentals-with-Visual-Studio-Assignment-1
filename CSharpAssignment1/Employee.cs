using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment1
{
    public delegate void EmployeeDetailsDelegate(object sender, MessageEventArgs eventArgs);

    public class MessageEventArgs:EventArgs
    {
        public string Message { get; set; }
    }
    class Employee
    {
        
        public event EmployeeDetailsDelegate DetailsDelegate;
        private int _id;
        private string _name;
        private string _departmentName;
        
        public Employee(int id,string name,string departmentName)
        {
            _id = id;
            _name = name;
            _departmentName = departmentName;
        }
        public int GetId()
        {
            string message = "GetId() method called";
            OnDetailsDelegate(message);
            return _id;
        }
        public string GetName()
        {
            string message = "GetName() method called";
            OnDetailsDelegate(message);
            return _name;
        }
        public string GetDepartmentName()
        {
            string message = "GetDepartmentName() method called";
            OnDetailsDelegate(message);
            return _departmentName;
        }
        public void UpdateEmployeeDetail(int id)
        {
            _id = id;
        }
        public void UpdateEmployeeDetail(int id,string name)
        {
            _name = name;
        }
        public void UpdateEmployeeDetail(int id,string name,string departmentName)
        {
            _id = id;
            _name = name;
            _departmentName = departmentName;
           
        }
        protected virtual void OnDetailsDelegate(string message)
        {
            if(DetailsDelegate!=null)
            {
                DetailsDelegate(this, new MessageEventArgs() { Message = message });
            }

        }
    }
}
