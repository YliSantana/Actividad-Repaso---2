using System;
using System.Collections.Generic;

class Autobus
{
    public string Nombre { get; set; }
    public int CapacidadTotal { get; set; }
    public int Pasajeros { get; private set; }
    public int PrecioPasaje { get; set; }
    
    public Autobus(string nombre, int capacidadTotal, int precioPasaje)
    {
        Nombre = nombre;
        CapacidadTotal = capacidadTotal;
        PrecioPasaje = precioPasaje;
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
    
    public override string ToString()
    {
        return $"{Nombre} {Pasajeros} Pasajeros Ventas {CalcularVentas()}, quedan {AsientosDisponibles()} asientos disponibles";
    }
}

class Program
{
    static void Main()
    {
        List<Autobus> autobuses = new List<Autobus>
        {
            new Autobus("Auto Bus Plantinum", 22, 1000),
            new Autobus("Auto Bus Gold", 15, 1300)
        };
        
        autobuses[0].AgregarPasajeros(5);
        autobuses[1].AgregarPasajeros(3);
        
        foreach (var bus in autobuses)
        {
            Console.WriteLine(bus);
        }
    }
}
