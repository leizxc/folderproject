-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 18, 2025 at 08:45 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `database_panel`
--

-- --------------------------------------------------------

--
-- Table structure for table `account`
--

CREATE TABLE `account` (
  `id` int(11) NOT NULL,
  `firstname` varchar(50) NOT NULL,
  `lastname` varchar(50) NOT NULL,
  `middlename` varchar(50) NOT NULL,
  `username` varchar(50) NOT NULL,
  `passwordusername` varchar(50) NOT NULL,
  `role` varchar(50) NOT NULL,
  `secques` varchar(50) NOT NULL,
  `secans` varchar(50) NOT NULL,
  `age` int(3) NOT NULL,
  `gender` varchar(10) DEFAULT NULL,
  `contact` varchar(14) NOT NULL,
  `address` varchar(100) NOT NULL,
  `acc_status` varchar(20) DEFAULT NULL,
  `course` varchar(100) NOT NULL,
  `subject` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `account`
--

INSERT INTO `account` (`id`, `firstname`, `lastname`, `middlename`, `username`, `passwordusername`, `role`, `secques`, `secans`, `age`, `gender`, `contact`, `address`, `acc_status`, `course`, `subject`) VALUES
(20253, 'nelmar', 'radam', 's', 'itsmebbm', '25d55ad283aa400af464c76d713c07ad', 'ADMIN', '', '', 0, '', '', '', '', '', ''),
(20256, 'dave', 'abriol', 'd', 'dave', '25d55ad283aa400af464c76d713c07ad', 'STUDENT', 'Favorite Food', 'kalapate', 20, NULL, '09223112', 'canada', 'ON', 'BSIT', '');

--
-- Triggers `account`
--
DELIMITER $$
CREATE TRIGGER `trg_insert_stud_prfl` AFTER INSERT ON `account` FOR EACH ROW BEGIN
  IF NEW.role = 'STUDENT' THEN
    INSERT INTO stud_prfl (
      id, firstname, lastname, middlename, age, gender, contact, address, acc_status, course, username
    ) VALUES (
      NEW.id, NEW.firstname, NEW.lastname, NEW.middlename,
      NEW.age, NEW.gender, NEW.contact, new.address, new.acc_status, new.course, new.username
    );
  END IF;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `admin_users`
--

CREATE TABLE `admin_users` (
  `admin_id` int(11) NOT NULL,
  `user_id` varchar(50) DEFAULT NULL,
  `full_name` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `cashier_pfrl`
--

CREATE TABLE `cashier_pfrl` (
  `cashier_id` int(11) NOT NULL,
  `account_id` int(11) NOT NULL,
  `first_name` varchar(50) NOT NULL,
  `middle_name` varchar(50) NOT NULL,
  `last_name` varchar(50) NOT NULL,
  `age` int(2) DEFAULT NULL,
  `gender` varchar(20) DEFAULT NULL,
  `birthday` varchar(50) DEFAULT NULL,
  `address` varchar(100) DEFAULT NULL,
  `contact_num` int(11) DEFAULT NULL,
  `status` varchar(20) DEFAULT 'ACTIVE'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `first_sem`
--

CREATE TABLE `first_sem` (
  `firstsem_id` int(11) NOT NULL,
  `grade_id` int(11) NOT NULL,
  `subject_code` varchar(30) DEFAULT NULL,
  `subject_name` varchar(100) DEFAULT NULL,
  `units` int(11) DEFAULT NULL,
  `grade` decimal(3,2) DEFAULT NULL,
  `remarks` varchar(30) DEFAULT NULL,
  `section` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `online_payment`
--

CREATE TABLE `online_payment` (
  `online_payment_id` int(11) NOT NULL,
  `student_id` int(11) NOT NULL,
  `cashier_id` int(11) DEFAULT NULL,
  `transaction_ref` varchar(50) NOT NULL,
  `amount` varchar(50) NOT NULL,
  `payment_method` varchar(50) NOT NULL,
  `payment_date` datetime DEFAULT current_timestamp(),
  `payment_status` enum('Pending','Approved') DEFAULT 'Pending',
  `remarks` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `payments`
--

CREATE TABLE `payments` (
  `payment_id` int(11) NOT NULL,
  `student_id` int(11) NOT NULL,
  `official_receipt` varchar(20) DEFAULT NULL,
  `amount` decimal(10,2) DEFAULT NULL,
  `date_of_payment` date DEFAULT NULL,
  `payment_method` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `professors_gradingsys`
--

CREATE TABLE `professors_gradingsys` (
  `grade_id` int(11) NOT NULL,
  `firstsem_id` int(11) DEFAULT NULL,
  `secondsem_id` int(11) NOT NULL,
  `yr_lvl` int(1) DEFAULT NULL,
  `RawScore` int(11) DEFAULT NULL CHECK (`RawScore` between 0 and 100),
  `Equivalent_Grade` decimal(3,2) DEFAULT NULL,
  `Remarks` varchar(20) DEFAULT NULL,
  `Semester` varchar(20) DEFAULT NULL,
  `SchoolYear` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `professors_gradingsys`
--

INSERT INTO `professors_gradingsys` (`grade_id`, `firstsem_id`, `secondsem_id`, `yr_lvl`, `RawScore`, `Equivalent_Grade`, `Remarks`, `Semester`, `SchoolYear`) VALUES
(1, 1, 0, 3, 94, 1.25, 'PASSED', '1st Semester', '2025-2026'),
(2, 2, 0, 2, 74, 5.00, 'FAILED', '2nd Semester', '2025-2026');

--
-- Triggers `professors_gradingsys`
--
DELIMITER $$
CREATE TRIGGER `trg_round_grade_before_insert` BEFORE INSERT ON `professors_gradingsys` FOR EACH ROW BEGIN
	IF NEW.RawScore >=97 THEN
    	SET NEW.Equivalent_Grade = 1.00;
    ELSEIF NEW.RawScore >=94 THEN
    	SET NEW.Equivalent_Grade = 1.25;
    ELSEIF NEW.RawScore >=91 THEN
    	SET NEW.Equivalent_Grade = 1.50;
    ELSEIF NEW.RawScore >=88 THEN
    	SET NEW.Equivalent_Grade = 1.75;
    ELSEIF NEW.RawScore >=85 THEN
    	SET NEW.Equivalent_Grade = 2.00;
    ELSEIF NEW.RawScore >=82 THEN
    	SET NEW.Equivalent_Grade = 2.25;
    ELSEIF NEW.RawScore >=79 THEN
    	SET NEW.Equivalent_Grade = 2.50;
    ELSEIF NEW.RawScore >=76 THEN
    	SET NEW.Equivalent_Grade = 2.75;
    ELSEIF NEW.RawScore >=75 THEN
    	SET NEW.Equivalent_Grade = 3.00;
    ELSE
    	SET NEW.Equivalent_Grade = 5.00;
    END IF;
    
    IF NEW.Equivalent_Grade <= 3.00 THEN
        SET NEW.Remarks = 'PASSED';
    ELSE
    	SET NEW.Remarks = 'FAILED';
    END IF;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `prof_attendances`
--

CREATE TABLE `prof_attendances` (
  `id` int(11) NOT NULL,
  `prof_id` int(11) DEFAULT NULL,
  `time_in` varchar(11) DEFAULT NULL,
  `time_out` varchar(11) DEFAULT NULL,
  `date` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Triggers `prof_attendances`
--
DELIMITER $$
CREATE TRIGGER `set_time_out` BEFORE UPDATE ON `prof_attendances` FOR EACH ROW BEGIN
    IF OLD.time_out IS NULL THEN
        SET NEW.time_out = DATE_FORMAT(CURRENT_TIME, '%h:%i:%s %p');
    ELSE
        SET NEW.time_out = OLD.time_out;
    END IF;
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `time_in` BEFORE INSERT ON `prof_attendances` FOR EACH ROW BEGIN
    SET NEW.time_in = DATE_FORMAT(CURRENT_TIME, '%h:%i:%s %p');
    SET NEW.date = CURDATE(); 
    SET NEW.time_out = NULL;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `prof_prfl`
--

CREATE TABLE `prof_prfl` (
  `account_id` int(11) NOT NULL,
  `professor_id` int(11) NOT NULL,
  `first_name` varchar(50) NOT NULL,
  `middle_name` varchar(50) NOT NULL,
  `last_name` varchar(50) NOT NULL,
  `age` int(2) DEFAULT NULL,
  `gender` varchar(20) DEFAULT NULL,
  `birthday` varchar(50) DEFAULT NULL,
  `address` varchar(100) DEFAULT NULL,
  `contact_num` int(11) DEFAULT NULL,
  `subject` varchar(50) DEFAULT NULL,
  `status` varchar(20) DEFAULT 'Active'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `prof_student`
--

CREATE TABLE `prof_student` (
  `id` int(11) NOT NULL,
  `account_id` int(11) NOT NULL,
  `student_id` int(11) NOT NULL,
  `subject_name` varchar(50) NOT NULL,
  `subject_code` varchar(50) DEFAULT NULL,
  `semester` varchar(50) DEFAULT NULL,
  `school_year` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `second_sem`
--

CREATE TABLE `second_sem` (
  `secondsem_id` int(11) NOT NULL,
  `grade_id` int(11) NOT NULL,
  `subject_code` varchar(30) DEFAULT NULL,
  `subject_name` varchar(100) DEFAULT NULL,
  `units` int(11) DEFAULT NULL,
  `grade` decimal(3,2) DEFAULT NULL,
  `remarks` varchar(30) DEFAULT NULL,
  `section` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `stud_prfl`
--

CREATE TABLE `stud_prfl` (
  `account_id` int(11) DEFAULT NULL,
  `id` int(11) NOT NULL,
  `firstname` varchar(50) NOT NULL,
  `middlename` varchar(20) NOT NULL,
  `lastname` varchar(50) NOT NULL,
  `age` int(2) DEFAULT NULL,
  `gender` varchar(10) DEFAULT NULL,
  `address` varchar(100) DEFAULT NULL,
  `contact` varchar(11) DEFAULT NULL,
  `course` varchar(50) DEFAULT NULL,
  `acc_status` varchar(20) DEFAULT 'Active',
  `username` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `stud_prfl`
--

INSERT INTO `stud_prfl` (`account_id`, `id`, `firstname`, `middlename`, `lastname`, `age`, `gender`, `address`, `contact`, `course`, `acc_status`, `username`) VALUES
(NULL, 20255, 'lei', 'd', 'librora', 20, NULL, NULL, '2147483647', NULL, 'Active', ''),
(NULL, 20256, 'dave', 'd', 'abriol', 20, NULL, 'canada', '09223112', 'BSIT', 'ON', 'dave');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `account`
--
ALTER TABLE `account`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `admin_users`
--
ALTER TABLE `admin_users`
  ADD PRIMARY KEY (`admin_id`);

--
-- Indexes for table `cashier_pfrl`
--
ALTER TABLE `cashier_pfrl`
  ADD PRIMARY KEY (`cashier_id`);

--
-- Indexes for table `first_sem`
--
ALTER TABLE `first_sem`
  ADD PRIMARY KEY (`firstsem_id`),
  ADD KEY `fk_fsem_grade` (`grade_id`);

--
-- Indexes for table `online_payment`
--
ALTER TABLE `online_payment`
  ADD PRIMARY KEY (`online_payment_id`),
  ADD KEY `student_id` (`student_id`),
  ADD KEY `fk_olpayment` (`cashier_id`);

--
-- Indexes for table `payments`
--
ALTER TABLE `payments`
  ADD PRIMARY KEY (`student_id`),
  ADD UNIQUE KEY `official_receipt` (`official_receipt`),
  ADD UNIQUE KEY `official_receipt_2` (`official_receipt`),
  ADD KEY `std_no` (`student_id`);

--
-- Indexes for table `professors_gradingsys`
--
ALTER TABLE `professors_gradingsys`
  ADD PRIMARY KEY (`grade_id`),
  ADD KEY `fk_student` (`firstsem_id`);

--
-- Indexes for table `prof_attendances`
--
ALTER TABLE `prof_attendances`
  ADD PRIMARY KEY (`id`),
  ADD KEY `prof_id` (`prof_id`);

--
-- Indexes for table `prof_prfl`
--
ALTER TABLE `prof_prfl`
  ADD PRIMARY KEY (`account_id`);

--
-- Indexes for table `prof_student`
--
ALTER TABLE `prof_student`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_stud_acc_stud` (`student_id`),
  ADD KEY `fk_prof_acc_prof` (`account_id`);

--
-- Indexes for table `second_sem`
--
ALTER TABLE `second_sem`
  ADD PRIMARY KEY (`secondsem_id`),
  ADD KEY `fk_ssem_grade` (`grade_id`);

--
-- Indexes for table `stud_prfl`
--
ALTER TABLE `stud_prfl`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_stud_acc` (`account_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `account`
--
ALTER TABLE `account`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2025112;

--
-- AUTO_INCREMENT for table `admin_users`
--
ALTER TABLE `admin_users`
  MODIFY `admin_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `cashier_pfrl`
--
ALTER TABLE `cashier_pfrl`
  MODIFY `cashier_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `first_sem`
--
ALTER TABLE `first_sem`
  MODIFY `firstsem_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `online_payment`
--
ALTER TABLE `online_payment`
  MODIFY `online_payment_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `professors_gradingsys`
--
ALTER TABLE `professors_gradingsys`
  MODIFY `grade_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `prof_attendances`
--
ALTER TABLE `prof_attendances`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT for table `prof_prfl`
--
ALTER TABLE `prof_prfl`
  MODIFY `account_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `prof_student`
--
ALTER TABLE `prof_student`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `second_sem`
--
ALTER TABLE `second_sem`
  MODIFY `secondsem_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `cashier_pfrl`
--
ALTER TABLE `cashier_pfrl`
  ADD CONSTRAINT `fk_cashier_acc` FOREIGN KEY (`cashier_id`) REFERENCES `account` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `first_sem`
--
ALTER TABLE `first_sem`
  ADD CONSTRAINT `fk_fsem_grade` FOREIGN KEY (`grade_id`) REFERENCES `professors_gradingsys` (`grade_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `online_payment`
--
ALTER TABLE `online_payment`
  ADD CONSTRAINT `fk_olpayment` FOREIGN KEY (`cashier_id`) REFERENCES `cashier_pfrl` (`cashier_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `payments`
--
ALTER TABLE `payments`
  ADD CONSTRAINT `fk_studpayments` FOREIGN KEY (`student_id`) REFERENCES `stud_prfl` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `prof_prfl`
--
ALTER TABLE `prof_prfl`
  ADD CONSTRAINT `fk_prof_acc` FOREIGN KEY (`account_id`) REFERENCES `account` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `prof_student`
--
ALTER TABLE `prof_student`
  ADD CONSTRAINT `fk_prof_acc_prof` FOREIGN KEY (`account_id`) REFERENCES `prof_prfl` (`account_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_stud_acc_stud` FOREIGN KEY (`student_id`) REFERENCES `stud_prfl` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `second_sem`
--
ALTER TABLE `second_sem`
  ADD CONSTRAINT `fk_ssem_grade` FOREIGN KEY (`grade_id`) REFERENCES `professors_gradingsys` (`grade_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `stud_prfl`
--
ALTER TABLE `stud_prfl`
  ADD CONSTRAINT `fk_stud_acc` FOREIGN KEY (`account_id`) REFERENCES `account` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
