﻿//*************************** 
//文件名称(File Name)： 
//功能描述(Description)：价格模板搜索实体
//数据表(Tables)：    
//作者(Author)： Xrp
//日期(Create Date)： 2016.04.28
//参考文档(Reference)(可选)：      
//引用(Using) (可选)﹕        
//修改记录(Revision History)：
//***************************

using System;

namespace Conan.Model
{
    public class PriceTempletAddCmd
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime StartTime { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime EndTime { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public PriceTempletStateEnum State { get; set; }
        /// <summary>
        /// 要删除的价格模板
        /// </summary>
        public string DeTempletPricel { get; set; }
    }
}
