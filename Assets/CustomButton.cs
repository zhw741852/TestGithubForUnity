using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
public class CustomButton :  Button{
  
    [System.Serializable]
    public class CustomButtonClickedEvent : UnityEvent<Button>
    {
        
    }
    [SerializeField]
    public new CustomButtonClickedEvent onClick;
    // Use this for initialization
    void Start () {
        base.onClick.AddListener(() => { this.onClick.Invoke(this); });
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

