-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1:3306
-- Tiempo de generación: 16-11-2023 a las 21:00:06
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
-- Base de datos: `modista`
--
CREATE DATABASE IF NOT EXISTS `modista` DEFAULT CHARACTER SET utf8mb4;
USE `modista`;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clientes`
--

DROP TABLE IF EXISTS `clientes`;
CREATE TABLE IF NOT EXISTS `clientes` (
  `IDCliente` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(40) DEFAULT NULL,
  `Apellido` varchar(40) DEFAULT NULL,
  `Dirección` varchar(50) DEFAULT NULL,
  `Cédula_Cli` varchar(15) DEFAULT NULL,
  `Teléfono` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`IDCliente`)
) ENGINE=MyISAM AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `clientes`
--

INSERT INTO `clientes` (`IDCliente`, `Nombre`, `Apellido`, `Dirección`, `Cédula_Cli`, `Teléfono`) VALUES
(3, 'Ana Maria', 'Gonzalez', 'Entre Ríos 548', '3.654.878-5', '091 484 555'),
(5, 'Danilo', 'Ramírez', 'Avda. Solari 1690', '3.706.278-8', '097 343 778'),
(7, 'Juan', 'Marcos ', 'Avda. Almiron 799', '4434352-8', '094 434 228');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `materia_prima`
--

DROP TABLE IF EXISTS `materia_prima`;
CREATE TABLE IF NOT EXISTS `materia_prima` (
  `IDMateriaP` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(40) DEFAULT NULL,
  `Descripción` varchar(100) DEFAULT NULL,
  `Cantidad` int DEFAULT NULL,
  `Costo` int DEFAULT NULL,
  `Costo_Total` int DEFAULT NULL,
  PRIMARY KEY (`IDMateriaP`)
) ENGINE=MyISAM AUTO_INCREMENT=37 DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `materia_prima`
--

INSERT INTO `materia_prima` (`IDMateriaP`, `Nombre`, `Descripción`, `Cantidad`, `Costo_Total`) VALUES
(35, 'Hilo', 'Negro', 3, '60.00'),
(36, 'Hilo', 'Azúl', 3, '30.00'),
(33, 'Hilo', 'Rojo', 4, '20.00');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `Ingreso`
--

DROP TABLE IF EXISTS `Ingreso`;
CREATE TABLE IF NOT EXISTS `Ingreso` (
  `IDIngreso` int NOT NULL AUTO_INCREMENT,
  `FechaHoy_I` date DEFAULT NULL,
  `Descripcion` varchar (100) DEFAULT NULL,
  `Fecha_Retiro` date DEFAULT NULL,
  `Cant_Prendas` int DEFAULT NULL,
  `Valor_Prendas` int DEFAULT NULL,
  `Horas` int DEFAULT NULL,
  `Total` int DEFAULT NULL,
  `Total_I` int DEFAULT NULL,
  `Ocultar` BOOLEAN DEFAULT FALSE,
  `Cierre_I` BOOLEAN DEFAULT FALSE,
  PRIMARY KEY (`IDIngreso`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4;
-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `Egreso`
--

DROP TABLE IF EXISTS `Egreso`;
CREATE TABLE IF NOT EXISTS `Egreso` (
  `IDEgreso` int NOT NULL AUTO_INCREMENT,
  `FechaHoy_E` date DEFAULT NULL,
  `Descripcion` varchar (100) DEFAULT NULL,
  `Costo` int DEFAULT NULL,
  `Total_E` int DEFAULT NULL,
  `Ocultar` BOOLEAN DEFAULT FALSE,
  `Cierre_E` BOOLEAN DEFAULT FALSE,
  PRIMARY KEY (`IDEgreso`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4;
-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `R_Diario`
--

DROP TABLE IF EXISTS `R_Diario`;
CREATE TABLE IF NOT EXISTS `R_Diario` (
  `IDR_Diario` int NOT NULL  AUTO_INCREMENT,
  `Total_Ingreso` INT,
  `Total_Egreso` INT,
  `Fecha_Saldo` DATE DEFAULT NULL,
  `Saldo` INT NOT NULL,
   PRIMARY  KEY (`IDR_Diario`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `R_Mensual`
--

DROP TABLE IF EXISTS `R_Mensual`;
CREATE TABLE IF NOT EXISTS `R_Mensual` (
  `IDR_Mensual` int NOT NULL  AUTO_INCREMENT,
  `IDR_Diario` int,
  `Total_Ingreso` INT,
  `Total_Egreso` INT,
  `Fecha_Saldo` DATE DEFAULT NULL,
  `Saldo` int NOT NULL,
  PRIMARY  KEY (`IDR_Mensual`),
   KEY (`IDR_Diario`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
CREATE TABLE IF NOT EXISTS `usuarios` (
  `IDUsuario` int NOT NULL AUTO_INCREMENT,
  `Usuario` varchar(40) DEFAULT NULL,
  `Contraseña` varchar(80) DEFAULT NULL,
  `Tipo_Usuario` varchar(15) DEFAULT NULL,
  `Teléfono` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`IDUsuario`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`IDUsuario`, `Usuario`, `Contraseña`, `Tipo_Usuario`, `Teléfono`) VALUES
(1, 'admin', '8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918', 'Administrador', '099 000 000'),
(2, 'ola', '1be00341082e25c4e251ca6713e767f7131a2823b0052caf9c9b006ec512f6cb', 'Usuario', '096 123 456');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
