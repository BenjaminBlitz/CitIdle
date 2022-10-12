using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class MoneyManager : MonoBehaviour
{
    //public static float InternalMoney;
    public float MoneyCount;
    public GameObject DisplayMoney;


    private void Update()
    {
       // InternalMoney = MoneyCount;
        DisplayMoney.GetComponent<TMP_Text>().text = " $ = " + MoneyCount;
    }
}
