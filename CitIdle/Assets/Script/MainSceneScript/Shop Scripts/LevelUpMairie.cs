using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUpMairie : MonoBehaviour
{

    public void LevelUp()
    {
        LevelManager.statLevelMairie++;
        print(LevelManager.statLevelMairie);
    }
    
}
