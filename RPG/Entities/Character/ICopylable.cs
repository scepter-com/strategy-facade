using UnityEngine;

namespace Source.RPG.Entities.Character
{
    public interface ICopylable
    {
        Character ShallowCopy(Vector3 spawnPosition);
        Character DeepCopy(Vector3 spawnPosition);
    }
}