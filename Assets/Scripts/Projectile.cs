using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float projectileSpeed = 25f;
    public float lifetime = 3f;

    void Start()
    {
        //Destory projectiles after 3 sec, better performance
        Destroy(gameObject, lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        //move forward in local space
        transform.Translate(projectileSpeed * Time.deltaTime * Vector3.forward);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
