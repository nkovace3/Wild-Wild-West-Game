using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerAttackingTrain : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    public float targetDistance;
    public int health = 3;
    public int health2 = 3;
    public int bossHealth = 10;
    public Text XP;
    public int[] exp = new int[3];


    // Update is called once per frame
    void Update()
    {

        float distance = Mathf.Abs(enemy.transform.position.magnitude - player.transform.position.magnitude);

        if ((distance <= 2f) && Input.GetMouseButtonDown(0))
        {

            health--;
        }
        if ((distance <= 2f) && Input.GetMouseButtonDown(1))
        {
            health = health - 2;
        }
        if (health <= 0)
        {
            Destroy(enemy);
            exp[0] = 100;
        }
        //

       
        //
      

        XP.text = "Experience:" + (exp[0] + exp[1] + exp[2]);

    }
}
