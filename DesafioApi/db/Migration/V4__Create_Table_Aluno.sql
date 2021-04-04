CREATE TABLE IF NOT EXISTS `aluno` (
  `Id` bigint(19) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `Nome` varchar(100) NOT NULL,
  `Nota` float NOT NULL DEFAULT '0',
  `TurmaId` bigint(19) unsigned zerofill NOT NULL DEFAULT '0000000000000000000',
  PRIMARY KEY (`Id`),
  KEY `Index 2` (`TurmaId`),
  CONSTRAINT `TurmaId` FOREIGN KEY (`TurmaId`) REFERENCES `turma` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;