using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerAttacking : MonoBehaviour
{
    public GameObject player;
    public GameObject [] enemy;
    public float targetDistance;
    public int health = 5;
    public int health2 = 5;
    public int health3 = 5;
    public int health4 = 5;
    public int bossHealth = 10;
    public Text XP;
    public int[] exp = new int[5];
    public int punchStrength = 1;
    public int experience = 0;

    // Update is called once per frame
    void Update()
    {
        float bossDistance = Mathf.Abs(enemy[0].transform.position.magnitude - player.transform.position.magnitude);
        float distance = Mathf.Abs(enemy[1].transform.position.magnitude - player.transform.position.magnitude);
        float distance2 = Mathf.Abs(enemy[2].transform.position.magnitude - player.transform.position.magnitude);
        float distance3 = Mathf.Abs(enemy[3].transform.position.magnitude - player.transform.position.magnitude);
        float distance4 = Mathf.Abs(enemy[4].transform.position.magnitude - player.transform.position.magnitude);

        if (experience == 200)
        {
            punchStrength++;
        }

        if ((distance <= 2f) && Input.GetMouseButtonDown(0))
        {

            health-=punchStrength;
        }
        if ((distance <= 2f) && Input.GetMouseButtonDown(1))
        {
            health = health - 2;
        }
        if (health <= 0)
        {
            enemy[1].SetActive(false);
            exp[0] = 100;
            experience += 100;
            
        }
        //

        if ((distance2 <= 2f) && Input.GetMouseButtonDown(0))
        {

            health2-=punchStrength;
        }
        if ((distance2 <= 2f) && Input.GetMouseButtonDown(1))
        {
            health2 = health2 - 2;
        }
        if (health2 <= 0)
        {
            enemy[2].SetActive(false);
            exp[1] = 100;
            experience += 100;
        }


        if ((distance3 <= 2f) && Input.GetMouseButtonDown(0))
        {

            health3-=punchStrength;
        }
        if ((distance3 <= 2f) && Input.GetMouseButtonDown(1))
        {
            health3 = health3 - 2;
        }
        if (health3 <= 0)
        {
            enemy[3].SetActive(false);
            exp[2] = 100;
            experience += 100;
        }

        //

        if ((distance4 <= 2f) && Input.GetMouseButtonDown(0))
        {

            health4-=punchStrength;
        }
        if ((distance4 <= 2f) && Input.GetMouseButtonDown(1))
        {
            health4 = health4 - 2;
        }
        if (health4 <= 0)
        {
            enemy[4].SetActive(false);
            exp[3] = 100;
            experience += 100;

        }
        //
        if ((bossDistance <= 2f) && Input.GetMouseButtonDown(0))
        {
            bossHealth-=punchStrength;
        }
        if ((bossDistance <= 2f) && Input.GetMouseButtonDown(1))
        {
            bossHealth = bossHealth - 2;
        }
        if (bossHealth <= 0)
        {
            enemy[0].SetActive(false);
            exp[4] = 500;


        }

        XP.text = "Experience:" + (exp[0]+ exp[1]+ exp[2]+ exp[3]+ exp[4]);

    }
}
