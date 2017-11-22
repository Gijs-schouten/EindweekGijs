using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///  Made by: Gijs Schouten.
/// </summary>

public class BulletMovement : MonoBehaviour {
    public float bulletSpeed;

	void Update () {
		transform.Translate(Vector3.up * bulletSpeed * Time.deltaTime);
	}

    void OnCollisionEnter2D(Collision2D col) {
        print("d");

        if (col.gameObject.tag == "Enemy") {
            Destroy(gameObject);
        }
    }
}
