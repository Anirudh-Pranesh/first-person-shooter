using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dmgplayer : MonoBehaviour
{
    private Target target;

    void Start()
    {
        // Find the player object in the scene and get its PlayerController script
        GameObject player = GameObject.Find("Player");
        if (player != null)
        {
            target = player.GetComponent<Target>();
        }
        else
        {
            Debug.LogError("Player GameObject not found!");
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        // Check if the object it collided with is named "Player"
        if (collision.gameObject.name == "Player")
        {
            target.TakeDamage(5f);
        }
    }
}
