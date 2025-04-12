using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float speed = 3.0f; 
    
    void Update()
    {
        transform.Rotate(0, speed, 0);
    }
}
