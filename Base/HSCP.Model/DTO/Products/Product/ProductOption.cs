﻿//*************************** 
//文件名称(File Name)： 
//功能描述(Description)：产品搜索实体
//数据表(Tables)：    
//作者(Author)： Xrp
//日期(Create Date)： 2016.04.28
//参考文档(Reference)(可选)：      
//引用(Using) (可选)﹕        
//修改记录(Revision History)：
//***************************

namespace Conan.Model
{
    public class ProductOption
    {
        public int? StoreId{ get; set; }
        public int? Id { get; set; }
        public int? CategoryId { get; set; }
        public string CategoryName { get; set; }
        public ProductStateEnum? State { get; set; }
        public string Name { get; set; }
        public string ProductCode { get; set; }
    }
}