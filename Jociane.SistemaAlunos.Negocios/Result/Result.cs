using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Jociane.SistemaAlunos.Negocios.Result
{
    public class Result<T>
    {
        public List<T> Data { get; set; } = new List<T>();
        public bool Error { get; set; }
        public List<string> Message { get; set; } = new List<string>();
        public HttpStatusCode Status { get; set; }

    }
}
