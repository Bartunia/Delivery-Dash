using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [SerializeField] float movementSpeed = 10f;
    [SerializeField] float rotationSpeed = 50f;
    bool isMoving = false;   
    bool isReversing = false;

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
            isMoving = true;
            isReversing = false;
        }
        else if (Keyboard.current.sKey.isPressed && !Keyboard.current.wKey.isPressed)
        {
            transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);
            isMoving = true;
            isReversing = true;
        }
        else
        {
            isMoving = false;
        }
    }

    void RotationInput()
    {
        if (isReversing == true)
        {
            if (Keyboard.current.aKey.isPressed
            && !Keyboard.current.dKey.isPressed
            && isMoving == true)
            {
                transform.Rotate(Vector3.back * rotationSpeed * Time.deltaTime);
            }
            else if (Keyboard.current.dKey.isPressed
            && !Keyboard.current.aKey.isPressed
            && isMoving == true)
            {
                transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
            }
            return;
        }
        if (isReversing == false)
        {
            if (Keyboard.current.aKey.isPressed
            && !Keyboard.current.dKey.isPressed
            && isMoving == true)
            {
                transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
            }
            else if (Keyboard.current.dKey.isPressed
            && !Keyboard.current.aKey.isPressed
            && isMoving == true)
            {
                transform.Rotate(Vector3.back * rotationSpeed * Time.deltaTime);
            }
        }
    }
}
