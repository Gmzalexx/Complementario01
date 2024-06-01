namespace Complementario01;

public partial class Pruebauno : ContentPage
{
	public Pruebauno()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        //Obtenemos los numeros registrados por los usuarios, esto se logra por los entry
        int num1 = Convert.ToInt32(entry1.Text);
        int num2 = Convert.ToInt32(entry2.Text);
        int num3 = Convert.ToInt32(entry3.Text);
        int num4 = Convert.ToInt32(entry4.Text);

        // Invertimos los números
        int[] numeros = { num1, num2, num3, num4 };
        Array.Reverse(numeros);

        // Mostramos los numeros invertidos en el label
        lblResultado.Text = string.Join(", ", numeros);
    }
}