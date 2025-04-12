using UnityEngine;

namespace UnityInAction
{
  [AddComponentMenu("Control Script/Ray Shooter")]
  [RequireComponent(typeof(Camera))]
  public class RayShooter : MonoBehaviour
  {
    private Camera _camera;
    void Start()
    {
      _camera = GetComponent<Camera>();
    }

    void Update()
    {
      if (Input.GetMouseButtonDown(0))
      {
        Vector3 point = new Vector3(_camera.pixelWidth / 2, _camera.pixelHeight / 2, 0);
        Ray ray = _camera.ScreenPointToRay(point);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
          Debug.Log("Hit" + hit.point);
        }
      }
    }
  }
}