namespace sisPersonal
{
    public enum Cargo
    {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }

    public class Empleado
    {
        string nombre;
        string apellido;
        DateTime fechaNacimiento;
        char estadoCivil;
        DateTime fechaIngreso;

        double sueldoBasico;
        Cargo cargos;



        public Empleado(string nombre, string apellido, DateTime fechaNacimiento, char estadoCivil, DateTime fechaIngreso, double sueldoBasico, Cargo cargos)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNacimiento = fechaNacimiento;
            this.estadoCivil = estadoCivil;
            this.fechaIngreso = fechaIngreso;
            this.sueldoBasico = sueldoBasico;
            this.cargos = cargos;
        }

        public String Nombre { get => nombre; set => nombre = value; }
        public String Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public Char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public Double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
        public Cargo Cargos { get => cargos; set => cargos = value; }









        public int CalcularEdad()
        {
            var hoy = DateTime.Today;
            int edad = hoy.Year - fechaNacimiento.Year;
            if (FechaNacimiento > hoy.AddYears(-edad))
            {
                edad--;
            }
            return edad;
        }



        public int CalcularAntiguedad()
        {
            var hoy = DateTime.Today;
            int antig = hoy.Year - fechaIngreso.Year;
            if (FechaIngreso > hoy.AddYears(-antig))
            {
                antig--;
            }
            return antig;
        }



        public int AniosParaJubilarse()
        {
            return 65 - CalcularEdad();
        }

        public double CalcularSalario()
        {
            double adicional = 0;
            int antig = CalcularAntiguedad();

            if (antig <= 20)
            {
                adicional = SueldoBasico * 0.01 * antig;
            }
            else
            {
                adicional = SueldoBasico * 0.25;
            }
            if (Cargos == Cargo.Ingeniero || Cargos == Cargo.Especialista)
            {
                adicional *= 1.5;
            }
            if (EstadoCivil == 'C' || EstadoCivil == 'c')
            {
                adicional += 150000;
            }

            return SueldoBasico + adicional;
        }
    }





}

