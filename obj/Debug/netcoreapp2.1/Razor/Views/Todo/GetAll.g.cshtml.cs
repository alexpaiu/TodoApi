#pragma checksum "/Users/alexpaiu/ToDoNew/TodoApi/Views/Todo/GetAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9328d899cdc51a14ecafac9885ac6df7373763fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Todo_GetAll), @"mvc.1.0.view", @"/Views/Todo/GetAll.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Todo/GetAll.cshtml", typeof(AspNetCore.Views_Todo_GetAll))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9328d899cdc51a14ecafac9885ac6df7373763fa", @"/Views/Todo/GetAll.cshtml")]
    public class Views_Todo_GetAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TodoApi.Models.TodoItem>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 103, true);
            WriteLiteral("\r\n<table>\r\n    <thead>\r\n        <th>Name </th>\r\n        <th>Is complete</th>\r\n        <th>Time  </th>\r\n");
            EndContext();
#line 8 "/Users/alexpaiu/ToDoNew/TodoApi/Views/Todo/GetAll.cshtml"
     for (int i = 0; i < Model.Count; i++)
    {

#line default
#line hidden
            BeginContext(192, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(241, 13, false);
#line 12 "/Users/alexpaiu/ToDoNew/TodoApi/Views/Todo/GetAll.cshtml"
           Write(Model[i].Name);

#line default
#line hidden
            EndContext();
            BeginContext(254, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(310, 19, false);
#line 15 "/Users/alexpaiu/ToDoNew/TodoApi/Views/Todo/GetAll.cshtml"
           Write(Model[i].IsComplete);

#line default
#line hidden
            EndContext();
            BeginContext(329, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(385, 18, false);
#line 18 "/Users/alexpaiu/ToDoNew/TodoApi/Views/Todo/GetAll.cshtml"
           Write(Model[i].CreatedAt);

#line default
#line hidden
            EndContext();
            BeginContext(403, 40, true);
            WriteLiteral("\r\n                </td>\r\n        </tr>\r\n");
            EndContext();
#line 21 "/Users/alexpaiu/ToDoNew/TodoApi/Views/Todo/GetAll.cshtml"
    }

#line default
#line hidden
            BeginContext(450, 141, true);
            WriteLiteral("</table>\r\n\r\n\r\n<form action=\"/api/todo\" method=\"POST\">\r\n    <input type=\"text\" name=\"name\"/>\r\n    <input type=\"submit\"/>\r\n</form>\r\n\r\n   \r\n\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TodoApi.Models.TodoItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
