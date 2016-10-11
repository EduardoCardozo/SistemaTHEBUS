-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           5.5.5-10.0.14-MariaDB - mariadb.org binary distribution
-- OS do Servidor:               Win64
-- HeidiSQL Versão:              8.3.0.4694
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- Copiando estrutura do banco de dados para foodtruck
CREATE DATABASE IF NOT EXISTS `foodtruck` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `foodtruck`;


-- Copiando estrutura para tabela foodtruck.produto
CREATE TABLE IF NOT EXISTS `produto` (
  `Id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Nome` varchar(50) NOT NULL,
  `Preco` double NOT NULL,
  `Quantidade` int(11) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela foodtruck.produto: ~4 rows (aproximadamente)
/*!40000 ALTER TABLE `produto` DISABLE KEYS */;
INSERT INTO `produto` (`Id`, `Nome`, `Preco`, `Quantidade`) VALUES
	(1, 'Hamburguer de Costela', 22, 150),
	(2, 'Big Bus', 20, 150),
	(3, 'Sanduiche de Costela', 18, 100),
	(4, 'Sanduiche de Pernil', 18, 100),
	(5, 'dsdds', 23, 323);
/*!40000 ALTER TABLE `produto` ENABLE KEYS */;


-- Copiando estrutura para tabela foodtruck.registrovenda
CREATE TABLE IF NOT EXISTS `registrovenda` (
  `Id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Data` datetime NOT NULL,
  `PrecoTotal` double DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela foodtruck.registrovenda: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `registrovenda` DISABLE KEYS */;
/*!40000 ALTER TABLE `registrovenda` ENABLE KEYS */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
