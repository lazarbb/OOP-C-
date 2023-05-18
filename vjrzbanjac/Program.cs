using System;

namespace vjrzbanjac
{
    class Program
    {
        static void Main(string[] args)
        {
            BluetoothSpeaker b = new BluetoothSpeaker(100, "JBL", "Lazarov zvucnik", 10);

            try
            {
                b.Talk("1234");
            }
            catch(CannotContainNumbersException e)
            {
                //Console.WriteLine($"the speaker cannot pronounce numbers:{e.Text}");
                Console.WriteLine(e.Message);
            }
        }
    }
}
