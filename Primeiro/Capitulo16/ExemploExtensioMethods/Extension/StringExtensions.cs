namespace System
{
    static class StringExtensions
    {
        public static string Cut(this string thisObj, int count) // em extension methods o primeiro parametro é sempre a referencia para o proprio objeto
        {
            if (thisObj.Length <= count)
            {
                return thisObj;
            }
            else
            {
                return thisObj.Substring(0, count) + "...";
            }
        }
    }
}