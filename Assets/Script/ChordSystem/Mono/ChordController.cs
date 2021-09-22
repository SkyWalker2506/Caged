using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChordSystem
{
    public class ChordController : MonoBehaviour
    {
        [SerializeField] Hand leftHand;
        [SerializeField] Hand rightHand;

        public void SetLeftHand(HandData data)
        {
            leftHand.SetHand(data);
        }

        public void SetRightHand(HandData data)
        {
            rightHand.SetHand(data);
        }

        public void SetChord(ChordData data)
        {
            SetLeftHand(data.LeftHand);
            SetRightHand(data.RightHand);
        }

        public HandData GetLeftHandData()
        {
            return leftHand.GetHandData();
        }

        public HandData GetRightHandData()
        {
            return rightHand.GetHandData();
        }

        public ChordData GetChordData()
        {
            return new ChordData(GetLeftHandData(), GetRightHandData());
        }

        public void MoveToChord(ChordData data, float time)
        {
            leftHand.MoveHand(data.LeftHand, time);
            rightHand.MoveHand(data.RightHand, time);
        }
    }
}