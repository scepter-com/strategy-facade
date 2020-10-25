using Source.Facades.Scene;
using UnityEditor;
using UnityEngine;

namespace Source.Context.Lobby
{
    public class LobbyManager : MonoBehaviour
    {
        [SerializeField] private SceneAsset battleFieldScene;
        public void SelectCharacter(string characterName)
        {
            
            PlayerPrefs.SetString("CurrentCharacter", characterName);
            LauncherFacade.LoadScene(battleFieldScene, LoadType.ByName);
        }
    }
}