using Microsoft.Data.SqlClient;

using (var contextdb = new Context())
{
    contextdb.Database.EnsureCreated();
    
    bool continuar = true;
    while (continuar)
    {
        Console.WriteLine("Ingrese un Id: ");
        int Id = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese sus Nombres: ");
        string Nombres = Console.ReadLine();

        Console.WriteLine("Ingrese sus Apellidos: ");
        string Apellidos = Console.ReadLine();

        Console.WriteLine("Ingrese su Edad: ");
        int Edad = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese su Sexo: ");
        string Sexo = Console.ReadLine();

        var estudiante = new ESTUDIANTE
        {
            Id = Id,
            Nombres = Nombres,
            Apellidos = Apellidos,
            Edad = Edad,
            Sexo = Sexo
        };

        contextdb.Add(estudiante);
        contextdb.SaveChanges();

        Console.Write("¿Desea agregar otro registro? (S/N): ");
        string respuesta = Console.ReadLine();
        continuar = (respuesta.ToLower() == "s \n");

        Console.WriteLine("\nLOS DATOS REGISTRADOS SON LOS SIGUIENTES: \n");

        foreach (var s in contextdb.Estudiante)
        {
            Console.WriteLine("Id: " + s.Id + "\nNombres: " + s.Nombres + "\nApellidos: " + s.Apellidos + "\nEdad: " + s.Edad + "\nSexo: " + s.Sexo + "\n");
        }
    }
    
}
