using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	
	public CharacterController2D controller;
    // Start is called before the first frame update
	float horizontalMove = 20f;
	public float runSpeed = 70f;
	bool jump = false;
	bool crouch = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
		
		if (Input.GetButtonDown("Jump"))
		{
			jump = true;
		}
		
		if (Input.GetButtonDown("Crouch"))
		{
			crouch = true;
		}else if (Input.GetButtonUp("Crouch"))
		{
			crouch = false;
		}
        if (Input.GetButtonDown("Sprint"))
        {
            runSpeed = 140f;
        }
        else if (Input.GetButtonUp("Sprint"))
        {
            runSpeed = 70f;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.LoadLevel("Menu");
            Debug.Log("Send for destroy the timer...");
            GameObject.Find("TimerText").SendMessage("Destroy");
        }

    }
	
	void FixedUpdate()
	{
		controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
		jump = false;
	}
}
