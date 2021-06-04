Nombre del proyecto: IQÜEA 
https://drive.google.com/file/d/1hVX6BNHEjkbp4z0n8j_iQtwcYlA1Y0So/view?usp=sharing
Esquema de la base de datos se llama BBDD_Iquea.pdf y se encuentra en hada-grupal/.

Componentes del grupo:

Álvaro Lario Sánchez 23813883M
Daniel Bolaño Morillas 74394309G
Pedro Simarro Santamaría 05720860R
Joaquín José Cerdán López 48825524C
Adrian Ubeda Touati 50771466R 
Adam Brahim García 48797984B

● Descripción 

Nuestra página web consistirá en una tienda online que venderá muebles y elementos para el hogar, ya puede ser del salón, del baño, o del jardín, también estará disponible una sección para vender comida, y también contará con una opción para solicitar que te arreglen tus muebles. Además un cliente se podrá registrar como un usuario, un administrador o como empresa.

● Parte pública: se deberá especificar la funcionalidad de la parte pública de la web (sin estar registrado). Es conveniente usar una lista en forma de viñetas (como esta), donde explicaremos un poco cada opción. 

Ver el catálogo de la tienda, con varias opciones para la búsqueda de artículos, como puede ser filtrar por nombre, o por tipo de mueble.
Registrarse . Para poder acceder a la parte privada
Formulario de contacto, para poder contactar con la empresa
Carrito de la compra, lista de artículos en la que el cliente puede añadir productos deseados dentro de la web.
Ver comentarios de los diferentes artículos además de las valoraciones de los clientes


● Listado EN Pública: Además se entregará un listado con las EN que hemos identificado en esta parte. 

ENArticulo se podrá consultar su información necesaria:precio,tamaño,tipo...
ENOferta se  podrán conocer las ofertas existentes en cada artículo,su fecha de vencimiento y el porcentaje de reducción del precio.
ENAnuncio se almacenará la información necesaria según el tipo de anuncio como puede ser que se publicita y un enlace a lo publicitado.
ENComentario se almacenará las diferentes opiniones de los clientes además de sus valoraciones
ENCarrito donde se almacena el nombre y precio de los artículos que se vayan a comprar.

● Parte privada: se deberá especificar la funcionalidad de la parte privada de la web (una vez registrado). Es conveniente usar una lista en forma de viñetas, donde explicaremos un poco cada opción. 

Valorar un artículo, los clientes podrán valorar de una a cinco estrellas el artículo seleccionado.
Comprar un producto, los clientes podrán realizar compras de artículos.
Los clientes podrán realizar reservas de artículos que no se encuentren actualmente a la venta.
Modificar un perfil (administrador, cliente), el cliente que posea una cuenta en la web, podrá modificar su perfil, además de los administradores de la web.
Añadir ofertas (administrador), los administradores de la página podrán añadir ofertas sobre los artículos de la web.
Reparación de muebles, el cliente podrá requerir de la reparación de muebles.
Darse de baja, si el cliente lo desea, podrá solicitar una baja de la web.
Seguimiento del pedido, apartado en el que el cliente podrá consultar el estado de su pedido y el tiempo aproximado de entrega.

● Listado EN Privada: Además se entregará un listado con las EN que hemos identificado en esta parte. 

ENCompra nos permite realizar compras a los usuarios registrados.Debe permitir guardar datos bancarios y los datos del usuario por posibles problemas con el pedido.
ENReserva para guardar los datos de los usuarios y el artículo de la reserva.
ENAdministrador guarda los datos de los usuarios que son administradores de la página.
ENUsuario guarda datos de los usuarios tales como nombre,dirección, teléfono...
ENEmpresa guarda los datos de las empresas de las que provienen los diferentes artículos tales como domicilio, teléfono de contacto, nombre...
ENArticulo almacena todos los datos que caracterizan a un artículo, como puede ser el precio, el nombre del artículo…
ENOferta se  podrán conocer las ofertas existentes en cada artículo,su fecha de vencimiento y el porcentaje de reducción del precio.
ENConsulta permite a los usuarios realizar la búsqueda de artículos que estén contenidos dentro de la web.
ENComentario permite que los usuarios puedan redactar comentarios sobre los artículos de la web.
ENAnuncio permite a los administradores la posibilidad de colgar anuncios en la web que sean visionados por los usuarios.
ENHorarios nos permite consultar los horarios de los distintos trabajadores y de la propia tienda.
ENCarrito donde se almacena el nombre y precio de los artículos que se vayan a comprar.

● Posibles mejoras

Permitir filtrar por precios segun un mínimo que se nos de.
Enlaces a redes sociales(Facebook,Instagram...).
Creación de muebles a medida según una serie de especificaciones dadas por los usuarios.
Creación de un parque en el cual los hijos de los clientes puedan divertirse mientras que los padres realizan sus compras
Instalación de cosas electrónicas y montado de muebles.
Reparación de muebles a domicilio.

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

Entrega final:

+Cambios y problemas respecto a la idea original:

-No se ha podido implementar carrito ni pedido.
-Se ha creado un email y unas redes sociales (Instagram,Twitter) con el que se puede contactar.
-Falta de comunicación y orden dentro del grupo.
-Falta de tiempo.
-las ofertas están creadas,pero no implementadas de forma efectiva.

+Tiempo gastado:

-Daniel Bolaño Morillas:100 horas.
-Álvaro Lario Sánchez: 100 horas
-Pedro Simarro Santamaría:100 horas.
-Joaquín José Cerdán López: 100 horas.
-Adrian Ubeda Touati: 100 horas.
-Adam Brahim García: 100 horas.

+Trabajo realizado por cada persona:

-Daniel Bolaño Morillas:
Capa EN:Oferta y Comentario.
Capa CAD:Oferta y Comentario.
Interfaz:Master.aspx,articulos.aspx,Busqueda.aspx,Comentar.aspx,Modificar.aspx.
Validación:controles de validación de registrarse y modificar.
Otros:diseñar diagrama de la BD,Presentación,Filtro por nombre,gridview de las mayoría de vistas,objeto Session,enlace de gridview con la pagina articulo.aspx,salir de la sesion abierta.

-Álvaro Lario Sánchez:
Capa EN:Lin_pedido y pedido.
Capa CAD:Lin_pedido y pedido.
Interfaz:Administrador.aspx y todas las vistas que se derivan de esta,Master.aspx,Carrito.aspx,
Validación:
Otros:diseñar diagrama de la BD,Presentación, Tablas de pedido, lin_pedido.






-Pedro Simarro Santamaría:
Capa EN:Lista_deseos,Anuncio.
Capa CAD:Lista_deseos,Anuncio.
Interfaz:Master.aspx,Index.aspx, Login.aspx, Lista_deseos.aspx, Registrarse.aspx,CrearArticulo.aspx
Validación: Registrarse.aspx
Otros:diseñar diagrama de la BD,Presentación,creación de redes sociales, Implementación de los CRUD en CAD_ListaDeseos, Implementación de los CRUD en CAD_Articulo, Implementación de Bootstrap en todas las vistas del proyecto,Aplicado el Bootstrap a las vistas Index, Registrarse,Articulo, Login y Perfil, GridView Lista_deseos, GridView Articulo.

-Joaquín José Cerdán López:
Capa EN:Categoría,Artículo.
Capa CAD:Categoría,Artículo.
Interfaz:Master.aspx,Pedido.aspx,Lista_deseos.aspx, Login.aspx, Index.aspx,
Validación:
Otros:diseñar diagrama de la BD,Presentación, crear la variable sesión,  modificaciones diagrama de la BD, implementación de la Base de Datos, mystyle.css, ayuda en la creación de artículo, ayuda en la corrección de GridView.

-Adam Brahim García:
Capa EN:Administrador,Usuario.
Capa CAD:Administrador,Usuario.
Interfaz:Master.aspx,Usuario.aspx,barra de búsqueda.
Validación: CrearOferta.aspx
Otros:diseñar diagrama de la BD,Presentación, implementación de la barra de búsqueda con filtrado por nombre y precio

-Adrian Ubeda Touati: 
Capa EN:Lin_Carrito,Carrito.
Capa CAD:Lin_Carrito,Carrito.
Interfaz:Master.aspx,Categoría.aspx,Exterior.aspx,Interior.aspx,Temporada.aspx,Sencillo.aspx,Moderno.aspx,Clásico.aspx,Index.aspx,Ofertas.aspx,menu asp.
Validación: 
Otros:diseñar diagrama de la BD,Presentación, Implementación de la sql en codigo (se modificó posteriormente por casi todos), ayude en creacion artículo, GridViews, mystyle.css (parte), búsqueda de información de todos los artículos y de la implementación de estos en la base de datos a través del archivo sql, ayude en la variable sesión.

+forma de actuar:

dentro de la carpeta de IqueaWeb/App_Data hay un ejecutable llamado “ejecutableBD.sql”.Se debe conectar a la base de datos “Database.mdf” y ejecutarlo para introducir unos datos básicos en la web.

Al ejecutarlo se crean 4 usuarios con los siguientes correos y contraseña:
-Correo:profegod@gmail.com Contraseña:123456789
-Correo:dbm39@gmail.com Contraseña:987654321
-Correo:pepo@gmail.com Contraseña:789654123
-Correo:willyrex@gmail.com Contraseña:3455623626

El código para acceder a Administrador es:Admin_god


