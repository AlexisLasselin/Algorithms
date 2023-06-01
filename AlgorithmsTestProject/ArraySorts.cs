namespace AlgorithmsTestProject
{
    public static class ArraySortProblems
    {
        public static void MySort1(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        ArrayProblems.Swap(array, i, j);
                    }
                }
            }
        }

        public static void MySort2(int[] array)
        {
            var current = array.ToList();
            var result = new List<int>();
            while (current.Count > 0)
            {
                var x = current.Min();
                result.Add(x);
                current.Remove(x);
            }
            result.CopyTo(array);
        }

        public static void MergeSort(int[] array)
        {
            if (array.Length < 2)
                return;

            int mid = array.Length / 2;
            int[] left = new int[mid];
            int[] right = new int[array.Length - mid];

            Array.Copy(array, 0, left, 0, mid);
            Array.Copy(array, mid, right, 0, array.Length - mid);

            MergeSort(left);
            MergeSort(right);
            Merge(array, left, right);
        }

        private static void Merge(int[] array, int[] left, int[] right)
        {
            int i = 0, j = 0, k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                    array[k++] = left[i++];
                else
                    array[k++] = right[j++];
            }

            while (i < left.Length)
                array[k++] = left[i++];

            while (j < right.Length)
                array[k++] = right[j++];
        }

        public static void HeapSort(int[] array)
        {
            int n = array.Length;

            // Build heap (rearrange array)
            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(array, n, i);

            // One by one extract elements from the heap
            for (int i = n - 1; i > 0; i--)
            {
                // Move current root to the end
                int temp = array[0];
                array[0] = array[i];
                array[i] = temp;

                // Call max heapify on the reduced heap
                Heapify(array, i, 0);
            }
        }

        private static void Heapify(int[] array, int n, int i)
        {
            int largest = i;  // Initialize largest as root
            int left = 2 * i + 1;  // left = 2*i + 1
            int right = 2 * i + 2;  // right = 2*i + 2

            // If left child is larger than root
            if (left < n && array[left] > array[largest])
                largest = left;

            // If right child is larger than largest so far
            if (right < n && array[right] > array[largest])
                largest = right;

            // If largest is not root
            if (largest != i)
            {
                int swap = array[i];
                array[i] = array[largest];
                array[largest] = swap;

                // Recursively heapify the affected sub-tree
                Heapify(array, n, largest);
            }
        }


        public static void BubbleSort(int[] array)
        {
            bool swapped;
            var n = array.Length;
            do
            {
                swapped = false;

                for (var i = 1; i < n; ++i)
                {
                    if (array[i - 1] > array[i])
                    {
                        ArrayProblems.Swap(array, i-1, i);
                        swapped = true;
                    }
                }

                --n;
            } 
            while (swapped && n > 0);
        }

        public static void ShuffleSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void IntroSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void CocktailSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void QuickSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void BlockSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void BogoSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void DoNothingSort(int[] array)
        {
        }

        public static void EvilSort(int[] array)
        {
            Array.Fill(array, 0);
        }

        public static void GnomeSort(int[] array)
        {
            throw new NotImplementedException();
        }

        public static void SelectionSort(int[] array)
        {
        }
    }
}
