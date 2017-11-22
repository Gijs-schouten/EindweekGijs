using UnityEngine;

/// <summary>
/// Destroys enemies.
/// Made by: Gijs Schouten.
/// </summary>

public class EnemyHealth : MonoBehaviour {
    public float enemyHealth = 2;

    void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.tag == "Bullet") {
            if (enemyHealth > 1) {
                enemyHealth -= 1;
            } else {
                Destroy(gameObject);
            }
        }
    }
}