-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 30, 2022 at 03:19 PM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.0.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `lufthansa_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `passenger`
--

CREATE TABLE `passenger` (
  `ID` int(11) NOT NULL,
  `Name` varchar(50) CHARACTER SET utf8mb4 NOT NULL,
  `Nationality` varchar(50) CHARACTER SET utf8mb4 NOT NULL,
  `Gender` varchar(20) CHARACTER SET utf8mb4 NOT NULL,
  `Origin` varchar(20) CHARACTER SET utf8mb4 NOT NULL,
  `Destination` varchar(20) CHARACTER SET utf8mb4 NOT NULL,
  `Travel Class` varchar(20) CHARACTER SET utf8mb4 NOT NULL,
  `Class Fees` int(11) NOT NULL,
  `Flight Fees` int(11) NOT NULL,
  `Discount` varchar(50) CHARACTER SET utf8mb4 NOT NULL,
  `Discount Fees` int(11) NOT NULL,
  `Pre Total` int(11) NOT NULL,
  `Total Fees` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `passenger`
--

INSERT INTO `passenger` (`ID`, `Name`, `Nationality`, `Gender`, `Origin`, `Destination`, `Travel Class`, `Class Fees`, `Flight Fees`, `Discount`, `Discount Fees`, `Pre Total`, `Total Fees`) VALUES
(1, 'Muller', 'German', 'Male', 'Berlin', 'Philadelphia', 'Business Class', 250, 1000, 'None of them - No Discount', 0, 1250, 1250),
(2, 'Audrey', 'American', 'Female', 'Philadelphia', 'Hiroshima', 'Business Class', 250, 1500, 'None of them - No Discount', 0, 1750, 1750),
(3, 'Indah', 'American', 'Female', 'Philadelphia', 'Hiroshima', 'Business Class', 250, 1500, 'None of them - No Discount', 0, 1750, 1750),
(4, 'Rafale', 'French', 'Male', 'Philadelphia', 'Hiroshima', 'Business Class', 250, 1500, 'None of them - No Discount', 0, 1750, 1750),
(5, 'Abrams', 'American', 'Male', 'Philadelphia', 'Hiroshima', 'Business Class', 250, 1500, 'None of them - No Discount', 0, 1750, 1750),
(6, 'Anna', 'German', 'Female', 'Berlin', 'Philadelphia', 'First Class', 500, 1000, 'None of them - No Discount', 0, 1500, 1500),
(9, 'Dassault ', 'German', 'Male', 'Berlin', 'Hiroshima', 'First Class', 500, 2000, 'None of them - No Discount', 0, 2500, 2500),
(11, 'Miller', 'American', 'Male', 'Philadelphia', 'Hiroshima', 'Business Class', 250, 1500, 'None of them - No Discount', 0, 1750, 1750),
(12, 'Erika', 'German', 'Female', 'Berlin', 'Hiroshima', 'Economy Class', 100, 2000, 'None of them - No Discount', 0, 2100, 2100),
(23, 'Shayne', 'American', 'Male', 'Berlin', 'Philadelphia', 'Economy Class', 100, 1000, 'None of them - No Discount', 0, 1100, 1100),
(24, 'Hans', 'German', 'Male', 'Berlin', 'Hiroshima', 'Economy Class', 100, 2000, 'None of them - No Discount', 0, 2100, 2100),
(25, 'Jessica', 'American', 'Male', 'Philadelphia', 'Hiroshima', 'Business Class', 250, 1500, 'None of them - No Discount', 0, 1750, 1750),
(26, 'Dempster', 'American', 'Male', 'Philadelphia', 'Hiroshima', 'First Class', 500, 1500, 'People With Disability - 75% Discount', 1500, 2000, 500),
(29, 'Dakota', 'American', 'Male', 'Berlin', 'Hiroshima', 'First Class', 500, 2000, 'None of them - No Discount', 0, 2500, 2500),
(30, 'Angela', 'American', 'Female', 'Berlin', 'Hiroshima', 'Business Class', 250, 2000, 'Single Parent Family - 75% Discount', 1688, 2250, 562),
(31, 'Johnson', 'American', 'Female', 'Berlin', 'Hiroshima', 'First Class', 500, 2000, 'None of them - No Discount', 0, 2500, 2500),
(32, 'Merkel Angela ', 'German', 'Female', 'Berlin', 'Hiroshima', 'First Class', 500, 2000, 'None of them - No Discount', 0, 2500, 2500),
(33, 'Scholtz', 'German', 'Female', 'Berlin', 'Hiroshima', 'Economy Class', 100, 2000, 'None of them - No Discount', 0, 2100, 2100),
(40, 'Alina ', 'Ukrainian', 'Female', 'Berlin', 'Philadelphia', 'First Class', 500, 1000, 'Ukrainian Citizenship - 75% Discount', 1125, 1500, 375),
(41, 'Anastasya Olga ', 'Ukrainian', 'Female', 'Berlin', 'Hiroshima', 'Business Class', 250, 2000, 'Ukrainian Citizenship - 75% Discount', 1688, 2250, 563),
(42, 'Charlie ', 'French', 'Male', 'Berlin', 'Philadelphia', 'Economy Class', 100, 1000, 'None of them - No Discount', 0, 1100, 1100),
(43, 'Leonardo Bonucci', 'Italian', 'Male', 'Berlin', 'Philadelphia', 'Business Class', 250, 1000, 'None of them - No Discount', 0, 1250, 1250),
(44, 'Abraham', 'Israeli', 'Male', 'Philadelphia', 'Hiroshima', 'Business Class', 250, 1500, 'None of them - No Discount', 0, 1750, 1750),
(45, 'Gigi Hadid', 'Palestinian', 'Female', 'Berlin', 'Philadelphia', 'First Class', 500, 1000, 'Single Parent Family - 75% Discount', 1125, 1500, 375),
(46, 'Ahmed', 'Emirates', 'Male', 'Philadelphia', 'Hiroshima', 'Business Class', 250, 1500, 'None of them - No Discount', 0, 1750, 1750),
(47, 'Gaijin', 'Chinese', 'Male', 'Berlin', 'Hiroshima', 'Business Class', 250, 2000, 'None of them - No Discount', 0, 2250, 2250),
(48, 'Yamamoto', 'Japanese', 'Male', 'Berlin', 'Hiroshima', 'First Class', 500, 2000, 'None of them - No Discount', 0, 2500, 2500),
(49, 'Whitney', 'American', 'Female', 'Berlin', 'Philadelphia', 'Economy Class', 100, 1000, 'None of them - No Discount', 0, 1100, 1100),
(50, 'Scarlett Johansson', 'Norwegian', 'Female', 'Berlin', 'Hiroshima', 'Business Class', 250, 2000, 'None of them - No Discount', 0, 2250, 2250),
(51, 'Ashigara', 'Japanese', 'Male', 'Berlin', 'Hiroshima', 'First Class', 500, 2000, 'Single Parent Family - 75% Discount', 1875, 2500, 625),
(52, 'Drew Durnhill', 'American', 'Male', 'Berlin', 'Hiroshima', 'First Class', 500, 2000, 'None of them - No Discount', 0, 2500, 2500),
(53, 'Nakamura', 'Japanese', 'Male', 'Berlin', 'Hiroshima', 'First Class', 500, 2000, 'People With Disability - 75% Discount', 1875, 2500, 625),
(54, 'Nagato', 'Japanese', 'Female', 'Berlin', 'Hiroshima', 'Business Class', 250, 2000, 'None of them - No Discount', 0, 2250, 2250),
(55, 'Rafaela', 'American', 'Female', 'Berlin', 'Philadelphia', 'Business Class', 250, 1000, 'None of them - No Discount', 0, 1250, 1250),
(56, 'Clint', 'American', 'Male', 'Berlin', 'Hiroshima', 'Economy Class', 100, 2000, 'None of them - No Discount', 0, 2100, 2100),
(57, 'Guinevere', 'American', 'Female', 'Berlin', 'Philadelphia', 'Business Class', 250, 1000, 'None of them - No Discount', 0, 1250, 1250),
(62, 'Barbara Palvin', 'American', 'Female', 'Berlin', 'Philadelphia', 'Business Class', 250, 1000, 'Single Parent Family - 75% Discount', 938, 1250, 312),
(63, 'Claude', 'American', 'Male', 'Philadelphia', 'Hiroshima', 'Economy Class', 100, 1500, 'None of them - No Discount', 0, 1600, 1600),
(64, 'Putri', 'Indonesian', 'Female', 'Philadelphia', 'Hiroshima', 'Economy Class', 100, 1500, 'None of them - No Discount', 0, 1600, 1600),
(65, 'Erickson', 'Norwegian', 'Male', 'Berlin', 'Philadelphia', 'Economy Class', 100, 1000, 'None of them - No Discount', 0, 1100, 1100),
(66, 'Alex', 'French', 'Male', 'Berlin', 'Hiroshima', 'First Class', 500, 2000, 'None of them - No Discount', 0, 2500, 2500),
(67, 'Alisha', 'Ukrainian', 'Female', 'Philadelphia', 'Hiroshima', 'First Class', 500, 1500, 'Ukrainian Citizenship - 75% Discount', 1500, 2000, 500),
(68, 'Alabama', 'Canadian', 'Male', 'Philadelphia', 'Hiroshima', 'First Class', 500, 1500, 'None of them - No Discount', 0, 2000, 2000),
(69, 'Jean', 'French', 'Male', 'Berlin', 'Hiroshima', 'First Class', 500, 2000, 'None of them - No Discount', 0, 2500, 2500),
(70, 'Ronald Reagan', 'American', 'Male', 'Berlin', 'Hiroshima', 'First Class', 500, 2000, 'None of them - No Discount', 0, 2500, 2500),
(71, 'Gerald Ford', 'American', 'Male', 'Berlin', 'Philadelphia', 'Business Class', 250, 1000, 'None of them - No Discount', 0, 1250, 1250),
(72, 'John F Kennedy', 'American', 'Male', 'Philadelphia', 'Hiroshima', 'Economy Class', 100, 1500, 'None of them - No Discount', 0, 1600, 1600),
(73, 'Volodymyr Zelensky', 'Ukrainian', 'Male', 'Berlin', 'Philadelphia', 'First Class', 500, 1000, 'Ukrainian Citizenship - 75% Discount', 1125, 1500, 375),
(74, 'Anastasiya', 'Ukrainian', 'Female', 'Berlin', 'Hiroshima', 'First Class', 500, 2000, 'Ukrainian Citizenship - 75% Discount', 1875, 2500, 625),
(75, 'Tojo', 'Japanese', 'Male', 'Berlin', 'Hiroshima', 'Business Class', 250, 2000, 'None of them - No Discount', 0, 2250, 2250),
(76, 'Lemi', 'American', 'Male', 'Philadelphia', 'Hiroshima', 'Economy Class', 100, 1500, 'None of them - No Discount', 0, 1600, 1600),
(77, 'Izumo', 'Japanese', 'Male', 'Berlin', 'Hiroshima', 'Economy Class', 100, 2000, 'None of them - No Discount', 0, 2100, 2100),
(78, 'Hayabusa', 'Japanese', 'Male', 'Philadelphia', 'Hiroshima', 'Economy Class', 100, 1500, 'None of them - No Discount', 0, 1600, 1600),
(80, 'James', 'American', 'Male', 'Berlin', 'Hiroshima', 'First Class', 500, 2000, 'None of them - No Discount', 0, 2500, 2500),
(81, 'Hanabi', 'Japanese', 'Female', 'Philadelphia', 'Hiroshima', 'Economy Class', 100, 1500, 'Single Parent Family - 75% Discount', 1200, 1600, 400),
(83, 'Hinata', 'Japanese', 'Female', 'Philadelphia', 'Hiroshima', 'Economy Class', 100, 1500, 'None of them - No Discount', 0, 1600, 1600),
(84, 'Nobita', 'Japanese', 'Male', 'Berlin', 'Hiroshima', 'Economy Class', 100, 2000, 'None of them - No Discount', 0, 2100, 2100),
(85, 'Siri Tollerod', 'Norwegian', 'Female', 'Berlin', 'Philadelphia', 'Economy Class', 100, 1000, 'People With Disability - 75% Discount', 825, 1100, 275),
(86, 'Nicholas', 'Canadian', 'Male', 'Philadelphia', 'Hiroshima', 'Economy Class', 100, 1500, 'None of them - No Discount', 0, 1600, 1600),
(87, 'Beatrix', 'Canadian', 'Female', 'Philadelphia', 'Hiroshima', 'Economy Class', 100, 1500, 'None of them - No Discount', 0, 1600, 1600),
(88, 'William', 'Canadian', 'Male', 'Berlin', 'Philadelphia', 'Business Class', 250, 1000, 'None of them - No Discount', 0, 1250, 1250),
(89, 'Li Bingbing', 'Chinese', 'Female', 'Berlin', 'Hiroshima', 'Economy Class', 100, 2000, 'None of them - No Discount', 0, 2100, 2100),
(90, 'Shizuka', 'Japanese', 'Female', 'Berlin', 'Hiroshima', 'Business Class', 250, 2000, 'Single Parent Family - 75% Discount', 1688, 2250, 563),
(91, 'Suneo', 'Japanese', 'Male', 'Berlin', 'Hiroshima', 'Business Class', 250, 2000, 'None of them - No Discount', 0, 2250, 2250),
(92, 'Atago', 'Japanese', 'Male', 'Berlin', 'Hiroshima', 'Business Class', 250, 2000, 'None of them - No Discount', 0, 2250, 2250),
(93, 'Fukushima', 'Japanese', 'Female', 'Philadelphia', 'Hiroshima', 'Business Class', 250, 1500, 'None of them - No Discount', 0, 1750, 1750),
(94, 'Suziki', 'Japanese', 'Female', 'Philadelphia', 'Hiroshima', 'Economy Class', 100, 1500, 'None of them - No Discount', 0, 1600, 1600),
(95, 'Arnold', 'American', 'Male', 'Philadelphia', 'Hiroshima', 'Economy Class', 100, 1500, 'None of them - No Discount', 0, 1600, 1600),
(96, 'Willis', 'American', 'Male', 'Berlin', 'Philadelphia', 'Economy Class', 100, 1000, 'None of them - No Discount', 0, 1100, 1100),
(97, 'Arleigh', 'American', 'Male', 'Berlin', 'Philadelphia', 'Economy Class', 100, 1000, 'People With Disability - 75% Discount', 825, 1100, 275),
(98, 'Rafael', 'French', 'Male', 'Berlin', 'Philadelphia', 'Economy Class', 100, 1000, 'People With Disability - 75% Discount', 825, 1100, 275),
(99, 'Husein', 'Emirates', 'Male', 'Berlin', 'Philadelphia', 'Economy Class', 100, 1000, 'None of them - No Discount', 0, 1100, 1100),
(100, 'Luo Yi', 'Chinese', 'Female', 'Philadelphia', 'Hiroshima', 'Economy Class', 100, 1500, 'None of them - No Discount', 0, 1600, 1600),
(101, 'Heinrich', 'German', 'Male', 'Berlin', 'Philadelphia', 'Economy Class', 100, 1000, 'None of them - No Discount', 0, 1100, 1100),
(102, 'Juliane', 'German', 'Female', 'Berlin', 'Philadelphia', 'Economy Class', 100, 1000, 'None of them - No Discount', 0, 1100, 1100),
(103, 'Alan', 'American', 'Male', 'Berlin', 'Hiroshima', 'Economy Class', 100, 2000, 'None of them - No Discount', 0, 2100, 2100),
(105, 'Chris Pratt', 'American', 'Male', 'Berlin', 'Philadelphia', 'Economy Class', 100, 1000, 'None of them - No Discount', 0, 1100, 1100);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `passenger`
--
ALTER TABLE `passenger`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `passenger`
--
ALTER TABLE `passenger`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=107;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
