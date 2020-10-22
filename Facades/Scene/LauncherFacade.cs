using Source.Strategy.Scene;
using UnityEditor;

namespace Source.Facades.Scene
{
    public class LauncherFacade 
    {
        
        /// <summary>
        /// Загрузка сцены исходя из типа данных
        /// </summary>
        /// <param name="scene"></param>
        /// <param name="isString"></param>
        public static void LoadScene(SceneAsset scene, LoadType loadType)
        {
            SourceSceneManager sceneManager = new SourceSceneManager(scene);

            switch (loadType)
            {
                case LoadType.ById : sceneManager.LoadSceneByID();
                    break;
                case LoadType.ByName : sceneManager.LoadSceneByName();
                    break;
            }
        }
    }
}