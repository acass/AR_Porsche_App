using UnityEngine;

public class ChangeCarColors : MonoBehaviour {

    public Color mRed, mBlue, Green;
    public Material mMaterial;

    void Start() {
        
         mMaterial.SetColor("_Color", mRed);
    }

    public void GoRed() {

        mMaterial.SetColor("_Color", mRed);
    }

    public void GoBlue() {

        mMaterial.SetColor("_Color", mBlue);
    }

    public void GoGreen() {

        mMaterial.SetColor("_Color", Green);
    }
}