namespace CashRegister
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rideTicketLabel = new System.Windows.Forms.Label();
            this.fastPassLabel = new System.Windows.Forms.Label();
            this.gameTicketLabel = new System.Windows.Forms.Label();
            this.rideTicketAmountBox = new System.Windows.Forms.TextBox();
            this.fastPassAmountBox = new System.Windows.Forms.TextBox();
            this.gameTicketAmountBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.calculateTotalButton = new System.Windows.Forms.Button();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.managerEntry = new System.Windows.Forms.Button();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.tenderedAmountBox = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.recieptButton = new System.Windows.Forms.Button();
            this.recieptBackground = new System.Windows.Forms.Label();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.recieptTitleLabel = new System.Windows.Forms.Label();
            this.recieptOrderNumberLabel = new System.Windows.Forms.Label();
            this.recieptDateLabel = new System.Windows.Forms.Label();
            this.recieptRideTicketLabel = new System.Windows.Forms.Label();
            this.recieptFastPassLabel = new System.Windows.Forms.Label();
            this.recieptGameTicketsLabel = new System.Windows.Forms.Label();
            this.recieptSubTotalLabel = new System.Windows.Forms.Label();
            this.recieptTaxLabel = new System.Windows.Forms.Label();
            this.recieptTotalLabel = new System.Windows.Forms.Label();
            this.recieptTenderedLabel = new System.Windows.Forms.Label();
            this.recieptChangeLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.errorLabel2 = new System.Windows.Forms.Label();
            this.errorLabel3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rideTicketLabel
            // 
            this.rideTicketLabel.AutoSize = true;
            this.rideTicketLabel.Font = new System.Drawing.Font("NewsGoth XCn BT", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rideTicketLabel.Location = new System.Drawing.Point(37, 81);
            this.rideTicketLabel.Name = "rideTicketLabel";
            this.rideTicketLabel.Size = new System.Drawing.Size(90, 26);
            this.rideTicketLabel.TabIndex = 0;
            this.rideTicketLabel.Text = "Ride Tickets:";
            // 
            // fastPassLabel
            // 
            this.fastPassLabel.AutoSize = true;
            this.fastPassLabel.Font = new System.Drawing.Font("NewsGoth XCn BT", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fastPassLabel.Location = new System.Drawing.Point(36, 107);
            this.fastPassLabel.Name = "fastPassLabel";
            this.fastPassLabel.Size = new System.Drawing.Size(91, 26);
            this.fastPassLabel.TabIndex = 1;
            this.fastPassLabel.Text = "Fast Passes:";
            // 
            // gameTicketLabel
            // 
            this.gameTicketLabel.AutoSize = true;
            this.gameTicketLabel.Font = new System.Drawing.Font("NewsGoth XCn BT", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTicketLabel.Location = new System.Drawing.Point(28, 133);
            this.gameTicketLabel.Name = "gameTicketLabel";
            this.gameTicketLabel.Size = new System.Drawing.Size(99, 26);
            this.gameTicketLabel.TabIndex = 2;
            this.gameTicketLabel.Text = "Game Tickets:";
            // 
            // rideTicketAmountBox
            // 
            this.rideTicketAmountBox.Location = new System.Drawing.Point(133, 87);
            this.rideTicketAmountBox.Name = "rideTicketAmountBox";
            this.rideTicketAmountBox.Size = new System.Drawing.Size(100, 20);
            this.rideTicketAmountBox.TabIndex = 3;
            // 
            // fastPassAmountBox
            // 
            this.fastPassAmountBox.Location = new System.Drawing.Point(133, 113);
            this.fastPassAmountBox.Name = "fastPassAmountBox";
            this.fastPassAmountBox.Size = new System.Drawing.Size(100, 20);
            this.fastPassAmountBox.TabIndex = 4;
            // 
            // gameTicketAmountBox
            // 
            this.gameTicketAmountBox.Location = new System.Drawing.Point(133, 139);
            this.gameTicketAmountBox.Name = "gameTicketAmountBox";
            this.gameTicketAmountBox.Size = new System.Drawing.Size(100, 20);
            this.gameTicketAmountBox.TabIndex = 5;
            this.gameTicketAmountBox.TextChanged += new System.EventHandler(this.GameTicketAmount_TextChanged);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Onyx BT", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(41, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(168, 50);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.Text = "Theme Park";
            // 
            // calculateTotalButton
            // 
            this.calculateTotalButton.Font = new System.Drawing.Font("NewsGoth XCn BT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateTotalButton.Location = new System.Drawing.Point(18, 174);
            this.calculateTotalButton.Name = "calculateTotalButton";
            this.calculateTotalButton.Size = new System.Drawing.Size(191, 32);
            this.calculateTotalButton.TabIndex = 7;
            this.calculateTotalButton.Text = "Calculate Total";
            this.calculateTotalButton.UseVisualStyleBackColor = true;
            this.calculateTotalButton.Click += new System.EventHandler(this.CalculateTotalButton_Click);
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.AutoSize = true;
            this.subTotalLabel.Font = new System.Drawing.Font("NewsGoth XCn BT", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalLabel.Location = new System.Drawing.Point(13, 219);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(114, 26);
            this.subTotalLabel.TabIndex = 8;
            this.subTotalLabel.Text = "Sub Total: $0.00";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("NewsGoth XCn BT", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(40, 271);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(87, 26);
            this.totalLabel.TabIndex = 9;
            this.totalLabel.Text = "Total: $0.00";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("NewsGoth XCn BT", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(51, 245);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(76, 26);
            this.taxLabel.TabIndex = 10;
            this.taxLabel.Text = "Tax: $0.00";
            // 
            // managerEntry
            // 
            this.managerEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerEntry.Location = new System.Drawing.Point(463, 439);
            this.managerEntry.Name = "managerEntry";
            this.managerEntry.Size = new System.Drawing.Size(42, 42);
            this.managerEntry.TabIndex = 11;
            this.managerEntry.Text = "🔒";
            this.managerEntry.UseVisualStyleBackColor = true;
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Font = new System.Drawing.Font("NewsGoth XCn BT", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.Location = new System.Drawing.Point(51, 320);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(76, 26);
            this.tenderedLabel.TabIndex = 12;
            this.tenderedLabel.Text = "Tendered: ";
            // 
            // tenderedAmountBox
            // 
            this.tenderedAmountBox.Location = new System.Drawing.Point(133, 326);
            this.tenderedAmountBox.Name = "tenderedAmountBox";
            this.tenderedAmountBox.Size = new System.Drawing.Size(100, 20);
            this.tenderedAmountBox.TabIndex = 13;
            // 
            // changeButton
            // 
            this.changeButton.Font = new System.Drawing.Font("NewsGoth XCn BT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.Location = new System.Drawing.Point(18, 352);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(191, 32);
            this.changeButton.TabIndex = 14;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("NewsGoth XCn BT", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(25, 397);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(102, 26);
            this.changeLabel.TabIndex = 15;
            this.changeLabel.Text = "Change: $0.00";
            // 
            // recieptButton
            // 
            this.recieptButton.Font = new System.Drawing.Font("NewsGoth XCn BT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recieptButton.Location = new System.Drawing.Point(18, 426);
            this.recieptButton.Name = "recieptButton";
            this.recieptButton.Size = new System.Drawing.Size(191, 32);
            this.recieptButton.TabIndex = 16;
            this.recieptButton.Text = "Print Reciept";
            this.recieptButton.UseVisualStyleBackColor = true;
            this.recieptButton.Click += new System.EventHandler(this.RecieptButton_Click);
            // 
            // recieptBackground
            // 
            this.recieptBackground.BackColor = System.Drawing.Color.Gainsboro;
            this.recieptBackground.Font = new System.Drawing.Font("NewsGoth XCn BT", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recieptBackground.Location = new System.Drawing.Point(263, 9);
            this.recieptBackground.Name = "recieptBackground";
            this.recieptBackground.Size = new System.Drawing.Size(242, 414);
            this.recieptBackground.TabIndex = 17;
            // 
            // newOrderButton
            // 
            this.newOrderButton.Font = new System.Drawing.Font("NewsGoth XCn BT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrderButton.Location = new System.Drawing.Point(268, 439);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(191, 32);
            this.newOrderButton.TabIndex = 18;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = true;
            this.newOrderButton.Click += new System.EventHandler(this.NewOrderButton_Click);
            // 
            // recieptTitleLabel
            // 
            this.recieptTitleLabel.AutoSize = true;
            this.recieptTitleLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.recieptTitleLabel.Font = new System.Drawing.Font("Onyx BT", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recieptTitleLabel.Location = new System.Drawing.Point(273, 9);
            this.recieptTitleLabel.Name = "recieptTitleLabel";
            this.recieptTitleLabel.Size = new System.Drawing.Size(222, 50);
            this.recieptTitleLabel.TabIndex = 19;
            this.recieptTitleLabel.Text = "Theme Park INC.";
            this.recieptTitleLabel.Visible = false;
            // 
            // recieptOrderNumberLabel
            // 
            this.recieptOrderNumberLabel.AutoSize = true;
            this.recieptOrderNumberLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.recieptOrderNumberLabel.Font = new System.Drawing.Font("NewsGoth XCn BT", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recieptOrderNumberLabel.Location = new System.Drawing.Point(277, 69);
            this.recieptOrderNumberLabel.Name = "recieptOrderNumberLabel";
            this.recieptOrderNumberLabel.Size = new System.Drawing.Size(143, 26);
            this.recieptOrderNumberLabel.TabIndex = 20;
            this.recieptOrderNumberLabel.Text = "Order Number 10000";
            this.recieptOrderNumberLabel.Visible = false;
            // 
            // recieptDateLabel
            // 
            this.recieptDateLabel.AutoSize = true;
            this.recieptDateLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.recieptDateLabel.Font = new System.Drawing.Font("NewsGoth XCn BT", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recieptDateLabel.Location = new System.Drawing.Point(277, 95);
            this.recieptDateLabel.Name = "recieptDateLabel";
            this.recieptDateLabel.Size = new System.Drawing.Size(101, 26);
            this.recieptDateLabel.TabIndex = 21;
            this.recieptDateLabel.Text = "June 25, 2116";
            this.recieptDateLabel.Visible = false;
            // 
            // recieptRideTicketLabel
            // 
            this.recieptRideTicketLabel.AutoSize = true;
            this.recieptRideTicketLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.recieptRideTicketLabel.Font = new System.Drawing.Font("NewsGoth XCn BT", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recieptRideTicketLabel.Location = new System.Drawing.Point(277, 154);
            this.recieptRideTicketLabel.Name = "recieptRideTicketLabel";
            this.recieptRideTicketLabel.Size = new System.Drawing.Size(160, 26);
            this.recieptRideTicketLabel.TabIndex = 22;
            this.recieptRideTicketLabel.Text = "Ride Tickets   x0   $1.25";
            this.recieptRideTicketLabel.Visible = false;
            // 
            // recieptFastPassLabel
            // 
            this.recieptFastPassLabel.AutoSize = true;
            this.recieptFastPassLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.recieptFastPassLabel.Font = new System.Drawing.Font("NewsGoth XCn BT", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recieptFastPassLabel.Location = new System.Drawing.Point(282, 180);
            this.recieptFastPassLabel.Name = "recieptFastPassLabel";
            this.recieptFastPassLabel.Size = new System.Drawing.Size(155, 26);
            this.recieptFastPassLabel.TabIndex = 23;
            this.recieptFastPassLabel.Text = "Fast Pass     x0 $15.00";
            this.recieptFastPassLabel.Visible = false;
            // 
            // recieptGameTicketsLabel
            // 
            this.recieptGameTicketsLabel.AutoSize = true;
            this.recieptGameTicketsLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.recieptGameTicketsLabel.Font = new System.Drawing.Font("NewsGoth XCn BT", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recieptGameTicketsLabel.Location = new System.Drawing.Point(268, 206);
            this.recieptGameTicketsLabel.Name = "recieptGameTicketsLabel";
            this.recieptGameTicketsLabel.Size = new System.Drawing.Size(169, 26);
            this.recieptGameTicketsLabel.TabIndex = 24;
            this.recieptGameTicketsLabel.Text = "Game Tickets   x0   $2.00";
            this.recieptGameTicketsLabel.Visible = false;
            // 
            // recieptSubTotalLabel
            // 
            this.recieptSubTotalLabel.AutoSize = true;
            this.recieptSubTotalLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.recieptSubTotalLabel.Font = new System.Drawing.Font("NewsGoth XCn BT", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recieptSubTotalLabel.Location = new System.Drawing.Point(275, 256);
            this.recieptSubTotalLabel.Name = "recieptSubTotalLabel";
            this.recieptSubTotalLabel.Size = new System.Drawing.Size(162, 26);
            this.recieptSubTotalLabel.TabIndex = 25;
            this.recieptSubTotalLabel.Text = "Sub Total              $0.00";
            this.recieptSubTotalLabel.Visible = false;
            // 
            // recieptTaxLabel
            // 
            this.recieptTaxLabel.AutoSize = true;
            this.recieptTaxLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.recieptTaxLabel.Font = new System.Drawing.Font("NewsGoth XCn BT", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recieptTaxLabel.Location = new System.Drawing.Point(273, 282);
            this.recieptTaxLabel.Name = "recieptTaxLabel";
            this.recieptTaxLabel.Size = new System.Drawing.Size(164, 26);
            this.recieptTaxLabel.TabIndex = 26;
            this.recieptTaxLabel.Text = "Tax                        $0.00";
            this.recieptTaxLabel.Visible = false;
            // 
            // recieptTotalLabel
            // 
            this.recieptTotalLabel.AutoSize = true;
            this.recieptTotalLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.recieptTotalLabel.Font = new System.Drawing.Font("NewsGoth XCn BT", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recieptTotalLabel.Location = new System.Drawing.Point(274, 308);
            this.recieptTotalLabel.Name = "recieptTotalLabel";
            this.recieptTotalLabel.Size = new System.Drawing.Size(163, 26);
            this.recieptTotalLabel.TabIndex = 27;
            this.recieptTotalLabel.Text = "Total                     $0.00";
            this.recieptTotalLabel.Visible = false;
            // 
            // recieptTenderedLabel
            // 
            this.recieptTenderedLabel.AutoSize = true;
            this.recieptTenderedLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.recieptTenderedLabel.Font = new System.Drawing.Font("NewsGoth XCn BT", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recieptTenderedLabel.Location = new System.Drawing.Point(273, 352);
            this.recieptTenderedLabel.Name = "recieptTenderedLabel";
            this.recieptTenderedLabel.Size = new System.Drawing.Size(164, 26);
            this.recieptTenderedLabel.TabIndex = 28;
            this.recieptTenderedLabel.Text = "Tendered               $0.00";
            this.recieptTenderedLabel.Visible = false;
            // 
            // recieptChangeLabel
            // 
            this.recieptChangeLabel.AutoSize = true;
            this.recieptChangeLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.recieptChangeLabel.Font = new System.Drawing.Font("NewsGoth XCn BT", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recieptChangeLabel.Location = new System.Drawing.Point(275, 378);
            this.recieptChangeLabel.Name = "recieptChangeLabel";
            this.recieptChangeLabel.Size = new System.Drawing.Size(162, 26);
            this.recieptChangeLabel.TabIndex = 29;
            this.recieptChangeLabel.Text = "Change                 $0.00";
            this.recieptChangeLabel.Visible = false;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(30, 159);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(208, 13);
            this.errorLabel.TabIndex = 30;
            this.errorLabel.Text = "Error: Entered characters must be numbers";
            this.errorLabel.Visible = false;
            // 
            // errorLabel2
            // 
            this.errorLabel2.AutoSize = true;
            this.errorLabel2.Location = new System.Drawing.Point(49, 307);
            this.errorLabel2.Name = "errorLabel2";
            this.errorLabel2.Size = new System.Drawing.Size(208, 13);
            this.errorLabel2.TabIndex = 31;
            this.errorLabel2.Text = "Error: Entered characters must be numbers";
            this.errorLabel2.Visible = false;
            // 
            // errorLabel3
            // 
            this.errorLabel3.AutoSize = true;
            this.errorLabel3.Location = new System.Drawing.Point(133, 295);
            this.errorLabel3.Name = "errorLabel3";
            this.errorLabel3.Size = new System.Drawing.Size(106, 13);
            this.errorLabel3.TabIndex = 32;
            this.errorLabel3.Text = "Not enough Change!";
            this.errorLabel3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 493);
            this.Controls.Add(this.errorLabel3);
            this.Controls.Add(this.errorLabel2);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.recieptChangeLabel);
            this.Controls.Add(this.recieptTenderedLabel);
            this.Controls.Add(this.recieptTotalLabel);
            this.Controls.Add(this.recieptTaxLabel);
            this.Controls.Add(this.recieptSubTotalLabel);
            this.Controls.Add(this.recieptGameTicketsLabel);
            this.Controls.Add(this.recieptFastPassLabel);
            this.Controls.Add(this.recieptRideTicketLabel);
            this.Controls.Add(this.recieptDateLabel);
            this.Controls.Add(this.recieptOrderNumberLabel);
            this.Controls.Add(this.recieptTitleLabel);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.recieptBackground);
            this.Controls.Add(this.recieptButton);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.tenderedAmountBox);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.managerEntry);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.subTotalLabel);
            this.Controls.Add(this.calculateTotalButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.gameTicketAmountBox);
            this.Controls.Add(this.fastPassAmountBox);
            this.Controls.Add(this.rideTicketAmountBox);
            this.Controls.Add(this.gameTicketLabel);
            this.Controls.Add(this.fastPassLabel);
            this.Controls.Add(this.rideTicketLabel);
            this.Name = "Form1";
            this.Text = "Theme Park Terminal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rideTicketLabel;
        private System.Windows.Forms.Label fastPassLabel;
        private System.Windows.Forms.Label gameTicketLabel;
        private System.Windows.Forms.TextBox rideTicketAmountBox;
        private System.Windows.Forms.TextBox fastPassAmountBox;
        private System.Windows.Forms.TextBox gameTicketAmountBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button calculateTotalButton;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Button managerEntry;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.TextBox tenderedAmountBox;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button recieptButton;
        private System.Windows.Forms.Label recieptBackground;
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Label recieptTitleLabel;
        private System.Windows.Forms.Label recieptOrderNumberLabel;
        private System.Windows.Forms.Label recieptDateLabel;
        private System.Windows.Forms.Label recieptRideTicketLabel;
        private System.Windows.Forms.Label recieptFastPassLabel;
        private System.Windows.Forms.Label recieptGameTicketsLabel;
        private System.Windows.Forms.Label recieptSubTotalLabel;
        private System.Windows.Forms.Label recieptTaxLabel;
        private System.Windows.Forms.Label recieptTotalLabel;
        private System.Windows.Forms.Label recieptTenderedLabel;
        private System.Windows.Forms.Label recieptChangeLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label errorLabel2;
        private System.Windows.Forms.Label errorLabel3;
    }
}

