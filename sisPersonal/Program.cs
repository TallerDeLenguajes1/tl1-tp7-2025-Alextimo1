using sisPersonal;

Empleado[] empleados = new Empleado[3];

empleados[0] = new Empleado("Ana", "Gomez", new DateTime(1985, 5, 15), 'C', new DateTime(2005, 6, 1), 650000, Cargo.Ingeniero);
empleados[1] = new Empleado("Luis", "Pérez", new DateTime(1990, 9, 10), 'S', new DateTime(2010, 3, 12), 500000, Cargo.Administrativo);
empleados[2] = new Empleado("María", "López", new DateTime(1963, 2, 20), 'C', new DateTime(1990, 7, 5), 700000, Cargo.Especialista);

double totalSalarios = 0;
Empleado masCercanoAJubilarse = empleados[0];

Console.WriteLine("=== INFORMACIÓN DE EMPLEADOS ===\n");

foreach (Empleado emp in empleados)
{
    Console.WriteLine($"Nombre: {emp.Nombre} {emp.Apellido}");
    Console.WriteLine($"Edad: {emp.CalcularEdad()} años");
    Console.WriteLine($"Antigüedad: {emp.CalcularAntiguedad()} años");
    Console.WriteLine($"Años para jubilarse: {emp.AniosParaJubilarse()}");
    Console.WriteLine($"Salario: ${emp.CalcularSalario()}");
    Console.WriteLine("-----------------------------------");

    totalSalarios += emp.CalcularSalario();

    if (emp.AniosParaJubilarse() < masCercanoAJubilarse.AniosParaJubilarse())
    {
        masCercanoAJubilarse = emp;
    }
}

Console.WriteLine($"\nTOTAL PAGADO EN SALARIOS: ${totalSalarios}");

// Empleado más próximo a jubilarse
Console.WriteLine("\n=== EMPLEADO MÁS PRÓXIMO A JUBILARSE ===");
Console.WriteLine($"Nombre: {masCercanoAJubilarse.Nombre} {masCercanoAJubilarse.Apellido}");
Console.WriteLine($"Edad: {masCercanoAJubilarse.CalcularEdad()} años");
Console.WriteLine($"Antigüedad: {masCercanoAJubilarse.CalcularAntiguedad()} años");
Console.WriteLine($"Años para jubilarse: {masCercanoAJubilarse.AniosParaJubilarse()}");
Console.WriteLine($"Salario: ${masCercanoAJubilarse.CalcularSalario()}");