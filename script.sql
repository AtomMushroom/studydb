-- MySQL dump 10.13  Distrib 8.0.28, for Win64 (x86_64)
--
-- Host: localhost    Database: studydb
-- ------------------------------------------------------
-- Server version	8.0.28

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
-- Table structure for table `main`
--

DROP TABLE IF EXISTS `main`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `main` (
  `id` int NOT NULL,
  `student` int DEFAULT NULL,
  `period` int DEFAULT NULL,
  `subject` int DEFAULT NULL,
  `mark` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `c_idx` (`student`),
  KEY `b_idx` (`period`,`subject`),
  CONSTRAINT `a` FOREIGN KEY (`student`) REFERENCES `student` (`id`),
  CONSTRAINT `b` FOREIGN KEY (`period`, `subject`) REFERENCES `subject` (`period`, `id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `main`
--

LOCK TABLES `main` WRITE;
/*!40000 ALTER TABLE `main` DISABLE KEYS */;
INSERT INTO `main` VALUES (1,1,1,1,3),(2,1,1,2,5),(3,1,1,3,3),(4,1,1,4,2),(5,1,1,5,4),(6,1,1,6,4),(7,1,1,7,5),(8,1,1,8,5),(9,1,1,9,3),(10,1,1,10,3),(11,1,1,11,5),(12,1,1,12,5),(13,1,1,13,4),(14,1,1,14,5),(15,1,2,15,5),(16,1,2,16,5),(17,1,2,17,5),(18,1,2,18,5),(19,1,2,19,5),(20,1,2,20,5),(21,1,2,21,5),(22,1,2,22,5),(23,1,2,23,4),(24,1,2,24,5),(25,1,2,25,4),(26,1,2,26,5),(27,1,2,27,5),(28,1,2,28,3),(29,1,5,29,3),(30,1,4,30,5),(31,1,3,31,5),(32,1,3,32,5),(33,1,3,33,5),(34,1,4,34,4),(35,1,4,35,5),(36,1,5,36,5),(37,1,5,37,5),(38,1,6,38,5),(39,1,6,39,5),(40,1,7,40,5),(41,1,7,41,4),(42,1,8,42,5),(43,1,8,43,5),(44,1,3,44,5),(45,1,3,45,5),(46,1,4,46,3),(47,1,3,47,5),(48,1,4,48,5),(49,1,3,49,5),(50,1,3,50,5),(51,1,8,51,5),(52,1,6,52,5),(53,1,6,53,2),(54,1,3,54,5),(55,1,8,55,5),(56,1,8,56,4),(57,1,5,57,5),(58,1,8,58,5),(59,1,8,59,3),(60,1,7,60,5),(61,1,4,61,5),(62,1,4,62,5),(63,1,4,63,4),(64,1,5,64,5),(65,1,7,65,3),(66,1,4,66,5),(67,1,6,67,5),(68,1,5,68,5),(69,1,6,69,5),(70,1,7,70,5),(71,1,5,71,5),(72,1,6,72,4),(73,1,8,73,4),(74,1,7,74,5),(75,1,8,75,5),(76,1,6,76,5),(77,1,7,77,2),(78,1,6,78,5),(79,1,6,79,5),(80,1,7,80,5),(81,1,8,81,3),(82,1,8,82,5),(83,1,6,83,4),(84,1,6,84,5),(85,1,6,85,5),(86,1,7,86,5),(87,1,7,87,5);
/*!40000 ALTER TABLE `main` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `student`
--

DROP TABLE IF EXISTS `student`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `student` (
  `id` int NOT NULL,
  `firstname` varchar(45) DEFAULT NULL,
  `lastname` varchar(45) DEFAULT NULL,
  `patronymic` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `student`
--

LOCK TABLES `student` WRITE;
/*!40000 ALTER TABLE `student` DISABLE KEYS */;
INSERT INTO `student` VALUES (1,'Иван','Иванов','Иванович'),(2,'Сергей','Сергеев','Сергеевич'),(3,'Сидр','Сидоров','Сидорович'),(4,'Илья','Илюшин','Ильич'),(5,'Владимир','Ульянов','Ильич'),(6,'Владимир','Иванов','Иванович'),(7,'Сергей','Сергеев','Сергеевич'),(8,'Дмитрий','Сидоров','Сидорович'),(9,'Александр','Илюшин','Ильич'),(10,'Николай','Ульянов','Ильич'),(11,'Мария','Иванова','Иванович'),(12,'Дарья','Сергеева','Сергеевич'),(13,'Гоголь','Гоголь','Гоголевич');
/*!40000 ALTER TABLE `student` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `subject`
--

DROP TABLE IF EXISTS `subject`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `subject` (
  `id` int NOT NULL AUTO_INCREMENT,
  `subj` varchar(150) DEFAULT NULL,
  `period` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `any_name` (`period`),
  KEY `any_name2` (`subj`)
) ENGINE=InnoDB AUTO_INCREMENT=88 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `subject`
--

LOCK TABLES `subject` WRITE;
/*!40000 ALTER TABLE `subject` DISABLE KEYS */;
INSERT INTO `subject` VALUES (1,'Русский язык',1),(2,'Литература',1),(3,'Иностранный язык',1),(4,'Математика: алгебра, начала математического анализа, геометрия',1),(5,'История',1),(6,'Физическая культура',1),(7,'ОБЖ',1),(8,'Информатика',1),(9,'Физика',1),(10,'Астрономия',1),(11,'Химия',1),(12,'Обществознание (вкл. экономику и право)',1),(13,'Введение в специальность/ Основы профессиональной этики',1),(14,'Индивидуальный проект/ Решение нестандартных задач',1),(15,'Русский язык',2),(16,'Литература',2),(17,'Иностранный язык',2),(18,'Математика: алгебра, начала математического анализа, геометрия',2),(19,'История',2),(20,'Физическая культура',2),(21,'ОБЖ',2),(22,'Информатика',2),(23,'Физика',2),(24,'Астрономия',2),(25,'Химия',2),(26,'Обществознание (вкл. экономику и право)',2),(27,'Введение в специальность/ Основы профессиональной этики',2),(28,'Индивидуальный проект/ Решение нестандартных задач',2),(29,'Основы философии',5),(30,'История',4),(31,'Психология общения',3),(32,'Иностранный язык в профессиональной деятельности',3),(33,'Физическая культура',3),(34,'Иностранный язык в профессиональной деятельности',4),(35,'Физическая культура',4),(36,'Иностранный язык в профессиональной деятельности',5),(37,'Физическая культура',5),(38,'Иностранный язык в профессиональной деятельности',6),(39,'Физическая культура',6),(40,'Иностранный язык в профессиональной деятельности',7),(41,'Физическая культура',7),(42,'Иностранный язык в профессиональной деятельности',8),(43,'Физическая культура',8),(44,'Элементы высшей математики',3),(45,'Дискретная математика с элементами математической логики',3),(46,'Теория вероятностей и математическая статистика',4),(47,'Операционные системы и среды',3),(48,'Архитектура аппаратных средств',4),(49,'Информационные технологии',3),(50,'Основы алгоритмизации и программирования',3),(51,'Правовое обеспечение профессиональной деятельности',8),(52,'Безопасность жизнедеятельности',6),(53,'Экономика отрасли',6),(54,'Основы проектирования баз данных',3),(55,'Стандартизация, сертификация и техническое документоведение',8),(56,'Численные методы',8),(57,'Компьютерные сети',5),(58,'Менеджмент в профессиональной деятельности',8),(59,'Основы информационной безопасности',8),(60,'Веб-дизайн и разработка',7),(61,'Основы проектирования баз данных',4),(62,'Разработка программных модулей',4),(63,'Поддержка и тестирование программных модулей',4),(64,'Разработка мобильных приложений',5),(65,'Системное программирование',7),(66,'Учебная практика',4),(67,'Производственная практика',6),(68,'Разработка программных модулей',5),(69,'Разработка программных модулей',6),(70,'Разработка программных модулей',7),(71,'Поддержка и тестирование программных модулей',5),(72,'Разработка мобильных приложений',6),(73,'Системное программирование',8),(74,'Производственная практика',7),(75,'Производственная практика',8),(76,'Технология разработки программного обеспечения',6),(77,'Инструментальные средства разработки программного обеспечения',7),(78,'Математическое моделирование',6),(79,'Учебная практика',6),(80,'Производственная практика',7),(81,'Инструментальные средства разработки программного обеспечения',8),(82,'Производственная практика',8),(83,'Технология разработки и защиты баз данных',6),(84,'Учебная практика',6),(85,'Производственная практика',6),(86,'Технология разработки и защиты баз данных',7),(87,'Производственная практика',7);
/*!40000 ALTER TABLE `subject` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-10-09 14:21:59
