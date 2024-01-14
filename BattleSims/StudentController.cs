using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Basic Student Control
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
 * @version   $Id: StudentController.cs 06340 2023-07-03 10:27:06 1027Z foster $
 * @license   http://fosterjohnson.com/licenses/unity.php FJE Unity Build Licenses
 */

public class StudentController : MonoBehaviour
{
    // Keyboard keys move the student along the x axis. Restricted within a defined area (see boundsX).

    public float speed = 20.0f;
    public float horizontalInput;
    public float boundsX = 20.0f;
    public GameObject projectilePrefab;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(horizontalInput * speed * Time.deltaTime * Vector3.right);

        /* Adjusted left and right boundary from the boundsX value in the construct. is referenced here.
         * If the student moves too far in either direction and strikes the boundsX value, its new position will remain at that position regardless of how long the student holds the right or left arrow down.
         * First if statement measures the negative of boundsX. The next if statment measures that distance in the positive.
        */

        if (transform.position.x < -boundsX)
        {
            transform.position = new Vector3(-boundsX, transform.position.y, transform.position.z);
        }
        if (transform.position.x > boundsX)
        {
            transform.position = new Vector3(boundsX, transform.position.y, transform.position.z);
        }

        //Spacebar fires projectile.

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //fires the student's weapon

            GameObject gameObject1 = Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
