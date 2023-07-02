using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Basic Bullet Automatic Fire
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
 * @copyright Copyright (c) 2011-2021 Foster Johnson Enterprises, LLC USA Inc. 
 *            (http://www.fosterjohnson.com)
 * @version   $Id: BulletFireScript.cs 32544 2021-08-29 09:46:00 foster $
 * @license   http://fosterjohnson.com/licenses/unity.php FJE Unity Build Licenses
 */

public class BulletFireScript : MonoBehaviour
{
    //Firing Time is set to weapons automatic interval, or automatic trigger speed.
    public float fireTime = .1f;
    private void Start()
    {
        //Interface buttons can call "Fire" to trigger weapon.
        InvokeRepeating("Fire", fireTime, fireTime);

    }
    void Fire ()
    {
        //If the weapon is not firing, load the projectile set in Pooled Object and prepare to fire.
        GameObject obj = ObjectPool.current.GetPooledObject();
        if (obj == null) return;
        obj.transform.position = transform.position;
        obj.transform.rotation = transform.rotation;
        obj.SetActive(true);

    }
}
