///Сапер в темной теме.
///Дизайн и разработка: Дронов Сергей, Одесса (пока еще Украина), 26 март 2024
///Разрешаю свободно пользоваться этой программой и ее код кому хочется и как хочется, исключая продажу.
///Разрешаю свободно распостранять эту программу и ее код.
///Запрещаю брать деньги за эту программу и ее код.
using System.Drawing.Text;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Saper
{
    public partial class Form1 : Form
    {
        PictureBox[,] pole = new PictureBox[100, 100];
        int[,] matrix = new int[100, 100];
        //массив для проверки клетки вокруг
        List<int> wheelX = new List<int>() { -1, 0, 1, 1, -1, 1, 0, -1 };
        List<int> wheelY = new List<int>() { -1, -1, -1, 0, 0, 1, 1, 1 };
        const int bomb = 99;
        int X;
        int Y;//конец глобальных переменных
        int numberOfMines;//количество мин
        int bombCells;//количество НЕоткрытых клеток
        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBoxMouseClick(object sender, MouseEventArgs e)
        {
            var pictureBox = (PictureBox)sender;
            if (pictureBox != null)
            {//узнаем координаты, в какую клетку мы нажали
                string tex = pictureBox.Tag.ToString();
                string xs = "";
                int x1 = 0, y1 = 0;
                for (int i = 0; i < tex.Length; i++)
                {//не хотел возиться с regex, все просто и понятно, как напильник
                    if (char.IsDigit(tex[i]))
                    {
                        xs = xs + tex[i];
                    }
                    if (char.IsLetter(tex[i]))
                    {
                        x1 = Convert.ToUInt16(xs);
                        xs = "";
                    }
                }
                y1 = Convert.ToUInt16(xs);
                //x1, y1 - это наши координаты
                if (e.Button == MouseButtons.Right)
                {
                    if (pole[x1, y1].Image == pictureBoxZero.Image)
                    {
                        pole[x1, y1].Image = pictureBoxFlag.Image;
                        numberOfMines--;
                        labelNumMines.Text = "Осталось мин: " + numberOfMines;
                    }
                    else if (pole[x1, y1].Image == pictureBoxFlag.Image)
                    {
                        pole[x1, y1].Image = pictureBoxZero.Image;
                        numberOfMines++;
                        labelNumMines.Text = "Осталось мин: " + numberOfMines;
                    }
                    checkForVictory();
                }
                if (e.Button == MouseButtons.Left)
                {
                    if (pole[x1, y1].Image == pictureBoxFlag.Image) return;//нажатие левой кнопкой на флаг ИГНОРИРУЕМ
                    draw_a_Number(x1, y1);//рисуем цифры 1-8

                    if (matrix[x1, y1] == bomb)
                    {
                        labelNumMines.Text = "Game Over";
                        for (int ix = 0; ix < X; ix++)
                        {
                            for (int jy = 0; jy < Y; jy++)
                            {
                                if (matrix[ix, jy] == bomb)
                                {
                                    pole[ix, jy].Image = pictureBoxMine.Image;//посмотреть, где "лежат" мины
                                }
                            }
                        }
                        buttonReturnToMenu.Visible = true;
                        return;
                    }
                    //обработка пустых клеток:показываем их 
                    //и граничащие с цифрами
                    if (matrix[x1, y1] == 0)//начинаем автоочистку поля до границ с цифрами
                    {
                        pole[x1, y1].Image = pictureBoxOpen.Image;
                        int xx;//позиция по горизонтали
                        int yy;//позиция по вертикали
                        int ch = 0;//счетчик найденных пустых клеток
                        List<int> coordX = new List<int>();//вносим сюда все координаты граничащих
                        List<int> coordY = new List<int>();//пустых клеток
                        coordX.Add(x1);
                        coordY.Add(y1);
                        for (int i = 0; i < 8; i++)//пробегаем вокруг точки
                        {
                            xx = x1 + wheelX[i];
                            yy = y1 + wheelY[i];
                            if (xx == -1 | yy == -1 | xx == X | yy == Y) goto detour1;//за границу не выходим!
                            if (matrix[xx, yy] == 0 & pole[xx, yy].Image == pictureBoxZero.Image)
                            {//нашли рядом пустую клетку С НЕЗАКРАШЕННЫМ ПОЛЕМ: заносим коорд. в список Х и Y
                                ch++;
                                coordX.Add(xx);
                                coordY.Add(yy);
                                pole[xx, yy].Image = pictureBoxOpen.Image;

                            }
                            else
                            {//если не пустая,то значит там цифра
                                draw_a_Number(xx, yy);
                            }
                        detour1: xx++;//оператор-заглушка, ни на что не влияет
                        }
                        //теперь открываем все граничащие пустые клетки
                        for (int j = 0; j < coordX.Count; j++)
                        {
                            for (int i = 0; i < 8; i++)//пробегаем вокруг точки
                            {
                                xx = coordX[j] + wheelX[i];
                                yy = coordY[j] + wheelY[i];
                                if (xx == -1 | yy == -1 | xx == X | yy == Y) goto detour2;//за границу не выходим!
                                if (matrix[xx, yy] == 0 & pole[xx, yy].Image == pictureBoxZero.Image)
                                {//нашли рядом пустую клетку С НЕЗАКРАШЕННЫМ ПОЛЕМ: заносим коорд. в список Х и Y
                                    ch++;
                                    coordX.Add(xx);
                                    coordY.Add(yy);
                                    pole[xx, yy].Image = pictureBoxOpen.Image;

                                }
                                else
                                {//если не пустая,то значит там цифра
                                    draw_a_Number(xx, yy);

                                }
                            detour2: xx++;//оператор-заглушка, ни на что не влияет
                            }
                        }
                        checkForVictory();
                    }
                }
            }
        }
        void checkForVictory()
        {
            bombCells = 0;
            for (int ii = 0; ii < X; ii++)
            {
                for (int jj = 0; jj < Y; jj++)
                {
                    if (pole[ii, jj].Image == pictureBoxZero.Image | pole[ii, jj].Image == pictureBoxFlag.Image)
                    {
                        bombCells++;
                    }
                }
            }
            if (bombCells == trackBarBomb.Value)
            {
                labelNumMines.Text = "Победа!";
                buttonReturnToMenu.Visible = true;
            }
        }
        void draw_a_Number(int i, int j)
        {
            switch (matrix[i, j])
            {
                case 1:
                    pole[i, j].Image = pictureBox1.Image;
                    break;
                case 2:
                    pole[i, j].Image = pictureBox2.Image;
                    break;
                case 3:
                    pole[i, j].Image = pictureBox3.Image;
                    break;
                case 4:
                    pole[i, j].Image = pictureBox4.Image;
                    break;
                case 5:
                    pole[i, j].Image = pictureBox5.Image;
                    break;
                case 6:
                    pole[i, j].Image = pictureBox6.Image;
                    break;
                case 7:
                    pole[i, j].Image = pictureBox7.Image;
                    break;
                case 8:
                    pole[i, j].Image = pictureBox8.Image;
                    break;
            }
            checkForVictory();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            labelX.Text = trackBarX.Value + " - количество клеток по горизонтали";
            labelY.Text = trackBarY.Value + " - количество клеток по вертикали";
            labelB.Text = trackBarBomb.Value + " - количество мин. Оптимально:182";
        }
        private static Array ResizeArray(Array arr, int[] newSizes)
        {//https://learn.microsoft.com/ru-ru/dotnet/api/system.array.resize?view=net-7.0
            if (newSizes.Length != arr.Rank)
                throw new ArgumentException("arr must have the same number of dimensions " +
                                            "as there are elements in newSizes", "newSizes");

            var temp = Array.CreateInstance(arr.GetType().GetElementType(), newSizes);
            int length = arr.Length <= temp.Length ? arr.Length : temp.Length;
            Array.ConstrainedCopy(arr, 0, temp, 0, length);
            return temp;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                panel1.Top = this.Height / 2 - panel1.Height / 2;
                panel1.Left = this.Width / 2 - panel1.Width / 2;
            }
            else
            {
                panel1.Top = 0;
                panel1.Left = 0;
            }
        }

        private void buttonStart_MouseClick(object sender, MouseEventArgs e)
        {
            X = trackBarX.Value;
            Y = trackBarY.Value;
            numberOfMines = trackBarBomb.Value;
            if ((X * Y) <= numberOfMines) return;//клеток поля не хватит для расстановки мин
            pole = (PictureBox[,])ResizeArray(pole, new int[] { X, Y });
            matrix = (int[,])ResizeArray(matrix, new int[] { X, Y });
            for (int i = 0; i < X; i++)
            {
                for (int j = 0; j < Y; j++)
                {
                    matrix[i, j] = 0;
                }
            }


            panel1.Visible = false;
            labelNumMines.Text = "Осталось мин: " + numberOfMines;
            labelNumMines.Visible = true;
            int otstupX = 20;
            int otstupY = 50;
            for (int i = 0; i < X; i++)
            {
                for (int j = 0; j < Y; j++)
                {
                    pole[i, j] = new PictureBox();
                    pole[i, j].Size = new Size(30, 30);
                    pole[i, j].Location = new Point(otstupX + ((pole[i, j].Width + 1) * i), otstupY + ((pole[i, j].Height + 1) * j));
                    pole[i, j].BorderStyle = BorderStyle.FixedSingle;
                    pole[i, j].Image = pictureBoxZero.Image;
                    pole[i, j].Tag = i + "w" + j;
                    pole[i, j].MouseClick += PictureBoxMouseClick;
                    this.Controls.Add(pole[i, j]);
                }
            }
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.Size = new Size(((pole[X - 1, Y - 1].Width + 1) * X), otstupY * 2 + ((pole[X - 1, Y - 1].Height + 1) * Y));
            }
            //расставляем мины в массиве
            Random rand = new Random();
            for (int i = 0; i < numberOfMines; i++)
            {
            again: int x1 = rand.Next(0, X);//я знаю,что это не лучший способ получения случайного числа
                int y1 = rand.Next(0, Y);//но решил не заморачиваться
                if (matrix[x1, y1] == bomb) goto again;
                else
                {
                    matrix[x1, y1] = bomb;
                    //pole[x1, y1].Image = pictureBoxMine.Image;//посмотреть, где "лежат" мины//отладка
                }
            }
            //подсчитываем для каждой клетки количество мин вокруг
            int ch = 0;//счетчик мин вокруг
            int xx = 0;//позиция по горизонтали
            int yy = 0;//позиция по вертикали

            for (int i = 0; i < X; i++)
            {
                for (int j = 0; j < Y; j++)
                {
                    if (matrix[i, j] == bomb) goto vihod;//в клетке мина-считать ничего не нужно
                    //вместо "goto vihod" ставить "break" НЕЛЬЗЯ!!! 
                    //из-за "break" ломается цикл и неправильно считаются мины!!!
                    ch = 0;//счетчик мин
                    //три клетки сверху позиции
                    //   ххх
                    //    о
                    xx = i - 1;
                    yy = j - 1;
                    if (xx == -1 | yy == -1) goto a1;
                    if (matrix[xx, yy] == bomb) ch++;

                    a1: xx = i;
                    yy = j - 1;
                    if (yy == -1) goto a2;
                    if (matrix[xx, yy] == bomb) ch++;

                    a2: xx = i + 1;
                    yy = j - 1;
                    if (xx == X | yy == -1) goto a3;
                    if (matrix[xx, yy] == bomb) ch++;
                    // клетки слева и справа
                    //   хох
                    a3: xx = i - 1;
                    yy = j;
                    if (xx == -1) goto a4;
                    if (matrix[xx, yy] == bomb) ch++;

                    a4: xx = i + 1;
                    yy = j;
                    if (xx == X) goto a5;
                    if (matrix[xx, yy] == bomb) ch++;
                    //три клетки ниже позиции
                    //     о
                    //    ххх
                    a5: xx = i - 1;
                    yy = j + 1;
                    if (xx == -1 | yy == Y) goto a6;
                    if (matrix[xx, yy] == bomb) ch++;

                    a6: xx = i;
                    yy = j + 1;
                    if (yy == Y) goto a7;
                    if (matrix[xx, yy] == bomb) ch++;

                    a7: xx = i + 1;
                    yy = j + 1;
                    if (xx == X | yy == Y) goto a8;
                    if (matrix[xx, yy] == bomb) ch++;


                    a8: matrix[i, j] = ch;
                vihod: ch = 0;
                }
            }
        }

        private void buttonReturnToMenu_MouseClick(object sender, MouseEventArgs e)
        {
            buttonReturnToMenu.Visible = false;
            labelNumMines.Visible = false;
            panel1.Visible = true;
            for (int i = 0; i < X; i++)
            {
                for (int j = 0; j < Y; j++)
                {
                    pole[i, j].Dispose();
                }
            }
        }

        private void trackBarX_ValueChanged(object sender, EventArgs e)
        {
            labelX.Text = trackBarX.Value + " - количество клеток по горизонтали";
            labelB.Text = trackBarBomb.Value + " - количество мин. Оптимально:" + ((trackBarX.Value * trackBarY.Value) / 10);
        }

        private void trackBarY_ValueChanged(object sender, EventArgs e)
        {
            labelY.Text = trackBarY.Value + " - количество клеток по вертикали";
            labelB.Text = trackBarBomb.Value + " - количество мин. Оптимально:" + ((trackBarX.Value * trackBarY.Value) / 10);
        }

        private void trackBarBomb_ValueChanged(object sender, EventArgs e)
        {
            labelB.Text = trackBarBomb.Value + " - количество мин. Оптимально:"+((trackBarX.Value*trackBarY.Value)/10);
        }
    }
}
