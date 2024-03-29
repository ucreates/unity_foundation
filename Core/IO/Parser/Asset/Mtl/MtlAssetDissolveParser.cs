﻿//======================================================================
// Project Name    : unity_foundation
//
// Copyright © 2017 U-CREATES. All rights reserved.
//
// This source code is the property of U-CREATES.
// If such findings are accepted at any time.
// We hope the tips and helpful in developing.
//======================================================================
using System;
using Core.IO.Format.Asset;
namespace Core.IO.Parser.Asset {
public class MtlAssetDissolveParser : MtlAssetBaseParser<MtlAssetDissolveFormat> {
    public override MtlAssetDissolveFormat Read(string header, string body) {
        MtlAssetDissolveFormat format = new MtlAssetDissolveFormat();
        format.header = header;
        format.dissolve = Convert.ToSingle(body);
        return format;
    }
}
}
