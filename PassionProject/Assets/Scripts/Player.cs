using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private CharacterController myCharacterController;
    [SerializeField] private float mySpeed;
    [SerializeField] private float myRotationSpeed;
    [SerializeField] private float myGravity;

    public void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.W))
        {
            myCharacterController.Move(this.transform.forward * Time.deltaTime * mySpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            myCharacterController.Move(-this.transform.forward * Time.deltaTime * mySpeed);
        }
        if(Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(new Vector3(0, -myRotationSpeed, 0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate(new Vector3(0, myRotationSpeed, 0));
        }

        myCharacterController.Move(new Vector3(0, myGravity * Time.deltaTime, 0));
    }
}
