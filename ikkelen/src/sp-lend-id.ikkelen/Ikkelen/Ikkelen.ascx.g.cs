﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5448
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sp_lend_id.ikkelen.Ikkelen {
    using System.Web.Profile;
    using System.Text.RegularExpressions;
    using System.Web.Caching;
    using System.Configuration;
    using System.Collections.Specialized;
    using System.Web.UI.HtmlControls;
    using System.Web.UI.WebControls;
    using System.Collections;
    using System.Web.UI;
    using System.Web.UI.WebControls.WebParts;
    using System;
    using System.Web.Security;
    using System.Web;
    using System.Web.SessionState;
    using System.Text;
    
    
    public partial class Ikkelen {
        
        public static implicit operator global::System.Web.UI.TemplateControl(Ikkelen target) 
        {
            return target == null ? null : target.TemplateControl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void @__BuildControlTree(global::sp_lend_id.ikkelen.Ikkelen.Ikkelen @__ctrl) {
            @__ctrl.SetRenderMethodDelegate(new System.Web.UI.RenderMethod(this.@__Render__control1));
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void @__Render__control1(System.Web.UI.HtmlTextWriter @__w, System.Web.UI.Control parameterContainer) {
            @__w.Write(@"
<link rel=""stylesheet"" href=""/sp-lend-id/ikkelen.css""/>
<script type=""text/javascript"" 
    src=""//ajax.googleapis.com/ajax/libs/jquery/1.7.2/jquery.min.js""></script>
<script type=""text/javascript"" 
    src=""/sp-lend-id/ikkelen.js""></script>
<div data-role=""notification-area""></div>
<input type=""button"" data-role=""clickMe"" value=""Click me to show a notification""/>
<script type=""text/javascript"">
    ikkelen(jQuery, """);
             @__w.Write( this.ClientID );

            @__w.Write("\");\r\n</script>\r\n");
        }
        
        private void InitializeControl() {
            this.@__BuildControlTree(this);
            this.Load += new global::System.EventHandler(this.Page_Load);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected virtual object Eval(string expression) {
            return global::System.Web.UI.DataBinder.Eval(this.Page.GetDataItem(), expression);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected virtual string Eval(string expression, string format) {
            return global::System.Web.UI.DataBinder.Eval(this.Page.GetDataItem(), expression, format);
        }
    }
}
