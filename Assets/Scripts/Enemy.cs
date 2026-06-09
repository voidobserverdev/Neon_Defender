using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed = 5f;


    void Update()
    {
        float step = moveSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, transform.position.y, 0), step);
    }
}
