namespace Ref_Out_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Methods
            //int[] arr2 = { -10, 20, 30, -20, -40,-60 };
            //NegativToPositiv(ref arr2);
            #endregion
            //PolindromeOrNot("ana");

            //Repeat("SAlam!", 5);
            //RemoveRepeatedChars("nurane");
            //Reverse("salam");
            //SkipGaps("Code Academyde bir nece proqramlasdirma sahesi tedris olunur");
            //First4Letter("saaalllaaamm");
            int[] arr1 = { 10, 20, 12, 32, 45, 17 };
            //int a = 10;
            //int b = 20;
            //a=b;
            //Console.WriteLine(b);

            BubbleSort(arr1);


        }

        #region Task_1
        static void NegativToPositiv(ref int[] arr2)
        {

            for (int i = 0; i < arr2.Length; i++)
            {
                if (arr2[i] < 0)
                {
                    arr2[i] = -arr2[i];
                }
                Console.WriteLine(arr2[i]);
            }

            //int tipindən bir array olur içində müsbət və mənfi ədədlər olur elə bir method yazın ki, bu array-i
            //parametr olaraq qəbul etsin və
            //qəbul etdiyi array-in əvvəlcədən assign olunması məcburi olsun daha sonra içindəki mənfi ədədləri
            //müsbətə çevirib həmin array-i geriyə qaytarsın

        }
        #endregion
        #region Task_2
        //Repeat deyə bir method olsun və iki parametr qəbul etsin biri "word" digəri "count" yəni bu şəkildə
        //"Repeat(string word, int count)" bu method göndərilən word-ü göndərilən count qədər yan-yana yazdırıb
        //geri qaytarsın. Məsələn: Repeat("Ha!") //Ha! Repeat("Ha!", 2) //Ha!Ha! Repeat("Ha!", 3) //Ha!Ha!Ha!
        static void Repeat(string word, int count)
        {
            string newword = word;

            for (int i = 1; i < count; i++)
            {

                word = word + newword; //haha// 


            }
            Console.WriteLine(word);
        }
        #endregion
        #region Task_3
        //Verilmiş stringin Palindrome olub olmamağını yoxlayın.
        static void PolindromeOrNot(string input)
        {
            string empty = string.Empty;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                empty += input[i];
            }
            if (empty == input)
            {
                Console.WriteLine("Daxil Edilmis String Polindromdur!");
            }
            else
            {
                Console.WriteLine("Daxil Edilmis String Polindrom deyil!");
            }
        }
        #endregion
        #region Task_4
        //Verilmiş stringin içərisindəki təkrarlanan karakterləri silin.
        static void RemoveRepeatedChars(string input)
        {
            string empty = string.Empty;
            char c;
            foreach (var item in input) //salam // s
            {
                int count = 0;
                c = item;
                for (int i = 0; i < input.Length; i++)
                {
                    if (item == input[i])
                    {
                        count++;
                    }
                }
                if (count < 2)
                {
                    empty = empty + c;
                }
            }
            Console.WriteLine(empty);


        }
        #endregion
        #region Task_5
        //Verilmiş stringi tərsinə yazdırın.
        static void Reverse(string input)
        {
            string empty = string.Empty;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                empty = empty + input[i];
            }
            Console.WriteLine(empty);
        }
        #endregion
        // TAM BITMEYIB-6
        #region Task_6
        //Verilmiş string bir mətnin içərisindəki boşluqlara qədər olan sözdəri ayrılıqda yazın.
        // Code Academyde bir nece proqramlasdirma sahesi tedris olunur.

        static void SkipGaps(string input)
        {
            string empty = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                empty = empty + input[i];

                if (input[i] == ' ')
                {
                    continue;
                }


            }
            Console.WriteLine(empty);

        }
        #endregion
        #region Task_7
        //Verilmiş arrayı bubble sort istifadə edərək sort edin.
        static void BubbleSort( int[] arr)
        {
            //int[] arr1 = { 10, 20, 12, 32, 45, 17 }; //10,12,17,20,32,45
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int eded = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1]= eded;
                        Console.WriteLine(eded);
                    }
                }

            }


        }
        #endregion
        #region Task_8
        //Verilmiş strigin ilk 4 hərfini ekrana yazdırın.
        static void First4Letter(string input)
        {
            string empty = string.Empty;
            for (int i = 0; i < 4; i++)
            {
                empty = empty + input[i];
            }
            Console.WriteLine(empty);
        }

        #endregion


    }
}