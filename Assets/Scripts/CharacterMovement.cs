using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float speed;
    public bool animate;
    private GameObject mc;
    bool attack;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        mc = GameObject.Find("Dragoon");
        speed = 0.001f;
        animate = false;
        animator = mc.GetComponent<Animator>();
        attack = false;
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        //float v = Input.GetAxisRaw("Vertical");
        if (Input.GetKey(KeyCode.Space))
        {
            attack = !attack;
        }


        mc.transform.position = new Vector2(transform.position.x + (h * speed), 0);
    }
}
