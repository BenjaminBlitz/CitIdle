using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainButton : MonoBehaviour
{
    public void clickOnButton()
    {
        MoneyManager.InternalMoney ++;
    }
}
