using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image image1;
    public Image image2;
    public Image image3;
    int counter = 0;
    public int health;

    public void Awake()
    {
        health = 500;
    }

    
 
 

    // Update is called once per frame
    void Update()
    {
        health--;
        if (health == 250) {
            Destroy(image1);
        }
        else if(health == 100)
        {
            Destroy(image2);
        }
        else if (health == 0)
        {
            Destroy(image3);
        }
    }
}
