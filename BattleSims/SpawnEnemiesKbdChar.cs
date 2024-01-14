using UnityEngine;

/*
 * Spawn Enemies | OPFOR
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
 * @version   $Id: SpawnEnemiesKbdChar.cs 06340 2023-07-03T13:05:24-04:00 foster $ 
 * @license   http://fosterjohnson.com/licenses/unity.php FJE Unity Build Licenses
 */


public class SpawnEnemiesKbdChar : MonoBehaviour
{
    public GameObject[] enemiesPrefabs;
    public int enemyIndex;

    private float forceSpawnX = 20;
    private float forceSpawnZ = 20;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            Vector3 forceSpawn = new Vector3(Random.Range(-forceSpawnX, forceSpawnX), 0, forceSpawnZ);

            int enemyIndex = Random.Range(0,enemiesPrefabs.Length);
            Instantiate(enemiesPrefabs[enemyIndex], forceSpawn, enemiesPrefabs[enemyIndex].transform.rotation);

        }
    }
}
