/*****************************************************
 * 本类库的核心系 JNTemplate
 * 作者：翅膀的初衷 QQ:4585839
 * Mail: i@Jiniannet.com
 * 网址：http://www.JiNianNet.com
 *****************************************************/
using System;
using System.IO;
using JinianNet.JNTemplate.Context;
namespace JinianNet.JNTemplate
{
    public interface ITemplate
    {
        TemplateContext Context { get;set; }
        String TemplateContent { get;set; }
        void Render(TextWriter writer);
    }
}
