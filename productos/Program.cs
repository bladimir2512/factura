//////......declaracion de variables.....////
///
int cantidad = 2;
int cantidadProducto;
String nombreProducto;
double precioProducto, totalPagar, totalAcumulado = 0;

for (int i = 1; i <= cantidad; i++)
{
    Console.WriteLine("nombre producto: " + i);
    nombreProducto = Console.ReadLine();
    Console.WriteLine("precio producto: " + i);
    precioProducto = double.Parse(Console.ReadLine());
    Console.WriteLine("cantida producto" + i);
    cantidadProducto = int.Parse(Console.ReadLine());
    totalPagar = (cantidadProducto * precioProducto) * 1.13;
    totalAcumulado = totalAcumulado + totalPagar;
}
Console.WriteLine("El total a pagar es: " + totalAcumulado);
Console.ReadKey();
