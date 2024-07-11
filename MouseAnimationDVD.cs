using animouse.Properties;
using System;
using System.Drawing;
using System.Threading;

namespace animouse
{
    internal static class MouseAnimationDVD
    {
        public static Point Position;
        public static Point Move;
        public static Point Center;
        public static Size Box
        {
            get
            {
                return new Size
                { Width = Settings.Default.BoxWidth, Height = Settings.Default.BoxHeight };
            }
        }
        public static Point Speed
        {
            get
            {
                return new Point
                { X = Settings.Default.SpeedHor, Y = Settings.Default.SpeedVer };
            }
        }
        private static readonly Random Rand = new Random();

        public static double SpeedMod;
        private static bool IsAtStart = true;
        private static Point Delta = new Point(1, 1);

        public static void Reset()
        {
            IsAtStart = true;
            DeltaGenerate();
            SpeedModGenerate();
        }

        private static void SpeedModGenerate()
        {
            SpeedMod = Rand.NextDouble() * (Settings.Default.SpeedRandomMax - Settings.Default.SpeedRandomMin) + Settings.Default.SpeedRandomMin;
        }

        private static void DeltaGenerate()
        {
            int x = Rand.Next(0, 2) == 0 ? -1 : 1;
            int y = Rand.Next(0, 2) == 0 ? -1 : 1;
            Delta = new Point(x, y);
        }

        public static int BoundLeft { get { return Center.X - Box.Width / 2; } }
        public static int BoundRight { get { return Center.X + Box.Width / 2; } }
        public static int BoundTop { get { return Center.Y - Box.Height / 2; } }
        public static int BoundBottom { get { return Center.Y + Box.Height / 2; } }


        public static void Tick()
        {
            if (IsAtStart)
            {
                Position = Center;
            }
            IsAtStart = false;

            // Move
            Move.X = (int)(Delta.X * Speed.X * SpeedMod);
            Move.Y = (int)(Delta.Y * Speed.Y * SpeedMod);
            Position.X += Move.X;
            Position.Y += Move.Y;

            // Bounds
            bool boundXReached = Position.X <= BoundLeft || Position.X >= BoundRight;
            bool boundYReached = Position.Y <= BoundTop || Position.Y >= BoundBottom;

            if (boundXReached)
            {
                // Ensure Position stays within bounds
                if (Position.X <= BoundLeft)
                {
                    Position.X = BoundLeft;
                }
                else if (Position.X >= BoundRight)
                {
                    Position.X = BoundRight;
                }

                Delta.X = -Delta.X;
            }

            if (boundYReached)
            {
                // Ensure Position stays within bounds
                if (Position.Y <= BoundTop)
                {
                    Position.Y = BoundTop;
                }
                else if (Position.Y >= BoundBottom)
                {
                    Position.Y = BoundBottom;
                }

                Delta.Y = -Delta.Y;
            }

            if (boundXReached || boundYReached)
            {
                SpeedModGenerate();
            }
        }

        public static void Animate()
        {
            while (true)
            {
                var framerate = Math.Max(1, Math.Min(Settings.Default.Framerate, 1000));
                Thread.Sleep(1000 / framerate);

                var isDownShortcutAddWhitelist = Program.ShortcutAddWhitelist.IsDown();
                if (isDownShortcutAddWhitelist)
                {
                    if (!Settings.Default.WhiteList.Contains(Program.InFocusProcess))
                    {
                        Settings.Default.WhiteList.Add(Program.InFocusProcess);
                    }
                    Program.formWhiteList.PickWhiteList();
                    continue;
                }

                var isFocusedInWhiteList = !Settings.Default.UseProcWhitelist || Settings.Default.WhiteList.Contains(Program.InFocusProcess);
                var isDownShortcutDVD = Program.ShortcutRunDVD.IsDown();
                if (isFocusedInWhiteList && isDownShortcutDVD)
                {
                    Tick();
                    Program.Move(Move.X, Move.Y);
                    continue;
                }

                Reset();
                Center = System.Windows.Forms.Cursor.Position;
            }
        }
    }

}
