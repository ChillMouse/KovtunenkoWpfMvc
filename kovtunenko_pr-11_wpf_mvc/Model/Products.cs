//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KovtunenkoWpfMvc.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Products
    {
        public long id { get; set; }
        public string title { get; set; }
        public Nullable<int> count { get; set; }
    
        public virtual FavoritesCompositions FavoritesCompositions { get; set; }
    }
}
