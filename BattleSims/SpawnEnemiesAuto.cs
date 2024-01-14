using UnityEngine;

/*
 * Spawn Enemies Automatically | OPFOR
 *
 * LICENSE
 * This source file is subject to the Foster Johnson Enterprises'
 * license included in Unity builds where it is used.
 * See the file FJE_LICENSE.txt.
 * It is also available at this URL:
 * http://fosterjohnson.com/licenses/unity.php
 * @CSA       DoD
 * @CI        None
 * @category  Training
 * @build     [DEVELOPER'S INSTRUCTION: Replace this with name of Build that includes this src.]
 * 
 * @copyright Copyright (c)2023 SFJ Academy 
 *            (http://www.sfjacademy.com)
 * @version   $Id: SpawnEnemiesAuto.cs 06340 2023-07-03T13:05:24-04:00 foster $ 
 * @license   http://fosterjohnson.com/licenses/unity.php FJE Unity Build Licenses
 */


public class SpawnEnemiesAuto : MonoBehaviour
{
    public GameObject[] enemiesPrefabs;
    public int enemyIndex;

    //Random positioning
    private float forceSpawnX = 20;
    private float forceSpawnZ = 20;

    //Random Timing
    private float startDelay = 2f;
    private float spawnInterval = 2f;

    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", startDelay, spawnInterval);
    }

    // Randomly generates an enemy in random locations at simulation start.
    void Update()
    {

    }

    void SpawnRandomEnemy()
    {
        int enemyIndex = Random.Range(0, enemiesPrefabs.Length);
        Vector3 forceSpawn = new Vector3(Random.Range(-forceSpawnX, forceSpawnX), 0, forceSpawnZ);
        Instantiate(enemiesPrefabs[enemyIndex], forceSpawn, enemiesPrefabs[enemyIndex].transform.rotation);
    }
}
