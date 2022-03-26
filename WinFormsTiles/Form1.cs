using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryTiles;

namespace WinFormsTiles
{
    /// <summary>
    /// Класс формы
    /// задаёт работу формы
    /// </summary>
    public partial class Form1 : Form
    {
        Tile[] ArrTiles;
        int[] arrNumTiles;
        int index = 0;
        FileInfo[] File = ClassWorkForm1.arrJPG();
        double[] arrPrice;
        /// <summary>
        /// Запуск формы
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            //прорисовка кнопок
            ButtonCircle(buttonReference);
            ButtonCircle(buttonOK);
            ButtonCircle(buttonRefresh);
            ButtonCircle(buttonNext);
            ButtonCircle(buttonBack);
            ButtonCircle(buttonStart);
            comboBoxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;//блокировка ввода размера
            radioButtonSqM.Checked=true;
            InitializationForm1();
        }
        /// <summary>
        /// Округление кнопки
        /// </summary>
        /// <param name="buttonOK">кнопка, которую будем округлять</param>
        void ButtonCircle(Button buttonOK)
        {
            GraphicsPath gp = new GraphicsPath();
            Graphics g = CreateGraphics();
            // Создадим новый прямоугольник с размерами кнопки 
            Rectangle smallRectangle = buttonOK.ClientRectangle;
            // уменьшим размеры прямоугольника 
            smallRectangle.Inflate(-3, -3);
            // создадим эллипс, используя полученные размеры 
            gp.AddEllipse(smallRectangle);
            buttonOK.Region = new Region(gp);
            // рисуем окантовоку для круглой кнопки 
            g.DrawEllipse(new Pen(Color.Black, 1),
            buttonOK.Left + 1,
            buttonOK.Top + 1,
            buttonOK.Width - 3,
            buttonOK.Height - 3);
            //  освобождаем ресурсы
            g.Dispose();
        }
        /// <summary>
        /// Инициализация формы
        /// </summary>
        void InitializationForm1()
        {
            index = 0;
            ArrTiles = GenerateTiles.GenerateArrTiles(10);
            arrPrice = ClassWorkForm1.arrPriceTile(ArrTiles);
            arrNumTiles = ClassWorkForm1.arrNumTile(ArrTiles);
            DrawTiles(index);
            buttonBack.Visible = false;
            buttonNext.Visible = true;
            comboBoxSize.SelectedIndex = 0;
            groupBoxCreateSize.Visible = false;
            radioButtonSqM.Checked = true;
            textBoxM1.Text = "";
            textBoxM2.Text = "";
            textBoxLen.Text = "";
            textBoxW.Text = "";
            labelPrice.Text = "";
        }
        /// <summary>
        /// Кнопка перехода к следующей плитке
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNext_Click(object sender, EventArgs e)
        {
            index++;
            ArrTiles[index].length = 50;
            ArrTiles[index].width = 50;
            ArrTiles[index].price_packaging = arrPrice[index];
            CheckButton(index);
            DrawTiles(index);
            comboBoxSize.SelectedIndex = 0;
            groupBoxCreateSize.Visible = false;
            labelPrice.Text = "";
        }
        /// <summary>
        /// Проявление плитки
        /// </summary>
        /// <param name="index">индекс плитки</param>
        void DrawTiles(int index)
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Color.Black, 5);
            g.Clear(this.BackColor);
            int cs = ClassWorkForm1.MultiplierSizePictureBox(ArrTiles[index].width, ArrTiles[index].length);
            pictureBoxTiles.Image = new Bitmap(File[arrNumTiles[index]].FullName);//картинка плитки
            pictureBoxTiles.Size = new Size(int.Parse(ArrTiles[index].width.ToString()) * cs,
                int.Parse(ArrTiles[index].length.ToString()) * cs);//размер плитки
            labelInf.Location = new Point(pictureBoxTiles.Location.X + int.Parse(ArrTiles[index].width.ToString()) * cs + 25,
                pictureBoxTiles.Location.Y);//перемещение информации плитки
            labelInf.Text = ArrTiles[index].ToString();//информация
            labelCreateSize.Location = new Point(labelInf.Location.X, labelCreateSize.Location.Y);
            comboBoxSize.Location = new Point(labelCreateSize.Location.X + labelCreateSize.Size.Width, labelCreateSize.Location.Y);
            groupBoxCreateSize.Location = new Point(labelCreateSize.Location.X, labelCreateSize.Location.Y+ labelCreateSize.Size.Height+10);
            g.DrawRectangle(pen, new Rectangle(pictureBoxTiles.Location.X - 1, pictureBoxTiles.Location.Y - 1,//рамка вокруг плитки
                int.Parse(ArrTiles[index].width.ToString()) * cs + 2, int.Parse(ArrTiles[index].length.ToString()) * cs + 2));
        }
        /// <summary>
        /// Работа кнопок(перелистывание)
        /// </summary>
        /// <param name="index">индекс плитки</param>
        void CheckButton(int index)
        {
            if (index == 0)//кнопка "назад"
                buttonBack.Visible = false;
            else
                buttonBack.Visible = true;
            if (index == ArrTiles.Length - 1)//кнопка "вперёд"
                buttonNext.Visible = false;
            else
                buttonNext.Visible = true;
        }
        /// <summary>
        /// Кнопка перехода к предыдущей плитке
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBack_Click(object sender, EventArgs e)
        {
            index--;
            ArrTiles[index].length = 50;
            ArrTiles[index].width = 50;
            ArrTiles[index].price_packaging = arrPrice[index];
            CheckButton(index);
            DrawTiles(index);
            groupBoxCreateSize.Visible = false;
            labelPrice.Text = "";
        }
        /// <summary>
        /// Работа кнопки обновить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            InitializationForm1();
        }
        /// <summary>
        /// Работа комбобокса выбора размера плитки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSize.SelectedIndex == 0)
            {
                ArrTiles[index].width = 50;
                ArrTiles[index].length = 50;
                ArrTiles[index].price_packaging = ClassWorkForm1.GeneratedPriceTile(ArrTiles[index].width * ArrTiles[index].length, index,arrPrice);
                DrawTiles(index);
                groupBoxCreateSize.Visible = false;
            }
            if (comboBoxSize.SelectedIndex == 1)
            {
                ArrTiles[index].width = 45;
                ArrTiles[index].length = 45;
                ArrTiles[index].price_packaging = ClassWorkForm1.GeneratedPriceTile(ArrTiles[index].width * ArrTiles[index].length, index,arrPrice);
                DrawTiles(index);
                groupBoxCreateSize.Visible = false;
            }
            if (comboBoxSize.SelectedIndex == 2)
            {
                ArrTiles[index].width = 40;
                ArrTiles[index].length = 40;
                ArrTiles[index].price_packaging = ClassWorkForm1.GeneratedPriceTile(ArrTiles[index].width * ArrTiles[index].length, index, arrPrice);
                DrawTiles(index);
                groupBoxCreateSize.Visible = false;
            }
            if (comboBoxSize.SelectedIndex == 3)
            {
                ArrTiles[index].width = 35;
                ArrTiles[index].length = 35;
                ArrTiles[index].price_packaging = ClassWorkForm1.GeneratedPriceTile(ArrTiles[index].width * ArrTiles[index].length, index, arrPrice);
                DrawTiles(index);
                groupBoxCreateSize.Visible = false;
            }
            if (comboBoxSize.SelectedIndex == 4)
            {
                ArrTiles[index].width = 30;
                ArrTiles[index].length = 30;
                ArrTiles[index].price_packaging = ClassWorkForm1.GeneratedPriceTile(ArrTiles[index].width * ArrTiles[index].length, index, arrPrice);
                DrawTiles(index);
                groupBoxCreateSize.Visible = false;
            }
            if (comboBoxSize.SelectedIndex == 5)
            {
                ArrTiles[index].width = 25;
                ArrTiles[index].length = 25;
                ArrTiles[index].price_packaging = ClassWorkForm1.GeneratedPriceTile(ArrTiles[index].width * ArrTiles[index].length, index, arrPrice);
                DrawTiles(index);
                groupBoxCreateSize.Visible = false;
            }
            if (comboBoxSize.SelectedIndex == 6)
            {
                ArrTiles[index].width = 20;
                ArrTiles[index].length = 20;
                ArrTiles[index].price_packaging = ClassWorkForm1.GeneratedPriceTile(ArrTiles[index].width * ArrTiles[index].length, index, arrPrice);
                DrawTiles(index);
                groupBoxCreateSize.Visible = false;
            }
            if (comboBoxSize.SelectedIndex == 7)
                groupBoxCreateSize.Visible = true;
        }
        
        /// <summary>
        /// Кнопка изменения размера для пользователя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                labelPrice.Text = "";
                double l = double.Parse(textBoxLen.Text);
                double w = double.Parse(textBoxW.Text);
                if (CheckTextSize(l, w) && textBoxLen.BackColor != Color.Red && textBoxW.BackColor != Color.Red)
                {
                    ArrTiles[index].length = l;
                    ArrTiles[index].width = w;
                    ArrTiles[index].price_packaging = ClassWorkForm1.GeneratedPriceTile(ArrTiles[index].width * ArrTiles[index].length, index,arrPrice);
                    DrawTiles(index);
                }
                else
                    MessageBox.Show("Ввод не верного размера!\nМагазин не осуществляет продажу керамических плиток," +
                              " ширина или длина которых не входит в рамки диапозона: 12<=l<=80\n Смотрите ''Справку''.\n ", "Внимание!");
            }
            catch(Exception)
            {
                MessageBox.Show("Ввод неверного размера!\nМагазин не осуществляет продажу керамических плиток," +
                             " ширина или длина которых не входит в рамки диапозона: 12<=l<=80\n Смотрите ''Справку''.\n ", "Внимание!");
            }
        }
        /// <summary>
        /// Проверка вводимого размера плитки
        /// </summary>
        /// <param name="l">длина плитки</param>
        /// <param name="w">ширина плитки</param>
        /// <returns>true- если подходит под условие,false - если не подходит</returns>
        bool CheckTextSize(double l, double w)
        {
            if (l > 80 || l < 12 || w > 80 || w < 12)
                return false;
            return true;
        }
        /// <summary>
        /// Управление textBoxLen клавиатурой 
        /// Контроль ввода
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxLen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    if (sender.Equals(textBoxLen))
                        textBoxW.Focus();
                if (e.KeyChar == (char)Keys.Down)
                    if (sender.Equals(textBoxLen))
                        textBoxW.Focus();
                return;
            }
            if (!(e.KeyChar != ' ' && e.KeyChar >= '0' && e.KeyChar <= '9'))
            { e.Handled = true; }
        }
        /// <summary>
        /// Управление вводом textBoxLen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxLen_TextChanged(object sender, EventArgs e)
        {
            if (textBoxLen.Text != "")
                if (int.Parse(textBoxLen.Text) > 80 || int.Parse(textBoxLen.Text) < 12)
                    textBoxLen.BackColor = Color.Tomato;
                else
                    textBoxLen.BackColor = Color.White;
        }
        /// <summary>
        /// Управление textBoxW клавиатурой 
        /// Контроль ввода
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxW_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    if (sender.Equals(textBoxW))
                        buttonOK.Focus();
                if (e.KeyChar == (char)Keys.Up)
                    if (sender.Equals(textBoxW))
                        textBoxLen.Focus();
                return;
            }
            if (!(e.KeyChar != ' ' && e.KeyChar >= '0' && e.KeyChar <= '9'))
            { e.Handled = true; }
        }
        /// <summary>
        /// Управление вводом textBoxW
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxW_TextChanged(object sender, EventArgs e)
        {
            if (textBoxW.Text != "")
                if (int.Parse(textBoxW.Text) > 80 || int.Parse(textBoxW.Text) < 12)
                    textBoxW.BackColor = Color.Tomato;
                else
                    textBoxW.BackColor = Color.White;
        }
        /// <summary>
        /// Управление comboBoxSize кнопками
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxSize_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (Char.IsControl(e.KeyChar))
                {
                if (comboBoxSize.SelectedIndex == 7)
                    if (e.KeyChar == (char)Keys.Enter)
                        if (sender.Equals(comboBoxSize))
                            textBoxLen.Focus();
                            return;
                }
        }
        /// <summary>
        /// Кнопка рассчитать плитку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            double t;
            try
            {
                if (radioButtonSqM.Checked)
                {
                    textBoxM1.Text= textBoxM1.Text.Replace('.', ',');
                       t = double.Parse(textBoxM1.Text);
                    labelPrice.Text = "Количество упаковок этой плитки\n(размером: " + ArrTiles[index].width+" x "+ ArrTiles[index].length + " кв.см.) \nна пространство в " + t + " кв.м.: " + ArrTiles[index].NumberOfPackages(t) +
                 "\nЦена всех упаковок: " + ArrTiles[index].Price(ArrTiles[index].NumberOfPackages(t)) + " p.";
                }
                if (radioButtonM2.Checked)
                {
                    textBoxM1.Text=textBoxM1.Text.Replace('.', ',');
                    textBoxM2.Text= textBoxM2.Text.Replace('.', ',');
                    t = double.Parse(textBoxM1.Text);
                    double t1 = double.Parse(textBoxM2.Text);
                    labelPrice.Text = "Количество упаковок этой плитки\n(размером: " + ArrTiles[index].width + " x " + ArrTiles[index].length + " кв.см.)\nна пространство в " + t + " x " + t1 + " кв.м.: " + ArrTiles[index].NumberOfPackages(t*t1) +
                 "\nЦена всех упаковок: " + ArrTiles[index].Price(ArrTiles[index].NumberOfPackages(t* t1)) + " p.";
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Ввод неверного размера!\nВы неверно ввели размер пространства.\nl= "+textBoxM1.Text+"\nw= "+ textBoxM2.Text + "\n", "Внимание!");
            }
        }
        /// <summary>
        /// radioButtonSqM когда выбран
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonSqM_CheckedChanged(object sender, EventArgs e)
        {
            textBoxM1.Visible = true;
            textBoxM2.Visible = false;
            label4.Visible = false;
        }
        /// <summary>
        /// radioButtonM2 когда выбран
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonM2_CheckedChanged(object sender, EventArgs e)
        {
            textBoxM1.Visible = true;
            textBoxM2.Visible = true;
            label4.Visible = true;
        }
        /// <summary>
        /// textBoxM1 когда вводится
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxM1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
            {
                if(radioButtonSqM.Checked)
                if (e.KeyChar == (char)Keys.Enter)
                    if (sender.Equals(textBoxM1))
                        buttonStart.Focus();
                if(radioButtonM2.Checked)
                if (e.KeyChar == (char)Keys.Enter)
                    if (sender.Equals(textBoxM1))
                        textBoxM2.Focus();
                return;
            }
            if (!(e.KeyChar != ' ' && (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == ',' || e.KeyChar == '.'))
            { e.Handled = true; }
        }
        /// <summary>
        /// textBoxM2 когда вводится
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxM2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
            {
                if (radioButtonM2.Checked)
                    if (e.KeyChar == (char)Keys.Enter)
                        if (sender.Equals(textBoxM2))
                            buttonStart.Focus();
                return;
            }
            if (!(e.KeyChar != ' ' && (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == ',' || e.KeyChar == '.'))
            { e.Handled = true; }
        }
        /// <summary>
        /// Кнопка справки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReference_Click(object sender, EventArgs e)
        {
            string reference = "Работа магазина:\n"+
 "  * Не осуществляется продажа плиток нецелых размеров;\n"+
      "  * Размер вводимой плитки должен соответствовать диапазону:\n" +
"           12 <= l <= 80\n"+
  "Работа формы:\n"+
	"  * Ввод нового размера:\n"+
            "    - При вводе размера, который не входит в вышеуказанный диапазон, текстовое поле будет окрашиваться красным цветом;\n"+
            "    - Нельзя вводить буквы, пробел, точку, запятую и другие знаки;\n"+
            "    - Если пользователь нажмёт кнопку OK с неверно введённым размером, то появиться окно с ошибкой.\n"+
    "  * Ввод размера пространства:\n"+
            "    - Можно выбрать вид ввода(произведение или готовый метраж);\n"+
            "    - В текстовые поля ввода нельзя вводить буквы, пробел и все другие знаки, кроме точки и запятой.\n"+
    "  * По умолчанию размер плитки 50 х 50 кв.см;\n"+
    "  * По умолчанию генерируется массив из 10 плиток;\n" +
            "  * На 1 плитке кнопка «Назад» блокируется, на последней плитке кнопка «Далее» блокируется.\n";
            MessageBox.Show(reference, "Справка");
        }
    }
}
