using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class NextLevel : MonoBehaviour
{
    string LevelToLoad = "Level 2" ;

    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            Application.LoadLevel(LevelToLoad);
        }

    }
}