﻿//======================================================================
// Project Name    : unity_foundation
//
// Copyright © 2017 U-CREATES. All rights reserved.
//
// This source code is the property of U-CREATES.
// If such findings are accepted at any time.
// We hope the tips and helpful in developing.
//======================================================================
using UnityEngine;
using System;
using System.Text.RegularExpressions;
using Core.IO.Format.Asset;
namespace Core.IO.Parser.Asset {
public class MtlAssetAmbientParser : MtlAssetBaseParser<MtlAssetAmbientFormat> {
    public override MtlAssetAmbientFormat Read(string header, string body) {
        Regex pattern = new Regex(@"\s+");
        string[] elements = pattern.Split(body);
        if (0 == elements.Length) {
            return null;
        }
        float r = Convert.ToSingle(elements[0]);
        float g = Convert.ToSingle(elements[1]);
        float b = Convert.ToSingle(elements[2]);
        MtlAssetAmbientFormat format = new MtlAssetAmbientFormat();
        format.header = header;
        format.color = new Color(r, g, b, 1.0f);
        return format;
    }
}
}
