using UnityEditor;

namespace Source.Strategy.Scene
{
    public struct SceneData
    {
        private string _name;
        private int _id;
        private SceneAsset _scene;
        
        public string Name => _name;
        public int ID => _id;
        public SceneAsset Scene => _scene;
        
        public SceneData(string name, int id, SceneAsset scene)
        {
            _name = name;
            _id = id;
            _scene = scene;
        }
    }
}