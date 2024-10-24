string[] board = new string[9] {"1","2","3","4","5","6","7","8","9"};
int turn = 0;
bool Player1turn = true;
    while (!checkwin() && turn != 9)
    {
        Makeboard();
        if (Player1turn) Console.WriteLine("Player 1 turn: ");
        else Console.WriteLine("Player 2 turn:");
        string choice = Console.ReadLine();
        if (board.Contains(choice) && choice != "X" && choice != "O")
        {
            int nhap = Convert.ToInt32(choice) - 1;
            if (Player1turn) board[nhap] = "X";
            else board[nhap] = "O";
            turn++;
        }
        Player1turn = !Player1turn;
    }

    if (checkwin())
    {
        if (!Player1turn) Console.WriteLine("PLAYER 1 WIN!");
        else Console.WriteLine("PLAYER 2 WIN!");
    }
    else Console.WriteLine("IT'S A DRAW!");

bool checkwin()
{
    bool rowl1 = board[0] == board[1] && board[1] == board[2];
    bool rowl2 = board[3] == board[4] && board[4] == board[5];
    bool rowl3 = board[6] == board[7] && board[7] == board[8];
    bool col1 = board[0] == board[3] && board[3] == board[6];
    bool col2 = board[1] == board[4] && board[4] == board[7];
    bool col3 = board[2] == board[5] && board[5] == board[8];
    bool dia1 = board[0] == board[4] && board[4] == board[8];
    bool dia2 = board[2] == board[4] && board[4] == board[6];
    return rowl1 || rowl2 || rowl3 || col1 || col2 || col3 || dia1 || dia2;
}

void Makeboard()
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            Console.Write(board[i * 3 + j] + "|");
        }
        Console.WriteLine();
        Console.WriteLine("------");
    }
}
