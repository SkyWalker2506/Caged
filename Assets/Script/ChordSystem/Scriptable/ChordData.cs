using UnityEditor;
using UnityEngine;

namespace ChordSystem
{
    [CreateAssetMenu(fileName = "ChordData", menuName = "Data/ChordData")]
    public class ChordData : ScriptableObject
    {
        ChordController chordController { get { return FindObjectOfType<ChordController>(); } }
        public HandData LeftHand;
        public HandData RightHand;

        public ChordData(HandData leftHand, HandData rightHand)
        {
            LeftHand = leftHand;
            RightHand = rightHand;
        }

        public void LoadLeftHandData()
        {
            if (chordController)
                chordController.SetLeftHand(LeftHand);
        }

        public void SaveLeftHandData()
        {
            if (chordController)
                LeftHand = chordController.GetLeftHandData();
        }

        public void LoadRightHandData()
        {
            if (chordController)
                chordController.SetRightHand(RightHand);
        }

        public void SaveRightHandData()
        {
            if (chordController)
                RightHand = chordController.GetRightHandData();
        }

        public void LoadChordData()
        {
            if (chordController)
                chordController.SetChord(this);
        }

        public void SaveChordData()
        {
            SaveLeftHandData();
            SaveRightHandData();
        }

        public void MoveToChordPositon(float time)
        {
            if (chordController)
                chordController.MoveToChord(this, time);
        }

    }
#if UNITY_EDITOR
    [CustomEditor(typeof(ChordData))]
    public class ChordDataEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();


            ChordData chordData = (ChordData)target;
            EditorGUILayout.Space();
            if (GUILayout.Button("Load Left Hand Data"))
            {
                chordData.LoadLeftHandData();
            }
            if (GUILayout.Button("Save Left Hand Data"))
            {
                chordData.SaveLeftHandData();
                EditorUtility.SetDirty(chordData);
            }
            EditorGUILayout.Space();
            if (GUILayout.Button("Load Right Hand Data"))
            {
                chordData.LoadRightHandData();
            }
            if (GUILayout.Button("Save Right Hand Data"))
            {
                chordData.SaveRightHandData();
                EditorUtility.SetDirty(chordData);
            }
            EditorGUILayout.Space();
            if (GUILayout.Button("Load Chord Data"))
            {
                chordData.LoadChordData();
            }
            if (GUILayout.Button("Save Chord Data"))
            {
                chordData.SaveChordData();
                EditorUtility.SetDirty(chordData);
            }
            EditorGUILayout.Space();
            if (GUILayout.Button("Move To Chord Positon"))
            {
                chordData.MoveToChordPositon(1);
            }

        }
    }
#endif
}