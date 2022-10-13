using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PollutionManager : MonoBehaviour
{
    public static float InternalePollution;
    public float Pollution;
    public GameObject Displaypollution; 
    private void Update()
    {

        Displaypollution.GetComponent<TMP_Text>().text = " Pop = " + Pollution;
    }
}
