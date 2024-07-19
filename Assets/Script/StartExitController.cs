using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartExitController : MonoBehaviour
{
    public void OnStartClick()
    {
        SceneManager.LoadScene("Opening");
    }

    public void OnExitClick()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();        
    }
}
