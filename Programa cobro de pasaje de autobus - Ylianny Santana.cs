using System;

class Autobus
{
    public string Nombre;
    public int CapacidadTotal;
    public int Pasajeros;
    public int PrecioPasaje;
    public string Ruta;
    public double Distancia;

    public Autobus(string nombre, int capacidadTotal, int precioPasaje, string ruta, double distancia)
    {
        Nombre = nombre;
        CapacidadTotal = capacidadTotal;
        PrecioPasaje = precioPasaje;
        Ruta = ruta;
        Distancia = distancia;
        Pasajeros = 0;
    }

    public void AgregarPasajeros(int cantidad)
    {
        if (Pasajeros + cantidad <= CapacidadTotal)
        {
            Pasajeros += cantidad;
        }
        else
        {
            Console.WriteLine("No hay suficientes asientos disponibles.");
        }
    }

    public int CalcularVentas()
    {
        return Pasajeros * PrecioPasaje;
    }

    public int AsientosDisponibles()
    {
        return CapacidadTotal - Pasajeros;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine(Nombre + " - Ruta: " + Ruta + " - Distancia: " + Distancia + " km | " +
                          Pasajeros + " Pasajeros | Ventas: " + CalcularVentas() + " | Quedan " +
                          AsientosDisponibles() + " asientos disponibles");
    }
}

class Program
{
    static void Main()
    {
        Autobus bus1 = new Autobus("Auto Bus Platinum", 22, 1000, "Ruta A", 150.5);
        Autobus bus2 = new Autobus("Auto Bus Gold", 15, 1300, "Ruta B", 120.0);

        bus1.AgregarPasajeros(5);
        bus2.AgregarPasajeros(3);

        bus1.MostrarInformacion();
        bus2.MostrarInformacion();
    }
}

