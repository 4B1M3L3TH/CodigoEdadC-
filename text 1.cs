using POO;

Persona p1 = new Persona();
Console.WriteLine("Nombre de la Persona");
p1.Nombre = "Che";
p1.Edad = 18;
p1.Cdula = "0011713131M";

p1.mostrar();
p1.esMayordeEdad();

// Puedes probar cualquiera de las siguientes:
p1.clasificarEdad_ifelse();
p1.clasificarEdad_switch_clasico();
p1.clasificarEdad_switch_expression();
p1.clasificarEdad_modular();
