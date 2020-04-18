-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 11, 2019 at 04:17 PM
-- Server version: 10.3.15-MariaDB
-- PHP Version: 7.3.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `frequenz`
--

-- --------------------------------------------------------

--
-- Table structure for table `frequenz_followers`
--

CREATE TABLE `frequenz_followers` (
  `userFollowerID1` int(11) NOT NULL,
  `userFollowerID2` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `frequenz_friends`
--

CREATE TABLE `frequenz_friends` (
  `UserID1` int(11) NOT NULL,
  `UserID2` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `frequenz_songs`
--

CREATE TABLE `frequenz_songs` (
  `ID` int(11) NOT NULL,
  `ArtistID` int(11) NOT NULL,
  `SongName` varchar(255) NOT NULL,
  `Duration` int(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `frequenz_user`
--

CREATE TABLE `frequenz_user` (
  `ID` int(11) NOT NULL,
  `UserID` int(11) DEFAULT NULL,
  `Username` varchar(255) DEFAULT NULL,
  `email` varchar(255) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  `FriendID` int(11) DEFAULT NULL COMMENT 'This controls the link to the friendsTable',
  `FollowerID` int(11) DEFAULT NULL COMMENT 'This controls the link to the followerTable'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `frequenz_followers`
--
ALTER TABLE `frequenz_followers`
  ADD UNIQUE KEY `userFollowerID1` (`userFollowerID1`),
  ADD UNIQUE KEY `userFollowerID2` (`userFollowerID2`);

--
-- Indexes for table `frequenz_friends`
--
ALTER TABLE `frequenz_friends`
  ADD UNIQUE KEY `UserID1` (`UserID1`),
  ADD UNIQUE KEY `UserID2` (`UserID2`);

--
-- Indexes for table `frequenz_songs`
--
ALTER TABLE `frequenz_songs`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `ArtistID` (`ArtistID`);

--
-- Indexes for table `frequenz_user`
--
ALTER TABLE `frequenz_user`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `FriendID` (`FriendID`),
  ADD UNIQUE KEY `FollowerID` (`FollowerID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `frequenz_songs`
--
ALTER TABLE `frequenz_songs`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `frequenz_user`
--
ALTER TABLE `frequenz_user`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
