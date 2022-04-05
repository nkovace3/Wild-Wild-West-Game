using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public GameObject player;
    public static int playerHealth = 10;
    public Image image1;
    public Image image2;
    public Image image3;

    void Update()
    {
        if (playerHealth <= 0)
        {
            player.SetActive(false);
            Invoke("Restart", 1);

        }

        if (playerHealth <= 7)
        {
            image1.DisableSpriteOptimizations();
        }
        if (playerHealth <= 4)
        {
            image2.DisableSpriteOptimizations();
        }
        if (playerHealth <= 0)
        {
            image3.DisableSpriteOptimizations();
        }
    }
    void Restart()
    {
        playerHealth = 10;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void DecrementByOne()
    {
        Debug.Log(playerHealth);
        playerHealth--;
    }

    public void DecrementByThree()
    {

        Debug.Log(playerHealth);
        playerHealth -= 3;
    }
}
