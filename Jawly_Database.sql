create database if not exists db_jawly;
use db_jawly;

DROP TABLE IF EXISTS `LIST_AKUN`;
DROP TABLE IF EXISTS `ALAMAT_USER`;
DROP TABLE IF EXISTS `TRANSAKSI`;
DROP TABLE IF EXISTS `LIST_KOTA`;
DROP TABLE IF EXISTS `BIAYA_ONGKIR`;
DROP TABLE IF EXISTS `STATUS_BARANG`;
DROP TABLE IF EXISTS `VOUCHER_DISKON`;

-- AKUN USER BUAT LOGIN, NYIMPEN ALAMAT, HISTORY
CREATE TABLE LIST_AKUN (
    nama_username varchar(30) not null primary key,
    nama_panggilan varchar(30) not null,
    notelp_user varchar(15) not null,
    password_user varchar(100) not null
);

-- TABEL ALAMAT KALAU FIELD USERNAME KOSONG BERARTI BUKAN SAVED ADDRESS, TTP DISIMPAN KARENA UNTUK KEBUTUHAN HISTORY
create table ALAMAT_USER(
	id_alamat varchar(5) not null primary key,
    nama_pemilik varchar(30) not null, 
    nama_usern varchar(30) references LIST_AKUN(nama_username),
    notelp_pemilik varchar(15) not null,
    prov_alamat varchar(50) not null references LIST_KOTA(provinsi),
    kota_alamat varchar(50) not null references LIST_KOTA(nama_kota),
    kec_alamat varchar(50) not null,
    kodepos_alamat varchar(5) not null,
    alamat_lengkap varchar(100) not null,
    status_del1 varchar(1) not null
);

-- TABEL TRANSAKSI SESUAI USERNAME UNTUK MENAMPILKAN HISTORY 
create table TRANSAKSI (
	nomor_resi varchar(11) not null primary key,
    nama_username2 varchar(30) not null references LIST_AKUN(nama_username),
    tanggal_transaksi date not null,
	id_alamat_asal varchar(50) not null references ALAMAT_USER(id_alamat),
    id_alamat_tujuan varchar(50) not null references ALAMAT_USER(id_alamat),
    jenis_barang varchar(20) not null,
    berat_barang int not null,	
    volume_barang int not null, -- cm2
	jenis_layanan varchar(3) not null,
    status_pengiriman varchar(2) not null references STATUS_BARANG(id_status), 
    tanggal_pickup date not null,
    jam_pickup varchar(4) not null,
    id_vouchers varchar(4) references VOUCHER_DISKON(id_voucher),
    ongkos_kirim int not null,
    notes_utk_kurir varchar(100),
    status_del5 varchar(1) not null
); 
SELECT * FROM TRANSAKSI;
-- TABEL KOTA UNTUK KEPENTINGAN PENGECEKAN ONGKIR
create table LIST_KOTA (
	id_kota varchar(5) not null primary key,
    kode_gateway varchar(3) not null, 
    nama_kota varchar(50) not null,
    provinsi varchar(50) not null
); 

-- BIAYA ONGKIR BERDASARKAN PROVINSI ASAL DAN TUJUAN
-- JUGA SESUAI JENIS PENGIRIMAN (JAW DAN WLY)
create table BIAYA_ONGKIR (
	id_biaya varchar(5) primary key not null,
    prov_asal varchar(50) not null references LIST_KOTA(provinsi),
    prov_tujuan varchar(50) not null references LIST_KOTA(provinsi),
    jenis_layanan varchar(3) not null,
    harga int not null,
    status_del4 varchar(1) not null
); 

-- INI TABEL TAMBAHAN UNTUK MEMPERMUDAH CODINGAN
create table STATUS_BARANG (
	id_status varchar(2) not null primary key,
    keterangan varchar(100) not null
);
/*
list of status pengiriman :
- Package has been picked up by courier
- Package has been sent to 'Kota Tujuan'
- Package has arrived at sorting location of 'Kota Tujuan'
- Package is being delivered to the destination address
- Package successfully delivered to 'Nama Penerima'
*/

-- VOUCHER UNTUK PEMOTONGAN ONGKIR SESUAI BERAPA PERSEN & MAKSIMAL DISKON
create table VOUCHER_DISKON (
	id_voucher varchar(5) not null primary key ,
	kode_voucher varchar(30) not null,
	persen_pot int not null,
    maksimal_pot int not null,
	start_date date not null,
	end_date date not null,
	status_del6 varchar(1) not null
);




INSERT INTO LIST_AKUN
VALUES ('tokobahagia','Joko Wido', '082637493638', 'b39b0d57185d71f9717d59a04b4eae5b'), -- pass: apaajalah5
('onpoint.ofc','Bungeoppang', '089765467899', '7350dd27f7c1aabadd7e95e101385a2c'), -- pass: onpointkitasemua
('cemilan_enak','Andy Susanto', '082237185561', '399b3226f7bd02d9cba8c2ad751b75b3'), -- pass: cemilenak1
('semuakitajual','Si Paling Jual', '0895335872761', 'b9edbb4295de598c2737e8ce1b1d200b'), -- pass: yaya1010
('shop.atvelvet','Shop At Velvet', '087567896435', '47217a95d2eed1629cf7c9eab625b1f0'), -- pass: shopii99
('basrengpedas','Supriyadi', '087654677865', 'b73aa4c9ba92f23ad2b81aa5c07bcd3b'), -- pass: basrengpedasbp
('sendalbagus','Bambang', '087483926710', 'b583ac02165d9cd9ed3323c12c008b96'), -- pass: sendalkita55
('tehpucuk','Luna Kim', '089935865763', '57502b7f697f08c4eddc3b9ba230a626'), -- pass: pucukteh88
('ayopergi43','Alexandrah', '08764575635', 'd5bbfe6be72444c4d82664d284b5ab59'), -- pass: pergiajagas
('laptopmurah','Purnama S', '089547755443', '8385ae996bc33e94c5d4c77b1c95e3c3'), -- pass: laptoplaptop
('miegoreng01','Mi Goyeng', '086537674527', '09ac366a1998f6fd0c21beac66a24dab'), -- pass: gorengmiemie
('bt21_star','Taehyung', '089324527632', '841e6838c791b408d7c8cb26cfebd568'), -- pass: taetae0931
('jualcupmurah','Sandy', '0817293672428', '6542c315234dcac72a12e53b29ac6a4e'), -- pass: cupmurahmurah
('esbatuanticair','Jaemin', '0824283683528', 'fe8b6b6ec121a1bd7c8e053a2acb6be9'), -- pass: esbatuanticair2
('sepatu.id','Sepatu dot ID', '081343921639', 'c2bb498f156e564807fdbb0be0c20cda'), -- pass: sepatuidid
('cipungkiyowo', 'Cipung', '081233447555', 'd79230f2703c97b440a19475e0a6fb3b'), -- pass: snsd10298
('ayam_goreng7', 'Jenih Blekping', '082737726279', '55e8b3fa2bab266d971ef11d5fb9055d'), -- pass: ayam192882
('innerchildz', 'Jessica Cantik', '0895335872261', '9c34f902a9478ca8aea7423205ab96d7'), -- pass: njmborahae11
('elicegemoi','Kezia Elice', '084938279059', '15cbeb9778121ab1c87fc300c856a8f0'), -- pass: elicesemangat
('devinamochi','Devina', '083567411896', '6b592a4dc2879b1a0f7ad9808147c3f8'), -- pass: devina00mochi
('winnclothingme','Winnie', '082237849118', 'e4ff9d9a9555ef84d286985f37cb1fa7y'), -- pass: winwin100
('hahsteivan', 'Steivan', '081224373763', 'qwerty123'), -- pass: qwerty123 3fc0a7acf087f549ac2b266baf94b8b1
('valentasik','Valent', '086769086578', '1f316e9cfd45883acaa313a76b9e4a7e'), -- pass: hangatbangets
('steiv', 'Steivanhhh', '987346', 'aaaaaaaa')
;

SELECT * FROM VOUCHER_DISKON;
SELECT * FROM TRANSAKSI;
SELECT * FROM LIST_AKUN;
INSERT INTO ALAMAT_USER
VALUES 
-- UNSAVED ADDRESS
('JE001', 'Jessica T', '', '0895335872261', 'Jawa Timur', 'Surabaya', 'Sambikerep', '60982', 'Waterplace Residence Tower B', 1),
('ST001', 'Steivan Henry', '', '081397731495', 'Jawa Barat', 'Bandung', 'Coblong', '40132', 'Jalan Setiabudi No. 123', '1'),
('KE001', 'Kezia Elice', '', '081234567890', 'Jawa Tengah', 'Semarang', 'Candisari', '50251', 'Jalan Pemuda No. 45B', '1'),
('VA001', 'Valent', '', '081345678901', 'Jawa Timur', 'Surabaya', 'Gubeng', '60281', 'Jalan Diponegoro No. 45', '1'),
('DE001', 'Devina', '', '089556789012', 'DKI Jakarta', 'Jakarta Selatan', 'Kebayoran Baru', '12120', 'Jalan Sudirman No. 89', '1'),
('NA001', 'Na Jaemin', '', '08137499584712', 'DKI Jakarta', 'Jakarta Pusat', 'Tanah Abang', '70375', 'Tanah Abang, Jl. K.H. Mas Mansyur No.25', 1),
('MI001', 'Miya Aja', '', '083012345678', 'Jawa Barat', 'Depok', 'Beji', '16421', 'Jalan Margonda No. L67', '1'),
('LE002', 'Lee Alex', '', '081123456780', 'Daerah Istimewa Yogyakarta', 'Yogyakarta', 'Depok', '55281', 'Jalan Malioboro No. 780', '1'),
('OL001', 'Olaf frozen', '', '081678901234', 'Jawa Timur', 'Malang', 'Kedungkandang', '65133', 'Jalan Kawi No. 212', '1'),
('LE003', 'Lea Lewis', '', '081456789023', 'Jawa Tengah', 'Semarang', 'Banyumanik', '50263', 'Jalan Gajah Mada No. 11', '1'),
('JE002', 'Jennie Blekping', '', '082567890134', 'DKI Jakarta', 'Jakarta Utara', 'Kelapa Gading', '14240', 'Jalan Boulevard Raya No. 45', '1'),
('MI002', 'Mina chan', '', '0895667829930', 'Jawa Barat', 'Bekasi', 'Bekasi Timur', '17121', 'Jalan Cut Mutia No. 26', '1'),
('NA002', 'Nana Go', '', '081890123467', 'Jawa Timur', 'Surabaya', 'Rungkut', '60296', 'Jalan Kaliwaron No. 32', '1'),
('SA001', 'Sang Heon Lee', '', '0895123456790', 'Daerah Istimewa Yogyakarta', 'Yogyakarta', 'Gondokusuman', '55224', 'Jalan Gejayan No. 40', '1'),
('FR001', 'Fransiska Wijaya', '', '081974007891', 'Jawa Timur', 'Surabaya', 'Genteng', '60272', 'Jalan Diponegoro No. 45', '1'),
('KA001', 'Kartika Lee', '', '081830567892', 'Jawa Tengah', 'Semarang', 'Semarang Tengah', '50141', 'Jalan Pandanaran No. 67', '1'),
('JI001', 'Jimmy Park', '', '081234567893', 'Jawa Timur', 'Malang', 'Blimbing', '65126', 'Jalan Soekarno-Hatta No. 89', '1'),
('RI001', 'Rina Baa', '', '081234567894', 'DKI Jakarta', 'Jakarta Selatan', 'Pancoran', '12740', 'Jalan Tebet Barat No. 21', '1'),
('ME001', 'Mega Ibrahim', '', '081234567896', 'Daerah Istimewa Yogyakarta', 'Yogyakarta', 'Mergangsan', '55151', 'Jalan Malioboro No. 56', '1'),
('JA001', 'Jati Wijaya', '', '081234777899', 'Jawa Tengah', 'Surakarta', 'Laweyan', '57133', 'Jalan Slamet Riyadi No. 12', '1'),
('DI001', 'Diana Susanto', '', '081434567900', 'Jawa Barat', 'Bandung', 'Sukajadi', '40162', 'Jalan Dago No. 45', '1'),
('KO001', 'Koko Gans', '', '081298567901', 'Jawa Tengah', 'Semarang', 'Gajahmungkur', '50232', 'Jalan Raya Tugu Muda No. 67', '1'),
('RA001', 'Raka Wijaya',  '','081234567903', 'DKI Jakarta', 'Jakarta Selatan', 'Kebayoran Baru', '12120', 'Jalan Senopati No. 21', '1'),
('ME002', 'Mega Ibrahim', '', '081234567905', 'Daerah Istimewa Yogyakarta', 'Yogyakarta', 'Gondokusuman', '55224', 'Jalan Kaliurang No. 56', '1'),

-- SAVED ADDRESS tapi nda ada dipakai transaksi!!
('WI001', 'Winnie', 'basrengpedas',  '083567890123', 'Jawa Barat', 'Bogor', 'Bogor Utara', '16111', 'Jalan Raya Tajur No. 11', '1'),
('ST003', 'Stella Purnama', 'devinamochi', '082245678912', 'Jawa Barat', 'Bandung', 'Lengkong', '40261', 'Jalan Siliwangi No. 98', '1'),
('HA002', 'Hani Cho', 'elicegemoi', '081234567898', 'Jawa Barat', 'Bogor', 'Bogor Barat', '16116', 'Jalan Pajajaran No. 90', '1'),
('MI003', 'Milla Nurulwati', 'sendalbagus', '0822012345689', 'Jawa Barat', 'Depok', 'Cimanggis', '16453', 'Jalan Raya Bogor No. 79', '1'),

-- ada dipakai di transaksi
('LU001', 'Luna Kim', 'tehpucuk', '0812345112906', 'DKI Jakarta', 'Jakarta Pusat', 'Gambir', '10110', 'Jalan Merdeka Barat No. 78', '1'),
('HA003', 'Hadi Cho', 'ayopergi43', '081245099907', 'Jawa Barat', 'Bogor', 'Bogor Timur', '16114', 'Jalan Pajajaran No. 90', '1'),
('JU001', 'Juna Wijaya', 'valentasik', '082234567908', 'Jawa Tengah', 'Surakarta', 'Jebres', '57126', 'Jalan Slamet Riyadi No. 12', '1'),

-- punya tokobahagia
('TA001', 'Tania Park', 'tokobahagia', '081234567902', 'Jawa Timur', 'Malang', 'Klojen', '65115', 'Jalan Basuki Rahmat No. 89', '1'),
('JO001', 'Joko Widodo', 'tokobahagia', '081789012345', 'Jawa Tengah', 'Surakarta', 'Banjarsari', '57133', 'Jalan Slamet Riyadi No. 3', '1'),

-- punya onpoint.ofc
('KI001', 'Kitty XO', 'onpoint.ofc', '082789012356', 'Jawa Tengah', 'Semarang', 'Gajahmungkur', '50232', 'Jalan Pahlawan No. V17', '1'),
('SA003', 'Sari Putri', 'onpoint.ofc', '081234567909', 'Jawa Tengah', 'Semarang', 'Gajahmungkur', '50233', 'Jalan Diponegoro No. 99', '1'),

-- punya winnclothingme
('LE001', 'Lee Jeno', 'winnclothingme', '081901234567', 'DKI Jakarta', 'Jakarta Barat', 'Kembangan', '11610', 'Jalan Meruya No. 569A', '1'),
('LI001', 'Liana Kim', 'winnclothingme', '081234267897', 'DKI Jakarta', 'Jakarta Pusat', 'Senen', '10410', 'Jalan Kramat Raya No. 78', '1'),

-- punya cemilan_enak
('AN001', 'Andi Susanto', 'cemilan_enak', '081234567890', 'Jawa Barat', 'Bandung', 'Coblong', '40132', 'Jalan Setiabudi No. 123', '1'),
('AB001', 'Abdul Ahmad', 'cemilan_enak', '0822890123456', 'Jawa Timur', 'Surabaya', 'Wiyung', '60227', 'Jalan Raya Menganti No. 45', '1'),

-- punya semuakitajual
('SA002', 'Sandra Kusuma', 'semuakitajual', '081234977895', 'Jawa Barat', 'Depok', 'Sawangan', '16517', 'Jalan Margonda Raya No. 34', '1'),
('HA001', 'Haiya itulah', 'semuakitajual', '083501234578', 'DKI Jakarta', 'Jakarta Selatan', 'Mampang Prapatan', '12790', 'Jalan Haji Nawi No. 66', '1'),

-- punya shop.atvelvet
('ST002', 'Steven Tan', 'shop.atvelvet', '081234567801', 'Jawa Timur', 'Surabaya', 'Tambaksari', '60175', 'Jalan Gubeng Raya No. 89', '1'),
('SU001', 'Suci Kusuma', 'shop.atvelvet', '081232567904', 'Jawa Barat', 'Depok', 'Beji', '16423', 'Jalan Margonda Raya No. 34', '1')
;

SELECT * FROM LIST_AKUN;
INSERT INTO TRANSAKSI 
VALUES 
-- NO SAVED ADDRESS
-- pake voucher
('J2305050001','laptopmurah', '2023-05-05', 'JE001', 'KA001', 'Goods', 1, 6000, 'JAW', 'S4', '2023-05-06', 1000, 'V013', 9000, 'Minta ditaruh di Lantai B1', 1), -- jatim jateng jaw // REKAYOREK potong 7rebu, 50% from 16k but max 7k
('J2305050002','miegoreng01', '2023-05-05', 'ST001','JI001', 'Documents', 1, 1000, 'JAW', 'S2', '2023-05-07', 0900,'V019', 14000 , 'Tolong titipkan di pos satpam', 1), -- jabar jatim jaw // LOVELYDAY potong 6rebu, 30% from 20k
('W2206210001','bt21_star', '2022-06-21', 'MI001','RI001', 'Goods', 3, 2500, 'WLY', 'S5', '2022-06-23', 1800,'V008', 40800, 'Diambil oleh tetangga sebelah', 1), -- jabar dkijkrta wly // WLYKEBUT potong 10.200, 20% from 51k

-- gpake voucher
('W2206210002','bt21_star', '2022-06-21', 'VA001','JI001', 'Documents', 2, 1000, 'WLY', 'S4', '2022-06-21', 1230,'', 34000, 'Mohon diantar pada sore hari', 1), -- jatim jatim wly
('J2109190001','laptopmurah', '2021-09-19', 'DE001','ME002', 'Goods', 4, 6000, 'JAW', 'S2', '2021-09-23', 1430, '', 80000, 'Tinggal di lantai 4, apartemen 407', 1), -- jakarta yogya jaw - DIYXPRESS
('W2111090001','jualcupmurah', '2021-11-09', 'MI002','DI001', 'Goods', 1, 1000, 'WLY', 'S5', '2021-11-14', 0930, '', 17000, 'Mohon tinggalkan di pos kamling', 1), -- jabar jabar wly - BAYIJAWLY50
('J2306020001','esbatuanticair', '2023-06-02', 'OL001','RA001', 'Documents', 1, 1000, 'JAW', 'S2', '2023-06-03', 1030,'', 20000, 'Dikirimkan ke alamat kantor', 1), -- jatim dki jkrta
('W2308070001','cipungkiyowo', '2023-08-07', 'JE002','JA001', 'Documents', 1, 1500, 'WLY', 'S1', '2023-08-11', 1230,'',25500, 'Titipkan kepada resepsionis', 1), -- dkijkrt jateng wly
('J2201110001','cipungkiyowo', '2022-01-11', 'MI002','FR001', 'Goods', 1, 4000, 'JAW', 'S2', '2022-01-13', 0930,'', 20000, 'Tolong masukkan ke kotak pos rumah', 1), -- jabar jatim jaw
('W2203080001','henry05', '2022-03-08', 'LE003','KO001', 'Goods', 2, 7000, 'WLY', 'S2', '2022-03-10', 1230, 'V008', 27200, 'Dikirimkan ke alamat kantor cabang', 1), -- jateng jateng wly - WLYKEBUT
('J2105040011','noel_indargo', '2021-05-04', 'SA001','RA001', 'Documents', 2, 1000, 'JAW', 'S4', '2021-05-05', 1100,'', 40000, '', 1), -- yogya jakrta jaw

-- SALAH SATU alamat ada yg SAVED ADDRESS user
('J2311290001','tehpucuk', '2023-11-29', 'LE002','LU001', 'Goods', 3, 5000, 'JAW', 'S5', '2023-11-30', 1130,'', 60000, 'Tolong titipkan ke tetanggga nomor 7', 1), -- yogya jkrt jaw
('W2303050001','ayopergi43', '2023-03-05', 'KE001','HA003', 'Goods', 3, 1000, 'WLY', 'S1', '2023-03-06', 1100, '', 102000, 'Tolong letakkan di bawah karpet', 1), -- jateng jabar wly
('W2209210001','bajuhangat55', '2022-09-21', 'NA001','JU001', 'Documents', 1, 1000, 'WLY', 'S3', '2022-09-23', 1400,'', 25500, '', 1), -- jkrta jateng wly

-- DUA"NYA asal&tujuan itu SAVED ADDRESS user
('W2210230001','tokobahagia', '2022-10-23', 'JO001','TA001', 'Goods', 2, 10000, 'WLY', 'S1', '2022-10-25', 1800,'', 54400 , 'Serahkan pada petugas keamanan kompleks', 1), -- jateng jatim wly
('J2108200001','cemilan_enak', '2021-08-20', 'AB001','AN001', 'Documents', 2, 1500, 'JAW', 'S3', '2021-08-25', 1730,'', 40000, '', 1), -- jatim jabar jaw
('J2107110001','jessclothingme', '2021-07-11', 'LE001','LI001', 'Goods', 1, 1000, 'JAW', 'S3', '2021-07-15', 1000,'', 20000, 'Tolong bawa ke toko sebelah', 1), -- yogya jakarta jaw
('W2206110001','onpoint.ofc', '2023-06-11', 'KI001','SA003', 'Goods', 1, 2000, 'WLY', 'S3', '2023-06-17', 1300,'', 17000, '', 1), -- jateng jateng wly
('W2207020001','semuakitajual', '2022-07-02', 'HA001','SA002', 'Documents', 1, 1000, 'WLY', 'S4', '2022-07-03', 1530,'', 17000, '', 1), -- jkrta jabar
('J2310300001','shop.atvelvet', '2023-10-30', 'ST002','SU001', 'Goods', 2, 2000, 'JAW', 'S4', '2023-10-31', 0900,'', 40000, 'Tolong tinggalkan di meja depan', 1) -- jatim jabar jaw
;

-- ref http://journal.unair.ac.id/download-fullpapers-17.%20SNI%207657-2010%20Singkatan%20nama%20kota.pdf
INSERT INTO LIST_KOTA
VALUES 
-- DKI Jakarta
('K01', 'KSU', 'Kepulauan Seribu', 'DKI Jakarta'),
('J01', 'TNA', 'Jakarta Pusat', 'DKI Jakarta'),
('J02', 'TJP', 'Jakarta Utara', 'DKI Jakarta'),
('J03', 'GGP', 'Jakarta Barat', 'DKI Jakarta'),
('J04', 'KYB', 'Jakarta Selatan', 'DKI Jakarta'),
('J05', 'CKG', 'Jakarta Timur', 'DKI Jakarta'),

-- Jawa Barat
('C01', 'CJR','Cianjur', 'Jawa Barat'),
('G01', 'GRT', 'Garut', 'Jawa Barat'),
('C02', 'CMS', 'Ciamis', 'Jawa Barat'),
('K02', 'KNG', 'Kuningan', 'Jawa Barat'),
('M01', 'MJL', 'Majalengka', 'Jawa Barat'),
('S01', 'SMD', 'Sumedang', 'Jawa Barat'),
('I01', 'IDM', 'Indramayu', 'Jawa Barat'),
('S02', 'SNG', 'Subang', 'Jawa Barat'),
('P01', 'PWK', 'Purwakarta', 'Jawa Barat'),
('K03', 'KWG', 'Karawang', 'Jawa Barat'),
('B01', 'BGR', 'Bogor', 'Jawa Barat'),
('S03', 'SKB', 'Sukabumi', 'Jawa Barat'),
('B02', 'BDG', 'Bandung', 'Jawa Barat'),
('C03', 'CBN', 'Cirebon', 'Jawa Barat'),
('B03', 'BKS', 'Bekasi', 'Jawa Barat'),
('D01', 'DPK', 'Depok', 'Jawa Barat'),
('C04', 'CMH', 'Cimahi', 'Jawa Barat'),
('T01', 'TSM', 'Tasikmalaya', 'Jawa Barat'),
('B04', 'BJR', 'Banjar', 'Jawa Barat'),

-- Jawa Tengah
('C06', 'CLP', 'Cilacap', 'Jawa Tengah'),
('B15', 'PWT', 'Banyumas', 'Jawa Tengah'),
('P07', 'PBG', 'Purbalingga', 'Jawa Tengah'),
('B20', 'BNR', 'Banjarnegara', 'Jawa Tengah'),
('K06', 'KBM', 'Kebumen', 'Jawa Tengah'),
('P08', 'PWR', 'Purworejo', 'Jawa Tengah'),
('W01', 'WSB', 'Wonosobo', 'Jawa Tengah'),
('M06', 'MGG', 'Magelang', 'Jawa Tengah'),
('B16', 'BYL', 'Boyolali', 'Jawa Tengah'),
('K07', 'KLN', 'Klaten', 'Jawa Tengah'),
('S11', 'SKH', 'Sukoharjo', 'Jawa Tengah'),
('W02', 'WNG', 'Wonogiri', 'Jawa Tengah'),
('K08', 'KRG', 'Karanganyar', 'Jawa Tengah'),
('S12', 'SGN', 'Sragen', 'Jawa Tengah'),
('G03', 'PWD', 'Grobongan', 'Jawa Tengah'),
('B17', 'BLA', 'Blora', 'Jawa Tengah'),
('R01', 'RBG', 'Rembang', 'Jawa Tengah'),
('P09', 'PTI', 'Pati', 'Jawa Tengah'),
('K09', 'KDS', 'Kudus', 'Jawa Tengah'),
('J08', 'JPA', 'Jepara', 'Jawa Tengah'),
('D02', 'DMK', 'Demak', 'Jawa Tengah'),
('S13', 'SMG', 'Semarang', 'Jawa Tengah'),
('T06', 'TMG', 'Temanggung', 'Jawa Tengah'),
('K10', 'KDL', 'Kendal', 'Jawa Tengah'),
('B18', 'BTG', 'Batang', 'Jawa Tengah'),
('P10', 'PKL', 'Pekalongan', 'Jawa Tengah'),
('P11', 'PML', 'Pemalang', 'Jawa Tengah'),
('T07', 'TGL', 'Tegal', 'Jawa Tengah'),
('B19', 'BBS', 'Brebes', 'Jawa Tengah'),
('S14', 'SKT', 'Surakarta', 'Jawa Tengah'),
('S15', 'SLT', 'Salatiga', 'Jawa Tengah'),

-- Daerah Istimewa Yogyakarta
('K04', 'WAT', 'Kulon Progo', 'Daerah Istimewa Yogyakarta'),
('B08', 'BTL', 'Bantul', 'Daerah Istimewa Yogyakarta'),
('G02', 'WNO', 'Gunung Kidul' , 'Daerah Istimewa Yogyakarta'),
('S05', 'SMN', 'Sleman', 'Daerah Istimewa Yogyakarta'),
('Y01', 'YYK', 'Yogyakarta' , 'Daerah Istimewa Yogyakarta'),

-- Jawa Timur
('P02', 'PCT', 'Pacitan', 'Jawa Timur'), 
('P03', 'PNG', 'Ponorogo', 'Jawa Timur'),
('T03', 'TRK', 'Trenggalek', 'Jawa Timur'),
('T04', 'TLG', 'Tulungagung', 'Jawa Timur'),
('B09', 'BLT', 'Blitar', 'Jawa Timur'),
('K05', 'KDR', 'Kediri', 'Jawa Timur'),
('M02', 'MLG', 'Malang', 'Jawa Timur'),
('L01','LMG', 'Lumajang', 'Jawa Timur'),
('J06','JMR', 'Jember', 'Jawa Timur'),
('B10','BYW', 'Banyuwangi', 'Jawa Timur'),
('B11', 'BDW', 'Bondowoso', 'Jawa Timur'),
('S06', 'SIT', 'Situbondo', 'Jawa Timur'),
('P04', 'PBL', 'Probolinggo', 'Jawa Timur'),
('P05','PSN', 'Pasuruan', 'Jawa Timur'),
('S07', 'SDA', 'Sidoarjo', 'Jawa Timur'),
('M03', 'MJK', 'Mojokerto', 'Jawa Timur'),
('J07', 'JBG', 'Jombang', 'Jawa Timur'),
('N01', 'NJK', 'Nganjuk', 'Jawa Timur'),
('M04', 'MAD', 'Madiun', 'Jawa Timur'),
('M05', 'MGT', 'Magetan', 'Jawa Timur'),
('N02', 'NGW', 'Ngawi', 'Jawa Timur'),
('B12', 'BJN', 'Bojonegoro', 'Jawa Timur'),
('T05', 'TBN', 'Tuban', 'Jawa Timur'),
('L02', 'LMG', 'Lamongan', 'Jawa Timur'),
('G04', 'GSK', 'Gresik', 'Jawa Timur'),
('B13', 'BKL', 'Bangkalan', 'Jawa Timur'),
('S08', 'SPG', 'Sampang', 'Jawa Timur'),
('P06', 'PMK', 'Pamekasan', 'Jawa Timur'),
('S09', 'SMP', 'Sumenep', 'Jawa Timur'),
('S10', 'SBY', 'Surabaya', 'Jawa Timur'),
('B14', 'BTU', 'Batu', 'Jawa Timur'),

-- Banten
('P12', 'PDG', 'Pandeglang', 'Banten'),
('R02','RKB', 'Lebak', 'Banten'),
('T08','TNG', 'Tangerang', 'Banten'),
('S16','SRG', 'Serang', 'Banten'),
('C07','CLG', 'Cilegon', 'Banten'),
('T09','CPT', 'Tangerang Selatan', 'Banten')
;


INSERT INTO BIAYA_ONGKIR
VALUES 
('B01', 'Banten', 'Banten', 'JAW', 10000, '1'),
('B02', 'Banten', 'Jawa Timur', 'JAW',20000, '1'),
('B03', 'Banten', 'Jawa Barat', 'JAW',15000, '1'),
('B04', 'Banten', 'Jawa Tengah', 'JAW', 20000,'1'),
('B05', 'Banten', 'DKI Jakarta', 'JAW', 10000, '1'),
('B06', 'Banten', 'Daerah Istimewa Yogyakarta', 'JAW', 17000,'1'),

('B07', 'Daerah Istimewa Yogyakarta', 'Jawa Tengah', 'JAW',  15000,'1'),
('B08', 'Daerah Istimewa Yogyakarta', 'DKI Jakarta','JAW', 20000, '1'),
('B09', 'Daerah Istimewa Yogyakarta', 'Daerah Istimewa Yogyakarta','JAW',  10000,'1'),

('B10', 'Jawa Timur', 'Banten', 'JAW', 20000, '1'),
('B11', 'Jawa Timur', 'Jawa Timur','JAW', 10000, '1'),
('B12', 'Jawa Timur', 'Jawa Barat','JAW', 20000, '1'),
('B13', 'Jawa Timur', 'Jawa Tengah','JAW', 16000, '1'),
('B14', 'Jawa Timur', 'DKI Jakarta','JAW', 20000, '1'),
('B15', 'Jawa Timur', 'Daerah Istimewa Yogyakarta','JAW', 15000, '1'),

('B16', 'Jawa Barat', 'Banten', 'JAW', 15000, '1'),
('B17', 'Jawa Barat', 'Jawa Timur', 'JAW', 20000,'1'),
('B18', 'Jawa Barat', 'Jawa Barat','JAW', 10000, '1'),
('B19', 'Jawa Barat', 'Jawa Tengah','JAW', 20000, '1'),
('B20', 'Jawa Barat', 'DKI Jakarta','JAW', 10000, '1'),
('B21', 'Jawa Barat', 'Daerah Istimewa Yogyakarta', 'JAW', 15000, '1'),

('B22', 'Jawa Tengah', 'Banten','JAW', 20000, '1'),
('B23', 'Jawa Tengah', 'Jawa Timur','JAW', 16000, '1'),
('B24', 'Jawa Tengah', 'Jawa Barat','JAW', 20000, '1'),
('B25', 'Jawa Tengah', 'Jawa Tengah','JAW', 10000, '1'),
('B26', 'Jawa Tengah', 'DKI Jakarta','JAW', 15000, '1'),
('B27', 'Jawa Tengah', 'Daerah Istimewa Yogyakarta', 'JAW', 15000, '1'),

('B28', 'DKI Jakarta', 'Banten','JAW', 10000, '1'),
('B29', 'DKI Jakarta', 'Jawa Timur','JAW', 20000, '1'),
('B30', 'DKI Jakarta', 'Jawa Barat','JAW', 10000, '1'),
('B31', 'DKI Jakarta', 'Jawa Tengah','JAW', 15000, '1'),
('B32', 'DKI Jakarta', 'DKI Jakarta','JAW', 10000, '1'),
('B33', 'DKI Jakarta', 'Daerah Istimewa Yogyakarta','JAW', 20000, '1'),

('B34', 'Daerah Istimewa Yogyakarta', 'Banten','JAW', 17000, '1'),
('B35', 'Daerah Istimewa Yogyakarta', 'Jawa Timur','JAW', 15000, '1'),
('B36', 'Daerah Istimewa Yogyakarta', 'Jawa Barat','JAW', 15000, '1'),

-- WLY SERVICE + 70% OF PRICE
('B37', 'Banten', 'Banten', 'WLY', 17000, '1'),
('B38', 'Banten', 'Jawa Timur', 'WLY', 34000, '1'),
('B39', 'Banten', 'Jawa Barat', 'WLY', 25500, '1'),
('B40', 'Banten', 'Jawa Tengah', 'WLY', 34000, '1'),
('B41', 'Banten', 'DKI Jakarta', 'WLY', 17000, '1'),
('B42', 'Banten', 'Daerah Istimewa Yogyakarta', 'WLY', 28900, '1'),
('B43', 'Daerah Istimewa Yogyakarta', 'Jawa Tengah', 'WLY', 25500, '1'),
('B44', 'Daerah Istimewa Yogyakarta', 'DKI Jakarta', 'WLY', 34000, '1'),
('B45', 'Daerah Istimewa Yogyakarta', 'Daerah Istimewa Yogyakarta', 'WLY', 17000, '1'),

('B46', 'Jawa Timur', 'Banten', 'WLY', 34000, '1'),
('B47', 'Jawa Timur', 'Jawa Timur','WLY', 17000, '1'),
('B48', 'Jawa Timur', 'Jawa Barat','WLY', 34000, '1'),
('B49', 'Jawa Timur', 'Jawa Tengah','WLY', 27200, '1'),
('B50', 'Jawa Timur', 'DKI Jakarta','WLY', 34000, '1'),
('B51', 'Jawa Timur', 'Daerah Istimewa Yogyakarta','WLY', 25500, '1'),

('B52', 'Jawa Barat', 'Banten', 'WLY', 25500, '1'),
('B53', 'Jawa Barat', 'Jawa Timur', 'WLY', 34000, '1'),
('B54', 'Jawa Barat', 'Jawa Barat','WLY', 17000, '1'),
('B55', 'Jawa Barat', 'Jawa Tengah','WLY', 34000, '1'),
('B56', 'Jawa Barat', 'DKI Jakarta','WLY', 17000, '1'),
('B57', 'Jawa Barat', 'Daerah Istimewa Yogyakarta', 'WLY', 25500, '1'),

('B58', 'Jawa Tengah', 'Banten','WLY', 34000, '1'),
('B59', 'Jawa Tengah', 'Jawa Timur','WLY', 27200, '1'),
('B60', 'Jawa Tengah', 'Jawa Barat','WLY', 34000, '1'),
('B61', 'Jawa Tengah', 'Jawa Tengah','WLY', 17000, '1'),
('B62', 'Jawa Tengah', 'DKI Jakarta','WLY', 25500, '1'),
('B63', 'Jawa Tengah', 'Daerah Istimewa Yogyakarta', 'WLY', 25500, '1'),

('B64', 'DKI Jakarta', 'Banten','WLY', 17000, '1'),
('B65', 'DKI Jakarta', 'Jawa Timur','WLY', 34000, '1'),
('B66', 'DKI Jakarta', 'Jawa Barat','WLY', 17000, '1'),
('B67', 'DKI Jakarta', 'Jawa Tengah','WLY', 25500, '1'),
('B68', 'DKI Jakarta', 'DKI Jakarta','WLY', 17000, '1'),
('B69', 'DKI Jakarta', 'Daerah Istimewa Yogyakarta','WLY', 34000, '1'),

('B70', 'Daerah Istimewa Yogyakarta', 'Banten','WLY', 28900, '1'),
('B71', 'Daerah Istimewa Yogyakarta', 'Jawa Timur','WLY', 25500, '1'),
('B72', 'Daerah Istimewa Yogyakarta', 'Jawa Barat','WLY', 25500, '1'),
('B73', 'Daerah Istimewa Yogyakarta', 'Jawa Tengah','WLY', 25500, '1');

INSERT INTO STATUS_BARANG 
VALUES ('S1', 'Package has been picked up by courier'),
('S2', 'Package is being sent to sorting location'),
('S3', 'Package has arrived at sorting location'),
('S4', 'Package is being delivered to the destination address'),
('S5', 'Package successfully delivered to recipient');

SELECT * FROM STATUS_BARANG WHERE id_status BETWEEN 'S1' AND 'S4';

INSERT INTO VOUCHER_DISKON
VALUES ('V001', 'GODSPEED20', 20, 5000, '2023-05-20', '2024-05-20', 1), 
('V002', 'ANTINYASAR10', 10, 15000, '2023-03-10', '2024-03-10', 1), 
('V003', 'KAPANAJABISA', 5, 10000, '2023-04-20', '2023-07-20', 1),
('V004', 'SETENGAHHARGA', 50, 15000, '2023-02-10', '2024-05-20', 1), 
('V005', 'BAYIJAWLY50', 50, 9000, '2022-01-01', '2025-12-31', 1),
('V006', 'JAWLYBDAY17', 17, 20000, '2023-05-01', '2023-07-01', 1),
('V007', 'JAWAJALAH', 20, 30000, '2021-01-01', '2024-05-20', 1), -- khusus pengiriman jenis jaw
('V008', 'WLYKEBUT', 20, 30000, '2021-01-01', '2024-05-20', 1), -- khusus pengiriman jenis wly
('V009', 'TETAPFROZEN15', 15, 5000, '2023-05-20', '2024-05-20', 1), 
('V010', 'JATIMXPRESS', 50, 8000, '2023-05-20', '2024-05-20', 1), -- khusus antar jawa timur
('V011', 'JABARXPRESS', 50, 12000, '2023-05-20', '2024-05-20', 1), -- khusus antar jawa barat
('V012', 'JATENGXPRESS', 50, 11000, '2023-05-20', '2024-05-20', 1), -- khusus antar jawa tengah
('V013', 'REKAYOREK', 50, 7000, '2023-05-01', '2024-05-20', 1), -- khusus pengiriman dari/ke surabaya
('V014', 'DIYXPRESS', 20, 5000, '2023-05-20', '2024-05-20', 1), -- khusus dari/ke Daerah istimewa yogyakarta
-- sudah lewat masa aktif
('V015', 'JAWLYNEW2023', 50, 30000, '2022-12-30', '2023-01-30', 0), -- tahun baru
('V016', 'HARIBUMISEDUNIA', 25, 6000, '2023-04-22', '2023-04-23', 0), -- hari bumi
('V017', 'SPECIALRAYA', 35, 9000, '2023-04-19', '2023-04-25', 0), -- hari raya idul fitri
('V018', 'SEMANGAT45', 45, 17170, '2022-08-16', '2022-08-18', 0), -- hari kemerdekaan
('V019', 'LOVELYDAY', 30, 14000, '2023-02-01', '2023-02-20', 0), -- valentine day
('V020', 'CNYWITHJAWLY', 20, 3000, '2023-01-20', '2023-01-25', 0); -- chinese new year

SELECT * FROM 
(SELECT t.nomor_resi, t.tanggal_transaksi, a.nama_pemilik as 'Nama Pengirim', l1.kode_gateway as 'Gateaway Asal', a2.nama_pemilik as 'Nama Penerima', l2.kode_gateway as 'Gateway Tujuan', t.jenis_layanan, t.status_pengiriman 
FROM transaksi t, list_kota l1, alamat_user a, alamat_user a2, list_kota l2 WHERE t.id_alamat_asal = a.id_alamat 
AND a.kota_alamat = l1.nama_kota AND t.id_alamat_tujuan = a2.id_alamat AND a2.kota_alamat = l2.nama_kota AND t.nama_username2 = 'ivanya' 
GROUP BY 1,2,3,4, 5,6 ORDER BY 2 ASC) as a ;

SELECT t.nomor_resi, t.tanggal_transaksi, a.nama_pemilik as 'Nama Pengirim', l1.kode_gateway as 'Gateaway Asal', a2.nama_pemilik as 'Nama Penerima', l2.kode_gateway as 'Gateway Tujuan', t.jenis_layanan, t.status_pengiriman 
FROM transaksi t, list_kota l1, alamat_user a, alamat_user a2, list_kota l2 
WHERE t.id_alamat_asal = a.id_alamat 
AND a.kota_alamat = l1.nama_kota AND t.id_alamat_tujuan = a2.id_alamat AND a2.kota_alamat = l2.nama_kota AND t.nama_username2 = 'ivanya' 
GROUP BY 1,2,3,4, 5,6 ORDER BY 2 ASC;


                