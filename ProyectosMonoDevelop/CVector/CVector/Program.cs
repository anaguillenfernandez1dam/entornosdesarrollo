using System;

namespace CVector
{
    class Vector
    {
        public static void Main(string[] args)
        {
            int[] v = {1, 4, 6, 9, 13};
            int[] b = new int[v.Length];
            Array.Copy(v, 2, b, 0, 3);

            Console.WriteLine(BinarySearch(v, 12));

        }

        public static int BinarySearch(int[] v, int x){

            //int[] aux = v;
            //int num = x;
            //while(aux.Length > 0){
            //    int index = aux.Length / 2;
            //    if (aux[index] == x){
            //        return 1;
            //    }else{
            //        if (x < aux[index]){
            //            Array.Copy(aux, 0, aux, 0, index);
            //        }
            //        else{
            //            Array.Copy(aux, index, aux, 0, aux.Length - index);
            //        }
            //    }
            //}
            //return -1;

            int count = v.Length;
            if (count == 0)
                return -1;
            int left = 0;
            int right = count - 1;
            int middle = (left + right) / 2;
            while(left < right && v[middle] != x){
                if (x > v[middle])
                    left = middle + 1;
                else
                    right = middle - 1;
                middle = (left + right) / 2;
            }
        }
    }
}
