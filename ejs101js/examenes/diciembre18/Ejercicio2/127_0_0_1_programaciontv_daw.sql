--
-- Base de datos: `programaciontv_daw`
--
DROP DATABASE IF EXISTS `programaciontv_daw`;
CREATE DATABASE IF NOT EXISTS `programaciontv_daw` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `programaciontv_daw`;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `canal`
--

DROP TABLE IF EXISTS `canal`;
CREATE TABLE `canal` (
  `id` tinyint(3) UNSIGNED NOT NULL,
  `nombre` varchar(20) DEFAULT NULL,
  `url` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `canal`
--

INSERT INTO `canal` (`id`, `nombre`, `url`) VALUES
(1, 'TVE 1', 'tve1.jpg'),
(2, 'TVE 2', 'tve2.jpg'),
(3, 'ANTENA 3', 'antena3.gif'),
(4, 'Cuatro', 'cuatro.gif'),
(5, 'Telecinco', 'telecinco.jpg'),
(6, 'La Sexta', 'lasexta.gif');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `programa`
--

DROP TABLE IF EXISTS `programa`;
CREATE TABLE `programa` (
  `idcanal` tinyint(4) UNSIGNED NOT NULL DEFAULT '0',
  `fecha` date NOT NULL DEFAULT '0000-00-00',
  `hora` time NOT NULL DEFAULT '00:00:00',
  `nombre` varchar(100) DEFAULT NULL,
  `descripcion` mediumtext
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `programa`
--

INSERT INTO `programa` (`idcanal`, `fecha`, `hora`, `nombre`, `descripcion`) VALUES
(1, '2018-03-06', '00:05:00', 'Comando actualidad', '''El infierno de alquilar''. Vivir de alquiler en España es cada vez más caro. En las grandes ciudades hay cada vez más personas que quieren vivir de alquiler y menos casas disponibles. Además, en el centro de las grandes ciudades, los barrios se vacían de vecinos y se llenan de turistas.'),
(1, '2018-03-06', '01:05:00', 'Comando actualidad', '''Para entrar en calor''. El frío invernal es más llevadero con platos calientes y elaborados. Este espacio recorre la geografía española para mostrar diferentes desgustaciones como la pringá, las alubias del Barco de Ávila, el cocido montañés, el gazpacho manchego y el torrezno.'),
(1, '2018-03-06', '02:05:00', 'Comando actualidad', '''De pata negra''. Basta con nombrar el producto para saber su procedencia y viceversa: con sólo evocar un pueblo, viene a la cabeza aquel alimento que elaboran, cultivan o capturan mejor que nadie.'),
(1, '2018-03-06', '03:15:00', 'La noche en 24H', 'Informativo diario presentado por Víctor Arribas que incluye entrevistas y debates sobre diversas cuestiones de actualidad. El programa ofrece la posibilidad de que los espectadores participen opinando sobre las cuestiones debatidas mediante un foro en la web de RTVE.'),
(1, '2018-03-06', '05:15:00', 'Noticias 24 horas', 'Conexión con el canal de noticias 24 horas.'),
(1, '2018-03-06', '06:00:00', 'Noticias 24 horas', 'Conexión con el canal de noticias 24 horas.'),
(1, '2018-03-06', '06:30:00', 'Telediario Matinal', 'Rápido y exhaustivo repaso de todas las noticias de interés general conducido por Diego Losada y Ana Ibáñez. Además, se ofrece la actualidad meteorológica de España y Europa y el estado de la mar'),
(1, '2018-03-06', '08:30:00', 'Los desayunos de TVE', 'Programa de análisis de la actualidad, entrevistas y tertulias. Con Sergio Martín como presentador, el espacio da cabida a las diversas opiniones que expresa su panel de comentaristas, representativo del más amplio abanico de sensibilidades.'),
(1, '2018-03-06', '10:00:00', 'La mañana de La 1', 'Magacín matinal que reúne información de actualidad, entrevistas, reportajes y diversas secciones divulgativas, entre ellas el espacio de salud ''Saber vivir''. Silvia Jato conduce este espacio diario que además da cobertura a las noticias más importantes del día.'),
(1, '2018-03-06', '12:00:00', 'Saber vivir', 'Macarena Berlín presenta este programa sobre salud, que diariamente aborda un tema médico. ''''Saber vivir'''' cuenta con la presencia de varios especialistas según el tema del día que ayudan a resolver las dudas de los espectadores.'),
(1, '2018-03-06', '12:30:00', 'Amigas y conocidas', 'Inés Ballester y Berta Collado capitanean un grupo de mujeres que tratan y analizan una amplia variedad de temas sociales y políticos.'),
(1, '2018-03-06', '13:25:00', 'Torres en la cocina', '''Rape alangostado y berenjenas rellenas''. Un rape alantostinado, cocinado con una marinada de pimentón realmente original y unas berenjenas rellenas ''''de toda la vida'''', pero dándoles una vuelta para convertirlas en un plato nuevo y mucho más atractivo.'),
(1, '2018-03-06', '14:00:00', 'Informativo territorial', 'Desconexión de cada uno de los centros territoriales de TVE que incluye la emisión de su informativo.'),
(1, '2018-03-06', '14:30:00', 'Corazón', 'Magacín rosa que combina información sobre famosos, consejos de belleza, moda y noticias de estrenos teatrales y cinematográficos.'),
(1, '2018-03-06', '15:00:00', 'Telediario 1', 'El noticiario audiovisual más veterano de la historia de la televisión en España. Pilar García Muñiz está al frente de este repaso diario a la actualidad general de España y el mundo. Sergio Sauca le acompaña en el apartado deportivo.'),
(1, '2018-03-06', '16:00:00', 'Informativo territorial', 'Desconexión de cada uno de los centros territoriales de TVE que incluye la emisión de su informativo.'),
(1, '2018-03-06', '16:15:00', 'El tiempo', 'Previsión meteorológica para los próximos días.'),
(1, '2018-03-06', '16:25:00', 'Servir y proteger', 'Alicia intenta asimilar la difícil verdad sobre su hermano mientras Julio no comprende qué ha pasado. Jairo, mientras tanto, descubre que Paty ha dado calabazas a David. Fede, paralelamente, quiere compartir piso con Espe y Lola. Finalmente, Iker y Nerea se acuestan.'),
(1, '2018-03-06', '17:15:00', 'Acacias, 38', 'Silvia acepta la propuesta de Zavala e intuye que algo importante planea con Tamayo. Mientras tanto, Rosina tiene un ataque de gota e insta a Liberto a ir a la ópera con Flora. Al mismo tiempo, hay una serie de altercados en la mina y los Alday temen por Diego. Leonor, por su parte, le da una información secreta a Blanca sobre el yacimiento.'),
(1, '2018-03-06', '18:10:00', 'Centro médico', 'A través de algunos actores, que interpretan a médicos y enfermeras, se recrean historias basadas en casos clínicos reales, curiosos y atractivos. (Empezó hace 20'')'),
(1, '2018-03-06', '19:25:00', 'España directo', 'Magacín informativo muy en contacto con los temas sociales que incluye conexiones con todos los rincones de la geografía nacional. El programa pretende acercarse al espectador gracias a la abundancia de intervenciones en directo y a la espontaneidad de sus reporteros. (Empieza dentro de 55'')'),
(1, '2018-03-06', '20:30:00', 'Aquí la Tierra', 'Jacob Petrus ofrece una original mirada sobre el territorio y sus habitantes a través de la meteorología. La divulgación y la información sobre el terreno conviven con el descubrimiento de la naturaleza y el medio ambiente.'),
(1, '2018-03-06', '21:00:00', 'Telediario 2', 'Ana Blanco da la cara por los cientos de profesionales de TVE que salen cada día a la calle en busca de noticias. El resultado, un completo repaso a la actualidad nacional e internacional. Jesús Álvarez se ocupa de presentar la parcela deportiva.'),
(1, '2018-03-06', '21:50:00', 'El Tiempo', 'Información meteorológica.'),
(1, '2018-03-06', '22:05:00', 'Hora punta', 'Javier Cárdenas conduce un espacio que combina entrevistas y reportajes. El presentador cuenta con la participación de colaboradores que ponen el toque de humor al programa.'),
(1, '2018-03-06', '22:35:00', 'Cine Una historia de venganza', 'Dir: Elliott Lester. Int: Arnold Schwarzenegger, Scoot McNairy, Maggie Grace, Kevin Zegers, Hannah Ware, Glenn Morshower, Mariana Klaveno, Mo McRae, Theresa Cook (Thriller, EE.UU., 2017) [Tráiler]'),
(1, '2018-03-08', '00:05:00', 'Ochéntame otra vez', 'Un retrato nostálgico a la España de la década de 1980. El programa recurre a imágenes de archivo y al testimonio de personas significativas, tanto de los que protagonizaron la vida del momento como de los que nacieron en aquellos años y hoy son referencia en su ámbito.'),
(1, '2018-03-08', '01:00:00', 'Ochéntame otra vez', 'Un retrato nostálgico a la España de la década de 1980. El programa recurre a imágenes de archivo y al testimonio de personas significativas, tanto de los que protagonizaron la vida del momento como de los que nacieron en aquellos años y hoy son referencia en su ámbito.'),
(1, '2018-03-08', '01:55:00', 'La noche en 24H', 'Informativo diario presentado por Víctor Arribas que incluye entrevistas y debates sobre diversas cuestiones de actualidad. El programa ofrece la posibilidad de que los espectadores participen opinando sobre las cuestiones debatidas mediante un foro en la web de RTVE.'),
(1, '2018-03-08', '03:50:00', 'Noticias 24H', 'Noticias de los servicios informativos del Canal 24 Horas. Producido por Televisión Española, este canal está dedicado íntegramente a ofrecer información de actualidad y es el más antiguo de los canales de este tipo en España.'),
(1, '2018-03-08', '06:00:00', 'Noticias 24H', 'Noticias de los servicios informativos del Canal 24 Horas. Producido por Televisión Española, este canal está dedicado íntegramente a ofrecer información de actualidad y es el más antiguo de los canales de este tipo en España.'),
(1, '2018-03-08', '06:30:00', 'Telediario Matinal', 'Rápido y exhaustivo repaso de todas las noticias de interés general conducido por Diego Losad1'),
(1, '2018-03-08', '08:30:00', 'Los desayunos de TVE', 'Programa de análisis de la actualidad, entrevistas y tertulias. Con Sergio Martín como presentador, el espacio da cabida a las diversas opiniones que expresa su panel de comentaristas, representativo del más amplio abanico de sensibilidades.'),
(1, '2018-03-08', '10:00:00', 'La mañana de La 1', 'Magacín matinal que reúne información de actualidad, entrevistas, reportajes y diversas secciones divulgativas, entre ellas el espacio de salud ''Saber vivir''. María Casado conduce este espacio diario que además da cobertura a las noticias más importantes del día.'),
(1, '2018-03-08', '12:00:00', 'Saber vivir', 'Macarena Berlín presenta este programa sobre salud, que diariamente aborda un tema médico. ''''Saber vivir'''' cuenta con la presencia de varios especialistas según el tema del día que ayudan a resolver las dudas de los espectadores.'),
(1, '2018-03-08', '12:30:00', 'Amigas y conocidas', 'Inés Ballester y Berta Collado capitanean un grupo de mujeres que tratan y analizan una amplia variedad de temas sociales y políticos.'),
(1, '2018-03-08', '13:25:00', 'Torres en la cocina', 'Los chefs Javier y Sergio Torres abren su cocina para enseñar a preparar recetas originales, sabrosas y asequibles. Una mezcla de tradición y modernidad en la que los gemelos recuperan los sabores y recuerdos de la infancia reinterpretados según nuestro tiempo.'),
(1, '2018-03-08', '14:00:00', 'Informativo territorial', 'Espacio dedicado a la información autonómica.'),
(1, '2018-03-08', '14:30:00', 'Corazón', 'Magazine que ofrece toda la actualidad de la crónica social acompañada de reportajes sobre moda, belleza y cultura, con especial interés a los eventos de alta costura y las novedades de las firmas de diseñadores españoles.'),
(1, '2018-03-08', '15:00:00', 'Telediario 1', 'El noticiario audiovisual más veterano de la historia de la televisión en España. Pilar García Muñiz está al frente de este repaso diario a la actualidad general de España y el mundo. Sergio Sauca le acompaña en el apartado deportivo.'),
(1, '2018-03-08', '16:00:00', 'Informativo territorial', 'Resumen Desconexión de cada uno de los centros territoriales de TVE que incluye la emisión de su informativo.'),
(1, '2018-03-08', '16:15:00', 'El tiempo', 'La mejor manera de enterarse de la previsión meteorológica para los próximos días. La información del tiempo de Televisión Española es un clásico de la historia audiovisual española. Avalada por el Instituto Nacional de Meteorología, goza de un alto nivel de acierto.'),
(1, '2018-03-08', '16:25:00', 'Servir y proteger', 'Lola y Espe siguen investigando los posibles malos tratos a Palmira. Gracias a Jesús, las policías descubren que el agresor podría ser Bruno, el hijo de la mujer. Alicia, por su parte, va a descubrir algo que va a cambiar su vida para siempre.'),
(1, '2018-03-08', '17:20:00', 'Acacias 38', 'Úrsula le encomienda a Riera que siga con su investigación. Mientras tanto, Martín ultima los detalles para su pedida y Casilda empieza a dudar de él. Silvia, por su parte, le entrega a Arturo el tarjetón de bodas. Finalmente, Blanca se rebela contra su madre y pone a Samuel en su lugar.'),
(1, '2018-03-08', '18:15:00', 'Centro médico', 'A través de algunos actores, que interpretan a médicos y enfermeras, se recrean historias basadas en casos clínicos reales,curiosos y atractivos.'),
(1, '2018-03-08', '19:25:00', 'España directo', 'Magazine conducido por Roberto Leal y Sandra Daviú en el apartado de sociedad. En cada edición se hará un recorrido por la geografía española para ofrecer a los espectadores la actualidad informativa desde el lugar dónde se produce la noticia.'),
(1, '2018-03-08', '20:30:00', 'Aquí la Tierra', 'Jacob Petrus, geógrafo especializado en climatología, nos da una nueva visión de nuestro planeta y demuestra cómo la salud, la arquitectura, la conducta, incluso el arte o la economía, pueden estar condicionados por la meteorología.'),
(1, '2018-03-08', '21:00:00', 'Telediario 2', 'Ana Blanco da la cara por los cientos de profesionales de TVE que salen cada día a la calle en busca de noticias. El resultado, un completo repaso a la actualidad nacional e internacional. Jesús Álvarez se ocupan de presentar la parcela deportiva.'),
(1, '2018-03-08', '21:50:00', 'El Tiempo', 'Información meteorológica.'),
(1, '2018-03-08', '22:05:00', 'Hora punta', 'Javier Cárdenas conduce un espacio que combina entrevistas y reportajes. El presentador cuenta con la participación de colaboradores que ponen el toque de humor al programa.'),
(1, '2018-03-08', '22:40:00', 'Cuéntame cómo pasó', '''Perdonar es fácil, si sabes cómo''. Los Alcántara se unen con el objetivo de agasajar a Paquita y conseguir que les perdone.'),
(2, '2018-03-06', '00:40:00', 'La 2 Noticias', 'Espacio informativo de La 2 que cada día nos trae la actualidad más destacada desde otro punto de vista, centrado sobre todo en noticias sociales, culturales y científicas. También ofrece entrevistas con personajes de interés para ahondar en alguno de los temas de actualidad tratados en el informativo.'),
(2, '2018-03-06', '01:05:00', 'Documental', '''Mujeres que hicieron historia: Juana de Arco''. Juana de Arco estaba profundamente convencida de su misión divina; con tan sólo 17 años condujo a los franceses a la victoria en Orleans contra los ingleses. Al final fue víctima del rígido sistema político y social medieval. En 1431 murió en la hoguera en Rouen.'),
(2, '2018-03-06', '01:55:00', 'Conciertos de Radio-3', '''Marinah''. Programa que recoge la actuación de algún cantante, grupo o instrumentista del más actual panorama musical, con predominio de artistas españoles y latinos. El objetivo es abrir las puertas a aquellos artistas y grupos que existen al margen de las listas de ventas.'),
(2, '2018-03-06', '02:20:00', 'Documenta2', '''Las princesas americanas del millón de dólares''. Winnaretta Singer emergió de una infancia difícil hasta convertirse en una mecenas de la música. La originalidad de Sarah Murphy la convirtieron en musa de artistas y, Peggy Guggenheim fue una campeona del modernismo, mostró al público el revolucionario arte moderno.'),
(2, '2018-03-06', '03:05:00', 'Documental', '''Las tribus y yo: el pueblo Anaconda del Amazonas''. Gordon Buchanan viaja a la selva amazónica para conocer a los Huorani y aprender de su estrecha relación con el entorno, algunos secretos de los animales.'),
(2, '2018-03-06', '04:00:00', 'Documental', '''Biebzra - el Amazonas europeo''. Protegido por el parque nacional más grande de Polonia, el río Biebrza y sus lagunas son uno de los refugios naturales más importantes de Europa. Mamíferos, aves, anfibios, insectos y peces se muestran de una manera nunca antes vista en la llamada Amazonia europea.'),
(2, '2018-03-06', '04:50:00', 'Conciertos de Radio-3', 'Programa que recoge la actuación de algún cantante, grupo o instrumentista del más actual panorama musical, con predominio de artistas españoles y latinos. El objetivo es abrir las puertas a aquellos artistas y grupos que existen al margen de las listas de ventas.'),
(2, '2018-03-06', '06:00:00', 'Conciertos de Radio-3', 'Programa que recoge la actuación de algún cantante, grupo o instrumentista del más actual panorama musical, con predominio de artistas españoles y latinos. El objetivo es abrir las puertas a aquellos artistas y grupos que existen al margen de las listas de ventas.'),
(2, '2018-03-06', '06:30:00', 'That''s English', 'Programa divulgativo que ofrece un curso de inglés a distancia, creado por el Ministerio de Educación en colaboración con la BBC británica y Televisión Española. El curso permite obtener el Certificado del Ciclo Elemental de la Escuela Oficial de Idiomas.'),
(2, '2018-03-06', '07:00:00', '¡Qué animal!', '''Desierto de Tabernas''. Tabernas es el único espacio natural en Europa considerado desierto. Su superficie aloja animales como el lirón careto, el escorpión amarillo o el abejaruco. La chef Carme Ruscalleda enseñará el uso de la salicornia europea en la cocina, una planta típica del lugar.'),
(2, '2018-03-06', '07:30:00', 'Inglés Online', 'Curso de ingles de Televisión Española para hisponoparlantes.'),
(2, '2018-03-06', '08:00:00', 'Documental', '''Meganaturaleza''. Muchas veces sobrevivir a la naturaleza requiere convivir en grupo para no ser devorados y poder alimentarse. Este espacio muestra los diferentes rebaños de mamíferos, bancos de peces, enjambres de abejas o bandadas de pájaros que realizan esta táctica.'),
(2, '2018-03-06', '09:00:00', 'España en comunidad', 'Programa que ofrece reportajes en profundidad e información de actualidad sobre las distintas comunidades autónomas españolas. Está realizado por los centros territoriales y de producción de TVE, aunque cuenta con una pequeña redacción en Madrid.'),
(2, '2018-03-06', '09:30:00', 'Aquí hay trabajo', 'Un espacio que resume la actualidad del mundo laboral, con información sobre su situación, sobre becas y cursos de formación. Todo apoyado con invitados especialistas. Además, el programa muestra ofertas de empleo a las que pueden acceder los televidentes.'),
(2, '2018-03-06', '09:55:00', 'La aventura del saber', 'Programa diario matinal destinado a la formación educativa y la divulgación mediante entrevistas y series documentales. Coproducido por RTVE y el Ministerio de Educación, se trata de uno de los espacios más veteranos de la cadena, con más de 21 años en antena.'),
(2, '2018-03-06', '10:50:00', 'Documental', '''Los primeros hombres: África''. Hace 200.000 años, el homo sapiens apareció por primera vez en las llanuras de África. Pero los últimos estudios demuestran que no procedemos de una única especie sino que somos el resultado de la interacción entre diversas especies.'),
(2, '2018-03-06', '11:45:00', 'Documenta2', '''El imperio de los zares: La era de los extremos''. En el magnífico palacio de Peterhof cerca de San Petersburgo, Lucy muestra el ascenso meteórico de Catalina la Grande, quien se apoderó del trono ruso de su marido Pedro III en 1762 y se convirtió en la mujer más poderosa del mundo.'),
(2, '2018-03-06', '12:35:00', 'Mañanas de Cine Reverendo Colt Dir: León Klimovsky.', 'Int: Guy Madison, Richard Harrison , Ennio Girolami, María Martín , Germán Cobos, Ignazio Spalla, Steven Tedd, Perla Cristal, Alfonso Rojas (Oeste, España - Italia, 1970)'),
(2, '2018-03-06', '13:50:00', 'Documental Mercados', ':en el vientre de la ciudad.'),
(2, '2018-03-06', '14:55:00', 'Documental', '''Grandes viajes ferroviarios continentales: De la Selva Negra hasta Hannover''. Con su Guía Bradshaw de 1913 siempre en la mano, Michael Portillo se adentra en la Selva Negra para intentar dar con la esencia de Alemania, y descubre que Hansel y Gretel ayudaron a unificar la nación. Su viaje termina en la ciudad de Hannover.'),
(2, '2018-03-06', '15:50:00', 'Saber y ganar', 'Programa concurso en el que tres concursante participan en diversas pruebas demostrando sus conocimientos y agilidad mental.'),
(2, '2018-03-06', '16:30:00', 'Grandes documentales', 'Las islas Canarias.'),
(2, '2018-03-06', '17:20:00', 'Grandes documentales', '''Una manada en guerra''. El delta del Okawando, un entorno hostil y salvaje, es un territorio habitado por manadas de leones en conflicto. En Xakanada, dos poderosos machos lideran una manada que se ha especializado en matar búfalos cafre, una de las presas más combativas de África.'),
(2, '2018-03-06', '18:10:00', 'Documenta2', '''Las princesas americanas del millón de dólares''. A finales del s.XIX, Inglaterra tuvo una fuerte depresión agrícola y los empobrecidos aristócratas buscaron una nueva oportunidad casándose con las ricas herederas estadounidenses. McGovern muestra cómo eran estas mujeres, que le sirvieron para inspirarse como actriz. (Empezó hace 22'')'),
(2, '2018-03-06', '19:05:00', 'Documental', '''Mercados, en el vientre de la ciudad: Amsterdam''. Uno de los mercados más antiguos de Ámsterdam es el Albert Cuyp Markt, un mercado callejero que se extiende a lo largo del barrio De Pijp. Aquí podemos disfrutar de los mejores arenques de la ciudad, y luego hacer un viaje a Gouda para buscar la receta de Stroopwafels. (Empieza dentro de 33'')'),
(2, '2018-03-06', '20:00:00', 'Concierto víctimas del terrorismo', 'Desde el Auditorio Nacional de Música y organizado por la Fundación Víctimas del Terrorismo, se emite este concierto de la orquesta sinfónica RTVE, con la soprano Milagros Poblador, la mezzosoprano Diletta Scandiuzzi, el barítono Samuel Youn y el tenor José Pazos.'),
(2, '2018-03-06', '21:30:00', 'Página 2', '''Leonardo Padura''. Leonardo Padura nos presenta ''La transparecia del tiempo'', su última obra. En el reportaje, Libu: la fantástia labor de esta librería. Además, James Ellroy responde al cuestionario y conocemos la Biblioteca de la Sociedad Bilbaína.'),
(2, '2018-03-06', '21:55:00', 'Historia de nuestro cine', 'Vida perra Dir: Javier Aguirre. Int: Esperanza Roy (Drama, España, 1982)'),
(2, '2018-03-06', '23:45:00', 'Documentos Tv', '''La poetisa''. Una mujer desafía al gobierno saudí recitando poemas en el ''reality show'' de mayor audiencia de Oriente Próximo. Hissa Helal, la primera mujer participante del concurso de poesía árabe “El poeta del millón” ha convertido su recital en un alegato político contra la intransigencia religiosa y social hacia las mujeres saudíes. Sus críticas en defensa de los derechos usurpados a las mujeres'),
(2, '2018-03-08', '00:15:00', 'Conecta con el mercado', 'Espacio que muestra información sobre la actividad de las empresas españolas en el exterior. Esta segunda temporada está orientada a sensibilizar y motivar a los emprendedores sobre la necesidad y las ventajas de la internacionalización.'),
(2, '2018-03-08', '00:45:00', 'La 2 Noticias', 'Espacio informativo de La 2 que cada día nos trae la actualidad más destacada desde otro punto de vista, centrado sobre todo en noticias sociales, culturales y científicas. También ofrece entrevistas con personajes de interés para ahondar en alguno de los temas de actualidad tratados en el informativo.'),
(2, '2018-03-08', '01:15:00', 'Conecta con el mercado', 'Espacio que muestra información sobre la actividad de las empresas españolas en el exterior. Esta segunda temporada está orientada a sensibilizar y motivar a los emprendedores sobre la necesidad y las ventajas de la internacionalización.'),
(2, '2018-03-08', '01:45:00', 'Documental', 'Serie de documentales.'),
(2, '2018-03-08', '02:30:00', 'Conciertos de Radio-3', 'Programa que recoge la actuación de algún cantante, grupo o instrumentista del más actual panorama musical, con predominio de artistas españoles y latinos. El objetivo es abrir las puertas a aquellos artistas y grupos que existen al margen de las listas de ventas.'),
(2, '2018-03-08', '03:00:00', 'Documental', 'Serie de documentales.'),
(2, '2018-03-08', '04:00:00', 'Documental', 'Serie de documentales.'),
(2, '2018-03-08', '04:55:00', 'Documental', 'Serie de documentales.'),
(2, '2018-03-08', '05:45:00', 'Conciertos de Radio-3', 'Programa que recoge la actuación de algún cantante, grupo o instrumentista del más actual panorama musical, con predominio de artistas españoles y latinos. El objetivo es abrir las puertas a aquellos artistas y grupos que existen al margen de las listas de ventas.'),
(2, '2018-03-08', '06:30:00', 'That''s English', 'Programa divulgativo que ofrece un curso de inglés a distancia, creado por el Ministerio de Educación en colaboración con la BBC británica y Televisión Española. El curso permite obtener el Certificado del Ciclo Elemental de la Escuela Oficial de Idiomas.'),
(2, '2018-03-08', '07:00:00', 'Zoom tendencias', 'Espacio semanal dedicado a destacar y analizar el estilo de vida actual proponiendo reportajes de interiorismo, moda, restauración o cosmética. Aquellas tendencias que marcan la forma de ser hoy en día, serán tratadas en el programa.'),
(2, '2018-03-08', '07:30:00', 'Inglés Online', 'Curso de ingles de Televisión Española para hisponoparlantes.'),
(2, '2018-03-08', '08:00:00', 'Documental', 'Serie de documentales.'),
(2, '2018-03-08', '09:00:00', 'Pueblo de Dios', 'Programa religioso que ofrece reportajes sobre el trabajo que realizan las ONG o comunidades religiosas en España y en el mundo. Retrata los proyectos que se desarrollan en el campo de la educación y la salud para ayudar a las capas sociales más necesitadas.'),
(2, '2018-03-08', '09:30:00', 'Aquí hay trabajo', 'Un espacio que resume la actualidad del mundo laboral, con información sobre su situación, sobre becas y cursos de formación. Todo apoyado con invitados especialistas. Además, el programa muestra ofertas de empleo a las que pueden acceder los televidentes.'),
(2, '2018-03-08', '09:55:00', 'La aventura del saber', 'Programa diario matinal destinado a la formación educativa y la divulgación mediante entrevistas y series documentales. Coproducido por RTVE y el Ministerio de Educación, se trata de uno de los espacios más veteranos de la cadena, con más de 21 años en antena.'),
(2, '2018-03-08', '10:50:00', 'Documental', '''Los primeros hombres''.'),
(2, '2018-03-08', '11:45:00', 'Documenta2', '''El imperio de los zares''.'),
(2, '2018-03-08', '12:45:00', 'Mañanas de Cine', 'Título por determinar.'),
(2, '2018-03-08', '14:45:00', 'Documental', 'Mercados: en el vientre de la ciudad.'),
(2, '2018-03-08', '15:40:00', 'Saber y ganar', 'Programa concurso en el que tres concursante participan en diversas pruebas demostrando sus conocimientos y agilidad mental.'),
(2, '2018-03-08', '16:30:00', 'Grandes documentales', 'Serie de documentales.'),
(2, '2018-03-08', '17:25:00', 'Grandes documentales', 'Serie de documentales.'),
(2, '2018-03-08', '18:10:00', 'Documenta2', 'Las princesas americanas del millón de dólares.'),
(2, '2018-03-08', '19:00:00', 'Documental', '''Mercados: en el vientre de la ciudad''.'),
(2, '2018-03-08', '19:50:00', 'Documental', 'Las tribus y yo.'),
(2, '2018-03-08', '20:50:00', 'Días de cine', 'Espacio que recoge la actualidad cinematográfica española e internacional desgranando los estrenos de la cartelera. El programa se hace eco, también, de lo que acontece en los festivales y repasa la trayectoria de actores y directores clave del séptimo arte.'),
(2, '2018-03-08', '22:00:00', 'Carnaval Internacional de Maspalomas 2018', '''Gala Drag Queen Maspalomas''. Del 2 al 11 de marzo, la localidad canaria de Maspalomas se viste de mil colores para celebrar su carnaval. Durante más de una semana, rondallas, murgas y comparsas recorren las calles del municipio dejando a su paso un ambiente de fiesta en general.'),
(6, '2018-03-08', '06:00:00', 'Conciertos de Radio-3', 'Programa que recoge la actuación de algún cantante, grupo o instrumentista del más actual panorama musical, con predominio de artistas españoles y latinos. El objetivo es abrir las puertas a aquellos artistas y grupos que existen al margen de las listas de ventas.'),
(3, '2018-03-06', '00:15:00', 'Cine', 'Torrente, el brazo tonto de la ley Dir: Santiago Segura. Int: Santiago Segura, Javier Cámara, Neus Asensi, Chus Lampreave, Tony Leblanc (Comedia, España, 1998)'),
(3, '2018-03-06', '01:45:00', 'Cine', 'Última salida Dir: John Fawcett. Int: Andrea Roth, Cathleen Robertson, Linden Ashby, Rachael Crawford (Intriga, EE.UU., 2006)'),
(3, '2018-03-06', '03:00:00', 'Campeonato europeo de póker', 'Campeonato europeo de póker televisado en Ganing Casino que emite las partidas de los mejores jugadores internacionales.'),
(3, '2018-03-06', '03:30:00', 'Comprando en casa', 'Espacio de teletienda.'),
(3, '2018-03-06', '04:00:00', 'Minutos musicales', 'Música en directo interpretada por artistas de primer nivel. Un espacio pensado y diseñado para los amantes de la música...'),
(3, '2018-03-06', '06:00:00', 'Minutos musicales', 'Música en directo interpretada por artistas de primer nivel. Un espacio pensado y diseñado para los amantes de la música...'),
(3, '2018-03-06', '06:15:00', 'Las noticias de la mañana', 'Esther Vaquero, Lorena García y María José Sáez son las encargadas de traer las noticias de ámbito nacional e internacional a primera hora de la mañana.'),
(3, '2018-03-06', '08:30:00', 'Un café con Susana', 'Espacio en el que Susana Griso entrevista al protagonista del día. La presentadora se sienta para conversar con personajes de la actualidad política, social y cultural con el fin de aportar al espectador información contada en primera persona.'),
(3, '2018-03-06', '09:00:00', 'Espejo público', 'El protagonismo de este magacín matinal presentado por Susanna Griso es del público, la calle y los directos.'),
(3, '2018-03-06', '13:15:00', 'Karlos Arguiñano en tu cocina', 'Con Karlos Arguiñano nos lo vamos a pasar en grande mientras aprendemos un poco más los secretos de la cocina. Platos sencillos y muy ricos para todos los bolsillos que nos harán nuestra vida mucho más sencilla.'),
(3, '2018-03-06', '13:40:00', 'La ruleta de la suerte', 'Concurso presentado por Jorge Fernández, de lunes a viernes, que pone a prueba la agilidad mental, los reflejos y los conocimientos de los participantes.'),
(3, '2018-03-06', '15:00:00', 'Noticias 1', 'María Rey y Sandra Golpe te esperan de lunes a viernes a las 15:00 h. Una cita con la información nacional e internacional.'),
(3, '2018-03-06', '15:45:00', 'Deportes 1', 'Rocío Martínez se encarga de presentar el espacio dedicado a las noticias de deportes.'),
(3, '2018-03-06', '16:00:00', 'Tu Tiempo', 'Información meteorológica. Con Roberto Brasero.'),
(3, '2018-03-06', '16:30:00', 'Amar es para siempre', 'El seguro médico exige una evaluación psiquiátrica a Ortega. Algo que el hombre no acepta. Javier hace un último intento de luchar por Susana sin el resultado esperado. Charo le traslada a María las sospechas de que Belén es su hija. Arrastrada por Emilio Losada, Luisita acaba metida en un grave problema.'),
(3, '2018-03-06', '17:30:00', 'El secreto de Puente Viejo', 'Julieta llega de la mano de su abuela a Puente Viejo con el objetivo de labrarse un futuro y echar raíces, al fin, en un lugar. Por otro lado, los hermanos Ortega, salvadores de Francisca Montenegro, vivirán bajo el amparo de una de las mujeres más importantes e influyentes del (Hace más de 1 hora que empezó)'),
(3, '2018-03-06', '18:45:00', '¡Ahora caigo!', 'Presentado por Arturo Valls. Es un concurso tan impredecible que la tierra se abrirá bajo tus pies. Un formato revolucionario que une el suspense de una batalla de preguntas con un elemento sorpresa: el puro azar. (Empieza dentro de 13'')'),
(3, '2018-03-06', '20:00:00', 'Uefa Champions League', 'Previo.'),
(3, '2018-03-06', '20:45:00', 'Uefa Champions League', 'París Saint Germain - Real Madrid.'),
(3, '2018-03-06', '22:40:00', 'Cuerpo de élite', '''El fútbol cuerpo de élite''. El Gobierno decide tomar medidas drásticas: hasta que todos los clubes no paguen su deuda, la Liga queda paralizada. Esta decisión sume el país en un caos y acaba con el intento de asesinato del Ministro de Hacienda. Cuerpo de Élite debe detener al culpable antes de que sea demasiado tarde.'),
(3, '2018-03-07', '00:15:00', 'Cine', 'El Inocente Dir: Brad Furman. Int: Matthew McConaughey, Marisa Tomei, Ryan Phillippe, William H. Macy, John Leguizamo, Michael Pena, Trace Adkins, Katherine Moennig, Erin Carufel (Intriga, EE.UU., 2011) [Tráiler]'),
(3, '2018-03-07', '02:30:00', 'Comprando en casa', 'Espacio de teletienda.'),
(3, '2018-03-07', '03:00:00', 'Minutos musicales', 'Música en directo interpretada por artistas de primer nivel. Un espacio pensado y diseñado para los amantes de la música...'),
(3, '2018-03-07', '06:15:00', 'Noticias de la mañana', 'Esther Vaquero, Lorena García y María José Sáez son las encargadas de traer las noticias de ámbito nacional e internacional a primera hora de la mañana.'),
(3, '2018-03-07', '08:30:00', 'Un café con Susana', 'Espacio en el que Susana Griso entrevista al protagonista del día. La presentadora se sienta para conversar con personajes de la actualidad política, social y cultural con el fin de aportar al espectador información contada en primera persona.'),
(3, '2018-03-07', '09:00:00', 'Espejo público', 'El protagonismo de este magacín matinal presentado por Susanna Griso es del público, la calle y los directos.'),
(3, '2018-03-07', '13:15:00', 'Karlos Arguiñano en tu cocina', 'Con Karlos Arguiñano nos lo vamos a pasar en grande mientras aprendemos un poco más los secretos de la cocina. Platos sencillos y muy ricos para todos los bolsillos que nos harán nuestra vida mucho más sencilla.'),
(3, '2018-03-07', '13:40:00', 'La ruleta de la suerte', 'Es un concurso presentado por Jorge Fernández, de lunes a viernes, que pone a prueba la agilidad mental, los reflejos y los conocimientos de los participantes.'),
(3, '2018-03-07', '15:00:00', 'Noticias 1', 'María Rey y Sandra Golpe te esperan de lunes a viernes a las 15:00 h. Una cita con la información nacional e internacional.'),
(3, '2018-03-07', '15:45:00', 'Deportes 1', 'Rocío Martínez se encarga de presentar el espacio dedicado a las noticias de deportes.'),
(3, '2018-03-07', '16:00:00', 'Tu Tiempo', 'Información meteorológica. Con Roberto Brasero.'),
(3, '2018-03-07', '16:30:00', 'Amar es para siempre', 'Luisita duerme en el calabozo y todo apunta a que Emilio Losada y sus amigos le quieren endosar toda la responsabilidad. Durán sospecha que la muerte de Requena ha sido un asesinato. Para intentar congraciarse con Durán, Ortega incluye un agradecimiento a Osuna en el nuevo prólogo de la biografía de Franco.'),
(3, '2018-03-07', '17:30:00', 'El secreto de Puente Viejo', 'Ante las noticias de la cercana llegada de Dos Caras, Nicolás explica a Emilia y Alfonso que va a seguir luchando para que se haga justicia. Francisca, por su parte, espera al momento de recibir la decisión de la asamblea, y Raimundo llega para decirle que quiere compartir su destino. Mientras tanto, Saúl y Prudencio se juntan con Larraz, que trae noticias de la asamblea: Francisca será fusilada.'),
(3, '2018-03-07', '18:45:00', 'Ahora caigo', 'Presentado por Arturo Valls. Es un concurso tan impredecible que la tierra se abrirá bajo tus pies. Un formato revolucionario que une el suspense de una batalla de preguntas con un elemento sorpresa: el puro azar.'),
(3, '2018-03-07', '20:00:00', '¡Boom!', 'Juanra Bonet presenta ¡Boom! un programa impredecible en el que los concursantes no podrán cortar el cable de la respuesta correcta.'),
(3, '2018-03-07', '21:00:00', 'Noticias 2', 'Lourdes Maldonado y Ángel Carreira te esperan de lunes a viernes a las 21:00h para informarte de todo lo que aco'),
(3, '2018-03-07', '21:30:00', 'Deportes', 'Manu Sánchez se encarga de presentar el espacio dedicado a las noticias de deportes.'),
(3, '2018-03-07', '21:40:00', 'La previsión de las 9', 'Presenta Roberto Brasero. Información meteorológica de la noche y previsión del tiempo para los próximos días.'),
(3, '2018-03-07', '21:45:00', 'El hormiguero 3.0', 'La periodista y presentadora Mariló Montero y el humorista Santi Rodríguez hablan de la próxima gala de ''''Hipnotízame'''', en la que serán dos de los invitados.'),
(3, '2018-03-07', '22:40:00', 'Fariña', 'Años 80. Galicia. La reconversión de la pesca ha dejado a una parte de la flota gallega en tierra y cientos de armadores endeudados. No hay trabajo. En los muchos pueblos de pescadores que recorren la costa gallega, la falta de ingresos y los pagos cotidianos estrangula las economías'),
(3, '2018-03-08', '01:00:00', 'Cine Puro Vicio', 'Dir: Paul Thomas Anderson. Int: Jena Malone, Joaquin Phoenix, Sasha Pieterse, Reese Witherspoon, Wilson Bethel, Josh Brolin, Benicio Del Toro, Owen Wilson, Maya Rudolph, Martin Short (Thriller, EE.UU., 2014) [Tráiler]'),
(3, '2018-03-08', '02:03:00', 'Campeonato europeo de poker', 'Disfruta del campeonato de poker Europeo.'),
(3, '2018-03-08', '04:00:00', 'Comprando en casa', 'Espacio de teletienda.'),
(3, '2018-03-08', '04:30:00', 'Minutos musicales', 'Música en directo interpretada por artistas de primer nivel. Un espacio pensado y diseñado para los amantes de la música...'),
(3, '2018-03-08', '06:00:00', 'Minutos musicales', 'Música en directo interpretada por artistas de primer nivel. Un espacio pensado y diseñado para los amantes de la música...'),
(3, '2018-03-08', '06:15:00', 'Noticias de la mañana', 'Esther Vaquero, Lorena García y María José Sáez son las encargadas de traer las noticias de ámbito nacional e internacional a primera hora de la mañana.'),
(3, '2018-03-08', '08:30:00', 'Un café con Susana', 'Espacio en el que Susana Griso entrevista al protagonista del día. La presentadora se sienta para conversar con personajes de la actualidad política, social y cultural con el fin de aportar al espectador información contada en primera persona.'),
(3, '2018-03-08', '09:00:00', 'Espejo público', 'El protagonismo de este magacín matinal presentado por Susanna Griso es del público, la calle y los directos.'),
(3, '2018-03-08', '13:15:00', 'Karlos Arguiñano en tu cocina', 'Con Karlos Arguiñano nos lo vamos a pasar en grande mientras aprendemos un poco más los secretos de la cocina. Platos sencillos y muy ricos para todos los bolsillos que nos harán nuestra vida mucho más sencilla.'),
(3, '2018-03-08', '13:40:00', 'La ruleta de la suerte', 'Presentado por Jorge Fernández, con la colaboración de Laura Moure como la azafata del programa, La ruleta de la suerte, el concurso rey de las mañanas, inicia nueva temporada con muchas novedades.'),
(3, '2018-03-08', '15:00:00', 'Noticias 1', 'María Rey y Sandra Golpe te esperan de lunes a viernes a las 15:00 h. Una cita con la información nacional e internacional.'),
(3, '2018-03-08', '15:45:00', 'Deportes 1', 'Rocío Martínez se encarga de presentar el espacio dedicado a las noticias de deportes.'),
(3, '2018-03-08', '16:00:00', 'Tu Tiempo', 'Roberto Brasero nos informa de las previsiones meteorológicas de forma amena y sencilla.'),
(3, '2018-03-08', '16:30:00', 'Amar es para siempre', 'En la España de principios de los años 60, a la rigidez oficial se superpone una sociedad que desea abrirse al mundo y vivir nuevas experiencias.'),
(3, '2018-03-08', '17:30:00', 'El secreto de Puente Viejo', 'Francisca no permitirá que se arriesguen más por ella y dice estar dispuesta a afrontar la tragedia si llega. Es Consuelo quien tiene una idea para salvarla, y requiere de la ayuda y complicidad de Prudencio. Por su parte, Carmelo y Adela reciben informes sobre Irene que parecen confirmar todo lo dicho por la periodista. Y Nicolás pasa por casa de Severo para interesarse por él y da la sensación d'),
(3, '2018-03-08', '18:45:00', '¡Ahora caigo!', 'Presentado por Arturo Valls. Es un concurso tan impredecible que la tierra se abrirá bajo tus pies. Un formato revolucionario que une el suspense de una batalla de preguntas con un elemento sorpresa: el puro azar.'),
(3, '2018-03-08', '20:00:00', '¡Boom!', 'Juanra Bonet presenta ¡Boom! un programa impredecible en el que los concursantes no podrán cortar el cable de la respuesta correcta.'),
(3, '2018-03-08', '21:00:00', 'Noticias 2', 'Vicente Vallés te espera de lunes a viernes a las 21:00h para informarte de todo lo que acontece en España y fuera de nuestras fronteras. No faltes a la cita con la información.'),
(3, '2018-03-08', '21:30:00', 'Deportes 2', 'Manu Sánchez se encarga de presentar el espacio dedicado a las noticias de deportes.'),
(3, '2018-03-08', '21:40:00', 'La previsión de las 9', 'Información meteorológica. Con Roberto Brasero.'),
(3, '2018-03-08', '21:45:00', 'El hormiguero 3.0', 'El cantante Ricky Martin acude al plató de ''''El hormiguero 3.0'''' para presentar su nueva canción ''''Fiebre'''', que cuenta con la participación de los artistas Wisin y Yandel.'),
(3, '2018-03-08', '22:40:00', 'Casados a primera vista', '¿Se imaginan a 8 solteros que han tenido mala suerte en el amor confiando en un grupo de expertos para que les busquen su pareja ideal? Una experiencia única en .Casados a primera vista .'),
(4, '2018-03-06', '00:05:00', 'Ven a cenar conmigo.', 'Gourmet Edition Rappel se las ingeniará para organizar una exquisita velada donde desvelará sus excelentes dotes culinarias. Además, sus invitados quedarán perplejos ante el tamaño de su mansión y conocerán aspectos de su futuro con una tirada de cartas que no dejará indiferente.'),
(4, '2018-03-06', '01:20:00', 'Ven a cenar conmigo', 'Ser el mejor anfitrión es el objetivo de este concurso en que cinco amantes de la cocina se pondrán a prueba. El organizador de la velada que proporcione la mejor atención a los demás concursantes conseguirá un premio en metálico.'),
(4, '2018-03-06', '02:10:00', 'Ven a cenar conmigo', 'Los concursantes cenarán en casa de Neftalí, heavy, adorador de Satán y vegetariano. Este joven no tiene entre sus virtudes la de cocinar. Aun así, intentará contentar los paladares de sus invitados. Su extraña personalidad provocará que el menú pase a un segundo plano.'),
(4, '2018-03-06', '02:55:00', 'Puro Cuatro', 'Programa que da a conocer la música que suena en Cuatro.'),
(4, '2018-03-06', '04:00:00', 'La tienda en casa', 'Espacio de teletienda.'),
(4, '2018-03-06', '05:15:00', 'Puro Cuatro', 'Programa que da a conocer la música que suena en Cuatro.'),
(4, '2018-03-06', '06:00:00', 'Puro Cuatro', 'Espacio que actúa a modo de escaparate de la música que suena en los programas de Cuatro.'),
(4, '2018-03-06', '07:00:00', 'El Zapping De Surferos:', 'Lo mejor Espacio que recoge los mejores momentos y las imágenes más impactantes y curiosas emitidas en las distintas cadenas de televisión.'),
(4, '2018-03-06', '08:00:00', 'Gym Tony XS', 'En el gimnasio Gym Tony se reúnen unos personajes estrafalarios que viven las más cómicas y disparatadas aventuras: un dueño embaucador, unos empleados a los que nadie contrataría y un puñado de clientes fieles, a pesar de todo.'),
(4, '2018-03-06', '09:15:00', 'Alerta Cobra ''El día de la madre''.', 'En la Europa del año 2000, las autopistas alemanas se han convertido en los lugares de paso de multitud de personajes siniestros, cargas peligrosas y conductores temerarios. La brigada especial de carreteras se encarga de luchar contra el crimen en estos lugares.'),
(4, '2018-03-06', '10:15:00', 'Alerta Cobra ''La luchadora''.', 'Para Sandra, aspirante a boxeadora profesional, el mundo se derrumba. Poco antes de su primera gran pelea, su padre y su entrenador son asesinados durante un atraco. Semir y Alex investigan el verdadero trasfondo del asesinato.'),
(4, '2018-03-06', '11:20:00', 'Las Mañanas De Cuatro (Primera hora)', 'Javier Ruiz y sus colaboradores analizan cada mañana la actualidad política y los sucesos más destacados de nuestro país.'),
(4, '2018-03-06', '12:30:00', 'Las Mañanas De Cuatro', 'Magacín matinal presentado por Javier Ruiz que recoge la actualidad política y social, la cultura y las nuevas tendencias.'),
(4, '2018-03-06', '14:15:00', 'Noticias Cuatro mediodía', 'Toda la actualidad nacional e internacional de la mano de Marta Fernández.'),
(4, '2018-03-06', '14:45:00', 'El Tiempo', 'Presentado por Rebeca Haro.'),
(4, '2018-03-06', '14:55:00', 'Noticias Cuatro', 'Deportes'),
(4, '2018-03-06', '15:25:00', 'Deportes Cuatro', 'Presentado por Manu Carreño, Manolo Lama.'),
(4, '2018-03-06', '15:45:00', 'Mujeres Y Hombres Y Viceversa', 'El dating show más célebre de las pantallas españolas. Los tronistas tendrán divertidas citas con diversos candidatos hasta encontrar a su pareja ideal. Moderado por Emma García.'),
(4, '2018-03-06', '17:00:00', 'Ven a cenar conmigo a la hora de la merienda', 'Ser el mejor anfitrión es el objetivo de este concurso en que cinco amantes de la cocina se pondrán a prueba. El organizador de la velada que proporcione la mejor atención a los demás concursantes conseguirá un premio en metálico.'),
(4, '2018-03-06', '18:00:00', 'Hawai 5.0 ''Una tribuna para hablar''.', 'Cuando un grupo de armas es robado de un alijo de armas de fuego, el quipo 5-0 descubre que el culpable tiene la intención de hacer una declaración dramática sobre la violencia armada. (Empezó hace 31'')'),
(4, '2018-03-06', '18:50:00', 'Hawai 5.0 ''Una estrella fugaz''.', 'La muerte por envenenamiento de un imitador de Elvis conduce al equipo del 5.0 a un misterioso caso que tiene como principales elementos unos diamantes de contrabando y un par de caras conocidas de McGarrett y compañía. (Empieza dentro de 19'')'),
(4, '2018-03-06', '19:45:00', 'Noticias Cuatro Noche', 'Toda la actualidad nacional e internacional de la mano de Miguel Ángel Oliver.'),
(4, '2018-03-06', '20:20:00', 'Deportes Cuatro 2', 'Toda la actualidad deportiva en este espacio de Noticias Cuatro.'),
(4, '2018-03-06', '20:25:00', 'El Tiempo', 'Todo lo que quieres saber sobre los cambios meteorológicos, además de las curiosidades sobre el clima y el medio ambiente.'),
(4, '2018-03-06', '20:30:00', 'Ven a cenar conmigo', 'Los concursantes cenarán en casa de Neftalí, heavy, adorador de Satán y vegetariano. Este joven no tiene entre sus virtudes la de cocinar. Aun así, intentará contentar los paladares de sus invitados. Su extraña personalidad provocará que el menú pase a un segundo plano.'),
(4, '2018-03-06', '21:30:00', 'First Dates', 'Espacio que organiza citas a ciegas entre solteros en un restaurante único y especial. Carlos Sobera ejercerá de singular maître de este local, interviniendo en caso de que sus clientes necesiten una ayuda extra durante la cita, para conseguir el éxito entre la pareja.'),
(4, '2018-03-06', '22:45:00', 'Ven a cenar conmigo.', 'Gourmet Edition Víctor Janeiro es un hombre consciente de sus limitaciones. Es simpático, tiene encanto y mucho arte. Pero habilidades culinarias, pocas. Hoy intenta seducir a Ana Obregón, Lucía Etxebarria y Rappel con unos huevos con patatas.'),
(4, '2018-03-07', '01:20:00', 'Cine Cuatro Enemigos.', 'Ecks contra Sever Dir: Wych Kaosayananda. Int: Antonio Banderas, Lucy Liu, Gregg Henry, Ray Park, Talisa Soto (Acción, EE.UU., 2002)'),
(4, '2018-03-07', '03:00:00', 'Puro Cuatro', 'Programa que da a conocer la música que suena en Cuatro.'),
(4, '2018-03-07', '04:00:00', 'La tienda en casa', 'Espacio de teletienda.'),
(4, '2018-03-07', '05:15:00', 'Puro Cuatro Programa que da a conocer la música que suena en Cuatro.', NULL),
(4, '2018-03-07', '07:00:00', 'El Zapping De Surferos: Lo mejor', 'Espacio que recoge los mejores momentos y las imágenes más impactantes y curiosas emitidas en las distintas cadenas de televisión.'),
(4, '2018-03-07', '08:00:00', 'Gym Tony XS', 'En el gimnasio Gym Tony se reúnen unos personajes estrafalarios que viven las más cómicas y disparatadas aventuras: un dueño embaucador, unos empleados a los que nadie contrataría y un puñado de clientes fieles, a pesar de todo.'),
(4, '2018-03-07', '09:15:00', 'Alerta Cobra', '''Sin piedad''. En la Europa del año 2000, las autopistas alemanas se han convertido en los lugares de paso de multitud de personajes siniestros, cargas peligrosas y conductores temerarios. La brigada especial de carreteras se encarga de luchar contra el crimen en estos lugares.'),
(4, '2018-03-07', '10:15:00', 'Alerta Cobra', '''Cobra, encargaos vosotros''. En la Europa del año 2000, las autopistas alemanas se han convertido en los lugares de paso de multitud de personajes siniestros, cargas peligrosas y conductores temerarios. La brigada especial de carreteras se encarga de luchar contra el crimen en estos lugares.'),
(4, '2018-03-07', '11:20:00', 'Las Mañanas De Cuatro (Primera hora)', 'Javier Ruiz y sus colaboradores analizan cada mañana la actualidad política y los sucesos más destacados de nuestro país.'),
(4, '2018-03-07', '12:30:00', 'Las Mañanas De Cuatro', 'Magacín matinal presentado por Javier Ruiz que recoge la actualidad política y social, la cultura y las nuevas tendencias.'),
(4, '2018-03-07', '14:15:00', 'Noticias Cuatro mediodía', 'Toda la actualidad nacional e internacional de la mano de Marta Fernández.'),
(4, '2018-03-07', '14:45:00', 'El Tiempo', 'Presentado por Rebeca Haro.'),
(4, '2018-03-07', '14:55:00', 'Noticias Cuatro Deportes', 'Informativo deportivo incluido en el espacio Noticias Cuatro, que nos detalla las últimas novedades del mundo del deporte.'),
(4, '2018-03-07', '15:25:00', 'Deportes Cuatro', 'Presentado por Manu Carreño, Manolo Lama.'),
(4, '2018-03-07', '15:45:00', 'Mujeres Y Hombres Y Viceversa', 'El dating show más célebre de las pantallas españolas. Los tronistas tendrán divertidas citas con diversos candidatos hasta encontrar a su pareja ideal. Moderado por Emma García.'),
(4, '2018-03-07', '17:00:00', 'Ven a cenar conmigo a la hora de la merienda', 'Cada semana, de lunes a viernes, cinco personas anónimas competirán entre sí por erigirse en el mejor cocinero-anfitrión de la velada y ganar los 3.000 euros de premio. Presentado por Luis Larrodera.'),
(4, '2018-03-07', '18:00:00', 'Hawai 5.0', '''La casa de los horrores''. En Halloween, el equipo investiga el asesinato de un médium que aparentemente murió aterrado por la presencia de un poltergeist. Por otra parte, Kono y Adam son secuestrados para un culto a la muerte.'),
(4, '2018-03-07', '18:50:00', 'Hawai 5.0', '''Reconstruyendo el ayer''. Tres jóvenes contables encuentran un cadáver en su habitación de hotel después de una noche de fiesta. Mientras tanto, Jerry se topa con un asesinato vinculado con una red de trata de blancas mientras realizaba una entrega para Kamekona.'),
(4, '2018-03-07', '19:45:00', 'Noticias Cuatro Noche', 'Toda la actualidad nacional e internacional de la mano de Miguel Ángel Oliver.'),
(4, '2018-03-07', '20:20:00', 'Deportes Cuatro 2', 'Toda la actualidad deportiva en este espacio de Noticias Cuatro.'),
(4, '2018-03-07', '20:25:00', 'El Tiempo', 'Todo lo que quieres saber sobre los cambios meteorológicos, además de las curiosidades sobre el clima y el medio ambiente.'),
(4, '2018-03-07', '20:30:00', 'Ven a cenar conmigo', 'Cada semana, de lunes a viernes, cinco personas anónimas competirán entre sí por erigirse en el mejor cocinero-anfitrión de la velada y ganar los 3.000 euros de premio. Presentado por Luis Larrodera.');
INSERT INTO `programa` (`idcanal`, `fecha`, `hora`, `nombre`, `descripcion`) VALUES
(4, '2018-03-07', '21:30:00', 'First dates', 'La mesa está servida, el ambiente es romántico y todo el personal está listo para acoger a cientos de solteros que buscan pareja. El dating show tendrá como cómplice a Carlos Sobera, al que acompañan los ''camareros'' Matías Roure y Lydia Torrent.'),
(4, '2018-03-07', '22:55:00', 'Cine Cuatro Shooter: El Tirador', 'Dir: Antoine Fuqua. Int: Mark Wahlberg, Michael Pena, Danny Glover, Kate Mara, Elias Koteas, Rhona Mitra, Rade Sherbedgia, Ned Beatty (Acción, EE.UU., 2007)'),
(4, '2018-03-08', '00:25:00', 'Mentes criminales ', '''El testigo''. Un autobús urbano de Los Ángeles sufre un ataque con gas sarín. Hotchner y su equipo de analistas viajan a California para dar caza al culpable antes de que pueda repetir el atentado.'),
(4, '2018-03-08', '01:25:00', 'Mentes criminales ', '''Traspasando fronteras''. Hotch y Cruz recurren a un equipo de élite del FBI encabezado por Jack Garrett con tal de esclarecer el caso de una familia estadounidense secuestrada durante sus vacaciones en Barbados. Durante las pesquisas, se dan cuenta de que esta situación se asemeja a otro caso.'),
(4, '2018-03-08', '02:05:00', 'Mentes criminales ', '''Las ruedas del autobús''. La unidad busca un autobús escolar que ha desaparecido lleno de niños fuera del área de la ciudad de Washington. Los investigadores deben trabajar contra el reloj para conseguir devolver a los menores a sus casas sanos y salvos.'),
(4, '2018-03-08', '03:00:00', 'Puro Cuatro ', 'Programa que da a conocer la música que suena en Cuatro.'),
(4, '2018-03-08', '04:00:00', 'La tienda en casa ', 'Espacio de televenta.'),
(4, '2018-03-08', '05:15:00', 'Puro Cuatro ', 'Programa que da a conocer la música que suena en Cuatro.'),
(4, '2018-03-08', '06:00:00', 'Puro Cuatro', 'Espacio que actúa a modo de escaparate de la música que suena en los programas de Cuatro.'),
(4, '2018-03-08', '07:00:00', 'El Zapping De Surferos:', 'Lo mejor'),
(4, '2018-03-08', '08:00:00', 'Gym Tony XS', ' En el gimnasio Gym Tony se reúnen unos personajes estrafalarios que viven las más cómicas y disparatadas aventuras: un dueño embaucador, unos empleados a los que nadie contrataría y un puñado de clientes fieles, a pesar de todo.'),
(4, '2018-03-08', '09:15:00', 'Alerta Cobra', ' En la Europa del año 2000, las autopistas alemanas se han convertido en los lugares de paso de multitud de personajes siniestros, cargas peligrosas y conductores temerarios. La brigada especial de carreteras se encarga de luchar contra el crimen en estos lugares.'),
(4, '2018-03-08', '10:15:00', 'Alerta Cobra', ' En la Europa del año 2000, las autopistas alemanas se han convertido en los lugares de paso de multitud de personajes siniestros, cargas peligrosas y conductores temerarios. La brigada especial de carreteras se encarga de luchar contra el crimen en estos lugares.'),
(4, '2018-03-08', '11:20:00', 'Las Mañanas De Cuatro (Primera hora)', ' Javier Ruiz y sus colaboradores analizan cada mañana la actualidad política y los sucesos más destacados de nuestro país.'),
(4, '2018-03-08', '12:30:00', 'Las Mañanas De Cuatro', ' Magacín matinal presentado por Javier Ruiz que recoge la actualidad política y social, la cultura y las nuevas tendencias.'),
(4, '2018-03-08', '14:15:00', 'Noticias Cuatro ', 'mediodía Toda la actualidad nacional e internacional de la mano de Marta Fernández.'),
(4, '2018-03-08', '14:45:00', 'El Tiempo', ' Presentado por Rebeca Haro.'),
(4, '2018-03-08', '14:55:00', 'Noticias Cuatro Deportes', ' Informativo deportivo incluido en el espacio Noticias Cuatro, que nos detalla las últimas novedades del mundo del deporte.'),
(4, '2018-03-08', '15:25:00', 'Deportes Cuatro ', 'Informativo que ofrece las últimas noticias del mundo del deporte y las declaraciones de sus protagonistas.'),
(4, '2018-03-08', '15:45:00', 'Mujeres Y Hombres Y Viceversa', ' El dating show más célebre de las pantallas españolas. Los tronistas tendrán divertidas citas con diversos candidatos hasta encontrar a su pareja ideal. Moderado por Emma García.'),
(4, '2018-03-08', '17:00:00', 'Ven a cenar conmigo a la hora de la merienda ', 'Cada semana, de lunes a viernes, cinco personas anónimas competirán entre sí por erigirse en el mejor cocinero-anfitrión de la velada y ganar los 3.000 euros de premio. Presentado por Luis Larrodera.'),
(4, '2018-03-08', '18:00:00', 'Hawai 5.0', ' Serie policíaca que se sitúa en Hawai, donde una unidad especial de la policía estatal investiga los delitos que ocurren en la isla.'),
(4, '2018-03-08', '18:50:00', 'Hawai 5.0', ' Serie policíaca que se sitúa en Hawai, donde una unidad especial de la policía estatal investiga los delitos que ocurren en la isla.'),
(4, '2018-03-08', '19:45:00', 'Noticias Cuatro ', 'Toda la actualidad nacional e internacional de la mano de Miguel Ángel Oliver.'),
(4, '2018-03-08', '20:20:00', 'Deportes Cuatro 2 ', 'Toda la información deportiva en Cuatro. Presentado por Luis García y Ricardo Reyes.'),
(4, '2018-03-08', '20:25:00', 'El Tiempo', ' Presentado por Laura Madrueño.'),
(4, '2018-03-08', '20:30:00', 'Ven a cenar conmigo ', 'Cada semana, de lunes a viernes, cinco personas anónimas competirán entre sí por erigirse en el mejor cocinero-anfitrión de la velada y ganar los 3.000 euros de premio. Presentado por Luis Larrodera.'),
(4, '2018-03-08', '21:30:00', 'First Dates ', 'La mesa está servida, el ambiente es romántico y todo el personal está listo para acoger a cientos de solteros que buscan pareja. El dating show tendrá como cómplice a Carlos Sobera, al que acompañan los ''camareros'' Matías Roure y Lydia Torrent.'),
(4, '2018-03-08', '22:45:00', 'Mentes criminales ', '''Montaje''. Décimotercera temporada de la serie sobre la Unidad de Análisis de la Conducta, una sección del FBI que atiende al comportamiento del criminal para estrechar el cerco sobre él. Cuando no hay suficientes pistas en un caso, el FBI acude a esta división.'),
(4, '2018-03-08', '23:30:00', 'Mentes criminales ', '''Spencer''. Los agentes Clara Seger y Matt Simmons, de ''''Mentes criminales sin fronteras'''', viajan a México para sacar de prisión a su compañero de la Unidad de Análisis de Conducta, Spencer Reid, encarcelado por tráfico de drogas.'),
(5, '2018-03-06', '00:30:00', 'Amores que duelen ', 'Amores que duelen'' es uno de esos programas que abre los ojos a una realidad difícil de mirar: La Violencia de Género.'),
(5, '2018-03-06', '01:15:00', 'Amores que duelen ''Sandra''.', ' Sandra estuvo casada durante 22 años y fue víctima de maltrato psicológico. Actualmente, el acoso continúa mediante llamadas, mensajes y amenazas, por lo que Sandra cuenta con protección policial y con una orden de alejamiento de 1.500 metros.'),
(5, '2018-03-06', '02:15:00', 'La tienda en casa', ' Espacio de teletienda.'),
(5, '2018-03-06', '02:30:00', 'Miramimusica ', 'El espacio comercial de música en Telecinco.'),
(5, '2018-03-06', '06:30:00', 'Informativos Telecinco', 'Primera edición informativa de la cadena presentada por Alba Lago y Roberto Fernández. El noticiario ofrece un seguimiento de las noticias de la jornada anterior.'),
(5, '2018-03-06', '08:55:00', 'El Programa De Ana Rosa ', 'Magacín matutino conducido por Ana Rosa Quintana, que cuenta con Joaquín Prat como colaborador. El programa contiene diferentes secciones donde contertulianos hablan sobre temas de sociedad, corazón, política y actualidad.'),
(5, '2018-03-06', '13:45:00', 'Cámbiame ', 'Programa que ofrece un cambio radical de imagen a sus participantes. Los aspirantes tendrán 60 segundos para convencer a un equipo de tres estilitas de que ellos son los mejores candidatos para renovar su ropa, peinado e incluso su actitud y personalidad.'),
(5, '2018-03-06', '15:05:00', 'Informativos Telecinco ', 'Presentado por David Cantero, Isabel Jiménez. Espacio dedicado a la información de actualidad.'),
(5, '2018-03-06', '15:40:00', 'Deportes ', 'Espacio informativo dedicado al mundo del deporte. Presentado por J.J. Santos.'),
(5, '2018-03-06', '15:50:00', 'El Tiempo ', 'Información meteorológica y pronóstico del tiempo.'),
(5, '2018-03-06', '16:00:00', 'Sálvame Limón ', 'La edición más ácida de Sálvame, magacín vespertino que aborda la actualidad de la crónica rosa y que cuenta con una larga lista de colaboradores como: Belén Esteban, Karmele Marchante, Kiko Hernández, Lydia Lozano o Terelu Campos.'),
(5, '2018-03-06', '17:00:00', 'Sálvame Naranja ', 'La edición más dulce y apta para todas las sensibilidades de Sálvame, magacín vespertino que aborda la actualidad de la crónica rosa y que cuenta con una larga lista de colaboradores como: Belén Esteban, Karmele Marchante, Kiko Hernández, Lydia Lozano o Terelu Campos. (Hace más de 1 hora que empezó)'),
(5, '2018-03-06', '20:05:00', 'Pasapalabra ', 'Presentado por Christian Gálvez. Concurso en el que los participantes intentan acumular segundos a lo largo de diversas pruebas, con el fin de tener más tiempo para la prueba final: El Rosco.'),
(5, '2018-03-06', '21:05:00', 'Informativos Telecinco ', 'Presentado por Pedro Piqueras. Espacio dedicado a la información de actualidad.'),
(5, '2018-03-06', '21:40:00', 'Deportes ', 'Presentado por J.J. Santos. Espacio informativo dedicado al mundo del deporte.'),
(5, '2018-03-06', '21:50:00', 'El Tiempo ', 'Información meteorológica y pronóstico del tiempo.'),
(5, '2018-03-06', '22:00:00', 'Got Talent. Momentazos ', 'Disfruta de los mejores momentos de la gala del ‘talent show’ conducido por Santi Millán. El jurado está formado por Risto Mejide, Jorge Javier Vázquez, Eva Hache y Edurne.'),
(5, '2018-03-06', '22:40:00', 'Cine 5 Estrellas ', 'Noche real Dir: Julian Jarrold. Int: Sarah Gadon, Emily Watson, Jack Reynor, Rupert Everett, Bel Powley, Roger Allam, Jack Laskey, Ruth Sheen, Anastasia Harrold, Jack Gordon (Comedia, Gran Bretaña, 2015) [Tráiler]'),
(5, '2018-03-07', '01:45:00', 'Got Talent. Momentazos', 'Disfruta de los mejores momentos de la gala del ‘talent show’ conducido por Santi Millán. El jurado está formado por Risto Mejide, Jorge Javier Vázquez, Eva Hache y Edurne.'),
(5, '2018-03-07', '02:45:00', 'La tienda en casa', 'Espacio de televenta.'),
(5, '2018-03-07', '03:00:00', 'Miramimusica', 'El espacio comercial de música en Telecinco.'),
(5, '2018-03-07', '06:30:00', 'Informativos Telecinco', 'Primera edición informativa de la cadena presentada por Alba Lago y Roberto Fernández. El noticiario ofrece un seguimiento de las noticias de la jornada anterior.'),
(5, '2018-03-07', '08:55:00', 'El Programa de Ana Rosa', 'Magacín matutino conducido por Ana Rosa Quintana, que cuenta con Joaquín Prat como colaborador. El programa contiene diferentes secciones donde contertulianos hablan sobre temas de sociedad, corazón, política y actualidad.'),
(5, '2018-03-07', '13:45:00', 'Cambiame', 'Programa de cambio de imagen presentado por Carlota Corredera que pretende hacer realidad los sueños de sus aspirantes gracias a la intervención de estilistas profesionales: Cristina Rodríguez, Natalia Ferviú y Pelayo Díaz.'),
(5, '2018-03-07', '15:05:00', 'Informativos Telecinco', 'Presentado por David Cantero, Isabel Jiménez. Espacio dedicado a la información de actualidad.'),
(5, '2018-03-07', '15:40:00', 'Deportes', 'Espacio informativo dedicado al mundo del deporte. Presentado por Pablo Pinto.'),
(5, '2018-03-07', '15:50:00', 'El Tiempo', 'Información meteorológica y pronóstico del tiempo.'),
(5, '2018-03-07', '16:00:00', 'Sálvame Limón', 'La edición más ácida de Sálvame, magacín vespertino que aborda la actualidad de la crónica rosa y que cuenta con una larga lista de colaboradores como: Belén Esteban, Karmele Marchante, Kiko Hernández, Lydia Lozano o Terelu Campos.'),
(5, '2018-03-07', '17:00:00', 'Sálvame Naranja', 'La edición más dulce y apta para todas las sensibilidades de Sálvame, magacín vespertino que aborda la actualidad de la crónica rosa y que cuenta con una larga lista de colaboradores como: Belén Esteban, Karmele Marchante, Kiko Hernández, Lydia Lozano o Terelu Campos.'),
(5, '2018-03-07', '20:05:00', 'Pasapalabra', 'Concurso presentado por Christian Gálvez en el que dos concursantes intentarán acumular los máximos segundos posibles en una serie de pruebas para afrontar con más posibilidades el rosco final.'),
(5, '2018-03-07', '21:05:00', 'Informativos Telecinco', 'Presentado por Pedro Piqueras. Espacio dedicado a la información de actualidad.'),
(5, '2018-03-07', '21:40:00', 'Deportes', 'Espacio informativo dedicado al mundo del deporte. Presentado por J. J. Santos.'),
(5, '2018-03-07', '21:50:00', 'El Tiempo', 'Información meteorológica y pronóstico del tiempo.'),
(5, '2018-03-07', '22:00:00', 'Got Talent', 'Tercera edición del concurso que busca nuevas promesas en distintas disciplinas artísticas como el baile, la magia o el humor. El publicista Risto Mejide forma el jurado junto a Eva Hache, Edurne y Jorge Javier Vázquez. Santi Millán ejerce de maestro de ceremonias.'),
(5, '2018-03-08', '02:15:00', 'La tienda en casa', 'Espacio de televenta.'),
(5, '2018-03-08', '02:30:00', 'Miramimusica', 'El espacio comercial de música en Telecinco.'),
(5, '2018-03-08', '06:30:00', 'Informativos Telecinco', 'Primera edición informativa de la cadena presentada por Alba Lago y Roberto Fernández. El noticiario ofrece un seguimiento de las noticias de la jornada anterior.'),
(5, '2018-03-08', '08:55:00', 'El Programa de Ana Rosa', 'Magacín matutino conducido por Ana Rosa Quintana, que cuenta con Joaquín Prat como colaborador. El programa contiene diferentes secciones donde contertulianos hablan sobre temas de sociedad, corazón, política y actualidad.'),
(5, '2018-03-08', '13:45:00', 'Cambiame', 'Programa de cambio de imagen presentado por Carlota Corredera que pretende hacer realidad los sueños de sus aspirantes gracias a la intervención de estilistas profesionales: Cristina Rodríguez, Natalia Ferviú y Pelayo Díaz.'),
(5, '2018-03-08', '15:05:00', 'Informativos Telecinco', 'Presentado por David Cantero, Isabel Jiménez. Espacio dedicado a la información de actualidad.'),
(5, '2018-03-08', '15:40:00', 'Deportes', 'Espacio informativo dedicado al mundo del deporte. Presentado por Pablo Pinto.'),
(5, '2018-03-08', '15:50:00', 'El Tiempo', 'Información meteorológica y pronóstico del tiempo.'),
(5, '2018-03-08', '16:00:00', 'Sálvame Limón', 'La edición más ácida de Sálvame, magacín vespertino que aborda la actualidad de la crónica rosa y que cuenta con una larga lista de colaboradores como: Belén Esteban, Karmele Marchante, Kiko Hernández, Lydia Lozano o Terelu Campos.'),
(5, '2018-03-08', '17:00:00', 'Sálvame Naranja', 'La edición más dulce y apta para todas las sensibilidades de Sálvame, magacín vespertino que aborda la actualidad de la crónica rosa y que cuenta con una larga lista de colaboradores como: Belén Esteban, Karmele Marchante, Kiko Hernández, Lydia Lozano o Terelu Campos.'),
(5, '2018-03-08', '20:05:00', 'Pasapalabra', 'Presentado por Christian Gálvez. Concurso en el que los participantes intentan acumular segundos a lo largo de diversas pruebas, con el fin de tener más tiempo para la prueba final: El Rosco.'),
(5, '2018-03-08', '21:05:00', 'Informativos Telecinco', 'Presentado por Pedro Piqueras. Espacio dedicado a la información de actualidad.'),
(5, '2018-03-08', '21:40:00', 'Deportes', 'Presentado por J.J. Santos. Espacio informativo dedicado al mundo del deporte.'),
(5, '2018-03-08', '21:50:00', 'El Tiempo', 'Información meteorológica y pronóstico del tiempo.'),
(5, '2018-03-08', '22:00:00', 'Volverte a ver', 'Programa conducido por Carlos Sobera en el que el amor es el protagonista. Reencuentros, peticiones de matrimonio, confesiones y perdones son algunos de los componentes de este espacio que abre una ventana a todos aquellos que quieren demostrar sus sentimientos.'),
(6, '2018-03-06', '00:45:00', 'Policías en acción', 'La serie analiza el trabajo cotidiano de las Fuerzas de Seguridad del Estado. Desde persecuciones, detenciones, redadas y registros, la ayuda a los ciudadanos...'),
(6, '2018-03-06', '02:30:00', 'Comprando en casa', 'Espacio de teletienda.'),
(6, '2018-03-06', '03:30:00', 'Canal Ruleta', NULL),
(6, '2018-03-06', '04:30:00', 'Minutos musicales', 'Música en directo interpretada por artistas de primer nivel. Un espacio pensado y diseñado para los amantes de la música...'),
(6, '2018-03-06', '06:00:00', 'minutos musicales', 'Música en directo interpretada por artistas de primer nivel. Un espacio pensado y diseñado para los amantes de la música...'),
(6, '2018-03-06', '06:15:00', 'Navy: Investigación Criminal ''Semper Fortis''.', 'Gibbs intenta ayudar a un asistente médico del hospital de la marina que esta bajo investigación por sus métodos para salvar vidas.'),
(6, '2018-03-06', '06:52:00', 'Navy: Investigación Criminal ''En tierra''.', 'Dulles está atrapado en el aeropuerto debido al mal tiempo. DiNozzo, Bishop y Jake trabajan en un caso que implica una amenaza terrorista en los aeropuertos del noreste durante Acción de Gracias.'),
(6, '2018-03-06', '07:30:00', '¿Quién vive ahí?', 'Espacio en el que se muestran algunas residencias y lugares singulares que, por alguna razón, son únicos. Los dueños de estas viviendas cuentan en primera persona la vida e historia de los hogares donde habitan.'),
(6, '2018-03-06', '09:15:00', 'Crímenes imperfectos.', 'Deja de lado la investigación forense propiamente dicha y se centra en el aspecto judicial de los crímenes, en cómo el dinero puede comprar la justicia y en la labor de los medios de comunicación en la resolución de los casos.'),
(6, '2018-03-06', '10:15:00', 'Las primeras 48 horas', 'Inmersos en una Unidad de Homicidios de detectives de élite, el equipo documental conseguirá filmar las primeras 48 horas, críticas para la resolución del caso.'),
(6, '2018-03-06', '11:00:00', 'Al rojo vivo previo', 'Programa de actualidad presentado por Antonio García Ferreras.'),
(6, '2018-03-06', '12:30:00', 'Al rojo vivo', 'Antonio G. Ferreras dirige y presenta este espacio de debate sobre la actualidad, fundamentalmente política, y lejos de una línea editorial conservadora.'),
(6, '2018-03-06', '14:00:00', 'La Sexta Noticias', '1ª edición Repaso a la actualidad del día de la mano de los servicios informativos de La sexta. Presentado por Elena Resano.'),
(6, '2018-03-06', '14:55:00', 'La Sexta noticias', 'Jugones Actualidad, investigación y las mejores imágenes del deporte se dan cita en la sobremesa de laSexta en la nueva temporada de Jugones, con Josep Pedrerol al frente. El programa, copresentado por Lara Álvarez, contará además con análisis de los especialista'),
(6, '2018-03-06', '15:20:00', 'Jugones', 'el análisis Programa deportivo dirigido por Josep Pedrerol.'),
(6, '2018-03-06', '15:30:00', 'La Sexta Meteo', '1ª edición Le damos una vuelta de tuerca a anticiclones, borrascas, nevadas y olas de calor. La previsión del tiempo de la mano de Lluís Obiols, Adrián Cordero'),
(6, '2018-03-06', '15:45:00', 'Zapeando', 'Frank Blanco y su equipo amenizan cada tarde las sobremesas con Zapeando, el ojo crítico más divertido de la televisión.'),
(6, '2018-03-06', '17:15:00', 'Más vale tarde', 'Mamen Mendizábal, Hilario Pino y su equipo te traen la información vespertina de lunes a viernes. (Hace más de 1 hora que empezó)'),
(6, '2018-03-06', '20:00:00', 'La Sexta Noticias', '2ª edición Informativo nocturno de laSexta presentado por Cristina Saavedra.'),
(6, '2018-03-06', '20:55:00', 'Estación Sexta', 'Nuevo espacio dedicado al medio ambiente y la meteorología. Alberto Herrera, Adrián Cordero y Lluís Obiols te ofrecen la información del tiempo, además de imágenes, noticias y reportajes relacionados con nuestro entorno natural.'),
(6, '2018-03-06', '21:05:00', 'The Very Best of', 'El Intermedio Emisión de los mejores momentos de todos los programas de la temporada.'),
(6, '2018-03-06', '21:30:00', 'El Intermedio', 'Programa de actualidad y humor presentado por el Gran Wyoming y Sandra Sabatés. Con Thais Villas, Dani Mateo, Gonzo y Joaquín Reyes.'),
(6, '2018-03-06', '22:30:00', 'Cine Los Juegos Del Hambre: Sinsajo.', 'Parte I Dir: Francis Lawrence. Int: Jennifer Lawrence, Josh Hutcherson, Liam Hemsworth, Woody Harrelson, Elizabeth Banks, Julianne Moore, Philip Seymour Hoffman, Jeffrey Wright (Ciencia Ficción, EE.UU., 2014) [Tráiler]'),
(6, '2018-03-07', '00:30:00', 'Policías en acción', 'La serie analiza el trabajo cotidiano de las Fuerzas de Seguridad del Estado. Desde persecuciones, detenciones, redadas y registros, la ayuda a los ciudadanos...'),
(6, '2018-03-07', '02:30:00', 'Poker Caribbean Adventure', 'La gran fiesta del poker vuelve al Caribe en el Atlantis de Bahamas. 10 días de torneos, más de 10 millones de dólares en juego'),
(6, '2018-03-07', '03:00:00', 'Comprando en casa', 'Espacio de teletienda.'),
(6, '2018-03-07', '04:00:00', 'Canal Ruleta', NULL),
(6, '2018-03-07', '04:55:00', 'Minutos musicales', 'Música en directo interpretada por artistas de primer nivel. Un espacio pensado y diseñado para los amantes de la música...'),
(6, '2018-03-07', '06:00:00', 'Minutos musicales', 'Música en directo interpretada por artistas de primer nivel. Un espacio pensado y diseñado para los amantes de la música...'),
(6, '2018-03-07', '06:15:00', 'Navy: Investigación Criminal', 'Es una exitosa serie de televisión producida por Donald P. Bellisario. Con dosis de humor, está centrada en un complejo pero entretenido y dinámico grupo, forzado a trabajar en situaciones de alto estrés.'),
(6, '2018-03-07', '07:30:00', '¿Quién vive ahí?', 'Espacio en el que se muestran algunas residencias y lugares singulares que, por alguna razón, son únicos. Los dueños de estas viviendas cuentan en primera persona la vida e historia de los hogares donde habitan.'),
(6, '2018-03-07', '09:15:00', 'Crímenes imperfectos', 'Deja de lado la investigación forense propiamente dicha y se centra en el aspecto judicial de los crímenes, en cómo el dinero puede comprar la justicia y en la labor de los medios de comunicación en la resolución de los casos.'),
(6, '2018-03-07', '10:15:00', 'Las primeras 48 horas', 'Inmersos en una Unidad de Homicidios de detectives de élite, el equipo documental conseguirá filmar las primeras 48 horas, críticas para la resolución del caso.'),
(6, '2018-03-07', '11:00:00', 'Al rojo vivo previo', 'Programa de actualidad presentado por Antonio García Ferreras.'),
(6, '2018-03-07', '12:30:00', 'Al rojo vivo', 'Antonio G. Ferreras dirige y presenta este espacio de debate sobre la actualidad, fundamentalmente política, y lejos de una línea editorial conservadora.'),
(6, '2018-03-07', '14:00:00', 'La Sexta Noticias 1ª edición', 'Repaso a la actualidad del día de la mano de los servicios informativos de La sexta. Presentado por Elena Resano.'),
(6, '2018-03-07', '14:55:00', 'La Sexta noticias: Jugones', 'Actualidad, investigación y las mejores imágenes del deporte se dan cita en la sobremesa de laSexta en la nueva temporada de Jugones, con Josep Pedrerol al frente. El programa, copresentado por Lara Álvarez, contará además con análisis de los especialista'),
(6, '2018-03-07', '15:20:00', 'Jugones: el análisis', 'Programa deportivo dirigido por Josep Pedrerol.'),
(6, '2018-03-07', '15:30:00', 'La Sexta Meteo 1ª edición', 'Toda la información meteorológica a cargo de Lluis Obiols y Adrián Cordero.'),
(6, '2018-03-07', '15:45:00', 'Zapeando', 'Frank Blanco y su equipo amenizan cada tarde las sobremesas con Zapeando, el ojo crítico más divertido de la televisión.'),
(6, '2018-03-07', '17:15:00', 'Más vale tarde', 'Mamen Mendizábal, Hilario Pino y su equipo te traen la información vespertina de lunes a viernes. '),
(6, '2018-03-07', '20:00:00', 'La Sexta Noticias 2ª edición', 'Informativo nocturno de laSexta presentado por Cristina Saavedra.'),
(6, '2018-03-07', '20:55:00', 'Estación Sexta', 'Nuevo espacio dedicado al medio ambiente y la meteorología. Alberto Herrera, Adrián Cordero y Lluís Obiols te ofrecen la información del tiempo, además de imágenes, noticias y reportajes relacionados con nuestro entorno natural.'),
(6, '2018-03-07', '21:05:00', 'La Sexta Deportes 2ª edición', 'María Martínez, Óscar Rincón, Carlota Reig y Susana Guasch te acercan la información deportiva más completa.'),
(6, '2018-03-07', '21:30:00', 'El Intermedio', 'Programa de actualidad y humor presentado por el Gran Wyoming y Sandra Sabatés. Con Thais Villas, Dani Mateo, Gonzo y Joaquín Reyes.'),
(6, '2018-03-07', '22:30:00', 'Cine Jack y su Gemela', 'Dir: Dennis Dugan. Int: Adam Sandler, Al Pacino, Katie Holmes, Dana Carvey, Natalie Gal, Shaquille O''Neal, Regis Philbin, Santiago Segura, Valerie Mahaffey, Krystle Mataras (Comedia, EE.UU., 2011) [Tráiler]'),
(6, '2018-03-08', '01:10:00', 'Policías en acción', 'La serie analiza el trabajo cotidiano de las Fuerzas de Seguridad del Estado. Desde persecuciones, detenciones, redadas y registros, la ayuda a los ciudadanos...'),
(6, '2018-03-08', '02:30:00', 'Comprando en casa', 'Espacio de teletienda.'),
(6, '2018-03-08', '03:30:00', 'Canal Ruleta', NULL),
(6, '2018-03-08', '04:30:00', 'Minutos musicales', 'Música en directo interpretada por artistas de primer nivel. Un espacio pensado y diseñado para los amantes de la música...'),
(6, '2018-03-08', '06:00:00', 'Minutos musicales', 'Música en directo interpretada por artistas de primer nivel. Un espacio pensado y diseñado para los amantes de la música...'),
(6, '2018-03-08', '06:15:00', 'Navy: Investigación Criminal', 'El NCIS es un grupo especial de la Marina del ejército de los Estados Unidos que investiga todo tipo de crímenes que puedan tener relación con este cuerpo, desde asesinatos hasta espionaje, pasando por ataques terroristas o robos de submarinos.'),
(6, '2018-03-08', '07:30:00', '¿Quién vive ahí?', 'Espacio en el que se muestran algunas residencias y lugares singulares que, por alguna razón, son únicos. Los dueños de estas viviendas cuentan en primera persona la vida e historia de los hogares donde habitan.'),
(6, '2018-03-08', '09:15:00', 'Crímenes imperfectos', 'Deja de lado la investigación forense propiamente dicha y se centra en el aspecto judicial de los crímenes, en cómo el dinero puede comprar la justicia y en la labor de los medios de comunicación en la resolución de los casos.'),
(6, '2018-03-08', '10:15:00', 'Las primeras 48 horas', 'Inmersos en una Unidad de Homicidios de detectives de élite, el equipo documental conseguirá filmar las primeras 48 horas, críticas para la resolución del caso.'),
(6, '2018-03-08', '11:00:00', 'Al rojo vivo previo', 'Programa de actualidad presentado por Antonio García Ferreras.'),
(6, '2018-03-08', '12:30:00', 'Al rojo vivo', 'Antonio G. Ferreras dirige y presenta este espacio de debate sobre la actualidad, fundamentalmente política, y lejos de una línea editorial conservadora.'),
(6, '2018-03-08', '14:00:00', 'La Sexta Noticias 1ª edición', 'Repaso a la actualidad del día de la mano de los servicios informativos de La sexta. Presentado por Elena Resano.'),
(6, '2018-03-08', '14:55:00', 'La Sexta noticias: Jugones', 'Actualidad, investigación y las mejores imágenes del deporte se dan cita en la sobremesa de laSexta en la nueva temporada de Jugones, con Josep Pedrerol al frente. El programa, copresentado por Lara Álvarez, contará además con análisis de los especialista'),
(6, '2018-03-08', '15:20:00', 'Jugones: el análisis', 'Programa deportivo dirigido por Josep Pedrerol.'),
(6, '2018-03-08', '15:30:00', 'La Sexta Meteo 1ª edición', 'Toda la información meteorológica a cargo de Lluis Obiols y Adrián Cordero.'),
(6, '2018-03-08', '15:45:00', 'Zapeando', 'Frank Blanco y su equipo amenizan cada tarde las sobremesas con Zapeando, el ojo crítico más divertido de la televisión.'),
(6, '2018-03-08', '17:15:00', 'Más vale tarde', 'Mamen Mendizábal, Hilario Pino y su equipo te traen la información vespertina de lunes a viernes.'),
(6, '2018-03-08', '20:00:00', 'La Sexta Noticias 2ª edición', 'Informativo nocturno de laSexta presentado por Cristina Saavedra.'),
(6, '2018-03-08', '20:55:00', 'Estación Sexta', 'Nuevo espacio dedicado al medio ambiente y la meteorología. Alberto Herrera, Adrián Cordero y Lluís Obiols te ofrecen la información del tiempo, además de imágenes, noticias y reportajes relacionados con nuestro entorno natural.'),
(6, '2018-03-08', '21:05:00', 'La Sexta Deportes 2ª edición', 'María Martínez, Óscar Rincón, Carlota Reig y Susana Guasch te acercan la información deportiva más completa.'),
(6, '2018-03-08', '21:30:00', 'El Intermedio', 'Programa de actualidad y humor presentado por el Gran Wyoming y Sandra Sabatés. Con Thais Villas, Dani Mateo, Gonzo y Joaquín Reyes.'),
(6, '2018-03-08', '22:30:00', 'Cine Thelma y Louise', 'Dir: Ridley Scott. Int: Susan Sarandon, Geena Davis, Harvey Keitel, Brad Pitt, Michael Madsen (Policíaca, EE.UU., 1991)');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `programa_1_06`
--

DROP TABLE IF EXISTS `programa_1_06`;
CREATE TABLE `programa_1_06` (
  `idcanal` tinyint(3) UNSIGNED NOT NULL,
  `fecha` date NOT NULL,
  `hora` time NOT NULL,
  `nombre` varchar(100) DEFAULT NULL,
  `descripcion` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `programa_1_06`
--

INSERT INTO `programa_1_06` (`idcanal`, `fecha`, `hora`, `nombre`, `descripcion`) VALUES
(1, '2018-03-06', '00:05:00', 'Comando actualidad', '''El infierno de alquilar''. Vivir de alquiler en España es cada vez más caro. En las grandes ciudades hay cada vez más personas que quieren vivir de alquiler y menos casas disponibles. Además, en el centro de las grandes ciudades, los barrios se vacían de vecinos y se llenan de turistas.'),
(1, '2018-03-06', '01:05:00', 'Comando actualidad', '''Para entrar en calor''. El frío invernal es más llevadero con platos calientes y elaborados. Este espacio recorre la geografía española para mostrar diferentes desgustaciones como la pringá, las alubias del Barco de Ávila, el cocido montañés, el gazpacho manchego y el torrezno.'),
(1, '2018-03-06', '02:05:00', 'Comando actualidad', '''De pata negra''. Basta con nombrar el producto para saber su procedencia y viceversa: con sólo evocar un pueblo, viene a la cabeza aquel alimento que elaboran, cultivan o capturan mejor que nadie.'),
(1, '2018-03-06', '03:15:00', 'La noche en 24H', 'Informativo diario presentado por Víctor Arribas que incluye entrevistas y debates sobre diversas cuestiones de actualidad. El programa ofrece la posibilidad de que los espectadores participen opinando sobre las cuestiones debatidas mediante un foro en la web de RTVE.'),
(1, '2018-03-06', '05:15:00', 'Noticias 24 horas', 'Conexión con el canal de noticias 24 horas.'),
(1, '2018-03-06', '06:00:00', 'Noticias 24 horas', 'Conexión con el canal de noticias 24 horas.'),
(1, '2018-03-06', '06:30:00', 'Telediario Matinal', 'Rápido y exhaustivo repaso de todas las noticias de interés general conducido por Diego Losada y Ana Ibáñez. Además, se ofrece la actualidad meteorológica de España y Europa y el estado de la mar'),
(1, '2018-03-06', '08:30:00', 'Los desayunos de TVE', 'Programa de análisis de la actualidad, entrevistas y tertulias. Con Sergio Martín como presentador, el espacio da cabida a las diversas opiniones que expresa su panel de comentaristas, representativo del más amplio abanico de sensibilidades.'),
(1, '2018-03-06', '10:00:00', 'La mañana de La 1', 'Magacín matinal que reúne información de actualidad, entrevistas, reportajes y diversas secciones divulgativas, entre ellas el espacio de salud ''Saber vivir''. Silvia Jato conduce este espacio diario que además da cobertura a las noticias más importantes del día.'),
(1, '2018-03-06', '12:00:00', 'Saber vivir', 'Macarena Berlín presenta este programa sobre salud, que diariamente aborda un tema médico. ''''Saber vivir'''' cuenta con la presencia de varios especialistas según el tema del día que ayudan a resolver las dudas de los espectadores.'),
(1, '2018-03-06', '12:30:00', 'Amigas y conocidas', 'Inés Ballester y Berta Collado capitanean un grupo de mujeres que tratan y analizan una amplia variedad de temas sociales y políticos.'),
(1, '2018-03-06', '13:25:00', 'Torres en la cocina', '''Rape alangostado y berenjenas rellenas''. Un rape alantostinado, cocinado con una marinada de pimentón realmente original y unas berenjenas rellenas ''''de toda la vida'''', pero dándoles una vuelta para convertirlas en un plato nuevo y mucho más atractivo.'),
(1, '2018-03-06', '14:00:00', 'Informativo territorial', 'Desconexión de cada uno de los centros territoriales de TVE que incluye la emisión de su informativo.'),
(1, '2018-03-06', '14:30:00', 'Corazón', 'Magacín rosa que combina información sobre famosos, consejos de belleza, moda y noticias de estrenos teatrales y cinematográficos.'),
(1, '2018-03-06', '15:00:00', 'Telediario 1', 'El noticiario audiovisual más veterano de la historia de la televisión en España. Pilar García Muñiz está al frente de este repaso diario a la actualidad general de España y el mundo. Sergio Sauca le acompaña en el apartado deportivo.'),
(1, '2018-03-06', '16:00:00', 'Informativo territorial', 'Desconexión de cada uno de los centros territoriales de TVE que incluye la emisión de su informativo.'),
(1, '2018-03-06', '16:15:00', 'El tiempo', 'Previsión meteorológica para los próximos días.'),
(1, '2018-03-06', '16:25:00', 'Servir y proteger', 'Alicia intenta asimilar la difícil verdad sobre su hermano mientras Julio no comprende qué ha pasado. Jairo, mientras tanto, descubre que Paty ha dado calabazas a David. Fede, paralelamente, quiere compartir piso con Espe y Lola. Finalmente, Iker y Nerea se acuestan.'),
(1, '2018-03-06', '17:15:00', 'Acacias, 38', 'Silvia acepta la propuesta de Zavala e intuye que algo importante planea con Tamayo. Mientras tanto, Rosina tiene un ataque de gota e insta a Liberto a ir a la ópera con Flora. Al mismo tiempo, hay una serie de altercados en la mina y los Alday temen por Diego. Leonor, por su parte, le da una información secreta a Blanca sobre el yacimiento.'),
(1, '2018-03-06', '18:10:00', 'Centro médico', 'A través de algunos actores, que interpretan a médicos y enfermeras, se recrean historias basadas en casos clínicos reales, curiosos y atractivos. (Empezó hace 20'')'),
(1, '2018-03-06', '19:25:00', 'España directo', 'Magacín informativo muy en contacto con los temas sociales que incluye conexiones con todos los rincones de la geografía nacional. El programa pretende acercarse al espectador gracias a la abundancia de intervenciones en directo y a la espontaneidad de sus reporteros. (Empieza dentro de 55'')'),
(1, '2018-03-06', '20:30:00', 'Aquí la Tierra', 'Jacob Petrus ofrece una original mirada sobre el territorio y sus habitantes a través de la meteorología. La divulgación y la información sobre el terreno conviven con el descubrimiento de la naturaleza y el medio ambiente.'),
(1, '2018-03-06', '21:00:00', 'Telediario 2', 'Ana Blanco da la cara por los cientos de profesionales de TVE que salen cada día a la calle en busca de noticias. El resultado, un completo repaso a la actualidad nacional e internacional. Jesús Álvarez se ocupa de presentar la parcela deportiva.'),
(1, '2018-03-06', '21:50:00', 'El Tiempo', 'Información meteorológica.'),
(1, '2018-03-06', '22:05:00', 'Hora punta', 'Javier Cárdenas conduce un espacio que combina entrevistas y reportajes. El presentador cuenta con la participación de colaboradores que ponen el toque de humor al programa.'),
(1, '2018-03-06', '22:35:00', 'Cine Una historia de venganza', 'Dir: Elliott Lester. Int: Arnold Schwarzenegger, Scoot McNairy, Maggie Grace, Kevin Zegers, Hannah Ware, Glenn Morshower, Mariana Klaveno, Mo McRae, Theresa Cook (Thriller, EE.UU., 2017) [Tráiler]');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `programa_1_08`
--

DROP TABLE IF EXISTS `programa_1_08`;
CREATE TABLE `programa_1_08` (
  `idcanal` tinyint(3) UNSIGNED NOT NULL,
  `fecha` date NOT NULL,
  `hora` time NOT NULL,
  `nombre` varchar(100) DEFAULT NULL,
  `descripcion` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `programa_1_08`
--

INSERT INTO `programa_1_08` (`idcanal`, `fecha`, `hora`, `nombre`, `descripcion`) VALUES
(1, '2018-03-08', '00:05:00', 'Ochéntame otra vez', 'Un retrato nostálgico a la España de la década de 1980. El programa recurre a imágenes de archivo y al testimonio de personas significativas, tanto de los que protagonizaron la vida del momento como de los que nacieron en aquellos años y hoy son referencia en su ámbito.'),
(1, '2018-03-08', '01:00:00', 'Ochéntame otra vez', 'Un retrato nostálgico a la España de la década de 1980. El programa recurre a imágenes de archivo y al testimonio de personas significativas, tanto de los que protagonizaron la vida del momento como de los que nacieron en aquellos años y hoy son referencia en su ámbito.'),
(1, '2018-03-08', '01:55:00', 'La noche en 24H', 'Informativo diario presentado por Víctor Arribas que incluye entrevistas y debates sobre diversas cuestiones de actualidad. El programa ofrece la posibilidad de que los espectadores participen opinando sobre las cuestiones debatidas mediante un foro en la web de RTVE.'),
(1, '2018-03-08', '03:50:00', 'Noticias 24H', 'Noticias de los servicios informativos del Canal 24 Horas. Producido por Televisión Española, este canal está dedicado íntegramente a ofrecer información de actualidad y es el más antiguo de los canales de este tipo en España.'),
(1, '2018-03-08', '06:00:00', 'Noticias 24H', 'Noticias de los servicios informativos del Canal 24 Horas. Producido por Televisión Española, este canal está dedicado íntegramente a ofrecer información de actualidad y es el más antiguo de los canales de este tipo en España.'),
(1, '2018-03-08', '06:30:00', 'Telediario Matinal', 'Rápido y exhaustivo repaso de todas las noticias de interés general conducido por Diego Losad1'),
(1, '2018-03-08', '08:30:00', 'Los desayunos de TVE', 'Programa de análisis de la actualidad, entrevistas y tertulias. Con Sergio Martín como presentador, el espacio da cabida a las diversas opiniones que expresa su panel de comentaristas, representativo del más amplio abanico de sensibilidades.'),
(1, '2018-03-08', '10:00:00', 'La mañana de La 1', 'Magacín matinal que reúne información de actualidad, entrevistas, reportajes y diversas secciones divulgativas, entre ellas el espacio de salud ''Saber vivir''. María Casado conduce este espacio diario que además da cobertura a las noticias más importantes del día.'),
(1, '2018-03-08', '12:00:00', 'Saber vivir', 'Macarena Berlín presenta este programa sobre salud, que diariamente aborda un tema médico. ''''Saber vivir'''' cuenta con la presencia de varios especialistas según el tema del día que ayudan a resolver las dudas de los espectadores.'),
(1, '2018-03-08', '12:30:00', 'Amigas y conocidas', 'Inés Ballester y Berta Collado capitanean un grupo de mujeres que tratan y analizan una amplia variedad de temas sociales y políticos.'),
(1, '2018-03-08', '13:25:00', 'Torres en la cocina', 'Los chefs Javier y Sergio Torres abren su cocina para enseñar a preparar recetas originales, sabrosas y asequibles. Una mezcla de tradición y modernidad en la que los gemelos recuperan los sabores y recuerdos de la infancia reinterpretados según nuestro tiempo.'),
(1, '2018-03-08', '14:00:00', 'Informativo territorial', 'Espacio dedicado a la información autonómica.'),
(1, '2018-03-08', '14:30:00', 'Corazón', 'Magazine que ofrece toda la actualidad de la crónica social acompañada de reportajes sobre moda, belleza y cultura, con especial interés a los eventos de alta costura y las novedades de las firmas de diseñadores españoles.'),
(1, '2018-03-08', '15:00:00', 'Telediario 1', 'El noticiario audiovisual más veterano de la historia de la televisión en España. Pilar García Muñiz está al frente de este repaso diario a la actualidad general de España y el mundo. Sergio Sauca le acompaña en el apartado deportivo.'),
(1, '2018-03-08', '16:00:00', 'Informativo territorial', 'Resumen Desconexión de cada uno de los centros territoriales de TVE que incluye la emisión de su informativo.'),
(1, '2018-03-08', '16:15:00', 'El tiempo', 'La mejor manera de enterarse de la previsión meteorológica para los próximos días. La información del tiempo de Televisión Española es un clásico de la historia audiovisual española. Avalada por el Instituto Nacional de Meteorología, goza de un alto nivel de acierto.'),
(1, '2018-03-08', '16:25:00', 'Servir y proteger', 'Lola y Espe siguen investigando los posibles malos tratos a Palmira. Gracias a Jesús, las policías descubren que el agresor podría ser Bruno, el hijo de la mujer. Alicia, por su parte, va a descubrir algo que va a cambiar su vida para siempre.'),
(1, '2018-03-08', '17:20:00', 'Acacias 38', 'Úrsula le encomienda a Riera que siga con su investigación. Mientras tanto, Martín ultima los detalles para su pedida y Casilda empieza a dudar de él. Silvia, por su parte, le entrega a Arturo el tarjetón de bodas. Finalmente, Blanca se rebela contra su madre y pone a Samuel en su lugar.'),
(1, '2018-03-08', '18:15:00', 'Centro médico', 'A través de algunos actores, que interpretan a médicos y enfermeras, se recrean historias basadas en casos clínicos reales,curiosos y atractivos.'),
(1, '2018-03-08', '19:25:00', 'España directo', 'Magazine conducido por Roberto Leal y Sandra Daviú en el apartado de sociedad. En cada edición se hará un recorrido por la geografía española para ofrecer a los espectadores la actualidad informativa desde el lugar dónde se produce la noticia.'),
(1, '2018-03-08', '20:30:00', 'Aquí la Tierra', 'Jacob Petrus, geógrafo especializado en climatología, nos da una nueva visión de nuestro planeta y demuestra cómo la salud, la arquitectura, la conducta, incluso el arte o la economía, pueden estar condicionados por la meteorología.'),
(1, '2018-03-08', '21:00:00', 'Telediario 2', 'Ana Blanco da la cara por los cientos de profesionales de TVE que salen cada día a la calle en busca de noticias. El resultado, un completo repaso a la actualidad nacional e internacional. Jesús Álvarez se ocupan de presentar la parcela deportiva.'),
(1, '2018-03-08', '21:50:00', 'El Tiempo', 'Información meteorológica.'),
(1, '2018-03-08', '22:05:00', 'Hora punta', 'Javier Cárdenas conduce un espacio que combina entrevistas y reportajes. El presentador cuenta con la participación de colaboradores que ponen el toque de humor al programa.'),
(1, '2018-03-08', '22:40:00', 'Cuéntame cómo pasó', '''Perdonar es fácil, si sabes cómo''. Los Alcántara se unen con el objetivo de agasajar a Paquita y conseguir que les perdone.');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `programa_2_06`
--

DROP TABLE IF EXISTS `programa_2_06`;
CREATE TABLE `programa_2_06` (
  `idcanal` tinyint(3) UNSIGNED NOT NULL,
  `fecha` date NOT NULL,
  `hora` time NOT NULL,
  `nombre` varchar(100) DEFAULT NULL,
  `descripcion` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `programa_2_06`
--

INSERT INTO `programa_2_06` (`idcanal`, `fecha`, `hora`, `nombre`, `descripcion`) VALUES
(2, '2018-03-06', '00:40:00', 'La 2 Noticias', 'Espacio informativo de La 2 que cada día nos trae la actualidad más destacada desde otro punto de vista, centrado sobre todo en noticias sociales, culturales y científicas. También ofrece entrevistas con personajes de interés para ahondar en alguno de los temas de actualidad tratados en el informativo.'),
(2, '2018-03-06', '01:05:00', 'Documental', '''Mujeres que hicieron historia: Juana de Arco''. Juana de Arco estaba profundamente convencida de su misión divina; con tan sólo 17 años condujo a los franceses a la victoria en Orleans contra los ingleses. Al final fue víctima del rígido sistema político y social medieval. En 1431 murió en la hoguera en Rouen.'),
(2, '2018-03-06', '01:55:00', 'Conciertos de Radio-3', '''Marinah''. Programa que recoge la actuación de algún cantante, grupo o instrumentista del más actual panorama musical, con predominio de artistas españoles y latinos. El objetivo es abrir las puertas a aquellos artistas y grupos que existen al margen de las listas de ventas.'),
(2, '2018-03-06', '02:20:00', 'Documenta2', '''Las princesas americanas del millón de dólares''. Winnaretta Singer emergió de una infancia difícil hasta convertirse en una mecenas de la música. La originalidad de Sarah Murphy la convirtieron en musa de artistas y, Peggy Guggenheim fue una campeona del modernismo, mostró al público el revolucionario arte moderno.'),
(2, '2018-03-06', '03:05:00', 'Documental', '''Las tribus y yo: el pueblo Anaconda del Amazonas''. Gordon Buchanan viaja a la selva amazónica para conocer a los Huorani y aprender de su estrecha relación con el entorno, algunos secretos de los animales.'),
(2, '2018-03-06', '04:00:00', 'Documental', '''Biebzra - el Amazonas europeo''. Protegido por el parque nacional más grande de Polonia, el río Biebrza y sus lagunas son uno de los refugios naturales más importantes de Europa. Mamíferos, aves, anfibios, insectos y peces se muestran de una manera nunca antes vista en la llamada Amazonia europea.'),
(2, '2018-03-06', '04:50:00', 'Conciertos de Radio-3', 'Programa que recoge la actuación de algún cantante, grupo o instrumentista del más actual panorama musical, con predominio de artistas españoles y latinos. El objetivo es abrir las puertas a aquellos artistas y grupos que existen al margen de las listas de ventas.'),
(2, '2018-03-06', '06:00:00', 'Conciertos de Radio-3', 'Programa que recoge la actuación de algún cantante, grupo o instrumentista del más actual panorama musical, con predominio de artistas españoles y latinos. El objetivo es abrir las puertas a aquellos artistas y grupos que existen al margen de las listas de ventas.'),
(2, '2018-03-06', '06:30:00', 'That''s English', 'Programa divulgativo que ofrece un curso de inglés a distancia, creado por el Ministerio de Educación en colaboración con la BBC británica y Televisión Española. El curso permite obtener el Certificado del Ciclo Elemental de la Escuela Oficial de Idiomas.'),
(2, '2018-03-06', '07:00:00', '¡Qué animal!', '''Desierto de Tabernas''. Tabernas es el único espacio natural en Europa considerado desierto. Su superficie aloja animales como el lirón careto, el escorpión amarillo o el abejaruco. La chef Carme Ruscalleda enseñará el uso de la salicornia europea en la cocina, una planta típica del lugar.'),
(2, '2018-03-06', '07:30:00', 'Inglés Online', 'Curso de ingles de Televisión Española para hisponoparlantes.'),
(2, '2018-03-06', '08:00:00', 'Documental', '''Meganaturaleza''. Muchas veces sobrevivir a la naturaleza requiere convivir en grupo para no ser devorados y poder alimentarse. Este espacio muestra los diferentes rebaños de mamíferos, bancos de peces, enjambres de abejas o bandadas de pájaros que realizan esta táctica.'),
(2, '2018-03-06', '09:00:00', 'España en comunidad', 'Programa que ofrece reportajes en profundidad e información de actualidad sobre las distintas comunidades autónomas españolas. Está realizado por los centros territoriales y de producción de TVE, aunque cuenta con una pequeña redacción en Madrid.'),
(2, '2018-03-06', '09:30:00', 'Aquí hay trabajo', 'Un espacio que resume la actualidad del mundo laboral, con información sobre su situación, sobre becas y cursos de formación. Todo apoyado con invitados especialistas. Además, el programa muestra ofertas de empleo a las que pueden acceder los televidentes.'),
(2, '2018-03-06', '09:55:00', 'La aventura del saber', 'Programa diario matinal destinado a la formación educativa y la divulgación mediante entrevistas y series documentales. Coproducido por RTVE y el Ministerio de Educación, se trata de uno de los espacios más veteranos de la cadena, con más de 21 años en antena.'),
(2, '2018-03-06', '10:50:00', 'Documental', '''Los primeros hombres: África''. Hace 200.000 años, el homo sapiens apareció por primera vez en las llanuras de África. Pero los últimos estudios demuestran que no procedemos de una única especie sino que somos el resultado de la interacción entre diversas especies.'),
(2, '2018-03-06', '11:45:00', 'Documenta2', '''El imperio de los zares: La era de los extremos''. En el magnífico palacio de Peterhof cerca de San Petersburgo, Lucy muestra el ascenso meteórico de Catalina la Grande, quien se apoderó del trono ruso de su marido Pedro III en 1762 y se convirtió en la mujer más poderosa del mundo.'),
(2, '2018-03-06', '12:35:00', 'Mañanas de Cine Reverendo Colt Dir: León Klimovsky.', 'Int: Guy Madison, Richard Harrison , Ennio Girolami, María Martín , Germán Cobos, Ignazio Spalla, Steven Tedd, Perla Cristal, Alfonso Rojas (Oeste, España - Italia, 1970)'),
(2, '2018-03-06', '13:50:00', 'Documental Mercados', ':en el vientre de la ciudad.'),
(2, '2018-03-06', '14:55:00', 'Documental', '''Grandes viajes ferroviarios continentales: De la Selva Negra hasta Hannover''. Con su Guía Bradshaw de 1913 siempre en la mano, Michael Portillo se adentra en la Selva Negra para intentar dar con la esencia de Alemania, y descubre que Hansel y Gretel ayudaron a unificar la nación. Su viaje termina en la ciudad de Hannover.'),
(2, '2018-03-06', '15:50:00', 'Saber y ganar', 'Programa concurso en el que tres concursante participan en diversas pruebas demostrando sus conocimientos y agilidad mental.'),
(2, '2018-03-06', '16:30:00', 'Grandes documentales', 'Las islas Canarias.'),
(2, '2018-03-06', '17:20:00', 'Grandes documentales', '''Una manada en guerra''. El delta del Okawando, un entorno hostil y salvaje, es un territorio habitado por manadas de leones en conflicto. En Xakanada, dos poderosos machos lideran una manada que se ha especializado en matar búfalos cafre, una de las presas más combativas de África.'),
(2, '2018-03-06', '18:10:00', 'Documenta2', '''Las princesas americanas del millón de dólares''. A finales del s.XIX, Inglaterra tuvo una fuerte depresión agrícola y los empobrecidos aristócratas buscaron una nueva oportunidad casándose con las ricas herederas estadounidenses. McGovern muestra cómo eran estas mujeres, que le sirvieron para inspirarse como actriz. (Empezó hace 22'')'),
(2, '2018-03-06', '19:05:00', 'Documental', '''Mercados, en el vientre de la ciudad: Amsterdam''. Uno de los mercados más antiguos de Ámsterdam es el Albert Cuyp Markt, un mercado callejero que se extiende a lo largo del barrio De Pijp. Aquí podemos disfrutar de los mejores arenques de la ciudad, y luego hacer un viaje a Gouda para buscar la receta de Stroopwafels. (Empieza dentro de 33'')'),
(2, '2018-03-06', '20:00:00', 'Concierto víctimas del terrorismo', 'Desde el Auditorio Nacional de Música y organizado por la Fundación Víctimas del Terrorismo, se emite este concierto de la orquesta sinfónica RTVE, con la soprano Milagros Poblador, la mezzosoprano Diletta Scandiuzzi, el barítono Samuel Youn y el tenor José Pazos.'),
(2, '2018-03-06', '21:30:00', 'Página 2', '''Leonardo Padura''. Leonardo Padura nos presenta ''La transparecia del tiempo'', su última obra. En el reportaje, Libu: la fantástia labor de esta librería. Además, James Ellroy responde al cuestionario y conocemos la Biblioteca de la Sociedad Bilbaína.'),
(2, '2018-03-06', '21:55:00', 'Historia de nuestro cine', 'Vida perra Dir: Javier Aguirre. Int: Esperanza Roy (Drama, España, 1982)'),
(2, '2018-03-06', '23:45:00', 'Documentos Tv', '''La poetisa''. Una mujer desafía al gobierno saudí recitando poemas en el ''reality show'' de mayor audiencia de Oriente Próximo. Hissa Helal, la primera mujer participante del concurso de poesía árabe “El poeta del millón” ha convertido su recital en un alegato político contra la intransigencia religiosa y social hacia las mujeres saudíes. Sus críticas en defensa de los derechos usurpados a las mujeres');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `programa_2_08`
--

DROP TABLE IF EXISTS `programa_2_08`;
CREATE TABLE `programa_2_08` (
  `idcanal` tinyint(3) UNSIGNED NOT NULL,
  `fecha` date NOT NULL,
  `hora` time NOT NULL,
  `nombre` varchar(100) DEFAULT NULL,
  `descripcion` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `programa_2_08`
--

INSERT INTO `programa_2_08` (`idcanal`, `fecha`, `hora`, `nombre`, `descripcion`) VALUES
(2, '2018-03-08', '00:15:00', 'Conecta con el mercado', 'Espacio que muestra información sobre la actividad de las empresas españolas en el exterior. Esta segunda temporada está orientada a sensibilizar y motivar a los emprendedores sobre la necesidad y las ventajas de la internacionalización.'),
(2, '2018-03-08', '00:45:00', 'La 2 Noticias', 'Espacio informativo de La 2 que cada día nos trae la actualidad más destacada desde otro punto de vista, centrado sobre todo en noticias sociales, culturales y científicas. También ofrece entrevistas con personajes de interés para ahondar en alguno de los temas de actualidad tratados en el informativo.'),
(2, '2018-03-08', '01:15:00', 'Conecta con el mercado', 'Espacio que muestra información sobre la actividad de las empresas españolas en el exterior. Esta segunda temporada está orientada a sensibilizar y motivar a los emprendedores sobre la necesidad y las ventajas de la internacionalización.'),
(2, '2018-03-08', '01:45:00', 'Documental', 'Serie de documentales.'),
(2, '2018-03-08', '02:30:00', 'Conciertos de Radio-3', 'Programa que recoge la actuación de algún cantante, grupo o instrumentista del más actual panorama musical, con predominio de artistas españoles y latinos. El objetivo es abrir las puertas a aquellos artistas y grupos que existen al margen de las listas de ventas.'),
(2, '2018-03-08', '03:00:00', 'Documental', 'Serie de documentales.'),
(2, '2018-03-08', '04:00:00', 'Documental', 'Serie de documentales.'),
(2, '2018-03-08', '04:55:00', 'Documental', 'Serie de documentales.'),
(2, '2018-03-08', '05:45:00', 'Conciertos de Radio-3', 'Programa que recoge la actuación de algún cantante, grupo o instrumentista del más actual panorama musical, con predominio de artistas españoles y latinos. El objetivo es abrir las puertas a aquellos artistas y grupos que existen al margen de las listas de ventas.'),
(2, '2018-03-08', '06:30:00', 'That''s English', 'Programa divulgativo que ofrece un curso de inglés a distancia, creado por el Ministerio de Educación en colaboración con la BBC británica y Televisión Española. El curso permite obtener el Certificado del Ciclo Elemental de la Escuela Oficial de Idiomas.'),
(2, '2018-03-08', '07:00:00', 'Zoom tendencias', 'Espacio semanal dedicado a destacar y analizar el estilo de vida actual proponiendo reportajes de interiorismo, moda, restauración o cosmética. Aquellas tendencias que marcan la forma de ser hoy en día, serán tratadas en el programa.'),
(2, '2018-03-08', '07:30:00', 'Inglés Online', 'Curso de ingles de Televisión Española para hisponoparlantes.'),
(2, '2018-03-08', '08:00:00', 'Documental', 'Serie de documentales.'),
(2, '2018-03-08', '09:00:00', 'Pueblo de Dios', 'Programa religioso que ofrece reportajes sobre el trabajo que realizan las ONG o comunidades religiosas en España y en el mundo. Retrata los proyectos que se desarrollan en el campo de la educación y la salud para ayudar a las capas sociales más necesitadas.'),
(2, '2018-03-08', '09:30:00', 'Aquí hay trabajo', 'Un espacio que resume la actualidad del mundo laboral, con información sobre su situación, sobre becas y cursos de formación. Todo apoyado con invitados especialistas. Además, el programa muestra ofertas de empleo a las que pueden acceder los televidentes.'),
(2, '2018-03-08', '09:55:00', 'La aventura del saber', 'Programa diario matinal destinado a la formación educativa y la divulgación mediante entrevistas y series documentales. Coproducido por RTVE y el Ministerio de Educación, se trata de uno de los espacios más veteranos de la cadena, con más de 21 años en antena.'),
(2, '2018-03-08', '10:50:00', 'Documental', '''Los primeros hombres''.'),
(2, '2018-03-08', '11:45:00', 'Documenta2', '''El imperio de los zares''.'),
(2, '2018-03-08', '12:45:00', 'Mañanas de Cine', 'Título por determinar.'),
(2, '2018-03-08', '14:45:00', 'Documental', 'Mercados: en el vientre de la ciudad.'),
(2, '2018-03-08', '15:40:00', 'Saber y ganar', 'Programa concurso en el que tres concursante participan en diversas pruebas demostrando sus conocimientos y agilidad mental.'),
(2, '2018-03-08', '16:30:00', 'Grandes documentales', 'Serie de documentales.'),
(2, '2018-03-08', '17:25:00', 'Grandes documentales', 'Serie de documentales.'),
(2, '2018-03-08', '18:10:00', 'Documenta2', 'Las princesas americanas del millón de dólares.'),
(2, '2018-03-08', '19:00:00', 'Documental', '''Mercados: en el vientre de la ciudad''.'),
(2, '2018-03-08', '19:50:00', 'Documental', 'Las tribus y yo.'),
(2, '2018-03-08', '20:50:00', 'Días de cine', 'Espacio que recoge la actualidad cinematográfica española e internacional desgranando los estrenos de la cartelera. El programa se hace eco, también, de lo que acontece en los festivales y repasa la trayectoria de actores y directores clave del séptimo arte.'),
(2, '2018-03-08', '22:00:00', 'Carnaval Internacional de Maspalomas 2018', '''Gala Drag Queen Maspalomas''. Del 2 al 11 de marzo, la localidad canaria de Maspalomas se viste de mil colores para celebrar su carnaval. Durante más de una semana, rondallas, murgas y comparsas recorren las calles del municipio dejando a su paso un ambiente de fiesta en general.'),
(6, '2018-03-08', '06:00:00', 'Conciertos de Radio-3', 'Programa que recoge la actuación de algún cantante, grupo o instrumentista del más actual panorama musical, con predominio de artistas españoles y latinos. El objetivo es abrir las puertas a aquellos artistas y grupos que existen al margen de las listas de ventas.');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `programa_3_06`
--

DROP TABLE IF EXISTS `programa_3_06`;
CREATE TABLE `programa_3_06` (
  `idcanal` tinyint(3) UNSIGNED NOT NULL,
  `fecha` date NOT NULL,
  `hora` time NOT NULL,
  `nombre` varchar(100) DEFAULT NULL,
  `descripcion` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `programa_3_06`
--

INSERT INTO `programa_3_06` (`idcanal`, `fecha`, `hora`, `nombre`, `descripcion`) VALUES
(3, '2018-03-06', '00:15:00', 'Cine', 'Torrente, el brazo tonto de la ley Dir: Santiago Segura. Int: Santiago Segura, Javier Cámara, Neus Asensi, Chus Lampreave, Tony Leblanc (Comedia, España, 1998)'),
(3, '2018-03-06', '01:45:00', 'Cine', 'Última salida Dir: John Fawcett. Int: Andrea Roth, Cathleen Robertson, Linden Ashby, Rachael Crawford (Intriga, EE.UU., 2006)'),
(3, '2018-03-06', '03:00:00', 'Campeonato europeo de póker', 'Campeonato europeo de póker televisado en Ganing Casino que emite las partidas de los mejores jugadores internacionales.'),
(3, '2018-03-06', '03:30:00', 'Comprando en casa', 'Espacio de teletienda.'),
(3, '2018-03-06', '04:00:00', 'Minutos musicales', 'Música en directo interpretada por artistas de primer nivel. Un espacio pensado y diseñado para los amantes de la música...'),
(3, '2018-03-06', '06:00:00', 'Minutos musicales', 'Música en directo interpretada por artistas de primer nivel. Un espacio pensado y diseñado para los amantes de la música...'),
(3, '2018-03-06', '06:15:00', 'Las noticias de la mañana', 'Esther Vaquero, Lorena García y María José Sáez son las encargadas de traer las noticias de ámbito nacional e internacional a primera hora de la mañana.'),
(3, '2018-03-06', '08:30:00', 'Un café con Susana', 'Espacio en el que Susana Griso entrevista al protagonista del día. La presentadora se sienta para conversar con personajes de la actualidad política, social y cultural con el fin de aportar al espectador información contada en primera persona.'),
(3, '2018-03-06', '09:00:00', 'Espejo público', 'El protagonismo de este magacín matinal presentado por Susanna Griso es del público, la calle y los directos.'),
(3, '2018-03-06', '13:15:00', 'Karlos Arguiñano en tu cocina', 'Con Karlos Arguiñano nos lo vamos a pasar en grande mientras aprendemos un poco más los secretos de la cocina. Platos sencillos y muy ricos para todos los bolsillos que nos harán nuestra vida mucho más sencilla.'),
(3, '2018-03-06', '13:40:00', 'La ruleta de la suerte', 'Concurso presentado por Jorge Fernández, de lunes a viernes, que pone a prueba la agilidad mental, los reflejos y los conocimientos de los participantes.'),
(3, '2018-03-06', '15:00:00', 'Noticias 1', 'María Rey y Sandra Golpe te esperan de lunes a viernes a las 15:00 h. Una cita con la información nacional e internacional.'),
(3, '2018-03-06', '15:45:00', 'Deportes 1', 'Rocío Martínez se encarga de presentar el espacio dedicado a las noticias de deportes.'),
(3, '2018-03-06', '16:00:00', 'Tu Tiempo', 'Información meteorológica. Con Roberto Brasero.'),
(3, '2018-03-06', '16:30:00', 'Amar es para siempre', 'El seguro médico exige una evaluación psiquiátrica a Ortega. Algo que el hombre no acepta. Javier hace un último intento de luchar por Susana sin el resultado esperado. Charo le traslada a María las sospechas de que Belén es su hija. Arrastrada por Emilio Losada, Luisita acaba metida en un grave problema.'),
(3, '2018-03-06', '17:30:00', 'El secreto de Puente Viejo', 'Julieta llega de la mano de su abuela a Puente Viejo con el objetivo de labrarse un futuro y echar raíces, al fin, en un lugar. Por otro lado, los hermanos Ortega, salvadores de Francisca Montenegro, vivirán bajo el amparo de una de las mujeres más importantes e influyentes del (Hace más de 1 hora que empezó)'),
(3, '2018-03-06', '18:45:00', '¡Ahora caigo!', 'Presentado por Arturo Valls. Es un concurso tan impredecible que la tierra se abrirá bajo tus pies. Un formato revolucionario que une el suspense de una batalla de preguntas con un elemento sorpresa: el puro azar. (Empieza dentro de 13'')'),
(3, '2018-03-06', '20:00:00', 'Uefa Champions League', 'Previo.'),
(3, '2018-03-06', '20:45:00', 'Uefa Champions League', 'París Saint Germain - Real Madrid.'),
(3, '2018-03-06', '22:40:00', 'Cuerpo de élite', '''El fútbol cuerpo de élite''. El Gobierno decide tomar medidas drásticas: hasta que todos los clubes no paguen su deuda, la Liga queda paralizada. Esta decisión sume el país en un caos y acaba con el intento de asesinato del Ministro de Hacienda. Cuerpo de Élite debe detener al culpable antes de que sea demasiado tarde.');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `programa_3_07`
--

DROP TABLE IF EXISTS `programa_3_07`;
CREATE TABLE `programa_3_07` (
  `idcanal` tinyint(3) UNSIGNED NOT NULL,
  `fecha` date NOT NULL,
  `hora` time NOT NULL,
  `nombre` varchar(100) DEFAULT NULL,
  `descripcion` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `programa_3_07`
--

INSERT INTO `programa_3_07` (`idcanal`, `fecha`, `hora`, `nombre`, `descripcion`) VALUES
(3, '2018-03-07', '00:15:00', 'Cine', 'El Inocente Dir: Brad Furman. Int: Matthew McConaughey, Marisa Tomei, Ryan Phillippe, William H. Macy, John Leguizamo, Michael Pena, Trace Adkins, Katherine Moennig, Erin Carufel (Intriga, EE.UU., 2011) [Tráiler]'),
(3, '2018-03-07', '02:30:00', 'Comprando en casa', 'Espacio de teletienda.'),
(3, '2018-03-07', '03:00:00', 'Minutos musicales', 'Música en directo interpretada por artistas de primer nivel. Un espacio pensado y diseñado para los amantes de la música...'),
(3, '2018-03-07', '06:15:00', 'Noticias de la mañana', 'Esther Vaquero, Lorena García y María José Sáez son las encargadas de traer las noticias de ámbito nacional e internacional a primera hora de la mañana.'),
(3, '2018-03-07', '08:30:00', 'Un café con Susana', 'Espacio en el que Susana Griso entrevista al protagonista del día. La presentadora se sienta para conversar con personajes de la actualidad política, social y cultural con el fin de aportar al espectador información contada en primera persona.'),
(3, '2018-03-07', '09:00:00', 'Espejo público', 'El protagonismo de este magacín matinal presentado por Susanna Griso es del público, la calle y los directos.'),
(3, '2018-03-07', '13:15:00', 'Karlos Arguiñano en tu cocina', 'Con Karlos Arguiñano nos lo vamos a pasar en grande mientras aprendemos un poco más los secretos de la cocina. Platos sencillos y muy ricos para todos los bolsillos que nos harán nuestra vida mucho más sencilla.'),
(3, '2018-03-07', '13:40:00', 'La ruleta de la suerte', 'Es un concurso presentado por Jorge Fernández, de lunes a viernes, que pone a prueba la agilidad mental, los reflejos y los conocimientos de los participantes.'),
(3, '2018-03-07', '15:00:00', 'Noticias 1', 'María Rey y Sandra Golpe te esperan de lunes a viernes a las 15:00 h. Una cita con la información nacional e internacional.'),
(3, '2018-03-07', '15:45:00', 'Deportes 1', 'Rocío Martínez se encarga de presentar el espacio dedicado a las noticias de deportes.'),
(3, '2018-03-07', '16:00:00', 'Tu Tiempo', 'Información meteorológica. Con Roberto Brasero.'),
(3, '2018-03-07', '16:30:00', 'Amar es para siempre', 'Luisita duerme en el calabozo y todo apunta a que Emilio Losada y sus amigos le quieren endosar toda la responsabilidad. Durán sospecha que la muerte de Requena ha sido un asesinato. Para intentar congraciarse con Durán, Ortega incluye un agradecimiento a Osuna en el nuevo prólogo de la biografía de Franco.'),
(3, '2018-03-07', '17:30:00', 'El secreto de Puente Viejo', 'Ante las noticias de la cercana llegada de Dos Caras, Nicolás explica a Emilia y Alfonso que va a seguir luchando para que se haga justicia. Francisca, por su parte, espera al momento de recibir la decisión de la asamblea, y Raimundo llega para decirle que quiere compartir su destino. Mientras tanto, Saúl y Prudencio se juntan con Larraz, que trae noticias de la asamblea: Francisca será fusilada.'),
(3, '2018-03-07', '18:45:00', 'Ahora caigo', 'Presentado por Arturo Valls. Es un concurso tan impredecible que la tierra se abrirá bajo tus pies. Un formato revolucionario que une el suspense de una batalla de preguntas con un elemento sorpresa: el puro azar.'),
(3, '2018-03-07', '20:00:00', '¡Boom!', 'Juanra Bonet presenta ¡Boom! un programa impredecible en el que los concursantes no podrán cortar el cable de la respuesta correcta.'),
(3, '2018-03-07', '21:00:00', 'Noticias 2', 'Lourdes Maldonado y Ángel Carreira te esperan de lunes a viernes a las 21:00h para informarte de todo lo que aco'),
(3, '2018-03-07', '21:30:00', 'Deportes', 'Manu Sánchez se encarga de presentar el espacio dedicado a las noticias de deportes.'),
(3, '2018-03-07', '21:40:00', 'La previsión de las 9', 'Presenta Roberto Brasero. Información meteorológica de la noche y previsión del tiempo para los próximos días.'),
(3, '2018-03-07', '21:45:00', 'El hormiguero 3.0', 'La periodista y presentadora Mariló Montero y el humorista Santi Rodríguez hablan de la próxima gala de ''''Hipnotízame'''', en la que serán dos de los invitados.'),
(3, '2018-03-07', '22:40:00', 'Fariña', 'Años 80. Galicia. La reconversión de la pesca ha dejado a una parte de la flota gallega en tierra y cientos de armadores endeudados. No hay trabajo. En los muchos pueblos de pescadores que recorren la costa gallega, la falta de ingresos y los pagos cotidianos estrangula las economías');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `programa_3_08`
--

DROP TABLE IF EXISTS `programa_3_08`;
CREATE TABLE `programa_3_08` (
  `idcanal` tinyint(3) UNSIGNED NOT NULL,
  `fecha` date NOT NULL,
  `hora` time NOT NULL,
  `nombre` varchar(100) DEFAULT NULL,
  `descripcion` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `programa_3_08`
--

INSERT INTO `programa_3_08` (`idcanal`, `fecha`, `hora`, `nombre`, `descripcion`) VALUES
(3, '2018-03-08', '01:00:00', 'Cine Puro Vicio', 'Dir: Paul Thomas Anderson. Int: Jena Malone, Joaquin Phoenix, Sasha Pieterse, Reese Witherspoon, Wilson Bethel, Josh Brolin, Benicio Del Toro, Owen Wilson, Maya Rudolph, Martin Short (Thriller, EE.UU., 2014) [Tráiler]'),
(3, '2018-03-08', '02:03:00', 'Campeonato europeo de poker', 'Disfruta del campeonato de poker Europeo.'),
(3, '2018-03-08', '04:00:00', 'Comprando en casa', 'Espacio de teletienda.'),
(3, '2018-03-08', '04:30:00', 'Minutos musicales', 'Música en directo interpretada por artistas de primer nivel. Un espacio pensado y diseñado para los amantes de la música...'),
(3, '2018-03-08', '06:00:00', 'Minutos musicales', 'Música en directo interpretada por artistas de primer nivel. Un espacio pensado y diseñado para los amantes de la música...'),
(3, '2018-03-08', '06:15:00', 'Noticias de la mañana', 'Esther Vaquero, Lorena García y María José Sáez son las encargadas de traer las noticias de ámbito nacional e internacional a primera hora de la mañana.'),
(3, '2018-03-08', '08:30:00', 'Un café con Susana', 'Espacio en el que Susana Griso entrevista al protagonista del día. La presentadora se sienta para conversar con personajes de la actualidad política, social y cultural con el fin de aportar al espectador información contada en primera persona.'),
(3, '2018-03-08', '09:00:00', 'Espejo público', 'El protagonismo de este magacín matinal presentado por Susanna Griso es del público, la calle y los directos.'),
(3, '2018-03-08', '13:15:00', 'Karlos Arguiñano en tu cocina', 'Con Karlos Arguiñano nos lo vamos a pasar en grande mientras aprendemos un poco más los secretos de la cocina. Platos sencillos y muy ricos para todos los bolsillos que nos harán nuestra vida mucho más sencilla.'),
(3, '2018-03-08', '13:40:00', 'La ruleta de la suerte', 'Presentado por Jorge Fernández, con la colaboración de Laura Moure como la azafata del programa, La ruleta de la suerte, el concurso rey de las mañanas, inicia nueva temporada con muchas novedades.'),
(3, '2018-03-08', '15:00:00', 'Noticias 1', 'María Rey y Sandra Golpe te esperan de lunes a viernes a las 15:00 h. Una cita con la información nacional e internacional.'),
(3, '2018-03-08', '15:45:00', 'Deportes 1', 'Rocío Martínez se encarga de presentar el espacio dedicado a las noticias de deportes.'),
(3, '2018-03-08', '16:00:00', 'Tu Tiempo', 'Roberto Brasero nos informa de las previsiones meteorológicas de forma amena y sencilla.'),
(3, '2018-03-08', '16:30:00', 'Amar es para siempre', 'En la España de principios de los años 60, a la rigidez oficial se superpone una sociedad que desea abrirse al mundo y vivir nuevas experiencias.'),
(3, '2018-03-08', '17:30:00', 'El secreto de Puente Viejo', 'Francisca no permitirá que se arriesguen más por ella y dice estar dispuesta a afrontar la tragedia si llega. Es Consuelo quien tiene una idea para salvarla, y requiere de la ayuda y complicidad de Prudencio. Por su parte, Carmelo y Adela reciben informes sobre Irene que parecen confirmar todo lo dicho por la periodista. Y Nicolás pasa por casa de Severo para interesarse por él y da la sensación d'),
(3, '2018-03-08', '18:45:00', '¡Ahora caigo!', 'Presentado por Arturo Valls. Es un concurso tan impredecible que la tierra se abrirá bajo tus pies. Un formato revolucionario que une el suspense de una batalla de preguntas con un elemento sorpresa: el puro azar.'),
(3, '2018-03-08', '20:00:00', '¡Boom!', 'Juanra Bonet presenta ¡Boom! un programa impredecible en el que los concursantes no podrán cortar el cable de la respuesta correcta.'),
(3, '2018-03-08', '21:00:00', 'Noticias 2', 'Vicente Vallés te espera de lunes a viernes a las 21:00h para informarte de todo lo que acontece en España y fuera de nuestras fronteras. No faltes a la cita con la información.'),
(3, '2018-03-08', '21:30:00', 'Deportes 2', 'Manu Sánchez se encarga de presentar el espacio dedicado a las noticias de deportes.'),
(3, '2018-03-08', '21:40:00', 'La previsión de las 9', 'Información meteorológica. Con Roberto Brasero.'),
(3, '2018-03-08', '21:45:00', 'El hormiguero 3.0', 'El cantante Ricky Martin acude al plató de ''''El hormiguero 3.0'''' para presentar su nueva canción ''''Fiebre'''', que cuenta con la participación de los artistas Wisin y Yandel.'),
(3, '2018-03-08', '22:40:00', 'Casados a primera vista', '¿Se imaginan a 8 solteros que han tenido mala suerte en el amor confiando en un grupo de expertos para que les busquen su pareja ideal? Una experiencia única en .Casados a primera vista .');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `programa_4_06`
--

DROP TABLE IF EXISTS `programa_4_06`;
CREATE TABLE `programa_4_06` (
  `idcanal` tinyint(3) UNSIGNED NOT NULL,
  `fecha` date NOT NULL,
  `hora` time NOT NULL,
  `nombre` varchar(100) DEFAULT NULL,
  `descripcion` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `programa_4_06`
--

INSERT INTO `programa_4_06` (`idcanal`, `fecha`, `hora`, `nombre`, `descripcion`) VALUES
(4, '2018-03-06', '00:05:00', 'Ven a cenar conmigo.', 'Gourmet Edition Rappel se las ingeniará para organizar una exquisita velada donde desvelará sus excelentes dotes culinarias. Además, sus invitados quedarán perplejos ante el tamaño de su mansión y conocerán aspectos de su futuro con una tirada de cartas que no dejará indiferente.'),
(4, '2018-03-06', '01:20:00', 'Ven a cenar conmigo', 'Ser el mejor anfitrión es el objetivo de este concurso en que cinco amantes de la cocina se pondrán a prueba. El organizador de la velada que proporcione la mejor atención a los demás concursantes conseguirá un premio en metálico.'),
(4, '2018-03-06', '02:10:00', 'Ven a cenar conmigo', 'Los concursantes cenarán en casa de Neftalí, heavy, adorador de Satán y vegetariano. Este joven no tiene entre sus virtudes la de cocinar. Aun así, intentará contentar los paladares de sus invitados. Su extraña personalidad provocará que el menú pase a un segundo plano.'),
(4, '2018-03-06', '02:55:00', 'Puro Cuatro', 'Programa que da a conocer la música que suena en Cuatro.'),
(4, '2018-03-06', '04:00:00', 'La tienda en casa', 'Espacio de teletienda.'),
(4, '2018-03-06', '05:15:00', 'Puro Cuatro', 'Programa que da a conocer la música que suena en Cuatro.'),
(4, '2018-03-06', '06:00:00', 'Puro Cuatro', 'Espacio que actúa a modo de escaparate de la música que suena en los programas de Cuatro.'),
(4, '2018-03-06', '07:00:00', 'El Zapping De Surferos:', 'Lo mejor Espacio que recoge los mejores momentos y las imágenes más impactantes y curiosas emitidas en las distintas cadenas de televisión.'),
(4, '2018-03-06', '08:00:00', 'Gym Tony XS', 'En el gimnasio Gym Tony se reúnen unos personajes estrafalarios que viven las más cómicas y disparatadas aventuras: un dueño embaucador, unos empleados a los que nadie contrataría y un puñado de clientes fieles, a pesar de todo.'),
(4, '2018-03-06', '09:15:00', 'Alerta Cobra ''El día de la madre''.', 'En la Europa del año 2000, las autopistas alemanas se han convertido en los lugares de paso de multitud de personajes siniestros, cargas peligrosas y conductores temerarios. La brigada especial de carreteras se encarga de luchar contra el crimen en estos lugares.'),
(4, '2018-03-06', '10:15:00', 'Alerta Cobra ''La luchadora''.', 'Para Sandra, aspirante a boxeadora profesional, el mundo se derrumba. Poco antes de su primera gran pelea, su padre y su entrenador son asesinados durante un atraco. Semir y Alex investigan el verdadero trasfondo del asesinato.'),
(4, '2018-03-06', '11:20:00', 'Las Mañanas De Cuatro (Primera hora)', 'Javier Ruiz y sus colaboradores analizan cada mañana la actualidad política y los sucesos más destacados de nuestro país.'),
(4, '2018-03-06', '12:30:00', 'Las Mañanas De Cuatro', 'Magacín matinal presentado por Javier Ruiz que recoge la actualidad política y social, la cultura y las nuevas tendencias.'),
(4, '2018-03-06', '14:15:00', 'Noticias Cuatro mediodía', 'Toda la actualidad nacional e internacional de la mano de Marta Fernández.'),
(4, '2018-03-06', '14:45:00', 'El Tiempo', 'Presentado por Rebeca Haro.'),
(4, '2018-03-06', '14:55:00', 'Noticias Cuatro', 'Deportes'),
(4, '2018-03-06', '15:25:00', 'Deportes Cuatro', 'Presentado por Manu Carreño, Manolo Lama.'),
(4, '2018-03-06', '15:45:00', 'Mujeres Y Hombres Y Viceversa', 'El dating show más célebre de las pantallas españolas. Los tronistas tendrán divertidas citas con diversos candidatos hasta encontrar a su pareja ideal. Moderado por Emma García.'),
(4, '2018-03-06', '17:00:00', 'Ven a cenar conmigo a la hora de la merienda', 'Ser el mejor anfitrión es el objetivo de este concurso en que cinco amantes de la cocina se pondrán a prueba. El organizador de la velada que proporcione la mejor atención a los demás concursantes conseguirá un premio en metálico.'),
(4, '2018-03-06', '18:00:00', 'Hawai 5.0 ''Una tribuna para hablar''.', 'Cuando un grupo de armas es robado de un alijo de armas de fuego, el quipo 5-0 descubre que el culpable tiene la intención de hacer una declaración dramática sobre la violencia armada. (Empezó hace 31'')'),
(4, '2018-03-06', '18:50:00', 'Hawai 5.0 ''Una estrella fugaz''.', 'La muerte por envenenamiento de un imitador de Elvis conduce al equipo del 5.0 a un misterioso caso que tiene como principales elementos unos diamantes de contrabando y un par de caras conocidas de McGarrett y compañía. (Empieza dentro de 19'')'),
(4, '2018-03-06', '19:45:00', 'Noticias Cuatro Noche', 'Toda la actualidad nacional e internacional de la mano de Miguel Ángel Oliver.'),
(4, '2018-03-06', '20:20:00', 'Deportes Cuatro 2', 'Toda la actualidad deportiva en este espacio de Noticias Cuatro.'),
(4, '2018-03-06', '20:25:00', 'El Tiempo', 'Todo lo que quieres saber sobre los cambios meteorológicos, además de las curiosidades sobre el clima y el medio ambiente.'),
(4, '2018-03-06', '20:30:00', 'Ven a cenar conmigo', 'Los concursantes cenarán en casa de Neftalí, heavy, adorador de Satán y vegetariano. Este joven no tiene entre sus virtudes la de cocinar. Aun así, intentará contentar los paladares de sus invitados. Su extraña personalidad provocará que el menú pase a un segundo plano.'),
(4, '2018-03-06', '21:30:00', 'First Dates', 'Espacio que organiza citas a ciegas entre solteros en un restaurante único y especial. Carlos Sobera ejercerá de singular maître de este local, interviniendo en caso de que sus clientes necesiten una ayuda extra durante la cita, para conseguir el éxito entre la pareja.'),
(4, '2018-03-06', '22:45:00', 'Ven a cenar conmigo.', 'Gourmet Edition Víctor Janeiro es un hombre consciente de sus limitaciones. Es simpático, tiene encanto y mucho arte. Pero habilidades culinarias, pocas. Hoy intenta seducir a Ana Obregón, Lucía Etxebarria y Rappel con unos huevos con patatas.');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `programa_4_07`
--

DROP TABLE IF EXISTS `programa_4_07`;
CREATE TABLE `programa_4_07` (
  `idcanal` tinyint(3) UNSIGNED NOT NULL,
  `fecha` date NOT NULL,
  `hora` time NOT NULL,
  `nombre` varchar(100) DEFAULT NULL,
  `descripcion` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `programa_4_07`
--

INSERT INTO `programa_4_07` (`idcanal`, `fecha`, `hora`, `nombre`, `descripcion`) VALUES
(4, '2018-03-07', '01:20:00', 'Cine Cuatro Enemigos.', 'Ecks contra Sever Dir: Wych Kaosayananda. Int: Antonio Banderas, Lucy Liu, Gregg Henry, Ray Park, Talisa Soto (Acción, EE.UU., 2002)'),
(4, '2018-03-07', '03:00:00', 'Puro Cuatro', 'Programa que da a conocer la música que suena en Cuatro.'),
(4, '2018-03-07', '04:00:00', 'La tienda en casa', 'Espacio de teletienda.'),
(4, '2018-03-07', '05:15:00', 'Puro Cuatro Programa que da a conocer la música que suena en Cuatro.', NULL),
(4, '2018-03-07', '07:00:00', 'El Zapping De Surferos: Lo mejor', 'Espacio que recoge los mejores momentos y las imágenes más impactantes y curiosas emitidas en las distintas cadenas de televisión.'),
(4, '2018-03-07', '08:00:00', 'Gym Tony XS', 'En el gimnasio Gym Tony se reúnen unos personajes estrafalarios que viven las más cómicas y disparatadas aventuras: un dueño embaucador, unos empleados a los que nadie contrataría y un puñado de clientes fieles, a pesar de todo.'),
(4, '2018-03-07', '09:15:00', 'Alerta Cobra', '''Sin piedad''. En la Europa del año 2000, las autopistas alemanas se han convertido en los lugares de paso de multitud de personajes siniestros, cargas peligrosas y conductores temerarios. La brigada especial de carreteras se encarga de luchar contra el crimen en estos lugares.'),
(4, '2018-03-07', '10:15:00', 'Alerta Cobra', '''Cobra, encargaos vosotros''. En la Europa del año 2000, las autopistas alemanas se han convertido en los lugares de paso de multitud de personajes siniestros, cargas peligrosas y conductores temerarios. La brigada especial de carreteras se encarga de luchar contra el crimen en estos lugares.'),
(4, '2018-03-07', '11:20:00', 'Las Mañanas De Cuatro (Primera hora)', 'Javier Ruiz y sus colaboradores analizan cada mañana la actualidad política y los sucesos más destacados de nuestro país.'),
(4, '2018-03-07', '12:30:00', 'Las Mañanas De Cuatro', 'Magacín matinal presentado por Javier Ruiz que recoge la actualidad política y social, la cultura y las nuevas tendencias.'),
(4, '2018-03-07', '14:15:00', 'Noticias Cuatro mediodía', 'Toda la actualidad nacional e internacional de la mano de Marta Fernández.'),
(4, '2018-03-07', '14:45:00', 'El Tiempo', 'Presentado por Rebeca Haro.'),
(4, '2018-03-07', '14:55:00', 'Noticias Cuatro Deportes', 'Informativo deportivo incluido en el espacio Noticias Cuatro, que nos detalla las últimas novedades del mundo del deporte.'),
(4, '2018-03-07', '15:25:00', 'Deportes Cuatro', 'Presentado por Manu Carreño, Manolo Lama.'),
(4, '2018-03-07', '15:45:00', 'Mujeres Y Hombres Y Viceversa', 'El dating show más célebre de las pantallas españolas. Los tronistas tendrán divertidas citas con diversos candidatos hasta encontrar a su pareja ideal. Moderado por Emma García.'),
(4, '2018-03-07', '17:00:00', 'Ven a cenar conmigo a la hora de la merienda', 'Cada semana, de lunes a viernes, cinco personas anónimas competirán entre sí por erigirse en el mejor cocinero-anfitrión de la velada y ganar los 3.000 euros de premio. Presentado por Luis Larrodera.'),
(4, '2018-03-07', '18:00:00', 'Hawai 5.0', '''La casa de los horrores''. En Halloween, el equipo investiga el asesinato de un médium que aparentemente murió aterrado por la presencia de un poltergeist. Por otra parte, Kono y Adam son secuestrados para un culto a la muerte.'),
(4, '2018-03-07', '18:50:00', 'Hawai 5.0', '''Reconstruyendo el ayer''. Tres jóvenes contables encuentran un cadáver en su habitación de hotel después de una noche de fiesta. Mientras tanto, Jerry se topa con un asesinato vinculado con una red de trata de blancas mientras realizaba una entrega para Kamekona.'),
(4, '2018-03-07', '19:45:00', 'Noticias Cuatro Noche', 'Toda la actualidad nacional e internacional de la mano de Miguel Ángel Oliver.'),
(4, '2018-03-07', '20:20:00', 'Deportes Cuatro 2', 'Toda la actualidad deportiva en este espacio de Noticias Cuatro.'),
(4, '2018-03-07', '20:25:00', 'El Tiempo', 'Todo lo que quieres saber sobre los cambios meteorológicos, además de las curiosidades sobre el clima y el medio ambiente.'),
(4, '2018-03-07', '20:30:00', 'Ven a cenar conmigo', 'Cada semana, de lunes a viernes, cinco personas anónimas competirán entre sí por erigirse en el mejor cocinero-anfitrión de la velada y ganar los 3.000 euros de premio. Presentado por Luis Larrodera.'),
(4, '2018-03-07', '21:30:00', 'First dates', 'La mesa está servida, el ambiente es romántico y todo el personal está listo para acoger a cientos de solteros que buscan pareja. El dating show tendrá como cómplice a Carlos Sobera, al que acompañan los ''camareros'' Matías Roure y Lydia Torrent.'),
(4, '2018-03-07', '22:55:00', 'Cine Cuatro Shooter: El Tirador', 'Dir: Antoine Fuqua. Int: Mark Wahlberg, Michael Pena, Danny Glover, Kate Mara, Elias Koteas, Rhona Mitra, Rade Sherbedgia, Ned Beatty (Acción, EE.UU., 2007)');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `programa_4_08`
--

DROP TABLE IF EXISTS `programa_4_08`;
CREATE TABLE `programa_4_08` (
  `idcanal` tinyint(3) UNSIGNED NOT NULL,
  `fecha` date NOT NULL,
  `hora` time NOT NULL,
  `nombre` varchar(100) DEFAULT NULL,
  `descripcion` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `programa_4_08`
--

INSERT INTO `programa_4_08` (`idcanal`, `fecha`, `hora`, `nombre`, `descripcion`) VALUES
(4, '2018-03-08', '00:25:00', 'Mentes criminales ', '''El testigo''. Un autobús urbano de Los Ángeles sufre un ataque con gas sarín. Hotchner y su equipo de analistas viajan a California para dar caza al culpable antes de que pueda repetir el atentado.'),
(4, '2018-03-08', '01:25:00', 'Mentes criminales ', '''Traspasando fronteras''. Hotch y Cruz recurren a un equipo de élite del FBI encabezado por Jack Garrett con tal de esclarecer el caso de una familia estadounidense secuestrada durante sus vacaciones en Barbados. Durante las pesquisas, se dan cuenta de que esta situación se asemeja a otro caso.'),
(4, '2018-03-08', '02:05:00', 'Mentes criminales ', '''Las ruedas del autobús''. La unidad busca un autobús escolar que ha desaparecido lleno de niños fuera del área de la ciudad de Washington. Los investigadores deben trabajar contra el reloj para conseguir devolver a los menores a sus casas sanos y salvos.'),
(4, '2018-03-08', '03:00:00', 'Puro Cuatro ', 'Programa que da a conocer la música que suena en Cuatro.'),
(4, '2018-03-08', '04:00:00', 'La tienda en casa ', 'Espacio de televenta.'),
(4, '2018-03-08', '05:15:00', 'Puro Cuatro ', 'Programa que da a conocer la música que suena en Cuatro.'),
(4, '2018-03-08', '06:00:00', 'Puro Cuatro', 'Espacio que actúa a modo de escaparate de la música que suena en los programas de Cuatro.'),
(4, '2018-03-08', '07:00:00', 'El Zapping De Surferos:', 'Lo mejor'),
(4, '2018-03-08', '08:00:00', 'Gym Tony XS', ' En el gimnasio Gym Tony se reúnen unos personajes estrafalarios que viven las más cómicas y disparatadas aventuras: un dueño embaucador, unos empleados a los que nadie contrataría y un puñado de clientes fieles, a pesar de todo.'),
(4, '2018-03-08', '09:15:00', 'Alerta Cobra', ' En la Europa del año 2000, las autopistas alemanas se han convertido en los lugares de paso de multitud de personajes siniestros, cargas peligrosas y conductores temerarios. La brigada especial de carreteras se encarga de luchar contra el crimen en estos lugares.'),
(4, '2018-03-08', '10:15:00', 'Alerta Cobra', ' En la Europa del año 2000, las autopistas alemanas se han convertido en los lugares de paso de multitud de personajes siniestros, cargas peligrosas y conductores temerarios. La brigada especial de carreteras se encarga de luchar contra el crimen en estos lugares.'),
(4, '2018-03-08', '11:20:00', 'Las Mañanas De Cuatro (Primera hora)', ' Javier Ruiz y sus colaboradores analizan cada mañana la actualidad política y los sucesos más destacados de nuestro país.'),
(4, '2018-03-08', '12:30:00', 'Las Mañanas De Cuatro', ' Magacín matinal presentado por Javier Ruiz que recoge la actualidad política y social, la cultura y las nuevas tendencias.'),
(4, '2018-03-08', '14:15:00', 'Noticias Cuatro ', 'mediodía Toda la actualidad nacional e internacional de la mano de Marta Fernández.'),
(4, '2018-03-08', '14:45:00', 'El Tiempo', ' Presentado por Rebeca Haro.'),
(4, '2018-03-08', '14:55:00', 'Noticias Cuatro Deportes', ' Informativo deportivo incluido en el espacio Noticias Cuatro, que nos detalla las últimas novedades del mundo del deporte.'),
(4, '2018-03-08', '15:25:00', 'Deportes Cuatro ', 'Informativo que ofrece las últimas noticias del mundo del deporte y las declaraciones de sus protagonistas.'),
(4, '2018-03-08', '15:45:00', 'Mujeres Y Hombres Y Viceversa', ' El dating show más célebre de las pantallas españolas. Los tronistas tendrán divertidas citas con diversos candidatos hasta encontrar a su pareja ideal. Moderado por Emma García.'),
(4, '2018-03-08', '17:00:00', 'Ven a cenar conmigo a la hora de la merienda ', 'Cada semana, de lunes a viernes, cinco personas anónimas competirán entre sí por erigirse en el mejor cocinero-anfitrión de la velada y ganar los 3.000 euros de premio. Presentado por Luis Larrodera.'),
(4, '2018-03-08', '18:00:00', 'Hawai 5.0', ' Serie policíaca que se sitúa en Hawai, donde una unidad especial de la policía estatal investiga los delitos que ocurren en la isla.'),
(4, '2018-03-08', '18:50:00', 'Hawai 5.0', ' Serie policíaca que se sitúa en Hawai, donde una unidad especial de la policía estatal investiga los delitos que ocurren en la isla.'),
(4, '2018-03-08', '19:45:00', 'Noticias Cuatro ', 'Toda la actualidad nacional e internacional de la mano de Miguel Ángel Oliver.'),
(4, '2018-03-08', '20:20:00', 'Deportes Cuatro 2 ', 'Toda la información deportiva en Cuatro. Presentado por Luis García y Ricardo Reyes.'),
(4, '2018-03-08', '20:25:00', 'El Tiempo', ' Presentado por Laura Madrueño.'),
(4, '2018-03-08', '20:30:00', 'Ven a cenar conmigo ', 'Cada semana, de lunes a viernes, cinco personas anónimas competirán entre sí por erigirse en el mejor cocinero-anfitrión de la velada y ganar los 3.000 euros de premio. Presentado por Luis Larrodera.'),
(4, '2018-03-08', '21:30:00', 'First Dates ', 'La mesa está servida, el ambiente es romántico y todo el personal está listo para acoger a cientos de solteros que buscan pareja. El dating show tendrá como cómplice a Carlos Sobera, al que acompañan los ''camareros'' Matías Roure y Lydia Torrent.'),
(4, '2018-03-08', '22:45:00', 'Mentes criminales ', '''Montaje''. Décimotercera temporada de la serie sobre la Unidad de Análisis de la Conducta, una sección del FBI que atiende al comportamiento del criminal para estrechar el cerco sobre él. Cuando no hay suficientes pistas en un caso, el FBI acude a esta división.'),
(4, '2018-03-08', '23:30:00', 'Mentes criminales ', '''Spencer''. Los agentes Clara Seger y Matt Simmons, de ''''Mentes criminales sin fronteras'''', viajan a México para sacar de prisión a su compañero de la Unidad de Análisis de Conducta, Spencer Reid, encarcelado por tráfico de drogas.');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `programa_5_06`
--

DROP TABLE IF EXISTS `programa_5_06`;
CREATE TABLE `programa_5_06` (
  `idcanal` tinyint(3) UNSIGNED NOT NULL,
  `fecha` date NOT NULL,
  `hora` time NOT NULL,
  `nombre` varchar(100) DEFAULT NULL,
  `descripcion` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `programa_5_06`
--

INSERT INTO `programa_5_06` (`idcanal`, `fecha`, `hora`, `nombre`, `descripcion`) VALUES
(5, '2018-03-06', '00:30:00', 'Amores que duelen ', 'Amores que duelen'' es uno de esos programas que abre los ojos a una realidad difícil de mirar: La Violencia de Género.'),
(5, '2018-03-06', '01:15:00', 'Amores que duelen ''Sandra''.', ' Sandra estuvo casada durante 22 años y fue víctima de maltrato psicológico. Actualmente, el acoso continúa mediante llamadas, mensajes y amenazas, por lo que Sandra cuenta con protección policial y con una orden de alejamiento de 1.500 metros.'),
(5, '2018-03-06', '02:15:00', 'La tienda en casa', ' Espacio de teletienda.'),
(5, '2018-03-06', '02:30:00', 'Miramimusica ', 'El espacio comercial de música en Telecinco.'),
(5, '2018-03-06', '06:30:00', 'Informativos Telecinco', 'Primera edición informativa de la cadena presentada por Alba Lago y Roberto Fernández. El noticiario ofrece un seguimiento de las noticias de la jornada anterior.'),
(5, '2018-03-06', '08:55:00', 'El Programa De Ana Rosa ', 'Magacín matutino conducido por Ana Rosa Quintana, que cuenta con Joaquín Prat como colaborador. El programa contiene diferentes secciones donde contertulianos hablan sobre temas de sociedad, corazón, política y actualidad.'),
(5, '2018-03-06', '13:45:00', 'Cámbiame ', 'Programa que ofrece un cambio radical de imagen a sus participantes. Los aspirantes tendrán 60 segundos para convencer a un equipo de tres estilitas de que ellos son los mejores candidatos para renovar su ropa, peinado e incluso su actitud y personalidad.'),
(5, '2018-03-06', '15:05:00', 'Informativos Telecinco ', 'Presentado por David Cantero, Isabel Jiménez. Espacio dedicado a la información de actualidad.'),
(5, '2018-03-06', '15:40:00', 'Deportes ', 'Espacio informativo dedicado al mundo del deporte. Presentado por J.J. Santos.'),
(5, '2018-03-06', '15:50:00', 'El Tiempo ', 'Información meteorológica y pronóstico del tiempo.'),
(5, '2018-03-06', '16:00:00', 'Sálvame Limón ', 'La edición más ácida de Sálvame, magacín vespertino que aborda la actualidad de la crónica rosa y que cuenta con una larga lista de colaboradores como: Belén Esteban, Karmele Marchante, Kiko Hernández, Lydia Lozano o Terelu Campos.'),
(5, '2018-03-06', '17:00:00', 'Sálvame Naranja ', 'La edición más dulce y apta para todas las sensibilidades de Sálvame, magacín vespertino que aborda la actualidad de la crónica rosa y que cuenta con una larga lista de colaboradores como: Belén Esteban, Karmele Marchante, Kiko Hernández, Lydia Lozano o Terelu Campos. (Hace más de 1 hora que empezó)'),
(5, '2018-03-06', '20:05:00', 'Pasapalabra ', 'Presentado por Christian Gálvez. Concurso en el que los participantes intentan acumular segundos a lo largo de diversas pruebas, con el fin de tener más tiempo para la prueba final: El Rosco.'),
(5, '2018-03-06', '21:05:00', 'Informativos Telecinco ', 'Presentado por Pedro Piqueras. Espacio dedicado a la información de actualidad.'),
(5, '2018-03-06', '21:40:00', 'Deportes ', 'Presentado por J.J. Santos. Espacio informativo dedicado al mundo del deporte.'),
(5, '2018-03-06', '21:50:00', 'El Tiempo ', 'Información meteorológica y pronóstico del tiempo.'),
(5, '2018-03-06', '22:00:00', 'Got Talent. Momentazos ', 'Disfruta de los mejores momentos de la gala del ‘talent show’ conducido por Santi Millán. El jurado está formado por Risto Mejide, Jorge Javier Vázquez, Eva Hache y Edurne.'),
(5, '2018-03-06', '22:40:00', 'Cine 5 Estrellas ', 'Noche real Dir: Julian Jarrold. Int: Sarah Gadon, Emily Watson, Jack Reynor, Rupert Everett, Bel Powley, Roger Allam, Jack Laskey, Ruth Sheen, Anastasia Harrold, Jack Gordon (Comedia, Gran Bretaña, 2015) [Tráiler]');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `programa_5_07`
--

DROP TABLE IF EXISTS `programa_5_07`;
CREATE TABLE `programa_5_07` (
  `idcanal` tinyint(3) UNSIGNED NOT NULL,
  `fecha` date NOT NULL,
  `hora` time NOT NULL,
  `nombre` varchar(100) DEFAULT NULL,
  `descripcion` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `programa_5_07`
--

INSERT INTO `programa_5_07` (`idcanal`, `fecha`, `hora`, `nombre`, `descripcion`) VALUES
(5, '2018-03-07', '01:45:00', 'Got Talent. Momentazos', 'Disfruta de los mejores momentos de la gala del ‘talent show’ conducido por Santi Millán. El jurado está formado por Risto Mejide, Jorge Javier Vázquez, Eva Hache y Edurne.'),
(5, '2018-03-07', '02:45:00', 'La tienda en casa', 'Espacio de televenta.'),
(5, '2018-03-07', '03:00:00', 'Miramimusica', 'El espacio comercial de música en Telecinco.'),
(5, '2018-03-07', '06:30:00', 'Informativos Telecinco', 'Primera edición informativa de la cadena presentada por Alba Lago y Roberto Fernández. El noticiario ofrece un seguimiento de las noticias de la jornada anterior.'),
(5, '2018-03-07', '08:55:00', 'El Programa de Ana Rosa', 'Magacín matutino conducido por Ana Rosa Quintana, que cuenta con Joaquín Prat como colaborador. El programa contiene diferentes secciones donde contertulianos hablan sobre temas de sociedad, corazón, política y actualidad.'),
(5, '2018-03-07', '13:45:00', 'Cambiame', 'Programa de cambio de imagen presentado por Carlota Corredera que pretende hacer realidad los sueños de sus aspirantes gracias a la intervención de estilistas profesionales: Cristina Rodríguez, Natalia Ferviú y Pelayo Díaz.'),
(5, '2018-03-07', '15:05:00', 'Informativos Telecinco', 'Presentado por David Cantero, Isabel Jiménez. Espacio dedicado a la información de actualidad.'),
(5, '2018-03-07', '15:40:00', 'Deportes', 'Espacio informativo dedicado al mundo del deporte. Presentado por Pablo Pinto.'),
(5, '2018-03-07', '15:50:00', 'El Tiempo', 'Información meteorológica y pronóstico del tiempo.'),
(5, '2018-03-07', '16:00:00', 'Sálvame Limón', 'La edición más ácida de Sálvame, magacín vespertino que aborda la actualidad de la crónica rosa y que cuenta con una larga lista de colaboradores como: Belén Esteban, Karmele Marchante, Kiko Hernández, Lydia Lozano o Terelu Campos.'),
(5, '2018-03-07', '17:00:00', 'Sálvame Naranja', 'La edición más dulce y apta para todas las sensibilidades de Sálvame, magacín vespertino que aborda la actualidad de la crónica rosa y que cuenta con una larga lista de colaboradores como: Belén Esteban, Karmele Marchante, Kiko Hernández, Lydia Lozano o Terelu Campos.'),
(5, '2018-03-07', '20:05:00', 'Pasapalabra', 'Concurso presentado por Christian Gálvez en el que dos concursantes intentarán acumular los máximos segundos posibles en una serie de pruebas para afrontar con más posibilidades el rosco final.'),
(5, '2018-03-07', '21:05:00', 'Informativos Telecinco', 'Presentado por Pedro Piqueras. Espacio dedicado a la información de actualidad.'),
(5, '2018-03-07', '21:40:00', 'Deportes', 'Espacio informativo dedicado al mundo del deporte. Presentado por J. J. Santos.'),
(5, '2018-03-07', '21:50:00', 'El Tiempo', 'Información meteorológica y pronóstico del tiempo.'),
(5, '2018-03-07', '22:00:00', 'Got Talent', 'Tercera edición del concurso que busca nuevas promesas en distintas disciplinas artísticas como el baile, la magia o el humor. El publicista Risto Mejide forma el jurado junto a Eva Hache, Edurne y Jorge Javier Vázquez. Santi Millán ejerce de maestro de ceremonias.');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `programa_5_08`
--

DROP TABLE IF EXISTS `programa_5_08`;
CREATE TABLE `programa_5_08` (
  `idcanal` tinyint(3) UNSIGNED NOT NULL,
  `fecha` date NOT NULL,
  `hora` time NOT NULL,
  `nombre` varchar(100) DEFAULT NULL,
  `descripcion` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `programa_5_08`
--

INSERT INTO `programa_5_08` (`idcanal`, `fecha`, `hora`, `nombre`, `descripcion`) VALUES
(5, '2018-03-08', '02:15:00', 'La tienda en casa', 'Espacio de televenta.'),
(5, '2018-03-08', '02:30:00', 'Miramimusica', 'El espacio comercial de música en Telecinco.'),
(5, '2018-03-08', '06:30:00', 'Informativos Telecinco', 'Primera edición informativa de la cadena presentada por Alba Lago y Roberto Fernández. El noticiario ofrece un seguimiento de las noticias de la jornada anterior.'),
(5, '2018-03-08', '08:55:00', 'El Programa de Ana Rosa', 'Magacín matutino conducido por Ana Rosa Quintana, que cuenta con Joaquín Prat como colaborador. El programa contiene diferentes secciones donde contertulianos hablan sobre temas de sociedad, corazón, política y actualidad.'),
(5, '2018-03-08', '13:45:00', 'Cambiame', 'Programa de cambio de imagen presentado por Carlota Corredera que pretende hacer realidad los sueños de sus aspirantes gracias a la intervención de estilistas profesionales: Cristina Rodríguez, Natalia Ferviú y Pelayo Díaz.'),
(5, '2018-03-08', '15:05:00', 'Informativos Telecinco', 'Presentado por David Cantero, Isabel Jiménez. Espacio dedicado a la información de actualidad.'),
(5, '2018-03-08', '15:40:00', 'Deportes', 'Espacio informativo dedicado al mundo del deporte. Presentado por Pablo Pinto.'),
(5, '2018-03-08', '15:50:00', 'El Tiempo', 'Información meteorológica y pronóstico del tiempo.'),
(5, '2018-03-08', '16:00:00', 'Sálvame Limón', 'La edición más ácida de Sálvame, magacín vespertino que aborda la actualidad de la crónica rosa y que cuenta con una larga lista de colaboradores como: Belén Esteban, Karmele Marchante, Kiko Hernández, Lydia Lozano o Terelu Campos.'),
(5, '2018-03-08', '17:00:00', 'Sálvame Naranja', 'La edición más dulce y apta para todas las sensibilidades de Sálvame, magacín vespertino que aborda la actualidad de la crónica rosa y que cuenta con una larga lista de colaboradores como: Belén Esteban, Karmele Marchante, Kiko Hernández, Lydia Lozano o Terelu Campos.'),
(5, '2018-03-08', '20:05:00', 'Pasapalabra', 'Presentado por Christian Gálvez. Concurso en el que los participantes intentan acumular segundos a lo largo de diversas pruebas, con el fin de tener más tiempo para la prueba final: El Rosco.'),
(5, '2018-03-08', '21:05:00', 'Informativos Telecinco', 'Presentado por Pedro Piqueras. Espacio dedicado a la información de actualidad.'),
(5, '2018-03-08', '21:40:00', 'Deportes', 'Presentado por J.J. Santos. Espacio informativo dedicado al mundo del deporte.'),
(5, '2018-03-08', '21:50:00', 'El Tiempo', 'Información meteorológica y pronóstico del tiempo.'),
(5, '2018-03-08', '22:00:00', 'Volverte a ver', 'Programa conducido por Carlos Sobera en el que el amor es el protagonista. Reencuentros, peticiones de matrimonio, confesiones y perdones son algunos de los componentes de este espacio que abre una ventana a todos aquellos que quieren demostrar sus sentimientos.');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `programa_6_06`
--

DROP TABLE IF EXISTS `programa_6_06`;
CREATE TABLE `programa_6_06` (
  `idcanal` tinyint(3) UNSIGNED NOT NULL,
  `fecha` date NOT NULL,
  `hora` time NOT NULL,
  `nombre` varchar(100) DEFAULT NULL,
  `descripcion` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `programa_6_06`
--

INSERT INTO `programa_6_06` (`idcanal`, `fecha`, `hora`, `nombre`, `descripcion`) VALUES
(6, '2018-03-06', '00:45:00', 'Policías en acción', 'La serie analiza el trabajo cotidiano de las Fuerzas de Seguridad del Estado. Desde persecuciones, detenciones, redadas y registros, la ayuda a los ciudadanos...'),
(6, '2018-03-06', '02:30:00', 'Comprando en casa', 'Espacio de teletienda.'),
(6, '2018-03-06', '03:30:00', 'Canal Ruleta', NULL),
(6, '2018-03-06', '04:30:00', 'Minutos musicales', 'Música en directo interpretada por artistas de primer nivel. Un espacio pensado y diseñado para los amantes de la música...'),
(6, '2018-03-06', '06:00:00', 'minutos musicales', 'Música en directo interpretada por artistas de primer nivel. Un espacio pensado y diseñado para los amantes de la música...'),
(6, '2018-03-06', '06:15:00', 'Navy: Investigación Criminal ''Semper Fortis''.', 'Gibbs intenta ayudar a un asistente médico del hospital de la marina que esta bajo investigación por sus métodos para salvar vidas.'),
(6, '2018-03-06', '06:52:00', 'Navy: Investigación Criminal ''En tierra''.', 'Dulles está atrapado en el aeropuerto debido al mal tiempo. DiNozzo, Bishop y Jake trabajan en un caso que implica una amenaza terrorista en los aeropuertos del noreste durante Acción de Gracias.'),
(6, '2018-03-06', '07:30:00', '¿Quién vive ahí?', 'Espacio en el que se muestran algunas residencias y lugares singulares que, por alguna razón, son únicos. Los dueños de estas viviendas cuentan en primera persona la vida e historia de los hogares donde habitan.'),
(6, '2018-03-06', '09:15:00', 'Crímenes imperfectos.', 'Deja de lado la investigación forense propiamente dicha y se centra en el aspecto judicial de los crímenes, en cómo el dinero puede comprar la justicia y en la labor de los medios de comunicación en la resolución de los casos.'),
(6, '2018-03-06', '10:15:00', 'Las primeras 48 horas', 'Inmersos en una Unidad de Homicidios de detectives de élite, el equipo documental conseguirá filmar las primeras 48 horas, críticas para la resolución del caso.'),
(6, '2018-03-06', '11:00:00', 'Al rojo vivo previo', 'Programa de actualidad presentado por Antonio García Ferreras.'),
(6, '2018-03-06', '12:30:00', 'Al rojo vivo', 'Antonio G. Ferreras dirige y presenta este espacio de debate sobre la actualidad, fundamentalmente política, y lejos de una línea editorial conservadora.'),
(6, '2018-03-06', '14:00:00', 'La Sexta Noticias', '1ª edición Repaso a la actualidad del día de la mano de los servicios informativos de La sexta. Presentado por Elena Resano.'),
(6, '2018-03-06', '14:55:00', 'La Sexta noticias', 'Jugones Actualidad, investigación y las mejores imágenes del deporte se dan cita en la sobremesa de laSexta en la nueva temporada de Jugones, con Josep Pedrerol al frente. El programa, copresentado por Lara Álvarez, contará además con análisis de los especialista'),
(6, '2018-03-06', '15:20:00', 'Jugones', 'el análisis Programa deportivo dirigido por Josep Pedrerol.'),
(6, '2018-03-06', '15:30:00', 'La Sexta Meteo', '1ª edición Le damos una vuelta de tuerca a anticiclones, borrascas, nevadas y olas de calor. La previsión del tiempo de la mano de Lluís Obiols, Adrián Cordero'),
(6, '2018-03-06', '15:45:00', 'Zapeando', 'Frank Blanco y su equipo amenizan cada tarde las sobremesas con Zapeando, el ojo crítico más divertido de la televisión.'),
(6, '2018-03-06', '17:15:00', 'Más vale tarde', 'Mamen Mendizábal, Hilario Pino y su equipo te traen la información vespertina de lunes a viernes. (Hace más de 1 hora que empezó)'),
(6, '2018-03-06', '20:00:00', 'La Sexta Noticias', '2ª edición Informativo nocturno de laSexta presentado por Cristina Saavedra.'),
(6, '2018-03-06', '20:55:00', 'Estación Sexta', 'Nuevo espacio dedicado al medio ambiente y la meteorología. Alberto Herrera, Adrián Cordero y Lluís Obiols te ofrecen la información del tiempo, además de imágenes, noticias y reportajes relacionados con nuestro entorno natural.'),
(6, '2018-03-06', '21:05:00', 'The Very Best of', 'El Intermedio Emisión de los mejores momentos de todos los programas de la temporada.'),
(6, '2018-03-06', '21:30:00', 'El Intermedio', 'Programa de actualidad y humor presentado por el Gran Wyoming y Sandra Sabatés. Con Thais Villas, Dani Mateo, Gonzo y Joaquín Reyes.'),
(6, '2018-03-06', '22:30:00', 'Cine Los Juegos Del Hambre: Sinsajo.', 'Parte I Dir: Francis Lawrence. Int: Jennifer Lawrence, Josh Hutcherson, Liam Hemsworth, Woody Harrelson, Elizabeth Banks, Julianne Moore, Philip Seymour Hoffman, Jeffrey Wright (Ciencia Ficción, EE.UU., 2014) [Tráiler]');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `programa_6_07`
--

DROP TABLE IF EXISTS `programa_6_07`;
CREATE TABLE `programa_6_07` (
  `idcanal` tinyint(3) UNSIGNED NOT NULL,
  `fecha` date NOT NULL,
  `hora` time NOT NULL,
  `nombre` varchar(100) DEFAULT NULL,
  `descripcion` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `programa_6_07`
--

INSERT INTO `programa_6_07` (`idcanal`, `fecha`, `hora`, `nombre`, `descripcion`) VALUES
(6, '2018-03-07', '00:30:00', 'Policías en acción', 'La serie analiza el trabajo cotidiano de las Fuerzas de Seguridad del Estado. Desde persecuciones, detenciones, redadas y registros, la ayuda a los ciudadanos...'),
(6, '2018-03-07', '02:30:00', 'Poker Caribbean Adventure', 'La gran fiesta del poker vuelve al Caribe en el Atlantis de Bahamas. 10 días de torneos, más de 10 millones de dólares en juego'),
(6, '2018-03-07', '03:00:00', 'Comprando en casa', 'Espacio de teletienda.'),
(6, '2018-03-07', '04:00:00', 'Canal Ruleta', NULL),
(6, '2018-03-07', '04:55:00', 'Minutos musicales', 'Música en directo interpretada por artistas de primer nivel. Un espacio pensado y diseñado para los amantes de la música...'),
(6, '2018-03-07', '06:00:00', 'Minutos musicales', 'Música en directo interpretada por artistas de primer nivel. Un espacio pensado y diseñado para los amantes de la música...'),
(6, '2018-03-07', '06:15:00', 'Navy: Investigación Criminal', 'Es una exitosa serie de televisión producida por Donald P. Bellisario. Con dosis de humor, está centrada en un complejo pero entretenido y dinámico grupo, forzado a trabajar en situaciones de alto estrés.'),
(6, '2018-03-07', '07:30:00', '¿Quién vive ahí?', 'Espacio en el que se muestran algunas residencias y lugares singulares que, por alguna razón, son únicos. Los dueños de estas viviendas cuentan en primera persona la vida e historia de los hogares donde habitan.'),
(6, '2018-03-07', '09:15:00', 'Crímenes imperfectos', 'Deja de lado la investigación forense propiamente dicha y se centra en el aspecto judicial de los crímenes, en cómo el dinero puede comprar la justicia y en la labor de los medios de comunicación en la resolución de los casos.'),
(6, '2018-03-07', '10:15:00', 'Las primeras 48 horas', 'Inmersos en una Unidad de Homicidios de detectives de élite, el equipo documental conseguirá filmar las primeras 48 horas, críticas para la resolución del caso.'),
(6, '2018-03-07', '11:00:00', 'Al rojo vivo previo', 'Programa de actualidad presentado por Antonio García Ferreras.'),
(6, '2018-03-07', '12:30:00', 'Al rojo vivo', 'Antonio G. Ferreras dirige y presenta este espacio de debate sobre la actualidad, fundamentalmente política, y lejos de una línea editorial conservadora.'),
(6, '2018-03-07', '14:00:00', 'La Sexta Noticias 1ª edición', 'Repaso a la actualidad del día de la mano de los servicios informativos de La sexta. Presentado por Elena Resano.'),
(6, '2018-03-07', '14:55:00', 'La Sexta noticias: Jugones', 'Actualidad, investigación y las mejores imágenes del deporte se dan cita en la sobremesa de laSexta en la nueva temporada de Jugones, con Josep Pedrerol al frente. El programa, copresentado por Lara Álvarez, contará además con análisis de los especialista'),
(6, '2018-03-07', '15:20:00', 'Jugones: el análisis', 'Programa deportivo dirigido por Josep Pedrerol.'),
(6, '2018-03-07', '15:30:00', 'La Sexta Meteo 1ª edición', 'Toda la información meteorológica a cargo de Lluis Obiols y Adrián Cordero.'),
(6, '2018-03-07', '15:45:00', 'Zapeando', 'Frank Blanco y su equipo amenizan cada tarde las sobremesas con Zapeando, el ojo crítico más divertido de la televisión.'),
(6, '2018-03-07', '17:15:00', 'Más vale tarde', 'Mamen Mendizábal, Hilario Pino y su equipo te traen la información vespertina de lunes a viernes. '),
(6, '2018-03-07', '20:00:00', 'La Sexta Noticias 2ª edición', 'Informativo nocturno de laSexta presentado por Cristina Saavedra.'),
(6, '2018-03-07', '20:55:00', 'Estación Sexta', 'Nuevo espacio dedicado al medio ambiente y la meteorología. Alberto Herrera, Adrián Cordero y Lluís Obiols te ofrecen la información del tiempo, además de imágenes, noticias y reportajes relacionados con nuestro entorno natural.'),
(6, '2018-03-07', '21:05:00', 'La Sexta Deportes 2ª edición', 'María Martínez, Óscar Rincón, Carlota Reig y Susana Guasch te acercan la información deportiva más completa.'),
(6, '2018-03-07', '21:30:00', 'El Intermedio', 'Programa de actualidad y humor presentado por el Gran Wyoming y Sandra Sabatés. Con Thais Villas, Dani Mateo, Gonzo y Joaquín Reyes.'),
(6, '2018-03-07', '22:30:00', 'Cine Jack y su Gemela', 'Dir: Dennis Dugan. Int: Adam Sandler, Al Pacino, Katie Holmes, Dana Carvey, Natalie Gal, Shaquille O''Neal, Regis Philbin, Santiago Segura, Valerie Mahaffey, Krystle Mataras (Comedia, EE.UU., 2011) [Tráiler]');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `programa_6_08`
--

DROP TABLE IF EXISTS `programa_6_08`;
CREATE TABLE `programa_6_08` (
  `idcanal` tinyint(3) UNSIGNED NOT NULL,
  `fecha` date NOT NULL,
  `hora` time NOT NULL,
  `nombre` varchar(100) DEFAULT NULL,
  `descripcion` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `programa_6_08`
--

INSERT INTO `programa_6_08` (`idcanal`, `fecha`, `hora`, `nombre`, `descripcion`) VALUES
(6, '2018-03-08', '01:10:00', 'Policías en acción', 'La serie analiza el trabajo cotidiano de las Fuerzas de Seguridad del Estado. Desde persecuciones, detenciones, redadas y registros, la ayuda a los ciudadanos...'),
(6, '2018-03-08', '02:30:00', 'Comprando en casa', 'Espacio de teletienda.'),
(6, '2018-03-08', '03:30:00', 'Canal Ruleta', NULL),
(6, '2018-03-08', '04:30:00', 'Minutos musicales', 'Música en directo interpretada por artistas de primer nivel. Un espacio pensado y diseñado para los amantes de la música...'),
(6, '2018-03-08', '06:00:00', 'Minutos musicales', 'Música en directo interpretada por artistas de primer nivel. Un espacio pensado y diseñado para los amantes de la música...'),
(6, '2018-03-08', '06:15:00', 'Navy: Investigación Criminal', 'El NCIS es un grupo especial de la Marina del ejército de los Estados Unidos que investiga todo tipo de crímenes que puedan tener relación con este cuerpo, desde asesinatos hasta espionaje, pasando por ataques terroristas o robos de submarinos.'),
(6, '2018-03-08', '07:30:00', '¿Quién vive ahí?', 'Espacio en el que se muestran algunas residencias y lugares singulares que, por alguna razón, son únicos. Los dueños de estas viviendas cuentan en primera persona la vida e historia de los hogares donde habitan.'),
(6, '2018-03-08', '09:15:00', 'Crímenes imperfectos', 'Deja de lado la investigación forense propiamente dicha y se centra en el aspecto judicial de los crímenes, en cómo el dinero puede comprar la justicia y en la labor de los medios de comunicación en la resolución de los casos.'),
(6, '2018-03-08', '10:15:00', 'Las primeras 48 horas', 'Inmersos en una Unidad de Homicidios de detectives de élite, el equipo documental conseguirá filmar las primeras 48 horas, críticas para la resolución del caso.'),
(6, '2018-03-08', '11:00:00', 'Al rojo vivo previo', 'Programa de actualidad presentado por Antonio García Ferreras.'),
(6, '2018-03-08', '12:30:00', 'Al rojo vivo', 'Antonio G. Ferreras dirige y presenta este espacio de debate sobre la actualidad, fundamentalmente política, y lejos de una línea editorial conservadora.'),
(6, '2018-03-08', '14:00:00', 'La Sexta Noticias 1ª edición', 'Repaso a la actualidad del día de la mano de los servicios informativos de La sexta. Presentado por Elena Resano.'),
(6, '2018-03-08', '14:55:00', 'La Sexta noticias: Jugones', 'Actualidad, investigación y las mejores imágenes del deporte se dan cita en la sobremesa de laSexta en la nueva temporada de Jugones, con Josep Pedrerol al frente. El programa, copresentado por Lara Álvarez, contará además con análisis de los especialista'),
(6, '2018-03-08', '15:20:00', 'Jugones: el análisis', 'Programa deportivo dirigido por Josep Pedrerol.'),
(6, '2018-03-08', '15:30:00', 'La Sexta Meteo 1ª edición', 'Toda la información meteorológica a cargo de Lluis Obiols y Adrián Cordero.'),
(6, '2018-03-08', '15:45:00', 'Zapeando', 'Frank Blanco y su equipo amenizan cada tarde las sobremesas con Zapeando, el ojo crítico más divertido de la televisión.'),
(6, '2018-03-08', '17:15:00', 'Más vale tarde', 'Mamen Mendizábal, Hilario Pino y su equipo te traen la información vespertina de lunes a viernes.'),
(6, '2018-03-08', '20:00:00', 'La Sexta Noticias 2ª edición', 'Informativo nocturno de laSexta presentado por Cristina Saavedra.'),
(6, '2018-03-08', '20:55:00', 'Estación Sexta', 'Nuevo espacio dedicado al medio ambiente y la meteorología. Alberto Herrera, Adrián Cordero y Lluís Obiols te ofrecen la información del tiempo, además de imágenes, noticias y reportajes relacionados con nuestro entorno natural.'),
(6, '2018-03-08', '21:05:00', 'La Sexta Deportes 2ª edición', 'María Martínez, Óscar Rincón, Carlota Reig y Susana Guasch te acercan la información deportiva más completa.'),
(6, '2018-03-08', '21:30:00', 'El Intermedio', 'Programa de actualidad y humor presentado por el Gran Wyoming y Sandra Sabatés. Con Thais Villas, Dani Mateo, Gonzo y Joaquín Reyes.'),
(6, '2018-03-08', '22:30:00', 'Cine Thelma y Louise', 'Dir: Ridley Scott. Int: Susan Sarandon, Geena Davis, Harvey Keitel, Brad Pitt, Michael Madsen (Policíaca, EE.UU., 1991)');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `canal`
--
ALTER TABLE `canal`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `programa_1_06`
--
ALTER TABLE `programa_1_06`
  ADD PRIMARY KEY (`idcanal`,`fecha`,`hora`);

--
-- Indices de la tabla `programa_1_08`
--
ALTER TABLE `programa_1_08`
  ADD PRIMARY KEY (`idcanal`,`fecha`,`hora`);

--
-- Indices de la tabla `programa_2_06`
--
ALTER TABLE `programa_2_06`
  ADD PRIMARY KEY (`idcanal`,`fecha`,`hora`);

--
-- Indices de la tabla `programa_2_08`
--
ALTER TABLE `programa_2_08`
  ADD PRIMARY KEY (`idcanal`,`fecha`,`hora`);

--
-- Indices de la tabla `programa_3_06`
--
ALTER TABLE `programa_3_06`
  ADD PRIMARY KEY (`idcanal`,`fecha`,`hora`);

--
-- Indices de la tabla `programa_3_07`
--
ALTER TABLE `programa_3_07`
  ADD PRIMARY KEY (`idcanal`,`fecha`,`hora`);

--
-- Indices de la tabla `programa_3_08`
--
ALTER TABLE `programa_3_08`
  ADD PRIMARY KEY (`idcanal`,`fecha`,`hora`);

--
-- Indices de la tabla `programa_4_06`
--
ALTER TABLE `programa_4_06`
  ADD PRIMARY KEY (`idcanal`,`fecha`,`hora`);

--
-- Indices de la tabla `programa_4_07`
--
ALTER TABLE `programa_4_07`
  ADD PRIMARY KEY (`idcanal`,`fecha`,`hora`);

--
-- Indices de la tabla `programa_4_08`
--
ALTER TABLE `programa_4_08`
  ADD PRIMARY KEY (`idcanal`,`fecha`,`hora`);

--
-- Indices de la tabla `programa_5_06`
--
ALTER TABLE `programa_5_06`
  ADD PRIMARY KEY (`idcanal`,`fecha`,`hora`);

--
-- Indices de la tabla `programa_5_07`
--
ALTER TABLE `programa_5_07`
  ADD PRIMARY KEY (`idcanal`,`fecha`,`hora`);

--
-- Indices de la tabla `programa_5_08`
--
ALTER TABLE `programa_5_08`
  ADD PRIMARY KEY (`idcanal`,`fecha`,`hora`);

--
-- Indices de la tabla `programa_6_06`
--
ALTER TABLE `programa_6_06`
  ADD PRIMARY KEY (`idcanal`,`fecha`,`hora`);

--
-- Indices de la tabla `programa_6_07`
--
ALTER TABLE `programa_6_07`
  ADD PRIMARY KEY (`idcanal`,`fecha`,`hora`);

--
-- Indices de la tabla `programa_6_08`
--
ALTER TABLE `programa_6_08`
  ADD PRIMARY KEY (`idcanal`,`fecha`,`hora`);

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `programa_1_06`
--
ALTER TABLE `programa_1_06`
  ADD CONSTRAINT `programa_1_06_ibfk_1` FOREIGN KEY (`idcanal`) REFERENCES `canal` (`id`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Filtros para la tabla `programa_1_08`
--
ALTER TABLE `programa_1_08`
  ADD CONSTRAINT `programa_1_08_ibfk_1` FOREIGN KEY (`idcanal`) REFERENCES `canal` (`id`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Filtros para la tabla `programa_2_06`
--
ALTER TABLE `programa_2_06`
  ADD CONSTRAINT `programa_2_06_ibfk_1` FOREIGN KEY (`idcanal`) REFERENCES `canal` (`id`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Filtros para la tabla `programa_2_08`
--
ALTER TABLE `programa_2_08`
  ADD CONSTRAINT `programa_2_08_ibfk_1` FOREIGN KEY (`idcanal`) REFERENCES `canal` (`id`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Filtros para la tabla `programa_3_06`
--
ALTER TABLE `programa_3_06`
  ADD CONSTRAINT `programa_3_06_ibfk_1` FOREIGN KEY (`idcanal`) REFERENCES `canal` (`id`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Filtros para la tabla `programa_3_07`
--
ALTER TABLE `programa_3_07`
  ADD CONSTRAINT `programa_3_07_ibfk_1` FOREIGN KEY (`idcanal`) REFERENCES `canal` (`id`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Filtros para la tabla `programa_3_08`
--
ALTER TABLE `programa_3_08`
  ADD CONSTRAINT `programa_3_08_ibfk_1` FOREIGN KEY (`idcanal`) REFERENCES `canal` (`id`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Filtros para la tabla `programa_4_06`
--
ALTER TABLE `programa_4_06`
  ADD CONSTRAINT `programa_4_06_ibfk_1` FOREIGN KEY (`idcanal`) REFERENCES `canal` (`id`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Filtros para la tabla `programa_4_07`
--
ALTER TABLE `programa_4_07`
  ADD CONSTRAINT `programa_4_07_ibfk_1` FOREIGN KEY (`idcanal`) REFERENCES `canal` (`id`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Filtros para la tabla `programa_4_08`
--
ALTER TABLE `programa_4_08`
  ADD CONSTRAINT `programa_4_08_ibfk_1` FOREIGN KEY (`idcanal`) REFERENCES `canal` (`id`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Filtros para la tabla `programa_5_06`
--
ALTER TABLE `programa_5_06`
  ADD CONSTRAINT `programa_5_06_ibfk_1` FOREIGN KEY (`idcanal`) REFERENCES `canal` (`id`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Filtros para la tabla `programa_5_07`
--
ALTER TABLE `programa_5_07`
  ADD CONSTRAINT `programa_5_07_ibfk_1` FOREIGN KEY (`idcanal`) REFERENCES `canal` (`id`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Filtros para la tabla `programa_5_08`
--
ALTER TABLE `programa_5_08`
  ADD CONSTRAINT `programa_5_08_ibfk_1` FOREIGN KEY (`idcanal`) REFERENCES `canal` (`id`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Filtros para la tabla `programa_6_06`
--
ALTER TABLE `programa_6_06`
  ADD CONSTRAINT `programa_6_06_ibfk_1` FOREIGN KEY (`idcanal`) REFERENCES `canal` (`id`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Filtros para la tabla `programa_6_07`
--
ALTER TABLE `programa_6_07`
  ADD CONSTRAINT `programa_6_07_ibfk_1` FOREIGN KEY (`idcanal`) REFERENCES `canal` (`id`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Filtros para la tabla `programa_6_08`
--
ALTER TABLE `programa_6_08`
  ADD CONSTRAINT `programa_6_08_ibfk_1` FOREIGN KEY (`idcanal`) REFERENCES `canal` (`id`) ON DELETE NO ACTION ON UPDATE CASCADE;
