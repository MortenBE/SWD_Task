using System.Threading.Tasks;

namespace QuickSort
{
    public class QuickSortMultiThread
    {
        public static async Task SerialQuicksort(long[] elements, long left, long right)
        {
            long i = left, j = right;
            var pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0) i++;
                while (elements[j].CompareTo(pivot) > 0) j--;
                
               
                if (i <= j)
                {
                    // Swap
                    var tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j) await SerialQuicksort(elements, left, j);
            if (i < right) await SerialQuicksort(elements, i, right);
        }
    }
}