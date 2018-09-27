// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "ExpenseJson.json"
// Version: 2006
// DO NOT MODIFY DIRECTLY - CHANGES WILL BE OVERWRITTEN

using System;
using System.Collections;
using System.Collections.Generic;
using Starcounter.Advanced;
using Starcounter;
using Starcounter.Templates;
using Starcounter.XSON;
#pragma warning disable 0108
#pragma warning disable 1591

namespace HelloWorld {
using __ExpenseJ1__ = global::HelloWorld.ExpenseJson.JsonByExample;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __ExAmount__ = global::HelloWorld.ExpenseJson.Input.Amount;
using __ExDescript__ = global::HelloWorld.ExpenseJson.Input.Description;
using __ExHtml__ = global::HelloWorld.ExpenseJson.Input.Html;
using __ExpenseJ2__ = global::HelloWorld.ExpenseJson.Input;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __TString__ = global::Starcounter.Templates.TString;
using __ExSchema__ = global::HelloWorld.ExpenseJson.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __ExpenseJ__ = global::HelloWorld.ExpenseJson;
using __TLong__ = global::Starcounter.Templates.TLong;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class ExpenseJson_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class ExpenseJson : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __ExSchema__ DefaultTemplate = new __ExSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public ExpenseJson() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public ExpenseJson(__ExSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __ExSchema__ Template { get { return (__ExSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__ExpenseJ__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/HelloWorld/ExpenseJson.html";
                Html.SetCustomAccessors((_p_) => { return ((__ExpenseJ__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__ExpenseJ__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Description = Add<__TString__>("Description$");
                Description.DefaultValue = "";
                Description.Editable = true;
                Description.SetCustomAccessors((_p_) => { return ((__ExpenseJ__)_p_).__bf__Description__; }, (_p_, _v_) => { ((__ExpenseJ__)_p_).__bf__Description__ = (System.String)_v_; }, false);
                Amount = Add<__TLong__>("Amount$");
                Amount.DefaultValue = 0L;
                Amount.Editable = true;
                Amount.SetCustomAccessors((_p_) => { return ((__ExpenseJ__)_p_).__bf__Amount__; }, (_p_, _v_) => { ((__ExpenseJ__)_p_).__bf__Amount__ = (System.Int64)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __ExpenseJ__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ Description;
            public __TLong__ Amount;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "ExpenseJson.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "ExpenseJson.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Description__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Description {
    #line 3 "ExpenseJson.json"
        get {
        #line hidden
            return Template.Description.Getter(this); }
        #line 3 "ExpenseJson.json"
        set {
        #line hidden
            Template.Description.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__Amount__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 Amount {
    #line 4 "ExpenseJson.json"
        get {
        #line hidden
            return Template.Amount.Getter(this); }
        #line 4 "ExpenseJson.json"
        set {
        #line hidden
            Template.Amount.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__ExpenseJ__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Description : Input<__ExpenseJ__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Amount : Input<__ExpenseJ__, __TLong__, long> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
