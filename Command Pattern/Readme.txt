Patrón comando

Este patrón se encuentra dentro de la categoría de los patrones de diseño de comportamiento. Este toma una petición y la convierte en un objeto stand-alone que contiene toda la información de la petición. Esta transformación permite parametrizar clientes con diferentes peticiones, retrasar o encolar la ejecución de una petición y soportar operacciones que no se pueden deshacer.

Una solicitud es envuelta bajo un objeto cómo un comando y pasado al objeto invocador. El objeto invocador luce como el objeto apropiado el cual puede manejar este comando y pasa el comando al correspondiente objeto que se encarga de ejecutar el comando.

Este patrón desacopla el objeto que invoca la operación del que conoce cómo ejecutarla. Para alcanzar esto, el diseñador crea clase abstracta que mapea un recibidor (un objeto) con una acción (un puntero a un miembro de una función). La clase base tenía un método Execute() que simplemente llama la acción  sobre el recibidor.

El proposito de este patrón es: Encapsular una petición como un objeto, de tal forma que se puedan parametrizar otros objetos de otras peticiones o de colas de peticiones. 

Actores de este patrón:
    • Cliente: Es la clase que desencadena la acción.
    • Command: Es la clase que encapsula todo la información necesaria para ejecutar la acción. Pueden llegar a ser DTO’s. Lo importante es que se puedan serializar facilmente.
    • Handler: Es la clase que tiene la lógica que se debe ejecutar, esta clase solo debe tener una única responsabilidad y puede tener dependencias externas si es necesario.