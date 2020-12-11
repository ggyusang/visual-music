﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate512cubes : MonoBehaviour
{
    GameObject _instanceSampleCube;
    public GameObject _sampleCubePrefab;
    GameObject[] _sampleCube = new GameObject[512];
    public float _maxPower;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i<512; i++)
        {
            GameObject _instanceSampleCube = (GameObject)Instantiate(_sampleCubePrefab);
            _instanceSampleCube.transform.position = this.transform.position;
            _instanceSampleCube.transform.parent = this.transform;
            _instanceSampleCube.name = "Samplecube" + i;
            this.transform.eulerAngles = new Vector3(0, -0.703125f * i, 0);
            _instanceSampleCube.transform.position = Vector3.forward * 100;  //왜 해야하는지 확인해봅시당
            _sampleCube[i] = _instanceSampleCube;
        }
    }

    // Update is called once per frame
    void Update()
    {
      
        for (int i = 0; i < 512; i++)
        {
            if(_sampleCube != null)
            {
                _sampleCube[i].transform.localScale = new Vector3(10, (Audio._spectrumdata[i]*_maxPower)+2, 10);
            }
        }
    }
}


 