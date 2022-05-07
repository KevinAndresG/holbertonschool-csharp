using System;

class Line {
    public static void PrintDiagonal(int length) {
        if (length == 0 || length < 0) {
            Console.WriteLine();
            return;
        }
        for (int i = 1; i <= length; i++) {
            Console.WriteLine("\\");
            if (i != length) {
                for (int j = 1; j <= i; j++) {
                    Console.Write(" ");
                }
            } else {
                Console.WriteLine();
            }
        }
    }
}
