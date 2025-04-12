using System.Collections;
using UnityEngine;

namespace UnityInAction
{
  public class ReactiveTarget : MonoBehaviour
  {
    public void ReactToHit()
    {
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