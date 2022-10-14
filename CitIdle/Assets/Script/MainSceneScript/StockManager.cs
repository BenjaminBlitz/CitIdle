using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StockManager : MonoBehaviour
{



    public static float popo;
        public static float nombreAction1;
        public float nombreStatAction1;
        public float timeLeft = 10;
        public GameObject Action1;
        public GameObject Action2;
        public GameObject Action3;
        public GameObject b2;
        public GameObject b2bis;
        public GameObject b3;
        public GameObject b3bis;
        public GameObject time;



    public static float  action1Price=30;
        public static float nombreAction2;
        public float nombreStatAction2;
        public static float action2Price = 100;
        public static float action3Price = 300;
        public static float nombreAction3;


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


    public void Start()
    {
        b2.SetActive(false);
        b3.SetActive(false);
        b3bis.SetActive(false);
        b2bis.SetActive(false);

    }

    public void setStock(Stock s, float value)
        {
            s.stock = value;
        }


        public void Update()
        {
        timeLeft -= Time.deltaTime;
            if (timeLeft < 0)
            {
                action1Price = Random.Range(20, action1Price+ 20);
                action2Price = Random.Range(75, action2Price + 50);

                action3Price = Random.Range(175, action3Price + 100);
    

            timeLeft = 10;
            }

        time.GetComponent<TMP_Text>().text = "Temps Restant " + (int)timeLeft +"secondes";


        if (LevelManager.statLevelBank == 1)
        {
            Action1.GetComponent<TMP_Text>().text = " Nombre Action = " + nombreAction1 + "prix = " + action1Price;

        }
                    
            if (LevelManager.statLevelBank ==2)
            {
            Action1.GetComponent<TMP_Text>().text = " Nombre Action = " + nombreAction1 + "prix = " + action1Price;
            Action2.GetComponent<TMP_Text>().text = " Nombre Action = " + nombreAction2 + "prix = " + action2Price;
            b2.SetActive(true);
            b2bis.SetActive(true);


        }
        if (LevelManager.statLevelBank == 3)
        {
            Action1.GetComponent<TMP_Text>().text = " Nombre Action = " + nombreAction1 + "prix = " + action1Price;
            Action2.GetComponent<TMP_Text>().text = " Nombre Action = " + nombreAction2 + "prix = " + action2Price;
            Action3.GetComponent<TMP_Text>().text = " Nombre Action = " + nombreAction3 + "prix = " + action3Price;
            b2.SetActive(true);
            b2bis.SetActive(true);
            b3.SetActive(true);
            b3bis.SetActive(true);


        }



    }




}





