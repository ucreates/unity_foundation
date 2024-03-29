﻿//======================================================================
// Project Name    : unity_foundation
//
// Copyright © 2017 U-CREATES. All rights reserved.
//
// This source code is the property of U-CREATES.
// If such findings are accepted at any time.
// We hope the tips and helpful in developing.
//======================================================================
namespace Core.IO.Format.Asset {
public class MtlAssetDissolveFormat : MtlAssetBaseFormat {
    public float dissolve {
        get;
        set;
    }
    public MtlAssetDissolveFormat() {
        this.dissolve = 0.0f;
    }
}
}
