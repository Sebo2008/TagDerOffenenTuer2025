namespace ListenEinfuehrung
{
    public sealed class ListConfig
    {
        public List<int>? NewRandomInts(List<int> list, int objCount, int randomMin, int randomMax)
        {
            if (list != null)
            {
                list.Clear();
            }
            else
            {
                list = new List<int>();
            }
            if (randomMin > randomMax)
            {
                (randomMax, randomMin) = (randomMin, randomMax);
            }
            Random rnd = new Random();
            int rndInt;
            for (int i = 0; i < objCount; i++)
            {
                rndInt = rnd.Next(randomMin, (randomMax + 1));
                list.Add(rndInt);
            }
            return list;
        }
        public List<int>? SortList(List<int> list)
        {
            if (list != null)
            {
                list.Sort();
            }
            return list;
        }
        public List<int>? AddAtIndex(List<int> list, int index, int obj)
        {
            if (list != null)
            {
                list.Insert(index, obj);
            }
            else
            {
                list = new List<int> { obj };
            }
            return list;
        }
        public List<int> ZickZack(List<int> list)
        {
            if (list == null)
            {
                return [];
            }
            // Create a new list to store the sorted elements in the desired order
            List<int> result = new List<int>();
            // Iterate through the sorted list, alternating between lowest and highest elements
            int i = 0, j = list.Count - 1;
            while (i <= j)
            {
                result.Add(list[i]);
                if (i < j)
                {
                    result.Add(list[j]);
                }
                i++;
                j--;
            }
            return result;
        }
    }
}
