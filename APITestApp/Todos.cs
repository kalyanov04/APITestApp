﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITestApp
{
    public class Todos
    {
        string userId;
        int id;
        string title;
        string completed;

        public string UserId { get => userId; set => userId = value; }
        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Completed { get => completed; set => completed = value; }

        public Todos SetUserId(string userId)
        {
            UserId = userId;
            return this;
        }
        public Todos SetId(int id)
        {
            Id = id;
            return this;
        }
        public Todos SetTitle(string title)
        {
            Title = title;
            return this;
        }
        public Todos SetComplete(string completed)
        {
            Completed = completed;
            return this;
        }

    }
}
