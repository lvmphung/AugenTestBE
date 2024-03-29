﻿using Ninject;
using System;
using System.Collections.Generic;
using System.Web.Http.Dependencies;

namespace AugenProject.Web.Common.DependencyResolvers
{
    public sealed class NinjectDependencyResolver : IDependencyResolver
    {
        private readonly IKernel _container;

        public NinjectDependencyResolver(IKernel container)
        {
            _container = container;
        }

        public IKernel Container
        {
            get { return _container; }
        }

        public object GetService(Type serviceType)
        {
            return _container.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _container.GetAll(serviceType);
        }

        public IDependencyScope BeginScope()
        {
            //return this;
            return new NinjectDependencyScope(_container.BeginBlock());
        }

        public void Dispose()
        {
            //GC.SuppressFinalize(this);
            _container.Dispose();
        }
    }
}