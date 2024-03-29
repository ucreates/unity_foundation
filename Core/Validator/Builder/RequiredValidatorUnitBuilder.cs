//======================================================================
// Project Name    : unity_foundation
//
// Copyright © 2016 U-CREATES. All rights reserved.
//
// This source code is the property of U-CREATES.
// If such findings are accepted at any time.
// We hope the tips and helpful in developing.
//======================================================================
using Core.Validator.Unit;
namespace Core.Validator.Builder {
public sealed class RequiredValidatorUnitBuilder : BaseValidatorUnitBuilder {
    public override string type {
        get;
        set;
    }
    public RequiredValidatorUnitBuilder() {
    }
    public RequiredValidatorUnitBuilder AddType(string type) {
        this.type = type;
        return this;
    }
    public override object Build() {
        object validator = null;
        if (type.ToLower().Equals("int")) {
            validator = this.UnitFactoryMethod<int>();
        } else if (type.ToLower().Equals("long")) {
            validator = this.UnitFactoryMethod<long>();
        } else if (type.ToLower().Equals("float")) {
            validator = this.UnitFactoryMethod<float>();
        } else if (type.ToLower().Equals("double")) {
            validator = this.UnitFactoryMethod<double>();
        } else if (type.ToLower().Equals("string")) {
            validator = this.UnitFactoryMethod<string>();
        }
        return validator;
    }
    protected override BaseValidatorUnit<T> UnitFactoryMethod<T>() {
        RequiredValidatorUnit<T> validator = new RequiredValidatorUnit<T>();
        validator.validateMessage = this.message;
        return validator;
    }
}
}
