using System;
using UnityEngine;

namespace UnityInAction
{
  public class MouseLook : MonoBehaviour
  {
    public enum RotationAxes
    {
      MouseXAndY,
      MouseX,
      MouseY
    }

    public RotationAxes axes = RotationAxes.MouseXAndY;
    public float sensitivityHor = 9.0f;
    public float sensitivityVert = 9.0f;

    public float minimumVert = -45.0f;
    public float maximumVert = 45.0f;

    private float verticalRot = 0;

    void Update()
    {
      if (axes == RotationAxes.MouseX)
      {        
        transform.Rotate(0,  Input.GetAxis("Mouse X") * sensitivityHor, 0);
      }
      else if (axes == RotationAxes.MouseY)
      {
        verticalRot -= Input.GetAxis("Mouse Y") * sensitivityVert;
        verticalRot = Mathf.Clamp(verticalRot, minimumVert, maximumVert);

        float horizontalRot = transform.localEulerAngles.y;

        transform.localEulerAngles = new Vector3(verticalRot, horizontalRot, 0);
      }
      else
      {
        verticalRot -= Input.GetAxis("Mouse Y") * sensitivityVert;
        verticalRot = Mathf.Clamp(verticalRot, minimumVert, maximumVert);

        float delta = Input.GetAxis("Mouse X") * sensitivityHor;
        float horizontalRot = transform.localEulerAngles.y + delta;
        
        transform.localEulerAngles = new Vector3(verticalRot, horizontalRot, 0);
      }
    }

    private void Start()
    {
      Rigidbody body = GetComponent<Rigidbody>();
      if (body)
      {
        body.freezeRotation = true;
      }
    }
  }
}