using UnityEngine;

namespace UnityInAction
{
  public class SceneController : MonoBehaviour
  {
    [SerializeField] GameObject enemyPrefab;
    private GameObject _enemy;
    
    void Update()
    {
      if (_enemy != null) return;
      _enemy = Instantiate<GameObject>(enemyPrefab);
      _enemy.transform.position = new Vector3(0, 1, 0);
      float angle = Random.Range(0, 360);
      _enemy.transform.Rotate(0, angle, 0);
    }
  }
}