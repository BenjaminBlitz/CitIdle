using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BankManager : MonoBehaviour
{
    public float wallet;
   public struct Stock
    {
        public string name;
        public float price;

        public Stock(string n, float p)
        {
            this.name = n;
            this.price = p;
        }
    }
    public string getName(Stock n)
    {
        return n.name;
    }
    public string getName(Stock n)
    {
        return n.name;
    }s
    Stock tesla = new Stock("tesla", 100);
    void Update()
    {
        
    }
}
