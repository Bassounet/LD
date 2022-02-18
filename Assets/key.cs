using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour
{

    public bool collectable = false;
    public GameObject f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

   
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && collectable)
        {

            f.SetActive(true);
            Invoke("DestroyTheKey", 2f);
            other.GetComponent<AI_Behaviour>().GetKey = true;
            
        }
    }

    public void DestroyTheKey()
    {


        f.SetActive(false);
        this.gameObject.SetActive(false);

    }

}
