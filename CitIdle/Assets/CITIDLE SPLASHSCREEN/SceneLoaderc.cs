using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoaderc : MonoBehaviour
{
    [SerializeField] string m_SceneName;

    public void LoadScene()
    {
        SceneManager.LoadScene(m_SceneName);
    }
}
