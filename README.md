Ejemplo de conversión de tipos de datos en C#.       

Nuestro objetivo era usar varias técnicas distintas para cambiar el tipo de datos de un valor determinado.        
Usamos la conversión implícita y nos basamos en el compilador de C# para realizar conversiones de ampliación. En los casos en los que el compilador no pudo realizar una conversión implícita, usamos conversiones explícitas. Usamos el método ToString() para convertir explícitamente un tipo de datos numérico en un tipo de datos string.         
Cuando necesitamos realizar conversiones de restricción, narrowing conversions, empleamos varias técnicas diferentes. Usamos el operador de conversión () cuando la conversión podía realizarse de forma segura y podía aceptar el truncamiento de valores después del decimal. También usamos el método Convert() cuando queríamos realizar una conversión y usar reglas de redondeo comunes para llevar a cabo una conversión de restricción.         
Por último, usamos los métodos TryParse() cuando la conversión de un tipo de datos string a un tipo de datos numérico podría producir una excepción de conversión de tipos de datos.          
Sin esta variedad de opciones, sería difícil trabajar en un lenguaje de programación fuertemente tipado. Afortunadamente, este sistema de tipos y conversión bien ejecutado se puede usar para compilar aplicaciones sin errores.        
