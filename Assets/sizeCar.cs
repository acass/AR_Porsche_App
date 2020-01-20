using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sizeCar : MonoBehaviour {

    [SerializeField]
	private Slider slider;

    [SerializeField]
	private GameObject myCar;

    [SerializeField]
    float myCarSize;
    
     void Update () {

        myCarSize = slider.value;

        myCar.transform.localScale = new Vector3(myCarSize, myCarSize, myCarSize);
     }
}