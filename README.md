## ¿String es un tipo por valor o un tipo por referencia?
En C#, string es un tipo de dato por referencia. Aunque string se comporta de manera similar a un tipo por valor en muchos aspectos (como la inmutabilidad), es en realidad un tipo de referencia. Esto significa que las variables de tipo string almacenan una referencia a un objeto en la memoria, en lugar de almacenar directamente los datos de la cadena.

## ¿Qué secuencias de escape tiene el tipo string?
En C#, las secuencias de escape permiten incluir caracteres especiales dentro de las cadenas de texto. Aquí están las secuencias de escape más comunes:

\\ : Barra invertida (\)
\' : Comilla simple (')
\" : Comilla doble (")
\n : Nueva línea (line feed)
\r : Retorno de carro (carriage return)
\t : Tabulación horizontal (tab)
\b : Retroceso (backspace)
\f : Avance de página (form feed)
\0 : Carácter nulo (null character)
\v : Tabulación vertical (vertical tab)

## ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?

El carácter @ antes de una cadena de texto se utiliza para definir una cadena literal textual. Esto significa que las secuencias de escape no se procesan, y la cadena se toma tal cual, lo cual es especialmente útil para rutas de archivo o cadenas que contienen muchas barras invertidas.











