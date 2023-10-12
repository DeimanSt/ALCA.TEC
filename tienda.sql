-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1:3306
-- Tiempo de generación: 12-10-2023 a las 01:38:44
-- Versión del servidor: 8.0.31
-- Versión de PHP: 8.0.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `tienda`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clientes`
--

DROP TABLE IF EXISTS `clientes`;
CREATE TABLE IF NOT EXISTS `clientes` (
  `IDCliente` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(40) DEFAULT NULL,
  `Apellido` varchar(40) DEFAULT NULL,
  `Cédula_Cli` varchar(15) DEFAULT NULL,
  `Dirección` varchar(50) DEFAULT NULL,
  `Teléfono` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`IDCliente`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `materia_prima`
--

DROP TABLE IF EXISTS `materia_prima`;
CREATE TABLE IF NOT EXISTS `materia_prima` (
  `IDMateriaP` int NOT NULL AUTO_INCREMENT,
  `Descripción` varchar(100) DEFAULT NULL,
  `Costo` decimal(8,2) DEFAULT NULL,
  `StockMP` int DEFAULT NULL,
  PRIMARY KEY (`IDMateriaP`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `medidas`
--

DROP TABLE IF EXISTS `medidas`;
CREATE TABLE IF NOT EXISTS `medidas` (
  `IDMedida` int NOT NULL AUTO_INCREMENT,
  `IDMolde` int DEFAULT NULL,
  `Descripción` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`IDMedida`),
  KEY `IDMolde` (`IDMolde`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `modista`
--

DROP TABLE IF EXISTS `modista`;
CREATE TABLE IF NOT EXISTS `modista` (
  `IDUsuario` int NOT NULL AUTO_INCREMENT,
  `Usuario` varchar(40) DEFAULT NULL,
  `Contraseña` varchar(80) DEFAULT NULL,
  `Teléfono` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`IDUsuario`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `moldes`
--

DROP TABLE IF EXISTS `moldes`;
CREATE TABLE IF NOT EXISTS `moldes` (
  `IDMolde` int NOT NULL AUTO_INCREMENT,
  `Nombre_Molde` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`IDMolde`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `prendas`
--

DROP TABLE IF EXISTS `prendas`;
CREATE TABLE IF NOT EXISTS `prendas` (
  `IDPrenda` int NOT NULL AUTO_INCREMENT,
  `IDUsuario` int DEFAULT NULL,
  `Nombre_Prenda` varchar(50) DEFAULT NULL,
  `Descripción` varchar(100) DEFAULT NULL,
  `Tipo_Tela` varchar(50) DEFAULT NULL,
  `Talle` varchar(8) DEFAULT NULL,
  `Precio` decimal(6,2) DEFAULT NULL,
  PRIMARY KEY (`IDPrenda`),
  KEY `IDUsuario` (`IDUsuario`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `prend_medidas`
--

DROP TABLE IF EXISTS `prend_medidas`;
CREATE TABLE IF NOT EXISTS `prend_medidas` (
  `IDPrenda` int DEFAULT NULL,
  `IDMedida` int DEFAULT NULL,
  `IDMolde` int DEFAULT NULL,
  `Valor` decimal(6,2) DEFAULT NULL,
  KEY `IDPrenda` (`IDPrenda`),
  KEY `IDMedida` (`IDMedida`),
  KEY `IDMolde` (`IDMolde`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `solicita_retira`
--

DROP TABLE IF EXISTS `solicita_retira`;
CREATE TABLE IF NOT EXISTS `solicita_retira` (
  `IDPrenda` int DEFAULT NULL,
  `IDCliente` int DEFAULT NULL,
  `Fecha_Solicitud` date DEFAULT NULL,
  `Fecha_Retiro` date DEFAULT NULL,
  KEY `IDPrenda` (`IDPrenda`),
  KEY `IDCliente` (`IDCliente`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
