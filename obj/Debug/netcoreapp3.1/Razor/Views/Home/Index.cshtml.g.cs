#pragma checksum "C:\Users\ferna\Desktop\SENAC\Módulo 2\UC06\projetohotsite\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37002e55e1909c6d451592844fcbe4eb2bfabe7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\ferna\Desktop\SENAC\Módulo 2\UC06\projetohotsite\Views\_ViewImports.cshtml"
using Hotsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ferna\Desktop\SENAC\Módulo 2\UC06\projetohotsite\Views\_ViewImports.cshtml"
using Hotsite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37002e55e1909c6d451592844fcbe4eb2bfabe7a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bc39314ee689b901092e0940a38afe41bd0f7d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Interesse>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-sm-2 col-form-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/Cadastrar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ferna\Desktop\SENAC\Módulo 2\UC06\projetohotsite\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Hotsite";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row my-2"">
    <div class=""col-12 col-md-12 col-lg-4"">
        <h1 class=""text-center text-green"">Iniciativa Saúde da Cidade</h1>
        <p>
            Texto sobre vida saudável: Lorem ipsum dolor sit amet et delectus accommodare his consul copiosae legendos
            at vix ad putent delectus delicata usu. Vidit dissentiet eos cu eum an brute copiosae hendrerit.
        </p>
        <p>
            Texto sobre vida iniciativa: Lorem ipsum dolor sit amet et delectus accommodare his consul copiosae legendos
            at vix ad putent delectus delicata usu. Vidit dissentiet eos cu eum an brute copiosae hendrerit.
        </p>
    </div>

    <div class=""col-12 col-md-12 col-lg-8 text-center"">
        <img src=""/images/pexels-ella-olsson-1640777.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 852, "\"", 858, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-fluid"">
    </div>

</div>

<div class=""row my-2"">
    <div class=""col-12 col-md-12 col-lg-4 border border-success rounded py-2 my-2 bg-light"">

        <h2>Entre em contato!</h2>
        <p>Nos mande uma mensagem e fique por dentro de nossos eventos</p>

        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37002e55e1909c6d451592844fcbe4eb2bfabe7a6751", async() => {
                WriteLiteral("\r\n            <div class=\"form-group row\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37002e55e1909c6d451592844fcbe4eb2bfabe7a7071", async() => {
                    WriteLiteral("Nome:");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 33 "C:\Users\ferna\Desktop\SENAC\Módulo 2\UC06\projetohotsite\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Nome);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                <div class=\"col-sm-10\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "37002e55e1909c6d451592844fcbe4eb2bfabe7a8758", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 35 "C:\Users\ferna\Desktop\SENAC\Módulo 2\UC06\projetohotsite\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Nome);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group row\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37002e55e1909c6d451592844fcbe4eb2bfabe7a10763", async() => {
                    WriteLiteral("Email:");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 39 "C:\Users\ferna\Desktop\SENAC\Módulo 2\UC06\projetohotsite\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Email);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                <div class=\"col-sm-10\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "37002e55e1909c6d451592844fcbe4eb2bfabe7a12453", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 41 "C:\Users\ferna\Desktop\SENAC\Módulo 2\UC06\projetohotsite\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Email);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37002e55e1909c6d451592844fcbe4eb2bfabe7a14456", async() => {
                    WriteLiteral("Mensagem (opcional):");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 45 "C:\Users\ferna\Desktop\SENAC\Módulo 2\UC06\projetohotsite\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Mensagem);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37002e55e1909c6d451592844fcbe4eb2bfabe7a16027", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#nullable restore
#line 46 "C:\Users\ferna\Desktop\SENAC\Módulo 2\UC06\projetohotsite\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Mensagem);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n            <div>\r\n                <input type=\"submit\" value=\"Enviar\" class=\"btn btn-success\" />\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>

    <div class=""col-12 col-md-12 col-lg-8 d-flex align-items-center"">
        <div class=""row"">
            <div class=""col-12 col-lg-4 text-center"" data-bs-toggle=""modal"" data-bs-target=""#modalAgenda"">
                <figure class=""figure"" style=""cursor: pointer;"">
                    <img src=""/images/agenda.jpg"" alt=""Imagem de agenda"" class=""img-fluid"">
                    <figcaption class=""figure-caption text-center text-green"">Agenda</figcaption>
                </figure>
            </div>
            <div class=""col-12 col-lg-4 text-center"" data-bs-toggle=""modal"" data-bs-target=""#modalApoiadores"">
                <figure class=""figure"" style=""cursor: pointer;"">
                    <img src=""/images/apoio.jpg"" alt=""Imagem de patrocinadores"" class=""img-fluid"">
                    <figcaption class=""figure-caption text-center text-green"">Apoiadores</figcaption>
                </figure>
            </div>
            <div class=""col-12 col-lg-4 text-center"" data-bs-toggle=""");
            WriteLiteral(@"modal"" data-bs-target=""#modalDicas"">
                <figure class=""figure"" style=""cursor: pointer;"">
                    <img src=""/images/dicas.jpg"" alt=""Imagem de receita sendo preparada"" class=""img-fluid"">
                    <figcaption class=""figure-caption text-center text-green"">Dicas de vida saudável</figcaption>
                </figure>
            </div>

        </div>

    </div>
</div>

");
            WriteLiteral(@"
<div class=""modal fade"" id=""modalAgenda"" tabindex=""-1"" aria-labelledby=""modalAgendaLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header justify-content-center"">
                <h2 class=""modal-title"" id=""exampleModalLabel"">Agenda</h2>
            </div>
            <div class=""modal-body"">
                <h3 class=""text-center"">10/10/10 10:10 - Evento 1</h3>
                <p class=""mb-5"">Lorem ipsum dolor sit amet consectetur, adipisicing elit. Blanditiis optio vel
                    recusandae alias
                    soluta, ratione esse minima libero consectetur repudiandae atque voluptates corrupti. Impedit omnis
                    necessitatibus cumque perferendis, tempora aperiam autem accusamus harum laborum. Tempora commodi
                    placeat odit magnam odio.</p>
                <h3 class=""text-center"">10/10/10 10:10 - Evento 2</h3>
                <p class=""mb-5"">Lorem ipsum dolor sit amet c");
            WriteLiteral(@"onsectetur, adipisicing elit. Blanditiis optio vel
                    recusandae alias
                    soluta, ratione esse minima libero consectetur repudiandae atque voluptates corrupti. Impedit omnis
                    necessitatibus cumque perferendis, tempora aperiam autem accusamus harum laborum. Tempora commodi
                    placeat odit magnam odio.</p>
                <h3 class=""text-center"">10/10/10 10:10 - Evento 3</h3>
                <p class=""mb-5"">Lorem ipsum dolor sit amet consectetur, adipisicing elit. Blanditiis optio vel
                    recusandae alias
                    soluta, ratione esse minima libero consectetur repudiandae atque voluptates corrupti. Impedit omnis
                    necessitatibus cumque perferendis, tempora aperiam autem accusamus harum laborum. Tempora commodi
                    placeat odit magnam odio.</p>
                <h3 class=""text-center"">10/10/10 10:10 - Evento 4</h3>
                <p class=""mb-5"">Lorem ipsum dolor sit amet");
            WriteLiteral(@" consectetur, adipisicing elit. Blanditiis optio vel
                    recusandae alias
                    soluta, ratione esse minima libero consectetur repudiandae atque voluptates corrupti. Impedit omnis
                    necessitatibus cumque perferendis, tempora aperiam autem accusamus harum laborum. Tempora commodi
                    placeat odit magnam odio.</p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Fechar</button>
            </div>
        </div>
    </div>
</div>

");
            WriteLiteral(@"<div class=""modal fade"" id=""modalApoiadores"" tabindex=""-1"" aria-labelledby=""modalApoiadoresLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header justify-content-center"">
                <h2 class=""modal-title"" id=""exampleModalLabel"">Apoiadores</h2>
            </div>
            <div class=""modal-body"">
                <div class=""card mb-3 pl-3"" style=""max-width: 540px;"">
                    <div class=""row g-0"">
                        <div class=""col-md-4 m-auto"">
                            <img src=""/images/Empresa1.jpg"" class=""img-fluid rounded-start"" alt=""Logo da Empresa 1"">
                        </div>
                        <div class=""col-md-8"">
                            <div class=""card-body"">
                                <h5 class=""card-title"">Empresa 1</h5>
                                <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Vel,
                                    consectet");
            WriteLiteral(@"ur. Eos laudantium maiores ipsam eaque.</p>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""card mb-3 pl-3"" style=""max-width: 540px;"">
                    <div class=""row g-0"">
                        <div class=""col-md-4 m-auto"">
                            <img src=""/images/Empresa1.jpg"" class=""img-fluid rounded-start"" alt=""Logo da Empresa 1"">
                        </div>
                        <div class=""col-md-8"">
                            <div class=""card-body"">
                                <h5 class=""card-title"">Empresa 2</h5>
                                <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Vel,
                                    consectetur. Eos laudantium maiores ipsam eaque.</p>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""card mb-3 pl-3"" style=""max-widt");
            WriteLiteral(@"h: 540px;"">
                    <div class=""row g-0"">
                        <div class=""col-md-4 m-auto"">
                            <img src=""/images/Empresa1.jpg"" class=""img-fluid rounded-start"" alt=""Logo da Empresa 1"">
                        </div>
                        <div class=""col-md-8"">
                            <div class=""card-body"">
                                <h5 class=""card-title"">Empresa 3</h5>
                                <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Vel,
                                    consectetur. Eos laudantium maiores ipsam eaque.</p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Fechar</button>
            </div>
        </div>
    </div>
</div>

");
            WriteLiteral(@"
<div class=""modal fade"" id=""modalDicas"" tabindex=""-1"" aria-labelledby=""modalDicasLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header justify-content-center"">
                <h2 class=""modal-title"" id=""exampleModalLabel"">Dicas de vida saudável</h2>
            </div>
            <div class=""modal-body"">
                <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Tempore libero cupiditate minima dignissimos
                    illum consequuntur labore, odio autem maiores assumenda soluta, itaque quae ab cumque explicabo
                    illo. Impedit laboriosam facilis, sint soluta vel suscipit possimus sed sequi asperiores saepe ipsam
                    expedita consequatur voluptatibus nisi, qui consectetur quisquam libero, quas quibusdam?</p>

                <p>Lorem ipsum dolor sit amet consectetur, adipisicing elit. Facere quibusdam ipsum qui blanditiis
                    voluptatibus vero ");
            WriteLiteral(@"non vel laboriosam placeat, quaerat ad totam ea mollitia minima accusantium dicta
                    numquam in quidem architecto sunt dolor maxime. Amet, eaque, voluptas suscipit neque perferendis
                    dolorum quam doloremque cumque rem harum cum dolore assumenda molestias debitis dicta odio quaerat
                    repellat nobis. Reprehenderit est deserunt cupiditate.</p>

                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Temporibus dicta illo officiis fugit
                    tenetur dolores repudiandae quis odit perferendis similique magni ipsum, nulla repellat, distinctio
                    corrupti porro, deleniti consequatur perspiciatis culpa nihil eius sed a consequuntur ratione.
                    Eligendi totam, repellendus iure, suscipit, repudiandae cupiditate odit corporis provident inventore
                    similique eos repellat enim rem necessitatibus officia corrupti obcaecati? Corporis eius itaque
                    aliquam vo");
            WriteLiteral(@"luptatum dolorum dolores consectetur, necessitatibus quo delectus? Eaque nam, doloremque
                    nisi nostrum adipisci modi velit, fuga accusamus quasi, nobis asperiores sunt aliquam dolores
                    explicabo possimus itaque. Fugiat dolores vel eos? Perferendis harum quo iusto aliquam sapiente.
                    Beatae, quibusdam commodi.</p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Fechar</button>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Interesse> Html { get; private set; }
    }
}
#pragma warning restore 1591