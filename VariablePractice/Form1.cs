using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VariablePractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hockeyButton_Click(object sender, EventArgs e)
        {
            string playerName = "Wayne Gretzky";
            int playerID = 99;

            outputLabel.Text = $"{playerName} is number {playerID}";


        }

        private void payButton_Click(object sender, EventArgs e)
        {
            double hours = 25;
            double pay = 18.75;
            double earned = pay * hours;

            outputLabel.Text = $"{hours} hours at ${pay} per hour equals ${earned} ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double radius = 15;
            double pi = 3.14159265358979;
            double area = radius * radius * pi;

            outputLabel.Text = $"The area of a circle with a radius of {radius}cm is {area} cm^2";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double length = 8.5;
            double width = 6;
            double costPerMeter = 19.95;
            double area = length * width;
            double totalCost = costPerMeter * area;

            outputLabel.Text= $"The area of a room with dimensions {length}m x {width}m is {area}m^2\n\nThe cost to carpet this area at {costPerMeter} per square meter is {totalCost}";

        }

        private void carpetButton_Click(object sender, EventArgs e)
        {
            double bill = 12.49;
            double tax = 0.13 * bill;
            double total = bill * (tax + 1);
            double tendered = 20;
            double change = tendered - total;

            outputLabel.Text = $"Bill of Sale\n\nShirt: {bill}\n\nTax: {tax}\nTotal: {total}\n\nTendered: {tendered}\nChange: {change}";
        }
    }
}
