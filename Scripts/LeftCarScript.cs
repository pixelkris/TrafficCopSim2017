﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftCarScript : MonoBehaviour {
     public float movementSpeed = 5.0f;
     public enum directionFacing { Left, Right, Up, Down};


 		
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		 transform.position += transform.right * Time.deltaTime * movementSpeed;
	}
}
