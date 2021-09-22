using UnityEngine;
namespace ChordSystem
{
    public class Hand : MonoBehaviour
    {
        public Limb Base;
        public Limb Thumb;
        public Limb Index;
        public Limb Middle;
        public Limb Ring;
        public Limb Pinky;

        public void SetHand(HandData data)
        {
            Base.SetLimb(data.Base);
            Thumb.SetLimb(data.Thumb);
            Index.SetLimb(data.Index);
            Middle.SetLimb(data.Middle);
            Ring.SetLimb(data.Ring);
            Pinky.SetLimb(data.Pinky);
        }

        public HandData GetHandData()
        {
            return new HandData(Base.GetLimbData(), Thumb.GetLimbData(), Index.GetLimbData(), Middle.GetLimbData(), Ring.GetLimbData(), Pinky.GetLimbData());
        }

        public void MoveHand(HandData data, float time)
        {
            Base.MoveLimb(data.Base, time);
            Thumb.MoveLimb(data.Thumb, time); 
            Index.MoveLimb(data.Index, time); 
            Middle.MoveLimb(data.Middle, time);
            Ring.MoveLimb(data.Ring, time);
            Pinky.MoveLimb(data.Pinky, time);
        }

    }
}
