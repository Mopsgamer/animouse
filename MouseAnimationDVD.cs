using GlobalInput;
using mouseutil.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace mouseutil
{
    public class MouseAnimationDVD
    {
        private bool running = false;
        private bool stopping = true;
        public MouseAnimationDVD()
        {
            GlobalKeyboard.OnKeyDown += ToggleRunningKeyDown;
            GlobalKeyboard.OnKeyUp += ToggleRunningKeyUp;
        }

        ~MouseAnimationDVD()
        {
            GlobalKeyboard.OnKeyDown -= ToggleRunningKeyDown;
            GlobalKeyboard.OnKeyUp -= ToggleRunningKeyUp;
        }

        private void ToggleRunningKeyDown(object sender, EventArgs e)
        {
            if (!GlobalKeyboard.lastShortcut.Equals(Program.ShortcutRunDVD))
            {
                return;
            }

            if (!Settings.Default.ShortcutRunDVDToggler)
            {
                running = true;
                return;
            }
        }

        private void ToggleRunningKeyUp(object sender, EventArgs e)
        {
            if (!GlobalKeyboard.lastShortcut.Equals(Program.ShortcutRunDVD))
            {
                return;
            }

            if (!Settings.Default.ShortcutRunDVDToggler)
            {
                running = false;
                return;
            }

            running = !running;
        }

        [Serializable]
        public enum Clicking
        {
            Disabled, OnBounce, OnTick
        }

        public static Dictionary<Clicking, string> ClickingChoices = new Dictionary<Clicking, string>
        {
            { Clicking.Disabled, "Off" },
            { Clicking.OnBounce, "Each bounce"},
            { Clicking.OnTick, "Each tick" },
        };

        public Point Position;
        public Point Move;
        public Point Center;
        public Size Box
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
        private static Point Delta = new Point(1, 1);

        private void SpeedModGenerate()
        {
            SpeedMod = Rand.NextDouble() * (Settings.Default.SpeedRandomMax - Settings.Default.SpeedRandomMin) + Settings.Default.SpeedRandomMin;
        }

        private void DeltaGenerate()
        {
            int x = Rand.Next(0, 2) == 0 ? -1 : 1;
            int y = Rand.Next(0, 2) == 0 ? -1 : 1;
            Delta = new Point(x, y);
        }

        public int BoundLeft { get { return Center.X - Box.Width / 2; } }
        public int BoundRight { get { return Center.X + Box.Width / 2; } }
        public int BoundTop { get { return Center.Y - Box.Height / 2; } }
        public int BoundBottom { get { return Center.Y + Box.Height / 2; } }

        public void Next()
        {
            Clicking clickWhen = ClickingChoices.First(kv => kv.Value == Settings.Default.ClickWhen).Key;

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
                if (clickWhen == Clicking.OnBounce)
                {
                    GlobalCursor.ClickLeft(Position);
                }
            }

            if (clickWhen == Clicking.OnTick)
            {
                GlobalCursor.ClickLeft(Position);
            }
        }

        public bool Running
        {
            get
            {
                var isFocusedInWhiteList = !Settings.Default.UseProcWhitelist || Settings.Default.WhiteList.Contains(Program.InFocusProcess);
                return isFocusedInWhiteList && running;
            }
        }

        public void Stop()
        {
            stopping = true;
        }

        public void Start()
        {
            stopping = false;
            DeltaGenerate();
            SpeedModGenerate();
            while (true)
            {
                if (stopping)
                {
                    break;
                }
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

                if (Running)
                {
                    Next();
                    GlobalCursor.Position = Move;
                    continue;
                }

                Position = Center = GlobalCursor.Position;
            }
        }
    }

}
