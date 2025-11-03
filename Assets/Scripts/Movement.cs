using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [SerializeField] float movementSpeed = 10f;
    [SerializeField] float rotationSpeed = 50f;

    void Update()
    {
        DrivingInput();
        RotationInput();
    }

    void DrivingInput()
    {
        if (Keyboard.current.wKey.isPressed && !Keyboard.current.sKey.isPressed)
        {
            transform.Translate(Vector3.up * movementSpeed * Time.deltaTime);
        }
        else if (Keyboard.current.sKey.isPressed && !Keyboard.current.wKey.isPressed)
        {
            transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);
        }
    }

    void RotationInput()
    {
        if (Keyboard.current.aKey.isPressed && !Keyboard.current.dKey.isPressed)
        {
            transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
        }
        else if (Keyboard.current.dKey.isPressed && !Keyboard.current.aKey.isPressed)
        {
            transform.Rotate(Vector3.back * rotationSpeed * Time.deltaTime);
        }
    }
}
