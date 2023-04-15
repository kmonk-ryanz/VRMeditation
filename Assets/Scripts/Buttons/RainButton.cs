using UnityEngine;
using UnityEngine.SceneManagement;

namespace Buttons
{
    public class RainButton : MonoBehaviour
    {
        public static void LoadRain()
        {
            SceneManager.LoadScene("Rain");
        }
        
    }
}