using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Basic Collision Detection | Destroys target and projectile for optimization
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
 * @version   $Id: CollisionDetector.cs 06340 2023-07-03T15:08:20 foster $ 
 * @license   http://fosterjohnson.com/licenses/unity.php FJE Unity Build Licenses
 */

public class CollisionDetector : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
