using System;
using System.Collections.Generic;
using System.Text;

namespace vjrzbanjac
{
    class BluetoothSpeaker : BluetoothDevice
    {
        int maxVolume;
        string brand;

        public int MaxVolume
        {
            get { return maxVolume; }
            set { maxVolume = value; }
        }
        //Exceptioni su konstrukcija unutar objektno orijentiranih jezika koji sluze za prekidanje izvrsavanja programa u slucaju da dodje do nekog "problema"
        //njih bacimo kad nes nevalja

        public BluetoothSpeaker(int maxVolume, string brand, string name, int maxConnectedDevices) : base(name, maxConnectedDevices)
        {
            this.maxVolume = maxVolume;
            this.brand = brand;
        }
        public override string Pair()
        {
            return "Blutut moude";
        }

        public void Talk(string text)// Zadatak kod Zorica- Bluetooth ne moze izgovarati brojeve, u slucaju da korisnik unese tekst 
                                     //koji sadrzi brojeve potrebno je izbaciti objekt vlastite iznimke CannotContainNumbersException()
                                     //s porukom "the speaKER cannot pronounce numbers:text"
        {
            if (text.Contains('1') || text.Contains('2') || text.Contains('3') || text.Contains('4') || text.Contains('5') || text.Contains('6') || text.Contains('7')
                || text.Contains('8') || text.Contains('9') || text.Contains('0')) throw new CannotContainNumbersException(text, $"the speaker cannot pronounce numbers:{text}");
            Console.WriteLine(text);
        }
    }
}
