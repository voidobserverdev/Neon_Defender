using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    public float spawnRate = 2f;
    public float spawnTimer = 0;

    private float spawnRange;

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
        spawnRange = Random.Range(6, 8);

        //Get a random point on edge of circle
        Vector2 randomCirclePoint = Random.insideUnitCircle.normalized;

        randomCirclePoint *= spawnRange;

        return new Vector3(randomCirclePoint.x, transform.position.y, randomCirclePoint.y);
    }
}
