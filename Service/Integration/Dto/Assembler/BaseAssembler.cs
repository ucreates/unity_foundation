﻿//======================================================================
// Project Name    : unity_foundation
//
// Copyright © 2016 U-CREATES. All rights reserved.
//
// This source code is the property of U-CREATES.
// If such findings are accepted at any time.
// We hope the tips and helpful in developing.
//======================================================================
using System.Collections.Generic;
namespace Service.Integration.Dto.Assembler {
public abstract class BaseAssembler<T> {
    public BaseAssembler() {
    }
    public virtual List<T> WriteToTableList() {
        return null;
    }
}
}