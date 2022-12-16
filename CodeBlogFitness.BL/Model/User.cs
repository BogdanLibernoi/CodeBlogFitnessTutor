using System;
using System.Collections.Generic;
using System.Text;

namespace CodeBlogFitness.BL.Model
{
    class User
    {
        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Пол пользователя
        /// </summary>
        public Gender Gender { get; }
        /// <summary>
        /// Дата рождения пользователя
        /// </summary>
        public DateTime BirthDate { get; }
        /// <summary>
        /// Вес пользователя 
        /// </summary>
        public double Weight { get; set; }
        /// <summary>
        /// Рост пользователя
        /// </summary>
        public double Height { get; set; }

        /// <summary>
        /// Создать нового пользователя
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="gender">Пол</param>
        /// <param name="birthDate">Дата рождения</param>
        /// <param name="height">Рост</param>
        /// <param name="weight">Вес</param>
        public User(string name, 
                    Gender gender, 
                    DateTime birthDate, 
                    double height, 
                    double weight)
        {
            #region check
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Name of user can't be empty or null", nameof(name));
            }
            if (gender == null)
            {
                throw new ArgumentNullException("Gender can't be null", nameof(gender));
            }
            if(birthDate < DateTime.Parse("01.01.1900") || birthDate >= DateTime.Now)
            {
                throw new ArgumentException("BirthDate can't be like this", nameof(birthDate));
            }
            if(weight<= 0)
            {
                throw new ArgumentException("Weight can't be zero or less", nameof(weight));
            }
            if(height <= 0)
            {
                throw new ArgumentException("Height can't be zero or less", nameof(height));
            }
            #endregion
            Name = name;
            Gender = gender;
            BirthDate = birthDate;
            Height = height;
            Weight = weight;
        }
        public override string ToString()
        {
            return Name;
        }

    }
}
