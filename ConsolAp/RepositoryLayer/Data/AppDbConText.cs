namespace RepositoryLayer.Data
{
    public static   class AppDbConText<T>
    {
        public static List<T> datas;
        static  AppDbConText()
        {
             datas = new List<T>();
        }
    }
}
