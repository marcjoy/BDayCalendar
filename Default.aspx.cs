/*Marcus Joyner
ITC 172 SCC- Assignment 1
April 13, 2016
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        GetTimeTillBirthday();
    }

    protected void GetTimeTillBirthday()
    {
        //Object to calculate date
        DateTime birthDay;

        if (Calendar1.SelectedDate <= DateTime.Now)
        {
            birthDay = DateTime.Now;
            ResultLabel.Text = "If today is your birthday...Happy Birthday!!! Otherwise, please choose a date in the future. ";
            
        }
        else
        {
            birthDay = Calendar1.SelectedDate;
            string name = NameTextBox.Text;

        //This calculates the time until your next birthday
        TimeSpan daysRemaining = birthDay.Subtract(DateTime.Now);
        ResultLabel.Text= name + " it is " +
        Math.Abs(daysRemaining.Days).ToString() +
        " days until your next birthday.";
        }

       
    }
}