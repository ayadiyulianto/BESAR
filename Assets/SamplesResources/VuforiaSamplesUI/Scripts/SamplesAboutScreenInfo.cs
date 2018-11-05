/*===============================================================================
Copyright (c) 2016 PTC Inc. All Rights Reserved.

Vuforia is a trademark of PTC Inc., registered in the United States and other 
countries.
===============================================================================*/
using System.Collections.Generic;

public class SamplesAboutScreenInfo
{

	#region PRIVATE_MEMBERS

    private Dictionary<string, string> titles;
    private Dictionary<string, string> descriptions;

	#endregion // PRIVATE_MEMBERS


	#region PUBLIC_METHODS

    public string GetTitle(string titleKey)
    {
        return getValuefromDictionary(titles, titleKey);
    }

    public string GetDescription(string descriptionKey)
    {
        return getValuefromDictionary(descriptions, descriptionKey);
    }
	
	#endregion // PUBLIC_METHODS


	#region PRIVATE_METHODS

    private string getValuefromDictionary(Dictionary<string, string> dictionary, string key)
    {
        if (dictionary.ContainsKey(key))
        {
            string value;
            dictionary.TryGetValue(key, out value);
            return value;
        }
        else
        {
            return "Key not found.";
        }
    }

	#endregion // PRIVATE_METHODS


	#region CONSTRUCTOR

    public SamplesAboutScreenInfo()
    {

        // Init our Title Strings

        titles = new Dictionary<string, string>();

        titles.Add("Fort", "Fort Marlborough");
		titles.Add("Arsitektur", "Arsitektur Fort Marlborough");
		titles.Add("Bengkulu", "Sejarah Bengkulu");
		titles.Add("Parr", "Monument Thomas Parr");
        titles.Add("HowTo", "Cara Menggunakan");
        titles.Add("Tentang", "Tentang BESAR");
		titles.Add("Rumah","Rumah Pengasingan Bung Karno");
		titles.Add ("Jamik", "Masjid Jamik");
		titles.Add("first", "Tahun 1600");
		titles.Add("second", "Tahun 1700");
		titles.Add("third", "Tahun 1800");
		titles.Add("fourth", "Tahun 1900");
		titles.Add("shaw", "Prasasti Nisan");
		titles.Add("foto", "Foto keluarga Soekarno");

        // Init our Common Cache Strings

        string footer = 
            "\n\n" +
            "PKM-T 2017 BESAR.";

        // Init our Description Strings

        descriptions = new Dictionary<string, string>();

        // Image lokasi

        descriptions.Add("Fort", 
			"\nBenteng Marlborough (Inggris:Fort Marlborough) adalah benteng peninggalan Inggris di kota Bengkulu. " +
			"Benteng ini didirikan oleh East India Company (EIC) tahun 1714-1718 di bawah pimpinan gubernur Joseph Callet " +
			"sebagai benteng pertahanan Inggris. Benteng ini merupakan benteng terkuat Inggris di wilayah Timur " +
			"setelah benteng St. George di Madras, India.\n" +
            "\n" +
			"Marlborough masih berfungsi sebagai benteng pertahanan hingga masa Hindia Belanda tahun 1825-1942, Jepang tahun 1942-1945, " +
			"dan pada perang kemerdekaan Indonesia. Sejak Jepang kalah hingga tahun 1948, benteng itu manjadi markas Polri. Namun, " +
			"pada tahun 1949-1950, benteng Marlborough diduduki kembali oleh Belanda. Setelah Belanda pergi tahun 1950, " +
			"benteng Marlborough menjadi markas TNI-AD. Hingga tahun 1977, benteng ini diserahkan kepada Depdikbud untuk dipugar " +
			"dan dijadikan bangunan cagar budaya."
			+
            "\n" +
            footer + "\n");


		
		descriptions.Add("Arsitektur", 
			"Benteng merupakan lokasi militer atau bangunan yang didirikan secara khusus, diperkuat dan tertutup yang dipergunaka untuk " +
			"melindungi suatu instalasi, daerah , pasukan tentara dari serangan musuh atau untuk menguasai suatu daerah.\nBeberapa " +
			"komponen bangunan benteng Marlborough antara lain : \n<size=20>Revaline</size> adalah bangunan pertahanan bersudut tiga, umumnya terletak " +
			"diatas parit di depan curtine yang dihubungkan oleh jembatan ke arah bangunan benteng. Pada benteng Marlborough, " +
			"bagian revaline pada awalnya berfungsi sebagai pertahanan. namun pada masa kemudian difungsikan juga sebagai sarana sosial." +
			" \nHal ini dibuktikan dengan adanya 3 buah makam yaitu makam Thomas Parr, Charles Muray, dan Robert Hamilton. " +
			"Selain ketiga makam tersebut terdapat pula 4 buah prasastinisan berbahasa inggris yang ditempatkan pada dinding " +
			"gerbang pintu masuk yang bertuliskan George Thomas Shaw yang meninggal tanggal 25 April 1704, Richard Watts yang meninggal 17 Desember 1705." +
			"\nHenry Starling yang meninggal pada bulan April 1744 dalam usia 25 tahun dan Capt. James Coney yang meninggal Februari 1737 dalam usia 36 tahun." +
			"\nDiluar bangunan benteng terdapat parit keliling dengan kedalaman parit 1-3 meter dan lebarnya 7 meter. " +
			"Parit tersebut digunakan sebagai pertahanan pertama terhadap serangan musuh dan pembuangan aliran air dari dalam benteng." +
			"\n<size=20>Curtine</size> merupakan tembok pertahanan utama sebuah benteng yang terletak diantara dua bastion." +
			"\n<size=20>Bastion</size> adalah bagian yang menjorok keluar yang terletak pada tiap tiap sudut benteng. letaknya memungkinkan " +
			"seseorang untuk menembak tanpa harus memperlihatkan dirinya dan dapat menembak ke segala arah dengan bebas. " +
			"Dikembangkan pertama kali oeh bangsa Italia pada akir abad 15. pada benteng Marlborough terdapat 4 bastion di empat arah " +
			"mata angin.\nBastion barat memiliki ruang yang difungsikan sebagai penjara sebanyak 2 ruang dan ruang bawah tanah. " +
			"bangunan antara bastion timur dan selatan terdapat 5 ruang dengan pintu berbentuk jeruji. bangunan antara bastion " +
			"selatan dan barat terbagi menjadi 2 bagian yang dipisahkan lorong gerbang utama. pada benteng marlborough terdapat 4" +
			" meriam yang diletakkan diatas bastion dengan jenis meriam kaliber 10 cm. fungsi benteng marlborough sebagai pusat " +
			"pertahanan pada masa\ninggris menjadi berkurang, dan lebih difungsikan sebagai pangkalan perdagangan. hal ini terlihat " +
			"pada tahun 1803 Eic menjadikan benteng marlborough sebagai pusat penimbunan\nrempah-rempah inggris di seluruh hindia timur."			+
			"\n" +
			footer + "\n");
		// Image lokasi

		descriptions.Add("Parr", 
			"\n"+
			"Tugu Thomas Parr berbentuk oktagonal dengan sebuah kubah diatasnya." +
			" Karena kubah tersebut, tugu tersebut juga dikenal oleh orang lokal sebagai \"Kuburan Bulek\"." +
			"didedikasikan kepada Thomas Parr, Residen Inggris di Bengkulu yang terbunuh pada 1807"+
			"Thomas Parr lahir di Wigan, Lancashire, Inggris, dan dibaptis pada 20 Maret 1768" +
			"ia kemudian ditunjuk menjadi Residen di Bengkulu pada bulan April 1805, untuk memperbaiki keadaan di sana." +
			"Thomas Parr lalu melakukan banyak perubahan cara kerja, yang mana kebijakannya tersebut dilaksanakan secara otoriter dan manasuka." +
			" Ia mengkhususkan penanaman tanaman pala dan cengkeh untuk Inggris, sedangkan rakyat pribumi diharuskan untuk menanam kopi. " +
			"Pelaksanaan tanam paksa yang dirasakan kejam menimbulkan ketidakpuasan pada rakyat." +
			"\n\nCatatan Lady Sophia Raffles, istri kedua Sir Thomas Stamford Raffles, menyebutkan bahwa Thomas Parr tidak mengindahkan siapapun, bahkan para kepala adat" +
			" dan bangsawan setempat lainnya yang telah lama menjalin hubungan dengan Inggris. Ia juga mengubah tata cara peradilan " +
			"pribumi tanpa persetujuan ataupun meminta nasihat dari mereka. Rakyat setempat telah berada dalam keadaan krisis dan siap " +
			"memberontak, tapi Parr tidak menyadari bahaya yang mengancamnya." +
			"\n\nThomas Parr tewas terbunuh di kamar tidurnya pada malam hari tanggal 23 Desember 1807, dalam suatu serangan mendadak oleh" +
			" sekelompok orang yang tak dikenal. Turut terluka pula istrinya Frances Parr serta asistennya Charles Murray, yang " +
			"berusaha melindungi Parr dalam serangan tersebut. Charles Murray meninggal beberapa hari kemudian." +
			" Mereka dimakamkan secara berdampingan di area Benteng Marlborough."+
			"\n" +
			footer + "\n");

		// Cylinder lokasi

		descriptions.Add("Rumah", 
			"\nRumah Pengasingan Bung Karno merupakan tempat Soekarno menjalani hukuman pengasingan sebagai tahanan politik." +
			" Soekarno diasingkan ke Ende, Flores pada 14 Januari 1934. Ia diasingkan di sana selama empat tahun (1934-1938)." +
			" Setelah itu, ia diasingkan ke Bengkulu" +
			"Rumah pengasingan di Bengkulu" +
			"\nRumah ini terletak di tengah Kota Bengkulu, tepatnya di jalan Sukarno Hatta Kelurahan Anggut Atas kecamatan Gading Cempaka." +
			" Awalnya, rumah tersebut adalah milik seorang pedagang Tionghoa yang bernama Lion Bwe Seng yang disewa oleh orang Belanda " +
			"untuk menempatkan Soekarno selama diasingkan di Bengkulu. Soekarno menempati rumah itu pada 1938-1942. Di rumah ini terdapat" +
			" barang-barang peninggalan Soekarno. Ada ranjang besi yang pernah dipakai Soekarno dan keluarganya, koleksi buku yang " +
			"mayoritas berbahasa Belanda serta seragam grup drama Monte Carlo asuhan Soekarno semasa di Bengkulu. Ada juga foto-foto " +
			"Soekarno dan keluarganya yang menghiasi hampir seluruh ruangan dan yang tidak kalah menarik adalah sepeda tua yang dipakai Soekarno selama di Bengkulu." +
			"\n" +
			footer + "\n");

		// Cylinder lokasi

		descriptions.Add("Jamik", 
			"\n\nSukarno yang mengantongi gelar insinyur bidang arsitektur meninggalkan jejak saat melakukan renovasi atau perbaikan " +
			"secara menyeluruh terhadap bangunan Masjid Jamik. Masjid itu berlokasi di Jalan Jenderal Sudirman\n" +
			" sebelum direnovasi Bung Karno, bangunan itu hanyalah sebuah gubuk kecil yang oleh masyarakat sekitar disebut \"Surau Lamo\"." +
			"  Oleh Bung Karno dirancang satu bangunan bergaya Eropa dengan dua buah bubungan dan teras memanjang." +
			"Desain bangunan rancangan Bung Karno itu oleh warga sekitar itu lalu dikerjakan secara bersama sama dengan kumpulan uang untuk" +
			" membeli bahan bangunan secara bergotong royong. Mayoritas warga adalah penduduk asli suku bangsa Serawai \n\nDi sela " +
			"sela mengajar di Perguruan Muhammadiyah yang terletak di Jalan KH Ahmad Dahlan, Bung Karno selalu menyempatkan diri salat" +
			" di Surau Lamo. Melihat kondisi bangunan yang sangat memprihatinkan, Bung Karno lalu membuat desain dan memimpin renovasi " +
			"yang dimulai pada 1940. Pemugaran dilakukan selama satu tahun" +
			"\n" +
			footer + "\n");
		
        // VuMark

        descriptions.Add("HowTo", 
			"\n" +
			"- Download dan install aplikasi\n" +
			"- dapatkan gambar target di website\n" +
			"- arahkan kamera aplikasi ke gambar target\n" +
			"- tap dua kali untuk melihat model lain\n" +
			"- baca dan dengarkan informasi menarik dari gambar target tersebut\n" +
			"- jangan lupa bagikan pengetahuan barumu ke orang lain" +
            "\n" +
            footer + "\n");
		

        // Cylinder lokasi

        descriptions.Add("Tentang", 
			"\nBESAR merupakan sebuah aplikasi wisata sejarah untuk kota bengkulu dengan menggunakan teknologi realitas tertambah" +
			"(bahasa inggris : Augmented Reality).\n\n" + "<size=20>Tujuan</size>"+
			"\n" + "1.Mempromosikan wisata sejarah di Kota Bengkulu kepada wisatawan domestik dan mancanegara.\n" +
			"2.Membangun aplikasi AR berbasis smartphone untuk membantu wisatawan mengeksplorasi destinasi sejarah di Kota Bengkulu.\n" +
			"3.Menumbuhkan minat belajar sejarah Bengkulu.\n"+
			"\nBESAR merupakan produk dari Program Kreatifitas Mahasiswa skema Penerapan Teknologi(PKM-T) tahun pelaksaanaan 2017 yang didanai" +
			"oleh Kemenristekditi RI"+
            footer + "\n");

		// Cylinder lokasi

		descriptions.Add("first", 
			"<size=20>Masa Kerajaan</size>"+
			"\nSekitar abad 12 di daerah Bengkulu terdapat beberapa kerajaan antara lain:" +
			"\nKerajaan Selebar di daerah Pelabuhan pulai baai dan jenggalu\nKerajaan Sungai Serut\nKerajaan sungai lemau di pondok kelapa\nKerajaan empat petulai di daerah rejang lebong\nkerajaan indera pura\nkerajaan sungai itam di daerah lebak\nkerajaan gedung agung dan manau riang di bengkulu selatan\n" +
			"\nSampai pada akhir abad 15 kerajaan-kerajaan di daerah bengkulu berada di bawah pengaruh kerajaan majapahit yang mengalahkan sriwijaya pada abad 13. dalam periode ini kerajaan di daerah bengkulu khususnya di daerah rejang lebong dipimpin oleh para biksu (pemimpin agama budha) yang datang dari kerajaan sriwijaya. pada periode ini pula di bengkulu berkembang tulisan asli daerah dengan abjad Ka Ga Nga. Setelah kekuasaan kerajaan majapahit mundur pada pertengahan abad 16 kerajaan di bengkulumasuk ke dalam pengaruh kesultanan banten. Pada saat kesultanan banten berada dibawah kekuasaan belanda maka belanda ingin mengadakan peninjauan perdagangan lada dan hasil bumi lainnya di bengkulu. VOC mendarat dan sampai di kerajaan selebar pada tahun 1624. selanjutnya belanda mendirikan pos perdagangan pada tahun 1633. belanda menerapkan sistem perbudakan yang menyebabkan adanya pemberontakan dari kerajaan selebar.\n\n"+
			"\n\n<size=20>Kedatangan bangsa Inggris</size>"+
			"\n1570 : Sir Francis Drake, Orang Inggris pertama yang melalui Indonesia tepatnya selat sunda \n" +
			"\n1601 : pertama kali hubungan resmi bangsa Indonesia dan Inggris - Sultan Aceh dan Ratu Elizabeth I\n" +
			"\n1684 : Inggris dipaksa meninggalkan bandar perdagangan lada utama di banten karena kalah dari belanda\n" +
			"\n1685 12 juli : Ralph Ord salah seorang wakil dari East India Company Berhasil menguasai bengkulu."+
			"\n" +
			footer + "\n");

		// Cylinder lokasi

		descriptions.Add("second", 
			"<size=20>Masa Penjajahan Inggris</size>\n"+
			"\n1712 : Josep Collet ditunjuk menjadi deputi gubernur bengkulu \t\n" +
			"\n1714-1718 : Josep Collet membangun benteng di atas karang terletak 2 mil dari Yort Fort, dinamakan Marlborough untuk menghormati John Churchill Duke Of Marlborough I yang menjadi pahlawan perang eropa\n" +
			"\n1720 : Depgub dan staf Inggris meninggalkan Benteng karean pertentangan dengan penguasa bengkulu.\n" +
			"\n1723 : East India Company kembali menduduki benteng dengan menunjuk depgub dan staf baru beserta 2 kompi tentara infantri dan detasemen artileri\n" +
			"\n1759 : pembuatan parit di sekitar benteng\n" +
			"\n1760 : Bengkulu menjadi ibukota presidensi wilayah East India Company dipesisir barat.\n" +
			"\n1760 : Pihak inggris di benteng Marlborough menyerah ke pasukan Perancis karena kurang amunisi. Perancis menjadikannya sebagai penjara\n" +
			"\n1761 : Perancis meninggalkan benteng karena wabah penyakit.\n\n1761 : Roger Carter menjadi Gubernur wilayah pesisir barat pertama.\n" +
			"\n1785 : Status Presidensi Bengkulu berubah menjadi bagian Presidensi Madras di India.\n" +
			"\nSejak tahun 1714 hingga 1824, Fort Marlborough menjadi pusat pemerintahan kekuasaan inggris. Namun demikian, karena keangkuhan para pimpinannya rakyat melakukan beberapa kali perlawanan terang-terangan terhadap Inggris. Pada Maret 1719, pasukan rakyat Bengkulu menyerang Fort Marlborough. Peristiwa inilah yang menjadi hari jadi kota Bengkulu.\nPerlawanan lainnya adalah pembunuhan terhadap Thomas Parr, salah satu residen inggris yang dikenal kejam dan sangat angkuh pada Desember 1807 di Malibu Felix. Jasadnya di kubur di Fort Marlborough. Monumen peringatan Thomas Parr dibangun tidak jauh di tenggara Benteng Marlborough.\n\n"+
			"\n" +
			footer + "\n");

		// Cylinder lokasi

		descriptions.Add("third", 
			"\n1807 23 desember : Thomas Parr dibunuh\n" +
			"\n1808 : Pembangunan monumen Thomas Parr\n"+
			"\n1818-1821 : Sir Thomas Stamford Raffles menjadi letnan gubernur di bengkulu, ia memiliki hubungan yang baik dengan pemimpin setempat sehingga sangat membantu biaya\noperasional mengatur daerah penduduk.\n" +
			"\n<size=20>Masa Penjajahan Belanda</size>\n"+
			"\n1825 : Penyerahan kekuasaan wilayah pesisir barat Sumatra dari tangan inggris ke belanda sesuai perjanjian Anglo-Dutch.\n" +
			"\n1850 : Pemasangan meriam di 4 menara di benteng\n" +
			"\nSejak tahun 1807 hingga 1817 Bengkulu dalam keadaan tidak aman. Belanda berusaha mengambil alih kekuasaan selama lima tahun, sebelum kemudian koloni Belanda kembali dan Inggris kembali menduduki Bengkulu yang di bawah kepemimpinan Thomas Stamford Raffles. Pada tanggal 17 Maret 1824, perjanjian antara kerajaan inggris dan kerajaan Belanda tentang wilayah dan perdagangan di Hindia Timur ditandatangani di London. Belanda mulai menduduki Bengkulu.\nSetelah kekuasaan diambil alih oleh pemerintah Hindia Belanda, ekonomi mulai maju kembali, dengan dibukanya pertambangan emas di daerah Lebong, perkebunan teh, kopi dan kina di daerah Rejang. Pada masa itu pula pemerintah Hindia Belanda membagi Bengkulu menjadi 5 Afdeeling, yaitu Benkoelen, Lebong, Seluma, Manna dan Krue. Pemerintah Hindai Belanda mengatur seluruh birokrasi di Bengkulu dan mengambil alih penggunaan Fort Marlborough. \n\n"+
			"\n" +
			footer + "\n");

		// Cylinder lokasi

		descriptions.Add("fourth", 
			"\n1938 : Soekarno diasingkan ke Bengkulu.\n"+
			"\n1940 : Pemugaran masjid Jamik dengan arsitektur buatan Soekarno.\n"+
			"\n1942 : Berakhirnya masa pengasingan Soekarno\n"+
			"\n1943 : belanda menyerahkan benteng  ke jepang\n" +
			"\n1946 : tentara indonesia memanfaatkannya sebagai markas.\n" +
			"\n1970 : benteng dikosongkan.\n" +
			"\n1977 : pemugaran\n" +
			"\n<size=20>Masa Pengasingan Soekarno</size>\n"+
			"\nPada tahun 1938 Ir. Soekarno diasingkan oleh Belanda dari Ende Nusa Tenggara Timur ke Bengkulu.\nPejuang Indonesia yang wafat di Bengkulu pada  masa ini adalah Sentot Alibasyah.\nPada tanggal 8 Desember 1941, terjadi perang pasifik dengan keterlibatan Belanda, sejak itu tidak ada pertahanan Belanda yang tersisa dan mereka melarikan diri meninggalkan Bengkulu ke Bintuhan, kemudian ke Australia.\n" +
			"\n<size=20>Masa Kemerdekaan</size>\n"+
			"\nSetelah jepang menyerah kepada sekutu pada tanggal 14 agustus 1945, indonesia memproklamasikan kemerdekaan pada tanggal 17 agustus 1945. pada tanggal 6 oktober 1945,\nkapten williams datang ke bengkulu sebagai wakil tentara sekutu yang memiliki tugas mengurus tawanan perang serta mengawal gerakan kemerdekaan. kedatangan tentara sekutu di Bengkulu disambut para pejabat setempat seperti Ir. Inderatjaya (Residen Bengkulu), R. Abdullah dan MA Chanafiah (Pemimpin KNI). Belanda yang masih berkeinginan untuk menduduki Bengkulu datang membonceng sekutu (NICA). Rakyat Bengkulu yang tidak ingin dijajah lagi kemudian bersatu menghadapi Belanda pada agresi militer I dan II.\nBelanda ingin menguasai kembali perkebunan dan pertambangan di daerah Bengkulu. Peristiwa heroik rakyat Bengkulu dalam rangka mempertahankan kemerdekaan terjadi di lokasi pertambangan\ndaerah lebong. Rakyat Bengkulu berhasil mempertahankan Lebong dari serangan belanda. Akibat dari peristiwa ini, pertambangan di Lebong dihancurkan Belanda dengan cara dibombardir dari udara.\nDengan adanya perundingan Konferensi Meja Bundar, mewajibkan belanda harus meninggalkan wilayah Indonesia.\npada tanggal Desember 1949 Karesidenan Bengkulu terbentuk kembali dengan M. Hasan sebagai residen Bengkulu. Pada tanggal 18 November 1968, Karesidenan bengkulu diresmikan menjadi Provinsi Bengkulu dengan Gubernur Ali Amin.\n" +
			footer + "\n");

		descriptions.Add("Bengkulu", 
			"\n<size=20>Masa Penjajahan Inggris</size>\n"+
			"\n1570 : Sir Francis Drake, Orang Inggris pertama yang melalui Indonesia tepatnya selat sunda \n" +
			"\n1601 : pertama kali hubungan resmi bangsa Indonesia dan Inggris - Sultan Aceh dan Ratu Elizabeth I\n" +
			"\n1684 : Inggris dipaksa meninggalkan bandar perdagangan lada utama di banten karena kalah dari belanda\n" +
			"\n1685 12 juli : Ralph Ord salah seorang wakil dari East India Company Berhasil menguasai bengkulu."+
			"\n1712 : Josep Collet ditunjuk menjadi deputi gubernur bengkulu \t\n" +
			"\n1714-1718 : Josep Collet membangun benteng di atas karang terletak 2 mil dari Yort Fort, dinamakan Marlborough untuk menghormati John Churchill Duke Of Marlborough I yang menjadi pahlawan perang eropa\n" +
			"\n1720 : Depgub dan staf Inggris meninggalkan Benteng karean pertentangan dengan penguasa bengkulu.\n" +
			"\n1723 : East India Company kembali menduduki benteng dengan menunjuk depgub dan staf baru beserta 2 kompi tentara infantri dan detasemen artileri\n" +
			"\n1759 : pembuatan parit di sekitar benteng\n" +
			"\n1760 : Bengkulu menjadi ibukota presidensi wilayah East India Company dipesisir barat.\n" +
			"\n1760 : Pihak inggris di benteng Marlborough menyerah ke pasukan Perancis karena kurang amunisi. Perancis menjadikannya sebagai penjara\n" +
			"\n1761 : Perancis meninggalkan benteng karena wabah penyakit.\n\n1761 : Roger Carter menjadi Gubernur wilayah pesisir barat pertama.\n" +
			"\n1785 : Status Presidensi Bengkulu berubah menjadi bagian Presidensi Madras di India.\n" +
			"\n1807 23 desember : Thomas Parr dibunuh\n" +
			"\n1808 : Pembangunan monumen Thomas Parr\n"+
			"\n1818-1821 : Sir Thomas Stamford Raffles menjadi letnan gubernur di bengkulu, ia memiliki hubungan yang baik dengan pemimpin setempat sehingga sangat membantu biaya\noperasional mengatur daerah penduduk.\n" +
			"\n<size=20>Masa Penjajahan Belanda</size>\n"+
			"\n1825 : Penyerahan kekuasaan wilayah pesisir barat Sumatra dari tangan inggris ke belanda sesuai perjanjian Anglo-Dutch.\n" +
			"\n1850 : Pemasangan meriam di 4 menara di benteng\n" +
			"\n1938 : Soekarno diasingkan ke Bengkulu.\n"+
			"\n1940 : Pemugaran masjid Jamik dengan arsitektur buatan Soekarno.\n"+
			"\n1942 : Berakhirnya masa pengasingan Soekarno\n"+
			"\n1943 : belanda menyerahkan benteng  ke jepang\n" +
			"\n<size=20>Masa Kemerdekaan</size>\n"+
			"\n1946 : tentara indonesia memanfaatkan benteng sebagai markas.\n" +
			"\n1970 : benteng dikosongkan.\n" +
			"\n1977 : pemugaran benteng\n" +
			"\n" +
			footer + "\n");

		descriptions.Add("shaw", 
			"\nGeorge Thomas Shaw yang meninggal tanggal 25 April 1704." +
			"\nRichard Watts yang meninggal 17 Desember 1705. " +
			"\nHenry Starling yang meninggal pada bulan April 1744 dalam usia 25 tahun dan Capt. " +
			"\nJames Coney yang meninggal Februari 1737 dalam usia 36 tahun."+
			"\n" +
			footer + "\n");

		descriptions.Add("foto", 
			"\nFoto Keluarga Soekarno"+
			"\nBung karno berdiri di tengah" +
			"\nIbu Inggit duduk di deret tengah dua dari kanan" +
			"\nFatmawati duduk di deret bawah pertama dari kiri" +
			footer + "\n");

    }

	#endregion // CONSTRUCTOR

}
