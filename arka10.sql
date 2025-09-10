-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 06 Oca 2025, 12:00:59
-- Sunucu sürümü: 10.4.32-MariaDB
-- PHP Sürümü: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `arka10`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `masalar`
--

CREATE TABLE `masalar` (
  `masakategori` varchar(50) DEFAULT NULL,
  `masaid` varchar(50) DEFAULT NULL,
  `masaozet` varchar(250) DEFAULT NULL,
  `rezerve_time` int(11) DEFAULT NULL,
  `rezerve_end_time` int(11) DEFAULT NULL,
  `masadurum` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `masalar`
--

INSERT INTO `masalar` (`masakategori`, `masaid`, `masaozet`, `rezerve_time`, `rezerve_end_time`, `masadurum`) VALUES
('salon', 's1', '{\"siparisler\":{\"cay\":1},\"toplamTutar\":25}', NULL, NULL, 'bos'),
('salon', 's2', '{}', 1736157929, 1736160629, 'bos'),
('salon', 's3', '{\"siparisler\":{\"cay\":1},\"toplamTutar\":25}', NULL, NULL, 'bos'),
('salon', 's4', '{\"siparisler\":{\"cay\":1},\"toplamTutar\":25}', NULL, NULL, 'bos'),
('bahce', 'b1', '{\"siparisler\":{\"cay\":2},\"toplamTutar\":50}', NULL, NULL, NULL),
('bahce', 'b2', '{}', NULL, NULL, 'bos'),
('bahce', 'b3', '{}', NULL, NULL, 'bos'),
('bahce', 'b4', '{}', NULL, NULL, 'bos'),
('bahce', 'b5', '{}', NULL, NULL, 'bos'),
('teras', 't1', '{}', NULL, NULL, NULL),
('teras', 't2', '{}', NULL, NULL, NULL),
('teras', 't3', '{\"siparisler\":{\"cay\":2},\"toplamTutar\":50}', NULL, NULL, NULL),
('teras', 't4', '{}', NULL, NULL, NULL),
('teras', 't5', '{}', NULL, NULL, 'bos'),
('teras', 't6', '{\"siparisler\":{\"turkkahvesi\":3,\"cay\":1},\"toplamTutar\":265}', NULL, NULL, NULL),
('salon', 's5', '{}', NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `personeller`
--

CREATE TABLE `personeller` (
  `id` int(11) NOT NULL,
  `ad` text DEFAULT NULL,
  `soyad` text DEFAULT NULL,
  `dtarihi` text DEFAULT NULL,
  `adres` text DEFAULT NULL,
  `telefon` text DEFAULT NULL,
  `notlar` text DEFAULT '',
  `pozisyon` varchar(50) DEFAULT 'Garson'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `personeller`
--

INSERT INTO `personeller` (`id`, `ad`, `soyad`, `dtarihi`, `adres`, `telefon`, `notlar`, `pozisyon`) VALUES
(1, 'Yağız Kaan', 'Çoban', '0000-00-00', 'Yalova KYK', '05010830848', '', 'Garson'),
(2, 'Anıl Mert', 'Karaman', '0000-00-00', 'Merkez Yalova', '05555555555', '', ''),
(3, 'Ahmet Melih', 'Gürpınar', '0000-00-00', 'Merkez Yalova', '000000000000', '', '2'),
(4, 'Berkant', 'Kekeç', '0000-00-00', 'Merkez Yalova', '00000000000', '', ''),
(5, 'Ömer Faruk', 'Böğrek', '0000-00-00', 'Merkez Yalova', '05555555555', '', 'Şef'),
(6, 'Selin', 'Dursun', '0000-00-00', 'Merkez Yalova', '05555555555', '', 'Şef'),
(7, 'Mehmet', 'Yıldız', '0000-00-00', 'Merkez Yalova', '05555555555', '', 'Şef'),
(8, 'Hamza', 'Akman', '0000-00-00', 'Merkez Yalova', '05555555555', '', 'Şef'),
(9, 'Azra Betül', 'Bilici', '0000-00-00', 'Merkez Yalova', '05555555555', '', 'Şef'),
(10, 'Nebi', 'SEYYAR', '0000-00-00', 'Merkez Yalova', '05555555555', '', '61');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `siparisler_log`
--

CREATE TABLE `siparisler_log` (
  `siparis_id` varchar(50) DEFAULT NULL,
  `icerik` longtext DEFAULT NULL,
  `kapanis_tarihi` timestamp NULL DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `siparisler_log`
--

INSERT INTO `siparisler_log` (`siparis_id`, `icerik`, `kapanis_tarihi`) VALUES
('9c39c48c-836e-4682-a967-f33b1ae9664e', '{\"siparisler\":{\"urunid\":1},\"toplamTutar\":42342}', '2025-01-06 03:01:12'),
('3cb9a90c-7da2-4cef-88e0-85627e32d59a', '{\"siparisler\":{\"kola\":1},\"toplamTutar\":50}', '2025-01-06 03:45:22'),
('d14bf3d0-f6ba-4be7-ba33-1f4d8ab220d8', '{\"siparisler\":{\"cay\":3},\"toplamTutar\":75}', '2025-01-06 04:00:21'),
('703ca19d-451d-4e5f-b430-2bdfcc5992cd', '{\"siparisler\":{\"kola\":1,\"cay\":1,\"sicakcikolata\":1},\"toplamTutar\":155}', '2025-01-06 04:08:51'),
('b39918ed-b8ad-4db3-bbc8-8e4612543058', '{}', '2025-01-06 04:15:59'),
('3e98da68-0ae1-4cbb-9e62-4bbb749bd9fa', '{\"siparisler\":{\"cay\":1,\"kola\":1},\"toplamTutar\":67.5}', '2025-01-06 05:29:40'),
('266b062e-271d-4913-85d7-fcb6541303d8', '{\"siparisler\":{\"kola\":2},\"toplamTutar\":100}', '2025-01-06 08:01:14'),
('3b594bc5-3a16-4641-b344-8fa3cd3142dd', '{\"siparisler\":{},\"toplamTutar\":-3.625}', '2025-01-06 08:01:28'),
('d2132117-1e2e-4a4d-b2d1-2dc54385d991', '{\"siparisler\":{},\"toplamTutar\":0}', '2025-01-06 08:03:09'),
('91bcb466-297b-48fd-8722-e288a6e26cac', '{\"siparisler\":{\"cay\":1},\"toplamTutar\":30}', '2025-01-06 08:03:34'),
('88cd380f-3342-461c-b442-6da9b8f3e0ee', '{\"siparisler\":{},\"toplamTutar\":0}', '2025-01-06 08:34:38'),
('606d1758-9760-4f02-a4c8-9517fdbcd97f', '{\"siparisler\":{\"cay\":3},\"toplamTutar\":90}', '2025-01-06 08:45:37'),
('df007419-0496-47f7-887e-7a9c03d7f7a1', '{\"siparisler\":{\"cay\":1,\"kola\":14},\"toplamTutar\":725}', '2025-01-06 09:04:21'),
('9307b6ce-b067-4aa2-a608-7db32a40fa60', '{\"siparisler\":{\"kola\":6},\"toplamTutar\":300}', '2025-01-06 09:06:38'),
('f35bc757-3d13-4d29-9828-a387c7f99764', '{\"siparisler\":{\"kola\":3},\"toplamTutar\":0}', '2025-01-06 09:07:42'),
('5eaa9635-75e0-406d-b579-e5e9d74fba80', '{\"siparisler\":{\"cay\":1},\"toplamTutar\":25}', '2025-01-06 09:09:29'),
('407728ea-9ee8-4e46-a094-bfb64c3a75ab', '{\"siparisler\":{\"cay\":1},\"toplamTutar\":25}', '2025-01-06 09:09:45'),
('13566e9a-c692-42e8-87bd-7f1d3b3dd1a2', '{\"siparisler\":{\"kola\":1,\"cay\":1},\"toplamTutar\":75}', '2025-01-06 09:22:33'),
('95b0d27a-a97d-42a0-be84-1cd6a0713ec7', '{\"siparisler\":{\"cay\":1},\"toplamTutar\":25}', '2025-01-06 09:29:11'),
('6eb576d3-b665-4b3a-b843-89e376627532', '{\"siparisler\":{\"cay\":2},\"toplamTutar\":50}', '2025-01-06 09:37:56'),
('82e4ac67-f3c9-4264-84ec-5c8cde94819a', '{\"siparisler\":{\"kola\":1},\"toplamTutar\":50}', '2025-01-06 09:42:15'),
('c8a2cab3-43c6-4998-a6da-ab9a754ec0f9', '{\"siparisler\":{\"cay\":1},\"toplamTutar\":25}', '2025-01-06 09:45:51'),
('4657b425-bdab-4c46-9cf3-23f6effb2d6b', '{\"siparisler\":{\"cay\":1,\"cheesecake\":3},\"toplamTutar\":243.75}', '2025-01-06 10:01:19'),
('624a31d8-d30c-49d8-bd09-3559348d33cc', '{\"siparisler\":{\"cay\":1,\"kola\":1},\"toplamTutar\":67.5}', '2025-01-06 10:05:19'),
('f85c9c24-1532-43de-b397-c458793e91df', '{\"siparisler\":{\"cay\":1},\"toplamTutar\":25}', '2025-01-06 10:07:55'),
('bed8c506-3ad8-458f-87e3-00df6460a090', '{\"siparisler\":{\"cay\":1},\"toplamTutar\":25}', '2025-01-06 10:08:51'),
('958ec555-9f6b-43e1-ba3d-793d735b4178', '{\"siparisler\":{\"cay\":1},\"toplamTutar\":25}', '2025-01-06 10:11:05'),
('6b14fc3b-1360-4639-bbe0-07c5c63019ff', '{\"siparisler\":{\"cay\":1},\"toplamTutar\":30}', '2025-01-06 10:20:21'),
('26f18bef-3c65-4e85-b8f7-a554c919e6c2', '{\"siparisler\":{\"kola\":1},\"toplamTutar\":50}', '2025-01-06 10:21:15'),
('c2766324-012c-4565-90d3-d03a70d5093b', '{\"siparisler\":{\"kola\":1},\"toplamTutar\":50}', '2025-01-06 10:21:31'),
('bec1c049-58cd-45b8-98c9-4a1a08f8b8d2', '{\"siparisler\":{\"cay\":2},\"toplamTutar\":45.0}', '2025-01-06 10:23:30'),
('143efc0a-0d8d-4b7c-b706-31df4e89bdb4', '{\"siparisler\":{\"cay\":1},\"toplamTutar\":25}', '2025-01-06 10:28:27'),
('6e6e40b6-4cc2-4339-a960-552033606638', '{\"siparisler\":{\"kola\":1},\"toplamTutar\":50}', '2025-01-06 10:28:32'),
('b00eea45-ffce-439e-bdf2-00fed41bd004', '{\"siparisler\":{\"cay\":2},\"toplamTutar\":50}', '2025-01-06 10:28:45'),
('26cbbaee-4ec8-4ebb-bfa6-056ff8e40767', '{\"siparisler\":{\"cay\":1},\"toplamTutar\":25}', '2025-01-06 10:30:56'),
('14cf227a-262f-4320-844a-8e8c861f7539', '{\"siparisler\":{\"cay\":1},\"toplamTutar\":25}', '2025-01-06 10:31:17'),
('e640954a-d43c-43a7-870e-069938f594ef', '{\"siparisler\":{\"cay\":1},\"toplamTutar\":25}', '2025-01-06 10:31:50'),
('c28e47be-abde-4105-8a49-8fff8fb3e0d2', '{\"siparisler\":{\"gazoz\":1},\"toplamTutar\":45.0}', '2025-01-06 10:37:08');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `test`
--

CREATE TABLE `test` (
  `var1` varchar(255) DEFAULT NULL,
  `info` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `test`
--

INSERT INTO `test` (`var1`, `info`) VALUES
('a', 'test'),
('a', 'test');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `urunler`
--

CREATE TABLE `urunler` (
  `kategori` varchar(255) DEFAULT NULL,
  `urunid` varchar(50) DEFAULT NULL,
  `urunadi` varchar(255) DEFAULT NULL,
  `fiyat` int(11) DEFAULT NULL,
  `urunimage` varchar(255) DEFAULT NULL,
  `stok` int(11) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `urunler`
--

INSERT INTO `urunler` (`kategori`, `urunid`, `urunadi`, `fiyat`, `urunimage`, `stok`) VALUES
('icecekler', 'cay', 'Çay', 25, '\\cay.png', 7),
('icecekler', 'kola', 'Coca Cola', 50, '\\kola.png', 22),
('icecekler', 'gazoz', 'Sprite ', 50, '\\gazoz.png', 6),
('icecekler', 'turkkahvesi', 'Türk Kahvesi', 80, '\\turkkahvesi.png', 0),
('icecekler', 'filtrekahve', 'Filtre Kahve', 80, '\\filtrekahve.png', 10),
('icecekler', 'soda', 'Soda', 40, '\\soda.png', 0),
('icecekler', 'fanta', 'Fanta', 50, '\\fanta.png', 0),
('icecekler', 'sicakcikolata', 'Sıcak Çikolata', 80, '\\sicakcikolata.png', 6),
('yiyecekler', 'tost', 'Tost', 60, '\\tost.png', 0),
('yiyecekler', 'patatesekmek', 'Patates Ekmek', 75, '\\patatesekmek.png', 0),
('yiyecekler', 'gozleme', 'Gözleme', 80, '\\gozleme.png', 0),
('tatlilar', 'sufle', 'Sufle', 100, '\\sufle.png', 0),
('tatlilar', 'magnolia', 'Magnolia', 120, '\\magnolia.png', 0),
('tatlilar', 'cheesecake', 'Cheesecake', 100, '\\cheesecake.png', 5);

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `personeller`
--
ALTER TABLE `personeller`
  ADD PRIMARY KEY (`id`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `personeller`
--
ALTER TABLE `personeller`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
