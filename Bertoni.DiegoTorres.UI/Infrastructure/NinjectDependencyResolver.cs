using Bertoni.DiegoTorres.Service.Abstract;
using Bertoni.DiegoTorres.Service.Concrete.RestApi;
using Ninject;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Bertoni.DiegoTorres.UI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel _kernel;

        public NinjectDependencyResolver(IKernel kernel)
        {
            _kernel = kernel;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return _kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            _kernel.Bind<IAlbumService>().To<AlbumService>();
            _kernel.Bind<ICommentService>().To<CommentService>();
            _kernel.Bind<IPhotoService>().To<PhotoService>();
        }
    }
}