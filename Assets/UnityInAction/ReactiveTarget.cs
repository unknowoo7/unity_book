using System.Collections;
using UnityEngine;

namespace UnityInAction
{
  [RequireComponent(typeof(WanderingAI))]
  public class ReactiveTarget : MonoBehaviour
  {
    public void ReactToHit()
    {
      if (transform.TryGetComponent<WanderingAI>(out var behavior))
      {
        behavior.SetAlive(false);
      }
      //круитин
      StartCoroutine(Die());
    }

    private IEnumerator Die()
    {
      transform.Rotate(-75, 0, 0);
      yield return new WaitForSeconds(1.5f);
      Destroy(gameObject);
    }
  }
}