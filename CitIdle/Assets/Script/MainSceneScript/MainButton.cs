using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainButton : MonoBehaviour
{
    public static void clickOnButton()
    {
        MoneyManager.InternalMoney ++;
    }
}
