using System;
using Common;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Collections.Generic;
using System.Globalization;

namespace Data
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome do Cliente é obrigatório.")]
        [StringLength(50, ErrorMessage = "Nome do Cliente deve ter no máximo 50 caracteres.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Sobrenome do Cliente é obrigatório.")]
        [StringLength(50, ErrorMessage = "Sobrenome do Cliente deve ter no máximo 50 caracteres.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "CPF obrigatório.")]
        [RegularExpression("([0-9]+)", ErrorMessage = "CPF somente aceita valores numéricos.")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "CPF deve ter 11 dígitos.")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Data de nascimento é obrigatório.")]
        [RegularExpression(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$", ErrorMessage = "Digite uma data de nascimento válida.")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "dd/mm/yyyy", ApplyFormatInEditMode = true)]
        public string BirthDate { get; set; }

        [Required(ErrorMessage = "Email é obrigatório")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "O Email deve ter no mínimo 5 e no máximo 100 caracteres.")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido...")]
        [DataType(DataType.EmailAddress), DisplayFormat(DataFormatString = ".+\\@.+\\..+", ApplyFormatInEditMode = true)]
        public string Email { get; set; }

        public int Age
        {
            get
            {
                DateTime DateAge = DateTime.ParseExact(BirthDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                var actualDate = DateTime.Now;
                var age = actualDate.Year - DateAge.Year;

                if (actualDate.Month < DateAge.Month)
                    age--;

                return age;
            }
        }

        public string DateHourRegister
        {
            get
            {
                var dateHourResgiste = DateTime.Now.ToString();
                return dateHourResgiste;
            }
        }
        public string FullName => $"{FirstName} {LastName}";


        public string FormatedCpf
        { 
            get
            {
                var FormatedCpf =
                Convert.ToUInt64(Cpf.Replace(",", "").Replace(".", "").Replace("-", "")).ToString(@"000\.000\.000\-00");

                return FormatedCpf;
            }
            set
            {
                Cpf = Cpf;
            }
        }


        //Class Validation
        public bool ValidateClasse()
        {
            ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null);
            List<ValidationResult> results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(this, context, results, true);

            if (isValid == false)
            {
                StringBuilder sbrErrors = new StringBuilder();
                foreach (var validationResult in results)
                {
                    sbrErrors.AppendLine(validationResult.ErrorMessage);
                }
                throw new ValidationException(sbrErrors.ToString());
            }
            ValidateEmailCpfBirthDate();
            return true;
        }

        //validate Email, Cpf and BirthDate
        public bool ValidateEmailCpfBirthDate()
        {
            DateTime birthDate = DateTime.ParseExact(BirthDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            //var birthDate = Convert.ToDateTime(BirthDate);
            var cpf = (Cpf)Cpf;
            var email = (Email)Email;

            while (!cpf.IsValid)
            {
                throw new ValidationException("Digite um CPF válido");
            }
            while (!email.IsValid)
            {
                throw new ValidationException("Digite um email válido");
            }
            while (birthDate == DateTime.MinValue || String.IsNullOrEmpty(BirthDate))
            {
                throw new ValidationException("Digite uma data de nascimento válida");
            }
            return true;
        }
    }
    public class ListOfCustomer
    {
        public List<Customer> customers { get; set; }
        public ListOfCustomer()
        {

        }
    }
}
