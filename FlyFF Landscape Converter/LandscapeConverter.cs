using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FlyFF_Landscape_Converter
{
    public class LandscapeConverter
    {
        
        public const int MAP_SIZE = 128;

        public static async Task<Landscape[,]> LoadLandscapes(string folder)
        {
            return await Task.Factory.StartNew(() =>
            {
                var landscapeList = new List<Landscape>();

                foreach (var landscape in Directory.GetFiles(folder, "*.lnd"))
                {
                    landscapeList.Add(LoadLandscape(landscape));
                }

                var maxWidth = landscapeList.Max(x => x.X) + 1;
                var maxHeight = landscapeList.Max(y => y.Y) + 1;

                var landscapes = new Landscape[maxWidth, maxHeight];

                foreach (var landscape in landscapeList)
                {
                    landscapes[landscape.X, landscape.Y] = landscape;
                }

                return landscapes;
            });
        }

        public static Landscape LoadLandscape(string file)
        {
            var position = file.Substring(file.Length - 9, 5);
            var positionSplitter = position.Split('-');

            var landscape = new Landscape();
            landscape.X = int.Parse(positionSplitter[0]);
            landscape.Y = int.Parse(positionSplitter[1]);

            using (var fs = new FileStream(file, FileMode.Open))
            using (var br = new BinaryReader(fs))
            {
                var version = br.ReadUInt32();

                if (version >= 1)
                    br.ReadInt64(); // skip those

                for (int y = 0; y < MAP_SIZE + 1; y++)
                {
                    for (int x = 0; x < MAP_SIZE + 1; x++)
                    {
                        landscape.Height[x, y] = br.ReadSingle();
                    }
                }
            }

            return landscape;
        }

        public static Bitmap GetBitmapFromLandscape(Landscape landscape)
        {
            var bitmap = new Bitmap(MAP_SIZE + 1, MAP_SIZE + 1);

            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    var value = (int)GetHeight(landscape.Height[x, y]) / 4;
                    var color = Color.FromArgb(255, value, value, value);

                    bitmap.SetPixel(x, y, color);
                }
            }

            return bitmap;
        }

        public static async Task<Bitmap> GetBitmapFromLandscapes(Landscape[,] landscape)
        {
            return await Task.Factory.StartNew(() =>
            {
                var bitmap = new Bitmap(landscape.GetLength(0) * (MAP_SIZE + 1), landscape.GetLength(1) * (MAP_SIZE + 1));

                for (int ly = 0; ly < landscape.GetLength(0); ly++)
                {
                    for (int lx = 0; lx < landscape.GetLength(1); lx++)
                    {
                        for (int y = 0; y < MAP_SIZE + 1; y++)
                        {
                            for (int x = 0; x < MAP_SIZE + 1; x++)
                            {
                                var value = (int)GetHeight(landscape[lx, ly].Height[x, y]) / 4;
                                var color = Color.FromArgb(255, value, value, value);

                                bitmap.SetPixel((lx * (MAP_SIZE + 1)) + x, (ly * (MAP_SIZE + 1)) + y, color);
                            }
                        }
                    }
                }

                bitmap.RotateFlip(RotateFlipType.RotateNoneFlipY);

                return bitmap;
            });
        }

        public static float GetHeight(float heightData)
        {
            const float HGT_NOWALK = 1000.0f;
            const float HGT_NOFLY = 2000.0f;
            const float HGT_NOMOVE = 3000.0f;
            const float HGT_DIE = 4000.0f;

            if (heightData >= HGT_NOWALK)
            {
                if (heightData >= HGT_DIE)
                    return heightData - HGT_DIE;

                if (heightData >= HGT_NOMOVE)
                    return heightData - HGT_NOMOVE;

                if (heightData >= HGT_NOFLY)
                    return heightData - HGT_NOFLY;

                return heightData - HGT_NOWALK;
            }

            return heightData;
        }

    }
}
