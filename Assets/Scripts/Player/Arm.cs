﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arm : MonoBehaviour
{
    public float distanceBetween;

    // Use this for initialization
    void Awake()
    {
		
	}
	
	// Update is called once per frame
	void LateUpdate()
    {
		Vector3 pos1 = Camera.main.WorldToScreenPoint(transform.position);
		distanceBetween = Vector3.Distance(pos1, Input.mousePosition);

        if (distanceBetween > 100)
        {
            Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
            Vector3 dir = Input.mousePosition - pos;
            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
    }
}
