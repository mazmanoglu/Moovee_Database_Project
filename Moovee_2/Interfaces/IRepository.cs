using System.Collections.Generic;

namespace Moovee_2.Interfaces
{
	public interface IRepository<T>
	{
		void Create(T item);
		void Delete(T item);
		void Update(T item);
		T GetById(int id);
		IEnumerable<T> GetList();
	}
}
