-- MySQL dump 10.13  Distrib 8.0.32, for Win64 (x86_64)
--
-- Host: localhost    Database: ccustats
-- ------------------------------------------------------
-- Server version	8.0.32

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `ccubaseball`
--

DROP TABLE IF EXISTS `ccubaseball`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ccubaseball` (
  `id` int NOT NULL AUTO_INCREMENT,
  `season` int DEFAULT NULL,
  `number` int DEFAULT NULL,
  `name` varchar(100) DEFAULT NULL,
  `battingAvg` decimal(4,3) DEFAULT NULL,
  `onBasePlusSlugging` decimal(4,3) DEFAULT NULL,
  `gamesPlayed` int DEFAULT NULL,
  `gamesStarted` int DEFAULT NULL,
  `atBats` int DEFAULT NULL,
  `runs` int DEFAULT NULL,
  `hits` int DEFAULT NULL,
  `doubles` int DEFAULT NULL,
  `triples` int DEFAULT NULL,
  `homeruns` int DEFAULT NULL,
  `runsBattedIn` int DEFAULT NULL,
  `totalBases` int DEFAULT NULL,
  `sluggingPercentage` decimal(4,3) DEFAULT NULL,
  `baseOnBalls` int DEFAULT NULL,
  `hitByPitch` int DEFAULT NULL,
  `strikeout` int DEFAULT NULL,
  `groundIntoDoublePlay` int DEFAULT NULL,
  `onBasePercentage` decimal(4,3) DEFAULT NULL,
  `sacrificeFly` int DEFAULT NULL,
  `sacrificeBunt` int DEFAULT NULL,
  `stolenBases` int DEFAULT NULL,
  `stolenBaseAttempts` int DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=67 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ccubaseball`
--

LOCK TABLES `ccubaseball` WRITE;
/*!40000 ALTER TABLE `ccubaseball` DISABLE KEYS */;
INSERT INTO `ccubaseball` VALUES (1,2023,53,'Bender, Derek',0.341,1.034,62,61,252,61,86,13,2,19,83,160,0.635,16,11,42,7,0.399,4,0,2,3),(2,2023,36,'Hudson, Chase',0.111,0.496,6,2,9,4,1,0,0,0,0,1,0.111,4,0,2,1,0.385,0,1,2,2),(3,2023,32,'Guangorena, Kameron',0.244,0.742,28,6,45,8,11,2,0,2,7,19,0.422,3,2,14,0,0.320,0,0,0,0),(4,2023,27,'Garrison, Tanner',0.275,0.984,38,16,80,23,22,7,0,6,20,47,0.588,9,7,27,1,0.396,0,0,1,1),(5,2023,25,'Pena, Orlando',0.200,0.803,26,10,45,11,9,3,0,2,11,18,0.400,13,3,18,2,0.403,1,2,1,2),(6,2023,23,'Galason, Anthony',0.267,0.743,17,7,30,6,8,2,0,0,11,10,0.333,4,4,6,1,0.410,1,2,0,1),(7,2023,22,'Brown, Graham',0.278,0.950,63,63,255,71,71,24,0,17,71,146,0.573,29,13,73,3,0.377,3,3,8,8),(8,2023,21,'Koon, Houston',0.000,0.250,3,0,3,1,0,0,0,0,0,0,0.000,0,1,0,1,0.250,0,0,0,0),(9,2023,18,'Born, Chad',0.297,0.865,54,47,172,48,51,10,0,6,36,79,0.459,24,11,38,5,0.406,5,1,2,3),(10,2023,17,'Bodine, Caden',0.367,1.065,56,55,215,65,79,17,1,11,47,131,0.609,34,5,21,8,0.456,5,0,1,1),(11,2023,16,'Beach, Zack',0.321,1.071,57,46,168,48,54,10,0,13,56,103,0.613,38,7,61,2,0.458,3,0,3,3),(12,2023,12,'Books, Jake',0.311,0.864,27,14,61,11,19,3,0,2,15,28,0.459,8,3,15,1,0.405,2,0,1,1),(13,2023,8,'Mihos, Dean',0.246,0.686,41,18,69,16,17,7,0,0,15,24,0.348,3,7,17,2,0.338,1,7,2,2),(14,2023,7,'Barthol, Blake',0.308,0.996,52,46,159,41,49,13,4,7,32,91,0.572,26,9,54,1,0.424,4,3,4,6),(15,2023,6,'Lucky, Nick',0.307,1.011,63,61,228,62,70,19,1,13,58,130,0.570,45,13,65,1,0.441,4,2,19,20),(16,2023,5,'Eeles, Payton',0.374,0.992,63,63,246,74,92,17,0,4,43,121,0.492,45,20,34,5,0.500,3,5,42,48),(17,2023,3,'Dooley, Ty',0.281,0.766,57,52,178,32,50,6,0,6,37,74,0.416,12,9,42,1,0.350,4,8,3,4),(18,2022,30,'Johnson, Tyler',0.357,1.221,52,51,171,42,61,11,0,19,61,129,0.754,31,7,48,0,0.467,3,0,2,5),(19,2022,20,'Brown, Eric',0.330,1.004,57,57,206,60,68,19,2,7,40,112,0.544,39,14,28,1,0.460,4,2,12,17),(20,2022,22,'Brown, Graham',0.302,0.922,55,46,159,37,48,15,0,7,43,84,0.528,22,6,29,4,0.394,6,8,4,9),(21,2022,6,'Lucky, Nick',0.297,0.877,60,60,209,48,62,9,0,8,47,95,0.455,40,9,48,5,0.422,5,5,6,10),(22,2022,21,'White, Austin',0.288,0.759,60,60,233,59,67,12,1,1,39,84,0.361,39,7,38,1,0.398,5,9,34,39),(23,2022,1,'Thomas, Dale',0.284,0.927,59,59,218,49,62,15,2,13,49,120,0.550,31,2,48,6,0.377,1,5,5,7),(24,2022,17,'McDermott, Matt',0.273,0.792,60,58,209,44,57,10,4,7,41,96,0.459,19,3,45,2,0.333,6,4,19,25),(25,2022,25,'Pena, Orlando',0.300,0.717,8,0,10,6,3,0,0,0,1,3,0.300,2,0,3,0,0.417,0,0,0,0),(26,2022,32,'Guangorena, Kameron',0.282,0.797,37,30,103,26,29,7,0,2,12,42,0.408,17,3,22,3,0.389,3,4,1,2),(27,2022,23,'Rowan, Jr., Christopher',0.280,0.949,41,35,125,32,35,9,0,8,29,68,0.544,19,8,36,2,0.405,1,2,1,1),(28,2022,27,'Garrison, Tanner',0.263,0.793,31,22,76,13,20,2,0,3,11,31,0.408,8,7,19,2,0.385,0,4,0,1),(29,2022,53,'Bender, Derek',0.250,0.806,22,9,32,3,8,0,0,2,7,14,0.438,4,2,8,0,0.368,0,1,0,1),(30,2022,16,'Beach, Zack',0.247,0.795,44,22,77,18,19,3,0,3,13,31,0.403,14,5,31,0,0.392,1,1,1,1),(31,2022,7,'Weiss, Cooper',0.222,0.691,32,19,72,15,16,2,1,1,12,23,0.319,12,7,30,1,0.372,3,4,2,2),(32,2022,10,'Underwood, Billy',0.209,0.672,32,7,43,14,9,4,0,0,6,13,0.302,10,1,9,0,0.370,0,0,3,3),(33,2022,5,'Gitter, Jake',0.095,0.486,9,5,21,2,2,1,0,1,4,6,0.286,2,1,8,0,0.200,1,0,0,0),(34,2021,3,'Chavers, Parker',0.318,0.884,49,49,195,32,62,12,2,5,33,93,0.477,23,7,30,0,0.407,1,0,14,18),(35,2021,20,'Brown, Eric',0.294,0.926,50,50,187,42,55,12,1,9,38,96,0.513,33,7,37,4,0.413,3,4,11,15),(36,2021,10,'Underwood, Billy',0.280,0.791,40,33,125,20,35,10,0,2,22,51,0.408,19,3,33,0,0.383,2,1,3,4),(37,2021,6,'Lucky, Nick',0.279,0.868,50,50,190,47,53,10,4,8,34,95,0.500,20,9,52,0,0.368,4,11,7,8),(38,2021,1,'Thomas, Dale',0.277,0.781,49,48,166,31,46,4,1,5,26,67,0.404,22,7,37,3,0.377,4,10,3,6),(39,2021,25,'Riopelle, BT',0.270,0.813,48,47,185,27,50,11,0,8,27,85,0.459,17,7,77,1,0.354,0,2,8,10),(40,2021,33,'Gattinelli, Alex',0.244,0.778,46,46,172,30,42,6,1,9,37,77,0.448,21,3,30,3,0.330,4,3,4,6),(41,2021,23,'Pate, Makenzie',0.217,0.740,40,19,69,21,15,3,0,3,10,27,0.391,4,10,38,0,0.349,0,4,6,7),(42,2021,7,'Weiss, Cooper',0.208,0.745,44,44,144,27,30,6,4,3,24,53,0.368,32,7,57,0,0.377,0,5,1,2),(43,2021,27,'Garrison, Tanner',0.222,0.784,20,15,54,10,12,2,0,3,15,23,0.426,8,4,18,1,0.358,1,1,0,0),(44,2021,16,'Beach, Zack',0.215,0.760,30,28,93,15,20,0,1,6,13,40,0.430,15,2,36,1,0.330,2,2,1,1),(45,2021,30,'Johnson, Tyler',0.162,0.599,27,16,68,8,11,3,0,2,7,20,0.294,13,1,31,0,0.305,0,0,0,0),(46,2021,21,'Morello, Lorenzo',0.162,0.468,19,8,37,6,6,1,0,0,5,7,0.189,4,2,15,1,0.279,0,2,3,3),(47,2021,19,'Leum, Fox',0.063,0.381,12,5,16,2,1,0,0,0,0,1,0.063,5,1,10,0,0.318,0,0,0,0),(48,2021,36,'Richardson, Walt',0.000,0.286,4,1,5,0,0,0,0,0,1,0,0.000,2,0,5,0,0.286,0,0,0,0),(49,2020,7,'Weiss, Cooper',0.372,1.101,15,12,43,13,16,5,0,2,14,27,0.628,6,4,11,0,0.473,2,0,5,6),(50,2020,10,'McKeon, Scott',0.359,1.003,16,16,64,19,23,1,0,4,9,36,0.563,7,3,12,1,0.440,1,0,3,3),(51,2020,33,'Gattinelli, Alex',0.317,0.920,16,16,60,13,19,3,0,4,22,34,0.567,3,2,12,1,0.353,3,0,2,2),(52,2020,23,'Pate, Makenzie',0.286,0.862,15,13,35,11,10,1,1,1,4,16,0.457,4,3,11,0,0.405,0,0,6,6),(53,2020,24,'Hyde, Morgan',0.286,0.795,16,8,35,13,10,1,0,1,8,14,0.400,6,1,5,0,0.395,1,1,0,0),(54,2020,25,'Riopelle, BT',0.282,1.070,12,12,39,8,11,2,1,4,11,27,0.692,6,0,10,1,0.378,0,0,1,1),(55,2020,6,'Lucky, Nick',0.271,0.764,16,15,48,18,13,3,0,0,7,16,0.333,11,4,17,0,0.431,2,0,6,6),(56,2020,20,'Brown, Eric',0.259,0.687,16,16,58,11,15,3,0,0,10,18,0.310,9,2,10,0,0.377,0,2,3,5),(57,2020,19,'Leum, Fox',0.250,0.753,15,14,36,9,9,0,0,1,10,12,0.333,12,0,14,0,0.420,2,1,0,0),(58,2020,16,'Beach, Zack',0.195,0.755,15,12,41,8,8,4,0,1,8,15,0.366,10,3,17,1,0.389,0,2,0,1),(59,2020,17,'Johnson, Jared',0.400,0.900,9,0,10,1,4,0,0,0,2,4,0.400,2,0,1,0,0.500,0,0,0,0),(60,2020,2,'Westfall, Kyle',0.333,1.166,10,0,6,2,2,0,0,1,3,5,0.833,0,0,3,0,0.333,0,0,1,1),(61,2020,11,'Kirkley, Connor',0.333,1.167,8,0,3,1,1,1,0,0,0,2,0.667,1,0,1,0,0.500,0,0,1,1),(62,2020,1,'Thomas, Dale',0.273,0.606,8,0,11,4,3,0,0,0,0,3,0.273,1,0,2,0,0.333,0,0,0,0),(63,2020,27,'Garrison, Tanner',0.250,0.857,7,3,12,2,3,0,0,1,7,6,0.500,1,1,2,0,0.357,0,0,0,0),(64,2020,5,'Port, Brian',0.217,0.574,11,7,23,2,5,0,0,0,1,5,0.217,4,1,8,0,0.357,0,2,0,0),(65,2020,47,'Ashburn, Hunter',0.000,0.000,5,0,4,0,0,0,0,0,0,0,0.000,0,0,2,0,0.000,0,0,0,0),(66,2020,36,'Richardson, Walt',0.000,0.000,1,0,1,0,0,0,0,0,0,0,0.000,0,0,1,0,0.000,0,0,0,0);
/*!40000 ALTER TABLE `ccubaseball` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-10-10 16:54:14
