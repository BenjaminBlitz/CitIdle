using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;
public class PrestigeManager : MonoBehaviour
{
    public float actualPrestigePoints;
    public static float prestigePoints;

    public static float incomeCost=1;
    public static float populationCost=1;
    public static float polutionCost=1;

    public static int incomeLevel;
    public static int populationLevel;
    public static int polutionLevel;
    public GameObject DisplayPrestige;
    public GameObject DisplayIncome;
    public GameObject DisplayPopulation;
    public GameObject DisplayPolution;
    public string sceneName;

    // Start is called before the first frame update
    void Start()
    {
        /*if (incomeLevel < 1) { incomeLevel = 1; }
        if (populationLevel < 1) { populationLevel = 1; }
        if (polutionLevel < 1) { polutionLevel = 1; }*/
        sceneName = SceneManager.GetActiveScene().name;
        prestigePoints = PlayerPrefs.GetFloat("prestige");

        incomeLevel = PlayerPrefs.GetInt("prestigeIncome");
        incomeCost = 1 + PlayerPrefs.GetFloat("prestigeIncomeCost");

        populationLevel = PlayerPrefs.GetInt("prestigePopulation");
        populationCost = 1 + PlayerPrefs.GetFloat("prestigePopulationCost");

        polutionLevel = PlayerPrefs.GetInt("prestigePolution");
        polutionCost = 1 + PlayerPrefs.GetFloat("prestigePolutionCost");
        actualPrestigePoints = prestigePoints;
    }

    public static void upradeIncome()
    {   
        
        if (prestigePoints >= incomeCost)
        {
            prestigePoints -= incomeCost;
            incomeCost *= 1.05f;
            MoneyManager.incomeLevel +=1;
            incomeLevel++;
        }
    }    
    public static void upradePopulation()
    {
        if (prestigePoints >= populationCost)
        {
            prestigePoints -= populationCost;
            populationCost *= 1.1f;
            PopulationManager.populationLevel++;
            populationLevel++;
        }
    }    
    public static void upgradePolution()
    {
        if (prestigePoints >= polutionCost)
        {
            prestigePoints -= polutionCost;
            polutionCost *= 1.1f;
            PolutionManager.polutionLevel++;
            polutionLevel++;
        }
    }
    public void prestigeGame()
    {
        SceneManager.LoadScene(sceneName);
        MoneyManager.InternalMoney = 0;
    }
    /*public static void upPoint()
    {
        prestigePoints+=100;
    }*/

    // Update is called once per frame
    void Update()
    {
        actualPrestigePoints = prestigePoints;
        PlayerPrefs.SetFloat("prestige",actualPrestigePoints);

        PlayerPrefs.SetInt("prestigeIncome",incomeLevel);
        PlayerPrefs.SetFloat("prestigeIncomeCost",incomeCost);

        PlayerPrefs.SetInt("prestigePopulation",populationLevel);
        PlayerPrefs.SetFloat("prestigePopulationCost", populationCost);

        PlayerPrefs.SetInt("prestigePolution",polutionLevel);
        PlayerPrefs.SetFloat("prestigePolutionCost", polutionCost);

        DisplayPrestige.GetComponent<TMP_Text>().text = " Prestige points = " + actualPrestigePoints;
        DisplayIncome.GetComponent<TMP_Text>().text = " Income level = " + incomeLevel + " cost :" + incomeCost;
        DisplayPopulation.GetComponent<TMP_Text>().text = " Population level = " + populationLevel + " cost :" + populationCost;
        DisplayPolution.GetComponent<TMP_Text>().text = " Polution level = " + polutionLevel + " cost :" + polutionCost;



    }
}
