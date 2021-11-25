namespace Dotnet.Reflect
{
    public abstract class ReflectBase
    {
        public virtual void Start()
        {
            Log.i("");
            Log.i("start:   " + System.DateTime.Now.Millisecond);
        }

        protected void LogEndTime()
        {
            Log.i("end:   " + System.DateTime.Now.Millisecond);
        }

    }
}