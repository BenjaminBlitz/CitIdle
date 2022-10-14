using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class UpVente : MonoBehaviour
{

    public void clickOnPark()
    {



        if (StockManager.nombreAction1 > 0)
        {
            MoneyManager.InternalMoney += StockManager.action1Price;
            StockManager.nombreAction1--;


        }


    }
    public void clickOnVente2()
    {



        if (StockManager.nombreAction2 > 0)
        {
            MoneyManager.InternalMoney += StockManager.action2Price;
            StockManager.nombreAction2--;


        }


    }
    public void clickOnVente3()
    {



        if (StockManager.nombreAction3 > 0)
        {
            MoneyManager.InternalMoney += StockManager.action3Price;
            StockManager.nombreAction3--;


        }


    }
}
