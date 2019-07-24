//======================================================================
// Project Name    : unity_foundation
//
// Copyright © 2019 U-CREATES. All rights reserved.
//
// This source code is the property of U-CREATES.
// If such findings are accepted at any time.
// We hope the tips and helpful in developing.
//======================================================================
using System.Collections.Generic;
using UnityEngine;
namespace Frontend.Component.Route {
public abstract class BaseRouteSearch {
    public Vector3 start {
        get;
        set;
    }
    public Vector3 goal {
        get;
        set;
    }
    public BaseRouteSearch() {
        this.start = Vector3.zero;
        this.goal = Vector3.zero;
    }
    public virtual List<Vector3> Execute() {
        return null;
    }
    public bool IsReadyExecute() {
        if (this.start == this.goal) {
            return false;
        }
        return true;
    }
}
}
