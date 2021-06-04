delete From dbo.Administrador;
delete from dbo.Anuncio;
delete from dbo.Articulo_Lin_carrito;
delete from dbo.Articulo_Lin_Pedido;
delete from dbo.Articulo_Lista_deseos;
delete from dbo.Articulo_Oferta;
delete from dbo.Carrito;
delete from dbo.comentario;
delete from dbo.Lin_carrito;
delete from dbo.Lin_pedido;
delete from dbo.Lista_deseos;
delete from dbo.oferta;
delete from dbo.Pedido;
delete from dbo.Categoria;
delete from dbo.Usuarios;
delete from dbo.Articulo;

insert into dbo.Categoria (Id,Nombre,Descripcion) values (0,'interior','muebles perfectos para espacios cerrados e interiores');
insert into dbo.Categoria (Id,Nombre,Descripcion) values (1,'exterior','muebles perfectos para espacios abiertos y exteriores');

insert into dbo.Usuarios (email,contra,datosBancarios,nombre,direccion,numTelefono) values ('profegod@gmail.com',123456789,'12001234432156439009','Julio','Universidad de alicante',722343490);
insert into dbo.Usuarios (email,contra,datosBancarios,nombre,direccion,numTelefono) values ('dbm39@gmail.com',987654321,'1345643689796578','rodrigo','calle san martin',633598745);
insert into dbo.Usuarios (email,contra,datosBancarios,nombre,direccion,numTelefono) values ('pepo@gmail.com',789654123,'1257689607654798','julian','calle ruiseñor',755698432);
insert into dbo.Usuarios (email,contra,datosBancarios,nombre,direccion,numTelefono) values ('willyrex@gmail.com',3455623626,'9876543212345678','german','calle de la marina',544698574);
insert into dbo.Administrador (codigo, correo) values ('Admin_god','profegod@gmail.com');

/*SENCILLO*/


  INSERT INTO Articulo (Id, Nombre,Descripcion,Precio,Imagen,Stock,temporada,Categoria_id) VALUES (0,'Chicago','La estructura de metal está pintada en un llamativo negro para darle un aire clásico, mientras que la pantalla metalizada plateada le da ese acabado pulido.',229,'https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/f/f/0/f/ff0f5e39a00db5658e47de29b63938b289dd1779_FLPCHI011ZSI_UK_Chicago_Tripod_Floor_Lamp_Black_and_Silver_ar3_2_LB02_LS.jpg',20,'Sencillo',0);

  INSERT INTO Articulo (Id, Nombre,Descripcion,Precio,Imagen,Stock,temporada,Categoria_id) VALUES (1,'caspio','Este sofá te ofrece un buen confort. Su respaldo de fibra y picado recoge perfectamente la zona lumbar. Los brazos de este modelo tienen forma de almohada suave y mullida para facilitar el reposo cuando estés en posición tumbada. Diseño de gran comodidad, con asientos de densidad media que permiten disfrutar de un mayor confort en la sentada.',259,'https://i.ibb.co/VYcx7pX/Articulo-sofa-sencillo-sin-marca-de-agua.png',10,'Sencillo',0);

  INSERT INTO Articulo (Id, Nombre,Descripcion,Precio,Imagen,Stock,temporada,Categoria_id) VALUES (2,'Portlyn','Estantería con compartimentos de diferentes tamaños Se puede usar como separador de ambiente Peso máximo soportado: 45 kg por nivel El producto se entrega en un paquete que ahorra espacio, requiere montaje.',529,'https://static.westwingnow.de/image/upload//simple/74/932/1324021.jpg',17,'Sencillo',0);

  INSERT INTO Articulo (Id, Nombre,Descripcion,Precio,Imagen,Stock,temporada,Categoria_id) VALUES (3,'Masako','Masako duplica sus tonos: el cristal esmerilado en el interior, y el exterior ahumado, con una tonalidad gris frío. Las formas orgánicas dan una vibración nórdica, ideal para crear un ambiente tranquilo y zen en tu espacio.',189,'https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/6/a/1/4/6a14dc460b3700644830b77108556eb6792cb4f1_CLPMAS004SMK_UK_Masako_Chandelier_Pendant_Light_Smoked_Opal_Glass_ar3_2_LB02_LS.jpg',5,'Sencillo',0);


 /*Clasico*/


  INSERT INTO Articulo (Id, Nombre,Descripcion,Precio,Imagen,Stock,temporada,Categoria_id) VALUES (4,'Sillón','Su diseño y apariencia llama la atención de quien lo ve. Este sillón estilo Chesterfield crea una atmosfera acogedora en cualquier habitación. Su tapicería te invita a sentarte, leer un libro o ver la televisión. Las patas de madera y el respaldo decorado con botones completan su estructura.',379,'https://pictureserver.net/images/pic/d9/76/undef_src_sa_picid_749405_x_1800_type_color_image.jpg?ver=14',3,'Clasico',0);

  INSERT INTO Articulo (Id, Nombre,Descripcion,Precio,Imagen,Stock,temporada,Categoria_id) VALUES (5,'Twin-Naturale','El Conjunto de Salón Argos Twin es una composición contemporánea, serena y coqueta que hará de tu salón un lugar más acogedor y elegante a la vez que te ofrece una gran variedad de soluciones para el almacenaje y la colocación de fotos, libros y detalles decorativos.',349,'https://st01.ventamueblesonline.es/58096-thickbox_default/composicion-de-salon-argos-twin-sable.jpg',13,'Clasico',0);

  INSERT INTO Articulo (Id, Nombre,Descripcion,Precio,Imagen,Stock,temporada,Categoria_id) VALUES (6,'Luca-blanca','Atractiva lámpara de pared Luca con pantalla de cristal blanco. El soporte de pared de esta lámpara decorativa está hecho de metal marrón oscuro, lo que genera un contraste único con respecto a la pantalla de cristal que da a la lámpara un toque rústico y antiguo. La luz se proyecta suavemente y sin deslumbrar por la habitación a través de la pantalla de cristal, mientras ilumina sin impedimento hacia arriba inundando la pared con un reflejo de luz brillante.',77,'https://lw-cdn.com/images/D9963761E243/k_f8a7d8b0a190c36347dbba136cee5b27;w_1600;h_1600;q_70/lampara-de-pared-luca-de-cristal-rustica-blanca.webp',40,'Clasico',0);

  INSERT INTO Articulo (Id, Nombre,Descripcion,Precio,Imagen,Stock,temporada,Categoria_id) VALUES (7,'monstera','El verde vuelve a los hogares y cobra muchísimo protagonismo a través de la tendencia Urban Jungle. Las plantas contribuyen a que las estancias luzcan mucho más frescas y llenas de vida. Fabricada en plástico la Planta Artificial Monstera parecerá verdadera sin el mantenimiento que necesitan las plantas naturales. La monstera es la planta artificial del momento junto al helecho y al cactus. Llena los rincones de cualquier estancia de tu hogar ya que encajará perfectamente con cualquier estilo decorativo aportando luminosidad. Con un toque boho, podrás incluirla en tu salón, baño o dormitorio, sírvete de muebles, accesorios decorativos y texturas para que resalten todavía más. Aconsejamos para su limpieza el uso de un paño húmedo y evitar el uso de productos químicos. La planta se presenta con una maceta negra de plástico. Los maceteros que puedan aparecer en la imagen no están incluidos.',135,'https://cdn.sklum.com/es/875214/planta-artificial-monstera.jpg?cf-resize=gallery',30,'Clasico',0);


   /*Moderno*/


  INSERT INTO Articulo (Id, Nombre,Descripcion,Precio,Imagen,Stock,temporada,Categoria_id) VALUES (8,'Sweep','Sabemos que te encantan las piezas llamativas a buen precio. Por eso hemos diseñado la lámpara de pie Sweep para que llame la atención y sea asequible. Queda genial sobre una mesa de comedor, un sofá o un sillón de lectura.',129,'https://img.made.com/image/upload/c_pad,d_madeplusgrey.svg,f_auto,w_982,dpr_2.0,q_auto:good,b_rgb:f5f6f4/v4/catalog/product/asset/c/a/c/e/cacec5195cad86b692ae2b804bbd62bb3f41903a_FLPSWE007BLA_UK_Sweep_Arc_Overreach_Floor_Lamp_Matt_Black_Copper_ar3_2_LB02_LS.jpg',25,'Moderno',0);

  INSERT INTO Articulo (Id, Nombre,Descripcion,Precio,Imagen,Stock,temporada,Categoria_id) VALUES (9,'PufHaven','Los detalles marcan la diferencia. Ese es el encanto del Puf de terciopelo Haven. El Puf abotonado y los ribetes en contraste son características que marcan la diferencia.',159,'https://static.westwingnow.de/image/upload//simple/81/5511/1186712.jpg',9,'Moderno',0);

  INSERT INTO Articulo (Id, Nombre,Descripcion,Precio,Imagen,Stock,temporada,Categoria_id) VALUES (10,'Sofa-azul','La decoración años 70 se renueva con el sofá de 2/3 plazas de terciopelo azul MISTER. Su estilo Palm Springs luce la recreación de un aire vintage. ¡Las líneas redondeadas son las reinas en el diseño de este sofá! Gracias a su revestimiento de terciopelo, podrás disfrutar de una dulzura a la cabeza de la tendencia actual. Sus patas de acero de color dorado aportan un toque elegante. Para realzar un estilo Riviera, añade unos cojines de colores amarillo pálido y turquesa. Tus momentos de relax en este sofá de diseño tendrán un pequeño gusto estival. ¡No podrás resistirte!',1199,'https://medias.maisonsdumonde.com/image/upload/q_auto,f_auto/w_1000/img/sofa-de-2-3-plazas-de-terciopelo-azul-1000-9-30-188097_9.jpg',5,'Moderno',0);

  INSERT INTO Articulo (Id, Nombre,Descripcion,Precio,Imagen,Stock,temporada,Categoria_id) VALUES (11,'Mesa-noguche ','La mesa de diseño Noguchi está inspirada en la famosa mesa de diseño Noguchi Coffee del diseñador Isamu Noguchi, poeta y escultor de renombre de los años 50. Este hermoso mueble es una representación icónica de dos líneas rectas, con curvas finas llamadas “lágrimas” que se complementan con la suave textura de la base de madera. Es una magnífica obra de arte con una gran elegancia y presencia adecuándose perfectamente a su espacio.',299,'https://www.muebledesign.com/img/cms/mesa-noguche-coffe-mueble-design.jpg',14,'Moderno',0);


  /*Exterior*/

  INSERT INTO Articulo (Id, Nombre,Descripcion,Precio,Imagen,Stock,temporada,Categoria_id) VALUES (12,'Outsunny','Mecedora rustica de madera ideal para decorar desde porches a balcones. Dotando al espacio de mucho carácter propio. Reposabrazos muy originales en forma de rueda. Además de bonitos resultan muy prácticos para colocar los brazos mientras te relajas con su balanceo. Respaldo alto para dar un buen soporte a tu espalda mientras descansas al aire libre.',158,'https://eus3.aosomcdn.com/es/catalog/product/6/5/655759d03fb5c36bd6158f767bbde756_1.jpg',9,'Interior',1);

  INSERT INTO Articulo (Id, Nombre,Descripcion,Precio,Imagen,Stock,temporada,Categoria_id) VALUES (13,'CORATO','Este conjunto de jardín brinda comodidad, practicidad y estilo. Con dos grandes asientos dobles y un asiento de esquina generosamente acolchado, tiene capacidad para cinco personas, por lo que es la solución perfecta para fiestas en el jardín y reuniones sociales. El marco robusto está hecho de acero en un delicado tono gris, con un diseño exterior sofisticado hecho de madera de acacia pulida. Con mucho espacio para accesorios o decoraciones y elegantes cojines de respaldo, este conjunto contemporáneo puede ser la pieza central de cualquier patio, terraza o jardín moderno.',1319,'https://pictureserver.net/images/pic/c9/e0/undef_src_sa_picid_797775_x_1000_type_color_image.jpg?ver=8',5,'Moderno',1);

  INSERT INTO Articulo (Id, Nombre,Descripcion,Precio,Imagen,Stock,temporada,Categoria_id) VALUES (14,'Oceana','Una tumbona de ensueños en un exterior de ensueños. Con la tumbona grande Ocena, pasaras más tiempo en tu jardín, leer libros, tomarte una siesta o incluso tumbarte y contemplar el paisaje. Disfrutaras de todo tipo de pasatiempos en esta tumbona de lujo ultra cómoda. Una compra de la que no te arrepentirás.',1700,'https://www.arteleya.es/media/catalog/product/cache/af0544a5658ce96f8bcab9d1e8dbb4f8/1/1/11834_oceana_daybed_terasse_2k.jpg',3,'Moderno',1);

  INSERT INTO Articulo (Id, Nombre,Descripcion,Precio,Imagen,Stock,temporada,Categoria_id) VALUES (15,'resina-trenzada','¿Quieres conseguir un exterior elegante y natural? Con el sillón redondo gris St Raphael tu jardín se llenará de una suave atmósfera zen. Este sillón de resina trenzada se convertirá en un perfecto sillón de salón de jardín cómodo. Este sillón de jardín sobrio y moderno también está disponible en sillón redondo blanco. ¿Se acerca el invierno? ¡Para preservar tu mueble de jardín, no te olvides de cubrirlo con una de nuestras fundas de protección de lona impermeable y resistentes a los rayos UV! Será un placer encontrarlos intactos con el regreso del buen tiempo.',399,'https://medias.maisonsdumonde.com/image/upload/q_auto,f_auto/w_1000/img/sillon-de-jardin-de-resina-trenzada-1000-5-27-110522_4.jpg',15,'sencillo',1);

insert into dbo.oferta (cod,descuento,fechaValidez,Articulo_id) values (0,23.90,2021-7-11,0);
insert into dbo.oferta (cod,descuento,fechaValidez,Articulo_id) values (1,33.33,2022-11-7,3);
insert into dbo.oferta (cod,descuento,fechaValidez,Articulo_id) values (2,17.50,2021-9-21,7);
insert into dbo.oferta (cod,descuento,fechaValidez,Articulo_id) values (3,50.00,2023-9-27,11);

insert into dbo.comentario (id,comentario,valoracion,Articulo_id,Usuario_correo) values (0,'Increible sillon.Muy comodo y confortable',4,15,'dbm39@gmail.com');
insert into dbo.comentario (id,comentario,valoracion,Articulo_id,Usuario_correo) values (1,'modesta tumbona.No vale la pena por su precio',2,14,'pepo@gmail.com');
insert into dbo.comentario (id,comentario,valoracion,Articulo_id,Usuario_correo) values (2,'La mejor compra que he hecho en mucho tiempo',5,13,'dbm39@gmail.com');
insert into dbo.comentario (id,comentario,valoracion,Articulo_id,Usuario_correo) values (3,'Mecedora muy poco duradera.Se rompio a los 3 dias de estrenarla',1,12,'willyrex@gmail.com');
insert into dbo.comentario (id,comentario,valoracion,Articulo_id,Usuario_correo) values (4,'El nombre de la mesa es increible,la mesa ya no tanto',3,11,'dbm39@gmail.com');
insert into dbo.comentario (id,comentario,valoracion,Articulo_id,Usuario_correo) values (5,'El terciopelo se mancha y desgarra con demasiada facilidad',2,10,'pepo@gmail.com');
insert into dbo.comentario (id,comentario,valoracion,Articulo_id,Usuario_correo) values (6,'Puf muy comodo y poco pesado',4,9,'pepo@gmail.com');
insert into dbo.comentario (id,comentario,valoracion,Articulo_id,Usuario_correo) values (7,'Tiene tanta potencia que parece un foco.Encantado con la compra',5,8,'dbm39@gmail.com');
insert into dbo.comentario (id,comentario,valoracion,Articulo_id,Usuario_correo) values (8,'Planta que esta bien para su precio,pero un poco sosa',3,7,'profegod@gmail.com');
insert into dbo.comentario (id,comentario,valoracion,Articulo_id,Usuario_correo) values (9,'La lampara me da problemas a la hora de encender la luz',1,6,'profegod@gmail.com');
insert into dbo.comentario (id,comentario,valoracion,Articulo_id,Usuario_correo) values (10,'Un cuadro muy bonito',4,5,'profegod@gmail.com');
insert into dbo.comentario (id,comentario,valoracion,Articulo_id,Usuario_correo) values (11,'el color del sillon es horrible,pero es comodo',3,4,'willyrex@gmail.com');
insert into dbo.comentario (id,comentario,valoracion,Articulo_id,Usuario_correo) values (12,'Que es un masako y porque cuesta tanto',2,3,'dbm39@gmail.com');
insert into dbo.comentario (id,comentario,valoracion,Articulo_id,Usuario_correo) values (13,'El tamaño de la libreria es masivo.Un poco mas y me ocupa toda la pared del salon',4,2,'profegod@gmail.com');
insert into dbo.comentario (id,comentario,valoracion,Articulo_id,Usuario_correo) values (14,'Sofa muy comodo y economico',4,1,'pepo@gmail.com');
insert into dbo.comentario (id,comentario,valoracion,Articulo_id,Usuario_correo) values (15,'Un color muy metalizado para mi gusto',2,0,'dbm39@gmail.com');
