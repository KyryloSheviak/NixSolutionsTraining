﻿using System;
using System.Runtime.CompilerServices;

namespace ORM.Attributes
{
    public class ManyToManyAttribute : Attribute
    {
        public string StagingTable { get; set; }
        public string FkForThisObject { get; set; }
        public string FkForAnotherObject { get; set; }
        public string NameCollection { get; set; }

        public ManyToManyAttribute(string stagingTable, string fkForThisObject, string fkForAnotherObject, [CallerMemberName] string nameCollection = null)
        {
            this.StagingTable = stagingTable;
            this.FkForThisObject = fkForThisObject;
            this.FkForAnotherObject = fkForAnotherObject;
            this.NameCollection = nameCollection;
        }
    }
}