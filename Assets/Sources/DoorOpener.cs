using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : MonoBehaviour {
  
    public float StayOpened;
    public float TravelTime;
    private bool IsDoorOpenedKey= Input.GetKey(KeyCode.Space);
    private GameObject player;
    private Animation DoorAnimation;
    // Use this for initialization
    void Start () {
       DoorAnimation = GetComponent("Animation") as Animation; ;
       player = GameObject.FindGameObjectWithTag("Player");
    }
	
	// Update is called once per frame
	void Update () {
		if(IsDoorOpenedKey)

        {
            Vector3 relativePoint = gameObject.transform.position;   // poziciq na vraatata
            Vector3 playerPoint = player.transform.position;       // poziciq na igracha
            double relativeX;
            relativeX = playerPoint.x - relativePoint.x;          // razstoqnie ot vratata



            if (relativeX <= 1 && relativeX >= -1)   // chislata moe se fiksnat
            {
                DoorAnimation.Play("");
                DoorWait(StayOpened);
                DoorAnimation.Stop();
            }
        }

	}
    IEnumerator DoorWait(float delay)    // funkciq za wait
    {
        yield return new WaitForSeconds(delay);
    }

    


}

