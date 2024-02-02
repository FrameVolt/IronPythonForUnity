using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityLifecycle : MonoBehaviour
{

    public event EventHandler updateEvent;
    public event EventHandler startEvent;

    private void Start()
    {
        startEvent?.Invoke(this, EventArgs.Empty);
    }

    private void Update()
    {
        updateEvent?.Invoke(this, EventArgs.Empty); 
    }

}