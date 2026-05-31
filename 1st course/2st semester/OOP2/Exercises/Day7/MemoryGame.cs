(int, int) generateRandPosition(int rows, cols){
    int i = Random.Shared.Next(1, rows+1);
    int j = Random.Shared.Next(1, cols+1);
    return (i, j);
}

int[,] generateRandBoard(int rows, int cols){
    // filling the array with 0s
    int[,] board = new int[rows, cols];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < rows; j++)
            board[i, j] = 0;


    int num = 1, count = 1;
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < cols; j++){
            while(true){
                int x,y;
                (x, y) = generateRandPosition(rows, cols);
                if(board[x, y] == 0){
                    board[x,y] = num;
                    if(count == 2){
                        num++;
                        count = 1;
                        break;
                    }
                    else{
                        count++;
                    }
                }
            }
        }

        return board;

}

void printMisteryBoard(int[,] board){
    for(int i = 0;i<board.GetLength(0);i++){
        for(int j =0;j<board.GetLength(1);j++)
            Console.WriteLine($"[{board[i,j]}] ")
        Console.WriteLine("\n");
    }
}

int main(){
    int[,] board = generateRandBoard(4,4);

}
