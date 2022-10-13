using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParkButton : MonoBehaviour
{

    public void clickOnPark()
    {



        if (MoneyManager.InternalMoney > ParkManager.priceStatLvl)
        {
            MoneyManager.InternalMoney -= ParkManager.priceStatLvl;
            LevelManager.statLevelPark++;
            ParkManager.priceStatLvl += ParkManager.priceStatLvl * 1.1f;

        }


    }
}
