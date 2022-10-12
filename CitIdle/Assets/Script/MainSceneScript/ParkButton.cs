using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParkButton : MonoBehaviour
{
    public void clickOnPark()
    {
        if (MoneyManager.InternalMoney>LevelManager.statLevelPark* 2.5 )
        {
            LevelManager.statLevelPark++;
            MoneyManager.InternalMoney -= LevelManager.statLevelPark *(float) 2.5;

        }
    }
}
