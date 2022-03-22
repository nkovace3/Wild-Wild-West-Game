using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttacking : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    public float targetDistance;
    public int health = 3;
    
    // Update is called once per frame
    void Update()
    {
        
        float distance = Mathf.Abs(enemy.transform.position.magnitude - player.transform.position.magnitude);
        
        if((distance <= 2f) && Input.GetMouseButtonDown(0))
        {
           
            health--;
        }
        if ((distance <= 2f) && Input.GetMouseButtonDown(1))
        {
            health=health-2;
        }
        if (health <= 0)
        {
            enemy.SetActive(false);
        }
    }
}
