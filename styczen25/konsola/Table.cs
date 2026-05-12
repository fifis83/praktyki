namespace styczen25;

public class Table{
    private int[] numbers;
    private int numberLength;

    public Table(int numberLength){
        this.numberLength = numberLength;
        numbers = new int[numberLength];
        Random rand = new Random();
        for(int i=0;i<numberLength;i++){
            numbers[i] = rand.Next(1,1001);
        }
    }

    public void Print(){
        for(int i=0;i<numberLength;i++){
            Console.WriteLine($"{i}: {numbers[i]}");
        }
    }

    public int IndexOf(int numberToFind){
        for(int i=0;i<numberLength;i++){
            if(numbers[i]==numberToFind) return i;
        }
        return -1;
    }

    public int PrintOdd(){
        int count = 0;
        Console.WriteLine("Liczby Nieparzyste: ");
        for(int i=0;i<numberLength;i++){
            if(numbers[i]%2!=0){
                count++;
                Console.WriteLine(numbers[i]);
            }
        }
        return count;
    }

    public int Average(){
        int sum=0;
        for(int i=0;i<numberLength;i++){
            sum+=numbers[i];
        }
        return sum/numberLength;
    }
}