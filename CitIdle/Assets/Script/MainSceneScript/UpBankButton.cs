using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpBankButton : MonoBehaviour
{
    public void OnClick()

    {

        if (MoneyManager.InternalMoney > BankManager.priceBank)
        {

            MoneyManager.InternalMoney -= BankManager.priceBank;
            LevelManager.statLevelBank++;
            BankManager.priceBank += BankManager.priceBank * 1.1f;
        }

    }
}
