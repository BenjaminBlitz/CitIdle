using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PopulationManager : MonoBehaviour
{



    public static float PopulationCount;
    public float InternalPopulation;
    public GameObject DisplayPop;
    public float nextActionTime = 0;
    public float period = 0.3f;

    public static int populationLevel;

    private void Start()
    {
        switch (LevelManager.statLevelMairie)
        {
            case 1:
                InternalPopulation = 1000;
                PopulationCount = InternalPopulation;

                break;
            case 2:
                InternalPopulation = 10000;
                PopulationCount = InternalPopulation;


                break;
            case 3:
                InternalPopulation = 100000;
                PopulationCount = InternalPopulation;

                break;
            case 4:
                InternalPopulation = 1000000;
                PopulationCount = InternalPopulation;

                break;


        }
    }
    private void Update()
    {



        if (PolutionManager.statHighPollution)
        {
             if ( Time.time > nextActionTime)
            {
            nextActionTime += period;
                PopulationCount--;

               }


           

        }
        if(!PolutionManager.statHighPollution && PopulationCount< (InternalPopulation*10)*(1+(0.1f*populationLevel)))
        {
            if (Time.time > nextActionTime)
            {
                nextActionTime += period;
                PopulationCount++;
            }
        }

        DisplayPop.GetComponent<TMP_Text>().text = " Pop = " + PopulationCount;
    }
}


