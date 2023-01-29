promedioEdad();
/*Hacer un programa que calcule el
promedio de edad de un grupo de
personas y diga cuál es la de edad más
grande y cuál es la más joven.*/

static void promedioEdad()
	{
		Console.WriteLine("Ingrese la cantidad de personas: ");
        int cantidad = (int)Convert.ToInt64(Console.ReadLine());
		int promedio = 0, edad=0, mayor = 0, menor = 9999;

		for (int i = 1; i <= cantidad; i++)
		{
			Console.Write($"Ingrese la edad {i}: ");
            edad = (int)Convert.ToInt64(Console.ReadLine());
            promedio += edad;

            if(edad>mayor){
                mayor = edad;
            }
            if(edad<menor){
                menor = edad;
            }
		}
		promedio = promedio / cantidad;
		Console.WriteLine($"La edad promedio: {promedio}");
        Console.WriteLine($"La edad mayor: {mayor}");
        Console.WriteLine($"La edad menor: {menor}");
	}