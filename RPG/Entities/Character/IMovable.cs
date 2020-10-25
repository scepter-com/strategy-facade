using UnityEngine;

namespace Source.RPG.Entities.Character
{
    public interface IMovable
    {
        void Move(float horizontalInput, float verticalInput, float velocity);
    }
}