using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BulletDamage : MonoBehaviour
{
    public GameObject player;
    public int health = 100;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Bullet"))
        {

            Debug.Log("hit");
            health -= 100;
        }
    }
    private void Update()
    {
        if(health <= 0)
        {
            
            player.SetActive(false);
            
           
        }
    }
}
