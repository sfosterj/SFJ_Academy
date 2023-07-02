using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Camera Switcher | Keyboard Toggle
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
 * @version   $Id: CameraSwitcher.cs 06340 2023-07-11 12:31:06 1231Z foster $
 * @license   http://fosterjohnson.com/licenses/unity.php FJE Unity Build Licenses
 */

public class CameraSwitcher : MonoBehaviour
{
    public Camera mainCamera;
    public Camera followShot;
    public KeyCode switchKey
        ;
    // Setup up an unused keyboard key to view from various cameras. Useful for switching between driver or pilot views and bird's eye view.
    void Update()
    {
        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            followShot.enabled = !followShot.enabled;
        }
    }
}
