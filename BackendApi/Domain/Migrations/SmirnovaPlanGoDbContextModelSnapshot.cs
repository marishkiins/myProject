﻿// <auto-generated />
using System;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Domain.Migrations
{
    [DbContext(typeof(SmirnovaPlanGoDbContext))]
    partial class SmirnovaPlanGoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Models.Notification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("NotificationTime")
                        .HasColumnType("datetime")
                        .HasColumnName("notificationTime");

                    b.Property<int>("StatusId")
                        .HasColumnType("int")
                        .HasColumnName("statusId");

                    b.Property<int>("TaskId")
                        .HasColumnType("int")
                        .HasColumnName("taskId");

                    b.HasKey("Id")
                        .HasName("PK__Notifica__3213E83F81665EB3");

                    b.HasIndex("StatusId");

                    b.HasIndex("TaskId");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("Domain.Models.NotificationStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("StatusName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("statusName");

                    b.HasKey("Id")
                        .HasName("PK__Notifica__3213E83FEA0FBF0E");

                    b.ToTable("NotificationStatuses");
                });

            modelBuilder.Entity("Domain.Models.Report", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("createdAt")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<DateOnly>("ReportPeriodEnd")
                        .HasColumnType("date")
                        .HasColumnName("reportPeriodEnd");

                    b.Property<DateOnly>("ReportPeriodStart")
                        .HasColumnType("date")
                        .HasColumnName("reportPeriodStart");

                    b.Property<int>("ReportTypeId")
                        .HasColumnType("int")
                        .HasColumnName("reportTypeId");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("userId");

                    b.HasKey("Id")
                        .HasName("PK__Reports__3213E83FAA8DF638");

                    b.HasIndex("ReportTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("Reports");
                });

            modelBuilder.Entity("Domain.Models.ReportType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ReportTypeName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("reportTypeName");

                    b.HasKey("Id")
                        .HasName("PK__ReportTy__3213E83F6EF6437C");

                    b.ToTable("ReportTypes");
                });

            modelBuilder.Entity("Domain.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("roleName");

                    b.HasKey("Id")
                        .HasName("PK__Roles__3213E83F96F0A11D");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Domain.Models.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("subjectName");

                    b.HasKey("Id")
                        .HasName("PK__Subjects__3213E83FA85B43B7");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("Domain.Models.SubjectInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Classroom")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("classroom");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int")
                        .HasColumnName("subjectId");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int")
                        .HasColumnName("teacherId");

                    b.HasKey("Id")
                        .HasName("PK__SubjectI__3213E83F402CB8F9");

                    b.HasIndex("SubjectId");

                    b.HasIndex("TeacherId");

                    b.ToTable("SubjectInfo", (string)null);
                });

            modelBuilder.Entity("Domain.Models.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("categoryId");

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("createdAt")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<DateTime>("Deadline")
                        .HasColumnType("datetime")
                        .HasColumnName("deadline");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<int>("PriorityId")
                        .HasColumnType("int")
                        .HasColumnName("priorityId");

                    b.Property<int>("StatusId")
                        .HasColumnType("int")
                        .HasColumnName("statusId");

                    b.Property<int>("TypeId")
                        .HasColumnType("int")
                        .HasColumnName("typeId");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("updatedAt");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("userId");

                    b.HasKey("Id")
                        .HasName("PK__Tasks__3213E83F3283DBB6");

                    b.HasIndex("CategoryId");

                    b.HasIndex("PriorityId");

                    b.HasIndex("StatusId");

                    b.HasIndex("TypeId");

                    b.HasIndex("UserId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("Domain.Models.TaskAttachment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("createdAt")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("filePath");

                    b.Property<int>("TaskId")
                        .HasColumnType("int")
                        .HasColumnName("taskId");

                    b.HasKey("Id")
                        .HasName("PK__TaskAtta__3213E83F70439DD9");

                    b.HasIndex("TaskId");

                    b.ToTable("TaskAttachments");
                });

            modelBuilder.Entity("Domain.Models.TaskCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("categoryName");

                    b.HasKey("Id")
                        .HasName("PK__TaskCate__3213E83F1DA79648");

                    b.ToTable("TaskCategories");
                });

            modelBuilder.Entity("Domain.Models.TaskComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("comment");

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("createdAt")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int>("TaskId")
                        .HasColumnType("int")
                        .HasColumnName("taskId");

                    b.HasKey("Id")
                        .HasName("PK__TaskComm__3213E83FBC7AB98E");

                    b.HasIndex("TaskId");

                    b.ToTable("TaskComments");
                });

            modelBuilder.Entity("Domain.Models.TaskDescription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<int>("TaskId")
                        .HasColumnType("int")
                        .HasColumnName("taskId");

                    b.HasKey("Id")
                        .HasName("PK__TaskDesc__3213E83F1A6BFEF5");

                    b.HasIndex("TaskId");

                    b.ToTable("TaskDescriptions");
                });

            modelBuilder.Entity("Domain.Models.TaskPriority", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("PriorityName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("priorityName");

                    b.HasKey("Id")
                        .HasName("PK__TaskPrio__3213E83FB093C4AF");

                    b.ToTable("TaskPriorities");
                });

            modelBuilder.Entity("Domain.Models.TaskStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("StatusName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("statusName");

                    b.HasKey("Id")
                        .HasName("PK__TaskStat__3213E83FA02D9194");

                    b.ToTable("TaskStatuses");
                });

            modelBuilder.Entity("Domain.Models.TaskStatusHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("ChangedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("changedAt")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int>("NewStatusId")
                        .HasColumnType("int")
                        .HasColumnName("newStatusId");

                    b.Property<int>("OldStatusId")
                        .HasColumnType("int")
                        .HasColumnName("oldStatusId");

                    b.Property<int>("TaskId")
                        .HasColumnType("int")
                        .HasColumnName("taskId");

                    b.HasKey("Id")
                        .HasName("PK__TaskStat__3213E83F871CFE96");

                    b.HasIndex("NewStatusId");

                    b.HasIndex("OldStatusId");

                    b.HasIndex("TaskId");

                    b.ToTable("TaskStatusHistory", (string)null);
                });

            modelBuilder.Entity("Domain.Models.TaskType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("typeName");

                    b.HasKey("Id")
                        .HasName("PK__TaskType__3213E83F54278A26");

                    b.ToTable("TaskTypes");
                });

            modelBuilder.Entity("Domain.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("firstName");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("lastName");

                    b.HasKey("Id")
                        .HasName("PK__Teachers__3213E83FE762DBC4");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("Domain.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("createdAt")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("email");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("password");

                    b.HasKey("Id")
                        .HasName("PK__Users__3213E83F813C9834");

                    b.HasIndex(new[] { "Email" }, "UQ__Users__AB6E6164E5B8A0A6")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Domain.Models.UserInfo", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date")
                        .HasColumnName("dateOfBirth");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("firstName");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("lastName");

                    b.Property<string>("MiddleName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("middleName");

                    b.Property<string>("PlaceOfStudy")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("placeOfStudy");

                    b.HasKey("Id")
                        .HasName("PK__UserInfo__3213E83F5305A951");

                    b.ToTable("UserInfo", (string)null);
                });

            modelBuilder.Entity("UserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("userId");

                    b.Property<int>("RoleId")
                        .HasColumnType("int")
                        .HasColumnName("roleId");

                    b.HasKey("UserId", "RoleId")
                        .HasName("PK__UserRole__7743989D01ADD09E");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles", (string)null);
                });

            modelBuilder.Entity("Domain.Models.Notification", b =>
                {
                    b.HasOne("Domain.Models.NotificationStatus", "Status")
                        .WithMany("Notifications")
                        .HasForeignKey("StatusId")
                        .IsRequired()
                        .HasConstraintName("FK__Notificat__statu__4D94879B");

                    b.HasOne("Domain.Models.Task", "Task")
                        .WithMany("Notifications")
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__Notificat__taskI__4CA06362");

                    b.Navigation("Status");

                    b.Navigation("Task");
                });

            modelBuilder.Entity("Domain.Models.Report", b =>
                {
                    b.HasOne("Domain.Models.ReportType", "ReportType")
                        .WithMany("Reports")
                        .HasForeignKey("ReportTypeId")
                        .IsRequired()
                        .HasConstraintName("FK__Reports__reportT__5441852A");

                    b.HasOne("Domain.Models.User", "User")
                        .WithMany("Reports")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__Reports__userId__534D60F1");

                    b.Navigation("ReportType");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Models.SubjectInfo", b =>
                {
                    b.HasOne("Domain.Models.Subject", "Subject")
                        .WithMany("SubjectInfos")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__SubjectIn__subje__60A75C0F");

                    b.HasOne("Domain.Models.Teacher", "Teacher")
                        .WithMany("SubjectInfos")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__SubjectIn__teach__619B8048");

                    b.Navigation("Subject");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Domain.Models.Task", b =>
                {
                    b.HasOne("Domain.Models.TaskCategory", "Category")
                        .WithMany("Tasks")
                        .HasForeignKey("CategoryId")
                        .IsRequired()
                        .HasConstraintName("FK__Tasks__categoryI__37A5467C");

                    b.HasOne("Domain.Models.TaskPriority", "Priority")
                        .WithMany("Tasks")
                        .HasForeignKey("PriorityId")
                        .IsRequired()
                        .HasConstraintName("FK__Tasks__priorityI__35BCFE0A");

                    b.HasOne("Domain.Models.TaskStatus", "Status")
                        .WithMany("Tasks")
                        .HasForeignKey("StatusId")
                        .IsRequired()
                        .HasConstraintName("FK__Tasks__statusId__36B12243");

                    b.HasOne("Domain.Models.TaskType", "Type")
                        .WithMany("Tasks")
                        .HasForeignKey("TypeId")
                        .IsRequired()
                        .HasConstraintName("FK__Tasks__typeId__34C8D9D1");

                    b.HasOne("Domain.Models.User", "User")
                        .WithMany("Tasks")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__Tasks__userId__33D4B598");

                    b.Navigation("Category");

                    b.Navigation("Priority");

                    b.Navigation("Status");

                    b.Navigation("Type");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Models.TaskAttachment", b =>
                {
                    b.HasOne("Domain.Models.Task", "Task")
                        .WithMany("TaskAttachments")
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__TaskAttac__taskI__3E52440B");

                    b.Navigation("Task");
                });

            modelBuilder.Entity("Domain.Models.TaskComment", b =>
                {
                    b.HasOne("Domain.Models.Task", "Task")
                        .WithMany("TaskComments")
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__TaskComme__taskI__47DBAE45");

                    b.Navigation("Task");
                });

            modelBuilder.Entity("Domain.Models.TaskDescription", b =>
                {
                    b.HasOne("Domain.Models.Task", "Task")
                        .WithMany("TaskDescriptions")
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__TaskDescr__taskI__3A81B327");

                    b.Navigation("Task");
                });

            modelBuilder.Entity("Domain.Models.TaskStatusHistory", b =>
                {
                    b.HasOne("Domain.Models.TaskStatus", "NewStatus")
                        .WithMany("TaskStatusHistoryNewStatuses")
                        .HasForeignKey("NewStatusId")
                        .IsRequired()
                        .HasConstraintName("FK__TaskStatu__newSt__440B1D61");

                    b.HasOne("Domain.Models.TaskStatus", "OldStatus")
                        .WithMany("TaskStatusHistoryOldStatuses")
                        .HasForeignKey("OldStatusId")
                        .IsRequired()
                        .HasConstraintName("FK__TaskStatu__oldSt__4316F928");

                    b.HasOne("Domain.Models.Task", "Task")
                        .WithMany("TaskStatusHistories")
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__TaskStatu__taskI__4222D4EF");

                    b.Navigation("NewStatus");

                    b.Navigation("OldStatus");

                    b.Navigation("Task");
                });

            modelBuilder.Entity("Domain.Models.UserInfo", b =>
                {
                    b.HasOne("Domain.Models.User", "IdNavigation")
                        .WithOne("UserInfo")
                        .HasForeignKey("Domain.Models.UserInfo", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__UserInfo__id__286302EC");

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("UserRole", b =>
                {
                    b.HasOne("Domain.Models.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .IsRequired()
                        .HasConstraintName("FK__UserRoles__roleI__59FA5E80");

                    b.HasOne("Domain.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__UserRoles__userI__59063A47");
                });

            modelBuilder.Entity("Domain.Models.NotificationStatus", b =>
                {
                    b.Navigation("Notifications");
                });

            modelBuilder.Entity("Domain.Models.ReportType", b =>
                {
                    b.Navigation("Reports");
                });

            modelBuilder.Entity("Domain.Models.Subject", b =>
                {
                    b.Navigation("SubjectInfos");
                });

            modelBuilder.Entity("Domain.Models.Task", b =>
                {
                    b.Navigation("Notifications");

                    b.Navigation("TaskAttachments");

                    b.Navigation("TaskComments");

                    b.Navigation("TaskDescriptions");

                    b.Navigation("TaskStatusHistories");
                });

            modelBuilder.Entity("Domain.Models.TaskCategory", b =>
                {
                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("Domain.Models.TaskPriority", b =>
                {
                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("Domain.Models.TaskStatus", b =>
                {
                    b.Navigation("TaskStatusHistoryNewStatuses");

                    b.Navigation("TaskStatusHistoryOldStatuses");

                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("Domain.Models.TaskType", b =>
                {
                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("Domain.Models.Teacher", b =>
                {
                    b.Navigation("SubjectInfos");
                });

            modelBuilder.Entity("Domain.Models.User", b =>
                {
                    b.Navigation("Reports");

                    b.Navigation("Tasks");

                    b.Navigation("UserInfo");
                });
#pragma warning restore 612, 618
        }
    }
}
