using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpAchat : MonoBehaviour
{
    int compt = 0;
    public void clickOnPark()
    {


        if (MoneyManager.InternalMoney > StockManager.action1Price)
        {
            MoneyManager.InternalMoney -= StockManager.action1Price;
            StockManager.nombreAction1++;
         

        }
        compt++;
        if (compt == 10 && MoneyManager.InternalMoney < StockManager.action1Price)
        {
            StockManager.action1Price = 0;
            StockManager.action1Price = 0;
            StockManager.action1Price = 0;
            compt = 0;
    }        
    }

    public void clickOnAction2()
    {



        if (MoneyManager.InternalMoney > StockManager.action2Price)
        {
            MoneyManager.InternalMoney -= StockManager.action2Price;
            StockManager.nombreAction2++;


        }


    }
    public void clickOnAction3()
    {



        if (MoneyManager.InternalMoney > StockManager.action3Price)
        {
            MoneyManager.InternalMoney -= StockManager.action3Price;
            StockManager.nombreAction3++;


        }


    }
}
