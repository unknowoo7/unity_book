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

    private float _verticalRot;
    private Rigidbody _body;
    
    void Update()
    {
      if (axes == RotationAxes.MouseX)
      {        
        transform.Rotate(0,  Input.GetAxis("Mouse X") * sensitivityHor, 0);
      }
      else if (axes == RotationAxes.MouseY)
      {
        _verticalRot -= Input.GetAxis("Mouse Y") * sensitivityVert;
        _verticalRot = Mathf.Clamp(_verticalRot, minimumVert, maximumVert);

        float horizontalRot = transform.localEulerAngles.y;

        transform.localEulerAngles = new Vector3(_verticalRot, horizontalRot, 0);
      }
      else
      {
        _verticalRot -= Input.GetAxis("Mouse Y") * sensitivityVert;
        _verticalRot = Mathf.Clamp(_verticalRot, minimumVert, maximumVert);

        float delta = Input.GetAxis("Mouse X") * sensitivityHor;
        float horizontalRot = transform.localEulerAngles.y + delta;
        
        transform.localEulerAngles = new Vector3(_verticalRot, horizontalRot, 0);
      }
    }

    private void Start()
    {
      if (transform.TryGetComponent(out _body))
      {
        _body.freezeRotation = true;
      }
    }
  }
}