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

    void Update()
    {
      if (axes == RotationAxes.MouseX)
      {        
        transform.Rotate(0,  Input.GetAxis("Mouse X") * sensitivityHor, 0);
      }
      else if (axes == RotationAxes.MouseY)
      {
        
      }
      else
      {
        
      }
    }
  }
}