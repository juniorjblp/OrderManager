using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Data
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome do produto é obrigatório.")]
        [StringLength(50, ErrorMessage = "Nome do produto deve ter no máximo 50 caracteres.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Categoria do produto é obrigatório.")]
        public int Category_id { get; set; }

        public string Category { get; set; }

        [Required(ErrorMessage = "Quantidade de produtos é obrigatório.")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Quantidade aceita valores numéricos.")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Preço do produto é obrigatório.")]
        public string Value { get; set; }

        public string FormatedValue
        {
            get
            {
                return Convert.ToDecimal(Value).ToString(@"R$ 00\,00", CultureInfo.CurrentCulture);
            }
        }

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
            return true;
        }

        public List<Product> products { get; set; }
    }
}
