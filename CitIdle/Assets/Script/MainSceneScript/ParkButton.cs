using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParkButton : MonoBehaviour
{
    public bool doubleTap;
    int tap;
    public void clickOnPark()
    {
        tap++;

        if (tap==1)
        {
            if (MoneyManager.InternalMoney > LevelManager.statLevelPark * 2.5)
            {
                LevelManager.statLevelPark++;
                MoneyManager.InternalMoney -= LevelManager.statLevelPark * (float)2.5;
                StartCoroutine(DoubleTapInterval());

            }
        }
        else if (tap >1&& doubleTap)
          {
            tap = 0;
            doubleTap = false;
           }
       
    }

    IEnumerator DoubleTapInterval()
    {
        yield return new WaitForSeconds(2);
        doubleTap = true;
    }
}
