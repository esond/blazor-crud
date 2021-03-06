﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eThorTest.Data
{
    public class EThorTestEntity : IComparable
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<string> HardProperty
        {
            get => _hardProperty ??= new List<string>();
            set => _hardProperty = value;
        }
        private ICollection<string> _hardProperty;

        #region Implementation of IComparable

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
