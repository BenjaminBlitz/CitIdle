using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToLeft : MonoBehaviour
{
    public void GoLeft()
    {
        SceneManager.LoadScene("Gauche");
    }
}

