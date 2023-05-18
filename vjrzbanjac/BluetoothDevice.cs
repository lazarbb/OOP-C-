using System;
using System.Collections.Generic;
using System.Text;

namespace vjrzbanjac
{
    abstract class BluetoothDevice
    {

        protected BluetoothDevice(string name, int maxConnectedDevices)
        {
            Name = name;
            MaxConnectedDevices = maxConnectedDevices;
        }

        public string Name{ get;set;}//automatsko javno sučelje
        public int MaxConnectedDevices { get; set; }

        public abstract string Pair();
 
    }
}
