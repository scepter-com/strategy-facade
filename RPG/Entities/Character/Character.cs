using System;
using UnityEngine;

namespace Source.RPG.Entities.Character
{
    public class Character : MonoBehaviour, ICopylable, IMovable
    {
        public float CharacterVelocity;
        public int Health;
        public string Name;
        public float Stamina;
        private Transform _transform;
        
        private void Awake()
        {
            _transform = transform;
        }

        private void Update()
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");
            Move(h,v, CharacterVelocity);
        }

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
            clone.CharacterVelocity = CharacterVelocity;
            UnityEngine.Object.Instantiate(gameObject, spawnPosition, Quaternion.identity);
            return clone;
        }


        public void Move(float horizontalInput, float verticalInput, float velocity)
        {
            _transform.Translate(
                horizontalInput * velocity, 
                0f, 
                verticalInput * velocity);
        }
        
    }
}