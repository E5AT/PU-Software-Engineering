// for generating a random x and y in the given limits
(int, int) generateRandPosition(int[,] arr){
    List<(int, int)> list = new();

    for(int i=0;i<arr.GetLength(0);i++)
        for(int j = 0;j<arr.GetLength(1);j++)
            if(arr[i,j]==0)
                list.Add((i,j));

    return list[Random.Shared.Next(0,list.Count)];
}

int[,] generateRandBoard(int rows, int cols){
    // filling the array with 0s
    int[,] board = new int[rows, cols];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < cols; j++)
            board[i, j] = 0;

    

    int num = 1, count = 0, total = rows*cols;
    for(int i = 0; i < total; i++)
    {
                int x,y;
                (x, y) = generateRandPosition(board);
                    board[x,y] = num;
                    count++;
                    if(count == 2){
                        num++;
                        count = 0;
            }
        }

        return board;

}

void printBoard(int[,] arr)
{
    for(int i =0;i<arr.GetLength(0); i++){
        for(int j=0;j<arr.GetLength(1);j++)
            Console.Write($"[{arr[i,j]}] ");
        Console.WriteLine();
    }

}

char[,] fillArr withStars(char[])

void play(int[,] board)
{
    while (true)
    {
        int first, second;
    }
}

int[,] board = generateRandBoard(4,4);
printBoard(board);