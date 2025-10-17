using System;

namespace TipCalculator.Gui
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
           
        }

        private void CalcularButton_Clicked(object sender, EventArgs e)
        {
            decimal importe = Convert.ToDecimal(ImporteEntry.Text);
            decimal personas = Convert.ToDecimal(PersonaEntry.Text);
            decimal porcentajePropina = Convert.ToDecimal(PropinaEntry.Text);

            decimal importePropina = importe * (porcentajePropina / 100);
            decimal propinaPorPersona = importePropina / personas;
            decimal importeTotal = importe + importePropina;
            decimal importeTotalPorPersona = importeTotal / personas;

            ImportepropinaLabel.Text = importePropina.ToString("C2");
            PropinapersonaLabel.Text = propinaPorPersona.ToString("C2");
            ImportetotalLabel.Text = importeTotal.ToString("C2");
            ImportetotalpersonaLabel.Text = importeTotalPorPersona.ToString("C2");
        }

        private void LimpiarButton_Clicked(object sender, EventArgs e)
        {
            ImporteEntry.Text = string.Empty;
            PersonaEntry.Text = string.Empty;
            PropinaEntry.Text = string.Empty;
            ImportepropinaLabel.Text = string.Empty;
            PropinapersonaLabel.Text = string.Empty;
            ImportetotalLabel.Text = string.Empty;
            ImportetotalpersonaLabel.Text = string.Empty;
        }
    }
}
