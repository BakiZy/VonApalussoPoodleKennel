﻿using FirstRealApp.Models.PoodleEntity;

namespace FirstRealApp.Interfaces
{
    public interface IFilterRepository
    {

        public IQueryable<Poodle> SearchPoodleByColor(string color);

        public IQueryable<Poodle> SearchPoodleBySize(string size);

        public IQueryable<Poodle> SearchPoodleByName(string name);
    }
}
