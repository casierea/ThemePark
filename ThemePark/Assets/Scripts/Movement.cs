<<<<<<< HEAD
﻿using System.Collections;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector3 offScreenPosition, startingPosition;
    public float timeToTravel, percentTraveled;

    private bool _finished;
    
    public void Start()
    {
        _finished = false;
    }

    public void MoveToFinalPosition(Vector3SO finalPosition)
    {
        StartCoroutine(DoTheMove(finalPosition));
    }

    public IEnumerator DoTheMove(Vector3SO finalPosition)
    {
        startingPosition = transform.position;
        percentTraveled = 0f;
        while (!_finished)
        {
            percentTraveled += Time.deltaTime / timeToTravel;
            transform.position = Vector3.Lerp(startingPosition, finalPosition.Position, percentTraveled);
            if (transform.position == finalPosition.Position)
                _finished = true;
            yield return null;
        }
        _finished = false;
    }
=======
﻿using System.Collections;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector3 offScreenPosition, startingPosition;
    public float timeToTravel, percentTraveled;

    private bool _finished;
    
    public void Start()
    {
        _finished = false;
    }

    public void MoveToFinalPosition(Vector3SO finalPosition)
    {
        StartCoroutine(DoTheMove(finalPosition));
    }

    public IEnumerator DoTheMove(Vector3SO finalPosition)
    {
        startingPosition = transform.position;
        percentTraveled = 0f;
        while (!_finished)
        {
            percentTraveled += Time.deltaTime / timeToTravel;
            transform.position = Vector3.Lerp(startingPosition, finalPosition.Position, percentTraveled);
            if (transform.position == finalPosition.Position)
                _finished = true;
            yield return null;
        }
        _finished = false;
    }
>>>>>>> 70a0f9f16ad177f4b21438af99ef17e541da6143
}