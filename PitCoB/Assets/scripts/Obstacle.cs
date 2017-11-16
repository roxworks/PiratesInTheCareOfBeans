﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Obstacle : MonoBehaviour, IWeigh {

	public abstract float Weight {
		get;
	}

	public abstract Vector3 Position
	{
		get;
	}

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
