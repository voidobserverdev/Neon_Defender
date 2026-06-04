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
    }
}
