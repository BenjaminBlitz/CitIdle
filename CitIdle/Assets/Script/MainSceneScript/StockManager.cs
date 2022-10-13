using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StockManager : MonoBehaviour
{



    public static float popo;
        public static float nombreAction;
        public float nombreStatAction;
        public float timeLeft = 10;
        public GameObject walletDisplay;
        public struct Stock
        {
           public string name;
           public float stock;

           public Stock(string n, float s)
            {
                this.name = n;
                this.stock = s;

            }



        }


        Stock tesla = new Stock("tesla", 100);
        Stock bitcoin = new Stock("Bitcoin", 25000);
        Stock Intel = new Stock("Intel", 50);
        Stock unity = new Stock("Unity", 5000000);
        Stock esiee = new Stock("ESIEE", 10000000000000000);




        public void setStock(Stock s, float value)
        {
            s.stock = value;
        }


        public void Update()
        {
        setStock(tesla, Random.Range(-50, 50));
        timeLeft -= Time.deltaTime;
            if (timeLeft < 0)
            {
            popo = Random.Range(-50, 50);

             setStock(tesla, Random.Range(-50, 50));
                timeLeft = 10;
            }

           


        walletDisplay.GetComponent<TMP_Text>().text = " Nombre Action = " + nombreAction + "prix = " + popo;
                    


          }




}





