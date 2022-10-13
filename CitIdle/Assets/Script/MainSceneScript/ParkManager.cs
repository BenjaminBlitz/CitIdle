using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ParkManager : MonoBehaviour
{
   public float reducePollution;
   public static float reducePo;
    public GameObject DisplayLvl;
    public float priceLvl;
    public static float priceStatLvl=2;

    void Update()
    {

        priceLvl = 2;
        reducePo = reducePollution;
        reducePollution = (float)0.0000001 * LevelManager.statLevelPark;
        reducePo = reducePollution;
        priceLvl = priceStatLvl;
        DisplayLvl.GetComponent<TMP_Text>().text = " Park niv =  " + LevelManager.statLevelPark +" prix = " + priceLvl;

    }
}
