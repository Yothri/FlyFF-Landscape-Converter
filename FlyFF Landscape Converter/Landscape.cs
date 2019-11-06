namespace FlyFF_Landscape_Converter
{
    public class Landscape
    {
        public int X, Y;
        public float[,] Height;

        public Landscape(int map_size = 128)
        {
            X = 0;
            Y = 0;
            Height = new float[map_size + 1, map_size + 1];
        }
    }
}
