using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private InputAction rotateAction;
    [SerializeField] private InputAction fireAction;
    [SerializeField] private GameObject firePoint;
    [SerializeField] private GameObject projectile;

    public float rotationSpeed = 300f;

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
        transform.Rotate(0, 1 * Time.deltaTime * rotationSpeed * inputValue, 0);

        if (fireAction.WasPressedThisFrame())
        {
            Instantiate(projectile, firePoint.transform.position, Quaternion.identity);
        }
    }
}
