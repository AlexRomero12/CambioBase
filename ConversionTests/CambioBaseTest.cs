namespace ConversionTests
{
    public class CambioBaseTest
    {
        public class ConversionTests
        {
            [Theory]
            [InlineData(10, 2, "1010")]
            [InlineData(20, 2, "10100")]
            [InlineData(100, 2, "1100100")]
            [InlineData(100, 8, "144")]
            [InlineData(100, 16, "64")]
            public void TestConversionToBinary(int x, int k, string expectedResult)
            {
                // Creamos una lista para almacenar los residuos de las divisiones
                List<int> conversion = new();

                // Mientras x sea mayor que 0, seguimos realizando divisiones y obteniendo residuos
                while (x > 0)
                {
                    // Obtenemos el residuo de la división de x entre k y lo añadimos a la lista
                    conversion.Add(x % k);
                    // Obtenemos el cociente de la división y lo asignamos a x para continuar con el proceso de conversión
                    x /= k;
                }

                // Invertimos el orden de los elementos en la lista, ya que los hemos ido
                // añadiendo en orden inverso al que deben aparecer en la representación
                // final en base k
                conversion.Reverse();

                // Convertimos la lista de enteros a una cadena de texto y comprobamos que sea igual al resultado esperado
                Assert.Equal(expectedResult, string.Join("", conversion));
            }
        }
    }
}