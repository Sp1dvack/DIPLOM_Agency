//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Agency
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AgencyEntities1 : DbContext
    {
        private static AgencyEntities1 _context;
        public AgencyEntities1()
            : base("name=AgencyEntities1")
        {
        }
        public static AgencyEntities1 GetContext()//ДОПИСАТЬ
        {
            if (_context == null)
                _context = new AgencyEntities1();
            return _context;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Images> Images { get; set; }
        public virtual DbSet<Object> Object { get; set; }
        public virtual DbSet<ObjectType> ObjectType { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}
