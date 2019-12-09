using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using eThorTest.Data;

namespace eThorTest.Models
{
    public class EntityModel
    {
        private EThorTestEntity _entity;

        public EntityModel()
        {
            _entity = new EThorTestEntity();
        }

        public EntityModel(EThorTestEntity entity)
        {
            _entity = entity;
        }

        public Guid Id => _entity.Id;

        [Required]
        public string Name
        {
            get => _entity.Name;
            set => _entity.Name = value;
        }

        public IEnumerable<string> Properties
        {
            get => _entity.HardProperty;
            set => _entity.HardProperty = value.ToList();
        }

        public string PropertiesValue
        {
            get => string.Join('\n', _entity.HardProperty);
            set => _entity.HardProperty = value.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        }

        public EThorTestEntity GetEntity()
        {
            return _entity;
        }
    }
}
