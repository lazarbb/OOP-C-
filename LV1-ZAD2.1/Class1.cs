using System;
using System.Collections.Generic;
using System.Text;

public class TrashCan
{
   public int trashAmount;
   public int trashCapacity;

    public void TrashCan(int trashCapacity)
    {
        trashAmount = 0;
        this.trashCapacity = trashCapacity;
    }

    public bool GetTrashCapacity()=true
    {
       Console.WriteLine(trashCapacity);
    }

    public bool GetTrashAmount()
    {
        Console.WriteLine(trashAmount);
    }

    public void Insert(int trashAmount)
    {
        Console.WriteLine(trashAmount);
    }
}
