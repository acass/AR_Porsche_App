using UnityEngine;
using DG.Tweening;

public class ControlExpander : MonoBehaviour {

    public GameObject[] myxObjects;

    public void ExpandMeX(){

         for(int i = 0; i < myxObjects.Length; i++) {

            myxObjects[i].transform.DOLocalMoveZ(0.4f, 2f, false);
        }
    }
}