using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passaparola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        int SıraNo = 0, Dogru = 0, Yanlis = 0;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (SıraNo)
                {
                    case 1:
                        if (textBox1.Text == "Avrupa Birliği")
                        {
                            button2.BackColor = Color.Green;
                            Dogru++;
                            Lbldogru.Text = Dogru.ToString();
                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                            Yanlis++;
                            Lblyanlis.Text = Yanlis.ToString();
                        }
                    break;
                    case 2:
                        if (textBox1.Text == "Balıkesir")
                        {
                            button3.BackColor = Color.Green;
                            Dogru++;
                            Lbldogru.Text = Dogru.ToString();
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            Yanlis++;
                            Lblyanlis.Text = Yanlis.ToString();
                        }
                        break;
                    case 3:
                        if (textBox1.Text == "Cellat")
                        {
                            button4.BackColor = Color.Green;
                            Dogru++;
                            Lbldogru.Text = Dogru.ToString();
                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            Yanlis++;
                            Lblyanlis.Text = Yanlis.ToString();
                        }
                        break;
                    case 4:
                        if (textBox1.Text == "Dinamometre")
                        {
                            button5.BackColor = Color.Green;
                            Dogru++;
                            Lbldogru.Text = Dogru.ToString();
                        }
                        else
                        {
                            button5.BackColor = Color.Red;
                            Yanlis++;
                            Lblyanlis.Text = Yanlis.ToString();
                        }
                        break;
                    case 5:
                        if (textBox1.Text == "Erzurum")
                        {
                            button6.BackColor = Color.Green;
                            Dogru++;
                            Lbldogru.Text = Dogru.ToString();
                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            Yanlis++;
                            Lblyanlis.Text = Yanlis.ToString();
                        }
                        break;
                    case 6:
                        if (textBox1.Text == "Fırat nehri")
                        {
                            button7.BackColor = Color.Green;
                            Dogru++;
                            Lbldogru.Text = Dogru.ToString();
                        }
                        else
                        {
                            button7.BackColor = Color.Red;
                            Yanlis++;
                            Lblyanlis.Text = Yanlis.ToString();
                        }
                        break;
                    case 7:
                        if (textBox1.Text == "Galilio")
                        {
                            button8.BackColor = Color.Green;
                            Dogru++;
                            Lbldogru.Text = Dogru.ToString();
                        }
                        else
                        {
                            button8.BackColor = Color.Red;
                            Yanlis++;
                            Lblyanlis.Text = Yanlis.ToString();
                        }
                        break;
                    case 8:
                        if (textBox1.Text == "Harward üniversitesi")
                        {
                            button9.BackColor = Color.Green;
                            Dogru++;
                            Lbldogru.Text = Dogru.ToString();
                        }
                        else
                        {
                            button9.BackColor = Color.Red;
                            Yanlis++;
                            Lblyanlis.Text = Yanlis.ToString();
                        }
                        break;
                    case 9:
                        if (textBox1.Text == "İron man")
                        {
                            button10.BackColor = Color.Green;
                            Dogru++;
                            Lbldogru.Text = Dogru.ToString();
                        }
                        else
                        {
                            button10.BackColor = Color.Red;
                            Yanlis++;
                            Lblyanlis.Text = Yanlis.ToString();
                        }
                        break;
                    case 10:
                        if (textBox1.Text == "Jandarma")
                        {
                            button11.BackColor = Color.Green;
                            Dogru++;
                            Lbldogru.Text = Dogru.ToString();
                        }
                        else
                        {
                            button11.BackColor = Color.Red;
                            Yanlis++;
                            Lblyanlis.Text = Yanlis.ToString();
                        }
                        break;
                    case 11:
                        if (textBox1.Text == "Katır")
                        {
                            button12.BackColor = Color.Green;
                            Dogru++;
                            Lbldogru.Text = Dogru.ToString();
                        }
                        else
                        {
                            button12.BackColor = Color.Red;
                            Yanlis++;
                            Lblyanlis.Text = Yanlis.ToString();
                        }
                        break;
                    case 12:
                        if (textBox1.Text == "Lale")
                        {
                            button13.BackColor = Color.Green;
                            Dogru++;
                            Lbldogru.Text = Dogru.ToString();
                        }
                        else
                        {
                            button13.BackColor = Color.Red;
                            Yanlis++;
                            Lblyanlis.Text = Yanlis.ToString();
                        }
                        break;
                    case 13:
                        if (textBox1.Text == "Malatya")
                        {
                            button14.BackColor = Color.Green;
                            Dogru++;
                            Lbldogru.Text = Dogru.ToString();
                        }
                        else
                        {
                            button14.BackColor = Color.Red;
                            Yanlis++;
                            Lblyanlis.Text = Yanlis.ToString();
                        }
                        break;
                    case 14:
                        if (textBox1.Text == "Nijerya")
                        {
                            button15.BackColor = Color.Green;
                            Dogru++;
                            Lbldogru.Text = Dogru.ToString();
                        }
                        else
                        {
                            button15.BackColor = Color.Red;
                            Yanlis++;
                            Lblyanlis.Text = Yanlis.ToString();
                        }
                        break;
                    case 15:
                        if (textBox1.Text == "Osmaniye")
                        {
                            button16.BackColor = Color.Green;
                            Dogru++;
                            Lbldogru.Text = Dogru.ToString();
                        }
                        else
                        {
                            button16.BackColor = Color.Red;
                            Yanlis++;
                            Lblyanlis.Text = Yanlis.ToString();
                        }
                        break;
                    case 16:
                        if (textBox1.Text == "Paris")
                        {
                            button17.BackColor = Color.Green;
                            Dogru++;
                            Lbldogru.Text = Dogru.ToString();
                        }
                        else
                        {
                            button17.BackColor = Color.Red;
                            Yanlis++;
                            Lblyanlis.Text = Yanlis.ToString();
                        }
                        break;
                    case 17:
                        if (textBox1.Text == "Riyal")
                        {
                            button18.BackColor = Color.Green;
                            Dogru++;
                            Lbldogru.Text = Dogru.ToString();
                        }
                        else
                        {
                            button18.BackColor = Color.Red;
                            Yanlis++;
                            Lblyanlis.Text = Yanlis.ToString();
                        }
                        break;
                    case 18:
                        if (textBox1.Text == "Sakız")
                        {
                            button19.BackColor = Color.Green;
                            Dogru++;
                            Lbldogru.Text = Dogru.ToString();
                        }
                        else
                        {
                            button19.BackColor = Color.Red;
                            Yanlis++;
                            Lblyanlis.Text = Yanlis.ToString();
                        }
                        break;
                    case 19:
                        if (textBox1.Text == "Titanik")
                        {
                            button20.BackColor = Color.Green;
                            Dogru++;
                            Lbldogru.Text = Dogru.ToString();
                        }
                        else
                        {
                            button20.BackColor = Color.Red;
                            Yanlis++;
                            Lblyanlis.Text = Yanlis.ToString();
                        }
                        break;
                    case 20:
                        if (textBox1.Text == "Van")
                        {
                            button21.BackColor = Color.Green;
                            Dogru++;
                            Lbldogru.Text = Dogru.ToString();
                        }
                        else
                        {
                            button21.BackColor = Color.Red;
                            Yanlis++;
                            Lblyanlis.Text = Yanlis.ToString();
                        }
                        break;
                    case 21:
                        if (textBox1.Text == "Yaprak")
                        {
                            button22.BackColor = Color.Green;
                            Dogru++;
                            Lbldogru.Text = Dogru.ToString();
                        }
                        else
                        {
                            button22.BackColor = Color.Red;
                            Yanlis++;
                            Lblyanlis.Text = Yanlis.ToString();
                        }
                        break;
                    case 22:
                        if (textBox1.Text == "Zeytin")
                        {
                            button1.BackColor = Color.Green;
                            Dogru++;
                            Lbldogru.Text = Dogru.ToString();
                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            Yanlis++;
                            Lblyanlis.Text = Yanlis.ToString();
                        }
                        break;
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { 
            linkLabel1.Text = "SONRAKİ";
            SıraNo++;
         
           
           
            this.Text = SıraNo.ToString();

            if (SıraNo == 1)
            {
                richTextBox1.Text = "27 üye ülkeden oluşan ve toprakları büyük ölçüde Avrupa kıtasında bulunan siyasi ve ekonomik bir örgütlenme olan topluluğun adı nedir?";
                button2.BackColor = Color.Yellow;

            }
            if (SıraNo == 2)
            {
                richTextBox1.Text = "Türkiye Cumhuriyeti'nin Marmara Bölgesi'nin Güney Marmara Bölümü'nde, topraklarının bir kısmı ise Ege Bölgesi'nde yer alan, hem Marmara hem de Ege Denizi'ne kıyısı bulunan bir il?. ";
                button3.BackColor = Color.Yellow;

            }
            if (SıraNo == 3)
            {
                richTextBox1.Text = "Arapçada 'Kırbaçla Vurmak' anlamına gelen 'Celd' kökünden türeyen kelime nedir?.";
                button4.BackColor = Color.Yellow;

            }
            if (SıraNo == 4)
            {
                richTextBox1.Text = "Cisimlerin kuvvetlerini ölçmede kullanılan ölçü aleti?";
                button5.BackColor = Color.Yellow;

            }
            if (SıraNo == 5)
            {
                richTextBox1.Text = " Türkiye'nin bir ili ve en kalabalık yirmi dokuzuncu şehridir ve evliyalar beldesi olarak bilinir?";
                button6.BackColor = Color.Yellow;

            }
            if (SıraNo == 6)
            {
                richTextBox1.Text = " Güneybatı Asya'nın en uzun ırmağı?";
                button7.BackColor = Color.Yellow;

            }
            if (SıraNo == 7)
            {
                richTextBox1.Text = "İtalyan astronom, fizikçi, mühendis, filozof ve matematikçi. Rönesans'ın bilimsel devrimine büyük katkıda bulunan bu bilim insanına “gözlemsel astronominin babası”, “modern fiziğin babası” ve “bilimin babası” gibi isimler takılmıştır. Bu bilim adamı kimdir?";
                button8.BackColor = Color.Yellow;

            }
            if (SıraNo == 8)
            {
                richTextBox1.Text = " Amerika Birleşik Devletleri'nde Massachusetts eyaletinin Cambridge şehrinde bulunan ve alanında dünyanın en önde gelen üniversitelerinden biri olarak tanınan özel bir yükseköğretim kurumudur?";
                button9.BackColor = Color.Yellow;

            }
            if (SıraNo == 9)
            {
                richTextBox1.Text = "2008 yapımı, Marvel Comics Şirketi’nin yayımladığı ilk Marvel Sinematik Evreni filmidir. Başrolünde Robert Downey Jr oynamıştır?.";
                button10.BackColor = Color.Yellow;

            }
            if (SıraNo == 10)
            {
                richTextBox1.Text = "Türkiye'de il ve ilçe belediye sınırları dışında kalan veya polis teşkilatı bulunmayan yerler ile Sahil Güvenlik Teşkilatı bulunmayan kıyı, deniz ve sahillerde görev yapan silahlı genel kolluk kuvvetidir.?.";
                button11.BackColor = Color.Yellow;

            }
            if (SıraNo == 11)
            {
                richTextBox1.Text = "Erkek eşek ile dişi atın çiftleşmesiyle meydana gelen ve çoğu kez kısır olan melez hayvandır.?";
                button12.BackColor = Color.Yellow;

            }
            if (SıraNo == 12)
            {
                richTextBox1.Text = " zambakgiller familyasından Tulipa cinsini oluşturan güzel çiçekleri ile süs bitkisi olarak yetiştirilen, soğanlı, çok yıllık otsu bitki türlerinin ortak adı?";
                button13.BackColor = Color.Yellow;

            }
            if (SıraNo == 13)
            {
                richTextBox1.Text = "Kayısı ile ünlü ilimiz?";
                button14.BackColor = Color.Yellow;

            }
            if (SıraNo == 14)
            {
                richTextBox1.Text = "Başkenti abuja olan afrika kıtasının batısında yer alan ülke?.";
                button15.BackColor = Color.Yellow;

            }
            if (SıraNo == 15)
            {
                richTextBox1.Text = "İliyle ilçesi aynı isimde olan ilimiz hangisidir?.";
                button16.BackColor = Color.Yellow;

            }
            if (SıraNo == 16)
            {
                richTextBox1.Text = "Fransanın başkenti neresidir?.";
                button17.BackColor = Color.Yellow;

            }
            if (SıraNo == 17)
            {
                richTextBox1.Text = "Suudi Arabistan'da kullanılan resmî para birimidir?.";
                button18.BackColor = Color.Yellow;

            }
            if (SıraNo == 18)
            {
                richTextBox1.Text = "Manilkara zapota adlı ağaçtan elde edilen hammadesi lateks olup işlendikten sonra bizlere sunulan üründür?";
                button19.BackColor = Color.Yellow;

            }
            if (SıraNo == 19)
            {
                richTextBox1.Text = "White Star Line şirketine ait Olympic sınıfı bir transatlantik yolcu gemisi olup 15 Nisan 1912 gecesi daha ilk seferinde bir buz dağına çarpmış ve yaklaşık iki saat kırk dakika içinde Kuzey Atlantik'in buzlu sularına gömülen yolcu gemisinin ismi?";
                button20.BackColor = Color.Yellow;

            }
            if (SıraNo == 20)
            {
                richTextBox1.Text = "Akdamar kilisesiyle meşhur ilimiz?";
                button21.BackColor = Color.Yellow;

            }
            if (SıraNo == 21)
            {
                richTextBox1.Text = " Bitkilerde fotosentez, transpirasyon ve solunumun gerçekleştiği temel organ hangisidir?.";
                button22.BackColor = Color.Yellow;

            }
            if (SıraNo == 22)
            {
                richTextBox1.Text = " Zeytingiller familyasından meyvesi yenen Akdeniz iklimine özgü bir ağaç türü?";
                button1.BackColor = Color.Yellow;
              

            }
            if (SıraNo == 23)
            {
                button23.Text = "Doğru Sayınız :" + Dogru.ToString() + "    " + "Yanlış Sayınız :" + Yanlis.ToString();


            }
            if (SıraNo >= 24)
            {
                MessageBox.Show("Yarışma bitmiştir.");
                SıraNo = 0;
            }
        }

    }
}
