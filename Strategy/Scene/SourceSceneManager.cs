using System;
using UnityEditor;
using UnityEngine;

namespace Source.Strategy.Scene
{
    public class SourceSceneManager : ILoader
    {
        
        private SceneData _data;
        
        public SourceSceneManager(SceneAsset scene)
        {
            string name = scene.name;
            int id = scene.GetInstanceID();
            _data = new SceneData(name, id, scene);
        }

        public bool LoadSceneByID()
        {
            try
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(_data.ID);
                return true;
            }
            catch (Exception e)
            {
                Debug.Log(e);
                throw;
            }
        }
        
        
        public bool LoadSceneByName()
        {
            try
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(_data.Name);
                return true;
            }
            catch (Exception e)
            {
                Debug.Log(e);
                throw;
            }
        }
        
        
    }
}