using Bertoni.DiegoTorres.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bertoni.DiegoTorres.Service
{
    public interface IAlbumService
    {
        Task<IEnumerable<Album>> GetAll();
    }
}
