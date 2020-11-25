using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace CashRegister
{
    public partial class Form1 : Form
    {
        //Global Variables
        const double rideTicketPrice = 1.25;
        const double fastPassPrice = 15.00;
        const double gameTicketPrice = 2.00;
        const double taxRate = 0.13;

        int rideTicketAmount;
        int fastPassAmount;
        int gameTicketAmount;
        double rideTicketTotal;
        double fastPassTotal;
        double gameTicketTotal;

        double subtotal;
        double total;
        double tax;

        double amountTendered;
        double change;

        int orderNumber = 10000;
        double totalRevenue;

        public Form1()
        {
            InitializeComponent();
        }





        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CalculateTotalButton_Click(object sender, EventArgs e)
        {
            errorLabel.Visible = false;

            //Checking for empty entries, placing zeroes
            if (rideTicketAmountBox.Text == "")
            {
                rideTicketAmountBox.Text = "0";
            }

            if (gameTicketAmountBox.Text == "")
            {
                gameTicketAmountBox.Text = "0";
            }

            if (fastPassAmountBox.Text == "")
            {
                fastPassAmountBox.Text = "0";
            }
            //protecting against letter input crash
            try
            {
                rideTicketAmount = Convert.ToInt32(rideTicketAmountBox.Text);
                fastPassAmount = Convert.ToInt32(fastPassAmountBox.Text);
                gameTicketAmount = Convert.ToInt32(gameTicketAmountBox.Text);
            }
            catch
            {
                errorLabel.Visible = true;
            }
            //calculating totals for individual services
            rideTicketTotal = rideTicketPrice * rideTicketAmount;
            fastPassTotal = fastPassPrice * fastPassAmount;
            gameTicketTotal = gameTicketPrice * gameTicketAmount;
            //calculating subtotal
            subtotal = rideTicketTotal + fastPassTotal + gameTicketTotal;
            subTotalLabel.Text = "Sub Total: " + $" {subtotal.ToString("$0.00")}";
            //calculating tax
            tax = subtotal * taxRate;
            taxLabel.Text = "Tax: " + $" {tax.ToString("$0.00")}";
            //calculating total
            total = tax + subtotal;
            totalLabel.Text = "Total: " + $" {total.ToString("$0.00")}";
            totalRevenue += total;
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            //bunch of change stuff
            errorLabel2.Visible = false;
            errorLabel3.Visible = false;
            if (tenderedAmountBox.Text == "")
            {
                tenderedAmountBox.Text = "0";
            }
            try
            {
                amountTendered = Convert.ToDouble(tenderedAmountBox.Text);
            }
            catch
            {
                errorLabel2.Visible = true;
            }

            if (amountTendered >= total)
            {

                change = amountTendered - total;
                changeLabel.Text = "Change: " + $" {change.ToString("$0.00")}";
            }
            else
            {
                errorLabel3.Visible = true;
            }
        

        }

        private void RecieptButton_Click(object sender, EventArgs e)
        {
            //Printing the reciept
            SoundPlayer player = new SoundPlayer(Properties.Resources.printSound);

            recieptTitleLabel.Visible = true;

            player.Play();
            Refresh();
            Thread.Sleep(500);

            recieptOrderNumberLabel.Visible = true;
            recieptOrderNumberLabel.Text = "Order Number " + orderNumber;
            orderNumber++;
            player.Play();
            Refresh();
            Thread.Sleep(500);

            recieptDateLabel.Visible = true;
            player.Play();
            Refresh();
            Thread.Sleep(500);

            recieptRideTicketLabel.Visible = true;
            recieptRideTicketLabel.Text = "Ride Tickets   x" + rideTicketAmount + "   " +$"{rideTicketTotal.ToString("$0.00")}";
            player.Play();
            Refresh();
            Thread.Sleep(500);

            recieptFastPassLabel.Visible = true;
            recieptFastPassLabel.Text = "Fast Pass     x" + fastPassAmount + "   " + $"{fastPassTotal.ToString("$0.00")}";
            player.Play();
            Refresh();
            Thread.Sleep(500);

            recieptGameTicketsLabel.Visible = true;
            recieptGameTicketsLabel.Text = "Game Tickets   x" + gameTicketAmount + "   " + $"{gameTicketTotal.ToString("$0.00")}";
            player.Play();
            Refresh();
            Thread.Sleep(500);

            recieptSubTotalLabel.Visible = true;
            recieptSubTotalLabel.Text = "Sub Total" + "              " + $"{subtotal.ToString("$0.00")}";
            player.Play();
            Refresh();
            Thread.Sleep(500);

            recieptTaxLabel.Visible = true;
            recieptTaxLabel.Text = "Tax" + "                        " + $"{tax.ToString("$0.00")}";
            player.Play();
            Refresh();
            Thread.Sleep(500);

            recieptTotalLabel.Visible = true;
            recieptTotalLabel.Text = "Total" + "                     " + $"{total.ToString("$0.00")}";
            player.Play();
            Refresh();
            Thread.Sleep(500);

            recieptTenderedLabel.Visible = true;
            recieptTenderedLabel.Text = "Tendered" + "               " + $"{amountTendered.ToString("$0.00")}";
            player.Play();
            Refresh();
            Thread.Sleep(500);

            recieptChangeLabel.Visible = true;
            recieptChangeLabel.Text = "Change" + "                 " + $"{change.ToString("$0.00")}";
            player.Play();
            Refresh();
            Thread.Sleep(500);
        }

        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            //Clearing the reciept
            recieptChangeLabel.Visible = false;
            recieptTenderedLabel.Visible = false;
            recieptTotalLabel.Visible = false;
            recieptTaxLabel.Visible = false;
            recieptSubTotalLabel.Visible = false;
            recieptGameTicketsLabel.Visible = false;
            recieptFastPassLabel.Visible = false;
            recieptRideTicketLabel.Visible = false;
            recieptDateLabel.Visible = false;
            recieptOrderNumberLabel.Visible = false;
            recieptTitleLabel.Visible = false;

            //Clearing labels
            changeLabel.Text = "Change: $0.00";
            totalLabel.Text = "Total: $0.00";
            subTotalLabel.Text = "Sub Total: $0.00";
            taxLabel.Text = "Tax: $0.00";

            //Clearing text entry boxes
            rideTicketAmountBox.Text = "";
            fastPassAmountBox.Text = "";
            gameTicketAmountBox.Text = "";
            tenderedAmountBox.Text = "";

            //Clearing Variables
            rideTicketAmount = 0;
            fastPassAmount = 0;
            gameTicketAmount = 0;
            rideTicketTotal = 0;
            fastPassTotal = 0;
            gameTicketTotal = 0;
            amountTendered = 0;

            subtotal = 0;
            total = 0;
            tax = 0;
        }

        private void ManagerEntry_Click(object sender, EventArgs e)
        {

        }
    }
}
