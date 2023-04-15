using UnityEngine;
using UnityEngine.SceneManagement;

namespace Buttons
{
    public class CreekButton : MonoBehaviour
    {
        public static void LoadCreek()
        {
            SceneManager.LoadScene("Creek");
        }
        
    }
}