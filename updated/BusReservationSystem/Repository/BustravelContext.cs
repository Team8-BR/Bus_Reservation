using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BusReservationSystem.Repository
{
    public partial class BustravelContext : DbContext
    {
        public BustravelContext()
        {
        }

        public BustravelContext(DbContextOptions<BustravelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BusDetails> BusDetails { get; set; }
        public virtual DbSet<BusFare> BusFare { get; set; }
        public virtual DbSet<BusSchedule> BusSchedule { get; set; }
        public virtual DbSet<BusType> BusType { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<Payments> Payments { get; set; }
        public virtual DbSet<RouteDetails> RouteDetails { get; set; }
        public virtual DbSet<TicketBooking> TicketBooking { get; set; }
        public virtual DbSet<TicketCancellation> TicketCancellation { get; set; }
        public virtual DbSet<TypeOfTicket> TypeOfTicket { get; set; }
        public virtual DbSet<UserType> UserType { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-5D4VGK2;Database=Bustravel;User id=sa;Password=Deshmukh");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BusDetails>(entity =>
            {
                entity.HasKey(e => e.BusId)
                    .HasName("PK__Bus_Deta__B0524D192ABDD14D");

                entity.ToTable("Bus_Details");

                entity.Property(e => e.BusId)
                    .HasColumnName("Bus_Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BusTypeId).HasColumnName("Bus_Type_Id");

                entity.Property(e => e.RegistrationNumber).HasColumnName("Registration_Number");

                entity.Property(e => e.TotalSeats).HasColumnName("Total_Seats");

                entity.HasOne(d => d.BusType)
                    .WithMany(p => p.BusDetails)
                    .HasForeignKey(d => d.BusTypeId)
                    .HasConstraintName("FK__Bus_Detai__Bus_T__3E52440B");
            });

            modelBuilder.Entity<BusFare>(entity =>
            {
                entity.HasKey(e => e.FareId)
                    .HasName("PK__Bus_Fare__495DB84F66705523");

                entity.ToTable("Bus_Fare");

                entity.Property(e => e.FareId)
                    .HasColumnName("Fare_Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BusTypeId).HasColumnName("Bus_Type_Id");

                entity.Property(e => e.FareAmount)
                    .HasColumnName("Fare_Amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RouteId).HasColumnName("Route_Id");

                entity.HasOne(d => d.BusType)
                    .WithMany(p => p.BusFare)
                    .HasForeignKey(d => d.BusTypeId)
                    .HasConstraintName("FK__Bus_Fare__Bus_Ty__440B1D61");

                entity.HasOne(d => d.Route)
                    .WithMany(p => p.BusFare)
                    .HasForeignKey(d => d.RouteId)
                    .HasConstraintName("FK__Bus_Fare__Route___4316F928");
            });

            modelBuilder.Entity<BusSchedule>(entity =>
            {
                entity.HasKey(e => e.ScheduleId)
                    .HasName("PK__Bus_Sche__8C4D3C5B5121E932");

                entity.ToTable("Bus_Schedule");

                entity.Property(e => e.ScheduleId)
                    .HasColumnName("Schedule_Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArrivalDate)
                    .HasColumnName("Arrival_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ArrivalTime).HasColumnName("Arrival_Time");

                entity.Property(e => e.AvailableSeats).HasColumnName("Available_Seats");

                entity.Property(e => e.BookedSeats).HasColumnName("Booked_Seats");

                entity.Property(e => e.BusId).HasColumnName("Bus_Id");

                entity.Property(e => e.DepartureDate)
                    .HasColumnName("Departure_Date")
                    .HasColumnType("date");

                entity.Property(e => e.DepartureTime).HasColumnName("Departure_Time");

                entity.Property(e => e.DriverName)
                    .HasColumnName("Driver_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FareId).HasColumnName("Fare_Id");

                entity.Property(e => e.RouteId).HasColumnName("Route_Id");

                entity.HasOne(d => d.Bus)
                    .WithMany(p => p.BusSchedule)
                    .HasForeignKey(d => d.BusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Bus_Sched__Bus_I__46E78A0C");

                entity.HasOne(d => d.Fare)
                    .WithMany(p => p.BusSchedule)
                    .HasForeignKey(d => d.FareId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Bus_Sched__Fare___48CFD27E");

                entity.HasOne(d => d.Route)
                    .WithMany(p => p.BusSchedule)
                    .HasForeignKey(d => d.RouteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Bus_Sched__Route__47DBAE45");
            });

            modelBuilder.Entity<BusType>(entity =>
            {
                entity.ToTable("Bus_Type");

                entity.Property(e => e.BusTypeId)
                    .HasColumnName("Bus_Type_Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BusType1)
                    .HasColumnName("Bus_Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.CustomerId)
                    .HasColumnName("Customer_Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNo)
                    .HasColumnName("Contact_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfBirth)
                    .HasColumnName("Date_Of_Birth")
                    .HasColumnType("date");

                entity.Property(e => e.EmailId)
                    .HasColumnName("Email_Id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasColumnName("First_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasColumnName("Last_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pincode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("User_Id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Customer__User_I__4E88ABD4");
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__Login__206D917094606AEB");

                entity.Property(e => e.UserId)
                    .HasColumnName("User_Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserTypeId).HasColumnName("User_Type_Id");

                entity.HasOne(d => d.UserType)
                    .WithMany(p => p.Login)
                    .HasForeignKey(d => d.UserTypeId)
                    .HasConstraintName("FK__Login__User_Type__4BAC3F29");
            });

            modelBuilder.Entity<Payments>(entity =>
            {
                entity.HasKey(e => e.PaymentId)
                    .HasName("PK__Payments__DA6C7FC1BE7AFC0B");

                entity.Property(e => e.PaymentId)
                    .HasColumnName("Payment_Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BankName)
                    .HasColumnName("Bank_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BookingId).HasColumnName("Booking_Id");

                entity.Property(e => e.CardHolderName)
                    .HasColumnName("Card_Holder_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardNo)
                    .HasColumnName("Card_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardType)
                    .HasColumnName("Card_Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAmount)
                    .HasColumnName("Total_Amount")
                    .HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Booking)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.BookingId)
                    .HasConstraintName("FK__Payments__Bookin__5812160E");
            });

            modelBuilder.Entity<RouteDetails>(entity =>
            {
                entity.HasKey(e => e.RouteId)
                    .HasName("PK__Route_De__6DC9D9115B4E79A7");

                entity.ToTable("Route_Details");

                entity.Property(e => e.RouteId)
                    .HasColumnName("Route_Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DepartureStation)
                    .HasColumnName("Departure_Station")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationStation)
                    .HasColumnName("Destination_Station")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TicketBooking>(entity =>
            {
                entity.HasKey(e => e.BookingId)
                    .HasName("PK__Ticket_B__35ABFDC0EF7B357D");

                entity.ToTable("Ticket_Booking");

                entity.Property(e => e.BookingId)
                    .HasColumnName("Booking_Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AvailableSeats).HasColumnName("Available_Seats");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_Id");

                entity.Property(e => e.DateOfBooking)
                    .HasColumnName("Date_Of_Booking")
                    .HasColumnType("date");

                entity.Property(e => e.Fare).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OnwardJourneyDate)
                    .HasColumnName("Onward_Journey_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ReturnDate)
                    .HasColumnName("Return_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ScheduleId).HasColumnName("Schedule_Id");

                entity.Property(e => e.TicketTypeId).HasColumnName("Ticket_Type_Id");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TicketBooking)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__Ticket_Bo__Custo__534D60F1");

                entity.HasOne(d => d.Schedule)
                    .WithMany(p => p.TicketBooking)
                    .HasForeignKey(d => d.ScheduleId)
                    .HasConstraintName("FK__Ticket_Bo__Sched__5535A963");

                entity.HasOne(d => d.TicketType)
                    .WithMany(p => p.TicketBooking)
                    .HasForeignKey(d => d.TicketTypeId)
                    .HasConstraintName("FK__Ticket_Bo__Ticke__5441852A");
            });

            modelBuilder.Entity<TicketCancellation>(entity =>
            {
                entity.HasKey(e => e.CancellationId)
                    .HasName("PK__Ticket_C__BC9DC290867F8B3D");

                entity.ToTable("Ticket_Cancellation");

                entity.Property(e => e.CancellationId)
                    .HasColumnName("Cancellation_Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BookingId).HasColumnName("Booking_Id");

                entity.Property(e => e.CancellationDate)
                    .HasColumnName("Cancellation_Date")
                    .HasColumnType("date");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_Id");

                entity.Property(e => e.RefundAmount)
                    .HasColumnName("Refund_Amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ScheduleId).HasColumnName("Schedule_Id");

                entity.Property(e => e.TicketTypeId).HasColumnName("Ticket_Type_Id");

                entity.HasOne(d => d.Booking)
                    .WithMany(p => p.TicketCancellation)
                    .HasForeignKey(d => d.BookingId)
                    .HasConstraintName("FK__Ticket_Ca__Booki__5BE2A6F2");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TicketCancellation)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__Ticket_Ca__Custo__5DCAEF64");

                entity.HasOne(d => d.Schedule)
                    .WithMany(p => p.TicketCancellation)
                    .HasForeignKey(d => d.ScheduleId)
                    .HasConstraintName("FK__Ticket_Ca__Sched__5EBF139D");

                entity.HasOne(d => d.TicketType)
                    .WithMany(p => p.TicketCancellation)
                    .HasForeignKey(d => d.TicketTypeId)
                    .HasConstraintName("FK__Ticket_Ca__Ticke__5CD6CB2B");
            });

            modelBuilder.Entity<TypeOfTicket>(entity =>
            {
                entity.HasKey(e => e.TicketTypeId)
                    .HasName("PK__Type_Of___B272714221014921");

                entity.ToTable("Type_Of_Ticket");

                entity.Property(e => e.TicketTypeId)
                    .HasColumnName("Ticket_Type_Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.TicketType)
                    .HasColumnName("Ticket_Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserType>(entity =>
            {
                entity.ToTable("User_Type");

                entity.Property(e => e.UserTypeId)
                    .HasColumnName("User_Type_Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.UserTypeName)
                    .HasColumnName("User_type_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
