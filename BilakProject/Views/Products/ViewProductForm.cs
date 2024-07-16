using BilakProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilakProject.Views.Products
{
    public partial class ViewProductForm : Form
    {
        public ViewProductForm()
        {
            InitializeComponent();
            RefreshData();
        }

        private async void RefreshData()
        {
            try
            {
                IEnumerable<TeacherViewModel> student = null;
                HttpClient httpclient = new HttpClient();
                httpclient.BaseAddress = new Uri("https://localhost:7144/");
                var consumeApi = await httpclient.GetAsync("api/teacher");


                if (consumeApi.IsSuccessStatusCode)
                {
                    var displayData = await consumeApi.Content.ReadAsAsync<IList<TeacherViewModel>>();
                    student = displayData;
                    StudentDataGridView.DataSource = student;
                    ErrorLable.Visible = true;
                }
            }
            catch (Exception ex)
            {
                ErrorLable.Text = "Please check whether web API is running or not!";
            }         
        }
    }
}
