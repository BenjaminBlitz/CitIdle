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
<<<<<<< Updated upstream
           // StartCoroutine(CreateMoney());
=======
            StartCoroutine(CreateMoney());
>>>>>>> Stashed changes

        }
        MoneyCount += (float)(PopulationManager.PopulationCount * 0.000001);
        DisplayMoney.GetComponent<TMP_Text>().text = " $ = " + MoneyCount;
<<<<<<< Updated upstream
=======
    }




    IEnumerator CreateMoney()
    {
        MoneyCount += (float) InternalIncrease * PopulationManager.PopulationCount*0.00001);
        yield return new WaitForSeconds(1);
        CreatingCrystal = false;
>>>>>>> Stashed changes
    }




   /* IEnumerator CreateMoney()
    {
       /* MoneyCount += (float) InternalIncrease * PopulationManager.PopulationCount*0.1);
        yield return new WaitForSeconds(1);
        CreatingCrystal = false;
    }*/
}
