﻿namespace HearthCap.Data
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Settings : IEntityWithId<int>
    {
        [Key]
        public int Id { get; protected set; }

        public string Key { get; set; }

        public virtual IList<SettingsItem> Items { get; protected set; }

        public Settings()
        {
            Items = new List<SettingsItem>();
        }
    }
}