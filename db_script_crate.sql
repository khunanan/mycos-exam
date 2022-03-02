-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 02, 2022 at 06:25 PM
-- Server version: 10.4.22-MariaDB
-- PHP Version: 8.1.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_mysql`
--
CREATE DATABASE db_mysql;
CREATE USER 'root'@'localhost';
GRANT SELECT, INSERT, UPDATE, DELETE, CREATE, INDEX, DROP, ALTER, CREATE TEMPORARY TABLES, LOCK TABLES ON matomo_db_name_here.* TO 'root'@'localhost';
-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `id` int(11) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `LastName` varchar(255) NOT NULL,
  `Date_of_birth` date NOT NULL,
  `Start_of_date` date NOT NULL,
  `Salary` int(255) NOT NULL,
  `pvd_3_12` int(3) NOT NULL,
  `pvd_12_36` int(3) NOT NULL,
  `pvd_36_60` int(3) NOT NULL,
  `pvd_max` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`id`, `Name`, `LastName`, `Date_of_birth`, `Start_of_date`, `Salary`, `pvd_3_12`, `pvd_12_36`, `pvd_36_60`, `pvd_max`) VALUES
(4, 'John', 'Wick', '1964-09-02', '2004-03-01', 46000, 3, 5, 8, 10),
(5, 'Beyoncé', 'Knowles', '1981-09-04', '2022-03-02', 25000, 3, 3, 3, 3),
(6, 'Justin', 'Bieber', '2394-06-01', '2016-12-01', 21000, 3, 3, 3, 3),
(7, 'Justin', 'Timberlake', '1981-01-31', '2014-01-20', 35000, 3, 5, 5, 5),
(8, 'Taylor', 'Swift', '1989-12-13', '2014-05-01', 23000, 3, 4, 4, 4);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `employee`
--
ALTER TABLE `employee`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
