using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class Game : IEntity
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public int Price { get; set; }
    }
}
