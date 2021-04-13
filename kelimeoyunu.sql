-- MySQL dump 10.13  Distrib 8.0.18, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: kelimeoyunu
-- ------------------------------------------------------
-- Server version	8.0.18

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `altihane`
--

DROP TABLE IF EXISTS `altihane`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `altihane` (
  `id` int(11) NOT NULL,
  `soru` varchar(145) DEFAULT NULL,
  `cevap` varchar(6) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `altihane`
--

LOCK TABLES `altihane` WRITE;
/*!40000 ALTER TABLE `altihane` DISABLE KEYS */;
INSERT INTO `altihane` VALUES (1,'Eklemek, katmak, ilave etmek” anlamında bir söz','ULAMAK'),(2,'“Güncel” anlamına gelen Fransızca kökenli sözcük','AKTÜEL'),(3,'Dikiş nakış işlerinde kullanılan parmak korumalığı','YÜKSEK'),(4,'Havlamak” anlamında bir söz','ÜRÜMEK'),(5,'Döndürerek bükmek','BURMAK'),(6,'Kolayca, haksız ele geçen kazanç','VURGUN'),(7,'“Hayali” sözünün Türkçe kökenli karşılıklarından biri','DÜŞSEL'),(8,'Canlı bir sarı tonunu da adıyla niteleyen, dünyanın en pahalı baharatı','SAFRAN'),(9,'Yakınma ve hafifseme yoluyla “Şimdiki devir” anlamında kullanılan sözcük','ZAMANE'),(10,'“Müşkül” sözünün karşılıklarından biri','ZORLUK'),(11,'Avuç içine bakılarak yapılan kehanet türü','ELFALI'),(12,'“İnsicamlı, rabıtalı, muntazam” sözlerinin yaygın kullanılan karşılığı','DÜZGÜN'),(13,'Yapılacak bir işin türlü evrelerini zamana bağlı olarak gösteren program','TAKVİM'),(14,'“Yabancı” anlamında kullanılan bir ifade','ELOĞLU'),(15,'“Muteber” sözünün günümüz Türkçesindeki karşılıklarından biri','SAYGIN'),(16,'Gibi gelmek, farz etmek','SANMAK'),(17,'“Nikahlı eş, hanım” anlamında eski bir söz','REFİKA'),(18,'Uygulandığı yüzeyi havanın tesirinden koruyan çözülmüş reçine','VERNİK'),(19,'Balık yumurtası ile yapılan bir tür meze','TARAMA'),(20,'Sporda veya oyunda yenilmiş olanın aynı rakiple oynadığı ikinci oyun','RÖVANŞ'),(21,'Zeytingillerden, yaprakları karşılıklı bir ağaççık','LEYLAK'),(22,'Yalnız başparmağı ayrı, diğer dört parmağı bir örülmüş yün eldiven','KOLÇAK'),(23,'Benzerleri arasında niteliklerinin yüksekliğiyle göze çarpan, üstün, mümtaz','SEÇKİN'),(24,'Birleşme, kaynaşma','FÜZYON'),(25,'Bir yazı ile ilgili taslağı temize çekme','TEBYİZ'),(26,'Alacak ve verecekleri hesaplayarak sonucu belirlenmiş','LİKİDE'),(27,'Tamamıyla, büsbütün','HEPTEN'),(28,'Belirli bir sebebi olmadan sinirlenip huysuzluk eden (kimse)','HIRÇIN'),(29,'İstenilen düzende olan, düzene uygun olan, kurallara uygun olan','NİZAMİ'),(30,'Yoksunluğun genele yayılmış hali','KITLIK'),(31,'Büyümemişine şalak denen meyve','KARPUZ');
/*!40000 ALTER TABLE `altihane` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `beshane`
--

DROP TABLE IF EXISTS `beshane`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `beshane` (
  `id` int(11) NOT NULL,
  `soru` varchar(145) DEFAULT NULL,
  `cevap` varchar(5) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `beshane`
--

LOCK TABLES `beshane` WRITE;
/*!40000 ALTER TABLE `beshane` DISABLE KEYS */;
INSERT INTO `beshane` VALUES (1,'Haber toplama, yayma ve üyelerine dağıtma işiyle uğraşan kuruluş','AJANS'),(2,'Gelişen teknolojiyle birçok alanda insanın yerini alabileceği düşünülen elektromekanik araç','ROBOT'),(3,'Karanın deniz boyunca uzanan bölümü','DENİZ'),(4,'Kişinin kendine taktığı simgesel isim','RUMUZ'),(5,'Karanın deniz boyunca uzanan bölümü','SAHİL'),(6,'Dar alanlarda kendini tekrarlayan gezinti','VOLTA'),(7,'“Çöl” anlamında Arapça kökenli bir sözcük','SAHRA'),(8,'“Atlas” da denen kumaş türü','SATEN'),(9,'Çeşitli işlerde kullanılmak üzere hazırlanmış, işlenmiş ağaç parçası','TAHTA'),(10,'Bazı orkide türlerinden elde edilen, içecek ve dondurma yapımında kullanılan toz','SALEP'),(11,'“Kalmak” fiili ile birlikte, “Bir şeyin olmasına çok az kalmak” anlamında kullanılan sözcük','RAMAK'),(12,'Yok olmaya sebep olabilecek şey, büyük zarar, felaket','YIKIM'),(13,'Besin değeri düşük olsa da hayvancılıkta yararlanılan, tahıl hasadının artık ürünü','SAMAN'),(14,'Duruşmada gördüğünü ve bildiğini anlatan, görgüsüne başvurulan kimse','TANIK'),(15,'Bir din ve düşünce biçiminin, aynı zamanda da bir saç modelinin ortak adı','RASTA'),(16,'“Eziyet” ile eş anlamlı bir sözcük','ZULÜM'),(17,'“Duraksamadan yapılan konuşmayı veya konuşma tarzını” niteleyen bir sıfat','AKICI'),(18,'Çalar saat veya cep telefonunun, önceden belirlenen zamanda verdiği uyarı sesi','ALARM'),(19,'“Divan” sözcüğünün Arapça kökenli karşılığı','SEDİR'),(20,'Keten, kenevir gibi türlü dokuma maddelerinden yapılan ince halat','URGAN'),(21,'Geçimsizlik, anlaşmazlık, ara bozuculuk','NİFAK'),(22,'Zararı az, en zararsız','EHVEN'),(23,'Çıkıntıları çok olan bitki','DİKEN'),(24,'Bitkilerin çürümesiyle oluşan koyu renkte organik toprak','HUMUS'),(25,'Bir şeyin veya yapının ön tarafta bulunan bölümü','CEPHE'),(26,'Bir şeyin önemini belirlemeye yarayan soyut ölçü','DEĞER'),(27,'Genellikle, içinde bir şey yıkamak için kullanılan metal veya plastikten yayvan kap','LEĞEN'),(28,'Çevre, yöre, etraf','MUHİT'),(29,'Evlilik yoluyla birbirine bağlı olan kimseler','HISIM'),(30,'Bir yıkımın geride bıraktıkları','ENKAZ'),(31,'Güneşin batmasından iki saat sonraki vakit','YATSI');
/*!40000 ALTER TABLE `beshane` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dokuzhane`
--

DROP TABLE IF EXISTS `dokuzhane`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `dokuzhane` (
  `id` int(11) NOT NULL,
  `soru` varchar(145) DEFAULT NULL,
  `cevap` varchar(9) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dokuzhane`
--

LOCK TABLES `dokuzhane` WRITE;
/*!40000 ALTER TABLE `dokuzhane` DISABLE KEYS */;
INSERT INTO `dokuzhane` VALUES (1,' Genellikle ev işlerinde çalışan, işverenlerin isteklerini yerine getiren emekçi','HİZMETKAR'),(2,'“Bu işle ilgilenmem, buna karışmam” anlamında bir tabir','NEMELAZIM'),(3,'Bir cismi bir yöne doğru ansızın, çabucak fırlatmak','ALTIVERME'),(4,'Örnek ve feyzalınan, öykünülen, taklit edilen kişi','ROLMODELİ'),(5,'Mecazi anlamda “Bir yalana inandırmak”','YUTTURMAK'),(6,'“İthalatçı” anlamında bir söz dizisi','DIŞALIMCI'),(7,'“Saydamlık” sözcüğünün eş ve yakın anlamlısı','ŞEFFAFLIK'),(8,'Kavuniçi ile pembe arası bir renk','YAVRUAĞZI'),(9,'“Güneşin battığı sıralarda” anlamında kullanılan bir tabir','AKŞAMÜSTÜ'),(10,'“Sağ gösterip sol vurmak”. Şaşırtarak aldatmak','YANILTMAK'),(11,'“İyileştirmek, tedavi etmek” anlamında bir sözcük','SAĞALTMAK'),(12,'Onarım evi','TAMİRHANE'),(13,'Bilgisayarların ve onu kullanan insanların internet ve benzeri ağlar içinde kurduğu iletişimden doğan ortam','SANALALEM'),(14,'Genellikle kıyafetler, ayakkabılar için, “Uygun boyutlarda olmak, bütünüyle uymak” anlamında bir tabir','TAMGELMEK'),(15,'Varlığını yadsımak, mevcut olmadığını kabul etmek','YOKSAYMAK'),(16,'Alt anlamı, “Anlaşamamak, uyuşamamak” olan sözcük','SÜRTÜŞMEK'),(17,'Savaş, kaza veya afetlerde cana ve mala gelen büyük zarar','AĞIRKAYIP'),(18,'Bir sorunun çözümünü akıl etmek, çaresini ortaya koymak','YOLBULMAK'),(19,'Eğitim öğretimde öğrencilerin sorunlarını öğrenerek onlara yardımda bulunmayı amaçlayan dal','REHBERLİK'),(20,'Alışılmış olandan ayrı, olağanüstü, beklenmedik, görülmedik, işitilmedik','FEVKALADE'),(21,'Kötü bir davranışa aynen verilen karşılık','MİSİLLEME'),(22,'Yuva yapmak için ağaçları oyan böcek','AĞAÇDELEN'),(23,'Bir şey yapmak için onay sağlamak','İZİNALMAK'),(24,'Bir görüş, kanı veya inancı benimsetme çabası','GÜDÜMLEME'),(25,'Sıkıntı çekilmeden, güçlükle karşılaşmadan yapılan, eziyetsiz, kolay','ZAHMETSİZ'),(26,'Kan dökücülük, zalimlik.','HUNHARLIK'),(27,'Alışılmış olandan ayrı, olağanüstü, beklenmedik, görülmedik, işitilmedik','FEVKALADE'),(28,'Aralarındaki düşünce veya çıkar ayrılığını, karşılıklı ödünlerle kaldırarak uyuşmak','UZLAŞMAK'),(29,'İyi arkadaşlık eden, saygılı, görgülü, kibar erkek','CENTİLMEN');
/*!40000 ALTER TABLE `dokuzhane` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dorthane`
--

DROP TABLE IF EXISTS `dorthane`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `dorthane` (
  `id` int(11) NOT NULL,
  `soru` varchar(100) DEFAULT NULL,
  `cevap` varchar(4) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dorthane`
--

LOCK TABLES `dorthane` WRITE;
/*!40000 ALTER TABLE `dorthane` DISABLE KEYS */;
INSERT INTO `dorthane` VALUES (1,'\"Düşünce\" sözcüğünün yunanca kökenli karşılığı','İDEA'),(2,'C vitamini deposu olan meyve','KİVİ'),(3,'EKONOMİDE,\"PAY\"','MARJ'),(4,'SARI RENKLİ İRİ MEYVE','AYVA'),(5,'“Ulvi” sözünün Türkçe kökenli eş anlamlısı','YÜCE'),(6,'Deride sinirler boyunca beliren, “Gece yanığı” olarak da bilinen hastalık','ZONA'),(7,'Çabuk ve kolay kavrayan, zeyrek','ZEKİ'),(8,'Ruhi yaşam ve bedenle uyumlu olmayı amaçlayan kültürfizik ve felsefe sistemi','YOGA'),(9,'Temel niteliği bir olan dil, hayvan veya bitki topluluğu','AİLE'),(10,'Soğuk bir cisim üzerine ince bir tabaka durumunda yoğunlaşmış sıvı','BUĞU'),(11,'“Kendine çekme, etkileyerek bağlama” anlamında ki Arapça kökenli bir sözcük','CEZP'),(12,'Devlet veya özel kurumlarca verilen eğitim öğretim ödeneği','BURS'),(13,'Gönül birliği kurulmuş arkadaş, gönüldaş','DOST'),(14,'Fatih ve Beyoğlu’na bağlı bölgelerin birleşmesiyle kurulan İstanbul ilçesinin bilinen kısa adı','EYÜP'),(15,'“Genç inekler” için kullanılan sözcük','DÜVE'),(16,'“Belgegeçer” sözünün yabancı kökenli karşılığı','FAKS'),(17,'“Torik yavrusu”nun, argoda “Kadın” anlamına gelen adı','GACI'),(18,'Dünya’nın atmosferinde, yaklaşık beşte dört oranında bulunan gaz','AZOT'),(19,'İstenç güçsüzlüğü','ZAAF'),(20,'Akla ve gerçeğe aykırı','ABES'),(21,'Yün, pamuk vb. ipliklerden düğümlerle oluşmuş ağ','FİLE'),(22,'Bankaya para yatıran kimse','MUDİ'),(23,'Soğukla sıcak arası, ne soğuk ne sıcak','ILIK'),(24,'Kusur, özür, bozukluk','DEFO'),(25,'Bir kişi tarafından söylenen veya çalınan müzik parçası','SOLO'),(26,'Askerlik ödevini yapmaya çağırma','CELP'),(27,'Sonu gelmeyen istek, aşırı tutku','HIRS'),(28,'Gücü bir işe yetmez olanın durumu, güçsüzlük','ACİZ'),(29,'Kaçak ve yasak şeylerin saklandığı gizli yer','ZULA'),(30,'Yemek, barınma, ısınma gibi konularda çığır açan bir keşif','ATEŞ'),(31,'İlahi idarenin çizdiğine inanılan yol','BAHT');
/*!40000 ALTER TABLE `dorthane` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `giris`
--

DROP TABLE IF EXISTS `giris`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `giris` (
  `kullanici_adi` varchar(15) NOT NULL,
  `sifre` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`kullanici_adi`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `giris`
--

LOCK TABLES `giris` WRITE;
/*!40000 ALTER TABLE `giris` DISABLE KEYS */;
INSERT INTO `giris` VALUES ('a','a'),('admin','admin');
/*!40000 ALTER TABLE `giris` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `onhane`
--

DROP TABLE IF EXISTS `onhane`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `onhane` (
  `id` int(11) NOT NULL,
  `soru` varchar(145) DEFAULT NULL,
  `cevap` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `onhane`
--

LOCK TABLES `onhane` WRITE;
/*!40000 ALTER TABLE `onhane` DISABLE KEYS */;
INSERT INTO `onhane` VALUES (1,' “Tüm hava koşullarında, yaz kış kullanılabilen” gereçlere yönelik bir tabir','DÖRTMEVSİM'),(2,'“İmece”nin kurumsallaşıp sermayeli ortaklığa dönüşmüş hali','KOOPERATİF'),(3,'“Kefeni yırtmayı adet haline getirmiş kişiler” için kullanılan bir söz','DOKUZCANLI'),(4,' Psikolojik denge','RUHSAĞLIĞI'),(5,'“Bağımlılık” anlamında bir söz','MÜPTELALIK'),(6,'Çekerek ve iterek hırpalama','TARTAKLAMA'),(7,'Aktarmasız yapılan hava yolculuğu','DİREKTUÇUŞ'),(8,'\"Aşkmerdiveni” de denen bitkinin bir diğer adı','EĞRELTİOTU'),(9,'“Göz, Burun, Kulak, Dil ve Derinin her biri” için kullanılan bir tabir','DUYUORGANI'),(10,'“Saklanan, gizlenen bir şey veya bir kişi için gözükme, anlaşılma” anlamlarında bir söz dizisi','AÇIĞAÇIKMA'),(11,'Yatırılmış sermayenin bir kuruluşun veya bir yatırımın gelir sağlayabilme olanağı, rantabilite','VERİMLİLİK'),(12,'Halk ağzında, “Sözü geçme, yetkisi olma” anlamında kullanılan bir tabir','BORUSUÖTME'),(13,'“Araç gereç” ile eş anlamlı kullanılan bir sözcük dizisi','ALETEDEVAT'),(14,'Yaratıcılık ve ustalık sonucu ortaya çıkan eserlere değer veren, ilgi gösteren kişi','SANATSEVER'),(15,'Maddi veya manevi olarak yardımcı olma, koltuk çıkma','DESTEKLEME'),(16,'“Eğlence mekanlarında müzisyenlerin çalgı ve sesleriyle seslendirdikleri repertuvara” verilen genel ad','CANLIMÜZİK'),(17,'“Sınırları bilinmeyen, sonu olmadığı düşünülen olgular” için kullanılan metaforik tabir','DİPSİZKUYU'),(18,'“Temasla çalışan cihazları” niteleyen bir tabir','DOKUNMATİK'),(19,'Bir soruyu, bir isteğe, bir söz veya yazıya karşılık vermek','CEVAPLAMAK'),(20,'Bir isteği kabul etmeme, nazlanma','MIRINKIRIN'),(21,'Eşi görülmemiş, şaşkınlık yaratıcı, olağanüstü','HARİKULADE'),(22,'Bir aşağı bir yukarı dolaşmak','VOLTAATMAK'),(23,'Sürekli ve hızlı bir biçimde','BICIRBICIR'),(24,'İçyüzü, gerçek şekli','ASLIASTARI'),(25,'Çarşaf, yastık kılıfı, nevresim ve yorgandan oluşan yatak eşyası','UYKUTAKIMI'),(26,'iyi bir duruma getirmek, iyileştirmek, düzeltmek','ISLAHETMEK'),(27,'Halk oylaması','REFERANDUM'),(28,'Bir durumu, bir haberi sözle veya yazıyla halka bildirmek','ANONSETMEK'),(29,'Karın doyurmak, beslenmek','YİYİPİÇMEK');
/*!40000 ALTER TABLE `onhane` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `oyuncular`
--

DROP TABLE IF EXISTS `oyuncular`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `oyuncular` (
  `kullaniciadi` varchar(15) NOT NULL,
  `oynaniszaman` varchar(45) DEFAULT NULL,
  `puan` int(11) DEFAULT NULL,
  `harfalma` int(11) DEFAULT NULL,
  `kalansure` varchar(6) DEFAULT NULL,
  PRIMARY KEY (`kullaniciadi`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `oyuncular`
--

LOCK TABLES `oyuncular` WRITE;
/*!40000 ALTER TABLE `oyuncular` DISABLE KEYS */;
INSERT INTO `oyuncular` VALUES ('Ahmet','13.04.2021 18:02:15',0,0,'3:56'),('Ali2','25.03.2021 17:53:11',600,10,'3:54'),('Ayşe','20.03.2021 00:42:19',1200,5,'1:34'),('D1','13.04.2021 14:20:46',0,0,'3:50'),('De1','25.03.2021 18:19:26',0,3,'3:44'),('demir','21.03.2021 01:42:19',800,12,'2:23'),('efecan','21.03.2021 00:42:19',400,20,'3:44'),('fa','25.03.2021 17:08:17',300,87,'3:33'),('Fatma','01.03.2021 00:42:19',200,33,'2:54'),('Mehmet','23.03.2021 01:28:19',1000,60,'2:25'),('rep','11.03.2021 00:42:19',2400,6,'3:39'),('safd','25.03.2021 17:46:25',200,35,'2:55'),('uyyh','13.04.2021 14:25:15',2300,22,'3:59'),('Veli','25.03.2021 16:34:53',0,0,'3:55');
/*!40000 ALTER TABLE `oyuncular` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sekizhane`
--

DROP TABLE IF EXISTS `sekizhane`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sekizhane` (
  `id` int(11) NOT NULL,
  `soru` varchar(145) DEFAULT NULL,
  `cevap` varchar(8) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sekizhane`
--

LOCK TABLES `sekizhane` WRITE;
/*!40000 ALTER TABLE `sekizhane` DISABLE KEYS */;
INSERT INTO `sekizhane` VALUES (1,' Her dizenin ilk harfi yukarıdan aşağıya doğru okunduğunda ortaya bir söz çıkacak biçimde düzenlenmiş manzume','AKROSTİŞ'),(2,' Duygusal bağ veya akrabalık ilişkisi','YAKINLIK'),(3,' Argoda, “Normal formunu, halini, durumunu kaybetmek, bozulmak”','YAMULMAK'),(4,'Alacakların toplanması','TAHSİLAT'),(5,'Bir ilacın bir defada veya bir günde alınması gereken miktarının fazlasını kullanma','DOZAŞIMI'),(6,'Eğlence amaçlı, fiziksel temas içeren, genelde hoş karşılanmayan her türlü hareket','ELŞAKASI'),(7,'Konuk ağırlayan kimse, kurum, şehir veya ülke','EVSAHİBİ'),(8,'Mecazen, “Çok eskimiş olmak, değerini ve güzelliğini yitirmek”','DÖKÜLMEK'),(9,'Geçmişte, mahkemece ispatlanıp cezalandırılmış bir suç işlemiş olan','SABIKALI'),(10,'Sürekli ve aşırı çalışmadan doğan yorgunluk, bitkinlik','SÜRMENAJ'),(11,'\"İlişkili, ilintili, ilgili” anlamlarındaki bir söz','ALAKADAR'),(12,'“Film prodüksiyon şirketi”nin Türkçe karşılığı','YAPIMEVİ'),(13,'İçindeki tanelerin hareketi ile ses çıkaran oyuncak','ÇINGIRAK'),(14,'Kötü ve yasa dışı işlerdeki yardımcı','YARDAKÇI'),(15,'“Herhangi bir uğraşısı ve işi olmayıp, iş bulmaya da çalışmayan kişilere” yönelik bir söz','BOŞGEZEN'),(16,'Kan basıncı','TANSİYON'),(17,'\"Etmek” fiiliyle birlikte, “Ahbapça, dostça konuşmak, sohbet etmek” anlamında kullanılan bir söz','YARENLİK'),(18,'“Korku, üzüntü, coşku benzeri sebeplerle yüz rengi solmak” anlamında bir tabir','SARARMAK'),(19,'Tüketicinin maddi düzeyi','ALIMGÜCÜ'),(20,'Bir yerde çalışan kimselere genellikle kazançtan dağıtılan  para','İKRAMİYE'),(21,'Aralarındaki düşünce veya çıkar ayrılığını, karşılıklı ödünlerle kaldırarak uyuşmak','UZLAŞMAK'),(22,'Katı yürekli, merhametsiz','ACIMASIZ'),(23,'Çalma, aşırma','ARAKLAMA'),(24,'Cambazlık','AKROBASİ'),(25,'Kilit, tel, çivi vb. metal eşya','HIRDAVAT'),(26,'Görür görmez seven, âşık olan kimse','ŞIPSEVDİ'),(27,'Çıkış yeri kolay bulunamayacak kadar karışık koridorları olan yapı','LABİRENT'),(28,'Bir elektrik üretecinin kutuplarını birbirinden ayırt etmeyi sağlayan nitelik','POLARİTE'),(29,'Türlü eğlence ve oyun kuruluşları bulunan alan','LUNAPARK');
/*!40000 ALTER TABLE `sekizhane` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `yedihane`
--

DROP TABLE IF EXISTS `yedihane`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `yedihane` (
  `id` int(11) NOT NULL,
  `soru` varchar(145) DEFAULT NULL,
  `cevap` varchar(7) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `yedihane`
--

LOCK TABLES `yedihane` WRITE;
/*!40000 ALTER TABLE `yedihane` DISABLE KEYS */;
INSERT INTO `yedihane` VALUES (1,'Bir yere ağırlanmak üzere çağrılmış kişi','DAVETLİ'),(2,'Neşeli ve hoşça vakit geçirilen toplantı','EĞLENTİ'),(3,'Yapılması istenmeyen bir davranışı engellemek için söylenen, iki farklı ünlemden oluşan sözcük dizisi','SAKINHA'),(4,'“Birbiri arkasından” anlamında bir söz dizisi','ÜSTÜSTE'),(5,'“Amacında, yolunda” anlamında bir zarf','UĞRUNDA'),(6,'Evliya mucizesi','KERAMET'),(7,'“Öküz, manda ve deve” gibi hayvanlar için, “Diyaframını kullanarak bağırma”','BÖĞÜRME'),(8,' Bir iş için, “Gereği gibi yürümemek, geri kalmak” anlamında kullanılan tabir','AKSAMAK'),(9,'“Karşılık beklemeden, iyilik olsun diye” anlamında bir söz','HAYRINA'),(10,'Bir adın başka bir ad, zamir veya sıfatla oluşturduğu kelime grubu','TAMLAMA'),(11,'“Açıktan açığa, gerçekten” anlamlarında pekiştirilmiş bir sözcük','DÜPEDÜZ'),(12,'Randevulaştığı kişi tarafından aldatılmak','EKİLMEK'),(13,'“Bir internet servisi veya web sitesi adresinin sözcük olarak ismi” anlamındaki bilişim terimi','ALANADI'),(14,'“Bayrağı ve Sancağı taşıyan kimse” anlamında eski bir tabir','ALEMDAR'),(15,'Yağ alınmış sütten yapılan peynir, kesmik, çökelek','EKŞİMİK'),(16,'“Maş, çalı, horoz” gibi türleri olan bir bitki','FASULYE'),(17,'“Güçlü, hareketli ve aktif” anlamlarındaki söz','ENERJİK'),(18,'Kuşlar için, “Ezgili ses çıkarmak”','ŞAKIMAK'),(19,'Alt anlamı, “Harcayıp tüketmek” olan söz','ERİTMEK'),(20,'Değişik iş kollarında gerekli olan şeyler, araç ve gereçler','LEVAZIM'),(21,'Sertlik, kabalık, kırıcılık','HUŞUNET'),(22,'Tasalanmış, tasalı, kaygılı','EFKARLI'),(23,'Sert ve sürekli çıkan ses','HIŞILTI'),(24,'Attığı kurşun, taş vb. ile hedefi vurmakta ustalık kazanmış olan','NİŞANCI'),(25,'Sulu, cıvık hamur','BULAMAÇ'),(26,'Yücelik','ULVİYET'),(27,'Sövmeyi huy edinmiş olan (kimse)','AĞZIPİS'),(28,'Çaresiz bir biçimde, çıkar yolu olmaksızın','UMARSIZ'),(29,'Yemek yeme gereksinimi duymak','ACIKMAK');
/*!40000 ALTER TABLE `yedihane` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-04-14  1:44:55
