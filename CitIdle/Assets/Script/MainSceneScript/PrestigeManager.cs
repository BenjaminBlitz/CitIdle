using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrestigeManager : MonoBehaviour
{
    public float actualPrestigePoints;
    public static float prestigePoints;

    public float incomeCost;
    public float populationCost;
    public float polutionCost;

    public static int incomeLevel;
    public static int populationLevel;
    public static int polutionLevel;


    // Start is called before the first frame update
    void Start()
    {
        actualPrestigePoints = prestigePoints;
    }

    public void upradeIncome()
    {
        if (actualPrestigePoints >= incomeCost)
        {
            actualPrestigePoints -= incomeCost;
            incomeCost *= 1.1f;
        }
    }    
    public void upradePopulation()
    {
        if (actualPrestigePoints >= populationCost)
        {
            actualPrestigePoints -= populationCost;
            populationCost *= 1.1f;
        }
    }    
    public void upgradePolution()
    {
        if (actualPrestigePoints >= polutionCost)
        {
            actualPrestigePoints -= polutionCost;
            polutionCost *= 1.1f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        


    }
}
