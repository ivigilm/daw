--
-- Base de datos: `cadiz`
--
DROP DATABASE `cadiz`;
CREATE DATABASE IF NOT EXISTS `cadiz` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `cadiz`;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `comarca`
--

DROP TABLE IF EXISTS `comarca`;
CREATE TABLE `comarca` (
  `id` tinyint(3) UNSIGNED NOT NULL,
  `nombre` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `comarca`
--

INSERT INTO `comarca` (`id`, `nombre`) VALUES
(1, 'La Janda'),
(2, 'Sierra de Cádiz'),
(3, 'Campo de Gibraltar'),
(4, 'Bahía de Cádiz'),
(5, 'Costa Noroeste'),
(6, 'Campiña de Jerez');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `municipio`
--

DROP TABLE IF EXISTS `municipio`;
CREATE TABLE `municipio` (
  `id` tinyint(3) UNSIGNED NOT NULL,
  `nombre` varchar(50) DEFAULT NULL,
  `comarca_id` tinyint(3) UNSIGNED DEFAULT NULL,
  `poblacion` int(10) UNSIGNED DEFAULT NULL,
  `superficie` float DEFAULT NULL,
  `densidad` float DEFAULT NULL,
  `altitud` int(11) DEFAULT NULL,
  `distancia` int(10) UNSIGNED DEFAULT NULL,
  `gentilicio` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `municipio`
--

INSERT INTO `municipio` (`id`, `nombre`, `comarca_id`, `poblacion`, `superficie`, `densidad`, `altitud`, `distancia`, `gentilicio`) VALUES
(1, 'Alcalá de los Gazules', 1, 5326, 479.59, 11.21, 165, 79, 'Alcalaíno, na'),
(2, 'Alcalá del Valle', 2, 5224, 46.89, 111.35, 628, 155, 'Alcalareño, ña'),
(3, 'Algar', 2, 1448, 26.6, 55.71, 212, 87, 'Algareño, ña'),
(4, 'Algeciras', 3, 118920, 85.9, 1373.39, 20, 127, 'Algecireño, ña'),
(5, 'Algodonales', 2, 5649, 134.16, 42.32, 370, 118, 'Algodonaleño, ña'),
(6, 'Arcos de la Frontera', 2, 31193, 527.54, 59.24, 185, 67, 'Arcense'),
(7, 'Barbate', 1, 22808, 143.36, 159.47, 14, 64, 'Barbateño, ña'),
(8, 'Benalup-Casas Viejas', 1, 7000, 60.7, 114.78, 112, 62, 'Benalupense'),
(9, 'Benaocaz', 2, 720, 69.39, 10.36, 790, 113, 'Benaocaceño, ña'),
(10, 'Bornos', 2, 7934, 54.31, 147.71, 182, 79, 'Bornicho, cha'),
(11, 'Cádiz', 4, 120468, 12.1, 10061, 11, 0, 'Gaditano, na'),
(12, 'Castellar de la Frontera', 3, 3045, 178.84, 17.24, 47, 137, 'Castellarense'),
(13, 'Chiclana de la Frontera', 4, 82777, 205.45, 400.57, 11, 24, 'Chiclanero, ra'),
(14, 'Chipiona', 5, 19062, 32.92, 577.28, 6, 60, 'Chipionero, ra'),
(15, 'Conil de la Frontera', 1, 22136, 88.51, 249.27, 41, 40, 'Conileño, ña'),
(16, 'El Bosque', 2, 2067, 30.75, 67.28, 285, 96, 'Bosqueño, ña'),
(17, 'El Gastor', 2, 1809, 27.55, 65.44, 590, 131, 'Gastoreño, ña'),
(18, 'El Puerto de Santa María', 4, 88335, 159.34, 556.67, 0, 22, 'Portuense'),
(19, 'Espera', 2, 3915, 123.44, 31.69, 164, 82, 'Espereño, ña'),
(20, 'Grazalema', 2, 2165, 122.41, 17.69, 812, 142, 'Grazalemeño, ña'),
(21, 'Jerez de la Frontera', 6, 212876, 1188.23, 178.61, 56, 6, 'Jerezano, na'),
(22, 'Jimena de la Frontera', 3, 9772, 345.66, 28.09, 99, 157, 'Jimenato, ta'),
(23, 'La Línea de la Concepción', 3, 63352, 19.27, 3276.18, 5, 137, 'Linense'),
(24, 'Los Barrios', 3, 23167, 331.33, 69.39, 23, 117, 'Barreño, ña'),
(25, 'Medina-Sidonia', 1, 11749, 487, 24.22, 400, 45, 'Asidonenses'),
(26, 'Olvera', 2, 8298, 193.57, 43.14, 643, 130, 'Olvereño, ña'),
(27, 'Paterna de Rivera', 1, 5585, 14.01, 400.36, 127, 45, 'Paternero, ra'),
(28, 'Prado del Rey', 2, 5819, 48.58, 121.14, 440, 105, 'Pradense'),
(29, 'Puerto Real', 4, 41509, 195.96, 211.71, 3, 15, 'Puertorrealeño, ña'),
(30, 'Puerto Serrano', 2, 7145, 79.85, 89.25, 168, 105, 'Portoserranense'),
(31, 'Rota', 5, 29123, 84.01, 347.33, 9, 51, 'Roteño, ña'),
(32, 'San Fernando', 4, 96131, 30.65, 3143.07, 25, 14, 'Isleño, ña'),
(33, 'San José del Valle', 6, 4427, 223.87, 19.91, 143, 62, 'Vallense'),
(34, 'San Roque', 3, 29373, 140, 210.65, 109, 130, 'Sanroqueño, ña'),
(35, 'Sanlúcar de Barrameda', 5, 67433, 170.9, 394.29, 30, 53, 'Sanluqueño, ña'),
(36, 'Setenil de las Bodegas', 2, 2845, 82.15, 34.77, 640, 157, 'Setenileño, ña'),
(37, 'Tarifa', 3, 18011, 419.67, 42.67, 7, 105, 'Tarifeño, ña'),
(38, 'Torre Alháquime', 2, 779, 17.36, 44.7, 495, 145, 'Torreño, ña'),
(39, 'Trebujena', 5, 7072, 70, 101.29, 69, 57, 'Trebujenero, ra'),
(40, 'Ubrique', 2, 16836, 69.75, 242.06, 330, 118, 'Ubriqueño, ña'),
(41, 'Vejer de la Frontera', 1, 12812, 262.88, 49.06, 168, 56, 'Vejeriego, ga'),
(42, 'Villaluenga del Rosario', 2, 471, 59.46, 7.67, 858, 128, 'Villaluenguense'),
(43, 'Villamartín', 2, 12271, 210.3, 58.5, 167, 85, 'Villamartinense'),
(44, 'Zahara de la Sierra', 2, 1436, 72.48, 20.14, 500, 124, 'Zahareño, ña');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pedania`
--

DROP TABLE IF EXISTS `pedania`;
CREATE TABLE `pedania` (
  `id` int(10) UNSIGNED NOT NULL,
  `nombre` varchar(50) DEFAULT NULL,
  `municipio_id` tinyint(3) UNSIGNED DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `pedania`
--

INSERT INTO `pedania` (`id`, `nombre`, `municipio_id`) VALUES
(1, 'Los Albarizones', 21),
(2, 'La Barca de la Florida', 21),
(3, 'La Corta', 21),
(4, 'Cuartillos', 21),
(5, 'El Mojo-Baldío de Gallardo', 21),
(6, 'El Portal del Guadalete', 21),
(7, 'Estella del Marqués', 21),
(8, 'Gibalbín', 21),
(9, 'Guadalcacín', 21),
(10, 'Puente de La Guareña', 21),
(11, 'La Ina', 21),
(12, 'Las Pachecas', 21),
(13, 'Lomopardo', 21),
(14, 'Majarromaque', 21),
(15, 'Mesas de Asta', 21),
(16, 'Mesas de Santa Rosa', 21),
(17, 'Mesas del Corral', 21),
(18, 'Mimbral', 21),
(19, 'Nueva Jarilla', 21),
(20, 'El Portal', 21),
(21, 'Rajamancera', 21),
(22, 'San Isidro del Guadalete', 21),
(23, 'Las Tablas, Polila y Añina', 21),
(24, 'El Torno', 21),
(25, 'Tahivilla', 37),
(26, 'Torrecera', 21),
(27, 'Torremelgarejo', 21),
(28, 'Los Ángeles', 22),
(29, 'San Pablo de Buceite', 22),
(30, 'San Martín del Tesorillo', 22),
(31, 'Benamahoma', 20),
(32, 'Pozo Amargo', 30),
(33, 'La Muela', 5),
(34, 'La Almoraima', 12),
(35, 'La Muela', 41),
(36, 'Zahara de los Atunes', 7),
(37, 'Estación de San Roque', 34),
(38, 'Palmones', 24),
(39, 'El Bujeo', 37),
(40, 'El Colmenar', 12),
(41, 'Los Cortijillos', 24),
(42, 'San Enrique de Guadiaro', 34),
(43, 'Poblado de Doña Blanca', 18),
(44, 'Las Abiertas', 6),
(45, 'Jédula', 6),
(46, 'Junta de los Ríos', 6),
(47, 'La Pedrosa', 6),
(48, 'Guadacorte', 24),
(49, 'Campamento', 34),
(50, 'La Colonia', 34),
(51, 'Guadarranque', 34),
(52, 'Guadiaro', 34),
(53, 'Miraflores', 34),
(54, 'Pueblo Nuevo de Guadiaro', 34),
(55, 'Puente Mayorga', 34),
(56, 'San Diego', 34),
(57, 'Sotogrande', 34),
(58, 'Taraguilla', 34),
(59, 'Torreguadiaro', 34),
(60, 'La Alcaidesa', 23),
(61, 'Los Caños de Meca', 7),
(62, 'Novo Sancti Petri', 13),
(63, 'Río San Pedro', 29),
(64, 'El Palmar', 41),
(65, 'El Cuartón', 37),
(66, 'Facinas', 37),
(67, 'La Zarzuela', 37),
(68, 'Bolonia', 37);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `comarca`
--
ALTER TABLE `comarca`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `municipio`
--
ALTER TABLE `municipio`
  ADD PRIMARY KEY (`id`),
  ADD KEY `comarca_id` (`comarca_id`);

--
-- Indices de la tabla `pedania`
--
ALTER TABLE `pedania`
  ADD PRIMARY KEY (`id`),
  ADD KEY `municipio_id` (`municipio_id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `municipio`
--
ALTER TABLE `municipio`
  MODIFY `id` tinyint(3) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=45;
--
-- AUTO_INCREMENT de la tabla `pedania`
--
ALTER TABLE `pedania`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=69;
--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `municipio`
--
ALTER TABLE `municipio`
  ADD CONSTRAINT `municipio_ibfk_1` FOREIGN KEY (`comarca_id`) REFERENCES `comarca` (`id`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Filtros para la tabla `pedania`
--
ALTER TABLE `pedania`
  ADD CONSTRAINT `pedania_ibfk_1` FOREIGN KEY (`municipio_id`) REFERENCES `municipio` (`id`) ON DELETE NO ACTION ON UPDATE CASCADE;
