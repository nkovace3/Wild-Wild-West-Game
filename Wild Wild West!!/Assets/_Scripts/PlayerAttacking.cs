using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttacking : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;
    public float targetDistance;
    public int health = 3;
    public int health2 = 3;
    public int health3 = 3;
    public int health4 = 3;



    // Update is called once per frame
    void Update()
    {
        
        float distance = Mathf.Abs(enemy.transform.position.magnitude - player.transform.position.magnitude);
        float distance2 = Mathf.Abs(enemy2.transform.position.magnitude - player.transform.position.magnitude);
        float distance3 = Mathf.Abs(enemy3.transform.position.magnitude - player.transform.position.magnitude);
        float distance4 = Mathf.Abs(enemy4.transform.position.magnitude - player.transform.position.magnitude);


        if ((distance <= 2f) && Input.GetMouseButtonDown(0))
        {
           
            health--;
        }
        if ((distance <= 2f) && Input.GetMouseButtonDown(1))
        {
            health = health-2;
        }
        if (health <= 0)
        {
            enemy.SetActive(false);
        }
        //

        if ((distance2 <= 2f) && Input.GetMouseButtonDown(0))
        {

            health2--;
        }
        if ((distance2 <= 2f) && Input.GetMouseButtonDown(1))
        {
            health2 = health2 - 2;
        }
        if (health2 <= 0)
        {
            enemy2.SetActive(false);
        }


        if ((distance3 <= 2f) && Input.GetMouseButtonDown(0))
        {

            health3--;
        }
        if ((distance3 <= 2f) && Input.GetMouseButtonDown(1))
        {
            health3 = health3 - 2;
        }
        if (health3 <= 0)
        {
            enemy3.SetActive(false);
        }

        if ((distance4 <= 2f) && Input.GetMouseButtonDown(0))
        {

            health4--;
        }
        if ((distance4 <= 2f) && Input.GetMouseButtonDown(1))
        {
            health4 = health4 - 2;
        }
        if (health4 <= 0)
        {
            enemy4.SetActive(false);
        }


    }
}
