﻿//*************************** 
//文件名称(File Name)： 
//功能描述(Description)：价格模板产品
//数据表(Tables)：    
//作者(Author)： Xrp
//日期(Create Date)： 2016.06.06
//参考文档(Reference)(可选)：      
//引用(Using) (可选)﹕        
//修改记录(Revision History)：
//***************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conan.Model;

namespace Conan.BLL
{
    /// <summary>
    /// 材料管理
    /// </summary>
    public   class PriceTempletItemBll : BaseBll<PriceTempletItem>
    {
        #region 构造函数
        private static PriceTempletItemBll instance;
        public static PriceTempletItemBll GetInstance()
        {
            if (instance == null)
            {
                instance = new PriceTempletItemBll();
            }
            return instance;
        }
        #endregion




    }
}
