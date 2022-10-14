using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrestigeButton : MonoBehaviour
{



    // Start is called before the first frame update
    public void clickOnPark()
    {
        if (PrestigeManager.prestigePoints >= PrestigeManager.incomeCost)
        {
            PrestigeManager.upradeIncome();
            

        }
        if (PrestigeManager.prestigePoints >= PrestigeManager.populationCost)
        {
            PrestigeManager.prestigePoints -= PrestigeManager.populationCost;
            PrestigeManager.populationLevel++;


        }
        if (PrestigeManager.prestigePoints >= PrestigeManager.polutionCost)
        {
            PrestigeManager.prestigePoints -= PrestigeManager.polutionCost;
            PrestigeManager.polutionLevel++;


        }
        


    }
}
