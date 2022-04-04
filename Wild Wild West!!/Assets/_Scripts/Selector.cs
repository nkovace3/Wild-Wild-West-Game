using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selector : MonoBehaviour
{
    public GameObject PlayerOne;
    public GameObject PlayerTwo;
    public GameObject PlayerThree;
    private Vector3 CharacterPos;
    private Vector3 offScreen;
    private int charInt = 1;
    private SpriteRenderer PlayerOneRender; 
    private SpriteRenderer PlayerTwoRender;
    private SpriteRenderer PlayerThreeRender;

    private void Awake()
    {
        CharacterPos = PlayerOne.transform.position;
        offScreen = PlayerTwo.transform.position;
        PlayerOneRender = PlayerOne.GetComponent<SpriteRenderer>();
        PlayerTwoRender = PlayerTwo.GetComponent<SpriteRenderer>();
        PlayerThreeRender = PlayerThree.GetComponent<SpriteRenderer>();

    }

    public void Next()
    {
        switch (charInt)
        {
            case 1:
                PlayerOneRender.enabled = false;
                PlayerOne.transform.position = offScreen;
                PlayerTwo.transform.position = CharacterPos;
                PlayerTwoRender.enabled = true;
                charInt++;
                break;
            case 2:
                PlayerTwoRender.enabled = false;
                PlayerTwo.transform.position = offScreen;
                PlayerThree.transform.position = CharacterPos;
                PlayerThreeRender.enabled = true;
                charInt++;
                break;
            case 3:
                PlayerThreeRender.enabled = false;
                PlayerThree.transform.position = offScreen;
                PlayerOne.transform.position = CharacterPos;
                PlayerOneRender.enabled = true;
                charInt = 1;
                break;
            default:
                PlayerOneRender.enabled = true;
                PlayerOne.transform.position = CharacterPos;
                PlayerTwoRender.enabled = false;
                PlayerTwo.transform.position = offScreen;
                PlayerThreeRender.enabled = false;
                PlayerThree.transform.position = offScreen;
                break;

        }
    }
    public void playGame()
    {

    }

}

