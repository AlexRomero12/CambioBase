# CambioBase

Este código es un programa de consola que realiza la conversión de un número en base 10 a otra base k.

Primero, el programa pide al usuario que ingrese el valor de x en base 10 y luego valida que el valor ingresado sea un número entero. Luego, pide al usuario que ingrese la base k a la que quiere convertir x y también valida que el valor ingresado sea un número entero.

Luego, el programa realiza la conversión de x a la base k mediante un bucle while: mientras x sea mayor que cero, se añade el resto de x dividido entre k a una lista y luego se divide x entre k. Esto se repite hasta que x sea menor o igual a cero.

Finalmente, se invierte el orden de los dígitos en la lista y se muestra el resultado en pantalla junto con un mensaje que indica la base a la que se ha convertido x.
