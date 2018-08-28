﻿using System.Collections.Generic;
using System.Web.Http;
using WebAPIWithCastleWindsor4.Api.Services;

namespace WebAPIWithCastleWindsor4.Api.Controllers
{
  public class ValuesController : ApiController
  {
    #region Data

    private readonly IValueProvider _valueProvider;

    #endregion

    #region Constructors

    public ValuesController(IValueProvider valueProvider)
    {
      _valueProvider = valueProvider;
    }

    #endregion

    #region Apis

    public IEnumerable<string> Get()
    {
      return new [] {
        _valueProvider.Get(), 
        _valueProvider.Get()
      };
    }

    #endregion
  }
}