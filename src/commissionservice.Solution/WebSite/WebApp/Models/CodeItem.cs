﻿using Repository.Pattern.Ef6;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApp.Models
{

    public partial class CodeItem : Entity
    {
             [MaxLength(50), Display(Name = "值"), Required(ErrorMessage = "必填"), Index("CodeItem_IX", 1, IsUnique = true)]
        public string Code { get; set; }
        [MaxLength(50), Display(Name = "显示"), Required(ErrorMessage = "必填")]
        public string Text { get; set; }
        [MaxLength(20), Display(Name = "代码名称"), Required(ErrorMessage = "必填"), Index("CodeItem_IX",2,IsUnique = true)]
        public string CodeType { get; set; }
        [MaxLength(80), Display(Name = "描述"), Required(ErrorMessage = "必填")]
        public string Description { get; set; }
        [Display(Name = "是否禁用")]
        public int IsDisabled { get; set; }
        [Display(Name = "是否支持多选")]
        public bool Multiple { get; set; }

        //[Required(ErrorMessage = "必填"), Index("CodeItem_IX", 2,IsUnique = true)]
        //public int BaseCodeId { get; set; }
        //[ForeignKey("BaseCodeId")]
        //public BaseCode BaseCode { get; set; }
    }
}