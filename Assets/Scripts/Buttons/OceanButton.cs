using UnityEngine;
using UnityEngine.SceneManagement;

namespace Buttons
{
    public class OceanButton : MonoBehaviour
    {
        public static void LoadOcean()
        {
            SceneManager.LoadScene("Ocean");
        }
        
    }
}