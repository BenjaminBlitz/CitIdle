using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PopulationManager : MonoBehaviour
{



    public static float PopulationCount= 10000;
    public float InternalPopulation;
    public GameObject DisplayPop;
    public float timeRemaining = 10;
   
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
        if (PolutionManager.statHighPollution)
        {
            if (timeRemaining>0)
            {
                timeRemaining--;
                
            }
            else
            {
                PopulationCount--;
                timeRemaining = 10;
            }
            

        }
        DisplayPop.GetComponent<TMP_Text>().text = " Pop = " + PopulationCount;
    }
}


