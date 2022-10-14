using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class PolutionManager : MonoBehaviour
{
    public static float PolutionCount;
    public float InternalPolution;
    public GameObject DisplayPolution;
    public GameObject DisplayPol;
    public GameObject PolutionNuage;
    public float maxPolution;
    public bool highPollution;
    public static bool statHighPollution;

    public static float temps;

    private void Update()
    {
      
        
        InternalPolution += (float)(LevelManager.statLevelBank * 0.000000001 + LevelManager.statLevelMairie * 0.000000001 + LevelManager.statLevelPark * 0.000000001+PopulationManager.PopulationCount*0.00000001 -( ParkManager.reducePo));
        maxPolution = 100;
        PolutionCount = InternalPolution;
        if (PolutionCount> 100)
        {
            highPollution = true;
            statHighPollution = true;
            temps = Time.deltaTime;
           
        }
        else
        {
            highPollution = false;
            statHighPollution = false;
            temps = 0;
        }
        DisplayPolution.GetComponent<TMP_Text>().text = " Polution = " + Mathf.Round(PolutionCount * 100.0f) * 0.01f;
        DisplayPol.GetComponent<TMP_Text>().text =      " Polution = " + Mathf.Round(PolutionCount * 100.0f) * 0.01f + " / " + maxPolution;
        PolutionNuage.GetComponent<SpriteRenderer>().color = new Color(0,0,0,((170*PolutionCount)/100)/255);

    }
}
