using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTools.ADO.Repositories
{
    public interface IBaseRepository<T>
    {
        /// <summary>
        /// this method add a <typeparamref name="T"/>
        /// </summary>
        /// <param name="entity">Represents the <typeparamref name="T"/> will be added</param>
        void Add(T entity);

        /// <summary>
        /// this method update a <typeparamref name="T"/>
        /// </summary>
        /// <param name="entity">Represents the <typeparamref name="T"/> will be updated</param>
        void Update(T entity);

        /// <summary>
        /// this method delete a <typeparamref name="T"/>
        /// </summary>
        /// <param name="id">Represents the id of <typeparamref name="T"/> will be deleted</param>
        void Delete(int  id);

        /// <summary>
        /// this method get one <typeparamref name="T"/>
        /// </summary>
        /// <param name="id"></param>
        /// <returns>represents the id of <typeparamref name="T"/> </returns>
        T Get(int id);

        /// <summary>
        /// this method get all <typeparamref name="T"/>
        /// </summary>
        /// <returns>represents the list of <typeparamref name="T"/> </returns>
        ICollection<T> GetAll();

    }
}
