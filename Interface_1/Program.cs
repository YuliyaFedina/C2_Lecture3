using System;
using Interface_1.Data;
using Interface_1.Model;

namespace Interface_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User { Id = 1, Name = "Name" };

            var phone = new Phone { Id = 1, PhoneCode = "123", Value = "123124" };

            var userRepository = GetRepository<User>();
            userRepository.Add(user);

            var contactRepository = GetRepository<Contact>();
            contactRepository.Add(phone);

            var result = GetData(userRepository);

            foreach (var item in result)
            {
                Console.WriteLine(item.Name);
            }
            Console.ReadLine();
        }

        private static IRepository<TEntity> GetRepository<TEntity>() where TEntity : IEntity
        {
            return new EntityRepository<TEntity>();
        }

        private static TEntity[] GetData<TEntity>(IReadOnlyRepository<TEntity> repository) where TEntity : IEntity
        {
            var data = repository.GetAll();

            //TODO: do smth

            return data;
        }

    }
}
