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


    private void Update()
    {
        InternalMoney += (float)(PopulationManager.PopulationCount * 0.0000001);
        MoneyCount = InternalMoney;
        if ( MoneyCount<0)
        {
            MoneyCount = 0;
        }
        DisplayMoney.GetComponent<TMP_Text>().text = " $ = " + InternalMoney;

    }








 
}
