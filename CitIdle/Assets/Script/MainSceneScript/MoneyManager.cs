using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class MoneyManager : MonoBehaviour
{
    public static float InternalMoney;
    public float MoneyCount;
    public GameObject DisplayMoney;
    public float InternalIncrease;
    public float MoneyIncrease;
    public bool CreatingMoney;
    public float incomeSec;
    public GameObject DisplayIncome;

    public static int incomeLevel;

    private void FixedUpdate()
    {
        incomeSec = (float)(PopulationManager.PopulationCount * 0.0000001 * LevelManager.statLevelCitoyen * 4);
        incomeSec *= (1+(incomeLevel*0.1f));

        InternalMoney += incomeSec;
            //(float)(PopulationManager.PopulationCount * 0.0000001*LevelManager.statLevelCitoyen*4);
        MoneyCount = InternalMoney;
        if ( MoneyCount<0)
        {
            MoneyCount = 0;
        }
        DisplayMoney.GetComponent<TMP_Text>().text = " $ = " + Mathf.Round(InternalMoney * 1000.0f) * 0.001f;
        DisplayIncome.GetComponent<TMP_Text>().text = " Income/s = " + incomeSec*50;
        

    }








 
}
