using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParkManager : MonoBehaviour
{
   public float reducePollution;
   public static float reducePo;

    void Update()
    {
        reducePo = reducePollution;
        reducePollution = (float)0.1 * LevelManager.statLevelPark;
        reducePo = reducePollution;

    }
}
