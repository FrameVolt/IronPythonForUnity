using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class MonoBehaviourCode : MonoBehaviour
{
    
    public void Fun()
    {
        Debug.Log("Fun");
    }
    public async void AsyncFun()
    {
        Debug.Log("Async Funtion start");
        await Task.Delay(1000);
        Debug.Log("Async Funtion end");
    }
}
