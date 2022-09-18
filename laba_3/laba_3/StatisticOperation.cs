namespace laba_3
{
    public static class StatisticOperation
    {
        public static int CountCapacity(List list)
        {
            var current = list.Head;
            int count = 0;

            while (current != null)
            {
                count++;
                current = current.Pointer;
            }

            return count;
        }

        public static string FindTheLongestString(List list)
        {

            var current = list.Head;
            var maxString = "";
            while (current!=null)
            {
                if (current.Data.Length > maxString.Length)
                    maxString = current.Data;
                current = current.Pointer;
                
            }

            return maxString;
        }

        public static void ShortenString(this List list,int length)
        {
            var current = list.Head;
            while (current != null)
            {
                current.Data = current.Data.Substring(0, length);
                current = current.Pointer;
            }
        }

        public static string ConcatAllElements(this List list)
        {
           

            string newLine="";
                
            var current = list.Head;
            while (current != null)
            {
                newLine += current.Data;
                current = current.Pointer;
            }

            return newLine;

        }
        
    }
}