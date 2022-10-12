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
        PolutionCount = InternalPolution;
        DisplayPolution.GetComponent<TMP_Text>().text = " Polution = " + PolutionCount;
    }
}
