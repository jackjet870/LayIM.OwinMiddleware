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

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 1 "..\..\Views\Home\ChatLog.cshtml"
    using LayIM.NetClient.Pages.Model;
    
    #line default
    #line hidden
    using MVCSample;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Home/ChatLog.cshtml")]
    public partial class _Views_Home_ChatLog_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Home_ChatLog_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Home\ChatLog.cshtml"
  
    var models = new List<LayimChatMessage>()
    {
        new LayimChatMessage { uid=1, self=true, name="小盘子", content="hello", avatar="", addtime="2017-06-08 17:32" },
        new LayimChatMessage { uid=1, self=false, name="小盘子", content="hello", avatar="", addtime="2017-06-08 17:32" }
    };

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<head>\r\n    <meta");

WriteLiteral(" charset=\"utf-8\"");

WriteLiteral(">\r\n    <title>聊天记录</title>\r\n    <link");

WriteLiteral(" href=\"/Scripts/layui/css/layui.css\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(">\r\n    <style>body .layim-chat-main {height: auto;}</style>\r\n    <link");

WriteLiteral(" href=\"/css/layim.css\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n</head>\r\n\r\n    <div");

WriteLiteral(" class=\"layim-chat-main\"");

WriteLiteral(">\r\n        <ul");

WriteLiteral(" id=\"LAY_view\"");

WriteLiteral(">  \r\n            <div");

WriteLiteral(" id=\"chatLogMore\"");

WriteLiteral(" class=\"layim-chat-system\"");

WriteLiteral(" style=\"display:none;\"");

WriteLiteral("><span>查看更多记录</span></div>\r\n");

            
            #line 21 "..\..\Views\Home\ChatLog.cshtml"
            
            
            #line default
            #line hidden
            
            #line 21 "..\..\Views\Home\ChatLog.cshtml"
             foreach (var item in models)
            {
                if (item.self)
                {

            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteLiteral(" class=\"layim-chat-mine\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"layim-chat-user\"");

WriteLiteral(">\r\n                    <img");

WriteAttribute("src", Tuple.Create(" src=\"", 991), Tuple.Create("\"", 1009)
            
            #line 27 "..\..\Views\Home\ChatLog.cshtml"
, Tuple.Create(Tuple.Create("", 997), Tuple.Create<System.Object, System.Int32>(item.avatar
            
            #line default
            #line hidden
, 997), false)
);

WriteLiteral(" />\r\n                    <cite><i>");

            
            #line 28 "..\..\Views\Home\ChatLog.cshtml"
                        Write(item.addtime);

            
            #line default
            #line hidden
WriteLiteral("</i>");

            
            #line 28 "..\..\Views\Home\ChatLog.cshtml"
                                         Write(item.name);

            
            #line default
            #line hidden
WriteLiteral("</cite>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"layim-chat-text\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 31 "..\..\Views\Home\ChatLog.cshtml"
               Write(item.content);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </li>\r\n");

            
            #line 34 "..\..\Views\Home\ChatLog.cshtml"
                }
                else
                {

            
            #line default
            #line hidden
WriteLiteral("            <li>\r\n                <div");

WriteLiteral(" class=\"layim-chat-user\"");

WriteLiteral(">\r\n                    <img");

WriteAttribute("src", Tuple.Create(" src=\"", 1378), Tuple.Create("\"", 1396)
            
            #line 39 "..\..\Views\Home\ChatLog.cshtml"
, Tuple.Create(Tuple.Create("", 1384), Tuple.Create<System.Object, System.Int32>(item.avatar
            
            #line default
            #line hidden
, 1384), false)
);

WriteLiteral(" />\r\n                    <cite>");

            
            #line 40 "..\..\Views\Home\ChatLog.cshtml"
                     Write(item.name);

            
            #line default
            #line hidden
WriteLiteral("<i>");

            
            #line 40 "..\..\Views\Home\ChatLog.cshtml"
                                  Write(item.addtime);

            
            #line default
            #line hidden
WriteLiteral("</i></cite>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"layim-chat-text\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 43 "..\..\Views\Home\ChatLog.cshtml"
               Write(item.content);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </li>\r\n");

            
            #line 46 "..\..\Views\Home\ChatLog.cshtml"
                }
            }

            
            #line default
            #line hidden
WriteLiteral("         </ul>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" id=\"LAY_page\"");

WriteLiteral(" style=\"margin: 0 10px;\"");

WriteLiteral("></div>\r\n    <script");

WriteLiteral(" src=\"https://cdn.bootcss.com/jquery/3.2.1/jquery.min.js\"");

WriteLiteral("></script>\r\n    <script>\r\n        $(function () {\r\n            $(\'#chatLogMore\')." +
"on(\'click\', function () {\r\n                console.log(\'查看更多\');\r\n            })\r" +
"\n        })\r\n        \r\n    </script>\r\n");

        }
    }
}
#pragma warning restore 1591