#pragma checksum "C:\Users\Grant\Desktop\School\.Net Software Development\.Net-Projects\WatsonUniversity\Views\Instructors\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2143b621d502f89f8b6b7ce174223bc907618e1ec1407467efee65c84957a691"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Instructors_Index), @"mvc.1.0.view", @"/Views/Instructors/Index.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Grant\Desktop\School\.Net Software Development\.Net-Projects\WatsonUniversity\Views\_ViewImports.cshtml"
using WatsonUniversity

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\Grant\Desktop\School\.Net Software Development\.Net-Projects\WatsonUniversity\Views\_ViewImports.cshtml"
using WatsonUniversity.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"2143b621d502f89f8b6b7ce174223bc907618e1ec1407467efee65c84957a691", @"/Views/Instructors/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"a25181026c58180a29c5fd95ec3178280072f77cb0b91787975e5affa453e395", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Instructors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WatsonUniversity.Models.SchoolViewModels.InstructorIndexData>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Grant\Desktop\School\.Net Software Development\.Net-Projects\WatsonUniversity\Views\Instructors\Index.cshtml"
  
    ViewData["Title"] = "Instructors";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<h2>Instructors</h2>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2143b621d502f89f8b6b7ce174223bc907618e1ec1407467efee65c84957a6915243", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</p>
<table class=""table"">
    <thead>
        <tr>
            <th>Last Name</th>
            <th>First Name</th>
            <th>Hire Date</th>
            <th>Office</th>
            <th>Courses</th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 24 "C:\Users\Grant\Desktop\School\.Net Software Development\.Net-Projects\WatsonUniversity\Views\Instructors\Index.cshtml"
         foreach (var item in Model.Instructors)
        {
            string selectedRow = "";
            if (item.ID == (int?)ViewData["InstructorID"])
            {
                selectedRow = "table-success";
            }

#line default
#line hidden
#nullable disable

            WriteLiteral("            <tr");
            BeginWriteAttribute("class", " class=\"", 721, "\"", 741, 1);
            WriteAttributeValue("", 729, 
#nullable restore
#line 31 "C:\Users\Grant\Desktop\School\.Net Software Development\.Net-Projects\WatsonUniversity\Views\Instructors\Index.cshtml"
                        selectedRow

#line default
#line hidden
#nullable disable
            , 729, 12, false);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <td>\r\n                    ");
            Write(
#nullable restore
#line 33 "C:\Users\Grant\Desktop\School\.Net Software Development\.Net-Projects\WatsonUniversity\Views\Instructors\Index.cshtml"
                     Html.DisplayFor(modelItem => item.LastName)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            Write(
#nullable restore
#line 36 "C:\Users\Grant\Desktop\School\.Net Software Development\.Net-Projects\WatsonUniversity\Views\Instructors\Index.cshtml"
                     Html.DisplayFor(modelItem => item.FirstMidName)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            Write(
#nullable restore
#line 39 "C:\Users\Grant\Desktop\School\.Net Software Development\.Net-Projects\WatsonUniversity\Views\Instructors\Index.cshtml"
                     Html.DisplayFor(modelItem => item.HireDate)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 42 "C:\Users\Grant\Desktop\School\.Net Software Development\.Net-Projects\WatsonUniversity\Views\Instructors\Index.cshtml"
                     if (item.OfficeAssignment != null)
                    {
                        

#line default
#line hidden
#nullable disable

            Write(
#nullable restore
#line 44 "C:\Users\Grant\Desktop\School\.Net Software Development\.Net-Projects\WatsonUniversity\Views\Instructors\Index.cshtml"
                         item.OfficeAssignment.Location

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 44 "C:\Users\Grant\Desktop\School\.Net Software Development\.Net-Projects\WatsonUniversity\Views\Instructors\Index.cshtml"
                                                       
                    }

#line default
#line hidden
#nullable disable

            WriteLiteral("                </td>\r\n                <td>\r\n");
#nullable restore
#line 48 "C:\Users\Grant\Desktop\School\.Net Software Development\.Net-Projects\WatsonUniversity\Views\Instructors\Index.cshtml"
                     foreach (var course in item.CourseAssignments)
                    {
                        

#line default
#line hidden
#nullable disable

            Write(
#nullable restore
#line 50 "C:\Users\Grant\Desktop\School\.Net Software Development\.Net-Projects\WatsonUniversity\Views\Instructors\Index.cshtml"
                         course.Course.CourseID

#line default
#line hidden
#nullable disable
            );
            Write(
#nullable restore
#line 50 "C:\Users\Grant\Desktop\School\.Net Software Development\.Net-Projects\WatsonUniversity\Views\Instructors\Index.cshtml"
                                                  " "

#line default
#line hidden
#nullable disable
            );
            Write(
#nullable restore
#line 50 "C:\Users\Grant\Desktop\School\.Net Software Development\.Net-Projects\WatsonUniversity\Views\Instructors\Index.cshtml"
                                                        course.Course.Title

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" <br />\r\n");
#nullable restore
#line 51 "C:\Users\Grant\Desktop\School\.Net Software Development\.Net-Projects\WatsonUniversity\Views\Instructors\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable

            WriteLiteral("                </td>\r\n\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2143b621d502f89f8b6b7ce174223bc907618e1ec1407467efee65c84957a69111422", async() => {
                WriteLiteral("Select");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 55 "C:\Users\Grant\Desktop\School\.Net Software Development\.Net-Projects\WatsonUniversity\Views\Instructors\Index.cshtml"
                                                         item.ID

#line default
#line hidden
#nullable disable
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2143b621d502f89f8b6b7ce174223bc907618e1ec1407467efee65c84957a69113702", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 56 "C:\Users\Grant\Desktop\School\.Net Software Development\.Net-Projects\WatsonUniversity\Views\Instructors\Index.cshtml"
                                                        item.ID

#line default
#line hidden
#nullable disable
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2143b621d502f89f8b6b7ce174223bc907618e1ec1407467efee65c84957a69115979", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 57 "C:\Users\Grant\Desktop\School\.Net Software Development\.Net-Projects\WatsonUniversity\Views\Instructors\Index.cshtml"
                                                           item.ID

#line default
#line hidden
#nullable disable
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2143b621d502f89f8b6b7ce174223bc907618e1ec1407467efee65c84957a69118262", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 58 "C:\Users\Grant\Desktop\School\.Net Software Development\.Net-Projects\WatsonUniversity\Views\Instructors\Index.cshtml"
                                                          item.ID

#line default
#line hidden
#nullable disable
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 61 "C:\Users\Grant\Desktop\School\.Net Software Development\.Net-Projects\WatsonUniversity\Views\Instructors\Index.cshtml"
        }

#line default
#line hidden
#nullable disable

            WriteLiteral("    </tbody>\r\n</table>\r\n");
#nullable restore
#line 64 "C:\Users\Grant\Desktop\School\.Net Software Development\.Net-Projects\WatsonUniversity\Views\Instructors\Index.cshtml"
 if (Model.Courses != null)
{

#line default
#line hidden
#nullable disable

            WriteLiteral("    <h3>Courses Taught by Selected Instructor</h3>\r\n    <table class=\"table\">\r\n        <tr>\r\n            <th></th>\r\n            <th>Number</th>\r\n            <th>Title</th>\r\n            <th>Department</th>\r\n        </tr>\r\n\r\n");
#nullable restore
#line 75 "C:\Users\Grant\Desktop\School\.Net Software Development\.Net-Projects\WatsonUniversity\Views\Instructors\Index.cshtml"
         foreach (var item in Model.Courses)
        {
            string selectedRow = "";
            if (item.CourseID == (int?)ViewData["CourseID"])
            {
                selectedRow = "success";
            }

#line default
#line hidden
#nullable disable

            WriteLiteral("            <tr");
            BeginWriteAttribute("class", " class=\"", 2450, "\"", 2470, 1);
            WriteAttributeValue("", 2458, 
#nullable restore
#line 82 "C:\Users\Grant\Desktop\School\.Net Software Development\.Net-Projects\WatsonUniversity\Views\Instructors\Index.cshtml"
                        selectedRow

#line default
#line hidden
#nullable disable
            , 2458, 12, false);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <td>\r\n                    ");
            Write(
#nullable restore
#line 84 "C:\Users\Grant\Desktop\School\.Net Software Development\.Net-Projects\WatsonUniversity\Views\Instructors\Index.cshtml"
                     Html.ActionLink("Select", "Index", new { courseID = item.CourseID })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            Write(
#nullable restore
#line 87 "C:\Users\Grant\Desktop\School\.Net Software Development\.Net-Projects\WatsonUniversity\Views\Instructors\Index.cshtml"
                     item.CourseID

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            Write(
#nullable restore
#line 90 "C:\Users\Grant\Desktop\School\.Net Software Development\.Net-Projects\WatsonUniversity\Views\Instructors\Index.cshtml"
                     item.Title

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            Write(
#nullable restore
#line 93 "C:\Users\Grant\Desktop\School\.Net Software Development\.Net-Projects\WatsonUniversity\Views\Instructors\Index.cshtml"
                     item.Department.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 96 "C:\Users\Grant\Desktop\School\.Net Software Development\.Net-Projects\WatsonUniversity\Views\Instructors\Index.cshtml"
        }

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n    </table>\r\n");
#nullable restore
#line 99 "C:\Users\Grant\Desktop\School\.Net Software Development\.Net-Projects\WatsonUniversity\Views\Instructors\Index.cshtml"
}

#line default
#line hidden
#nullable disable

#nullable restore
#line 100 "C:\Users\Grant\Desktop\School\.Net Software Development\.Net-Projects\WatsonUniversity\Views\Instructors\Index.cshtml"
 if (Model.Enrollments != null)
{

#line default
#line hidden
#nullable disable

            WriteLiteral("    <h3>\r\n        Students Enrolled in Selected Course\r\n    </h3>\r\n    <table class=\"table\">\r\n        <tr>\r\n            <th>Name</th>\r\n            <th>Grade</th>\r\n        </tr>\r\n");
#nullable restore
#line 110 "C:\Users\Grant\Desktop\School\.Net Software Development\.Net-Projects\WatsonUniversity\Views\Instructors\Index.cshtml"
         foreach (var item in Model.Enrollments)
        {

#line default
#line hidden
#nullable disable

            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            Write(
#nullable restore
#line 114 "C:\Users\Grant\Desktop\School\.Net Software Development\.Net-Projects\WatsonUniversity\Views\Instructors\Index.cshtml"
                     item.Student.FullName

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            Write(
#nullable restore
#line 117 "C:\Users\Grant\Desktop\School\.Net Software Development\.Net-Projects\WatsonUniversity\Views\Instructors\Index.cshtml"
                     Html.DisplayFor(modelItem => item.Grade)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 120 "C:\Users\Grant\Desktop\School\.Net Software Development\.Net-Projects\WatsonUniversity\Views\Instructors\Index.cshtml"
        }

#line default
#line hidden
#nullable disable

            WriteLiteral("    </table>\r\n");
#nullable restore
#line 122 "C:\Users\Grant\Desktop\School\.Net Software Development\.Net-Projects\WatsonUniversity\Views\Instructors\Index.cshtml"
}

#line default
#line hidden
#nullable disable

        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WatsonUniversity.Models.SchoolViewModels.InstructorIndexData> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
