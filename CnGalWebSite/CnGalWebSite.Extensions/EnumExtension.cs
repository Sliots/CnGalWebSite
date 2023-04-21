﻿using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace CnGalWebSite.Extensions
{
    public static class EnumExtension
    {
        /// <summary>
        /// 获得枚举的displayName
        /// </summary>
        /// <param name="eum"></param>
        /// <returns></returns>
        public static string GetDisplayName(this Enum eum)
        {
            try
            {
                if (eum == null)
                {
                    return string.Empty;
                }
                var type = eum.GetType();
                var field = type.GetField(eum.ToString());
                var obj = (DisplayAttribute)field.GetCustomAttribute(typeof(DisplayAttribute));
                return obj?.Name ?? "";
            }
            catch (Exception ex)
            {
                return string.Empty;
            }
        }
    }
}
