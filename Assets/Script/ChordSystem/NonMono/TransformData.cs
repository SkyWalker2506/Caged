using System;
using UnityEngine;

namespace ChordSystem
{
    [Serializable]
    public class TransformData 
    {
        public Vector3 Position;
        public Quaternion Rotation;

        public TransformData(Transform transform)
        {
            Position = transform.localPosition;
            Rotation = transform.localRotation;
        }
    }
}
