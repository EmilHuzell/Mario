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
        //vector2 centerOfBody = body.
        

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

            

            RaycastHit2D hitFloor = Physics2D.Raycast(collider.bounds.center - new Vector3(0,collider.bounds.extents.y + 0.01f,0), Vector2.down, 0.1f);
           

            Debug.DrawRay(collider.bounds.center - collider.bounds.extents, Vector2.down, Color.red);

            Debug.Log(hitFloor.rigidbody);

            if(hitFloor.rigidbody != null)
            {
                if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.Space)) 
                    {
			            // jump
			            body.AddForce(10*this.transform.up);
		            }
            }
                
        }
        
    }
    
}
