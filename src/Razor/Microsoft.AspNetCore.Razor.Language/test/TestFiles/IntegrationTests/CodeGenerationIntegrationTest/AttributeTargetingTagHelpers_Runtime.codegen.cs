#pragma checksum "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/AttributeTargetingTagHelpers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ceb35a784a30ab44eb8b621c9e61d2361841c63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Microsoft.AspNetCore.Razor.Language.IntegrationTests.TestFiles.TestFiles_IntegrationTests_CodeGenerationIntegrationTest_AttributeTargetingTagHelpers_Runtime), @"default", @"/TestFiles/IntegrationTests/CodeGenerationIntegrationTest/AttributeTargetingTagHelpers.cshtml")]
namespace Microsoft.AspNetCore.Razor.Language.IntegrationTests.TestFiles
{
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ceb35a784a30ab44eb8b621c9e61d2361841c63", @"/TestFiles/IntegrationTests/CodeGenerationIntegrationTest/AttributeTargetingTagHelpers.cshtml")]
    public class TestFiles_IntegrationTests_CodeGenerationIntegrationTest_AttributeTargetingTagHelpers_Runtime
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("catchAll", new global::Microsoft.AspNetCore.Html.HtmlString("hi"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "checkbox", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::TestNamespace.PTagHelper __TestNamespace_PTagHelper;
        private global::TestNamespace.CatchAllTagHelper __TestNamespace_CatchAllTagHelper;
        private global::TestNamespace.InputTagHelper __TestNamespace_InputTagHelper;
        private global::TestNamespace.InputTagHelper2 __TestNamespace_InputTagHelper2;
        #pragma warning disable 1998
        public async System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("p", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "test", async() => {
                WriteLiteral("\r\n    <p>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("strong", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "test", async() => {
                    WriteLiteral("Hello");
                }
                );
                __TestNamespace_CatchAllTagHelper = CreateTagHelper<global::TestNamespace.CatchAllTagHelper>();
                __tagHelperExecutionContext.Add(__TestNamespace_CatchAllTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("<strong>World</strong></p>\r\n    <input checked=\"true\" />\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "test", async() => {
                }
                );
                __TestNamespace_InputTagHelper = CreateTagHelper<global::TestNamespace.InputTagHelper>();
                __tagHelperExecutionContext.Add(__TestNamespace_InputTagHelper);
                __TestNamespace_InputTagHelper2 = CreateTagHelper<global::TestNamespace.InputTagHelper2>();
                __tagHelperExecutionContext.Add(__TestNamespace_InputTagHelper2);
                __TestNamespace_InputTagHelper.Type = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __TestNamespace_InputTagHelper2.Type = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 6 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/AttributeTargetingTagHelpers.cshtml"
__TestNamespace_InputTagHelper2.Checked = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("checked", __TestNamespace_InputTagHelper2.Checked, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "test", async() => {
                }
                );
                __TestNamespace_InputTagHelper = CreateTagHelper<global::TestNamespace.InputTagHelper>();
                __tagHelperExecutionContext.Add(__TestNamespace_InputTagHelper);
                __TestNamespace_InputTagHelper2 = CreateTagHelper<global::TestNamespace.InputTagHelper2>();
                __tagHelperExecutionContext.Add(__TestNamespace_InputTagHelper2);
                __TestNamespace_CatchAllTagHelper = CreateTagHelper<global::TestNamespace.CatchAllTagHelper>();
                __tagHelperExecutionContext.Add(__TestNamespace_CatchAllTagHelper);
                __TestNamespace_InputTagHelper.Type = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __TestNamespace_InputTagHelper2.Type = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 7 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/AttributeTargetingTagHelpers.cshtml"
__TestNamespace_InputTagHelper2.Checked = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("checked", __TestNamespace_InputTagHelper2.Checked, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __TestNamespace_PTagHelper = CreateTagHelper<global::TestNamespace.PTagHelper>();
            __tagHelperExecutionContext.Add(__TestNamespace_PTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
