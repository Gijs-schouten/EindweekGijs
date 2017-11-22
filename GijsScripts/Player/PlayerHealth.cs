using UnityEngine;

/// <summary>
/// Checks if the player gets hit and destroys it.
/// Made by: Gijs Schouten.
/// </summary>

public class PlayerHealth : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.tag == "Enemy") {
            Destroy(gameObject);
        }
    }
}
