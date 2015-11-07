﻿using UnityEngine;
using System.Collections;

public class BackAndForth : MonoBehaviour {

    public float speed = 3f;
    public float maxZ = 5f;
    public float minZ = -5f;

    private int direction = 1;
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, 0, direction * speed * Time.deltaTime);

        bool bounced = false;
        if (transform.position.z > maxZ || transform.position.z < minZ)
        {
            direction = -direction;
            bounced = true;
        }

        if (bounced)
        {
            transform.Translate(0, 0, direction * speed * Time.deltaTime);
        }	
	}
}
