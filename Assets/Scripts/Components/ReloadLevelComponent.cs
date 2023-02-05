using UnityEngine;
using UnityEngine.SceneManagement;

namespace Platformer.Components
{
    public class ReloadLevelComponent : MonoBehaviour
    {
        public void ReloadLevel()
        {
            var _scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(_scene.name);
        }
    }
}

