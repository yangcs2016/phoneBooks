using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Book.Books.PhoneNumbers
{
    /// <summary>
    /// 电话号码
    /// </summary>
    public class PhoneNumber :Entity<long>,IHasCreationTime
    {
        /// <summary>
        /// 电话号
        /// </summary>
        [Required]
        [MaxLength(11)]
        public string Number { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        public PhoneNumberType Type { get; set; }
        /// <summary>
        /// 人员
        /// </summary>
        public Persons.Person Person { get; set; }
        /// <summary>
        /// 人员Id
        /// </summary>
        public int PersionId { get; set; }
    }
}
