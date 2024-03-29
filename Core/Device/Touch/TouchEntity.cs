﻿//======================================================================
// Project Name    : unity_foundation
//
// Copyright © 2016 U-CREATES. All rights reserved.
//
// This source code is the property of U-CREATES.
// If such findings are accepted at any time.
// We hope the tips and helpful in developing.
//======================================================================
using UnityEngine;
using System.Collections.Generic;
namespace Core.Device.Touch {
public class TouchEntity {
    public TouchPhase touchPhase {
        get;
        set;
    }
    public List<Vector3> touchPositionList {
        get;
        set;
    }
    public TouchEntity() {
        this.touchPhase = TouchPhase.Canceled;
        this.touchPositionList = new List<Vector3>();
    }
}
}
