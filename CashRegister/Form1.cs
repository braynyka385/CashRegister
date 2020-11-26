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
        double rideTicketPrice = 1.25;
        double fastPassPrice = 15.00;
        double gameTicketPrice = 2.00;
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
            //Producing login screen
            //invalidCredentialsLabel.Visible = false;
            passwordBox.Visible = true;
            passwordLabel.Visible = true;
            usernameBox.Visible = true;
            usernameLabel.Visible = true;
            pinBox.Visible = true;
            pinLabel.Visible = true;
            loginButton.Visible = true;
            returnToTerminal.Visible = true;
            screenCover.Visible = true;

            //Removing reciept
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
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //Declaring username, password, PIN
            string username = "Karen";
            string password = "KareBear123";
            int pin = 4321;

            bool usernameCorrect = false;
            bool passwordCorrect = false;
            bool pinCorrect = false;

            pinErrorLabel.Visible = false;
            invalidCredentialsLabel.Visible = false;

            if (usernameBox.Text == username)
            {
                usernameCorrect = true;
            }
            else
            {
                invalidCredentialsLabel.Visible = true;
                invalidCredentialsLabel.BringToFront();
            }

            if (passwordBox.Text == password)
            {
                passwordCorrect = true;
            }
            else
            {
                invalidCredentialsLabel.Visible = true;
                invalidCredentialsLabel.BringToFront();
            }
            //Avoiding crash from letter in PIN box
            try
            {
                if (Convert.ToInt32(pinBox.Text) == pin)
                {
                    pinCorrect = true;
                }
                else
                {
                    invalidCredentialsLabel.Visible = true;
                    invalidCredentialsLabel.BringToFront();
                }
            }
            catch
            {
                pinErrorLabel.Visible = true;
                pinErrorLabel.BringToFront();
            }


            if (usernameCorrect == true && passwordCorrect == true && pinCorrect == true)
            {
                //hiding login screen
                passwordBox.Visible = false;
                passwordLabel.Visible = false;
                usernameBox.Visible = false;
                usernameLabel.Visible = false;
                pinBox.Visible = false;
                pinLabel.Visible = false;
                loginButton.Visible = false;

                sessionRevenueLabel.Text = "Revenue this session: " + $"{totalRevenue.ToString("$0.00")}";
                sessionRevenueLabel.Visible = true;
                sessionRevenueLabel.BringToFront();
                ridePriceBox.Visible = true;
                ridePriceBox.BringToFront();
                ridePriceLabel.Visible = true;
                ridePriceLabel.BringToFront();
                gamePriceBox.Visible = true;
                gamePriceBox.BringToFront();
                gamePriceLabel.Visible = true;
                gamePriceLabel.BringToFront();
                fastPassPriceBox.Visible = true;
                fastPassPriceBox.BringToFront();
                fastPassPriceLabel.Visible = true;
                fastPassPriceLabel.BringToFront();
                priceChangeButton.Visible = true;
                priceChangeButton.BringToFront();
            }
        }

        private void ReturnToTerminal_Click(object sender, EventArgs e)
        {
            //Clearing credential boxes
            usernameBox.Text = "";
            passwordBox.Text = "";
            pinBox.Text = "";

            //Clearing everythng else
            passwordBox.Visible = false;
            passwordLabel.Visible = false;
            usernameBox.Visible = false;
            usernameLabel.Visible = false;
            pinBox.Visible = false;
            pinLabel.Visible = false;
            loginButton.Visible = false;
            sessionRevenueLabel.Visible = false;
            returnToTerminal.Visible = false;
            screenCover.Visible = false;
            ridePriceBox.Visible = false;
            ridePriceLabel.Visible = false;
            gamePriceBox.Visible = false;
            gamePriceLabel.Visible = false;
            fastPassPriceBox.Visible = false;
            fastPassPriceLabel.Visible = false;
            priceChangeButton.Visible = false;
            priceChangeErrorLabel.Visible = true;
        }

        private void PriceChangeButton_Click(object sender, EventArgs e)
        {
            priceChangeErrorLabel.Visible = false;
            try
            {
                rideTicketPrice = Convert.ToInt32(ridePriceBox);
                gameTicketPrice = Convert.ToInt32(gamePriceBox);
                fastPassPrice = Convert.ToInt32(fastPassPriceBox);
            }
            catch
            {
                priceChangeErrorLabel.Visible = true;
                priceChangeErrorLabel.BringToFront();
            }
        }
    }
}
