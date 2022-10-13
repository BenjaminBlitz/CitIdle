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
        PopulationCount = InternalPopulation;
        DisplayPop.GetComponent<TMP_Text>().text = " Pop = " + PopulationCount;
    }
}


