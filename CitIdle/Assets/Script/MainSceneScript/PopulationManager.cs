using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PopulationManager : MonoBehaviour
{



    public static float PopulationCount;
    public float InternalPopulation;
    public GameObject DisplayPop;


    private void Update()
    {
        switch(LevelManager.statLevelMairie)
        {
            case 1:
                InternalPopulation = 10000;
                break;
            case 2:
                InternalPopulation = 100000;
;
                break;
            case 3:
                InternalPopulation = 10000000;
                break;
            case 4:
                InternalPopulation = 10000000000;
                break;


        }
           

        PopulationCount = InternalPopulation;
        DisplayPop.GetComponent<TMP_Text>().text = " Pop = " + PopulationCount;
    }
}


