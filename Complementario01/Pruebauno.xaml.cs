namespace Complementario01;

public partial class Pruebauno : ContentPage
{
	public Pruebauno()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        //Obtenemos los numeros registrados que hemos agregado esto funciona ya que entry tienen una
        //conexion por los entry1 entry2 entry3 emtry4 estos los declaramos 
        //En la xaml de prueba uno 
        int num1 = Convert.ToInt32(entry1.Text);
        int num2 = Convert.ToInt32(entry2.Text);
        int num3 = Convert.ToInt32(entry3.Text);
        int num4 = Convert.ToInt32(entry4.Text);
	
        //Con array.Reverse invertiremos los numeros que hemos colocado en los entry
        int[] numeros = { num1, num2, num3, num4 };
        Array.Reverse(numeros);
	
        //Luego mostramos los numeros invertidos en el label este aparecera en la pantalla cuando invertamos los nuemeros
        lblResultado.Text = string.Join(", ", numeros);
    }
}
