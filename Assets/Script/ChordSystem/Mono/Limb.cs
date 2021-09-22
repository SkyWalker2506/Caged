using UnityEngine;
using DG.Tweening;

namespace ChordSystem
{
    public class Limb : MonoBehaviour
    {
        [SerializeField] Transform target;
        [SerializeField] Transform hint;

        private void Awake()
        {
            ResetLimb();
        }

        void ResetLimb()
        {
            target.localPosition = Vector3.zero;
            target.localRotation = Quaternion.identity;
            hint.localPosition = Vector3.zero;
            hint.localRotation = Quaternion.identity;
        }

        public void SetLimb(LimbData data)
        {
            target.localPosition= data.TargetData.Position;
            target.localRotation= data.TargetData.Rotation;
            hint.localPosition = data.HintData.Position;
            hint.localRotation= data.HintData.Rotation;
        }

        public LimbData GetLimbData()
        {
            return new LimbData(target, hint);
        }

        public void MoveLimb(LimbData data,float time)
        {
            target.DOLocalMove(data.TargetData.Position, time);
            target.DOLocalRotate(data.TargetData.Rotation.eulerAngles, time);
            hint.DOLocalMove(data.HintData.Position, time);
            hint.DOLocalRotate(data.HintData.Rotation.eulerAngles, time);
        }
    }

}
