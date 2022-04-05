using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BulletDamage : MonoBehaviour
{
    public GameObject player;
    public int health = 100;
    public bool isPlayer = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Bullet"))
        {

            Debug.Log("hit");
            health -= 100;
        }
        if (other.tag.Equals("Beer"))
        {
            health -= 20;
            Destroy(other.gameObject);
        }
    }
    private void Update()
    {
        if(health <= 0)
        {
            
            player.SetActive(false);
            if(isPlayer == true)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);

            }

        }
    }
}
