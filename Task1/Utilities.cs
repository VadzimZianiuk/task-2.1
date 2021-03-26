using System;

namespace Task1
{
    public static class Utilities
    {
        /// <summary>
        /// Sorts an array in ascending order using bubble sort.
        /// </summary>
        /// <param name="numbers">Numbers to sort.</param>
        public static void Sort(int[] numbers)
        {
            if (numbers is null)
            {
                throw new ArgumentNullException(nameof(numbers));
            }

            int finish = numbers.Length;
            bool isDone = finish < 2;
            while (!isDone)
            {
                isDone = true;
                for (int i = 1; i < finish; i++)
                {
                    if (numbers[i - 1] > numbers[i])
                    {
                        isDone = false;
                        int temp = numbers[i];
                        numbers[i] = numbers[i - 1];
                        numbers[i - 1] = temp;
                    }
                }

                finish--;
            }
        }

        /// <summary>
        /// Searches for the index of a product in an <paramref name="products"/> 
        /// based on a <paramref name="predicate"/>.
        /// </summary>
        /// <param name="products">Products used for searching.</param>
        /// <param name="predicate">Product predicate.</param>
        /// <returns>If match found then returns index of product in <paramref name="products"/>
        /// otherwise -1.</returns>
        public static int IndexOf(Product[] products, Predicate<Product> predicate)
        {
            if (products is null)
            {
                throw new ArgumentNullException(nameof(products));
            }

            if (predicate is null)
            {
                throw new ArgumentNullException(nameof(predicate));
            }

            for (int i = 0; i < products.Length; i++)
            {
                if (predicate(products[i]))
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
