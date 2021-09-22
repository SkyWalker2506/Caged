using System;

namespace ChordSystem
{
    [Serializable]
    public class HandData
    {
        public LimbData Base;
        public LimbData Thumb;
        public LimbData Index;
        public LimbData Middle;
        public LimbData Ring;
        public LimbData Pinky;

        public HandData(LimbData baseData, LimbData thumbData, LimbData indexData, LimbData middleData, LimbData ringData, LimbData pinkyData)
        {
            Base = baseData;
            Thumb = thumbData;
            Index = indexData;
            Middle = middleData;
            Ring = ringData;
            Pinky = pinkyData;
        }
    }
}