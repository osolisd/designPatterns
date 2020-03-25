Patrón Decorator

El patrón Decorator es un patrón de diseño del tipo estructural, el cual permite añadir nuevos comportamientos a un objeto al colocarlo dentro de objetos especiales o wrappers, que continenen los nuevos comportamientos.

Wrapper es el apodo alternativo para el patrón Decorator que expresa claramente la idea principal del patrón. Un "wrapper" o contenedor es un objeto que se puede vincular con algún objeto "objetivo". El contenedor contiene el mismo conjunto de métodos que el destino y delega todas las solicitudes que recibe. Sin embargo, el contenedor puede alterar el resultado haciendo algo antes o después de pasar la solicitud al destino.

¿Cuándo un wrapper simple se convierte en el verdadero decorador?  El contenedor implementa la misma interfaz que el objeto envuelto. Por eso, desde la perspectiva del cliente, estos objetos son idénticos. Tambien, se puede hacer que el campo de referencia del contenedor acepte cualquier objeto que implemente a esa interfaz. Esto permitirá cubrir un objeto en varios contenedores, agregando el comportamiento combinado de todos los contenedores.

Aplicabilidad

- Cuando necesite poder asignar comportamientos adicionales a los objetos en tiempo de ejecución sin romper el código que usa estos objetos. Decorator permite estructurar su lógica de negocios en capas, crear un decorador para cada capa y componer objetos con varias combinaciones de esta lógica en tiempo de ejecución. El código del cliente puede tratar todos estos objetos de la misma manera, ya que todos siguen una interfaz común.

Cuando sea incómodo o no sea posible extender el comportamiento de un objeto usando la herencia Muchos lenguajes de programación tienen la palabra clave final que se puede usar para evitar una mayor extensión de una clase. Para una clase final, la única forma de reutilizar el comportamiento existente sería envolver la clase con su propio contenedor, utilizando el patrón Decorator.