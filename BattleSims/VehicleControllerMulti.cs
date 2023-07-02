using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Multiplayer Vehicle Control
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
 * @copyright Copyright (c) 2011-2023 Foster Johnson Enterprises, LLC USA Inc. 
 *            (http://www.fosterjohnson.com)
 * @version   $Id: VehicleControllerMulti.cs 06340 2020-11-21 08:04:06 0804Z foster $
 * @license   http://fosterjohnson.com/licenses/unity.php FJE Unity Build Licenses
 */


public class VehicleControllerMulti : MonoBehaviour
{
    public string forceType;
    public Camera mainCamera;
    
    private float speed = 20.0f;
    private float turnSpeed = 10.0f;
    private float horizontalInput;
    private float forwardInput;

    void Start()
    {
        
    }

    void Update()
    {
        //Add keyboard controls using the correct Input Axes.
        horizontalInput = Input.GetAxis("Horizontal" + forceType);
        forwardInput = Input.GetAxis("Vertical" + forceType);

        // Move vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime *speed * forwardInput);

        //Fine tune speed values in variables for speed and turnSpeed. Horizontal turn values turn right/starboard pressing right button. Left button decreases input values to turn left/port.
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
    }
}
