using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;

namespace Kredek
{
    public partial class FormMain : Form
    {
        NorthwindEntities db = new NorthwindEntities();
       //private IQueryable<Products> productNames = from p in db.Products select p.ProductName;
        private int loginAttempts = 0;
        private int wpisyAmount = 0;
        private int ticks = 0;
        private int buttonA3Location = 330;
        public FormMain()
        {
            InitializeComponent();
            A2GridView.Columns.Add("Kolumna1", "Pierwsza");
            A2GridView.Columns.Add("Kolumna2", "Druga");
            A2GridView.Columns.Add("Kolumna3", "Trzecia");
        }
        // LOGOWANIE
        private bool TryToLogIn()
        {
            if (textBoxLogin.Text == "admin" && textBoxPassword.Text == "test")
                return true;
            else
                return false;
        }

        private void HideLogInTextBoxes()
        {
            textBoxLogin.Visible = false;
            textBoxPassword.Visible = false;
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            if (TryToLogIn())
            {
                WriteLine("Pomyślnie zalogowano");
                HideLogInTextBoxes();
            }
                
            else
            {
                WriteLine("Nieprawidłowe dane logowania");
                loginAttempts++;
            }

            if (loginAttempts == 3)
                HideLogInTextBoxes();
        }
        // A2
        private void buttonAddWpis_Click(object sender, EventArgs e)
        {
            wpisyAmount++;
            textBoxWpisyCounter.Text = wpisyAmount.ToString();
            A2GridView.Rows.Add();
        }

        private void timerA3_Tick(object sender, EventArgs e)
        {
            ticks++;
            if (ticks % 3 == 0)
            {
                buttonA3Location += 10;
                buttonA3Start.Location = new Point(buttonA3Location, 25);
            }
        }
        // A3
        private void buttonA3Start_Click(object sender, EventArgs e)
        {
            timerA3.Start();
        }
        // A4
        private void buttonShowEmployees_Click(object sender, EventArgs e)
        {
            EmplyeesGridView.DataSource = db.Employees.Select(x => new { Imię = x.FirstName }).Where(x => x.Imię.Contains("a")).ToList();
            EmplyeesGridView.Refresh();
            EmplyeesGridView.Update();
        }
        // A5
        private void buttonNoReportsTo_Click(object sender, EventArgs e)
        {
            EmplyeesGridView.DataSource = db.Employees
                .Select(x => new {Imię = x.FirstName, Nazwisko = x.LastName, Przełożony = x.ReportsTo})
                .Where(x => x.Przełożony.HasValue == false).ToList();
        }
        // A6
        private void buttonProducts_Click(object sender, EventArgs e)
        {
            ProductsGridView.DataSource = db.Products.Select(x => new {Produkt = x.ProductName, Cena = x.UnitPrice})
                .Where(x => x.Cena.Value > 5 && x.Cena.Value < 20).OrderByDescending(x=> x.Cena).ToList();
        }
    }
}
