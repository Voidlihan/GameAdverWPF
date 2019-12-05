using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GameAdvers
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GamesAdd();
        }
        private static List<Game> GameList()
        {
            using(var context = new Context())
            {
                return context.Games.ToList();
            }
        }
        private static void GamesAdd()
        {
            using(var context = new Context())
            {
                var minecraft = new Game() {
                    Name = "Minecraft",
                    Developer = "Mojang",
                    Genre = "Sandbox",
                    Img = "https://upload.wikimedia.org/wikipedia/ru/thumb/b/b5/MinecraftLogo.svg/274px-MinecraftLogo.svg.png",
                    Description = "Перед началом игры нужно выбрать параметры для процедурной генерации мира. Игрок может" +
                    " ввести начальное значение для генератора псевдослучайных чисел, позволяющего создавать уникальные и неповторяющиеся миры. Если игрок не введёт это значение, то игра сделает это автоматически, " +
                    "используя для начального значения время на системных часах. Поэтому, если игрок создаст два мира с одинаковыми значениями, то такие миры также будут одинаковы. " +
                    "Таким образом создаётся игровой мир, состоящий из расставленных в фиксированном порядке кубов, и у такого мира практически нет ограничений в пространстве. " +
                    "Игровой мир делится на различные биомы, у каждого из которых свои погода и объекты. Дно мира состоит из бедрока (англ. Bedrock), который можно сломать только в творческом режиме. " +
                    "В начале игры игровой персонаж появляется на поверхности земли в случайном биоме — например, в пустыне, горах, равнинах, лесу и так далее[10]. В Minecraft нет каких-либо конкретных целей или сюжета — она строится на том, чтобы игрок импровизировал во время игрового процесса. " +
                    "По мере прохождения Minecraft игрок будет получать достижения за выполнения определённых действий. По умолчанию игрок управляет персонажем в режиме от первого лица, но игрок также может переключиться на режим от третьего лица. Сам мир состоит из трёхмерных объектов, " +
                    "которые в игре называются блоками (англ. Block), и такие блоки отличаются между собой текстурой, физикой и другими признаками. Игровой процесс в целом строится на добыче и размещении блоков, которыми могут быть земля, камень, руды, древесина, вода, лава и многие другие. " +
                    "Таким образом игрок может сооружать различные конструкции, и эта особенность делает игру схожей с конструктором LEGO",
                    Release = DateTime.Parse("17.05.2009"),
                    Price = 20,
                    Rating = 9.1
                };
                context.Add(minecraft);
                context.SaveChanges();
            }
        }

        private void GameClicked(object sender, MouseButtonEventArgs e)
        {
            WindowGame windowGame = new WindowGame();
            windowGame.ShowDialog();
        }
    }
}
