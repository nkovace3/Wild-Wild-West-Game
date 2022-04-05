using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadManager : PlayerAttacking
{
    public GameObject[] characterPrefabs;
    public Transform spawn;
    public EnemyController[] enemyController;
    public CameraFollow cameraFollow;
    public EnemyBossController bossController;
    public NextLevelCollision nextLevel;

    // Start is called before the first frame update
    void Start()
    {
        int selectedChar = PlayerPrefs.GetInt("selectedChar");
        GameObject prefab = characterPrefabs[selectedChar];
        GameObject clone = Instantiate(prefab, spawn.position, Quaternion.identity);

        enemyController[0].player = clone;
        enemyController[1].player = clone;
        enemyController[2].player = clone;
        enemyController[3].player = clone;
        cameraFollow.player = clone.transform;
        bossController.player = clone;
        nextLevel.player = clone;
        player = clone;
    }


}