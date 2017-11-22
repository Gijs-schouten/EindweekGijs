using UnityEngine;

/// <summary>
/// Shooting.
/// Made by: Gijs Schouten.
/// </summary>

public class PlayerShoot : MonoBehaviour {
    private Touch touch;
    public GameObject projectile;

    void Update() {
        if (Input.touchCount == 0) {
            Instantiate(projectile, transform.position, transform.rotation);
        }
    }
}
