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

        MoneyCount = InternalMoney;
        if (CreatingMoney == false)
        {
            CreatingMoney = true;
           // StartCoroutine(CreateMoney());

        }
        MoneyCount += (float)(PopulationManager.PopulationCount * 0.000001);
        DisplayMoney.GetComponent<TMP_Text>().text = " $ = " + MoneyCount;
    }




   /* IEnumerator CreateMoney()
    {
       /* MoneyCount += (float) InternalIncrease * PopulationManager.PopulationCount*0.1);
        yield return new WaitForSeconds(1);
        CreatingCrystal = false;
    }*/
}
