using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayerWinform
{
    

    public partial class EmployeeList : Form
    {
       ServiceEmployee.ServiceEmployeesClient servEmp;

        public EmployeeList()
        {
            InitializeComponent();
            servEmp = new ServiceEmployee.ServiceEmployeesClient();
        }

        private void EmployeeList_Load(object sender, EventArgs e)
        {
            //ServiceEmployee.Employee emp= new ServiceEmployee.FullTimeEmployee() { Name="DefaultEmployee"};
            //servEmp.AddEmployee(emp);
            Debug.WriteLine("test");
            
            // SERVICE
            try
            {
                listBox1.Items.Add("test");
                servEmp.GetAllEmployees();
                listBox1.Items.Add("test2");
                ServiceEmployee.Employee[] listaEmp = servEmp.GetAllEmployees();
                listBox1.Items.Add("test3");
                foreach (ServiceEmployee.Employee emp in listaEmp)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = emp.Name;
                    listBox1.Items.Add(item);
                }
            }
            catch(System.ServiceModel.FaultException ex)
            {
                Debug.WriteLine(ex.Message);
            }
            
            /* MOCK
            try
            {
                DALEmployeesMock dal = new DALEmployeesMock();
                List<Shared.Entities.Employee> empList = dal.GetAllEmployees();
                foreach (Shared.Entities.Employee emp in empList)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = emp.Name;
                    listBox1.Items.Add(item);
                }
            }catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            */

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
