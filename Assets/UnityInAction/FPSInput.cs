using UnityEngine;

namespace UnityInAction
{
  public class FPSInput : MonoBehaviour
  {
    public float speed = 6.0f;

    void Update()
    {
      float deltaX = Input.GetAxis("Horizontal") * speed;
      float deltaZ = Input.GetAxis("Vertical") * speed;
      transform.Translate(deltaX, 0, deltaZ);
    }
  }
}
