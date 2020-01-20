using UnityEngine;

public class animateTextures : MonoBehaviour {

    public GameObject theAirFlow;

    public int materialIndex = 0;
    public Vector2 uvAnimationRate = new Vector2( 1.0f, 0.0f );
    public string textureName = "_MainTex";
    public Renderer myAirFlow;
    Vector2 uvOffset = Vector2.zero;

    void Start() {
        
        theAirFlow.SetActive(false);
    }

     void LateUpdate() {

         uvOffset += ( uvAnimationRate * Time.deltaTime );
         if( myAirFlow.enabled ) {

             myAirFlow.materials[ materialIndex ].SetTextureOffset( textureName, uvOffset );
         }
     }

     public void enableMyAirFlow(){

         theAirFlow.SetActive(!theAirFlow.activeSelf);
     }
}