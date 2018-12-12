--
-- Base de datos: `flamencoxxi`
--
DROP DATABASE IF EXISTS `flamencoxxi`;
CREATE DATABASE IF NOT EXISTS `flamencoxxi` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `flamencoxxi`;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `espectaculo`
--

DROP TABLE IF EXISTS `espectaculo`;
CREATE TABLE `espectaculo` (
  `idespectaculo` smallint(5) UNSIGNED NOT NULL,
  `espectaculo` varchar(255) NOT NULL,
  `artista` varchar(50) NOT NULL,
  `fecha` date NOT NULL,
  `votos` int(11) NOT NULL DEFAULT '0',
  `foto` varchar(255) DEFAULT NULL,
  `sinopsis` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `espectaculo`
--

INSERT INTO `espectaculo` (`idespectaculo`, `espectaculo`, `artista`, `fecha`, `votos`, `foto`, `sinopsis`) VALUES
(1, 'Al compás con su gente', 'Manuela Carpio', '2017-03-01', 16, 'b8bc88b69c.jpg', 'Manuela Moneo Carpio nace en Jerez de la Frontera, en el seno de dos familias de gran tradición y renombre artístico  de la ciudad, como son los Moneo y los Carpios. Empieza a bailar desde muy pequeña, bajo la enseñanza del maestro de baile Cristóbal Fernández hasta que a la edad de nueve años pisa por primera vez los escenarios, con el grupo España-Jerez que dirige Manuel Morao. Manuel Morao, su gran valedor a lo largo de muchos años, la llama para que forme parte de su compañía, con la que trabajará en sucesivos espectáculos recorriendo, en diferentes giras, los escenarios de EE.U.U y España: Carnegie Hall de Nueva York y Brooklyn Center de Miami entre los más destacados de E.E.U.U además de muchos otros. En España, Lope de Vega de Sevilla, Albéniz de Madrid, Manuel de Falla y Pemán de Cádiz y por supuesto el Villamarta de Jerez de la Frontera. '),
(2, 'Óyeme con los ojos', 'María Pagés', '2017-03-02', 32, '7afc1aa522.jpg', NULL),
(3, 'El encuentro', 'Compañía David Coria', '2017-03-03', 0, '0d7c949abc.jpg', NULL),
(4, 'Baile Moreno', 'Farruquito', '2017-03-04', 1, '23e45aab10.jpg', '"Baile Moreno" es ante todo, un gesto de agradecimiento. El reconocimiento personal y artístico de Farruquito a su padre, el cantaor Juan el Moreno. De él toma la afición por el cante. También el amor a los caballos y a la naturaleza, la dedicación al arte, el respeto por la profesión y el compañerismo. Así que con esta obra, el bailaor pretende acoger esta importante influencia y compartirla con el público. Es el reencuentro con la figura del padre y se produce en un escenario. 15 años atrás en otro escenario, en Buenos Aires, El Moreno fallecía súbitamente mientras le cantaba a Farruquito la soleá escrita por este "Sueña con poder Volar"'),
(5, 'Esencia 20 aniversario', 'Rojas y Rodríguez', '2017-03-05', 0, '417cdf82ed.jpg', 'Esencia es el espectáculo que vuelve a unir a Rojas y Rodríguez en su creación esencial con motivo de su 20º aniversario como creadores. Rojas y Rodríguez quieren volver al origen de sus raíces rescatando de su repertorio momentos únicos que han quedado en la retina de los espectadores a lo largo de sus innumerables giras por todo el mundo. Esencia significa despojarse de todo para estar frente a frente con la verdad del movimiento y la esencia del baile español más genuino.'),
(6, 'Claroscuro', 'Ángel Muñoz', '2017-03-06', 1, NULL, 'Claroscuro es la nueva obra de Ángel Muñoz, un estreno absoluto para el Festival de Jerez 2017, donde el bailaor expande su vocabulario de danza y amplia sus referentes con el mundo del arte sonoro y la música electrónica en relación con el cante.'),
(7, 'Caída del cielo', 'Rocío Molina', '2017-03-08', 2, NULL, NULL),
(8, 'Mírame', 'Pastora Galván', '2017-03-09', 2, NULL, NULL),
(9, 'Guerrero', 'Eduardo Guerrero', '2017-03-10', 2, NULL, NULL),
(10, 'Así que pasen 20 años (1997-2017)', 'Compañía Antonio El Pipa', '2017-03-11', 6, NULL, NULL),
(11, 'Soniquetazo', 'Joaquín Grilo y Antonio Canales', '2017-02-25', 33, 'b92af75a9b.jpg', NULL),
(12, 'Divino amor humano', 'Fuensanta "La Moneta"', '2017-02-26', 3, 'c68935cd8f.jpg', NULL),
(13, 'Catedral', 'Patricia Guerrero', '2017-02-27', 0, NULL, NULL),
(14, 'La espina que quiso ser flor o la flor que soñó con ser bailaora', 'Olga Pericet', '2017-02-28', 2, 'cb32e623a2.jpg', 'Olga Pericet en este espectáculo realiza un viaje personal a través del baile que nace de la memoria, de las heridas, de los besos recibidos, del tiempo que la ha acariciado  como si de un sueño se tratara, donde lo real y lo onírico se funden en un solo espacio -tiempo: su interior. ');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `invitado`
--

DROP TABLE IF EXISTS `invitado`;
CREATE TABLE `invitado` (
  `idinvitado` smallint(5) UNSIGNED NOT NULL,
  `invitado` varchar(50) NOT NULL,
  `espectaculo_idespectaculo` smallint(5) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `invitado`
--

INSERT INTO `invitado` (`idinvitado`, `invitado`, `espectaculo_idespectaculo`) VALUES
(0, 'Tomasa Guerrero "La macanita"', 1),
(2, 'Diego de la Margara', 1),
(3, 'Ana Morales', 3),
(4, 'Jesús Fernández', 14);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `espectaculo`
--
ALTER TABLE `espectaculo`
  ADD PRIMARY KEY (`idespectaculo`);

--
-- Indices de la tabla `invitado`
--
ALTER TABLE `invitado`
  ADD PRIMARY KEY (`idinvitado`),
  ADD KEY `espectaculo_id` (`espectaculo_idespectaculo`);

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `invitado`
--
ALTER TABLE `invitado`
  ADD CONSTRAINT `artista_ibfk_1` FOREIGN KEY (`espectaculo_idespectaculo`) REFERENCES `espectaculo` (`idespectaculo`) ON DELETE CASCADE ON UPDATE CASCADE;
