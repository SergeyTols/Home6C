Console.Write("Введите длину массива: ");
uint Number = Convert.ToUInt32(Console.ReadLine());

int[] array = new int[Number];

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }

WriteArray(array);
Console.WriteLine();


int size = array.Length / 2;
    if(array.Length % 2 != 0)
    {
        size++;
    }
    
int[] newArray = new int[size];
    for( int i = 0; i < array.Length / 2; i++ )
    {
        newArray[i] = array[i] * array[array.Length - i - 1];
    }       
    if(array.Length % 2 != 0)
    {
        newArray[size - 1] =  array[Number / 2];  
    }       
    
void WriteArray(int[] test)
{
    Console.Write("[");
    
        for(int i = 0; i < test.Length; i++)
        {
            if(i < test.Length -1)
            {
                Console.Write(test[i] + ", ");
            }   
            else
            {
                Console.Write(test[i] + "]");         
            }
        }
        
}

WriteArray(newArray);
