using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Basic Bullet Optimizer/Detroy
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
 * @version   $Id: BulletDestroy.cs 32544 2021-08-29 14:55:00 foster $
 * @license   http://fosterjohnson.com/licenses/unity.php FJE Unity Build Licenses
 */

public class BulletDestroy : MonoBehaviour
{
    /*
     * After the projectile fires, it needs to be destroyed from game cache. 
     * Set that time interval. Set the peojecticle to inactive so nothing in can access it. 
     * This also makes it invisible to the student. 
     * If it is disbaled, it's invocation needs to be removed.
    */

    public void DestroyObjectDelayed()
    {
        Invoke("Destroy", 0.001f);
    }

    private void OnDestroy()
    {
        gameObject.SetActive(false);
    }

    private void OnDisable()
    {
        CancelInvoke();

    }
}


