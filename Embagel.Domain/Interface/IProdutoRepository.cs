using Embagel.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Embagel.Business.Interface
{
    public interface IProdutoRepository
    {
        Produto Add (Produto produto);
    }
}
