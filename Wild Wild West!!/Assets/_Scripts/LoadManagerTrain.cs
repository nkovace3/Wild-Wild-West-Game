using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadManagerTrain : PlayerAttackingTrain
{
    public GameObject[] characterPrefabs;
    public Transform spawn;
    public CameraFollow cameraFollow;
    public NextLevelCollision nextLevel;
   

    // Start is called before the first frame update
    void Start()
    {
        int selectedChar = PlayerPrefs.GetInt("selectedChar");
        GameObject prefab = characterPrefabs[selectedChar];
        GameObject clone = Instantiate(prefab, spawn.position, Quaternion.identity);

        player = clone;
        cameraFollow.player = clone.transform;
        nextLevel.player = clone;
    }
}
