﻿using Sys.Framework.Model.Sys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sys.Framework.Service.Sys
{
    public interface IRoleService
    {
        /// <summary>
        /// 插入
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="isSave"></param>
        /// <returns></returns>
        int Insert(T_Sys_Role entity, bool isSave = true);
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="isSave"></param>
        /// <returns></returns>
        int Update(T_Sys_Role entity, bool isSave = true);
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="whereLambds"></param>
        /// <param name="isSave"></param>
        /// <returns></returns>
        int DeleteById(Expression<Func<T_Sys_Role, bool>> whereLambds, bool isSave = true);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="S"></typeparam>
        /// <param name="whereLambds"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalItem"></param>
        /// <param name="orderByLambds"></param>
        /// <param name="isAsc"></param>
        /// <returns></returns>
        IEnumerable<T_Sys_Role> GetData(int pageIndex, int pageSize, string key, out int totalItem, bool isAsc = true);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>

        IEnumerable<T_Sys_Role> GetAll();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        T_Sys_Role GetModel(Expression<Func<T_Sys_Role, bool>> where);
    }
}
