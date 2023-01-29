using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Store
    {
        private Article[] articles;

        public Store(Article[] articles)
        {
            this.articles = articles;
        }

        public Article this[int index]
        {
            get { return this.articles[index]; }
        }

        public Article this[string name]
        {
            get
            {
                for (int i = 0; i < this.articles.Length; i++)
                    if (name.ToLower() == this.articles[i].ItemName)
                        return this.articles[i];
                throw new Exception("Unknown name");
            }
        }       
    }
}
