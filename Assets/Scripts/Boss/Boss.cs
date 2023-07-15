using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public Transform player;

    public bool IsFacingRight;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        IsFacingRight = false;
    }
    public void LookAtPlayer()
    {
        Vector3 flipped = transform.localScale;
        flipped.z *= -1f;

        if(player != null){
            
            if (transform.position.x > player.position.x && IsFacingRight)
            {
                transform.localScale = flipped;
                transform.Rotate(0f, 180f, 0f);
                IsFacingRight = false;
            }
            else if (transform.position.x < player.position.x && !IsFacingRight)
            {
                transform.localScale = flipped;
                transform.Rotate(0f, 180f, 0f);
                IsFacingRight = true;
            }
        }
    }
   

}
