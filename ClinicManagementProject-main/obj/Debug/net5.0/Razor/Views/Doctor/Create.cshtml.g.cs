#pragma checksum "C:\CollaberaTraining\July05Tim\Mona\ClinicManagementProject-main\Views\Doctor\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f915e3d0fd459dd90aedc1b4b04f40e4df81df18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doctor_Create), @"mvc.1.0.view", @"/Views/Doctor/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f915e3d0fd459dd90aedc1b4b04f40e4df81df18", @"/Views/Doctor/Create.cshtml")]
    public class Views_Doctor_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClinicManagementProject.Models.Doctor>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\CollaberaTraining\July05Tim\Mona\ClinicManagementProject-main\Views\Doctor\Create.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f915e3d0fd459dd90aedc1b4b04f40e4df81df183000", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Create</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f915e3d0fd459dd90aedc1b4b04f40e4df81df184060", async() => {
                WriteLiteral("\r\n\r\n    <h4>Doctor</h4>\r\n    <hr />\r\n    <div class=\"row\">\r\n        <div class=\"col-md-4\">\r\n");
#nullable restore
#line 20 "C:\CollaberaTraining\July05Tim\Mona\ClinicManagementProject-main\Views\Doctor\Create.cshtml"
             using (Html.BeginForm("Create", "Doctor", FormMethod.Post))
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\CollaberaTraining\July05Tim\Mona\ClinicManagementProject-main\Views\Doctor\Create.cshtml"
           Write(Html.LabelFor(m => m.Username, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\CollaberaTraining\July05Tim\Mona\ClinicManagementProject-main\Views\Doctor\Create.cshtml"
           Write(Html.EditorFor(m => m.Username, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\CollaberaTraining\July05Tim\Mona\ClinicManagementProject-main\Views\Doctor\Create.cshtml"
           Write(Html.LabelFor(m => m.Password, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\CollaberaTraining\July05Tim\Mona\ClinicManagementProject-main\Views\Doctor\Create.cshtml"
           Write(Html.PasswordFor(m => m.Password, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\CollaberaTraining\July05Tim\Mona\ClinicManagementProject-main\Views\Doctor\Create.cshtml"
           Write(Html.ValidationMessageFor(m => m.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\CollaberaTraining\July05Tim\Mona\ClinicManagementProject-main\Views\Doctor\Create.cshtml"
           Write(Html.LabelFor(m => m.Name, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\CollaberaTraining\July05Tim\Mona\ClinicManagementProject-main\Views\Doctor\Create.cshtml"
           Write(Html.EditorFor(m => m.Name, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\CollaberaTraining\July05Tim\Mona\ClinicManagementProject-main\Views\Doctor\Create.cshtml"
           Write(Html.LabelFor(m => m.Gender, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\CollaberaTraining\July05Tim\Mona\ClinicManagementProject-main\Views\Doctor\Create.cshtml"
           Write(Html.EditorFor(m => m.Gender, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\CollaberaTraining\July05Tim\Mona\ClinicManagementProject-main\Views\Doctor\Create.cshtml"
           Write(Html.LabelFor(m => m.Age, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\CollaberaTraining\July05Tim\Mona\ClinicManagementProject-main\Views\Doctor\Create.cshtml"
           Write(Html.EditorFor(m => m.Age, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\CollaberaTraining\July05Tim\Mona\ClinicManagementProject-main\Views\Doctor\Create.cshtml"
           Write(Html.LabelFor(m => m.Phone, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\CollaberaTraining\July05Tim\Mona\ClinicManagementProject-main\Views\Doctor\Create.cshtml"
           Write(Html.EditorFor(m => m.Phone, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\CollaberaTraining\July05Tim\Mona\ClinicManagementProject-main\Views\Doctor\Create.cshtml"
           Write(Html.LabelFor(m => m.Specialization, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\CollaberaTraining\July05Tim\Mona\ClinicManagementProject-main\Views\Doctor\Create.cshtml"
           Write(Html.EditorFor(m => m.Specialization, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("                <input type=\"submit\" value=\"Add Doctor\" class=\"btn btn-primary\" />\r\n");
#nullable restore
#line 44 "C:\CollaberaTraining\July05Tim\Mona\ClinicManagementProject-main\Views\Doctor\Create.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n    </div>\r\n\r\n    <div>\r\n        <a asp-action=\"Index\">Back to List</a>\r\n    </div>\r\n\r\n");
                DefineSection("Scripts", async() => {
                    WriteLiteral("\r\n");
#nullable restore
#line 53 "C:\CollaberaTraining\July05Tim\Mona\ClinicManagementProject-main\Views\Doctor\Create.cshtml"
          await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                    WriteLiteral("    ");
                }
                );
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ClinicManagementProject.Models.Doctor> Html { get; private set; }
    }
}
#pragma warning restore 1591