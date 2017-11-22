using UnityEngine;

/// <summary>
/// Checks for screen touch and moves the player.
/// Made by: Gijs Schouten
/// </summary>

public class PlayerMovement : MonoBehaviour {
    private Touch touch;
    public float moveSpeed;

    void Update() {
        if (touch.position.x < Screen.width/2) {
            //touching left
            gameObject.transform.Translate(Vector3.left * moveSpeed * Time.deltaTime); 
        }

        if (touch.position.x > Screen.width/2) {
            //touching right
            gameObject.transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }
    }
}
