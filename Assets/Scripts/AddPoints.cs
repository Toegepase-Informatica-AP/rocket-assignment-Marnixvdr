using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class AddPoints : MonoBehaviour
{

    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            Score.scoreValue += 1;
            Destroy(gameObject);
        }

    }
}
