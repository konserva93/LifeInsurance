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
      var clientAlivePayout = double.Parse(clientAlivePayoutInput.Text);
      var accidentPayout = double.Parse(accidentPayoutInput.Text);

      var clientAliveProbability = double.Parse(clientAliveProbabilityInput.Text);
      var accidentProbability = double.Parse(accidentProbabilityInput.Text);

      var N = double.Parse(numberOfContractsInput.Text);
      var paymentAmount = double.Parse(paymentAmountInput.Text);

      var poissonMultiplier = Math.Round(N * accidentProbability, 1);
      var quantile = PoissonQuantiles[poissonMultiplier]; // Квантиль для вероятности 95%

      var p = Math.Round(quantile / N, 4) * paymentAmount; // Плата за страховку
      var p0 = Math.Round(clientAliveProbability * clientAlivePayout + accidentProbability * accidentPayout, 4) * paymentAmount; // Нетто-премия

      PoissonInsuranceFee.Text = p.ToString();
      PoissonNet.Text = p0.ToString();
      PoissonSurcharge.Text = (p-p0).ToString();

      PoissonInsuranceFeeSum.Text = (p * N).ToString();
      PoissonNetSum.Text = (p0 * N).ToString();
      PoissonSurchargeSum.Text = ((p - p0) * N).ToString();
    }

    private void GaussCalc_Click(object sender, EventArgs e)
    {
      double GaussQuantile = 1.645; // 5%
      var clientAlivePayout = double.Parse(clientAlivePayoutInput.Text);
      var accidentPayout = double.Parse(accidentPayoutInput.Text);

      var clientAliveProbability = double.Parse(clientAliveProbabilityInput.Text);
      var accidentProbability = double.Parse(accidentProbabilityInput.Text);

      var N = double.Parse(numberOfContractsInput.Text);
      var paymentAmount = double.Parse(paymentAmountInput.Text);

      var EX = clientAliveProbability * clientAlivePayout + accidentProbability * accidentPayout;
      var VarX = (clientAliveProbability * clientAlivePayout * clientAlivePayout + accidentProbability * accidentPayout * accidentPayout) - (accidentProbability * accidentProbability);
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

      MessageBox.Show(U.ToString());
    }
  }
}
