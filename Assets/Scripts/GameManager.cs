using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    public float spawnRate = 2f;
    public float spawnTimer = 0;

    readonly float minRange = -8f;
    readonly float maxRange = 8f;
    readonly float excludeMinRange = -5f;
    readonly float excludeMaxRange = 5f;

    void Update()
    {
        spawnTimer += Time.deltaTime;

        if (spawnTimer >= spawnRate)
        {
            SpawnEnemy();
            spawnTimer = 0;
        }
    }
    void SpawnEnemy()
    {
        Instantiate(enemy, SpawnPoint(), transform.rotation);
    }


    Vector3 SpawnPoint()
    {
        float xPos;
        float zPos;
        do
        {
            xPos = Random.Range(minRange, maxRange);
        }
        while (xPos < excludeMinRange && xPos > excludeMaxRange);
        do
        {
            zPos = Random.Range(minRange, maxRange);
        }
        while (zPos < excludeMinRange && zPos > excludeMaxRange);
        return new Vector3(xPos, transform.position.y, zPos);
    }
}
