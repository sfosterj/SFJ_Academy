using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Basic Camera Control
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
 * @copyright Copyright (c) 2011-2021 Foster Johnson Enterprises, LLC 
 *            (http://www.fosterjohnson.com)
 * @version   $Id: HoverCamera.cs 94610 2021-08-11 15:14:25 1514Z foster $
 * @license   http://fosterjohnson.com/licenses/unity.php FJE Unity Build Licenses
 */

public class HoverCamera : MonoBehaviour
{
    //Point the camera at the object in the entry box in the Inspector.
    public GameObject targetVehicle;

    //change the position of the camera relative to the target vehicle
    private Vector3 offset = new Vector3 (0, 21.55f, -3.5f);

    void Start()
    {
        
    }
    //use LastUpdate to dampen camera movement. Camera position will update after the vehicle moves.
    void LateUpdate()
    {
        //Camera moves with target vehicle. Position is adjustable in variable named "offset", line 31.
        transform.position = targetVehicle.transform.position + offset;
    }
}
