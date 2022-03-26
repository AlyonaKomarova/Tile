using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Threading.Tasks;
using ClassLibraryTiles;

namespace WinFormsTiles
{

    /// <summary>
    /// Класс работы формы
    /// </summary>
    static class ClassWorkForm1
    {
        /// <summary>
        ///  Генерирование стоимости плиток
        /// в соответствии с размерами
        /// </summary>
        /// <param name="s">площадь плитки</param>
        /// <param name="index">индекс плитки</param>
        /// <param name="arrPrice">массив первоначальных цен</param>
        /// <returns>сгенерированная стоимость</returns>
        public static double GeneratedPriceTile(double s, int index, double[] arrPrice)
        {
            double price = arrPrice[index];
            if (s == 2500)
                return price;
            return Math.Round(price * (s / 2500), 2);
        }
        /// <summary>
        /// Массив первоначальных цен
        /// </summary>
        /// <param name="ArrTiles">массив плиток</param>
        /// <returns>массив цен</returns>
        public static double[] arrPriceTile(Tile [] ArrTiles)
        {
            double[] price = new double[ArrTiles.Length];
            for (int i = 0; i < price.Length; i++)
                price[i] = ArrTiles[i].price_packaging;
            return price;
        }
        /// <summary>
        /// Чтение картинок из каталога
        /// </summary>
        /// <returns>массив картинок</returns>
       public static FileInfo[] arrJPG()
        {
            DirectoryInfo Dir = new DirectoryInfo(Directory.GetCurrentDirectory());
            FileInfo[] Files = Dir.GetFiles("*.jpg");
            return Files;
        }
        /// <summary>
        /// Массив картинок для плиток
        /// </summary>
        /// <param name="ArrTiles">массив плиток</param>
        /// <returns>массив номеров картинок</returns>
        public static int[] arrNumTile(Tile[] ArrTiles)
        {
            int[] arr = new int[ArrTiles.Length];
            Random r = new Random();
            int i = 0;
            while (i < arr.Length)
            {
                int u = r.Next(0, 13);
                if (!Find(arr, u) || i > 13)
                {
                    arr[i] = u;
                    i++;
                }
            }
            return arr;
        }
        /// <summary>
        /// Проверка на наличие в массиве элемента
        /// </summary>
        /// <param name="arr">массив значение</param>
        /// <param name="n">значение, которое нужно проверить</param>
        /// <returns>true - элемент есть в массиве,false-элемента нет в массиве</returns>
       static bool Find(int[] arr, int n)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == n)
                    return true;
            return false;
        }
        /// <summary>
        /// Множитель для размера картинки
        /// </summary>
        /// <param name="l">длина плитки</param>
        /// <param name="w">ширина плитки</param>
        /// <returns>множитель</returns>
       public static int MultiplierSizePictureBox(double l, double w)
        {
            if (l > 50 || w > 50)
                return 3;
            else
                return 5;
        }
    }
}
