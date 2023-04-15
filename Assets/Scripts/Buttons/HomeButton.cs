using UnityEngine;
using UnityEngine.SceneManagement;

namespace Buttons
{
    public class HomeButton : MonoBehaviour
    {
        public static void LoadBaseScene()
        {
            SceneManager.LoadScene("Meditation");
        }

        private void OnTriggerEnter(Collider other)
        {
            LoadBaseScene();
        }
    }
}
    