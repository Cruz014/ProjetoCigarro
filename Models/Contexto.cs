﻿using Microsoft.EntityFrameworkCore;

namespace ProjetoCigarro.Models
{
    public class Contexto : DbContext
    {

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
    }
}
