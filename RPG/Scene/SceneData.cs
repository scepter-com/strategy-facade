using UnityEditor;

namespace Source.RPG.Scene
{
    public struct SceneData
    {
        private readonly string _name;
        private readonly int _id;
        private readonly SceneAsset _scene;
        
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