using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextEnding : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            SceneControllerNextEnding.instance.NextLevel();
        }
    }
}
