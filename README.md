# tl1_tp6_2023-GuilloValle
tl1_tp6_2023-GuilloValle created by GitHub Classroom

¿String es una tipo por valor o un tipo por referencia?
En C#, el tipo string es un tipo de referencia. Esto significa que cuando creas una variable string y la asignas a otra variable o pasas esa variable a una función, se pasa una referencia al objeto string en la memoria en lugar de hacer una copia completa del valor. 

¿Qué secuencias de escape tiene el tipo string?
El tipo string en C# admite varias secuencias de escape que te permiten incluir caracteres especiales dentro de una cadena. Aquí tienes algunas de las secuencias de escape más comunes:

\": Comilla doble. Se utiliza para incluir comillas dobles dentro de una cadena delimitada por comillas dobles.
\': Comilla simple. Se utiliza para incluir comillas simples dentro de una cadena delimitada por comillas simples.
\\: Barra invertida. Se utiliza para incluir una barra invertida dentro de una cadena.
\n: Nueva línea. Se utiliza para representar un carácter de nueva línea.
\r: Retorno de carro. Se utiliza para representar un carácter de retorno de carro.
\t: Tabulación horizontal. Se utiliza para representar un carácter de tabulación horizontal.
\b: Retroceso. Se utiliza para representar un carácter de retroceso.
\f: Avance de página. Se utiliza para representar un carácter de avance de página.
\v: Tabulación vertical. Se utiliza para representar un carácter de tabulación vertical.


¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?

Cuando utilizas el carácter @ antes de una cadena de texto en C#, se trata de una cadena de texto literal, lo que significa que se interpreta de forma literal sin interpretar secuencias de escape. Esto te permite escribir cadenas de texto sin la necesidad de escapar caracteres especiales.
Por ejemplo, si utilizas @"Hello\nWorld", la secuencia de escape \n se interpretará literalmente como una \ seguida de una n, en lugar de representar un carácter de nueva línea. Esto es útil cuando necesitas incluir rutas de archivo, expresiones regulares u otros tipos de cadenas en las que las secuencias de escape pueden interferir.
Por otro lado, cuando utilizas el carácter $ antes de una cadena de texto en C#, se trata de una cadena de interpolación. Esto te permite incrustar expresiones dentro de la cadena utilizando la sintaxis {} y el prefijo $ antes de la cadena. Las expresiones dentro de las llaves se evalúan y su resultado se convierte en una cadena de texto que se inserta en la posición correspondiente dentro de la cadena.
Por ejemplo, int age = 25; string message = $"I am {age} years old."; creará la cadena "I am 25 years old." al interpolar el valor de la variable age dentro de la cadena.
La combinación de @ y $ en una cadena de texto, como @$"Hello {name}", permite utilizar tanto la interpretación literal como la interpolación en una sola cadena, lo cual puede ser útil en ciertos escenarios.

