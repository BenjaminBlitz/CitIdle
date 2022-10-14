using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpCitoyenButton : MonoBehaviour
{
    public void OnClick()

    {

        if (MoneyManager.InternalMoney > CitoyenManager.priceCitoyen)
        {

            MoneyManager.InternalMoney -= CitoyenManager.priceCitoyen;
            LevelManager.statLevelCitoyen++;
            CitoyenManager.priceCitoyen += CitoyenManager.priceCitoyen * 1.01f;
        }

    }
}
