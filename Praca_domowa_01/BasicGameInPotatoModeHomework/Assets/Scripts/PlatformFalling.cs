using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformFalling : MonoBehaviour
{
	Rigidbody2D rb;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.name.Equals("Player"))
		{
			Invoke("DropPlatform", 0.5f);
			Destroy(gameObject, 4f);
		}
	}

	void DropPlatform()
	{
		rb.isKinematic = false;
	}
}