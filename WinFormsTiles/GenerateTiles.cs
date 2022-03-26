using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using ClassLibraryTiles;

namespace WinFormsTiles
{
    /// <summary>
    /// Класс генерирования массива плиток
    /// </summary>
    static class GenerateTiles
    {
        static Random r = new Random();
        /// <summary>
        /// Генерирование бренда
        /// </summary>
        /// <returns>бренд</returns>
        static Brand GenerateBrand()
        {
            return (Brand)r.Next(0, 6);
        }
        /// <summary>
        /// Генерирование цены
        /// </summary>
        /// <param name="k">кол-во плиток в упаковке</param>
        /// <returns>цена</returns>
        static double GeneratePrice(int k)
        {
            return k *0.5* r.Next(150, 500);
        }
        /// <summary>
        /// Генерирование кол-ва штук в упаковке
        /// </summary>
        /// <returns>кол-во плиток</returns>
        static int GenerateQuantity()
        {
            return r.Next(10, 25);
        }
        /// <summary>
        /// Генерирование массива плиток
        /// </summary>
        /// <param name="len">длина массива</param>
        /// <returns>массив плиток длиной len</returns>
        public static Tile[] GenerateArrTiles(int len)
        {
            Tile[] arr = new Tile[len];
            for(int i = 0;i<len;i++)
            {
                int k = GenerateQuantity();
                double price = GeneratePrice(k);
                    arr[i] = new Tile(GenerateBrand(), 50, 50, price, k);
            }
            return arr;
        }

    }
}
