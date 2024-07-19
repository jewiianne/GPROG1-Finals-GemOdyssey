using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending2 : MonoBehaviour
{
    public void OnUseClick()
    {
        SceneManager.LoadScene("StartScene");
    }

    public void OnDontClick()
    {
        SceneManager.LoadScene("BadEnding");
    }
}
