using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class PolutionManager : MonoBehaviour
{
    public static float PolutionCount;
    public float InternalPolution;
    public GameObject DisplayPolution;
    private void Update()
    {
      
        InternalPolution += (float)(LevelManager.statLevelBank * 0.000000001 + LevelManager.statLevelMairie * 0.000000001 + LevelManager.statLevelPark * 0.000000001+PopulationManager.PopulationCount*0.00000001 -( ParkManager.reducePo));     
        PolutionCount = InternalPolution;
        DisplayPolution.GetComponent<TMP_Text>().text = " Polution = " + PolutionCount;
        if (InternalPolution >= 100)
        {
            PopulationManager.PopulationCount -= 1;
        }
    }
}
