using System;

public class Program {
    public static void Main()
    {

        string[] input = Console.ReadLine().Split(' ');
        int N = int.Parse(input[0]);
        int K = int.Parse(input[1]);

        int[] array = new int[N];
        string[] arrayInput = Console.ReadLine().Split(' ');

        for(int i = 0; i < N; i++){
            array[i] = int.Parse(arrayInput[1]);
        }
        int max = 0;
        int flag;
        for (int i = K; i < N - K; i++){
            flag = array[i];
            for (int j = 1;j < K + 1;j++){
                flag += array[i - j];
                flag += array[i + j];
            }
            if (flag > max){
                max = flag;
            }
        }
        Console.WriteLine(max);
    }
}
