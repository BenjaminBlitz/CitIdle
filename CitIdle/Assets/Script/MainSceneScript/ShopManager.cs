using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public GameObject MairieLvl;
    public GameObject CitoyenLvl ;
    public GameObject BankLvl ;


    void Update()
    {
        MairieLvl.GetComponent<TMP_Text>().text = "Mairie level = " + LevelManager.statLevelMairie + " prix  = " + MairieManager.priceMairie;
        CitoyenLvl.GetComponent<TMP_Text>().text = "Citoyen level = " + LevelManager.statLevelCitoyen + " prix = " + CitoyenManager.priceCitoyen;
        BankLvl.GetComponent<TMP_Text>().text = "Bank level = " + LevelManager.statLevelBank + " prix = " + BankManager.priceBank;

    }
}

