using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class gameOverCollider : MonoBehaviour
{
	public UnityEvent onGameOver;

	private void OnTriggerEnter(Collider other) {
		if (other.CompareTag(player)) {
			Debug.Log("game over");
		}
	}
}
