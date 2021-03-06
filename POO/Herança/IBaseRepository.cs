﻿using System;
using System.Collections.Generic;
using System.Text;

namespace POO.Herança
{
    public interface IBaseRepository <TEntity>
    {
        void Save(TEntity entity);

        void Update(int id);

        void Delete(int id);
    }
}
