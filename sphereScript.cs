using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereScript : MonoBehaviour
{
    protected Joystick joystick;
    protected FixedButton fixedbutton;

    protected bool jump;




    // Start is called before the first frame update
    void Start()

    {
        joystick = FindObjectOfType<Joystick>();
        fixedbutton = FindObjectOfType<FixedButton>();
        
    }

    // Update is called once per frame
    void Update()
    {
        var rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = new Vector3(joystick.Horizontal * 8f,
                                          rigidbody.velocity.y,
                                          joystick.Vertical * 8f);

        if (!jump && fixedbutton.Pressed)
        {
            jump = true;
            rigidbody.velocity += Vector3.up * 5f;
        } 

        if (jump && !fixedbutton.Pressed)
        {
            jump = false;
        }

    }
}
