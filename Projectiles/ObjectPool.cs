using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Basic Object Pool
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
 * @version   $Id: ObjectPool.cs 32544 2021-08-29 10:23:00 foster $
 * @license   http://fosterjohnson.com/licenses/unity.php FJE Unity Build Licenses
 */

public class ObjectPool : MonoBehaviour
{
    //Load correct ammunition into Pooled Object in Inspector. Different weapons in same system can have specific munitions by loading the generic ObjetPool in the Inspector.

	public static ObjectPool current;
	public GameObject pooledObject;
	public int pooledAmount = 1;
	public bool willGrow = true;

	public List<GameObject> pooledObjects;

   void Awake()
    {
		current = this;
    }

    //When scene loads an array of pooled collects based on pooledAmount value. This amount should indicate standard unit number of clip or ammo source.
    void Start()
    {
        pooledObjects = new List<GameObject>();
        for (int i = 0; i <pooledAmount; i++)
        {
            GameObject obj = (GameObject)Instantiate(pooledObject);
            obj.SetActive(false);
            pooledObjects.Add(obj);
        }
    }

    //Feeds the projectiles grouped as ammunition clip. Set or change clip size using pooledAmount in Inspector.
     public GameObject GetPooledObject()
    {
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            if (!pooledObjects [i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }
        if (willGrow)
        {
            GameObject obj = (GameObject)Instantiate(pooledObject);
            pooledObjects.Add(obj);
            return obj;
        }
        return null;
    }


}
