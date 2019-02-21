# Agenda-mvc
## Ventajas y desventajas de c#
* Ventajas
  * Gran parecido con otros lenguacjes como C y Java, siendo de esta manera facil de entender
  * Amplio cantidad de tipos de datos
  * Permite extender clases existentes
  * Propiedades (get,set) para acceder a las variables
*Desventajas
  * .net se limita a windows

## Ventajas y desventajas de ASP.NET MVC
* Ventajas
  * Ha sido diseñados desde cero para realizar SoC y TDD.
  * No se realizan postback para atender una petición del usuario.
  * El Viewstate no es necesario para mantener el estado de la página.
  * No se utilizan controles de servidor con los que se pierde el control del html generado.
  * No depende de archivos aspx físicos.
  * El entorno de tiempo de ejecución es en gran medida la misma que en formularios Web Forms ASP.NET, pero el ciclo de solicitud es más sencillo y más directa.
  * Una parte esencial del modelo de formularios Web Forms, el ciclo de vida de página, ya no es necesaria en ASP.NET MVC.
* Desventajas
  * Control total sobre HTML, JavaScript y CSS, ASP.NET MVC significa que se introducen manualmente los elementos Web.
  * Toma un paso hacia atrás en términos de productividad y facilidad de uso.
  * Se requiere familiarización inicial con el patrón MVC. Se tiene que saber cómo funcionan conjuntamente los controladores y vistas en la implementación de ASP.NET.
  * No se puede aprender fácilmente experimentando lo que disminuye la productividad de los desarrolladores.
  
https://highscalability.wordpress.com/2010/02/03/cuando-usar-asp-net-mvc/

## Tecnologias mas usadas con ASP.NET MVC
* La herramienta ORM mas comun usada es entity framework
* Para el manejo de librerias se usa NuGet
* Para la publicacion en linea de la aplicacion web la plataorma mas comun es Azure y para implementar la aplicacion en una red local el IIS
* El IDE mas popular para el desarollo es Visul Studio y como alternativa mas ligera Visual Studio Code

## CURD
### Agregar
![alt text](https://github.com/duxifer/Agenda-mvc/blob/master/Agenda/Imagenes/crear.gif?raw=true)
![alt text](https://github.com/duxifer/Agenda-mvc/blob/master/Agenda/Imagenes/crear2.gif?raw=true)
## Editar
![alt text](https://github.com/duxifer/Agenda-mvc/blob/master/Agenda/Imagenes/editar.gif?raw=true)
## Borrar
![alt text](https://github.com/duxifer/Agenda-mvc/blob/master/Agenda/Imagenes/borrar.gif?raw=true)
