using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Forward Motion
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
 * @version   $Id: ForwardMotion.cs 06340 2023-07-03 11:05:00 1105Z foster $
 * @license   http://fosterjohnson.com/licenses/unity.php FJE Unity Build Licenses
 */


public class ForwardMotion : MonoBehaviour
{
    public float speed = 40.0f;

    void Start()
    {
        
    }

    // Forward movement is applied in the z axis simulations.
    void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector3.forward);
    }
}
