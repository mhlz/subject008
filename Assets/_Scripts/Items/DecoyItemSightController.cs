﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecoyItemSightController : MonoBehaviour {

	private void OnTriggerEnter2D(Collider2D other)
	{
		Destroy(gameObject.transform.parent.gameObject);
	}
}
