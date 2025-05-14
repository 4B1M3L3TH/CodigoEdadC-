public class Persona
{
    private string nombre;
    public string Nombre
    {
        get => nombre;
        set => nombre = value;
    }

    private int edad;
    public int Edad
    {
        get => edad;
        set => edad = (value > 0) ? value : 0;
    }

    private string cedula;
    public string Cdula
    {
        get => cedula;
        set => cedula = value;
    }

    public Persona() { }

    public void mostrar()
    {
        Console.WriteLine($"{Nombre} con id {Cdula} tiene {Edad} años");
    }

    public void esMayordeEdad()
    {
        if (edad >= 18)
            Console.WriteLine($"{nombre} es mayor");
        else
            Console.WriteLine($"{nombre} es menor");
    }

    // --- OPCIÓN 1: Clásico con if-else ---
    public void clasificarEdad_ifelse()
    {
        if (edad >= 0 && edad < 12)
            Console.WriteLine($"{nombre} está en la infancia");
        else if (edad >= 12 && edad < 18)
            Console.WriteLine($"{nombre} está en la adolescencia");
        else if (edad >= 18 && edad < 25)
            Console.WriteLine($"{nombre} está en la juventud");
        else if (edad >= 25 && edad < 60)
            Console.WriteLine($"{nombre} está en la adultez");
        else if (edad >= 60 && edad < 75)
            Console.WriteLine($"{nombre} es un adulto mayor");
        else if (edad >= 75 && edad < 90)
            Console.WriteLine($"{nombre} es un anciano");
        else if (edad >= 90)
            Console.WriteLine($"{nombre} es un anciano longevo");
        else
            Console.WriteLine("Edad no válida");
    }

    // --- OPCIÓN 2: Switch clásico con when ---
    public void clasificarEdad_switch_clasico()
    {
        switch (edad)
        {
            case int e when (e >= 0 && e < 12):
                Console.WriteLine($"{nombre} está en la infancia");
                break;
            case int e when (e >= 12 && e < 18):
                Console.WriteLine($"{nombre} está en la adolescencia");
                break;
            case int e when (e >= 18 && e < 25):
                Console.WriteLine($"{nombre} está en la juventud");
                break;
            case int e when (e >= 25 && e < 60):
                Console.WriteLine($"{nombre} está en la adultez");
                break;
            case int e when (e >= 60 && e < 75):
                Console.WriteLine($"{nombre} es un adulto mayor");
                break;
            case int e when (e >= 75 && e < 90):
                Console.WriteLine($"{nombre} es un anciano");
                break;
            case int e when (e >= 90):
                Console.WriteLine($"{nombre} es un anciano longevo");
                break;
            default:
                Console.WriteLine("Edad no válida");
                break;
        }
    }

    // --- OPCIÓN 3: Switch expression (C# 8+) ---
    public void clasificarEdad_switch_expression()
    {
        string clasificacion = edad switch
        {
            >= 0 and < 12 => "infancia",
            >= 12 and < 18 => "adolescencia",
            >= 18 and < 25 => "juventud",
            >= 25 and < 60 => "adultez",
            >= 60 and < 75 => "adulto mayor",
            >= 75 and < 90 => "anciano",
            >= 90 => "anciano longevo",
            _ => "edad no válida"
        };

        Console.WriteLine($"{nombre} está en la etapa: {clasificacion}");
    }

    // --- OPCIÓN 4: Lógica separada y reutilizable ---
    public string ObtenerClasificacionEdad()
    {
        if (edad < 0) return "edad no válida";
        if (edad < 12) return "infancia";
        if (edad < 18) return "adolescencia";
        if (edad < 25) return "juventud";
        if (edad < 60) return "adultez";
        if (edad < 75) return "adulto mayor";
        if (edad < 90) return "anciano";
        return "anciano longevo";
    }

    public void clasificarEdad_modular()
    {
        string clasificacion = ObtenerClasificacionEdad();
        Console.WriteLine($"{nombre} está en la etapa: {clasificacion}");
    }
}
