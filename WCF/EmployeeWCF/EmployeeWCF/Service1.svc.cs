using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EmployeeWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IEmployeeService
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

       


        public string AddEmployeeRecord(Employee emp)
        {
            string result = "";
            try
            {
                 
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLDBConnectionString"].ToString());
                SqlCommand cmd = new SqlCommand();

                string Query = @"INSERT INTO [FSE].[dbo].[Employees](SupplierId ,SupplierName ,Address ,City,ContactNumber,Email)VALUES 
                                        (@SupplierId ,@SupplierName ,@Address ,@City,@ContactNumber,@Email )";

                cmd = new SqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@EmpID", emp.EmployeeId);
                cmd.Parameters.AddWithValue("@Name", emp.EmployeeName);
                cmd.Parameters.AddWithValue("@Location", emp.Location); 
                cmd.Parameters.AddWithValue("@Salary", emp.Salary);
                cmd.Parameters.AddWithValue("@Gender", emp.Gender);
                cmd.Parameters.AddWithValue("@Phone", emp.Phone);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                result = "Record Added Successfully !";
            }
            catch (FaultException fex)
            {
                result = "Error";
            }

            return result; 
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> lst = new List<Employee>();
            
            try
            {
                using(SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLDBConnectionString"].ToString()))
                {
                    string Query = "SELECT * FROM Employees";
                    DataSet ds = new DataSet();
                    SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                    sda.Fill(ds);
                    lst = ds.Tables[0].DataTableToList<Employee>();
                }
            }
            catch (FaultException fex)
            {
                throw new FaultException<string>("Error: " + fex);
            }

            return lst;
        }

        public string DeleteEmployeeRecord(int Id)
        {
            string result = "";
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLDBConnectionString"].ToString());
            SqlCommand cmd = new SqlCommand();
            string Query = "DELETE FROM Employees Where EmployeeId=@EmpID";
            cmd = new SqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@EmpID", Id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            result = "Record Deleted Successfully!";
            return result;
        }

        public Employee SearchEmployeeRecord(int Id)
        {
            DataSet ds = new DataSet();
            Employee e = new Employee();
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLDBConnectionString"].ToString());
                string Query = "SELECT * FROM Employees WHERE EmployeeId=@EmpID";

                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                sda.SelectCommand.Parameters.AddWithValue("@EmpID", Id);
                sda.Fill(ds);
                e = ds.Tables[0].DataTableToList<Employee>().ToList().FirstOrDefault();
            }
            catch (FaultException fex)
            {
                throw new FaultException<string>("Error:  " + fex);
            }
            return e; 
        }

        public string UpdateEmployeeRecord(Employee emp)
        {
            string result = "";
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLDBConnectionString"].ToString());
            SqlCommand cmd = new SqlCommand();

            string Query = "UPDATE Employees SET EmployeeName=@Name,Location=@Location,Salary=@Salary,Gender=@Gender,Phone=@Phone WHERE EmployeeId=@EmpID";

            cmd = new SqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@EmpID", emp.EmployeeId);
            cmd.Parameters.AddWithValue("@Name", emp.EmployeeName);
            cmd.Parameters.AddWithValue("@Location", emp.Location);
            cmd.Parameters.AddWithValue("@Salary", emp.Salary);
            cmd.Parameters.AddWithValue("@Gender", emp.Gender);
            cmd.Parameters.AddWithValue("@Phone", emp.Phone);
            con.Open();
            cmd.ExecuteNonQuery();
            result = "Record Updated Successfully !";
            con.Close();

            return result;
        }
    }
}
