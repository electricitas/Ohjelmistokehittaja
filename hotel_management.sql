-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 27.02.2024 klo 07:56
-- Palvelimen versio: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hotel_management`
--

-- --------------------------------------------------------

--
-- Rakenne taululle `asiakkaat`
--

CREATE TABLE `asiakkaat` (
  `ktunnus` varchar(25) NOT NULL,
  `Etunimi` varchar(20) NOT NULL,
  `Sukunimi` varchar(45) NOT NULL,
  `Lahiosoite` varchar(50) NOT NULL,
  `Postinumero` varchar(10) NOT NULL,
  `Postitoimipaikka` varchar(25) NOT NULL,
  `Salasana` int(35) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Vedos taulusta `asiakkaat`
--

INSERT INTO `asiakkaat` (`ktunnus`, `Etunimi`, `Sukunimi`, `Lahiosoite`, `Postinumero`, `Postitoimipaikka`, `Salasana`) VALUES
('kekkurtt', 'Keke', 'Kurttila', 'helsingintie 15', '06541', 'Mäntsälä', 0);

-- --------------------------------------------------------

--
-- Rakenne taululle `huoneet`
--

CREATE TABLE `huoneet` (
  `HuoneenNro` int(6) NOT NULL,
  `Huonetyyppi` int(5) NOT NULL,
  `Puhelin` varchar(7) NOT NULL,
  `Vapaa` varchar(7) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Rakenne taululle `huonekategoria`
--

CREATE TABLE `huonekategoria` (
  `KategoriaId` int(12) NOT NULL,
  `Huonetyyppi` varchar(10) NOT NULL,
  `Hinta` decimal(10,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Rakenne taululle `varaukset`
--

CREATE TABLE `varaukset` (
  `VarausId` int(11) NOT NULL,
  `HuoneenNro` int(11) NOT NULL,
  `AsiakasId` int(11) NOT NULL,
  `DateIn` date NOT NULL,
  `DateOut` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `varaukset`
--
ALTER TABLE `varaukset`
  ADD PRIMARY KEY (`VarausId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `varaukset`
--
ALTER TABLE `varaukset`
  MODIFY `VarausId` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
