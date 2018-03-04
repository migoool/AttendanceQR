-- phpMyAdmin SQL Dump
-- version 4.7.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 04, 2018 at 11:55 AM
-- Server version: 10.1.22-MariaDB
-- PHP Version: 7.1.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `attendanceqr`
--

-- --------------------------------------------------------

--
-- Table structure for table `qrscan`
--

CREATE TABLE `qrscan` (
  `id` bigint(20) NOT NULL,
  `qr_number` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `qrscan`
--

INSERT INTO `qrscan` (`id`, `qr_number`) VALUES
(1, 20180001);

-- --------------------------------------------------------

--
-- Table structure for table `record`
--

CREATE TABLE `record` (
  `id` bigint(20) NOT NULL,
  `qr` text NOT NULL,
  `name` text NOT NULL,
  `time` time NOT NULL,
  `timeout` time NOT NULL,
  `date_record` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `record`
--

INSERT INTO `record` (`id`, `qr`, `name`, `time`, `timeout`, `date_record`) VALUES
(31, '20180000', ' Sam , Sample ID S', '13:55:13', '17:01:01', '2018-03-02'),
(32, '20180001', ' LastName , Sample 2 M', '13:55:35', '00:00:00', '2018-03-02'),
(33, '2', ' Manuel , Pamela V', '14:14:39', '00:00:00', '2018-03-02'),
(34, '4', ' Lopez , Richelle C', '14:14:43', '00:00:00', '2018-03-02'),
(35, '3', ' Senga , Rupert P', '14:17:53', '00:00:00', '2018-03-02'),
(37, '20180000', ' Sam , Sample ID S', '15:17:24', '17:01:01', '2018-03-03'),
(38, '20180001', ' LastName , Sample 2 M', '19:19:16', '00:00:00', '2018-03-03');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` bigint(20) UNSIGNED NOT NULL,
  `firstname` text NOT NULL,
  `middlename` text NOT NULL,
  `lastname` text NOT NULL,
  `course` text NOT NULL,
  `year` text NOT NULL,
  `section` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `firstname`, `middlename`, `lastname`, `course`, `year`, `section`) VALUES
(1, 'Juan Miguel', 'Vicente', 'Manuel', 'BS Computer Engineering', '5th Year', '1'),
(2, 'Pamela', 'Vicente', 'Manuel', 'BS Electrical Engineering', '3rd Year', '1'),
(3, 'Rupert', 'Pepito', 'Senga', 'BS Computer Engineering', '2nd Year', '1'),
(4, 'Richelle', 'Caponpon', 'Lopez', 'BS Electronics and Communications Engineering', '4th Year', '1'),
(20180000, 'Sample ID', 'Sample Name', 'Sam', 'BS Computer Engineering', '4th Year', '1'),
(20180001, 'Sample 2', 'Middle Name', 'LastName', 'BS Computer Engineering', '4th Year', '1');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `qrscan`
--
ALTER TABLE `qrscan`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `record`
--
ALTER TABLE `record`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `qrscan`
--
ALTER TABLE `qrscan`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `record`
--
ALTER TABLE `record`
  MODIFY `id` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=39;
--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20180002;COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
