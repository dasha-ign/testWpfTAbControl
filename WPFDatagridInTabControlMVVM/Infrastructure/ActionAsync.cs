﻿using System.Threading.Tasks;

namespace WPFDatagridInTabControlMVVM.Infrastructure
{
    internal delegate Task ActionAsync();

    internal delegate Task ActionAsync<in T>(T parameter);
}
