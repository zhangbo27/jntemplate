/********************************************************************************
 Copyright (c) jiniannet (http://www.jiniannet.com). All rights reserved.
 Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
 ********************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;

namespace JinianNet.JNTemplate.Parser.Node
{
    /// <summary>
    /// 基本类型标签
    /// </summary>
    /// <typeparam name="T">类型</typeparam>
    public abstract class TypeTag<T> : Tag
    {
        private T baseValue;
        /// <summary>
        /// 值
        /// </summary>
        public T Value
        {
            get { return this.baseValue; }
            set { this.baseValue = value; }
        }
        /// <summary>
        /// 解析结果
        /// </summary>
        /// <param name="context">TemplateContext</param>
        /// <returns></returns>
        public override object Parse(TemplateContext context)
        {
            return this.Value;
        }

        /// <summary>
        /// 解析结果
        /// </summary>
        /// <param name="context">TemplateContext</param>
        /// <param name="write">TextWriter</param>
        public override void Parse(TemplateContext context, System.IO.TextWriter write)
        {
            write.Write(this.Value.ToString());
        }

        ///// <summary>
        ///// 输出STRING
        ///// </summary>
        ///// <returns></returns>
        //public override String ToString()
        //{
        //    if (this.Value != null)
        //    {
        //        return this.Value.ToString();
        //    }
        //    return String.Empty;
        //}
    }
}