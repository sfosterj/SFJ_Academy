using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Basic Bullet Muzzle Velocity
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
 * @copyright Copyright (c) 2011-2021 Foster Johnson Enterprises, LLC *            (http://www.fosterjohnson.com)
 * @version   $Id: BulletScript.cs 32544 2021-08-29 13:08:00 foster $
 * @license   http://fosterjohnson.com/licenses/unity.php FJE Unity Build Licenses
 */
public class BulletScript : MonoBehaviour
{
    //Speed is uniform. Use a RigidBody with gravity to simulate arc degradation. 

    public float speed = .1f;

    private void Update()
    {
        //Fires the projecticle from and along the y-axis.
        transform.Translate(0, speed * Time.deltaTime, 0);
    }
}
