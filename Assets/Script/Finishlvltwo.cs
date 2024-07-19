using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finishlvltwo : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            SceneControllerLVLT.instance.NextLevel();
        }
    }
}
