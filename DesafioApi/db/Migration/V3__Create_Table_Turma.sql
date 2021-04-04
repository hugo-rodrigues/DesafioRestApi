CREATE TABLE IF NOT EXISTS `turma` (
  `Id` bigint(19) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `Nome` varchar(100) NOT NULL,
  `EscolaId` bigint NOT NULL DEFAULT '0',
  PRIMARY KEY (`Id`),
  KEY `EscolaId` (`EscolaId`),
  CONSTRAINT `FK__escola` FOREIGN KEY (`EscolaId`) REFERENCES `escola` (`id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;