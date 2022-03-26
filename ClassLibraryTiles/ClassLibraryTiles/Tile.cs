using System;

namespace ClassLibraryTiles
{
    /// <summary>
    /// Класс "Плитка"
    /// Помогает рассчитать 
    /// количество упаковок плиток на пространство 
    /// </summary>
    public class Tile
    {
        Brand brand;//бренд плитки
public double width, length, price_packaging;//ширина,длина,цена упаковки
       public int quantity_packaging;//кол-во плиток в упаковке
        /// <summary>
        /// Конструктор класса 
        /// </summary>
        /// <param name="brand">бренд</param>
        /// <param name="width">ширина</param>
        /// <param name="length">длина</param>
        /// <param name="price_packaging">цена упаковки</param>
        /// <param name="quantity_packaging">количество плиток в упаковке</param>
        public Tile(Brand brand, double width, double length, double price_packaging,
        int quantity_packaging)
        {
            this.brand = brand;
            this.width = width;
            this.length = length;
            this.price_packaging = price_packaging;
            this.quantity_packaging = quantity_packaging;
        }
        /// <summary>
        /// Вывод информации о плитке
        /// </summary>
        /// <returns>Строка со всей информацией о плитке</returns>
        public override string ToString()
        {
            string res = "Кафельная плитка " + brand.ToString() +
                "\nРазмер: " + length + " x " + width +
                " кв.см.\nВ 1 упаковке "+ Math.Round(HowMetersInPackage(),3) + " кв.м.\nЦена за упаковку (" + quantity_packaging + " шт) : " + price_packaging + " р.";
            return res ;
        }
        /// <summary>
        /// Рассчитывает количество кв.м. в 1 упаковке
        /// </summary>
        /// <returns>количество кв.м. в 1 упаковке</returns>
       private double HowMetersInPackage()
        {
            return (width / 100 * length / 100) * quantity_packaging;
        }
        /// <summary>
        /// Рассчитывает количество упаковок на пространство
        /// </summary>
        /// <param name="square">площадь пространства в кв.м.</param>
        /// <returns>количество упаковок на пространство</returns>
        public int NumberOfPackages(double square)
        {
            double res = square / HowMetersInPackage();
            if (square % HowMetersInPackage() == 0)
                return int.Parse(res.ToString());
            else
                return int.Parse(Math.Truncate(res).ToString()) + 1;
        }
        /// <summary>
        /// Рассчитывает цену за все упаковки
        /// </summary>
        /// <param name="packages">количество упаковок</param>
        /// <returns>Цена за все упаковки</returns>
        public double Price(int packages)
        {
            return Math.Round(packages * price_packaging,2);
        }
    }
    /// <summary>
    /// Перечисление брендов
    /// </summary>
   public enum Brand {ARTENS =0,AZORI =1,BELMAR = 2,CULTO = 3, ESTIMA=4,MAINZU=5 };
}
