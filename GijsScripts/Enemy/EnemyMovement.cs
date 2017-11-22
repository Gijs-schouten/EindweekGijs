using UnityEngine;

/// <summary>
/// Moves enemies left and right. 
/// By: Gijs Schouten.
/// </summary>

public class EnemyMovement : MonoBehaviour {
    public float leftRightSpeed;
    bool WeShouldGoRight = true;
    Vector3 dropAmount = new Vector3(0, -1, 0);
    public Transform myTransform;
    float boundaryLeft = -2;
    float boundaryRight = 14f;

    void Update() {
        if ((transform.position.x >= boundaryRight) || (transform.position.x <= boundaryLeft)) {
            WeShouldGoRight = !WeShouldGoRight;
            DropALevel();
            print("Switching directions; now moving " + (WeShouldGoRight ? "Right" : "Left"));
        }

        Move(WeShouldGoRight);
    }

    void Move(bool moveRight) {
        float movementX = moveRight ? leftRightSpeed : -leftRightSpeed;
        transform.Translate(new Vector3(movementX * Time.deltaTime, 0, 0));
    }

    void DropALevel() {
        transform.Translate(dropAmount);
    }
}