using UnityEngine;

namespace UnityInAction
{
  public class WanderingAI : MonoBehaviour
  {
    public float speed = 5.0f;
    public float obstacleRange = 5.0f;

    private bool _isAlive;

    void Start()
    {
      _isAlive = true;
    }
    
    void Update()
    {
      if (!_isAlive) return;
      
      transform.Translate(0, 0, speed * Time.deltaTime);
      
      Ray ray = new Ray(transform.position, transform.forward);
      if (!Physics.SphereCast(ray, 0.75f, out var hit)) return;
      if (hit.distance < obstacleRange)
      {
        int range = Random.Range(-100, 100);
        transform.Rotate(0, range, 0);
      }  
    }

    public void SetAlive(bool isAlive)
    {
      _isAlive = isAlive;
    }
    
  }
}
