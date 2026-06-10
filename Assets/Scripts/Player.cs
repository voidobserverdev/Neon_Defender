using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private InputAction rotateAction;
    [SerializeField] private InputAction fireAction;
    [SerializeField] private GameObject firePoint;
    [SerializeField] private GameObject projectile;
    [SerializeField] private TextMeshProUGUI healthText;
    public int health = 5;
    public float rotationSpeed = 300f;

    void Start()
    {
        healthText.text = health.ToString();
    }

    void OnEnable()
    {
        rotateAction.Enable();
        fireAction.Enable();
    }
    void OnDisable()
    {
        rotateAction.Disable();
        fireAction.Disable();
    }

    void Update()
    {
        float inputValue = rotateAction.ReadValue<Vector2>().x;

        //rotate along y-axis
        transform.Rotate(0, Time.deltaTime * rotationSpeed * inputValue, 0);

        if (fireAction.WasPressedThisFrame())
        {
            Instantiate(projectile, firePoint.transform.position, firePoint.transform.rotation);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            health--;
            healthText.text = health.ToString();
            Debug.Log("Current health:" + health);
            if (health <= 0)
            {
                Time.timeScale = 0;
            }
        }
    }
}
