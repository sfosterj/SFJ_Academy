using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Propeller Rotation / Mechanical
 *
 * LICENSE
 * This source file is subject to the Foster Johnson Eneterpises'
 * license included in Unity builds where it is used.
 * See the file FJE_LICENSE.txt.
 * It is also available at this URL:
 * http://fosterjohnson.com/licenses/unity.php
 * @CSA       DoD
 * @CI        None
 * @category  Training
 * @build     [DEVELOPER'S INSTRUCTION: Replace this with name of Build that includes this src.]
 * 
 * @copyright Copyright (c) 2011-2022 Foster Johnson Enterprises, LLC USA Inc. 
 *            (http://www.fosterjohnson.com)
 * @version   $Id: RotatePropeller.cs 94610 2022-01-09 10:11:59 1011Z foster $
 * @license   http://fosterjohnson.com/licenses/unity.php FJE Unity Build Licenses
 */

public class RotatePropeller : MonoBehaviour
{
    // Rotates a propellor Game Object at Uniform speed.
    
    public float speed = 1f;
    
    void Start()
    {
        
    }

    // Rotate prop clockwise once per second. Fine tune z angle value to simulate illusion of propeller strobe effect.
    void Update()
    {
        transform.Rotate(new Vector3 (0, 0, 36) * speed * Time.deltaTime) ;
    }
}
