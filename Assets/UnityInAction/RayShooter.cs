using System;
using System.Collections;
using UnityEngine;

namespace UnityInAction
{
  [AddComponentMenu("Control Script/Ray Shooter")]
  [RequireComponent(typeof(Camera))]
  public class RayShooter : MonoBehaviour
  {
    private Camera _camera;
    private ReactiveTarget _target;
    void Start()
    {
      _camera = GetComponent<Camera>();
      Cursor.lockState = CursorLockMode.Locked;
      Cursor.visible = false;
    }

    private void OnGUI()
    {
      int size = 12;
      float posX = _camera.pixelWidth / 2.0f - size / 4.0f;
      float posY = _camera.pixelHeight / 2.0f - size / 2.0f;
      GUI.Label(new Rect(posX, posY, size, size), "*");
    }

    void Update()
    {
      if (Input.GetMouseButtonDown(0))
      {
        Vector3 point = new Vector3(_camera.pixelWidth / 2.0f, _camera.pixelHeight / 2.0f, 0);
        Ray ray = _camera.ScreenPointToRay(point);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
          if (hit.transform.gameObject.TryGetComponent(out _target))
          {
            _target.ReactToHit();
          }
          else
          {
            StartCoroutine(SphereIndicator(hit.point));
          }
        }
      }
    }

    private IEnumerator SphereIndicator(Vector3 pos)
    {
      GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
      sphere.transform.position = pos;
      yield return new WaitForSeconds(1);
      Destroy(sphere);
    }
  }
}