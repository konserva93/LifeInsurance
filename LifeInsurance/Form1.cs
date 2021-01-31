using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeInsurance
{
  public partial class Form1 : Form
  {
    private Dictionary<double, double> PoissonQuantiles = new Dictionary<double, double> {
      { 0.7, 2 },
      { 0.8, 2 },
      { 0.9, 3 },
      { 1, 3 },
      { 2, 5 },
      { 3, 5 },
      { 4, 8 },
      { 5, 9 },
      { 6, 10 },
      { 7, 12 },
      { 8, 13 },
      { 9, 14 },
      { 10, 15 }
    };
    public Form1()
    {
      InitializeComponent();
    }

    private void PoissonCalc_Click(object sender, EventArgs e)
    {
      try
      {
        var clientAlivePayout = GetDouble(clientAlivePayoutInput.Text);
        var accidentPayout = GetDouble(accidentPayoutInput.Text);

        var clientAliveProbability = GetDouble(clientAliveProbabilityInput.Text);
        var accidentProbability = GetDouble(accidentProbabilityInput.Text);

        var N = GetDouble(numberOfContractsInput.Text);
        var paymentAmount = GetDouble(paymentAmountInput.Text);

        var poissonMultiplier = Math.Round(N * accidentProbability, 1);
        var quantile = PoissonQuantiles[poissonMultiplier]; // Квантиль для вероятности 95%

        var p = Math.Round(quantile / N, 4) * paymentAmount; // Плата за страховку
        var p0 = Math.Round(clientAliveProbability * clientAlivePayout + accidentProbability * accidentPayout, 4) * paymentAmount; // Нетто-премия

        PoissonInsuranceFee.Text = p.ToString();
        PoissonNet.Text = p0.ToString();
        PoissonSurcharge.Text = (p - p0).ToString();

        PoissonInsuranceFeeSum.Text = (p * N).ToString();
        PoissonNetSum.Text = (p0 * N).ToString();
        PoissonSurchargeSum.Text = ((p - p0) * N).ToString();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Exception");
      }
    }

    private void GaussCalc_Click(object sender, EventArgs e)
    {
      try
      {
        double GaussQuantile = 1.645; // 5%

        var clientAlivePayout = GetDouble(clientAlivePayoutInput.Text);
        var accidentPayout = GetDouble(accidentPayoutInput.Text);

        var clientAliveProbability = GetDouble(clientAliveProbabilityInput.Text);
        var accidentProbability = GetDouble(accidentProbabilityInput.Text);

        var N = GetDouble(numberOfContractsInput.Text);
        var paymentAmount = GetDouble(paymentAmountInput.Text);

        var EX = (clientAliveProbability * clientAlivePayout) + (accidentProbability * accidentPayout);
        var VarX = (clientAliveProbability * clientAlivePayout * clientAlivePayout + accidentProbability * accidentPayout * accidentPayout) - (EX * EX);
        var ES = N * EX;
        var VarS = N * VarX;

        var U = Math.Sqrt(VarS) * GaussQuantile + ES;

        var p = Math.Round(paymentAmount * U / N);
        var p0 = Math.Round(paymentAmount * EX);

        GaussInsuranceFee.Text = p.ToString();
        GaussNet.Text = p0.ToString();
        GaussSurcharge.Text = (p - p0).ToString();

        GaussInsuranceFeeSum.Text = (p * N).ToString();
        GaussNetSum.Text = (p0 * N).ToString();
        GaussSurchargeSum.Text = ((p - p0) * N).ToString();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Exception");
      }
    }

    private void GaussCalcGroups_Click(object sender, EventArgs e)
    {
      try
      {
        double GaussQuantile = GetDouble(quantileInput.Text);

        var group1ClientAlivePayout = GetDouble(group1ClientAlivePayoutInput.Text);
        var group1NaturalPayout = GetDouble(group1NaturalPayoutInput.Text);
        var group1AccidentPayout = GetDouble(group1AccidentPayoutInput.Text);

        var group1ClientAliveProbability = GetDouble(group1ClientAliveProbabilityInput.Text);
        var group1NaturalProbability = GetDouble(group1NaturalProbabilityInput.Text);
        var group1AccidentProbability = GetDouble(group1AccidentProbabilityInput.Text);

        var N1 = GetDouble(group1NumberOfContractsInput.Text);
        var paymentAmount1 = GetDouble(group1PaymentAmountInput.Text);

        var group2ClientAlivePayout = GetDouble(group2ClientAlivePayoutInput.Text);
        var group2NaturalPayout = GetDouble(group2NaturalPayoutInput.Text);
        var group2AccidentPayout = GetDouble(group2AccidentPayoutInput.Text);

        var group2ClientAliveProbability = GetDouble(group2ClientAliveProbabilityInput.Text);
        var group2NaturalProbability = GetDouble(group2NaturalProbabilityInput.Text);
        var group2AccidentProbability = GetDouble(group2AccidentProbabilityInput.Text);

        var N2 = GetDouble(group2NumberOfContractsInput.Text);
        var paymentAmount2 = GetDouble(group2PaymentAmountInput.Text);

        var EX1 = Math.Round((group1ClientAlivePayout * group1ClientAliveProbability) + (group1NaturalPayout * group1NaturalProbability) + (group1AccidentPayout * group1AccidentProbability), 4);
        var VarX1 = Math.Round((group1ClientAlivePayout * group1ClientAlivePayout * group1ClientAliveProbability) +
          (group1NaturalPayout * group1NaturalPayout * group1NaturalProbability) +
          (group1AccidentPayout * group1AccidentPayout * group1AccidentProbability) - (EX1 * EX1), 4);

        var EX2 = Math.Round((group2ClientAlivePayout * group2ClientAliveProbability) + (group2NaturalPayout * group2NaturalProbability) + (group2AccidentPayout * group2AccidentProbability), 4);
        var VarX2 = Math.Round((group2ClientAlivePayout * group2ClientAlivePayout * group2ClientAliveProbability) +
          (group2NaturalPayout * group2NaturalPayout * group2NaturalProbability) +
          (group2AccidentPayout * group2AccidentPayout * group2AccidentProbability) - (EX2 * EX2), 4);

        var ES = Math.Round(N1 * EX1 + N2 * EX2, 4);
        var VarS = Math.Round(N1 * VarX1 + N2 * VarX2, 4);

        var RelativeSurcharge = Math.Round((GaussQuantile * Math.Sqrt(VarS)) / ES, 4);

        var p1 = EX1 * (1 + RelativeSurcharge);
        var p2 = EX2 * (1 + RelativeSurcharge);

        group1AverageRisk.Text = EX1.ToString();
        group1Dispersion.Text = VarX1.ToString();
        group1InsuranceFee.Text = Math.Round(p1 * paymentAmount1).ToString();
        group1Net.Text = Math.Round(EX1 * paymentAmount1).ToString();

        group2AverageRisk.Text = EX2.ToString();
        group2Dispersion.Text = VarX2.ToString();
        group2InsuranceFee.Text = Math.Round(p2 * paymentAmount2).ToString();
        group2Net.Text = Math.Round(EX2 * paymentAmount2).ToString();

        averageLoss.Text = ES.ToString();
        dispersionSum.Text = VarS.ToString();
        relativeSurcharge.Text = RelativeSurcharge.ToString();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Exception");
      }
    }

    private double GetDouble(string text)
    {
      try
      {
        return double.Parse(text.Replace('.', ','));
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }
  }
}
