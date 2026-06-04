using UnityEngine;

public class Projectile : MonoBehaviour
{
    private GameObject player;
    public float projectileSpeed = 25f;

    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //move forward in local space
        transform.Translate(projectileSpeed * Time.deltaTime * Vector3.forward);
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
