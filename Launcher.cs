using Source.Facades.Scene;
using UnityEditor;
using UnityEngine;

namespace Source
{
    public class Launcher : MonoBehaviour
    {
        
        [SerializeField] private SceneAsset _bootScene;
        void Awake()
        {
            LauncherFacade.LoadScene(_bootScene, LoadType.ByName);
        }
    }
}

