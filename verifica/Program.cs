// See https://aka.ms/new-console-template for more information
int [,] popola(int[,]mat)
{
   
    Random rnd = new Random();
   
    int k=0, r=0;
    while (r < 12)
    {
        int random = rnd.Next(-10, 30);
        mat[k,r] = random;
        r++;
    }
 
    return mat;
}

void stampaMatrice(int[,] mat)
{
    for(int i = 0; i < mat.GetLength(0); i++)
    {
        for(int j = 0; j < mat.GetLength(1); j++)
        {
            Console.Write("[" + mat[i,j] + "]");
        }
        Console.WriteLine("");
    }
}
int[,] mat=new int[2,12];
//stampaMatrice(popola(mat));

int[,] mediaProgressiva(int[,] mat)
{
    Random rnd = new Random();
    
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            if (i == 0)
            {
                int random = rnd.Next(-10, 30);
                mat[i,j] = random;

            }
            else
            {
                if (j == 0)
                {
                    mat[i, j] = mat[0, 0];
                }
                else
                {
                    mat[i, j] += mat[0, j] / j+1;
                }
                
            }
        }
       
    }
    return mat;
}
stampaMatrice(mediaProgressiva(mat));

int tempMax(int[,] mat)
{
    int max = -999;
    mediaProgressiva(mat);
    for(int i = 0; i < mat.GetLength(0); i++)
    {
        for(int j=0; j < mat.GetLength(1); j++)
        {
            if (i == 0)
            {
                if (mat[i, j] > max)
                {
                    max = mat[i, j];
                }
            }
        }
    }
    return max;
}
//Console.WriteLine("La temperatura massima è: " + tempMax(mat));

string completa(string parola)
{
    char[] arr = {'A','B','C','D', 'E', 'F', 'G', 'H', 'I', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'Z', 'J', 'K', 'X', 'W', 'Y' };
    for(int i = 0;i < parola.Length;i++)
    {
       for(int j=0; j < arr.Length;j++)
        {
            if (parola[i] != arr[j])
            {
                parola += arr[j];
            }
        }
    }
    return parola;
}
string parola = "ILMATNOHRBC";
Console.WriteLine(completa(parola));

bool trova(string parola1)
{
    bool cerca = false;
    char[] arr = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    for (int i = 0; i < parola1.Length; i++)
    {
        for (int j = 0; j < arr.Length; j++)
        {
            if (parola1[i] == arr[j])
            {
                return false;
            }
        }
       
    }
    return true;
}
string ciao = "123456789";
Console.WriteLine(trova(ciao));
