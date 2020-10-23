using Source.Facades.Scene;
using UnityEditor;
using UnityEngine;

namespace Source
{
    public class Launcher : MonoBehaviour
    {
        
        [SerializeField] private SceneAsset _scene;
        void Awake()
        {
            LauncherFacade.LoadScene(_scene, LoadType.ByName);
        }
    }
}

