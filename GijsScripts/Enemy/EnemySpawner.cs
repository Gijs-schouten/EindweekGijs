using UnityEngine;

/// <summary>
/// Spawns enemies with a 2d array.
/// By: Gijs Schouten.
/// </summary>

public class EnemySpawner : MonoBehaviour {
    public int width;
    public int height;

    public GameObject enemy;
    public GameObject[,] enemies;

    private void Start() {
        enemies = new GameObject[width, height];

        for (int i = 0; i < width; i++) {
            for (int j = 0; j < height; j++) {       
                enemies[i, j] = Instantiate(enemy, new Vector3(i, j, 0), Quaternion.identity);
                enemies[i, j].gameObject.name = i + " : " + j;
                
            }
        }

    }
}