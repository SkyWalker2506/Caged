using System;
using UnityEngine;

namespace ChordSystem
{
    [Serializable]
    public class LimbData
    {
        public TransformData TargetData;
        public TransformData HintData;

        public LimbData(Transform target, Transform hint)
        {
            TargetData = new TransformData(target);
            HintData = new TransformData(hint);
        }
    }
}