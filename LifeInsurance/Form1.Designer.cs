
namespace LifeInsurance
{
  partial class Form1
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.clientAliveProbabilityInput = new System.Windows.Forms.TextBox();
      this.clientAlivePayoutInput = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.accidentPayoutInput = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.accidentProbabilityInput = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.numberOfContractsInput = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.paymentAmountInput = new System.Windows.Forms.TextBox();
      this.PoissonCalc = new System.Windows.Forms.Button();
      this.GaussCalc = new System.Windows.Forms.Button();
      this.GaussInsuranceFee = new System.Windows.Forms.TextBox();
      this.GaussNet = new System.Windows.Forms.TextBox();
      this.GaussSurcharge = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.PoissonInsuranceFee = new System.Windows.Forms.TextBox();
      this.PoissonNet = new System.Windows.Forms.TextBox();
      this.PoissonSurcharge = new System.Windows.Forms.TextBox();
      this.label10 = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.PoissonInsuranceFeeSum = new System.Windows.Forms.TextBox();
      this.PoissonNetSum = new System.Windows.Forms.TextBox();
      this.PoissonSurchargeSum = new System.Windows.Forms.TextBox();
      this.label12 = new System.Windows.Forms.Label();
      this.label13 = new System.Windows.Forms.Label();
      this.label14 = new System.Windows.Forms.Label();
      this.GaussInsuranceFeeSum = new System.Windows.Forms.TextBox();
      this.GaussNetSum = new System.Windows.Forms.TextBox();
      this.GaussSurchargeSum = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 44);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(57, 15);
      this.label1.TabIndex = 0;
      this.label1.Text = "Выплаты";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 83);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(97, 15);
      this.label2.TabIndex = 1;
      this.label2.Text = "Вероятность (%)";
      // 
      // clientAliveProbabilityInput
      // 
      this.clientAliveProbabilityInput.Location = new System.Drawing.Point(115, 80);
      this.clientAliveProbabilityInput.Name = "clientAliveProbabilityInput";
      this.clientAliveProbabilityInput.Size = new System.Drawing.Size(117, 23);
      this.clientAliveProbabilityInput.TabIndex = 3;
      this.clientAliveProbabilityInput.Text = "0.997";
      // 
      // clientAlivePayoutInput
      // 
      this.clientAlivePayoutInput.Location = new System.Drawing.Point(115, 41);
      this.clientAlivePayoutInput.Name = "clientAlivePayoutInput";
      this.clientAlivePayoutInput.Size = new System.Drawing.Size(117, 23);
      this.clientAlivePayoutInput.TabIndex = 2;
      this.clientAlivePayoutInput.Text = "0";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(115, 13);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(71, 15);
      this.label3.TabIndex = 4;
      this.label3.Text = "Клиент жив";
      // 
      // accidentPayoutInput
      // 
      this.accidentPayoutInput.Location = new System.Drawing.Point(253, 41);
      this.accidentPayoutInput.Name = "accidentPayoutInput";
      this.accidentPayoutInput.Size = new System.Drawing.Size(117, 23);
      this.accidentPayoutInput.TabIndex = 5;
      this.accidentPayoutInput.Text = "1";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(253, 13);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(117, 15);
      this.label4.TabIndex = 6;
      this.label4.Text = "Несчастный случай";
      // 
      // accidentProbabilityInput
      // 
      this.accidentProbabilityInput.Location = new System.Drawing.Point(253, 80);
      this.accidentProbabilityInput.Name = "accidentProbabilityInput";
      this.accidentProbabilityInput.Size = new System.Drawing.Size(117, 23);
      this.accidentProbabilityInput.TabIndex = 7;
      this.accidentProbabilityInput.Text = "0.003";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(413, 13);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(133, 15);
      this.label5.TabIndex = 8;
      this.label5.Text = "Количество договоров";
      // 
      // numberOfContractsInput
      // 
      this.numberOfContractsInput.Location = new System.Drawing.Point(413, 41);
      this.numberOfContractsInput.Name = "numberOfContractsInput";
      this.numberOfContractsInput.Size = new System.Drawing.Size(144, 23);
      this.numberOfContractsInput.TabIndex = 9;
      this.numberOfContractsInput.Text = "3000";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(578, 13);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(144, 15);
      this.label6.TabIndex = 10;
      this.label6.Text = "Сумма выплаты за 1 у. е.";
      // 
      // paymentAmountInput
      // 
      this.paymentAmountInput.Location = new System.Drawing.Point(578, 41);
      this.paymentAmountInput.Name = "paymentAmountInput";
      this.paymentAmountInput.Size = new System.Drawing.Size(144, 23);
      this.paymentAmountInput.TabIndex = 11;
      this.paymentAmountInput.Text = "250000";
      // 
      // PoissonCalc
      // 
      this.PoissonCalc.Location = new System.Drawing.Point(145, 131);
      this.PoissonCalc.Name = "PoissonCalc";
      this.PoissonCalc.Size = new System.Drawing.Size(189, 23);
      this.PoissonCalc.TabIndex = 12;
      this.PoissonCalc.Text = "Рассчитать методом Пуассона";
      this.PoissonCalc.UseVisualStyleBackColor = true;
      // 
      // GaussCalc
      // 
      this.GaussCalc.Location = new System.Drawing.Point(476, 131);
      this.GaussCalc.Name = "GaussCalc";
      this.GaussCalc.Size = new System.Drawing.Size(189, 23);
      this.GaussCalc.TabIndex = 13;
      this.GaussCalc.Text = "Рассчитать методом Гаусса";
      this.GaussCalc.UseVisualStyleBackColor = true;
      // 
      // GaussInsuranceFee
      // 
      this.GaussInsuranceFee.Location = new System.Drawing.Point(511, 191);
      this.GaussInsuranceFee.Name = "GaussInsuranceFee";
      this.GaussInsuranceFee.ReadOnly = true;
      this.GaussInsuranceFee.Size = new System.Drawing.Size(117, 23);
      this.GaussInsuranceFee.TabIndex = 20;
      // 
      // GaussNet
      // 
      this.GaussNet.Location = new System.Drawing.Point(511, 218);
      this.GaussNet.Name = "GaussNet";
      this.GaussNet.ReadOnly = true;
      this.GaussNet.Size = new System.Drawing.Size(117, 23);
      this.GaussNet.TabIndex = 21;
      // 
      // GaussSurcharge
      // 
      this.GaussSurcharge.Location = new System.Drawing.Point(511, 247);
      this.GaussSurcharge.Name = "GaussSurcharge";
      this.GaussSurcharge.ReadOnly = true;
      this.GaussSurcharge.Size = new System.Drawing.Size(117, 23);
      this.GaussSurcharge.TabIndex = 22;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(12, 194);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(164, 15);
      this.label7.TabIndex = 17;
      this.label7.Text = "Реальная плата за страховку";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(12, 224);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(86, 15);
      this.label8.TabIndex = 18;
      this.label8.Text = "Нетто-премия";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(12, 253);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(117, 15);
      this.label9.TabIndex = 19;
      this.label9.Text = "Страховая надбавка";
      // 
      // PoissonInsuranceFee
      // 
      this.PoissonInsuranceFee.Location = new System.Drawing.Point(182, 191);
      this.PoissonInsuranceFee.Name = "PoissonInsuranceFee";
      this.PoissonInsuranceFee.ReadOnly = true;
      this.PoissonInsuranceFee.Size = new System.Drawing.Size(117, 23);
      this.PoissonInsuranceFee.TabIndex = 14;
      // 
      // PoissonNet
      // 
      this.PoissonNet.Location = new System.Drawing.Point(182, 221);
      this.PoissonNet.Name = "PoissonNet";
      this.PoissonNet.ReadOnly = true;
      this.PoissonNet.Size = new System.Drawing.Size(117, 23);
      this.PoissonNet.TabIndex = 15;
      // 
      // PoissonSurcharge
      // 
      this.PoissonSurcharge.Location = new System.Drawing.Point(182, 250);
      this.PoissonSurcharge.Name = "PoissonSurcharge";
      this.PoissonSurcharge.ReadOnly = true;
      this.PoissonSurcharge.Size = new System.Drawing.Size(117, 23);
      this.PoissonSurcharge.TabIndex = 16;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(331, 170);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(148, 15);
      this.label10.TabIndex = 23;
      this.label10.Text = "За 1 индивидуальный иск";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(352, 289);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(111, 15);
      this.label11.TabIndex = 24;
      this.label11.Text = "За суммарный иск";
      // 
      // PoissonInsuranceFeeSum
      // 
      this.PoissonInsuranceFeeSum.Location = new System.Drawing.Point(182, 317);
      this.PoissonInsuranceFeeSum.Name = "PoissonInsuranceFeeSum";
      this.PoissonInsuranceFeeSum.ReadOnly = true;
      this.PoissonInsuranceFeeSum.Size = new System.Drawing.Size(117, 23);
      this.PoissonInsuranceFeeSum.TabIndex = 25;
      // 
      // PoissonNetSum
      // 
      this.PoissonNetSum.Location = new System.Drawing.Point(182, 346);
      this.PoissonNetSum.Name = "PoissonNetSum";
      this.PoissonNetSum.ReadOnly = true;
      this.PoissonNetSum.Size = new System.Drawing.Size(117, 23);
      this.PoissonNetSum.TabIndex = 26;
      // 
      // PoissonSurchargeSum
      // 
      this.PoissonSurchargeSum.Location = new System.Drawing.Point(182, 375);
      this.PoissonSurchargeSum.Name = "PoissonSurchargeSum";
      this.PoissonSurchargeSum.ReadOnly = true;
      this.PoissonSurchargeSum.Size = new System.Drawing.Size(117, 23);
      this.PoissonSurchargeSum.TabIndex = 27;
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Location = new System.Drawing.Point(12, 320);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(164, 15);
      this.label12.TabIndex = 28;
      this.label12.Text = "Реальная плата за страховку";
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Location = new System.Drawing.Point(12, 349);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(86, 15);
      this.label13.TabIndex = 29;
      this.label13.Text = "Нетто-премия";
      // 
      // label14
      // 
      this.label14.AutoSize = true;
      this.label14.Location = new System.Drawing.Point(12, 378);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(117, 15);
      this.label14.TabIndex = 30;
      this.label14.Text = "Страховая надбавка";
      // 
      // GaussInsuranceFeeSum
      // 
      this.GaussInsuranceFeeSum.Location = new System.Drawing.Point(511, 317);
      this.GaussInsuranceFeeSum.Name = "GaussInsuranceFeeSum";
      this.GaussInsuranceFeeSum.ReadOnly = true;
      this.GaussInsuranceFeeSum.Size = new System.Drawing.Size(117, 23);
      this.GaussInsuranceFeeSum.TabIndex = 31;
      // 
      // GaussNetSum
      // 
      this.GaussNetSum.Location = new System.Drawing.Point(511, 346);
      this.GaussNetSum.Name = "GaussNetSum";
      this.GaussNetSum.ReadOnly = true;
      this.GaussNetSum.Size = new System.Drawing.Size(117, 23);
      this.GaussNetSum.TabIndex = 32;
      // 
      // GaussSurchargeSum
      // 
      this.GaussSurchargeSum.Location = new System.Drawing.Point(511, 375);
      this.GaussSurchargeSum.Name = "GaussSurchargeSum";
      this.GaussSurchargeSum.ReadOnly = true;
      this.GaussSurchargeSum.Size = new System.Drawing.Size(117, 23);
      this.GaussSurchargeSum.TabIndex = 33;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(744, 450);
      this.Controls.Add(this.GaussSurchargeSum);
      this.Controls.Add(this.GaussNetSum);
      this.Controls.Add(this.GaussInsuranceFeeSum);
      this.Controls.Add(this.label14);
      this.Controls.Add(this.label13);
      this.Controls.Add(this.label12);
      this.Controls.Add(this.PoissonSurchargeSum);
      this.Controls.Add(this.PoissonNetSum);
      this.Controls.Add(this.PoissonInsuranceFeeSum);
      this.Controls.Add(this.label11);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.PoissonSurcharge);
      this.Controls.Add(this.PoissonNet);
      this.Controls.Add(this.PoissonInsuranceFee);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.GaussSurcharge);
      this.Controls.Add(this.GaussNet);
      this.Controls.Add(this.GaussInsuranceFee);
      this.Controls.Add(this.GaussCalc);
      this.Controls.Add(this.PoissonCalc);
      this.Controls.Add(this.paymentAmountInput);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.numberOfContractsInput);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.accidentProbabilityInput);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.accidentPayoutInput);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.clientAlivePayoutInput);
      this.Controls.Add(this.clientAliveProbabilityInput);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Страхование жизни";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox clientAliveProbabilityInput;
    private System.Windows.Forms.TextBox clientAlivePayoutInput;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox accidentPayoutInput;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox accidentProbabilityInput;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox numberOfContractsInput;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox paymentAmountInput;
    private System.Windows.Forms.Button PoissonCalc;
    private System.Windows.Forms.Button GaussCalc;
    private System.Windows.Forms.TextBox GaussInsuranceFee;
    private System.Windows.Forms.TextBox GaussNet;
    private System.Windows.Forms.TextBox GaussSurcharge;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.TextBox PoissonInsuranceFee;
    private System.Windows.Forms.TextBox PoissonNet;
    private System.Windows.Forms.TextBox PoissonSurcharge;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.TextBox PoissonInsuranceFeeSum;
    private System.Windows.Forms.TextBox PoissonNetSum;
    private System.Windows.Forms.TextBox PoissonSurchargeSum;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.TextBox GaussInsuranceFeeSum;
    private System.Windows.Forms.TextBox GaussNetSum;
    private System.Windows.Forms.TextBox GaussSurchargeSum;
  }
}

