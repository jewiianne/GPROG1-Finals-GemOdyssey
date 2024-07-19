using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Startlvlone : MonoBehaviour
{
    public void OnStartClick()
    {
        SceneManager.LoadScene("Level1");
    }
}
