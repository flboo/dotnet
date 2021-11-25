namespace Dotnet.Reflect
{
    public class Reflect
    {
        static void Main_reflect(string[] args)
        {
            Log.i(args.Length);

            ReflectBase reflectBase;
            //
            reflectBase = new ReflectNormal();

            reflectBase.Start();
        }

    }
}