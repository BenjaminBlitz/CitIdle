using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpAchat : MonoBehaviour
{

    public void clickOnPark()
    {



        if (MoneyManager.InternalMoney > StockManager.action1Price)
        {
            MoneyManager.InternalMoney -= StockManager.action1Price;
            StockManager.nombreAction1++;
         

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
