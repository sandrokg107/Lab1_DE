using DE_Lab01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DE_Lab01
{
    public class Usuario
    {
        public string Nombres { get; set; }
        public double Saldo { get; set; }

        public Usuario(string nombres, double saldo)
        {
            Nombres = nombres;
            Saldo = saldo;
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombres}");
            Console.WriteLine($"Saldo: {Saldo}");
        }
    }
}

public class Empleado : Usuario
{
    public double Sueldo { get; set; }

    // Constructor que llama al constructor de la clase base
    public Empleado(string nombres, double saldo, double sueldo) : base(nombres, saldo)
    {
        Sueldo = sueldo;
    }

    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Sueldo: {Sueldo}");
    }
}

public class Cliente : Usuario
{
    public double LitrosCargados { get; set; }

    // Constructor que llama al constructor de la clase base
    public Cliente(string nombres, double saldo, double litrosCargados) : base(nombres, saldo)
    {
        LitrosCargados = litrosCargados;
    }

    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Litros Cargados: {LitrosCargados}");
    }
}

public class Box
{
    private List<Usuario> usuarios;

    public Box()
    {
        usuarios = new List<Usuario>();
    }

    // Método para agregar usuarios a la lista
    public void AgregarUsuario(Usuario usuario)
    {
        usuarios.Add(usuario);
    }

    // Método para mostrar la información de todos los usuarios
    public void MostrarUsuarios()
    {
        foreach (Usuario usuario in usuarios)
        {
            usuario.MostrarInformacion();
            Console.WriteLine(); // Agrega una línea en blanco entre cada usuario para mejor legibilidad
        }
    }
}
