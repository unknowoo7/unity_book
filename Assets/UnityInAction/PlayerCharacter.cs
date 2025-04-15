using UnityEngine;

namespace UnityInAction
{
  public class PlayerCharacter : MonoBehaviour
  {
    public int health;
    void Start()
    {
      health = 5;
    }

    public void Hurt(int damage)
    {
      health -= damage;
      Debug.Log($"Ohh! Health: {health}");
    }
  }
}