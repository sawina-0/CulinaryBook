//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CulinaryBook.AppFrame
{
    using System;
    using System.Collections.Generic;
    
    public partial class CookingSteps
    {
        public int StepID { get; set; }
        public Nullable<int> RecipeID { get; set; }
        public Nullable<int> StepNumber { get; set; }
        public string StepDescription { get; set; }
    
        public virtual Recipes Recipes { get; set; }
    }
}
