﻿using System.ComponentModel;

namespace SistemaTarefas.Enums
{
    public enum StatusTarefa : int 
    {
        [Description("A fazer")]
        AFazer = 1,
        [Description("Em andamento")]
        EmAndamento = 2,
        [Description("Concluido")]
        Concluido = 3
    }
}
