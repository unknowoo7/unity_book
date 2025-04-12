using UnityEngine;

namespace UnityInAction
{
    public class MouseLook : MonoBehaviour
    {
        public enum RotationAxes
        {
            MouseXAndY,
            MouseX,
            MouseY
        }
    
        public RotationAxes axes = RotationAxes.MouseXAndY;
    
        void Update()
        {
            if (axes == RotationAxes.MouseX)
            {

            }
            else if (axes == RotationAxes.MouseY)
            {
            
            }
            else
            {
            
            }
        }
    }
    
}
