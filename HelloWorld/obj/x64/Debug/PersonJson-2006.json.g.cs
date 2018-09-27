// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "PersonJson.json"
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
using __Arr__ = global::Starcounter.Arr<ExpenseJson>;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __PeDeleteAl__ = global::HelloWorld.PersonJson.Input.DeleteAllTrigger;
using __PeCancelTr__ = global::HelloWorld.PersonJson.Input.CancelTrigger;
using __PeCurrentB__ = global::HelloWorld.PersonJson.Input.CurrentBalance;
using __PeNewExpen__ = global::HelloWorld.PersonJson.Input.NewExpenseTrigger;
using __PeFullName__ = global::HelloWorld.PersonJson.Input.FullName;
using __PeSaveTrig__ = global::HelloWorld.PersonJson.Input.SaveTrigger;
using __PeLastName__ = global::HelloWorld.PersonJson.Input.LastName;
using __PeFirstNam__ = global::HelloWorld.PersonJson.Input.FirstName;
using __PeHtml__ = global::HelloWorld.PersonJson.Input.Html;
using __PersonJs2__ = global::HelloWorld.PersonJson.Input;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __PersonJs1__ = global::HelloWorld.PersonJson.JsonByExample;
using __TArray__ = global::Starcounter.Templates.TArray<ExpenseJson>;
using __ExpenseJ1__ = ExpenseJson.JsonByExample;
using __ExSchema__ = ExpenseJson.JsonByExample.Schema;
using __ExpenseJ__ = ExpenseJson;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TString__ = global::Starcounter.Templates.TString;
using __PeSchema__ = global::HelloWorld.PersonJson.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __PersonJs__ = global::HelloWorld.PersonJson;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class PersonJson_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class PersonJson : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __PeSchema__ DefaultTemplate = new __PeSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public PersonJson() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public PersonJson(__PeSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __PeSchema__ Template { get { return (__PeSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__PersonJs__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/HelloWorld/PersonJson.html";
                Html.SetCustomAccessors((_p_) => { return ((__PersonJs__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__PersonJs__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                FirstName = Add<__TString__>("FirstName$");
                FirstName.DefaultValue = "";
                FirstName.Editable = true;
                FirstName.SetCustomAccessors((_p_) => { return ((__PersonJs__)_p_).__bf__FirstName__; }, (_p_, _v_) => { ((__PersonJs__)_p_).__bf__FirstName__ = (System.String)_v_; }, false);
                LastName = Add<__TString__>("LastName$");
                LastName.DefaultValue = "";
                LastName.Editable = true;
                LastName.SetCustomAccessors((_p_) => { return ((__PersonJs__)_p_).__bf__LastName__; }, (_p_, _v_) => { ((__PersonJs__)_p_).__bf__LastName__ = (System.String)_v_; }, false);
                SaveTrigger = Add<__TLong__>("SaveTrigger$");
                SaveTrigger.DefaultValue = 0L;
                SaveTrigger.Editable = true;
                SaveTrigger.SetCustomAccessors((_p_) => { return ((__PersonJs__)_p_).__bf__SaveTrigger__; }, (_p_, _v_) => { ((__PersonJs__)_p_).__bf__SaveTrigger__ = (System.Int64)_v_; }, false);
                SaveTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.SaveTrigger() { App = (PersonJson)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((PersonJson)pup).Handle((Input.SaveTrigger)input); });
                FullName = Add<__TString__>("FullName", bind:"FullName");
                FullName.DefaultValue = "";
                FullName.SetCustomAccessors((_p_) => { return ((__PersonJs__)_p_).__bf__FullName__; }, (_p_, _v_) => { ((__PersonJs__)_p_).__bf__FullName__ = (System.String)_v_; }, false);
                Expenses = Add<__TArray__>("Expenses");
                Expenses.SetCustomGetElementType((arr) => { return __ExpenseJ__.DefaultTemplate;});
                Expenses.SetCustomAccessors((_p_) => { return ((__PersonJs__)_p_).__bf__Expenses__; }, (_p_, _v_) => { ((__PersonJs__)_p_).__bf__Expenses__ = (__Arr__)_v_; }, false);
                NewExpenseTrigger = Add<__TLong__>("NewExpenseTrigger$");
                NewExpenseTrigger.DefaultValue = 0L;
                NewExpenseTrigger.Editable = true;
                NewExpenseTrigger.SetCustomAccessors((_p_) => { return ((__PersonJs__)_p_).__bf__NewExpenseTrigger__; }, (_p_, _v_) => { ((__PersonJs__)_p_).__bf__NewExpenseTrigger__ = (System.Int64)_v_; }, false);
                NewExpenseTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.NewExpenseTrigger() { App = (PersonJson)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((PersonJson)pup).Handle((Input.NewExpenseTrigger)input); });
                CurrentBalance = Add<__TLong__>("CurrentBalance");
                CurrentBalance.DefaultValue = 0L;
                CurrentBalance.SetCustomAccessors((_p_) => { return ((__PersonJs__)_p_).__bf__CurrentBalance__; }, (_p_, _v_) => { ((__PersonJs__)_p_).__bf__CurrentBalance__ = (System.Int64)_v_; }, false);
                CancelTrigger = Add<__TLong__>("CancelTrigger$");
                CancelTrigger.DefaultValue = 0L;
                CancelTrigger.Editable = true;
                CancelTrigger.SetCustomAccessors((_p_) => { return ((__PersonJs__)_p_).__bf__CancelTrigger__; }, (_p_, _v_) => { ((__PersonJs__)_p_).__bf__CancelTrigger__ = (System.Int64)_v_; }, false);
                CancelTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.CancelTrigger() { App = (PersonJson)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((PersonJson)pup).Handle((Input.CancelTrigger)input); });
                DeleteAllTrigger = Add<__TLong__>("DeleteAllTrigger$");
                DeleteAllTrigger.DefaultValue = 0L;
                DeleteAllTrigger.Editable = true;
                DeleteAllTrigger.SetCustomAccessors((_p_) => { return ((__PersonJs__)_p_).__bf__DeleteAllTrigger__; }, (_p_, _v_) => { ((__PersonJs__)_p_).__bf__DeleteAllTrigger__ = (System.Int64)_v_; }, false);
                DeleteAllTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.DeleteAllTrigger() { App = (PersonJson)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((PersonJson)pup).Handle((Input.DeleteAllTrigger)input); });
            }
            public override object CreateInstance(s.Json parent) { return new __PersonJs__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ FirstName;
            public __TString__ LastName;
            public __TLong__ SaveTrigger;
            public __TString__ FullName;
            public __TArray__ Expenses;
            public __TLong__ NewExpenseTrigger;
            public __TLong__ CurrentBalance;
            public __TLong__ CancelTrigger;
            public __TLong__ DeleteAllTrigger;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "PersonJson.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "PersonJson.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__FirstName__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String FirstName {
    #line 3 "PersonJson.json"
        get {
        #line hidden
            return Template.FirstName.Getter(this); }
        #line 3 "PersonJson.json"
        set {
        #line hidden
            Template.FirstName.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__LastName__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String LastName {
    #line 4 "PersonJson.json"
        get {
        #line hidden
            return Template.LastName.Getter(this); }
        #line 4 "PersonJson.json"
        set {
        #line hidden
            Template.LastName.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__SaveTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 SaveTrigger {
    #line 5 "PersonJson.json"
        get {
        #line hidden
            return Template.SaveTrigger.Getter(this); }
        #line 5 "PersonJson.json"
        set {
        #line hidden
            Template.SaveTrigger.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__FullName__;
    #line default
    #line hidden
    private __Arr__ __bf__Expenses__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ Expenses {
    #line 7 "PersonJson.json"
        get {
        #line hidden
            return Template.Expenses.Getter(this); }
        #line 7 "PersonJson.json"
        set {
        #line hidden
            Template.Expenses.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__NewExpenseTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 NewExpenseTrigger {
    #line 8 "PersonJson.json"
        get {
        #line hidden
            return Template.NewExpenseTrigger.Getter(this); }
        #line 8 "PersonJson.json"
        set {
        #line hidden
            Template.NewExpenseTrigger.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__CurrentBalance__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 CurrentBalance {
    #line 9 "PersonJson.json"
        get {
        #line hidden
            return Template.CurrentBalance.Getter(this); }
        #line 9 "PersonJson.json"
        set {
        #line hidden
            Template.CurrentBalance.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__CancelTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 CancelTrigger {
    #line 10 "PersonJson.json"
        get {
        #line hidden
            return Template.CancelTrigger.Getter(this); }
        #line 10 "PersonJson.json"
        set {
        #line hidden
            Template.CancelTrigger.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__DeleteAllTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 DeleteAllTrigger {
    #line 11 "PersonJson.json"
        get {
        #line hidden
            return Template.DeleteAllTrigger.Getter(this); }
        #line 11 "PersonJson.json"
        set {
        #line hidden
            Template.DeleteAllTrigger.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__PersonJs__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class FirstName : Input<__PersonJs__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class LastName : Input<__PersonJs__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class SaveTrigger : Input<__PersonJs__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class FullName : Input<__PersonJs__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class NewExpenseTrigger : Input<__PersonJs__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class CurrentBalance : Input<__PersonJs__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class CancelTrigger : Input<__PersonJs__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class DeleteAllTrigger : Input<__PersonJs__, __TLong__, long> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
