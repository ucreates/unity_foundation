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
public sealed class RangeValidatorUnitBuilder : BaseValidatorUnitBuilder {
    public override string type {
        get;
        set;
    }
    public string min {
        get;
        set;
    }
    public string max {
        get;
        set;
    }
    public string option {
        get;
        set;
    }
    public RangeValidatorUnitBuilder() {
    }
    public RangeValidatorUnitBuilder AddType(string type) {
        this.type = type.ToLower();
        return this;
    }
    public RangeValidatorUnitBuilder AddMin(string min) {
        this.min = min.ToLower();
        return this;
    }
    public RangeValidatorUnitBuilder AddMax(string max) {
        this.max = max.ToLower();
        return this;
    }
    public RangeValidatorUnitBuilder AddOption(string option) {
        this.option = option.ToLower();
        return this;
    }
    public override object Build() {
        object validator = null;
        if (this.type.Equals("int") || this.type.Equals("string")) {
            validator = this.UnitFactoryMethod<int>();
        } else if (this.type.Equals("long")) {
            validator = this.UnitFactoryMethod<long>();
        } else if (this.type.Equals("float")) {
            validator = this.UnitFactoryMethod<float>();
        } else if (this.type.Equals("double")) {
            validator = this.UnitFactoryMethod<double>();
        }
        return validator;
    }
    protected override BaseValidatorUnit<T> UnitFactoryMethod<T>() {
        RangeValidatorUnit<T> validator = new RangeValidatorUnit<T>();
        validator.min = Core.Object.Convert.ToGenerics<T>(this.min);
        validator.max = Core.Object.Convert.ToGenerics<T>(this.max);
        validator.validateMessage = this.message;
        if (option.Equals("addequal")) {
            validator.option = RangeValidatorUnit<T>.Option.AddEqual;
        } else {
            validator.option = RangeValidatorUnit<T>.Option.Default;
        }
        return validator;
    }
}
}
