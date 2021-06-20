-- phpMyAdmin SQL Dump
-- version 4.8.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 11, 2018 at 02:56 AM
-- Server version: 10.1.32-MariaDB
-- PHP Version: 7.2.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dblibrary`
--

-- --------------------------------------------------------

--
-- Table structure for table `tblbooknumber`
--

CREATE TABLE `tblbooknumber` (
  `ID` int(11) NOT NULL,
  `BOOKTITLE` varchar(255) NOT NULL,
  `QTY` int(11) NOT NULL,
  `Desc` varchar(90) NOT NULL,
  `Author` varchar(90) NOT NULL,
  `PublishDate` date NOT NULL,
  `Publisher` varchar(90) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblbooknumber`
--

INSERT INTO `tblbooknumber` (`ID`, `BOOKTITLE`, `QTY`, `Desc`, `Author`, `PublishDate`, `Publisher`) VALUES
(5, 'life of juan', 4, 'life of juan', 'unknown', '2016-10-10', 'unknown'),
(6, 'the computerizez system', 2, 'computer', 'unknown', '2016-10-10', 'unknown'),
(7, 'language of us', 2, 'language', 'unknown', '2016-10-10', 'unknown'),
(8, 'science', 2, 'invention of science', 'unknown', '2016-10-10', 'unknown'),
(9, 'book', 4, 'book revised', 'unknown', '2016-10-10', 'unknown'),
(10, 'the only book', 1, 'book', 'unknown', '2016-10-10', 'uknown'),
(11, 'book  now', 2, 'book', 'unknown', '2016-10-10', 'unknown'),
(12, 'the one', 1, 'book1', 'unknown', '2016-10-10', 'unknown'),
(13, 'the life of june', 2, 'journey', 'unknown', '2016-10-10', 'unknown'),
(14, 'title', 1, 'book', 'unknown', '2016-10-10', 'unknown'),
(15, 'sad', 1, 's', 'da', '2018-03-25', 'as'),
(16, '2wqe', 1, 'wqe', 'wqe', '2018-03-25', 'wqe');

-- --------------------------------------------------------

--
-- Table structure for table `tblbooks`
--

CREATE TABLE `tblbooks` (
  `BookID` int(11) NOT NULL,
  `AccessionNo` varchar(90) NOT NULL,
  `BookTitle` varchar(125) NOT NULL,
  `BookDesc` varchar(255) NOT NULL,
  `Author` varchar(125) NOT NULL,
  `PublishDate` date NOT NULL,
  `BookPublisher` varchar(125) NOT NULL,
  `CategoryId` int(11) NOT NULL,
  `BookPrice` double NOT NULL,
  `BookQuantity` int(11) NOT NULL,
  `Status` varchar(30) NOT NULL,
  `BookType` varchar(90) NOT NULL,
  `DeweyDecimal` varchar(90) NOT NULL,
  `OverAllQty` int(11) NOT NULL,
  `Donate` tinyint(1) NOT NULL,
  `Remark` varchar(90) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblbooks`
--

INSERT INTO `tblbooks` (`BookID`, `AccessionNo`, `BookTitle`, `BookDesc`, `Author`, `PublishDate`, `BookPublisher`, `CategoryId`, `BookPrice`, `BookQuantity`, `Status`, `BookType`, `DeweyDecimal`, `OverAllQty`, `Donate`, `Remark`) VALUES
(1, '12345678', 'life of juan', 'life of jose and maria', 'unknown', '2016-10-10', 'unknown', 10, 175, 1, 'Available', 'Fiction', 'Purchased', 1, 0, 'Donate'),
(2, '12345671', 'the computerizez system', 'computer', 'unknown', '2016-10-10', 'unknown', 1, 200, 1, 'Available', 'Fiction', '000', 1, 0, 'Donate'),
(3, '12345672', 'languages', 'language', 'unknown', '2016-10-10', 'unknown', 5, 180, 1, 'Available', 'Non-Fiction', '400', 1, 0, 'Purchased'),
(4, '12345673', 'science', 'invention of science', 'unknown', '2016-10-10', 'unknown', 6, 185, 1, 'Available', 'Non-Fiction', '500', 1, 0, 'Purchased'),
(5, '1345672', 'life of juan', 'life of juan', 'unknown', '2016-10-10', 'unknown', 10, 175, 1, 'Available', 'Fiction', '900', 1, 0, 'Purchased'),
(6, '1345673', 'life of juan', 'life of juan', 'unknown', '2016-10-10', 'unknown', 10, 185, 1, 'Available', 'Fiction', '900', 1, 0, 'Purchased'),
(7, '14256372', 'science', 'invention of science', 'unknown', '2016-10-10', 'unknown', 6, 185, 1, 'Available', 'Fiction', '500', 1, 0, 'Purchased'),
(8, '15243678', 'book', 'book revised', 'unknown', '2016-10-10', 'unknown', 7, 109, 1, 'Available', 'Fiction', '600', 1, 0, 'Purchased'),
(9, '15263712', 'language of us', 'language', 'unknown', '2016-10-10', 'unknown', 5, 100, 1, 'Available', 'Fiction', '400', 1, 0, 'Donate'),
(10, '19872634', 'book', 'book revised', 'unknown', '2016-10-10', 'unknown', 7, 190, 1, 'Available', 'Fiction', '600', 1, 0, 'Purchased'),
(11, '18293746', 'the only book', 'book', 'unknown', '2016-10-10', 'uknown', 8, 120, 1, 'Available', 'Unknown', '700', 1, 0, 'Donate'),
(12, '11726354', 'book  now', 'book', 'unknown', '2016-10-10', 'unknown', 8, 150, 1, 'Available', 'Unknown', '700', 1, 0, 'Purchased'),
(13, '10928273', 'the one', 'book1', 'unknown', '2016-10-10', 'unknown', 4, 210, 1, 'Available', 'Unknown', '300', 1, 0, 'Purchased'),
(14, '10987654', 'book', 'book3', 'unknown', '2016-10-16', 'unknown', 7, 125, 1, 'Available', 'Unknown', '600', 1, 0, 'Purchased'),
(15, '98172634', 'the life of june', 'journey', 'unknown', '2016-10-10', 'unknown', 6, 100, 1, 'Available', 'Fiction', '500', 1, 0, 'Donate'),
(16, '19282736', 'the life of june', 'journey', 'unknown', '2016-10-16', 'unknown', 6, 100, 1, 'Available', 'Non-Fiction', '500', 1, 0, 'Purchased'),
(17, '9812345', 'book', 'one', 'unkwon', '2016-11-14', 'unkown', 5, 90, 1, 'Available', 'Fiction', '400', 1, 0, 'Purchased'),
(18, '12345670', 'the computerizez system', 'computer', 'un', '2016-10-10', 'unknown', 1, 200, 1, 'Available', 'Fiction', '000', 1, 0, 'Purchased'),
(19, '12345677', 'life of juan', 'life of juan and jose', 'unknown', '2016-10-10', 'unknown', 10, 0, 1, 'Available', 'Fiction', '900', 1, 0, 'Donate'),
(20, '117263548', 'book  now', 'book one', 'unknown', '2016-10-10', 'unknown', 8, 0, 1, 'Available', 'Unknown', '700', 1, 0, 'Purchased'),
(21, '9876547', 'title', 'book', 'unknown', '2016-10-10', 'unknown', 7, 370, 1, 'Available', 'Fiction', '600', 1, 0, 'Purchased');

-- --------------------------------------------------------

--
-- Table structure for table `tblborrow`
--

CREATE TABLE `tblborrow` (
  `BorrowId` int(11) NOT NULL,
  `AccessionNo` varchar(90) NOT NULL,
  `NoCopies` int(11) NOT NULL,
  `DateBorrowed` datetime NOT NULL,
  `Purpose` varchar(90) NOT NULL,
  `Status` varchar(30) NOT NULL,
  `DueDate` datetime NOT NULL,
  `BorrowerId` int(11) NOT NULL,
  `Due` tinyint(1) NOT NULL,
  `Remarks` varchar(90) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblborrow`
--

INSERT INTO `tblborrow` (`BorrowId`, `AccessionNo`, `NoCopies`, `DateBorrowed`, `Purpose`, `Status`, `DueDate`, `BorrowerId`, `Due`, `Remarks`) VALUES
(1, '15263712', 1, '2016-10-10 13:32:12', 'Borrowed for 3days', 'Returned', '2016-10-13 13:32:12', 4321, 0, 'On Time'),
(2, '12345671', 1, '2016-10-10 13:32:38', 'Borrowed for 3days', 'Returned', '2016-10-13 13:32:38', 912, 0, 'On Time'),
(3, '18293746', 1, '2016-10-10 13:37:13', 'Overnight', 'Returned', '2016-10-11 13:37:13', 921, 0, 'On Time'),
(4, '11726354', 1, '2016-10-10 13:37:36', 'Photocopy', 'Returned', '2016-10-10 14:07:36', 9213, 0, 'On Time'),
(5, '12345678', 1, '2016-10-10 13:50:29', 'Borrowed for 3days', 'Returned', '2016-10-13 13:50:29', 9213, 0, 'On Time'),
(6, '12345673', 1, '2016-10-10 13:50:47', 'Overnight', 'Returned', '2016-10-11 13:50:47', 9213, 0, 'On Time'),
(7, '1345672', 1, '2016-10-10 13:51:07', 'Borrowed for 3days', 'Returned', '2016-10-13 13:51:07', 4321, 0, 'On Time'),
(8, '15243678', 1, '2016-10-10 13:51:27', 'Borrowed for 3days', 'Returned', '2016-10-13 13:51:27', 4321, 0, 'On Time'),
(9, '18293746', 1, '2016-10-10 13:55:23', 'Photocopy', 'Returned', '2016-10-10 14:25:23', 9213, 0, 'On Time'),
(10, '11726354', 1, '2016-10-10 13:55:51', 'Photocopy', 'Returned', '2016-10-10 14:25:51', 9213, 0, 'On Time'),
(11, '10928273', 1, '2016-10-10 13:57:44', 'Research', 'Returned', '2016-10-10 17:30:00', 9213, 0, 'On Time'),
(12, '12345678', 1, '2016-10-10 15:34:20', 'Borrowed for 3days', 'Returned', '2016-10-19 15:33:31', 912, 0, 'On Time'),
(13, '98172634', 1, '2016-10-10 15:34:41', 'Borrowed for 3days', 'Returned', '2016-10-19 15:33:53', 912, 0, 'On Time'),
(14, '9812345', 1, '2016-11-08 08:42:09', 'Borrowed for 3days', 'Returned', '2016-11-17 08:40:38', 912, 0, 'On Time'),
(15, '12345673', 1, '2016-11-08 08:46:40', 'Overnight', 'Returned', '2016-11-15 08:45:08', 912, 0, 'On Time'),
(16, '12345673', 1, '2016-11-08 08:53:53', 'Overnight', 'Returned', '2016-11-09 08:52:21', 912, 0, 'Overdue'),
(17, '19872634', 1, '2016-11-08 15:09:46', 'Borrowed for 3days', 'Returned', '2016-11-11 15:09:46', 213, 0, 'On Time'),
(18, '12345673', 1, '2016-11-17 13:58:29', 'Overnight', 'Returned', '2016-11-18 13:58:29', 912, 0, 'Overdue'),
(19, '12345671', 1, '2016-11-17 13:58:59', 'Borrowed for 3days', 'Returned', '2016-11-20 13:58:59', 912, 0, 'Overdue'),
(20, '1345672', 1, '2016-11-22 14:16:03', 'Borrowed for 3days', 'Returned', '2016-11-25 14:16:03', 912, 0, 'Overdue'),
(21, '18293746', 1, '2016-11-22 14:16:24', 'Research', 'Returned', '2016-11-22 17:30:00', 912, 0, 'Overdue'),
(22, '12345678', 1, '2016-11-29 14:19:24', 'Borrowed for 3days', 'Returned', '2016-12-02 14:19:24', 1234, 0, 'On Time'),
(23, '12345673', 1, '2018-02-09 04:03:56', 'Photocopy', 'Returned', '2018-02-09 04:33:56', 123432, 0, 'On Time'),
(24, '12345673', 1, '2018-03-03 07:13:36', 'Research', 'Returned', '2018-03-03 11:30:00', 921, 0, 'On Time'),
(25, '1345673', 1, '2018-03-23 19:01:51', 'Overnight', 'Returned', '2018-03-24 19:01:51', 1234, 0, 'Overdue'),
(26, '1345673', 1, '2018-03-27 01:51:19', 'Research', 'Returned', '2018-03-27 11:30:00', 123432, 0, 'On Time');

-- --------------------------------------------------------

--
-- Table structure for table `tblborrower`
--

CREATE TABLE `tblborrower` (
  `IDNO` int(11) NOT NULL,
  `BorrowerId` varchar(90) NOT NULL,
  `Firstname` varchar(125) NOT NULL,
  `Lastname` varchar(125) NOT NULL,
  `MiddleName` varchar(125) NOT NULL,
  `Address` varchar(255) NOT NULL,
  `Sex` varchar(11) NOT NULL,
  `ContactNo` varchar(125) NOT NULL,
  `CourseYear` varchar(125) NOT NULL,
  `BorrowerPhoto` varchar(255) NOT NULL,
  `BorrowerType` varchar(35) NOT NULL,
  `Stats` varchar(36) NOT NULL,
  `IMGBLOB` blob NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblborrower`
--

INSERT INTO `tblborrower` (`IDNO`, `BorrowerId`, `Firstname`, `Lastname`, `MiddleName`, `Address`, `Sex`, `ContactNo`, `CourseYear`, `BorrowerPhoto`, `BorrowerType`, `Stats`, `IMGBLOB`) VALUES
(1, '119', 'jom', 'lozada', 'baron', 'ilog', 'Female', '0920', 'BEED', 'Chrysanthemum.jpg', 'Student', '', ''),
(2, '213', 'Janno', 'Palacios', 'E', 'kabankalan City', 'Male', '0192836383', 'BSIT-2', 'Chrysanthemum.jpg', 'Student', 'Active', ''),
(3, '912', 'lou', 'gotera', 'velez', 'rizal', 'Female', '0930', 'BSIT', 'Hydrangeas.jpg', 'Student', 'Active', ''),
(4, '921', 'joma', 'baron', 'lozada', 'dancalan', 'Female', '0921', '', 'Desert.jpg', 'Student', '', ''),
(5, '1234', 'ambot', 'sure', 'guess', 'unknown', 'Male', '0907', 'ELECTRONICS', 'Koala.jpg', 'Student', 'NotActive', ''),
(6, '4321', 'John Craig', 'Nillos', 'Palacios', 'Dancalan Ilog', 'Male', '1233213123', 'BSIT-1', 'Wonderful-Room-King.jpg', 'Student', 'Active', ''),
(7, '9213', 'lou', 'velez', 'gotera', 'rizal', 'Female', '0930', 'BSIT', 'Lighthouse.jpg', 'Student', 'NotActive', ''),
(8, '54321', 'virgel', 'tem', 'brevilla', 'unknown', 'Female', '0930', 'BEED', 'ARIEL 6.jpg', 'Student', 'Active', ''),
(9, '123432', 'Mark', 'Palacios', 'E', 'Galicia Ilog', 'Male', '09291918272', 'HRM-1', 'Chrysanthemum.jpg', 'Student', 'Active', '');

-- --------------------------------------------------------

--
-- Table structure for table `tblcategory`
--

CREATE TABLE `tblcategory` (
  `CategoryId` int(11) NOT NULL,
  `Category` varchar(125) NOT NULL,
  `DDecimal` varchar(90) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblcategory`
--

INSERT INTO `tblcategory` (`CategoryId`, `Category`, `DDecimal`) VALUES
(1, 'Computers, Information and General Reference', '000'),
(2, 'Philosophy and Psychology', '100'),
(3, 'Religion', '200'),
(4, 'Social Science', '300'),
(5, 'Language', '400'),
(6, 'Science', '500'),
(7, 'Technology', '600'),
(8, 'Arts and Recreation', '700'),
(9, 'Literature', '800'),
(10, 'History and Geography', '900'),
(12, 'ALL', 'ALL');

-- --------------------------------------------------------

--
-- Table structure for table `tbllogs`
--

CREATE TABLE `tbllogs` (
  `LogId` int(11) NOT NULL,
  `UserId` int(11) NOT NULL,
  `LogDate` datetime NOT NULL,
  `LogMode` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbllogs`
--

INSERT INTO `tbllogs` (`LogId`, `UserId`, `LogDate`, `LogMode`) VALUES
(1, 3, '2016-08-22 14:30:29', 'Logged in'),
(2, 3, '2016-08-22 14:38:37', 'Logged in'),
(3, 3, '2016-08-22 14:39:03', 'Logged out'),
(4, 3, '2016-08-22 14:47:10', 'Logged in'),
(5, 3, '2016-08-22 14:48:08', 'Logged in'),
(6, 3, '2016-08-22 14:49:32', 'Logged in'),
(7, 3, '2016-08-22 14:57:43', 'Logged in'),
(8, 3, '2016-08-22 14:59:12', 'Logged in'),
(9, 3, '2016-08-22 15:05:27', 'Logged in'),
(10, 3, '2016-08-22 15:23:37', 'Logged in'),
(11, 3, '2016-08-22 15:23:47', 'Logged out'),
(12, 3, '2016-08-22 15:25:00', 'Logged in'),
(13, 3, '2016-08-22 15:25:32', 'Logged out'),
(14, 3, '2016-08-22 15:26:38', 'Logged in'),
(15, 3, '2016-08-22 15:26:45', 'Logged out'),
(16, 3, '2016-08-22 15:27:30', 'Logged in'),
(17, 3, '2016-08-22 15:27:57', 'Logged out'),
(18, 3, '2016-08-22 15:30:28', 'Logged in'),
(19, 3, '2016-08-22 15:31:16', 'Logged out'),
(20, 3, '2016-08-22 15:32:22', 'Logged in'),
(21, 3, '2016-08-22 15:32:54', 'Logged out'),
(22, 3, '2016-08-22 15:34:20', 'Logged in'),
(23, 3, '2016-08-22 15:35:06', 'Logged out'),
(24, 3, '2016-08-22 15:58:47', 'Logged in'),
(25, 3, '2016-08-22 16:02:41', 'Logged out'),
(26, 7, '2016-08-22 16:06:52', 'Logged in'),
(27, 7, '2016-08-24 16:33:38', 'Logged out'),
(28, 3, '2016-08-24 16:33:49', 'Logged in'),
(29, 3, '2016-08-24 16:37:57', 'Logged out'),
(30, 8, '2016-08-24 16:38:08', 'Logged in'),
(31, 8, '2016-08-24 16:40:07', 'Logged out'),
(32, 3, '2016-08-24 16:40:16', 'Logged in'),
(33, 3, '2016-08-24 16:46:31', 'Logged out'),
(34, 3, '2016-08-24 16:48:08', 'Logged in'),
(35, 8, '2016-08-24 16:55:05', 'Logged in'),
(36, 8, '2016-08-24 16:55:11', 'Logged out'),
(37, 8, '2016-08-24 16:55:49', 'Logged in'),
(38, 8, '2016-08-24 17:11:26', 'Logged out'),
(39, 4, '2016-08-24 19:09:55', 'Logged in'),
(40, 3, '2016-08-24 19:18:02', 'Logged in'),
(41, 3, '2016-08-24 19:23:46', 'Logged in'),
(42, 3, '2016-08-24 19:26:44', 'Logged in'),
(43, 3, '2016-08-22 19:28:32', 'Logged out'),
(44, 3, '2016-08-22 19:29:28', 'Logged in'),
(45, 3, '2016-08-22 19:49:21', 'Logged out'),
(46, 3, '2016-08-22 19:52:51', 'Logged in'),
(47, 3, '2016-08-22 19:54:52', 'Logged out'),
(48, 3, '2016-08-22 20:00:32', 'Logged in'),
(49, 3, '2016-08-22 20:01:40', 'Logged out'),
(50, 3, '2016-08-22 20:02:54', 'Logged in'),
(51, 3, '2016-08-22 20:04:21', 'Logged out'),
(52, 3, '2016-08-22 20:06:14', 'Logged in'),
(53, 3, '2016-08-22 20:06:42', 'Logged out'),
(54, 3, '2016-08-22 20:47:41', 'Logged in'),
(55, 3, '2016-08-22 20:48:31', 'Logged out'),
(56, 3, '2016-08-22 20:49:21', 'Logged in'),
(57, 3, '2016-08-22 20:50:50', 'Logged out'),
(58, 3, '2016-08-22 21:00:01', 'Logged in'),
(59, 3, '2016-08-22 21:00:28', 'Logged out'),
(60, 3, '2016-08-22 21:08:06', 'Logged in'),
(61, 3, '2016-08-22 21:08:53', 'Logged out'),
(62, 3, '2016-08-22 21:10:56', 'Logged in'),
(63, 3, '2016-08-22 21:11:26', 'Logged in'),
(64, 3, '2016-08-22 21:12:52', 'Logged out'),
(65, 3, '2016-08-22 21:15:07', 'Logged in'),
(66, 3, '2016-08-22 21:20:13', 'Logged out'),
(67, 3, '2016-08-22 21:23:59', 'Logged in'),
(68, 3, '2016-08-22 22:06:06', 'Logged in'),
(69, 3, '2016-08-22 22:30:16', 'Logged out'),
(70, 3, '2016-08-24 10:23:30', 'Logged in'),
(71, 3, '2016-08-24 10:25:30', 'Logged out'),
(72, 3, '2016-08-24 10:34:54', 'Logged in'),
(73, 3, '2016-08-24 10:51:46', 'Logged out'),
(74, 3, '2016-08-24 12:59:04', 'Logged in'),
(75, 3, '2016-08-24 13:11:17', 'Logged out'),
(76, 3, '2016-08-24 13:15:06', 'Logged in'),
(77, 3, '2016-08-24 13:38:36', 'Logged out'),
(78, 9, '2016-08-24 13:39:02', 'Logged in'),
(79, 9, '2016-08-24 13:41:12', 'Logged out'),
(80, 3, '2016-08-24 13:42:56', 'Logged in'),
(81, 3, '2016-08-24 13:44:20', 'Logged out'),
(82, 3, '2016-08-25 10:22:43', 'Logged in'),
(83, 3, '2016-08-25 10:23:12', 'Logged out'),
(84, 3, '2016-08-30 14:16:22', 'Logged in'),
(85, 3, '2016-08-30 14:16:48', 'Logged out'),
(86, 3, '2016-08-30 14:18:20', 'Logged in'),
(87, 3, '2016-08-30 14:19:12', 'Logged out'),
(88, 3, '2016-08-30 14:22:55', 'Logged in'),
(89, 3, '2016-08-30 14:24:26', 'Logged out'),
(90, 3, '2016-08-30 14:25:22', 'Logged in'),
(91, 3, '2016-08-30 14:26:11', 'Logged out'),
(92, 3, '2016-08-30 14:36:08', 'Logged in'),
(93, 3, '2016-08-30 14:36:32', 'Logged out'),
(94, 3, '2016-08-30 14:38:16', 'Logged in'),
(95, 3, '2016-08-30 14:38:45', 'Logged out'),
(96, 3, '2016-08-30 14:40:48', 'Logged in'),
(97, 3, '2016-08-30 14:43:06', 'Logged out'),
(98, 3, '2016-08-30 14:46:35', 'Logged in'),
(99, 3, '2016-08-30 14:48:53', 'Logged in'),
(100, 3, '2016-08-30 14:49:48', 'Logged out'),
(101, 3, '2016-08-30 14:51:34', 'Logged in'),
(102, 3, '2016-08-30 14:51:54', 'Logged out'),
(103, 3, '2016-08-30 14:52:33', 'Logged in'),
(104, 3, '2016-08-30 14:54:24', 'Logged out'),
(105, 3, '2016-08-30 14:58:10', 'Logged in'),
(106, 3, '2016-08-30 15:05:33', 'Logged out'),
(107, 3, '2016-08-30 15:09:54', 'Logged in'),
(108, 3, '2016-08-30 15:14:43', 'Logged out'),
(109, 3, '2016-08-30 15:15:41', 'Logged in'),
(110, 3, '2016-08-30 15:17:55', 'Logged out'),
(111, 3, '2016-08-30 15:27:54', 'Logged in'),
(112, 3, '2016-08-30 15:29:59', 'Logged out'),
(113, 3, '2016-08-30 15:30:32', 'Logged in'),
(114, 3, '2016-08-30 15:32:17', 'Logged out'),
(115, 3, '2016-09-01 10:46:31', 'Logged in'),
(116, 3, '2016-09-01 11:13:31', 'Logged in'),
(117, 3, '2016-08-30 11:36:16', 'Logged out'),
(118, 3, '2016-09-01 11:40:35', 'Logged in'),
(119, 3, '2016-09-01 11:55:36', 'Logged out'),
(120, 9, '2016-09-01 11:55:59', 'Logged in'),
(121, 9, '2016-09-01 12:00:28', 'Logged out'),
(122, 3, '2016-09-01 12:00:37', 'Logged in'),
(123, 3, '2016-09-01 12:09:16', 'Logged in'),
(124, 3, '2016-09-01 12:09:34', 'Logged out'),
(125, 9, '2016-09-01 12:09:44', 'Logged in'),
(126, 9, '2016-09-01 12:17:04', 'Logged out'),
(127, 3, '2016-09-01 12:17:38', 'Logged out'),
(128, 3, '2016-09-01 12:28:49', 'Logged in'),
(129, 3, '2016-09-01 12:29:27', 'Logged in'),
(130, 3, '2016-09-01 12:36:20', 'Logged out'),
(131, 9, '2016-09-01 12:37:10', 'Logged in'),
(132, 9, '2016-09-01 12:38:48', 'Logged out'),
(133, 3, '2016-09-01 12:39:49', 'Logged in'),
(134, 3, '2016-09-01 12:40:18', 'Logged out'),
(135, 3, '2016-09-01 12:40:49', 'Logged in'),
(136, 3, '2016-09-01 12:44:13', 'Logged out'),
(137, 3, '2016-09-01 12:45:35', 'Logged out'),
(138, 3, '2016-09-01 13:29:56', 'Logged in'),
(139, 3, '2016-09-01 13:30:25', 'Logged out'),
(140, 3, '2016-09-01 14:23:41', 'Logged in'),
(141, 3, '2016-09-01 16:02:46', 'Logged out'),
(142, 3, '2016-09-01 16:32:46', 'Logged in'),
(143, 9, '2016-09-01 16:55:59', 'Logged in'),
(144, 3, '2016-09-01 17:14:17', 'Logged out'),
(145, 3, '2016-09-01 17:26:45', 'Logged in'),
(146, 3, '2016-09-01 17:43:03', 'Logged out'),
(147, 9, '2016-09-01 18:04:33', 'Logged in'),
(148, 9, '2016-09-01 18:06:00', 'Logged out'),
(149, 3, '2016-09-01 18:12:26', 'Logged in'),
(150, 3, '2016-09-01 18:13:08', 'Logged out'),
(151, 3, '2016-09-02 00:03:45', 'Logged in'),
(152, 9, '2016-09-02 00:04:34', 'Logged in'),
(153, 9, '2016-09-02 00:05:36', 'Logged out'),
(154, 3, '2016-09-02 00:05:50', 'Logged in'),
(155, 3, '2016-09-02 00:06:17', 'Logged out'),
(156, 3, '2016-09-02 00:06:27', 'Logged out'),
(157, 3, '2016-09-02 00:50:25', 'Logged in'),
(158, 3, '2016-09-02 01:00:34', 'Logged out'),
(159, 3, '2016-09-02 09:02:56', 'Logged in'),
(160, 3, '2016-09-02 09:06:24', 'Logged out'),
(161, 3, '2016-09-02 09:23:28', 'Logged in'),
(162, 3, '2016-09-02 09:24:33', 'Logged out'),
(163, 9, '2016-09-02 09:35:56', 'Logged in'),
(164, 9, '2016-09-02 09:36:28', 'Logged out'),
(165, 3, '2016-09-02 10:13:53', 'Logged in'),
(166, 3, '2016-09-02 10:14:40', 'Logged out'),
(167, 3, '2016-09-02 15:51:38', 'Logged in'),
(168, 3, '2016-09-02 15:51:53', 'Logged in'),
(169, 3, '2016-09-02 15:52:18', 'Logged out'),
(170, 3, '2016-09-02 15:52:42', 'Logged in'),
(171, 3, '2016-09-02 15:53:03', 'Logged out'),
(172, 3, '2016-09-02 15:55:30', 'Logged in'),
(173, 9, '2016-09-02 15:56:55', 'Logged in'),
(174, 3, '2016-09-02 15:57:02', 'Logged out'),
(175, 9, '2016-09-02 16:10:43', 'Logged in'),
(176, 3, '2016-09-02 16:11:23', 'Logged in'),
(177, 9, '2016-09-02 16:12:52', 'Logged out'),
(178, 3, '2016-09-02 16:13:20', 'Logged out'),
(179, 9, '2016-09-02 16:27:11', 'Logged in'),
(180, 3, '2016-09-02 16:27:27', 'Logged in'),
(181, 9, '2016-09-02 17:14:07', 'Logged out'),
(182, 3, '2016-09-02 17:14:14', 'Logged out'),
(183, 3, '2016-09-02 17:16:50', 'Logged in'),
(184, 3, '2016-09-02 17:20:42', 'Logged out'),
(185, 3, '2016-09-02 17:23:59', 'Logged in'),
(186, 9, '2016-09-02 17:24:56', 'Logged in'),
(187, 9, '2016-09-02 17:37:12', 'Logged out'),
(188, 9, '2016-09-02 17:38:24', 'Logged in'),
(189, 9, '2016-09-02 17:40:07', 'Logged out'),
(190, 3, '2016-09-02 17:40:20', 'Logged out'),
(191, 3, '2016-09-02 14:41:21', 'Logged in'),
(192, 9, '2016-09-02 14:41:37', 'Logged in'),
(193, 3, '2016-09-02 15:58:06', 'Logged out'),
(194, 3, '2016-09-02 20:00:25', 'Logged in'),
(195, 3, '2016-09-02 20:30:22', 'Logged out'),
(196, 3, '2016-09-02 20:38:33', 'Logged in'),
(197, 3, '2016-09-02 20:40:54', 'Logged out'),
(198, 3, '2016-09-06 11:04:04', 'Logged in'),
(199, 3, '2016-09-06 11:04:12', 'Logged out'),
(200, 3, '2016-09-06 11:07:04', 'Logged in'),
(201, 3, '2016-09-06 09:29:19', 'Logged out'),
(202, 3, '2016-09-06 09:29:32', 'Logged in'),
(203, 3, '2016-09-06 09:40:24', 'Logged out'),
(204, 3, '2016-09-06 09:45:58', 'Logged in'),
(205, 3, '2016-09-06 09:46:30', 'Logged out'),
(206, 3, '2016-09-06 09:48:45', 'Logged in'),
(207, 3, '2016-09-06 09:51:21', 'Logged in'),
(208, 3, '2016-09-06 10:02:04', 'Logged out'),
(209, 3, '2016-09-06 10:02:12', 'Logged in'),
(210, 3, '2016-09-06 13:04:41', 'Logged out'),
(211, 9, '2016-09-06 13:04:51', 'Logged in'),
(212, 9, '2016-09-06 10:13:30', 'Logged out'),
(213, 3, '2016-09-06 10:13:44', 'Logged in'),
(214, 3, '2016-09-06 10:03:35', 'Logged out'),
(215, 3, '2016-09-06 10:05:57', 'Logged in'),
(216, 3, '2016-09-06 10:06:15', 'Logged out'),
(217, 3, '2016-09-06 10:07:24', 'Logged in'),
(218, 3, '2016-09-06 10:07:35', 'Logged out'),
(219, 3, '2016-09-06 10:09:56', 'Logged in'),
(220, 3, '2016-09-06 14:10:39', 'Logged out'),
(221, 3, '2016-09-06 14:13:53', 'Logged in'),
(222, 3, '2016-09-06 10:08:30', 'Logged out'),
(223, 3, '2016-09-06 10:09:13', 'Logged in'),
(224, 3, '2016-09-06 10:09:22', 'Logged out'),
(225, 3, '2016-09-06 10:10:52', 'Logged in'),
(226, 3, '2016-09-06 10:11:02', 'Logged out'),
(227, 3, '2016-09-06 10:13:59', 'Logged in'),
(228, 3, '2016-09-06 10:14:06', 'Logged out'),
(229, 3, '2016-09-06 10:11:38', 'Logged in'),
(230, 9, '2016-09-06 10:21:05', 'Logged in'),
(231, 9, '2016-09-06 10:24:00', 'Logged out'),
(232, 9, '2016-09-06 10:24:09', 'Logged in'),
(233, 9, '2016-09-06 10:24:13', 'Logged out'),
(234, 3, '2016-09-06 10:24:21', 'Logged in'),
(235, 3, '2016-09-06 10:24:30', 'Logged out'),
(236, 3, '2016-09-06 10:27:49', 'Logged in'),
(237, 3, '2016-09-06 10:30:57', 'Logged in'),
(238, 3, '2016-09-06 10:40:02', 'Logged out'),
(239, 3, '2016-09-06 10:40:40', 'Logged out'),
(240, 3, '2016-09-06 14:35:45', 'Logged in'),
(241, 9, '2016-09-06 14:43:39', 'Logged in'),
(242, 9, '2016-09-06 14:45:12', 'Logged out'),
(243, 3, '2016-09-06 14:46:59', 'Logged out'),
(244, 3, '2016-09-08 13:19:40', 'Logged in'),
(245, 3, '2016-09-08 13:29:09', 'Logged out'),
(246, 9, '2016-09-09 13:24:41', 'Logged in'),
(247, 9, '2016-09-09 13:25:13', 'Logged out'),
(248, 9, '2016-09-09 13:26:11', 'Logged in'),
(249, 9, '2016-09-09 13:26:19', 'Logged out'),
(250, 3, '2016-09-09 13:26:27', 'Logged in'),
(251, 3, '2016-09-09 13:29:42', 'Logged out'),
(252, 3, '2016-09-09 13:59:16', 'Logged in'),
(253, 3, '2016-09-09 13:59:22', 'Logged out'),
(254, 9, '2016-09-09 14:02:50', 'Logged in'),
(255, 9, '2016-09-09 14:03:05', 'Logged out'),
(256, 3, '2016-09-09 14:03:16', 'Logged in'),
(257, 3, '2016-09-09 14:03:23', 'Logged out'),
(258, 9, '2016-09-09 14:03:36', 'Logged in'),
(259, 3, '2016-09-09 14:03:52', 'Logged in'),
(260, 3, '2016-09-09 14:25:48', 'Logged out'),
(261, 3, '2016-09-10 14:26:19', 'Logged in'),
(262, 9, '2016-09-10 14:26:48', 'Logged out'),
(263, 3, '2016-09-10 14:27:17', 'Logged out'),
(264, 3, '2016-09-10 14:28:14', 'Logged in'),
(265, 3, '2016-09-10 14:28:19', 'Logged out'),
(266, 9, '2016-09-10 14:29:07', 'Logged in'),
(267, 3, '2016-09-10 14:29:16', 'Logged in'),
(268, 3, '2016-09-09 14:32:23', 'Logged out'),
(269, 9, '2016-09-09 14:32:55', 'Logged out'),
(270, 3, '2016-09-09 14:33:34', 'Logged in'),
(271, 3, '2016-09-07 14:37:41', 'Logged out'),
(272, 3, '2016-09-07 14:37:53', 'Logged in'),
(273, 3, '2016-09-12 14:39:38', 'Logged out'),
(274, 3, '2016-09-12 14:39:46', 'Logged in'),
(275, 3, '2016-09-12 14:42:55', 'Logged out'),
(276, 3, '2016-09-12 18:43:28', 'Logged in'),
(277, 3, '2016-09-12 18:43:58', 'Logged out'),
(278, 3, '2016-09-12 16:44:26', 'Logged in'),
(279, 9, '2016-09-12 16:48:40', 'Logged in'),
(280, 3, '2016-09-15 17:14:34', 'Logged out'),
(281, 9, '2016-09-10 17:14:53', 'Logged out'),
(282, 3, '2016-09-10 17:14:58', 'Logged in'),
(283, 9, '2016-09-10 17:15:29', 'Logged in'),
(284, 3, '2016-09-10 17:15:39', 'Logged out'),
(285, 3, '2016-09-15 17:16:04', 'Logged in'),
(286, 3, '2016-09-15 17:25:07', 'Logged out'),
(287, 3, '2016-09-15 17:53:37', 'Logged in'),
(288, 3, '2016-09-15 17:54:07', 'Logged out'),
(289, 10, '2016-09-15 17:54:17', 'Logged in'),
(290, 10, '2016-09-15 18:03:49', 'Logged out'),
(291, 10, '2016-09-15 18:05:26', 'Logged in'),
(292, 10, '2016-09-15 18:07:02', 'Logged out'),
(293, 10, '2016-09-09 18:07:25', 'Logged in'),
(294, 10, '2016-09-09 16:09:43', 'Logged out'),
(295, 10, '2016-09-09 16:09:49', 'Logged in'),
(296, 10, '2016-09-09 16:12:59', 'Logged out'),
(297, 10, '2016-09-09 18:05:39', 'Logged in'),
(298, 10, '2016-09-09 18:05:45', 'Logged out'),
(299, 10, '2016-09-29 12:23:03', 'Logged in'),
(300, 10, '2016-09-29 12:25:05', 'Logged out'),
(301, 10, '2016-09-29 15:13:49', 'Logged in'),
(302, 10, '2016-09-29 15:15:16', 'Logged out'),
(303, 10, '2016-10-10 13:11:06', 'Logged in'),
(304, 10, '2016-10-10 13:14:33', 'Logged in'),
(305, 10, '2016-10-10 13:29:44', 'Logged in'),
(306, 10, '2016-10-10 13:43:37', 'Logged out'),
(307, 3, '2016-10-10 13:44:20', 'Logged in'),
(308, 3, '2016-10-10 13:45:45', 'Logged out'),
(309, 3, '2016-10-10 13:46:05', 'Logged in'),
(310, 3, '2016-10-10 14:00:48', 'Logged out'),
(311, 3, '2016-10-10 14:00:58', 'Logged in'),
(312, 3, '2016-10-10 14:02:17', 'Logged out'),
(313, 10, '2016-10-10 15:29:32', 'Logged in'),
(314, 3, '2016-10-10 15:31:56', 'Logged in'),
(315, 10, '2016-10-10 15:39:15', 'Logged out'),
(316, 3, '2016-10-10 15:41:21', 'Logged out'),
(317, 10, '2016-10-10 15:43:36', 'Logged in'),
(318, 3, '2016-10-10 15:46:09', 'Logged in'),
(319, 10, '2016-10-10 15:50:28', 'Logged out'),
(320, 3, '2016-10-10 15:51:13', 'Logged out'),
(321, 10, '2016-11-07 06:52:09', 'Logged in'),
(322, 10, '2016-11-07 06:53:32', 'Logged in'),
(323, 10, '2016-11-07 06:54:35', 'Logged out'),
(324, 10, '2016-11-07 06:56:53', 'Logged out'),
(325, 10, '2016-11-08 08:35:49', 'Logged in'),
(326, 10, '2016-11-08 08:36:02', 'Logged out'),
(327, 10, '2016-11-08 08:36:17', 'Logged in'),
(328, 9, '2016-11-08 08:38:42', 'Logged in'),
(329, 10, '2016-11-08 08:49:36', 'Logged out'),
(330, 10, '2016-11-08 08:49:54', 'Logged in'),
(331, 10, '2016-11-08 08:58:21', 'Logged out'),
(332, 9, '2016-11-08 08:58:26', 'Logged out'),
(333, 10, '2016-11-25 08:59:08', 'Logged in'),
(334, 9, '2016-11-25 08:59:40', 'Logged in'),
(335, 9, '2016-11-25 09:04:20', 'Logged out'),
(336, 10, '2016-11-25 09:07:13', 'Logged out'),
(337, 10, '2016-11-25 14:36:52', 'Logged in'),
(338, 10, '2016-11-25 14:51:40', 'Logged out'),
(339, 9, '2016-11-25 14:52:08', 'Logged in'),
(340, 9, '2016-11-08 15:05:54', 'Logged out'),
(341, 10, '2016-11-08 15:06:11', 'Logged in'),
(342, 10, '2016-11-08 15:10:05', 'Logged out'),
(343, 10, '2016-11-25 15:10:41', 'Logged in'),
(344, 10, '2016-11-25 15:16:49', 'Logged out'),
(345, 10, '2016-11-08 15:19:19', 'Logged in'),
(346, 10, '2016-11-08 15:21:44', 'Logged out'),
(347, 10, '2016-11-16 15:22:12', 'Logged in'),
(348, 10, '2016-11-16 15:32:09', 'Logged out'),
(349, 3, '2016-11-17 13:56:35', 'Logged in'),
(350, 3, '2016-11-17 14:01:21', 'Logged in'),
(351, 3, '2016-11-22 14:10:38', 'Logged in'),
(352, 3, '2016-11-25 14:24:33', 'Logged in'),
(353, 3, '2016-11-25 14:25:57', 'Logged in'),
(354, 3, '2016-11-26 14:23:38', 'Logged out'),
(355, 3, '2016-11-26 14:24:44', 'Logged in'),
(356, 3, '2016-11-26 14:25:23', 'Logged out'),
(357, 10, '2016-11-29 09:29:19', 'Logged in'),
(358, 10, '2016-11-29 09:41:32', 'Logged out'),
(359, 10, '2016-12-02 11:48:44', 'Logged in'),
(360, 10, '2016-12-02 11:51:56', 'Logged out'),
(361, 3, '2016-12-07 13:11:07', 'Logged in'),
(362, 3, '2016-12-07 13:11:50', 'Logged out'),
(363, 3, '2016-12-07 13:16:26', 'Logged in'),
(364, 3, '2016-12-07 13:16:45', 'Logged out'),
(365, 3, '2016-12-07 13:19:18', 'Logged in'),
(366, 3, '2016-12-07 13:21:20', 'Logged out'),
(367, 10, '2016-12-07 13:22:11', 'Logged in'),
(368, 10, '2016-12-07 13:22:44', 'Logged out'),
(369, 10, '2016-12-10 14:18:57', 'Logged in'),
(370, 10, '2016-12-10 14:42:26', 'Logged out'),
(371, 10, '2016-12-16 08:35:20', 'Logged in'),
(372, 10, '2016-12-16 08:44:55', 'Logged in'),
(373, 10, '2016-12-16 08:46:08', 'Logged in'),
(374, 10, '2016-12-16 08:46:49', 'Logged in'),
(375, 10, '2016-11-29 08:48:04', 'Logged in'),
(376, 10, '2016-11-29 08:48:48', 'Logged in'),
(377, 10, '2016-11-29 12:07:40', 'Logged in'),
(378, 10, '2016-11-29 12:14:48', 'Logged out'),
(379, 3, '2016-11-29 13:07:59', 'Logged in'),
(380, 3, '2016-11-29 14:11:28', 'Logged in'),
(381, 3, '2016-11-29 14:18:12', 'Logged in'),
(382, 3, '2016-11-29 14:19:07', 'Logged in'),
(383, 3, '2018-01-08 00:47:19', 'Logged in'),
(384, 3, '2018-01-08 00:47:55', 'Logged out'),
(385, 10, '2018-01-08 00:47:59', 'Logged in'),
(386, 10, '2018-01-08 00:49:17', 'Logged out'),
(387, 3, '2018-01-08 00:56:40', 'Logged in'),
(388, 3, '2018-01-08 00:56:49', 'Logged out'),
(389, 3, '2018-01-08 01:12:50', 'Logged in'),
(390, 3, '2018-01-08 01:13:47', 'Logged out'),
(391, 3, '2018-01-08 01:18:09', 'Logged in'),
(392, 3, '2018-01-08 01:19:08', 'Logged out'),
(393, 3, '2018-01-18 14:53:05', 'Logged in'),
(394, 3, '2018-01-18 14:56:34', 'Logged out'),
(395, 3, '2018-01-22 08:56:09', 'Logged in'),
(396, 3, '2018-01-22 08:58:30', 'Logged out'),
(397, 3, '2018-01-22 09:01:05', 'Logged in'),
(398, 3, '2018-01-22 09:06:32', 'Logged out'),
(399, 3, '2018-01-22 09:08:32', 'Logged in'),
(400, 3, '2018-01-22 09:08:51', 'Logged out'),
(401, 3, '2018-01-22 09:11:16', 'Logged in'),
(402, 3, '2018-01-22 09:11:22', 'Logged out'),
(403, 3, '2018-01-22 09:13:02', 'Logged in'),
(404, 3, '2018-01-22 12:24:10', 'Logged out'),
(405, 3, '2018-01-22 12:33:19', 'Logged in'),
(406, 3, '2018-01-22 12:34:17', 'Logged out'),
(407, 3, '2018-01-22 12:37:17', 'Logged in'),
(408, 3, '2018-01-22 12:38:16', 'Logged out'),
(409, 3, '2018-01-22 12:43:24', 'Logged in'),
(410, 3, '2018-01-22 12:43:54', 'Logged out'),
(411, 3, '2018-02-10 02:11:24', 'Logged in'),
(412, 3, '2018-02-10 02:11:47', 'Logged out'),
(413, 3, '2018-02-10 02:17:35', 'Logged in'),
(414, 3, '2018-02-10 02:17:58', 'Logged out'),
(415, 3, '2018-02-09 01:02:55', 'Logged in'),
(416, 3, '2018-02-09 03:28:49', 'Logged in'),
(417, 3, '2018-02-09 03:49:52', 'Logged out'),
(418, 3, '2018-02-09 03:54:21', 'Logged in'),
(419, 3, '2018-02-09 03:54:41', 'Logged out'),
(420, 3, '2018-02-09 03:55:19', 'Logged in'),
(421, 3, '2018-02-09 03:55:51', 'Logged out'),
(422, 3, '2018-02-09 04:03:36', 'Logged in'),
(423, 3, '2018-02-09 04:11:19', 'Logged out'),
(424, 3, '2018-02-09 04:14:07', 'Logged in'),
(425, 3, '2018-02-09 04:14:11', 'Logged out'),
(426, 3, '2018-03-03 07:05:32', 'Logged in'),
(427, 3, '2018-03-03 17:35:29', 'Logged out'),
(428, 3, '2018-03-12 01:13:46', 'Logged in'),
(429, 3, '2018-03-12 01:27:30', 'Logged out'),
(430, 3, '2018-03-25 15:18:12', 'Logged in'),
(431, 3, '2018-03-25 15:21:08', 'Logged out'),
(432, 3, '2018-03-25 15:30:29', 'Logged in'),
(433, 3, '2018-03-25 15:31:00', 'Logged out'),
(434, 3, '2018-03-25 15:58:25', 'Logged in'),
(435, 3, '2018-03-25 16:00:33', 'Logged out'),
(436, 3, '2018-03-25 19:01:34', 'Logged in'),
(437, 3, '2018-03-25 19:02:33', 'Logged out'),
(438, 3, '2018-03-26 19:05:17', 'Logged in'),
(439, 3, '2018-03-26 19:07:29', 'Logged out'),
(440, 3, '2018-03-26 19:48:22', 'Logged in'),
(441, 3, '2018-03-26 19:49:39', 'Logged out'),
(442, 3, '2018-03-27 00:52:06', 'Logged in'),
(443, 3, '2018-03-27 00:52:17', 'Logged out'),
(444, 3, '2018-03-27 01:02:20', 'Logged in'),
(445, 3, '2018-03-27 01:05:02', 'Logged out'),
(446, 3, '2018-03-27 01:07:21', 'Logged in'),
(447, 3, '2018-03-27 01:07:24', 'Logged out'),
(448, 3, '2018-03-27 01:07:37', 'Logged in'),
(449, 3, '2018-03-27 01:08:24', 'Logged out'),
(450, 3, '2018-03-27 01:44:54', 'Logged in'),
(451, 3, '2018-03-27 01:50:51', 'Logged in'),
(452, 3, '2018-03-27 01:52:13', 'Logged out'),
(453, 3, '2018-03-27 01:53:50', 'Logged in'),
(454, 3, '2018-03-27 01:54:33', 'Logged out'),
(455, 3, '2018-03-27 01:57:04', 'Logged in'),
(456, 3, '2018-03-27 01:57:28', 'Logged out'),
(457, 3, '2018-08-06 11:27:17', 'Logged in'),
(458, 3, '2018-08-06 11:30:20', 'Logged out'),
(459, 3, '2018-08-06 12:05:29', 'Logged in'),
(460, 3, '2018-08-06 12:06:17', 'Logged out'),
(461, 3, '2018-08-07 10:46:29', 'Logged in'),
(462, 3, '2018-08-07 10:46:57', 'Logged out'),
(463, 3, '2018-08-07 10:51:18', 'Logged in'),
(464, 3, '2018-08-07 10:51:36', 'Logged out'),
(465, 3, '2018-08-07 10:53:23', 'Logged in'),
(466, 3, '2018-08-07 10:54:00', 'Logged out'),
(467, 3, '2018-08-11 06:54:34', 'Logged in'),
(468, 3, '2018-08-11 06:54:49', 'Logged out'),
(469, 3, '2018-08-11 07:07:29', 'Logged in'),
(470, 3, '2018-08-11 07:08:38', 'Logged out'),
(471, 3, '2018-08-11 07:13:23', 'Logged in'),
(472, 3, '2018-08-11 07:15:28', 'Logged out'),
(473, 3, '2018-08-11 08:20:20', 'Logged in'),
(474, 3, '2018-08-11 08:23:37', 'Logged out'),
(475, 3, '2018-08-11 08:37:44', 'Logged in'),
(476, 3, '2018-08-11 08:38:27', 'Logged out'),
(477, 3, '2018-08-11 08:43:38', 'Logged in'),
(478, 3, '2018-08-11 08:44:00', 'Logged out'),
(479, 3, '2018-08-11 08:45:00', 'Logged in'),
(480, 3, '2018-08-11 08:46:02', 'Logged out'),
(481, 3, '2018-08-11 08:52:56', 'Logged in'),
(482, 3, '2018-08-11 08:54:31', 'Logged out');

-- --------------------------------------------------------

--
-- Table structure for table `tblpayment`
--

CREATE TABLE `tblpayment` (
  `PaymentId` int(11) NOT NULL,
  `BorrowId` int(11) NOT NULL,
  `Payment` double NOT NULL,
  `Change` double NOT NULL,
  `DatePayed` date NOT NULL,
  `BorrowerId` int(11) NOT NULL,
  `Remarks` varchar(125) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblpayment`
--

INSERT INTO `tblpayment` (`PaymentId`, `BorrowId`, `Payment`, `Change`, `DatePayed`, `BorrowerId`, `Remarks`) VALUES
(1, 12345673, 130, 0, '2016-11-22', 912, 'Settled'),
(2, 12345673, 4, 0, '2016-11-22', 912, 'Settled'),
(3, 12345671, 4, 0, '2016-11-22', 912, 'Settled'),
(4, 18293746, 37, 13, '2018-02-09', 912, 'Settled'),
(5, 1345672, 37, 3, '2018-02-09', 912, 'Settled'),
(6, 1345673, 1200, 100, '2018-03-26', 1234, 'Settled');

-- --------------------------------------------------------

--
-- Table structure for table `tblreturn`
--

CREATE TABLE `tblreturn` (
  `ReturnId` int(11) NOT NULL,
  `BorrowId` int(11) NOT NULL,
  `NoCopies` int(11) NOT NULL,
  `DateReturned` datetime NOT NULL,
  `Remarks` varchar(125) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblreturn`
--

INSERT INTO `tblreturn` (`ReturnId`, `BorrowId`, `NoCopies`, `DateReturned`, `Remarks`) VALUES
(1, 4, 1, '2016-10-10 13:49:44', 'Returned'),
(2, 3, 1, '2016-10-10 13:49:52', 'Returned'),
(3, 2, 1, '2016-10-10 13:49:59', 'Returned'),
(4, 1, 1, '2016-10-10 13:50:03', 'Returned'),
(5, 6, 1, '2016-10-10 13:54:38', 'Returned'),
(6, 5, 1, '2016-10-10 13:59:33', 'Returned'),
(7, 8, 1, '2016-10-10 13:59:38', 'Returned'),
(8, 9, 1, '2016-10-10 13:59:43', 'Returned'),
(9, 7, 1, '2016-10-10 13:59:46', 'Returned'),
(10, 11, 1, '2016-10-10 13:59:51', 'Returned'),
(11, 10, 1, '2016-10-10 13:59:55', 'Returned'),
(12, 12, 1, '2016-10-10 15:38:26', 'Returned'),
(13, 13, 1, '2016-10-10 15:38:31', 'Returned'),
(14, 15, 1, '2016-11-08 08:53:00', 'Returned'),
(15, 14, 1, '2016-11-25 09:00:00', 'Returned'),
(16, 17, 1, '2016-11-16 15:24:56', 'Returned'),
(17, 12345673, 1, '2016-11-22 14:14:14', 'Returned'),
(18, 12345673, 1, '2016-11-22 14:14:28', 'Returned'),
(19, 12345671, 1, '2016-11-22 14:15:33', 'Returned'),
(20, 22, 1, '2018-01-22 09:14:12', 'Returned'),
(21, 18293746, 1, '2018-02-09 03:48:49', 'Returned'),
(22, 1345672, 1, '2018-02-09 03:49:01', 'Returned'),
(23, 23, 1, '2018-02-09 04:04:23', 'Returned'),
(24, 24, 1, '2018-03-26 19:06:39', 'Returned'),
(25, 1345673, 1, '2018-03-26 19:39:09', 'Returned'),
(26, 26, 1, '2018-08-07 10:22:26', 'Returned');

-- --------------------------------------------------------

--
-- Table structure for table `tbluser`
--

CREATE TABLE `tbluser` (
  `UserId` int(11) NOT NULL,
  `Fullname` varchar(124) NOT NULL,
  `User_name` varchar(125) NOT NULL,
  `Pass` varchar(125) NOT NULL,
  `UserRole` varchar(125) NOT NULL,
  `Status` varchar(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbluser`
--

INSERT INTO `tbluser` (`UserId`, `Fullname`, `User_name`, `Pass`, `UserRole`, `Status`) VALUES
(3, 'Janno Palacios', 'admin', 'd033e22ae348aeb5660fc2140aec35850c4da997', 'Librarian', 'Active'),
(4, 'Craig', 'librarian', '93c768d0152f72bc8d5e782c0b585acc35fb0442', 'Librarian', 'NotActive'),
(5, 'sad', 'sad', 'b4914600112ba18af7798b6c1a1363728ae1d96f', 'Librarian', 'NotActive'),
(6, 'asd', 'sd', '930a0029225aa4c28b8ef095b679285eaae27078', 'Administrator', 'NotActive'),
(7, 'cherry lou velez', 'lou', '15106e6aa53a70c18cb7ee7aa2658c931cd06f69', 'Librarian', 'NotActive'),
(8, 'velez lou', 'velez', 'fbe2b1ad416b7e3251086de11ad56d27ec6f72a3', 'Librarian', 'Active'),
(9, 'jom', 'lozada', 'e1b83874fa199b6a53a8334aeebd578fa8064111', 'Assistant', 'Active'),
(10, 'akon', 'a', '86f7e437faa5a7fce15d1ddcb9eaeaea377667b8', 'Assistant', 'NotActive');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tblbooknumber`
--
ALTER TABLE `tblbooknumber`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tblbooks`
--
ALTER TABLE `tblbooks`
  ADD PRIMARY KEY (`BookID`);

--
-- Indexes for table `tblborrow`
--
ALTER TABLE `tblborrow`
  ADD PRIMARY KEY (`BorrowId`);

--
-- Indexes for table `tblborrower`
--
ALTER TABLE `tblborrower`
  ADD PRIMARY KEY (`IDNO`),
  ADD UNIQUE KEY `BorrowerId` (`BorrowerId`);

--
-- Indexes for table `tblcategory`
--
ALTER TABLE `tblcategory`
  ADD PRIMARY KEY (`CategoryId`);

--
-- Indexes for table `tbllogs`
--
ALTER TABLE `tbllogs`
  ADD PRIMARY KEY (`LogId`);

--
-- Indexes for table `tblpayment`
--
ALTER TABLE `tblpayment`
  ADD PRIMARY KEY (`PaymentId`);

--
-- Indexes for table `tblreturn`
--
ALTER TABLE `tblreturn`
  ADD PRIMARY KEY (`ReturnId`);

--
-- Indexes for table `tbluser`
--
ALTER TABLE `tbluser`
  ADD PRIMARY KEY (`UserId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tblbooknumber`
--
ALTER TABLE `tblbooknumber`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT for table `tblbooks`
--
ALTER TABLE `tblbooks`
  MODIFY `BookID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT for table `tblborrow`
--
ALTER TABLE `tblborrow`
  MODIFY `BorrowId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- AUTO_INCREMENT for table `tblborrower`
--
ALTER TABLE `tblborrower`
  MODIFY `IDNO` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `tblcategory`
--
ALTER TABLE `tblcategory`
  MODIFY `CategoryId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `tbllogs`
--
ALTER TABLE `tbllogs`
  MODIFY `LogId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=483;

--
-- AUTO_INCREMENT for table `tblpayment`
--
ALTER TABLE `tblpayment`
  MODIFY `PaymentId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `tblreturn`
--
ALTER TABLE `tblreturn`
  MODIFY `ReturnId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- AUTO_INCREMENT for table `tbluser`
--
ALTER TABLE `tbluser`
  MODIFY `UserId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
