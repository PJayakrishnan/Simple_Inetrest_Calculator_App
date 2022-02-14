using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestApp1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public void HandleOnClick(object sender, EventArgs args)
        {
            double simpleinterest;
            double amount;
            double principle;
            double interest;
            double years;
            principle = Convert.ToDouble(principleAmount.Text);
            interest = Convert.ToDouble(interestRate.Text);
            years = Convert.ToDouble(noOfYears.Text);
            simpleinterest = (principle * years * interest) / 100;
            amount = simpleinterest + principle;
            interestLabel.Text = "Rs. " + simpleinterest;
            amountLabel.Text = "Rs. " + amount;
        }
        public void HandleClearOnClick(object sender,EventArgs args)
        {
            principleAmount.Text = String.Empty;
            interestRate.Text = String.Empty;
            noOfYears.Text = String.Empty;
            interestLabel.Text = String.Empty;
            amountLabel.Text = String.Empty;
        }
    }
}
