
namespace MorgageCaculatorApp
{
    partial class MortgageCaculatorApp
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
            this.lblHomePrice = new System.Windows.Forms.Label();
            this.txtHomePrice = new System.Windows.Forms.TextBox();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.lblLoaninYears = new System.Windows.Forms.Label();
            this.lblYearlyHoa = new System.Windows.Forms.Label();
            this.lblDownPayment = new System.Windows.Forms.Label();
            this.lblPaymentsPerYear = new System.Windows.Forms.Label();
            this.lblMonthlyIncome = new System.Windows.Forms.Label();
            this.txtMonthlyIncome = new System.Windows.Forms.TextBox();
            this.txtPaymentsPerYear = new System.Windows.Forms.TextBox();
            this.txtDownPayment = new System.Windows.Forms.TextBox();
            this.txtHoaFees = new System.Windows.Forms.TextBox();
            this.txtLoanInYears = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.TotalPayment = new System.Windows.Forms.Button();
            this.lblTotalPayments = new System.Windows.Forms.Label();
            this.EquityOutput = new System.Windows.Forms.Label();
            this.btnEquity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHomePrice
            // 
            this.lblHomePrice.AutoSize = true;
            this.lblHomePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomePrice.Location = new System.Drawing.Point(184, 187);
            this.lblHomePrice.Name = "lblHomePrice";
            this.lblHomePrice.Size = new System.Drawing.Size(192, 37);
            this.lblHomePrice.TabIndex = 0;
            this.lblHomePrice.Text = "Home Price:";
            // 
            // txtHomePrice
            // 
            this.txtHomePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHomePrice.Location = new System.Drawing.Point(592, 180);
            this.txtHomePrice.Name = "txtHomePrice";
            this.txtHomePrice.Size = new System.Drawing.Size(206, 44);
            this.txtHomePrice.TabIndex = 1;
            this.txtHomePrice.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterestRate.Location = new System.Drawing.Point(184, 315);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(206, 37);
            this.lblInterestRate.TabIndex = 2;
            this.lblInterestRate.Text = "Interest Rate:";
            this.lblInterestRate.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblLoaninYears
            // 
            this.lblLoaninYears.AutoSize = true;
            this.lblLoaninYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaninYears.Location = new System.Drawing.Point(855, 315);
            this.lblLoaninYears.Name = "lblLoaninYears";
            this.lblLoaninYears.Size = new System.Drawing.Size(340, 37);
            this.lblLoaninYears.TabIndex = 3;
            this.lblLoaninYears.Text = "A 15 or 30 Year Loan?";
            // 
            // lblYearlyHoa
            // 
            this.lblYearlyHoa.AutoSize = true;
            this.lblYearlyHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearlyHoa.Location = new System.Drawing.Point(184, 598);
            this.lblYearlyHoa.Name = "lblYearlyHoa";
            this.lblYearlyHoa.Size = new System.Drawing.Size(366, 37);
            this.lblYearlyHoa.TabIndex = 4;
            this.lblYearlyHoa.Text = "Yearly Hoa Fees? If any:";
            this.lblYearlyHoa.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblDownPayment
            // 
            this.lblDownPayment.AutoSize = true;
            this.lblDownPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDownPayment.Location = new System.Drawing.Point(863, 183);
            this.lblDownPayment.Name = "lblDownPayment";
            this.lblDownPayment.Size = new System.Drawing.Size(242, 37);
            this.lblDownPayment.TabIndex = 5;
            this.lblDownPayment.Text = "Down Payment:";
            // 
            // lblPaymentsPerYear
            // 
            this.lblPaymentsPerYear.AutoSize = true;
            this.lblPaymentsPerYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentsPerYear.Location = new System.Drawing.Point(184, 441);
            this.lblPaymentsPerYear.Name = "lblPaymentsPerYear";
            this.lblPaymentsPerYear.Size = new System.Drawing.Size(299, 37);
            this.lblPaymentsPerYear.TabIndex = 6;
            this.lblPaymentsPerYear.Text = "Payments per Year:";
            // 
            // lblMonthlyIncome
            // 
            this.lblMonthlyIncome.AutoSize = true;
            this.lblMonthlyIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyIncome.Location = new System.Drawing.Point(863, 444);
            this.lblMonthlyIncome.Name = "lblMonthlyIncome";
            this.lblMonthlyIncome.Size = new System.Drawing.Size(250, 37);
            this.lblMonthlyIncome.TabIndex = 7;
            this.lblMonthlyIncome.Text = "Monthly Income:";
            // 
            // txtMonthlyIncome
            // 
            this.txtMonthlyIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonthlyIncome.Location = new System.Drawing.Point(1269, 441);
            this.txtMonthlyIncome.Name = "txtMonthlyIncome";
            this.txtMonthlyIncome.Size = new System.Drawing.Size(208, 44);
            this.txtMonthlyIncome.TabIndex = 8;
            this.txtMonthlyIncome.TextChanged += new System.EventHandler(this.txtMonthlyIncome_TextChanged);
            // 
            // txtPaymentsPerYear
            // 
            this.txtPaymentsPerYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaymentsPerYear.Location = new System.Drawing.Point(592, 444);
            this.txtPaymentsPerYear.Name = "txtPaymentsPerYear";
            this.txtPaymentsPerYear.Size = new System.Drawing.Size(206, 44);
            this.txtPaymentsPerYear.TabIndex = 9;
            this.txtPaymentsPerYear.TextChanged += new System.EventHandler(this.txtPaymentsPerYear_TextChanged);
            // 
            // txtDownPayment
            // 
            this.txtDownPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDownPayment.Location = new System.Drawing.Point(1269, 184);
            this.txtDownPayment.Name = "txtDownPayment";
            this.txtDownPayment.Size = new System.Drawing.Size(208, 44);
            this.txtDownPayment.TabIndex = 10;
            this.txtDownPayment.TextChanged += new System.EventHandler(this.txtDownPayment_TextChanged);
            // 
            // txtHoaFees
            // 
            this.txtHoaFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoaFees.Location = new System.Drawing.Point(592, 598);
            this.txtHoaFees.Name = "txtHoaFees";
            this.txtHoaFees.Size = new System.Drawing.Size(206, 44);
            this.txtHoaFees.TabIndex = 11;
            this.txtHoaFees.TextChanged += new System.EventHandler(this.txtHoaFees_TextChanged);
            // 
            // txtLoanInYears
            // 
            this.txtLoanInYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoanInYears.Location = new System.Drawing.Point(1269, 308);
            this.txtLoanInYears.Name = "txtLoanInYears";
            this.txtLoanInYears.Size = new System.Drawing.Size(208, 44);
            this.txtLoanInYears.TabIndex = 12;
            this.txtLoanInYears.TextChanged += new System.EventHandler(this.txtLoanInYears_TextChanged);
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInterestRate.Location = new System.Drawing.Point(592, 308);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(206, 44);
            this.txtInterestRate.TabIndex = 13;
            this.txtInterestRate.TextChanged += new System.EventHandler(this.txtInterestRate_TextChanged);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Aqua;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(389, 29);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(868, 42);
            this.lblHeader.TabIndex = 14;
            this.lblHeader.Text = "Caculate Your Future Monthly Mortgage Payments!";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TotalPayment
            // 
            this.TotalPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPayment.Location = new System.Drawing.Point(451, 755);
            this.TotalPayment.Name = "TotalPayment";
            this.TotalPayment.Size = new System.Drawing.Size(365, 79);
            this.TotalPayment.TabIndex = 15;
            this.TotalPayment.Text = "See Monthly Payment!";
            this.TotalPayment.UseVisualStyleBackColor = true;
            this.TotalPayment.Click += new System.EventHandler(this.TotalPayment_Click);
            // 
            // lblTotalPayments
            // 
            this.lblTotalPayments.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTotalPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPayments.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotalPayments.Location = new System.Drawing.Point(453, 837);
            this.lblTotalPayments.Name = "lblTotalPayments";
            this.lblTotalPayments.Size = new System.Drawing.Size(363, 107);
            this.lblTotalPayments.TabIndex = 16;
            this.lblTotalPayments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EquityOutput
            // 
            this.EquityOutput.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.EquityOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EquityOutput.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EquityOutput.Location = new System.Drawing.Point(880, 837);
            this.EquityOutput.Name = "EquityOutput";
            this.EquityOutput.Size = new System.Drawing.Size(354, 107);
            this.EquityOutput.TabIndex = 18;
            this.EquityOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEquity
            // 
            this.btnEquity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquity.Location = new System.Drawing.Point(877, 755);
            this.btnEquity.Name = "btnEquity";
            this.btnEquity.Size = new System.Drawing.Size(357, 79);
            this.btnEquity.TabIndex = 19;
            this.btnEquity.Text = "See Projected Equity";
            this.btnEquity.UseVisualStyleBackColor = true;
            this.btnEquity.Click += new System.EventHandler(this.btnEquity_Click);
            // 
            // MortgageCaculatorApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1626, 1235);
            this.Controls.Add(this.btnEquity);
            this.Controls.Add(this.EquityOutput);
            this.Controls.Add(this.lblTotalPayments);
            this.Controls.Add(this.TotalPayment);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.txtInterestRate);
            this.Controls.Add(this.txtLoanInYears);
            this.Controls.Add(this.txtHoaFees);
            this.Controls.Add(this.txtDownPayment);
            this.Controls.Add(this.txtPaymentsPerYear);
            this.Controls.Add(this.txtMonthlyIncome);
            this.Controls.Add(this.lblMonthlyIncome);
            this.Controls.Add(this.lblPaymentsPerYear);
            this.Controls.Add(this.lblDownPayment);
            this.Controls.Add(this.lblYearlyHoa);
            this.Controls.Add(this.lblLoaninYears);
            this.Controls.Add(this.lblInterestRate);
            this.Controls.Add(this.txtHomePrice);
            this.Controls.Add(this.lblHomePrice);
            this.Name = "MortgageCaculatorApp";
            this.Text = "Mortgage Caculator App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblHomePrice;
        private System.Windows.Forms.TextBox txtHomePrice;
        private System.Windows.Forms.Label lblDownPayment;
        private System.Windows.Forms.TextBox txtDownPayment;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.Label lblLoaninYears;
        private System.Windows.Forms.TextBox txtLoanInYears;
        private System.Windows.Forms.Label lblPaymentsPerYear;
        private System.Windows.Forms.TextBox txtPaymentsPerYear;
        private System.Windows.Forms.Label lblMonthlyIncome;
        private System.Windows.Forms.TextBox txtMonthlyIncome;
        private System.Windows.Forms.Label lblYearlyHoa;
        private System.Windows.Forms.TextBox txtHoaFees;

      
        private System.Windows.Forms.Button TotalPayment;
        private System.Windows.Forms.Label lblTotalPayments; 
        private System.Windows.Forms.Button btnEquity;
        private System.Windows.Forms.Label EquityOutput;
    }
}

