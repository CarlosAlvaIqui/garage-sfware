-- phpMyAdmin SQL Dump
-- version 4.6.6
-- https://www.phpmyadmin.net/
--
-- Servidor: localhost
-- Tiempo de generación: 14-10-2019 a las 23:52:03
-- Versión del servidor: 5.7.17-log
-- Versión de PHP: 5.6.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `estacionamiento`
--
CREATE DATABASE IF NOT EXISTS `estacionamiento` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `estacionamiento`;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `boletas`
--

CREATE TABLE `boletas` (
  `id` int(10) NOT NULL,
  `nombreEstac` varchar(200) NOT NULL,
  `nombreUser` varchar(200) NOT NULL,
  `placa` varchar(20) NOT NULL,
  `zona` varchar(20) NOT NULL,
  `horaI` time NOT NULL,
  `horaF` time NOT NULL,
  `monto` decimal(10,6) NOT NULL,
  `descuento` decimal(10,6) NOT NULL,
  `total` decimal(10,6) NOT NULL,
  `fecha` date NOT NULL,
  `hora` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `carros`
--

CREATE TABLE `carros` (
  `id` int(10) NOT NULL,
  `placa` varchar(60) NOT NULL,
  `tipo` varchar(200) NOT NULL,
  `descripcion` varchar(300) NOT NULL,
  `nombreEstac` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `carros`
--

INSERT INTO `carros` (`id`, `placa`, `tipo`, `descripcion`, `nombreEstac`) VALUES
(1, 'ACM-1PT', 'Furgoneta', 'Abollado por la derecha cerca a la puerta', 'Estaciona Ya');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `id` int(10) NOT NULL,
  `usuario` varchar(60) NOT NULL,
  `contraseña` varchar(60) NOT NULL,
  `ubicacion` varchar(300) NOT NULL,
  `nombreEstac` varchar(100) NOT NULL,
  `nombre` varchar(200) NOT NULL,
  `dni` int(10) NOT NULL,
  `celular` int(12) NOT NULL,
  `tipo` varchar(20) NOT NULL,
  `cobroPhora` decimal(10,6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`id`, `usuario`, `contraseña`, `ubicacion`, `nombreEstac`, `nombre`, `dni`, `celular`, `tipo`, `cobroPhora`) VALUES
(1, 'lhyan123', 'lhyan123', 'Calle Cuadrada H-4', 'Estaciona Ya', 'Lhyan Robles Rodriguez', 72711859, 935874699, 'Administrador', '3.000000');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `boletas`
--
ALTER TABLE `boletas`
  ADD PRIMARY KEY (`id`),
  ADD KEY `placa` (`placa`),
  ADD KEY `nombreUser` (`nombreUser`),
  ADD KEY `nombreEstac` (`nombreEstac`);

--
-- Indices de la tabla `carros`
--
ALTER TABLE `carros`
  ADD PRIMARY KEY (`id`),
  ADD KEY `placa` (`placa`),
  ADD KEY `nombreEstac` (`nombreEstac`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`id`),
  ADD KEY `nombreEstac` (`nombreEstac`),
  ADD KEY `ubicacion` (`ubicacion`),
  ADD KEY `nombre` (`nombre`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `boletas`
--
ALTER TABLE `boletas`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `carros`
--
ALTER TABLE `carros`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `boletas`
--
ALTER TABLE `boletas`
  ADD CONSTRAINT `boletas_ibfk_1` FOREIGN KEY (`nombreEstac`) REFERENCES `usuarios` (`nombreEstac`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `boletas_ibfk_2` FOREIGN KEY (`nombreUser`) REFERENCES `usuarios` (`nombre`) ON DELETE NO ACTION ON UPDATE CASCADE,
  ADD CONSTRAINT `boletas_ibfk_3` FOREIGN KEY (`placa`) REFERENCES `carros` (`placa`) ON DELETE NO ACTION ON UPDATE CASCADE;

--
-- Filtros para la tabla `carros`
--
ALTER TABLE `carros`
  ADD CONSTRAINT `carros_ibfk_1` FOREIGN KEY (`nombreEstac`) REFERENCES `usuarios` (`nombreEstac`) ON DELETE NO ACTION ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
