using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpMairieButton : MonoBehaviour
{
    public void OnClick()

    {

        if ( MoneyManager.InternalMoney>MairieManager.priceMairie)
        {

            MoneyManager.InternalMoney -= MairieManager.priceMairie;
            LevelManager.statLevelMairie++;
            MairieManager.priceMairie += MairieManager.priceMairie * 1.1f;
        }

    }
}
