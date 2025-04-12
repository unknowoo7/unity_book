using System;
using UnityEngine;

namespace UnityInAction
{
  public class FPSInput : MonoBehaviour
  {
    public float speed = 6.0f;
    private CharacterController characterController;

    private void Start()
    {
      characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
      float deltaX = Input.GetAxis("Horizontal") * speed;
      float deltaZ = Input.GetAxis("Vertical") * speed;
      Vector3 movement = new Vector3(deltaX, 0, deltaZ);
      movement = Vector3.ClampMagnitude(movement, speed);
      
      movement *= Time.deltaTime;
      movement = transform.TransformDirection(movement);
      characterController.Move(movement);
    }
  }
}
