using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Modeling.Validation;
using Microsoft.VisualStudio.Uml.Classes;

namespace PTS_HomePage
{
    // Custom validation constraint
    // See http://msdn.microsoft.com/en-us/library/ee329482(v=vs.120).aspx
    public class ModelValidationExtension1
    {
        [Export(typeof(System.Action<ValidationContext, object>))]
        [ValidationMethod(ValidationCategories.Save | ValidationCategories.Menu | ValidationCategories.Open)]
        public void ValidateSomething(ValidationContext context, IClassifier elementToValidate)
        {
            // The second parameter to this method controls the types of model elements you want to have
            // passed to the validator. If you make it more precise (e.g. IClass) you will see fewer elements.
            // If you make it less precise (e.g. IClassifier) you will see more.
        }
    }
}
