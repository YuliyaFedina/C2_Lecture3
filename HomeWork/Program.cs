using System;
using HomeWork.Data;
using HomeWork.Infrastructure;
using HomeWork.Model;
using HomeWork.Model.Contact2;
using HomeWork.Validation;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User { Id = 1, Name = "Name" };

            var phone = new PhoneContact {Id = 1, PhoneCode = "123", Value = "123124" };
            var email = new EmailContact {Id = 2, Value = "mail@2gis.ru" };

            var emailContactValidator = new EmailContactValidator();
            var phoneContactValidator = new PhoneContactValidator();

            var userRepository = GetRepository<User>();
            userRepository.Add(user);

            var contactRepository = GetRepository<ContactBase>();

            if (emailContactValidator.IsValid(email))
                contactRepository.Add(phone);

            if (phoneContactValidator.IsValid(phone))
                contactRepository.Add(email);

            Console.WriteLine(contactRepository.GetById(1));

            Console.WriteLine(contactRepository.GetById(2));
            Console.ReadLine();
        }

        private static IRepository<TEntity> GetRepository<TEntity>() where TEntity : class, IEntity
        {
            return new EntityRepository<TEntity>(new ExceptionHandler());
        }
    }
}
