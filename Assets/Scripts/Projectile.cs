using UnityEngine;

public class Projectile : MonoBehaviour
{
    private GameObject player;
    public float projectileSpeed = 25f;
    private Vector3 fireDirection;

    void Start()
    {
        player = GameObject.Find("Player");
        fireDirection = player.transform.forward;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(projectileSpeed * Time.deltaTime * fireDirection, Space.World);
        OutOfBounds();
    }
    void OutOfBounds()
    {
        if (transform.position.x > 15 || transform.position.x < -15)
        {
            Destroy(gameObject);
        }
        if (transform.position.z > 15 || transform.position.z < -15)
        {
            Destroy(gameObject);
        }
    }
}
