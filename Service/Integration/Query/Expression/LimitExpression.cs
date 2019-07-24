//======================================================================
// Project Name    : unity_foundation
//
// Copyright © 2016 U-CREATES. All rights reserved.
//
// This source code is the property of U-CREATES.
// If such findings are accepted at any time.
// We hope the tips and helpful in developing.
//======================================================================
namespace Service.Integration.Query.Expression {
public sealed class LimitExpression : BaseExpression {
    public int limit {
        get;
        set;
    }
    public LimitExpression() : this(0) {
    }
    public LimitExpression(int limit) {
        this.limit = limit;
    }
}
}
