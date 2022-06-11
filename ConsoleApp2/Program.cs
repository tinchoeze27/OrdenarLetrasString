// See https://aka.ms/new-console-template for more information

//declaro arreglo con strings
string[] palabras = { "ddggcb", "aaaccbbd", "ffgrthc" };

//ahora debo convertir estas palabras en un arreglo de caracteres

char[] letras;

//recorro el arreglo

for (int i = 0; i < palabras.Length; i++)
{
    letras = palabras[i].ToCharArray(); // Pasa estas palabras a un arreglo de caracteres con esa propiedad
    Array.Sort(letras);
    palabras[i] = new String(letras); // Creo este arreglo de caracteres en nuevo string;
    Console.Write(palabras[i] + "\n");
}

Console.ReadLine();


