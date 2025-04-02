using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionDesign : MonoBehaviour
{
    int result;
   public int userOne;
   public int userTwo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    int AddTwoNumbers(int one, int two)
    {
        result = one + two;
        Debug.Log(result);
        return result;
       
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {
        AddTwoNumbers(userOne, userTwo);    
        }
    }
}
