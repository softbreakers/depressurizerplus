## Introducción ##

Depressurizer+ es una aplicación que permite clasificar con mucha más facilidad los juegos en librerías de gran tamaño, siendo una alternativa al interfaz de clasificación ofrecido por el cliente de Steam.

## Requisitos ##

  * Windows .NET 4.0 y Steam instalado

  * Conexión a internet

  * Perfil de comunidad de Steam establecido a público

**Importante:** Para usar el programa correctamente, primero debe asegurarse que su perfil de comunidad de Steam ha sido establecido y configurado como "Público". Si no es así, la aplicación no tendrá modo de acceder a su lista de juegos.

## Antes de empezar ##

No se requiere instalación. Descomprima el archivo en un directorio de su disco duro. Para ejecutar la aplicación, lance Depressurizer+.exe.

**Nota:** Para algunas configuraciones, puede ser recomendable ejecutar el programa como administrador. Esto es requerido si el programa se ejecuta desde una cuenta de usuario de Windows que no tiene acceso de escritura al directorio de instalación de Steam. Puede configurarse la aplicación para iniciarse siempre con permisos de administración desde la ventana de "Propiedades" bajo la pestaña "Compatibilidad".

## Guía básica de uso ##

Antes de iniciar la aplicación, asegúrese que Steam no está ejecutándose. Al menos, tendrá que cerrar Steam antes de salvar la clasificación generada en Depressurizer+.

  1. Después de iniciar la aplicación por primera vez. le solicitará el directorio de instalación de Steam. Confirme si el directorio sugerido es correcto, o en caso contrario introduzca el directorio correcto, y pulse "Ok".
  1. Durante la primera ejecución la aplicación le solicitará crear un perfil. Se mostrará el listado de cuentas de usuario de Steam con datos almacenados ordenador. Su cuenta debería aparecer ahí; selecciónela.
  1. A pulsar el botón "OK", Depressurizer+ creará su fichero de perfil, y descargará una lista de todos sus juegos, y además importará cualquier información de clasificación desde Steam.
  1. Puede auto-clasificar los juegos seleccionándolos y pulsando el botón "Auto-Categorías" en la esquina inferior derecha de la ventana principal. Si "Auto-Categorías" no funciona, pero puede acceder sin problemas a la página de la tienda de Steam relativa a ese juego, entonces es posible que la base de datos esté desactualizada.
  1. La base de datos de juegos puede ser actualizada desde la ventana "Editor base de datos" en el menú "Herramientas". Primero actualize la lista de juegos pulsando el botón obtener lista, para descargar los juegos nuevos añadidos a la tienda de Steam. Después pulse "Actualizar Nuevos" para extraer la información sobre los nuevos juegos de la tienda de Steam. Puede gestionar completamente la base de datos añadiendo, eliminando y editando cualquier juego.
  1. También puede editar manualmente las categorías, y mover los juegos entre ellas. Al seleccionar una categoría en el listado de la izquierda, se filtrará el listado de juegos. Cree nuevas categorías pulsando el botón "Añadir" debajo del listado de categorías, o seleccionando "Añadir Categoría..." en el menú contextual del listado de categoría, o seleccionando "Crear Nueva..." bajo la opción "Establecer categoría" en el menú contextual del listado de juegos(esta última opción también asignará todos los juegos seleccionados a la nueva categoría). Los juegos también pueden ser clasificados arrastrándolos a la lista de categorías o usando el desplegable situado debajo del listado de juegos.
  1. Cuando finalice asegúrese que Steam no está en ejecución. Pulse en "Fichero" y "Guardar Perfil", y los cambios se volcarán tanto a Steam como a su fichero de perfil. Al cargar Steam asegúrese que los cambios se han producido en su biblioteca de juegos.
  1. Depressurizer+ es compatible con Depressurizer 0.4.4, por lo que si ha sido previamente usuario de Depressurizer, Depressurizer+ cargará los perfiles previos así como la configuración.

Si desea realizar cambios posteriormente, o si desea clasificar nuevos juegos, o si sus categorías desaparecen del cliente de Steam y necesita restablecerlas, tan solo precisa ejecutar la aplicación nuevamente. Si la configuración de su perfil tiene las opciones por defecto, el programa automáticamente cargará sus categorías anteriormente definidas y actualizará su lista de juegos (esto puede llevar unos instantes). Tras esto, puede editar y/o salvar otra vez si lo desea.

Depressurizer+ incluye soporte para juegos externos añadidos a la librería de Steam mediante la funcionalidad del cliente de Steam "Añadir un juego que no es de Steam...". La auto-clasificación para juegos externos está deshabilitada, pero puede clasificarlos manualmente. Solo los juegos externos que han sido lanzados al menos una vez desde el cliente de Steam serán cargados por Despressurizer+. Esta funcionalidad puede ser deshabilitada para cada perfil desde la ventana de "Editar Información de Perfil", pestaña "Ignorar juegos".

Depressurizer+ también incluye soporte multidioma. En la versión 1.0.0 Depressurizer+ solo soporta inglés y español. Por defecto, el lenguaje de Depressurizer+ es establecido por el idioma del sistema operativo. Si el sistema operativo está configurado en español, Depressurizer+ se inicia en español, en cualquier otro caso se inicia en inglés. Este comportamiento predeterminado puede configurarse en la ventana "Configuración", en el menú "Herramientas". Tenga en cuenta que cambiar la configuración de idioma no traduce los nombres de las categorías existentes.

## Terminología ##

  * Leer / Guardar: Esto siempre se refiere a leer y guardar perfiles de Depressurizer+, que contienen algunos parámetros de configuración además de una lista completa de sus juegos y la información de clasificación asociada. No es un fichero de configuración de Steam, y el cliente de Steam no puede manipularlos ni cargarlos.

  * Importar: La aplicación examina el fichero de configuración de Steam y carga la información de clasificación establecida en Steam.

  * Exportar: La aplicación escribe la información de clasificación al fichero de configuración de Steam, de manera que el cliente de Steam pueda mostrar dicha clasificación al cargar.

  * Descargar: La aplicación accede a su lista de juegos desde su perfil público en la comunidad de Steam. Es el único modo en el que la aplicación puede acceder a su lista de juegos.

## Incidencias conocidas ##

Esta aplicación aún está en desarrollo.

Algunos juegos no se mostrarán en la aplicación. Esto se debe a que algunos juegos no son listados en su página de perfil de la comunidad de Steam.
Some games will not show up in the program. This is a result of the games not showing up on your community profile page. Igualmente, hay muchos otros "juegos" que se muestran en la aplicación pero que no se muestran en el cliente de Steam (mayoritariamente paquetes DLC). Ignorar o cargar los paquetes DLC para cada perfil se puede configurar desde la ventana "Editar Información de Perfil", pestaña "Ignorar juegos".