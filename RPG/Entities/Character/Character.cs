using System;
using UnityEngine;

namespace Source.RPG.Entities.Character
{
    public class Character : MonoBehaviour, ICopylable
    {
        
        public int Health;
        public string Name;
        public float Stamina;
        
        public Character ShallowCopy(Vector3 spawnPosition)
        {
            UnityEngine.Object.Instantiate(gameObject, spawnPosition, Quaternion.identity);
            return (Character) this.MemberwiseClone();
        }
        
        public Character DeepCopy(Vector3 spawnPosition)
        {
            Character clone = (Character) this.MemberwiseClone();
            clone.Name = String.Copy(Name);
            clone.Health = Health;
            clone.Stamina = Stamina;
            UnityEngine.Object.Instantiate(gameObject, spawnPosition, Quaternion.identity);
            return clone;
        }
        
    }
}