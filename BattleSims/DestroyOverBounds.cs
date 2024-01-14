using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Destroy Objects out of Simulator Bounds | Optimization
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
 * @version   $Id: DestroyOverBounds.cs 06340 2023-07-03 11:45:00 1145Z foster $
 * @license   http://fosterjohnson.com/licenses/unity.php FJE Unity Build Licenses
 */


public class DestroyOverBounds : MonoBehaviour
{
    // Set boundaries based upon what can be seen in any camera view.

    private float horizonBounds = 60;
    private float rearHorizonBounds = -60;
    void Start()
    {
        
    }

    // If the projectile or any game object moves past horizon (add else-if, to statement for more than one bounds when needed), destroy it.
    void Update()
    {
        if (transform.position.z > horizonBounds)
        {
            Destroy(gameObject);
        } else if (transform.position.z < rearHorizonBounds)
        {
            Destroy(gameObject);
            Debug.Log("Mission failed.");
        }
    }
}
