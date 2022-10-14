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
    public string sceneName;

    // Start is called before the first frame update
    void Start()
    {
        sceneName = SceneManager.GetActiveScene().name;
        prestigePoints = PlayerPrefs.GetFloat("prestige");
        actualPrestigePoints = prestigePoints;
    }

    public static void upradeIncome()
    {   
        
        if (prestigePoints >= incomeCost)
        {
            prestigePoints -= incomeCost;
            incomeCost *= 1.1f;
            MoneyManager.incomeLevel +=1;
        }
    }    
    public static void upradePopulation()
    {
        if (prestigePoints >= populationCost)
        {
            prestigePoints -= populationCost;
            populationCost *= 1.1f;
        }
    }    
    public static void upgradePolution()
    {
        if (prestigePoints >= polutionCost)
        {
            prestigePoints -= polutionCost;
            polutionCost *= 1.1f;
        }
    }
    public void prestigeGame()
    {
        SceneManager.LoadScene(sceneName);
        print(prestigePoints);
    }
    public static void upPoint()
    {
        prestigePoints++;
    }

    // Update is called once per frame
    void Update()
    {
        actualPrestigePoints = prestigePoints;
        PlayerPrefs.SetFloat("prestige",actualPrestigePoints);

        DisplayPrestige.GetComponent<TMP_Text>().text = " Prestige points = " + actualPrestigePoints;



    }
}
