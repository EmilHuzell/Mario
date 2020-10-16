using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mario : MonoBehaviour
{
    // Start is called before the first frame update
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var body = GetComponent<Rigidbody2D>();
        var collider = GetComponent<CapsuleCollider2D>();
        
        //touching floor check
        RaycastHit2D hitFloor = Physics2D.Raycast(collider.bounds.center - new Vector3(0,collider.bounds.extents.y + 0.01f,0), Vector2.down, 0.1f);
        //touching somethings side
        RaycastHit2D hitRight = Physics2D.Raycast(collider.bounds.center + new Vector3(collider.bounds.extents.x + 0.01f,0,0), Vector2.right, 0.1f);

        //Debug.DrawRay(collider.bounds.center + new Vector3(collider.bounds.extents.x + 0.01f,0,0), Vector2.right, Color.blue, 0.1f);

        if(hitRight.rigidbody != null)
        {
            Debug.Log(hitRight.collider.name);
            switch (hitRight.collider.name)
            { 
                case "FlagPole":
                  Debug.Log("victory");
                  FlagBehavior.touched = true;
                  break;
                case "Enemy":
                  Debug.Log("fail");
                  break; 
            }
        }
        

        if(Input.anyKey){
            if(Input.GetKey(KeyCode.A)) 
            {
			    // go left
			    body.AddForce(-this.transform.right);
		    }
            if(Input.GetKey(KeyCode.D)) 
            {
			    // go right
			    body.AddForce(this.transform.right);
		    }

            if(hitFloor.rigidbody != null)
            {
                if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.Space)) 
                    {
			            // jump
			            body.AddForce(25*this.transform.up);
		            }
            }
                
        }
        
    }
    
}
