class suma
{
    static void Main()
    {
        //Solicitando 1ªnumero
        Console.Write("Ingrese el primer número entero --> ");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        //Solicitando 2ªnumero
        Console.Write("Ingrese el segundo número entero --> ");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        //Calcular la suma
        int suma = numero1 + numero2;

        //Mostrar el resultado
        Console.Write("El resultado de la suma es = " + suma + " ");
    }
}
