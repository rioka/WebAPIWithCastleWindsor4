﻿using Microsoft.Owin;
using Owin;
using WebAPIWithCastleWindsor4.Api;

[assembly: OwinStartup(typeof(Startup))]
namespace WebAPIWithCastleWindsor4.Api
{
  public partial class Startup
  {
    #region Apis

    /// <summary>
    /// Owin configuration module
    /// </summary>
    /// <param name="app">Application builder</param>
    public void Configuration(IAppBuilder app) {}

    #endregion
  }
}