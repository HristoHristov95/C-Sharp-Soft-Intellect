using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2
{
    class SentenceNotCompleted : System.Exception
    {
        public SentenceNotCompleted() : base() { }

        public SentenceNotCompleted(String massage) : base(massage) { }
        public SentenceNotCompleted(String message, System.Exception inner) : base(message, inner) { }
        protected SentenceNotCompleted(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
}
