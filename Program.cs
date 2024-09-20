List <string> articulos = new List<string> {"Zapatos", "Tenis", "Camisetas", "Jeans"};
string mensajeFinal = "";
int sumaTotal = 0;
int promedioTotal = 0;
double aumentoPrecio = 0;
double disminucionPrecio = 0;

for (int i = 0; i < articulos.Count; i++) {
    Console.WriteLine($"Ingresa un valor para el siguiente artículo: {articulos[i]}");
    int precio = int.Parse(Console.ReadLine());
    mensajeFinal += $"El valor de {articulos[i]} es de {precio}\n";
    sumaTotal += precio;
    promedioTotal = sumaTotal / 4;

    if (articulos[i] == "Jeans") {
        aumentoPrecio = precio * (1 + 0.062);
    } if (articulos[i] == "Zapatos") {
        disminucionPrecio = precio * (1 - 0.008);
    }
}

Console.WriteLine(mensajeFinal);
Console.WriteLine($"La suma de todos los artículos es de ${sumaTotal}");
Console.WriteLine($"El promedio de los precios de los productos es de ${promedioTotal}");
Console.WriteLine($"El aumento del precio de los jeans es de ${aumentoPrecio}");
Console.WriteLine($"La disminución del precio de los zapatos es de ${disminucionPrecio}");