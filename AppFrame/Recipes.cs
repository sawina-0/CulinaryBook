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
    using System.Linq;
    using System.Windows.Controls;

    public partial class Recipes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Recipes()
        {
            this.CookingSteps = new HashSet<CookingSteps>();
            this.RecipeImages = new HashSet<RecipeImages>();
            this.RecipeIngredients = new HashSet<RecipeIngredients>();
            this.RecipeTags = new HashSet<RecipeTags>();
            this.Reviews = new HashSet<Reviews>();
        }
    
        public int RecipeID { get; set; }
        public string RecipeName { get; set; }
        public string Description { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public Nullable<int> AuthorID { get; set; }
        public Nullable<int> CookingTime { get; set; }
        
        public string CurrentPhoto
        {
            get
            {
                var image = RecipeImages.FirstOrDefault(x => x.RecipeID == RecipeID);
                return image.CurrentPhoto;
            }
        }

        public virtual Authors Authors { get; set; }
        public virtual Categories Categories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CookingSteps> CookingSteps { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RecipeImages> RecipeImages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RecipeIngredients> RecipeIngredients { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RecipeTags> RecipeTags { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reviews> Reviews { get; set; }
    }
}
