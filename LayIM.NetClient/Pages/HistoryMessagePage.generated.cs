﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace LayIM.NetClient
{
    using System;
    using System.Collections.Generic;

#line 1 "..\..\Views\Home\HistoryMessageView.cshtml"
    using LayIM.NetClient;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    public partial class HistoryMessagePage : RazorPage
    {
        public HistoryMessagePage()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");


#line 3 "..\..\Views\Home\HistoryMessageView.cshtml"

            var models = Storage.GetConnection().GetHistoryMessages(100000, 100001, "friend");
            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 10 "..\..\Views\Home\HistoryMessageView.cshtml"
 foreach (var item in models)
            {
                if (item.self)
                {

            
            #line default
            #line hidden
WriteLiteral("        <li");

WriteLiteral(" class=\"layim-chat-mine\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"layim-chat-user\">");

WriteLiteral(" <img src = \"" + item.avatar + "\" />");

WriteLiteral("<cite><i>");

            
            #line 17 "..\..\Views\Home\HistoryMessageView.cshtml"
                    Write(item.addtime);
            #line default
            #line hidden
WriteLiteral("</i>");

            
            #line 17 "..\..\Views\Home\HistoryMessageView.cshtml"
                                     Write(item.name);

            
            #line default
            #line hidden
WriteLiteral("</cite>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"layim-chat-text\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 20 "..\..\Views\Home\HistoryMessageView.cshtml"
           Write(item.content);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </li>\r\n");

            
            #line 23 "..\..\Views\Home\HistoryMessageView.cshtml"
    }
    else
    {

            
            #line default
            #line hidden
WriteLiteral("        <li>\r\n            <div");

WriteLiteral(" class=\"layim-chat-user\">");

                    WriteLiteral(" <img src = \"" + item.avatar + "\" />");

                    WriteLiteral("<cite>");

            
            #line 29 "..\..\Views\Home\HistoryMessageView.cshtml"
                 Write(item.name);

            
            #line default
            #line hidden
WriteLiteral("<i>");

            
            #line 29 "..\..\Views\Home\HistoryMessageView.cshtml"
                              Write(item.addtime);

            
            #line default
            #line hidden
WriteLiteral("</i></cite>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"layim-chat-text\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 32 "..\..\Views\Home\HistoryMessageView.cshtml"
           Write(item.content);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </li>\r\n");

            
            #line 35 "..\..\Views\Home\HistoryMessageView.cshtml"
    }
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
