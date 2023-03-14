using System.Text.RegularExpressions;

namespace JetlinkChallengeAlgorithm.Helper
{
    public class ConvertHelper
    {
        public static string ConvertToNumber(string input)
        {
            try
            {
                input = input.Trim(); // gelen değerin başında veya sonunda olan boşluklar temizlenir.
                string output = input; // gelen değeri output olarak ele arıyoruz ardından bu output string ifadesinde sayısal stringler yerine önce * karakteri atacağız ardından bu kelimeden sonra sayısal bir string yazmıyor ise buraya sayısal karşılığı yazılacak
                string[] tempdizi = input.ToLower().Split(' '); // gelen ifade önce boşluk ile ayrılarak yeni bir diziye atılır. Bu dizinin her index'i daha sonra harf harf incelenecektir.

                string[] inputValues = input.Split(' '); // girilen text ' ' ile ayrılarak yeni bir string dizisi oluşturuluyor.
                double total = 0; // sayı hesaplama totali
                int control = 0; // total çarpan değeri için

                string pattern = @"\*"; // regex'in kuralı
                string patternForSpace = "\\s+";
                Regex regex = new Regex(pattern); // her bir sayı ifadesi bulunduktan sonra yerine yıldız koyuluyor. Daha sonra Regex ile bunlar düzenli hale getiriliyor.

                string subLetter;
                string[] notincluedetxtnumberlist = tempdizi.Except(txtNumberList.Keys.ToList()).ToArray();
                // Bu dizi temparray'de yer alana ancak txtNumberList içerisinde yer almayan değerleri notincluedetxtnumberlist adlı diziye ekler.

                double sayi = 0;
                foreach (var item in inputValues)
                {
                    for (int i = 0, k = 0; i < item.Length; i++)
                    {
                        if (k + (i + 1) <= item.Length)
                            subLetter = item.Substring(k, i + 1).Trim();
                        else
                            subLetter = item.Substring(k, item.Length - i - 1).Trim();

                        string subLetterLowerCase = subLetter.ToLower();
                        if (notincluedetxtnumberlist.Contains(subLetterLowerCase))
                        {
                            // Bir sonraki kelime notincluedetxtnumberlist içerisinde var ise * yerine total basılıyor.

                            if (double.TryParse(subLetterLowerCase, out sayi)) //subLetterLowerCase değeri double'a çevirilebiliyorsa total sayısıyla gerekli işleme girer
                            {
                                control++;
                                if (sayi >= 100)
                                {
                                    if (control == 1)
                                    {
                                        total = 1;
                                    }
                                    total *= sayi;
                                }
                                else
                                {
                                    total += sayi;
                                }
                                output = output.Replace(subLetter, "*").Trim();

                            }
                            else
                            {
                                output = regex.Replace(output, match =>
                                {
                                    if (match.Index == output.IndexOf("*"))
                                        return total.ToString(); // yıldızlardan ilk index'e basılıyor.
                                    else
                                        return null;
                                });
                                total = 0; control = 0;
                            }
                        }
                        else if (txtNumberList.ContainsKey(subLetterLowerCase))
                        {
                            k = i + 1;
                            control++;
                            if (txtNumberList[subLetterLowerCase] >= 100)
                            {
                                if (control == 1)
                                {
                                    // eğer text'in ilk kelimesi 99 dan büyükse çarpım işlemi yapacağı için çarpan 1 yapılır
                                    total = 1;
                                }
                                total *= txtNumberList[subLetterLowerCase];
                            }
                            else
                            {
                                total += txtNumberList[subLetterLowerCase];
                            }

                            output = output.Replace(subLetter, "*").Trim();
                        }
                    }
                }
                string result = Regex.Replace(output, patternForSpace, " ").Trim(); // kelimeler arasındaki fazla boşluklar temizlenir.
                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        private static readonly Dictionary<string, double> txtNumberList = new Dictionary<string, double>
    {
        {"sıfır", 0},
        {"bir", 1},
        {"iki", 2},
        {"üç", 3},
        {"dört", 4},
        {"beş", 5},
        {"altı", 6},
        {"yedi", 7},
        {"sekiz", 8},
        {"dokuz", 9},
        {"on", 10},
        {"yirmi", 20},
        {"otuz", 30},
        {"kırk", 40},
        {"elli", 50},
        {"altmış", 60},
        {"yetmiş", 70},
        {"seksen", 80},
        {"doksan", 90},
        {"yüz", 100},
        {"bin", 1000},
        {"milyon", 1000000},
        {"milyar", 1000000000},
        {"katrilyon", 1000000000000000 },
    };

        #region Note
        /* Örnek : Elli kelimesi için;

                  Önce substring olarak sırasıyla E , El , Ell , Elli şeklinde incelenecek.
                  Bunun sebebi birleşik bir harf var ise o indexte arama durdurulacak ve tekrar yeni substringler oluşturulacak.

            Örnek : onaltıda kelimesi için;

                Önce o , on => 10  Daha sonra yeni substring oluşturulur. a , al , alt, altı => 6 , yeni substring d , da ve kelime biter

            Sonuç : 16da şeklinde olur.

        */
        #endregion
    }
}