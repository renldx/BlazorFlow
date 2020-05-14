#pragma checksum "/Users/renldx/Source/BlazorFlow/BlazorFlow/Pages/Application.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46c8c96bdd7395e9fa3346f7c4a13e4edbc43aad"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorFlow.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/renldx/Source/BlazorFlow/BlazorFlow/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/renldx/Source/BlazorFlow/BlazorFlow/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/renldx/Source/BlazorFlow/BlazorFlow/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/renldx/Source/BlazorFlow/BlazorFlow/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/renldx/Source/BlazorFlow/BlazorFlow/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/renldx/Source/BlazorFlow/BlazorFlow/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/renldx/Source/BlazorFlow/BlazorFlow/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/renldx/Source/BlazorFlow/BlazorFlow/_Imports.razor"
using BlazorFlow;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/renldx/Source/BlazorFlow/BlazorFlow/_Imports.razor"
using BlazorFlow.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/renldx/Source/BlazorFlow/BlazorFlow/Pages/Application.razor"
using BlazorFlow.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/renldx/Source/BlazorFlow/BlazorFlow/Pages/Application.razor"
using BlazorFlow.Shared.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/renldx/Source/BlazorFlow/BlazorFlow/Pages/Application.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/application")]
    public partial class Application : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Flow</h1>\n\n");
#nullable restore
#line 12 "/Users/renldx/Source/BlazorFlow/BlazorFlow/Pages/Application.razor"
 if (CurrentNode is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>\n");
#nullable restore
#line 15 "/Users/renldx/Source/BlazorFlow/BlazorFlow/Pages/Application.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(3);
            __builder.AddAttribute(4, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 18 "/Users/renldx/Source/BlazorFlow/BlazorFlow/Pages/Application.razor"
                 PageModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(6, "\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(9);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\n\n    ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "id", "question");
                __builder2.AddMarkupContent(13, "\n        ");
                __builder2.OpenElement(14, "p");
                __builder2.AddContent(15, 
#nullable restore
#line 23 "/Users/renldx/Source/BlazorFlow/BlazorFlow/Pages/Application.razor"
            CurrentNode.FlowQuestion.FlowQuestionTextEn

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\n\n    ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "id", "answer");
                __builder2.AddMarkupContent(20, "\n");
#nullable restore
#line 27 "/Users/renldx/Source/BlazorFlow/BlazorFlow/Pages/Application.razor"
         if (CurrentNode.FlowNodeType == FlowNodeType.radio)
        {
            if (CurrentNode.FlowAnswers is { } flowAnswers)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "/Users/renldx/Source/BlazorFlow/BlazorFlow/Pages/Application.razor"
                 foreach (var answer in flowAnswers)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(21, "                    ");
                __builder2.OpenElement(22, "label");
                __builder2.AddAttribute(23, "class", "radio-answer");
                __builder2.AddMarkupContent(24, "\n                        ");
                __Blazor.BlazorFlow.Pages.Application.TypeInference.CreateInputRadio_0(__builder2, 25, 26, "radio", 27, 
#nullable restore
#line 34 "/Users/renldx/Source/BlazorFlow/BlazorFlow/Pages/Application.razor"
                                                                int.Parse(answer.FlowAnswerValue!)

#line default
#line hidden
#nullable disable
                , 28, 
#nullable restore
#line 34 "/Users/renldx/Source/BlazorFlow/BlazorFlow/Pages/Application.razor"
                                                                                                                 PageModel.RadioValue

#line default
#line hidden
#nullable disable
                , 29, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => PageModel.RadioValue = __value, PageModel.RadioValue)), 30, () => PageModel.RadioValue);
                __builder2.AddMarkupContent(31, "\n                        ");
                __builder2.AddContent(32, 
#nullable restore
#line 35 "/Users/renldx/Source/BlazorFlow/BlazorFlow/Pages/Application.razor"
                         answer.FlowAnswerTextEn

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(33, "\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\n");
#nullable restore
#line 37 "/Users/renldx/Source/BlazorFlow/BlazorFlow/Pages/Application.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "/Users/renldx/Source/BlazorFlow/BlazorFlow/Pages/Application.razor"
                 
            }
        }
        else if (CurrentNode.FlowNodeType == FlowNodeType.number)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(35, "            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputNumber<decimal>>(36);
                __builder2.AddAttribute(37, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<decimal>(
#nullable restore
#line 42 "/Users/renldx/Source/BlazorFlow/BlazorFlow/Pages/Application.razor"
                                                       PageModel.NumberValue

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<decimal>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<decimal>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => PageModel.NumberValue = __value, PageModel.NumberValue))));
                __builder2.AddAttribute(39, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<decimal>>>(() => PageModel.NumberValue));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "\n");
#nullable restore
#line 43 "/Users/renldx/Source/BlazorFlow/BlazorFlow/Pages/Application.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(41, "    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(43, "\n");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "id", "navigation");
            __builder.AddAttribute(46, "class", "row");
            __builder.AddMarkupContent(47, "\n    ");
            __builder.OpenElement(48, "button");
            __builder.AddAttribute(49, "class", "btn btn-primary");
            __builder.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "/Users/renldx/Source/BlazorFlow/BlazorFlow/Pages/Application.razor"
                                              previous

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "disabled", 
#nullable restore
#line 48 "/Users/renldx/Source/BlazorFlow/BlazorFlow/Pages/Application.razor"
                                                                   isFirstNode

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(52, "Previous");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\n\n");
#nullable restore
#line 50 "/Users/renldx/Source/BlazorFlow/BlazorFlow/Pages/Application.razor"
     if (CurrentLinks?.Length == 0)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(54, "        ");
            __builder.OpenElement(55, "button");
            __builder.AddAttribute(56, "class", "btn btn-primary");
            __builder.AddAttribute(57, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "/Users/renldx/Source/BlazorFlow/BlazorFlow/Pages/Application.razor"
                                                  submit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(58, "Submit");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\n");
#nullable restore
#line 53 "/Users/renldx/Source/BlazorFlow/BlazorFlow/Pages/Application.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(60, "        ");
            __builder.OpenElement(61, "button");
            __builder.AddAttribute(62, "class", "btn btn-primary");
            __builder.AddAttribute(63, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 56 "/Users/renldx/Source/BlazorFlow/BlazorFlow/Pages/Application.razor"
                                                  next

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(64, "Next");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\n");
#nullable restore
#line 57 "/Users/renldx/Source/BlazorFlow/BlazorFlow/Pages/Application.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\n");
#nullable restore
#line 59 "/Users/renldx/Source/BlazorFlow/BlazorFlow/Pages/Application.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(67, "\n\n");
            __builder.AddMarkupContent(68, "<style>\n    button {\n        margin: 0.15em;\n    }\n\n    #step {\n        min-height: 120px;\n    }\n\n    .radio-answer {\n        display: block;\n    }\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 61 "/Users/renldx/Source/BlazorFlow/BlazorFlow/Pages/Application.razor"
       
    Flow? CurrentFlow;
    FlowNode? CurrentNode;
    FlowLink[]? CurrentLinks => CurrentFlow!.OutEdges(CurrentNode!).ToArray();
    UserFlow? UserFlow;

    Model PageModel = new Model();

    bool isFirstNode => false;
    bool isLastNode => false;

    protected override async Task OnInitializedAsync()
    {
        var flowVersion = 1;
        CurrentFlow = await FlowService.GetFlow(flowVersion);
        CurrentNode = CurrentFlow.Vertices.First(x => x.FlowQuestion.FlowQuestionCode == "START");
        UserFlow = new UserFlow(1, flowVersion, 1);
    }

    void next()
    {
        saveUserFlowAnswer();

        evaluateLinks();
    }

    void previous()
    {
        throw new NotImplementedException();
    }

    void submit()
    {
        NavigationManager.NavigateTo("/");
    }

    void saveUserFlowAnswer()
    {
        // check if userNode already exists for this flowNode
        var existingUserNode = UserFlow!.UserFlowAnswers.Where(x => x.Value.FlowNodeId == CurrentNode!.FlowNodeId);

        // userNode already exists for this flowNode, compare current answer with existing answer
        if (existingUserNode.Any())
        {
            // if no differences, do nothing and navigate forward

            // difference found, update current userNode, need to check for changes down the line
        }

        // no userNode exists for this flowNode, create new
        else
        {

        }

        LinkedListNode<UserFlowAnswer> newUserNode;

        switch (CurrentNode!.FlowNodeType)
        {
            case FlowNodeType.none:
                newUserNode = new LinkedListNode<UserFlowAnswer>(new UserFlowAnswer(0, CurrentNode.FlowNodeId));
                break;
            case FlowNodeType.radio:
                newUserNode = new LinkedListNode<UserFlowAnswer>(new UserFlowAnswer(0, CurrentNode.FlowNodeId, PageModel.RadioValue));
                break;
            case FlowNodeType.number:
                newUserNode = new LinkedListNode<UserFlowAnswer>(new UserFlowAnswer(0, CurrentNode.FlowNodeId, PageModel.NumberValue));
                break;
            default:
                newUserNode = new LinkedListNode<UserFlowAnswer>(new UserFlowAnswer(0, 0));
                break;
        }

        if (UserFlow!.UserFlowAnswers.Count() == 0)
        {
            UserFlow.UserFlowAnswers.AddFirst(newUserNode);
        }
        else
        {
            throw new NotImplementedException();
        }
    }

    void evaluateLinks()
    {
        if (CurrentLinks?.Length == 1)
        {
            CurrentNode = CurrentLinks[0].Target;
        }
        else if (CurrentLinks?.Length >= 2)
        {
            var availableLinks = new List<FlowLink>();

            foreach (var link in CurrentLinks!)
            {
                if (link.FlowCondition is { } flowCondition)
                {
                    switch (CurrentNode!.FlowNodeType)
                    {
                        case FlowNodeType.radio:
                            if (flowCondition.Evaluate(PageModel.RadioValue)) availableLinks.Add(link);
                            break;
                        case FlowNodeType.number:
                            if (flowCondition.Evaluate(PageModel.NumberValue)) availableLinks.Add(link);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (availableLinks.Count == 1)
            {
                CurrentNode = availableLinks[0].Target;
            }
        }
    }

    public class Model
    {
        [Range(0, 1)]
        public int RadioValue { get; set; }

        public decimal NumberValue { get; set; }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FlowService FlowService { get; set; }
    }
}
namespace __Blazor.BlazorFlow.Pages.Application
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputRadio_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::BlazorFlow.Shared.Components.InputRadio<TValue>>(seq);
        __builder.AddAttribute(__seq0, "name", __arg0);
        __builder.AddAttribute(__seq1, "SelectedValue", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591