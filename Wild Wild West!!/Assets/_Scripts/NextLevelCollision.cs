using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextLevelCollision : MonoBehaviour
{
    public GameObject plate;
    GameChange game;
    public GameObject player;

    public void Update()
    {
        if (Mathf.Abs(plate.transform.position.magnitude - player.transform.position.magnitude) <1f)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
       
    }
}
    

