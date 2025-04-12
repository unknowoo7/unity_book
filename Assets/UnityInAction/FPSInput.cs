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
      Debug.Log(Time.deltaTime);
      transform.Translate(deltaX * Time.deltaTime, 0, deltaZ * Time.deltaTime);
    }
  }
}
