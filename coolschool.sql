-- phpMyAdmin SQL Dump
-- version 4.9.5
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Feb 26, 2021 at 05:48 AM
-- Server version: 5.7.24
-- PHP Version: 7.4.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `coolschool`
--

-- --------------------------------------------------------

--
-- Table structure for table `groups`
--

CREATE TABLE `groups` (
  `id_group` int(11) NOT NULL,
  `group_name` varchar(255) NOT NULL,
  `name_subject` varchar(255) NOT NULL,
  `status` varchar(255) NOT NULL,
  `type` varchar(255) NOT NULL,
  `id_teacher` int(11) NOT NULL,
  `capacity` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `groups`
--

INSERT INTO `groups` (`id_group`, `group_name`, `name_subject`, `status`, `type`, `id_teacher`, `capacity`) VALUES
(2, 'Питон для самых маленьких', 'Изучение Python', 'В работе', 'Восстановление', 9, 1),
(3, 'Unity школьники', 'Unity3D', 'Формирующаяся', 'Общий', 13, 6),
(4, 'Английский подготовка к экзамену', 'Компьютерная грамотность', 'В работе', 'Online', 6, 7);

-- --------------------------------------------------------

--
-- Table structure for table `groups_and_students`
--

CREATE TABLE `groups_and_students` (
  `id_student` int(11) DEFAULT NULL,
  `id_group` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `groups_and_students`
--

INSERT INTO `groups_and_students` (`id_student`, `id_group`) VALUES
(17, 3),
(20, 3),
(25, 2),
(22, 2),
(16, 3),
(22, 3),
(26, 3),
(25, 3),
(23, 3),
(21, 3),
(19, 3),
(24, 4),
(20, 4),
(18, 4),
(20, 2),
(18, 2),
(21, 2),
(17, 2);

-- --------------------------------------------------------

--
-- Table structure for table `students`
--

CREATE TABLE `students` (
  `id_student` int(11) NOT NULL,
  `name` varchar(100) NOT NULL,
  `surname` varchar(100) NOT NULL,
  `lastname` varchar(100) NOT NULL,
  `sex` varchar(11) NOT NULL,
  `bitrh_date` date NOT NULL,
  `reg_date` date NOT NULL,
  `advet_type` varchar(100) NOT NULL,
  `request_type` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `students`
--

INSERT INTO `students` (`id_student`, `name`, `surname`, `lastname`, `sex`, `bitrh_date`, `reg_date`, `advet_type`, `request_type`) VALUES
(16, 'Даниил', 'Кузнецов', 'Евгеньевич', 'Жен.', '2000-10-26', '2021-01-30', 'Рекомендация', 'Учебный лагерь'),
(17, 'Игорь', 'Тодоренко', 'Михайлович', 'Жен.', '2000-10-26', '2000-10-26', 'Insagram', 'Программирование'),
(18, 'Сергей', 'Пастернак', 'Дмитриевич', 'Жен.', '0202-10-25', '0202-12-26', 'Insagram', 'Программирование'),
(19, 'Валерий\r\n', 'Куплинов', 'Робертович', '', '2021-02-04', '2021-02-17', 'dan', 'dan'),
(20, 'Александр', 'Ходюк', 'Даниилович', 'Жен.', '2000-11-11', '2020-12-12', 'Google карты', 'Программирование'),
(21, 'Соня', 'Маркарян', 'Робертовна', 'Жен.', '2001-12-06', '2020-09-14', 'Сайт', 'Видеомонтаж'),
(22, 'Александр', 'Гуфовский', 'Алексеевич', 'Муж.', '0011-01-01', '0012-02-21', 'Google карты', 'Подготовка к экзаменам'),
(23, 'Екатерина', 'Пирожкова', 'Робертовна', 'Муж.', '2121-12-12', '2112-12-12', 'Insagram', 'Видеомонтаж'),
(24, 'Дмитрий', 'Быков', 'Евгеньевич', 'Жен.', '1111-11-11', '1111-11-11', 'Сайт', 'Программирование'),
(25, 'Георгий', 'Хадарковский', 'Петрович', 'Муж.', '2021-02-10', '2021-02-16', 'Прикол', 'Прикол'),
(26, 'Алексей', 'Прокофьев ', 'Альтаирович', 'Муж.', '2021-01-31', '2021-02-25', 'Яндекс карты', 'Компьютерная грамотность');

-- --------------------------------------------------------

--
-- Table structure for table `subjects`
--

CREATE TABLE `subjects` (
  `id_subject` int(11) NOT NULL,
  `name_subject` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `subjects`
--

INSERT INTO `subjects` (`id_subject`, `name_subject`) VALUES
(1, 'Unity3D'),
(6, 'Видеомонаж'),
(4, 'Изучение Python'),
(5, 'Компьютерная грамотность'),
(2, 'Подготовка к ЕГЭ'),
(3, 'Фотошоп');

-- --------------------------------------------------------

--
-- Table structure for table `tasks`
--

CREATE TABLE `tasks` (
  `id` int(11) UNSIGNED NOT NULL,
  `date` date NOT NULL,
  `description` varchar(300) NOT NULL,
  `responsible` varchar(100) NOT NULL,
  `orderedBy` varchar(100) NOT NULL,
  `priority` varchar(11) NOT NULL,
  `status` varchar(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tasks`
--

INSERT INTO `tasks` (`id`, `date`, `description`, `responsible`, `orderedBy`, `priority`, `status`) VALUES
(6, '2021-02-04', 'Сделать дз', 'Даниил Кузнецов', 'Антон Нижегородов', 'Низкий.', 'Закрыта'),
(7, '2021-02-12', 'Покушать', 'Ассир Айсиболт', 'name', 'Высокий.', 'Открыта'),
(8, '2021-02-07', 'Установить кронштейн', 'Даниил Кузнецов', 'name', 'Высокий.', 'Открыт'),
(9, '2021-02-01', 'Удалить доту', 'Алексей Прокофьев', 'Алексей Прокофьев', 'Высокий.', 'Открыт');

-- --------------------------------------------------------

--
-- Table structure for table `teachers`
--

CREATE TABLE `teachers` (
  `id_teacher` int(11) NOT NULL,
  `experience` int(11) DEFAULT NULL,
  `name_subject` varchar(255) DEFAULT NULL,
  `id_user` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `teachers`
--

INSERT INTO `teachers` (`id_teacher`, `experience`, `name_subject`, `id_user`) VALUES
(1, 2, 'Unity3D', 42),
(2, 1, 'Unity3D', 1),
(3, 4, 'Видеомонаж', 36),
(6, 4, 'Фотошоп', 46),
(9, 4, 'Изучение Python', 39),
(13, 4, 'Видеомонаж', 41),
(14, 3, 'Компьютерная грамотность', 45),
(16, 4, 'Видеомонаж', 47),
(20, NULL, 'Unity3D', 40),
(21, NULL, 'Фотошоп', 48),
(22, NULL, 'Компьютерная грамотность', 49);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id_user` int(11) NOT NULL,
  `login` varchar(100) NOT NULL,
  `pass` varchar(100) NOT NULL,
  `name` varchar(100) NOT NULL,
  `surname` varchar(100) NOT NULL,
  `post` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id_user`, `login`, `pass`, `name`, `surname`, `post`) VALUES
(1, 'John', '123', 'Jonh', 'Wick', 'Учитель'),
(2, 'drason', '123', 'Даниил', 'Кузнецов', 'Администратор'),
(3, 'melok', '123', 'Софи', 'Мелок', 'Администратор'),
(36, 'Igor', '123', 'Игорь', 'Верховской', 'Учитель'),
(39, 'IcyBolt', '123', 'Ассир', 'Айсиболт', 'Учитель'),
(40, 'Sash0k20!8', '123', 'Сашко', 'Ходюк', 'Директор'),
(41, 'Trigl', '123', 'Марк', 'Давывод', 'Учитель'),
(42, 'itpedia', '123', 'Алексей', 'Шевцов', 'Учитель'),
(43, 'Mobic', '123', 'Антон', 'Нижегородов', 'Администратор'),
(45, 'mike', '123', 'Майк', 'Вазовский', 'Учитель'),
(46, 'lol', '123', 'Лев', 'Лерий', 'Учитель'),
(47, 'leo', '123', 'Леонид', 'Герштраус', 'Учитель'),
(48, 'max', '123', 'Максим', 'Теплицын', 'Учитель'),
(49, 'link3000', '123', 'Алексей', 'Прокофьев', 'Учитель');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `groups`
--
ALTER TABLE `groups`
  ADD PRIMARY KEY (`id_group`),
  ADD UNIQUE KEY `id_teacher` (`id_teacher`),
  ADD KEY `name_subject` (`name_subject`);

--
-- Indexes for table `groups_and_students`
--
ALTER TABLE `groups_and_students`
  ADD KEY `id_group` (`id_group`),
  ADD KEY `id_student` (`id_student`);

--
-- Indexes for table `students`
--
ALTER TABLE `students`
  ADD PRIMARY KEY (`id_student`);

--
-- Indexes for table `subjects`
--
ALTER TABLE `subjects`
  ADD PRIMARY KEY (`id_subject`),
  ADD KEY `name_subject` (`name_subject`),
  ADD KEY `name_subject_2` (`name_subject`);

--
-- Indexes for table `tasks`
--
ALTER TABLE `tasks`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `teachers`
--
ALTER TABLE `teachers`
  ADD PRIMARY KEY (`id_teacher`),
  ADD KEY `name_subject` (`name_subject`),
  ADD KEY `id_user` (`id_user`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id_user`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `groups`
--
ALTER TABLE `groups`
  MODIFY `id_group` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `students`
--
ALTER TABLE `students`
  MODIFY `id_student` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- AUTO_INCREMENT for table `subjects`
--
ALTER TABLE `subjects`
  MODIFY `id_subject` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `tasks`
--
ALTER TABLE `tasks`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `teachers`
--
ALTER TABLE `teachers`
  MODIFY `id_teacher` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id_user` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=50;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `groups`
--
ALTER TABLE `groups`
  ADD CONSTRAINT `group_subjects` FOREIGN KEY (`name_subject`) REFERENCES `subjects` (`name_subject`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `group_teachers` FOREIGN KEY (`id_teacher`) REFERENCES `teachers` (`id_teacher`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `groups_and_students`
--
ALTER TABLE `groups_and_students`
  ADD CONSTRAINT `group_members` FOREIGN KEY (`id_group`) REFERENCES `groups` (`id_group`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `group_members1` FOREIGN KEY (`id_student`) REFERENCES `students` (`id_student`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `teachers`
--
ALTER TABLE `teachers`
  ADD CONSTRAINT `teacher_subject` FOREIGN KEY (`name_subject`) REFERENCES `subjects` (`name_subject`) ON UPDATE CASCADE,
  ADD CONSTRAINT `user_teacher` FOREIGN KEY (`id_user`) REFERENCES `users` (`id_user`) ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
