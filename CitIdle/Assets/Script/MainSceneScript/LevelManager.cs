using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class LevelManager : MonoBehaviour
{
    public int levelPark = 1;
    public int levelMairie = 1;
    public int Bank = 1;
    public int Citoyen = 1;

    public static int statLevelPark = 1;
    public static int statLevelMairie = 1;
    public static int statLevelBank = 1;
    public static int statLevelCitoyen = 1;

    public GameObject mairieV1;
    public GameObject mairieV2;
    public GameObject mairieV3;
    public GameObject mairieV4;

    public GameObject ShopNiveau1;
    public GameObject ShopNiveau2;
    public GameObject ShopNiveau3;
    public GameObject ShopNiveau4;

    public GameObject BankNiveau1;
    public GameObject BankNiveau2;
    public GameObject BankNiveau3;
    public GameObject BankNiveau4;

    public GameObject ParkNiveau1;
    public GameObject ParkNiveau2;
    public GameObject ParkNiveau3;
    public GameObject ParkNiveau4;

    public GameObject LaboNiveau1;
    public GameObject LaboNiveau2;
    public GameObject LaboNiveau3;
    public GameObject LaboNiveau4;

    public GameObject Background1;
    public GameObject Background2;
    public GameObject Background3;
    public GameObject Background4;

    public GameObject BlackScreen;

    private bool One = true; 
    private bool Two = true; 
    private bool Tree = true; 
    private bool Four = true; 

    private Animator Transition = null;
    public void Start()
    { 
        Transition = GetComponent<Animator>();
        mairieV1 = GameObject.Find("mairieV1");
        mairieV1.SetActive(true);
        mairieV2 = GameObject.Find("mairieV2");
        mairieV2.SetActive(false);
        mairieV3 = GameObject.Find("mairieV3");
        mairieV3.SetActive(false);
        mairieV4 = GameObject.Find("mairieV4");
        mairieV4.SetActive(false);

        ShopNiveau1 = GameObject.Find("ShopNiveau1");
        ShopNiveau1.SetActive(true);
        ShopNiveau2 = GameObject.Find("ShopNiveau2");
        ShopNiveau2.SetActive(false);
        ShopNiveau3 = GameObject.Find("ShopNiveau3");
        ShopNiveau3.SetActive(false);
        ShopNiveau4 = GameObject.Find("ShopNiveau4");
        ShopNiveau4.SetActive(false);

        BankNiveau1 = GameObject.Find("BankNiveau1");
        BankNiveau1.SetActive(true);
        BankNiveau2 = GameObject.Find("BankNiveau2");
        BankNiveau2.SetActive(false);
        BankNiveau3 = GameObject.Find("BankNiveau3");
        BankNiveau3.SetActive(false);
        BankNiveau4 = GameObject.Find("BankNiveau4");
        BankNiveau4.SetActive(false);

        ParkNiveau1 = GameObject.Find("ParkNiveau1");
        ParkNiveau1.SetActive(true);
        ParkNiveau2 = GameObject.Find("ParkNiveau2");
        ParkNiveau2.SetActive(false);
        ParkNiveau3 = GameObject.Find("ParkNiveau3");
        ParkNiveau3.SetActive(false);
        ParkNiveau4 = GameObject.Find("ParkNiveau4");
        ParkNiveau4.SetActive(false);

        LaboNiveau1 = GameObject.Find("LaboNiveau1");
        LaboNiveau1.SetActive(true);
        LaboNiveau2 = GameObject.Find("LaboNiveau2");
        LaboNiveau2.SetActive(false);
        LaboNiveau3 = GameObject.Find("LaboNiveau3");
        LaboNiveau3.SetActive(false);
        LaboNiveau4 = GameObject.Find("LaboNiveau4");
        LaboNiveau4.SetActive(false);

        Background1 = GameObject.Find("Background1");
        Background1.SetActive(true);
        Background2 = GameObject.Find("Background2");
        Background2.SetActive(false);
        Background3 = GameObject.Find("Background3");
        Background3.SetActive(false);
        Background4 = GameObject.Find("Background4");
        Background4.SetActive(false);
    }

    public void Update()
    {
        Animation anim = GetComponent<Animation>();
        if (levelMairie == 1 && One)
        {
            BlackScreen.SetActive(false);
            mairieV1.SetActive(true);
            mairieV2.SetActive(false);
            mairieV3.SetActive(false);
            mairieV4.SetActive(false);

            ShopNiveau1.SetActive(true);
            ShopNiveau2.SetActive(false);
            ShopNiveau3.SetActive(false);
            ShopNiveau4.SetActive(false);

            BankNiveau1.SetActive(true);
            BankNiveau2.SetActive(false);
            BankNiveau3.SetActive(false);
            BankNiveau4.SetActive(false);

            ParkNiveau1.SetActive(true);
            ParkNiveau2.SetActive(false);
            ParkNiveau3.SetActive(false);
            ParkNiveau4.SetActive(false);

            LaboNiveau1.SetActive(true);
            LaboNiveau2.SetActive(false);
            LaboNiveau3.SetActive(false);
            LaboNiveau4.SetActive(false);

            Background1.SetActive(true);
            Background2.SetActive(false);
            Background3.SetActive(false);
            Background4.SetActive(false);

            One = false;
        }
        if (levelMairie == 2 && Two)
        {

            BlackScreen.SetActive(true);
            Transition.Play("lvlup_fade_up");
            //Thread.Sleep(2000);
            mairieV1.SetActive(false);
            mairieV2.SetActive(true);
            mairieV3.SetActive(false);
            mairieV4.SetActive(false);

            ShopNiveau1.SetActive(false);
            ShopNiveau2.SetActive(true);
            ShopNiveau3.SetActive(false);
            ShopNiveau4.SetActive(false);

            BankNiveau1.SetActive(false);
            BankNiveau2.SetActive(true);
            BankNiveau3.SetActive(false);
            BankNiveau4.SetActive(false);

            ParkNiveau1.SetActive(false);
            ParkNiveau2.SetActive(true);
            ParkNiveau3.SetActive(false);
            ParkNiveau4.SetActive(false);

            LaboNiveau1.SetActive(false);
            LaboNiveau2.SetActive(true);
            LaboNiveau3.SetActive(false);
            LaboNiveau4.SetActive(false);

            Background1.SetActive(false);
            Background2.SetActive(true);
            Background3.SetActive(false);
            Background4.SetActive(false);

            Two = false;

            PrestigeManager.prestigePoints += 0.0001f;

            
        }
        if (levelMairie == 3 && Tree)
        {
            BlackScreen.SetActive(true);
            //Transition.Play("lvlup_fade_up");
            anim.Play();
            //Thread.Sleep(2000);
            mairieV1.SetActive(false);
            mairieV2.SetActive(false);
            mairieV3.SetActive(true);
            mairieV4.SetActive(false);

            ShopNiveau1.SetActive(false);
            ShopNiveau2.SetActive(false);
            ShopNiveau3.SetActive(true);
            ShopNiveau4.SetActive(false);

            BankNiveau1.SetActive(false);
            BankNiveau2.SetActive(false);
            BankNiveau3.SetActive(true);
            BankNiveau4.SetActive(false);

            ParkNiveau1.SetActive(false);
            ParkNiveau2.SetActive(false);
            ParkNiveau3.SetActive(true);
            ParkNiveau4.SetActive(false);

            LaboNiveau1.SetActive(false);
            LaboNiveau2.SetActive(false);
            LaboNiveau3.SetActive(true);
            LaboNiveau4.SetActive(false);

            Background1.SetActive(false);
            Background2.SetActive(false);
            Background3.SetActive(true);
            Background4.SetActive(false);

            Tree = false;
            PrestigeManager.prestigePoints += 0.001f;
        }
        if (levelMairie == 4 && Four)
        {
            BlackScreen.SetActive(true);
            //Transition.Play("lvlup_fade_up");
            //Thread.Sleep(2000);
            anim.Play();
            mairieV1.SetActive(false);
            mairieV2.SetActive(false);
            mairieV3.SetActive(false);
            mairieV4.SetActive(true);

            ShopNiveau1.SetActive(false);
            ShopNiveau2.SetActive(false);
            ShopNiveau3.SetActive(false);
            ShopNiveau4.SetActive(true);

            BankNiveau1.SetActive(false);
            BankNiveau2.SetActive(false);
            BankNiveau3.SetActive(false);
            BankNiveau4.SetActive(true);

            ParkNiveau1.SetActive(false);
            ParkNiveau2.SetActive(false);
            ParkNiveau3.SetActive(false);
            ParkNiveau4.SetActive(true);

            LaboNiveau1.SetActive(false);
            LaboNiveau2.SetActive(false);
            LaboNiveau3.SetActive(false);
            LaboNiveau4.SetActive(true);

            Background1.SetActive(false);
            Background2.SetActive(false);
            Background3.SetActive(false);
            Background4.SetActive(true);

            Four = false;
            PrestigeManager.prestigePoints += 0.1f;
        }
    }
}

