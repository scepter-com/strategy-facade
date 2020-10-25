using System;
using Source.RPG.Entities.Character;
using UnityEngine;

namespace Source.Context
{
    public class BattlefieldContext : Context, IInitializable
    {
        private string _characterName;
        private Character _layoutCharacter;
        
        /// <summary>
        /// Player component
        /// </summary>
        [SerializeField] private Character _character;
        [SerializeField] private Vector3 _spawn;
        
        private void Start()
        {
            Initialize();
        }

        public void Initialize()
        {
            try
            {
                _characterName = PlayerPrefs.GetString("CurrentCharacter");
                GameObject obj = GameObject.Find(_characterName);
                _layoutCharacter = obj.GetComponent<Character>();
                _character = _layoutCharacter.ShallowCopy(_spawn);
            }
            catch (Exception e)
            {
                Debug.Log(e);
                throw;
            }
        }
    }
}