using System;
using System.Collections.Generic;
using DashBoard1.Models;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Data;

public partial class TarifplusPilotsContext : DbContext
{
    public TarifplusPilotsContext()
    {
    }

    public TarifplusPilotsContext(DbContextOptions<TarifplusPilotsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AdditionalOnCallPrestationRegistry> AdditionalOnCallPrestationRegistries { get; set; }

    public virtual DbSet<AssurmedAttest> AssurmedAttests { get; set; }

    public virtual DbSet<Attest> Attests { get; set; }

    public virtual DbSet<AttestLineItem> AttestLineItems { get; set; }

    public virtual DbSet<AttestPrintLayout> AttestPrintLayouts { get; set; }

    public virtual DbSet<AttestPrintLayoutItemPosition> AttestPrintLayoutItemPositions { get; set; }

    public virtual DbSet<AttestSummary> AttestSummaries { get; set; }

    public virtual DbSet<AttestedSession> AttestedSessions { get; set; }

    public virtual DbSet<AttestsAtTheExpenseOfPrivateInsuranceOrganismThatAreNotInvoiced> AttestsAtTheExpenseOfPrivateInsuranceOrganismThatAreNotInvoiceds { get; set; }

    public virtual DbSet<AttestsAtTheExpenseOfPublicInsuranceOrganismWithPatientContributionForOtherThatAreNotInvoiced> AttestsAtTheExpenseOfPublicInsuranceOrganismWithPatientContributionForOtherThatAreNotInvoiceds { get; set; }

    public virtual DbSet<AttestsAtTheExpenseOfPublicInsuranceOrganismWithReimbursementNotPaidThatAreNotInvoiced> AttestsAtTheExpenseOfPublicInsuranceOrganismWithReimbursementNotPaidThatAreNotInvoiceds { get; set; }

    public virtual DbSet<AttestsWithPatientContributionAtTheExpenseOfPatientThatAreNotInvoiced> AttestsWithPatientContributionAtTheExpenseOfPatientThatAreNotInvoiceds { get; set; }

    public virtual DbSet<BackgroundTask> BackgroundTasks { get; set; }

    public virtual DbSet<BackgroundTaskResult> BackgroundTaskResults { get; set; }

    public virtual DbSet<Beneficiary> Beneficiaries { get; set; }

    public virtual DbSet<Chapter> Chapters { get; set; }

    public virtual DbSet<ChapterName> ChapterNames { get; set; }

    public virtual DbSet<Correction> Corrections { get; set; }

    public virtual DbSet<DefaultMemoCodesForPatientCarePlan> DefaultMemoCodesForPatientCarePlans { get; set; }

    public virtual DbSet<DiadatNomenclatureCodeMap> DiadatNomenclatureCodeMaps { get; set; }

    public virtual DbSet<EfactRejectionReason> EfactRejectionReasons { get; set; }

    public virtual DbSet<EforfaitAgreement> EforfaitAgreements { get; set; }

    public virtual DbSet<ElectronicAttestResponse> ElectronicAttestResponses { get; set; }

    public virtual DbSet<ElectronicInvoice> ElectronicInvoices { get; set; }

    public virtual DbSet<ElectronicInvoiceDispatchNumberCounter> ElectronicInvoiceDispatchNumberCounters { get; set; }

    public virtual DbSet<ElectronicInvoiceResponse> ElectronicInvoiceResponses { get; set; }

    public virtual DbSet<ExternalApplication> ExternalApplications { get; set; }

    public virtual DbSet<ExternalApplicationSetting> ExternalApplicationSettings { get; set; }

    public virtual DbSet<FileJob> FileJobs { get; set; }

    public virtual DbSet<FileJobItem> FileJobItems { get; set; }

    public virtual DbSet<FileJobItemFile> FileJobItemFiles { get; set; }

    public virtual DbSet<ForfaitInvoice> ForfaitInvoices { get; set; }

    public virtual DbSet<ForfaitInvoiceDetail> ForfaitInvoiceDetails { get; set; }

    public virtual DbSet<ForfaitInvoiceElectronicMessage> ForfaitInvoiceElectronicMessages { get; set; }

    public virtual DbSet<ForfaitInvoicePatientInvoicedService> ForfaitInvoicePatientInvoicedServices { get; set; }

    public virtual DbSet<ForfaitInvoiceReInvoiceablePeriod> ForfaitInvoiceReInvoiceablePeriods { get; set; }

    public virtual DbSet<ForfaitMedicalCareServiceFee> ForfaitMedicalCareServiceFees { get; set; }

    public virtual DbSet<ForfaitPatientHistory> ForfaitPatientHistories { get; set; }

    public virtual DbSet<ForfaitPendingInvoicingItem> ForfaitPendingInvoicingItems { get; set; }

    public virtual DbSet<InsuranceInfo> InsuranceInfos { get; set; }

    public virtual DbSet<Invoice> Invoices { get; set; }

    public virtual DbSet<InvoiceLine> InvoiceLines { get; set; }

    public virtual DbSet<InvoiceSetting> InvoiceSettings { get; set; }

    public virtual DbSet<InvoiceTemplate> InvoiceTemplates { get; set; }

    public virtual DbSet<Language> Languages { get; set; }

    public virtual DbSet<LatestEfactReferenceNumberForAttest> LatestEfactReferenceNumberForAttests { get; set; }

    public virtual DbSet<MailerQueue> MailerQueues { get; set; }

    public virtual DbSet<MailerQueueAttachment> MailerQueueAttachments { get; set; }

    public virtual DbSet<MedicalCareServiceRelation> MedicalCareServiceRelations { get; set; }

    public virtual DbSet<MedicalHouseBankAccountInfo> MedicalHouseBankAccountInfos { get; set; }

    public virtual DbSet<MedicalHouseSetting> MedicalHouseSettings { get; set; }

    public virtual DbSet<MemberDataHistory> MemberDataHistories { get; set; }

    public virtual DbSet<MemberDataRequest> MemberDataRequests { get; set; }

    public virtual DbSet<MemoCode> MemoCodes { get; set; }

    public virtual DbSet<MemoCodeMedicalCareService> MemoCodeMedicalCareServices { get; set; }

    public virtual DbSet<OfficialOverriddenMedicalCareServiceFee> OfficialOverriddenMedicalCareServiceFees { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OverriddenOfficialFeesForConventionedCareProvider> OverriddenOfficialFeesForConventionedCareProviders { get; set; }

    public virtual DbSet<Patient> Patients { get; set; }

    public virtual DbSet<PatientCarePlan> PatientCarePlans { get; set; }

    public virtual DbSet<PatientCarePlanAgreement> PatientCarePlanAgreements { get; set; }

    public virtual DbSet<PatientCarePlanAgreementProperty> PatientCarePlanAgreementProperties { get; set; }

    public virtual DbSet<PatientCarePlanExternalVisit> PatientCarePlanExternalVisits { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<PaymentInvitation> PaymentInvitations { get; set; }

    public virtual DbSet<PaymentInvitationPayable> PaymentInvitationPayables { get; set; }

    public virtual DbSet<Physician> Physicians { get; set; }

    public virtual DbSet<PhysicianSettingsOb> PhysicianSettingsObs { get; set; }

    public virtual DbSet<Prestation> Prestations { get; set; }

    public virtual DbSet<PrestationCoefficientValue> PrestationCoefficientValues { get; set; }

    public virtual DbSet<PrestationGroup> PrestationGroups { get; set; }

    public virtual DbSet<PrestationGroupItem> PrestationGroupItems { get; set; }

    public virtual DbSet<PrestationName> PrestationNames { get; set; }

    public virtual DbSet<PrestationPrice> PrestationPrices { get; set; }

    public virtual DbSet<PrestationRelationCodeType> PrestationRelationCodeTypes { get; set; }

    public virtual DbSet<PrestationType> PrestationTypes { get; set; }

    public virtual DbSet<PriceType> PriceTypes { get; set; }

    public virtual DbSet<PriceTypeDescription> PriceTypeDescriptions { get; set; }

    public virtual DbSet<PriceTypeRelation> PriceTypeRelations { get; set; }

    public virtual DbSet<PriceTypeRelationCodeType> PriceTypeRelationCodeTypes { get; set; }

    public virtual DbSet<PrinterSetting> PrinterSettings { get; set; }

    public virtual DbSet<Projection> Projections { get; set; }

    public virtual DbSet<RelativePrestationCode> RelativePrestationCodes { get; set; }

    public virtual DbSet<Reminder> Reminders { get; set; }

    public virtual DbSet<ReminderTemplate> ReminderTemplates { get; set; }

    public virtual DbSet<RetrocessionSetting> RetrocessionSettings { get; set; }

    public virtual DbSet<SchemaInfo> SchemaInfos { get; set; }

    public virtual DbSet<SchemaVersion> SchemaVersions { get; set; }

    public virtual DbSet<Site> Sites { get; set; }

    public virtual DbSet<TariffedService> TariffedServices { get; set; }

    public virtual DbSet<TarificationProfile> TarificationProfiles { get; set; }

    public virtual DbSet<TarificationSession> TarificationSessions { get; set; }

    public virtual DbSet<TarificationSessionContext> TarificationSessionContexts { get; set; }

    public virtual DbSet<TarifiedItem> TarifiedItems { get; set; }

    public virtual DbSet<TarifiedPrestationGroupItem> TarifiedPrestationGroupItems { get; set; }

    public virtual DbSet<TarifiedPrestationGroupPrestationLine> TarifiedPrestationGroupPrestationLines { get; set; }

    public virtual DbSet<TarifiedPrestationItem> TarifiedPrestationItems { get; set; }

    public virtual DbSet<TarifiedPrestationRegistrationMode> TarifiedPrestationRegistrationModes { get; set; }

    public virtual DbSet<ThirdParty> ThirdParties { get; set; }

    public virtual DbSet<UpdateLog> UpdateLogs { get; set; }

    public virtual DbSet<UpdateLogLine> UpdateLogLines { get; set; }

    public virtual DbSet<UsageType> UsageTypes { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserPrintOption> UserPrintOptions { get; set; }

    public virtual DbSet<UserSetting> UserSettings { get; set; }

    public virtual DbSet<VwGlobalSessionInfoForAttest> VwGlobalSessionInfoForAttests { get; set; }

    public virtual DbSet<WorkAccident> WorkAccidents { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-02E5OBB\\MSSQLSERVER01;Initial Catalog=Tarifplus_Pilots;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Latin1_General_CI_AS");

        modelBuilder.Entity<AdditionalOnCallPrestationRegistry>(entity =>
        {
            entity.HasOne(d => d.AdditionalEveningPrestation).WithMany(p => p.AdditionalOnCallPrestationRegistryAdditionalEveningPrestations).HasConstraintName("FK_AdditionalOnCallPrestationRegistry_EveningPrestation");

            entity.HasOne(d => d.AdditionalNightPrestation).WithMany(p => p.AdditionalOnCallPrestationRegistryAdditionalNightPrestations).HasConstraintName("FK_AdditionalOnCallPrestationRegistry_NightPrestation");

            entity.HasOne(d => d.AdditionalWeekendPrestation).WithMany(p => p.AdditionalOnCallPrestationRegistryAdditionalWeekendPrestations).HasConstraintName("FK_AdditionalOnCallPrestationRegistry_WeekendPrestation");

            entity.HasOne(d => d.UsageCodeNavigation).WithMany(p => p.AdditionalOnCallPrestationRegistries)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AdditionalOnCallPrestationRegistry_UsageType");
        });

        modelBuilder.Entity<AssurmedAttest>(entity =>
        {
            entity.Property(e => e.AssurmedAttestId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Attest>(entity =>
        {
            entity.HasKey(e => e.AttestId).IsClustered(false);

            entity.HasIndex(e => new { e.ExternalApplicationId, e.AttestDate, e.PatientId, e.AttestNumber, e.AttestId }, "IX_Attest_ExtAppId_AttestDate_PatientId_AttestNumber_AttestId")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.AttestId).ValueGeneratedNever();
            entity.Property(e => e.AttestNumberType).HasDefaultValue(1);

            entity.HasOne(d => d.ExternalApplication).WithMany(p => p.Attests)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Attest_ExternalApplication");

            entity.HasOne(d => d.IsDuplicateOfNavigation).WithMany(p => p.InverseIsDuplicateOfNavigation).HasConstraintName("FK_Attest_Attest");

            entity.HasOne(d => d.Patient).WithMany(p => p.Attests)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Attest_Patient");

            entity.HasOne(d => d.ThirdPartyPayer).WithMany(p => p.Attests).HasConstraintName("FK_Attest_ThirdParty");
        });

        modelBuilder.Entity<AttestLineItem>(entity =>
        {
            entity.Property(e => e.AttestLineItemId).ValueGeneratedNever();
            entity.Property(e => e.Copayment).HasComputedColumnSql("(case when ([Honorarium]-[OfficialHonorarium])<(0) then ([OfficialHonorarium]-[Reimbursement])+([Honorarium]-[OfficialHonorarium]) else [OfficialHonorarium]-[Reimbursement] end)", true);
            entity.Property(e => e.Discount).HasComputedColumnSql("(case when ([Honorarium]-[OfficialHonorarium])<(0) then ([Honorarium]-[OfficialHonorarium])*(-1) else (0) end)", true);
            entity.Property(e => e.EfactMaxCountException)
                .HasDefaultValueSql("(NULL)")
                .IsFixedLength();
            entity.Property(e => e.HospitalServiceCode).IsFixedLength();
            entity.Property(e => e.Letter).IsFixedLength();
            entity.Property(e => e.Supplement).HasComputedColumnSql("(case when ([Honorarium]-[OfficialHonorarium])>(0) then [Honorarium]-[OfficialHonorarium] else (0) end)", true);

            entity.HasOne(d => d.AttestedSession).WithMany(p => p.AttestLineItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AttestLineItem_AttestedSession");
        });

        modelBuilder.Entity<AttestPrintLayout>(entity =>
        {
            entity.Property(e => e.AttestPrintLayoutId).ValueGeneratedNever();
        });

        modelBuilder.Entity<AttestPrintLayoutItemPosition>(entity =>
        {
            entity.HasOne(d => d.AttestPrintLayout).WithMany(p => p.AttestPrintLayoutItemPositions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AttestPrintLayoutItemPosition_AttestPrintLayout");
        });

        modelBuilder.Entity<AttestSummary>(entity =>
        {
            entity.HasKey(e => e.AttestSummaryId).IsClustered(false);

            entity.HasIndex(e => new { e.ExternalApplicationId, e.AttestSummaryDate, e.ThirdPartyId, e.AtTheExpenseOf, e.AttestSummaryId }, "IX_AttestSummary_ExtAppId_Date_ThirdPartyId_AtTheExpenseOf_Id")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.AttestSummaryId).ValueGeneratedNever();

            entity.HasOne(d => d.ExternalApplication).WithMany(p => p.AttestSummaries)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AttestSummary_ExternalApplication");

            entity.HasOne(d => d.ThirdParty).WithMany(p => p.AttestSummaries)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AttestSummary_ThirdParty");

            entity.HasMany(d => d.Attests).WithMany(p => p.AttestSummaries)
                .UsingEntity<Dictionary<string, object>>(
                    "AttestSummaryAttest",
                    r => r.HasOne<Attest>().WithMany()
                        .HasForeignKey("AttestId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_AttestSummary_Attest_Attest"),
                    l => l.HasOne<AttestSummary>().WithMany()
                        .HasForeignKey("AttestSummaryId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_AttestSummary_Attest_AttestSummary"),
                    j =>
                    {
                        j.HasKey("AttestSummaryId", "AttestId");
                        j.ToTable("AttestSummary_Attest");
                    });
        });

        modelBuilder.Entity<AttestedSession>(entity =>
        {
            entity.Property(e => e.AttestedSessionId).ValueGeneratedNever();
            entity.Property(e => e.PercentageCoPayment).HasDefaultValue(100);

            entity.HasOne(d => d.Attest).WithMany(p => p.AttestedSessions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AttestedSession_Attest");

            entity.HasOne(d => d.Order).WithMany(p => p.AttestedSessions).HasConstraintName("FK_AttestedSession_Orders");

            entity.HasOne(d => d.PatientCarePlan).WithMany(p => p.AttestedSessions).HasConstraintName("FK_AttestedSession_PatientCarePlan");

            entity.HasOne(d => d.Physician).WithMany(p => p.AttestedSessionPhysicians)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AttestedSession_Physician");

            entity.HasOne(d => d.ResponsiblePhysician).WithMany(p => p.AttestedSessionResponsiblePhysicians)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AttestedSession_ResponsiblePhysician");

            entity.HasOne(d => d.Site).WithMany(p => p.AttestedSessions).HasConstraintName("FK_AttestedSession_Site");

            entity.HasOne(d => d.SuppliedAidTypeNavigation).WithMany(p => p.AttestedSessions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AttestedSession_UsageType");

            entity.HasOne(d => d.WorkAccident).WithMany(p => p.AttestedSessions).HasConstraintName("FK_AttestedSession_Workaccident");
        });

        modelBuilder.Entity<AttestsAtTheExpenseOfPrivateInsuranceOrganismThatAreNotInvoiced>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("AttestsAtTheExpenseOfPrivateInsuranceOrganismThatAreNotInvoiced_PK");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<AttestsAtTheExpenseOfPublicInsuranceOrganismWithPatientContributionForOtherThatAreNotInvoiced>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("AttestsAtTheExpenseOfPublicInsuranceOrganismWithPatientContributionForOtherThatAreNotInvoiced_PK");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<AttestsAtTheExpenseOfPublicInsuranceOrganismWithReimbursementNotPaidThatAreNotInvoiced>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("AttestsAtTheExpenseOfPublicInsuranceOrganismWithReimbursementNotPaidThatAreNotInvoiced_PK");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<AttestsWithPatientContributionAtTheExpenseOfPatientThatAreNotInvoiced>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("AttestsWithPatientContributionAtTheExpenseOfPatientThatAreNotInvoiced_PK");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<BackgroundTask>(entity =>
        {
            entity.HasKey(e => e.BackgroundTaskId).IsClustered(false);

            entity.Property(e => e.BackgroundTaskId).ValueGeneratedNever();

            entity.HasOne(d => d.ExternalApplication).WithMany(p => p.BackgroundTasks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BackgroundTask_ExternalApplication");

            entity.HasOne(d => d.User).WithMany(p => p.BackgroundTasks).HasConstraintName("FK_BackgroundTask_User");
        });

        modelBuilder.Entity<BackgroundTaskResult>(entity =>
        {
            entity.HasKey(e => e.BackgroundTaskResultId).IsClustered(false);

            entity.Property(e => e.BackgroundTaskResultId).ValueGeneratedNever();

            entity.HasOne(d => d.BackgroundTask).WithMany(p => p.BackgroundTaskResults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BackgroundTaskResult_BackgroundTask");
        });

        modelBuilder.Entity<Beneficiary>(entity =>
        {
            entity.Property(e => e.BeneficiaryId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Chapter>(entity =>
        {
            entity.HasKey(e => e.ChapterId).IsClustered(false);

            entity.HasIndex(e => e.ChapterCode, "IX_Chapter_ChapterCode")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.ChapterId).ValueGeneratedNever();
        });

        modelBuilder.Entity<ChapterName>(entity =>
        {
            entity.HasKey(e => e.ChapterNameId).IsClustered(false);

            entity.HasIndex(e => new { e.ChapterId, e.LanguageCode }, "IX_Chapter_ChapterId_LanguageCode")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.ChapterNameId).ValueGeneratedNever();

            entity.HasOne(d => d.Chapter).WithMany(p => p.ChapterNames)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ChapterName_Chapter");

            entity.HasOne(d => d.LanguageCodeNavigation).WithMany(p => p.ChapterNames)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ChapterName_Language");
        });

        modelBuilder.Entity<Correction>(entity =>
        {
            entity.HasKey(e => e.CorrectionId).IsClustered(false);

            entity.HasIndex(e => e.CreationDate, "IX_Correction_CorrectionDate").IsClustered();

            entity.Property(e => e.CorrectionId).ValueGeneratedNever();

            entity.HasOne(d => d.Attest).WithMany(p => p.Corrections)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Correction_Attest");
        });

        modelBuilder.Entity<DefaultMemoCodesForPatientCarePlan>(entity =>
        {
            entity.HasOne(d => d.CareProvider).WithMany(p => p.DefaultMemoCodesForPatientCarePlans)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DefaultMemoCodesForPatientCarePlans_CareProvider");

            entity.HasOne(d => d.MemoCode).WithMany(p => p.DefaultMemoCodesForPatientCarePlans)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DefaultMemoCodesForPatientCarePlans_MemoCode");

            entity.HasOne(d => d.PatientCarePlan).WithMany(p => p.DefaultMemoCodesForPatientCarePlans)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DefaultMemoCodesForPatientCarePlans_PatientCarePlan");
        });

        modelBuilder.Entity<EfactRejectionReason>(entity =>
        {
            entity.HasKey(e => e.RejectionReasonId).IsClustered(false);

            entity.Property(e => e.RejectionReasonId).ValueGeneratedNever();
            entity.Property(e => e.CreationDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.ModificationDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Version).HasDefaultValue(1);

            entity.HasOne(d => d.AttestedTariffedService).WithMany(p => p.EfactRejectionReasons)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_EFactRejectionReason_AttestedTariffedServiceId");

            entity.HasOne(d => d.Efact).WithMany(p => p.EfactRejectionReasons)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_EFactRejectionReason_EFactId");

            entity.HasOne(d => d.ExternalApplication).WithMany(p => p.EfactRejectionReasons).HasConstraintName("FK_EFactRejectionReason_ExternalApplicationId");
        });

        modelBuilder.Entity<ElectronicAttestResponse>(entity =>
        {
            entity.HasKey(e => e.ElectronicAttestResponseId).IsClustered(false);

            entity.Property(e => e.ElectronicAttestResponseId).ValueGeneratedNever();

            entity.HasOne(d => d.Attest).WithMany(p => p.ElectronicAttestResponses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ElectronicAttestResponse_Attest");
        });

        modelBuilder.Entity<ElectronicInvoice>(entity =>
        {
            entity.HasKey(e => e.ElectronicInvoiceId).IsClustered(false);

            entity.ToTable("ElectronicInvoice", tb => tb.HasTrigger("DuplicateElectronicInvoiceCheck"));

            entity.Property(e => e.ElectronicInvoiceId).ValueGeneratedNever();
            entity.Property(e => e.Type).HasDefaultValue(1);

            entity.HasOne(d => d.ExternalApplication).WithMany(p => p.ElectronicInvoices)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ElectronicInvoice_ExternalApplication");

            entity.HasMany(d => d.Attests).WithMany(p => p.ElectronicInvoices)
                .UsingEntity<Dictionary<string, object>>(
                    "ElectronicInvoiceAttest",
                    r => r.HasOne<Attest>().WithMany()
                        .HasForeignKey("AttestId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ElectronicInvoiceAttest_Attest"),
                    l => l.HasOne<ElectronicInvoice>().WithMany()
                        .HasForeignKey("ElectronicInvoiceId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ElectronicInvoiceAttest_ElectronicInvoice"),
                    j =>
                    {
                        j.HasKey("ElectronicInvoiceId", "AttestId");
                        j.ToTable("ElectronicInvoice_Attest");
                        j.HasIndex(new[] { "AttestId" }, "IX_ElectronicInvoice_Attest_AttestId_Incl_ElectronicInvoiceId");
                        j.HasIndex(new[] { "AttestId" }, "Non_Clustered_On_AttestId");
                    });
        });

        modelBuilder.Entity<ElectronicInvoiceDispatchNumberCounter>(entity =>
        {
            entity.HasOne(d => d.ExternalApplication).WithMany(p => p.ElectronicInvoiceDispatchNumberCounters).HasConstraintName("FK_ElectronicInvoiceDispatchNumberCounter_ExternalApplication");
        });

        modelBuilder.Entity<ElectronicInvoiceResponse>(entity =>
        {
            entity.HasKey(e => e.ElectronicInvoiceResponseId).IsClustered(false);

            entity.Property(e => e.ElectronicInvoiceResponseId).ValueGeneratedNever();

            entity.HasOne(d => d.ElectronicInvoice).WithMany(p => p.ElectronicInvoiceResponses)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ElectronicInvoiceResponse_ElectronicInvoice");
        });

        modelBuilder.Entity<ExternalApplication>(entity =>
        {
            entity.HasKey(e => e.ExternalApplicationId).IsClustered(false);

            entity.HasIndex(e => e.ApplicationName, "IX_ExternalApplication_ApplicationName")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.ExternalApplicationId).ValueGeneratedNever();
        });

        modelBuilder.Entity<ExternalApplicationSetting>(entity =>
        {
            entity.Property(e => e.ExternalApplicationSettingsId).ValueGeneratedNever();
            entity.Property(e => e.AutoPayEfactInvoices).HasDefaultValue(true);
            entity.Property(e => e.AutoSendEfactInvoices).HasDefaultValue(true);
            entity.Property(e => e.EfactPucCode).IsFixedLength();
            entity.Property(e => e.UseCorrespondenceTemplates).HasDefaultValue(true);
            entity.Property(e => e.UseEboxByDefault).HasDefaultValue(true);
            entity.Property(e => e.UseEfact).HasDefaultValue(true);
            entity.Property(e => e.UseEtar).HasDefaultValue(true);
            entity.Property(e => e.UseHelenaByDefault).HasDefaultValue(true);

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.ExternalApplicationSettings).HasConstraintName("FK_ExternalApplication_Beneficiary");

            entity.HasOne(d => d.DefaultSite).WithMany(p => p.ExternalApplicationSettings).HasConstraintName("FK_ExternalApplicationSettings_Site");

            entity.HasOne(d => d.ExternalApplicationSettings).WithOne(p => p.ExternalApplicationSetting)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ExternalApplicationSettings_ExternalApplication");
        });

        modelBuilder.Entity<FileJob>(entity =>
        {
            entity.HasKey(e => e.FileJobId).IsClustered(false);

            entity.Property(e => e.FileJobId).ValueGeneratedNever();

            entity.HasOne(d => d.ExternalApplication).WithMany(p => p.FileJobs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FileJob_ExternalApplication");
        });

        modelBuilder.Entity<FileJobItem>(entity =>
        {
            entity.HasKey(e => e.FileJobItemId).IsClustered(false);

            entity.Property(e => e.FileJobItemId).ValueGeneratedNever();

            entity.HasOne(d => d.FileJob).WithMany(p => p.FileJobItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FileJobItem_FileJob");
        });

        modelBuilder.Entity<FileJobItemFile>(entity =>
        {
            entity.HasKey(e => e.FileJobItemFileId).IsClustered(false);

            entity.Property(e => e.FileJobItemFileId).ValueGeneratedNever();

            entity.HasOne(d => d.FileJobItem).WithMany(p => p.FileJobItemFiles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FileJobItemFile_FileJobItem");
        });

        modelBuilder.Entity<ForfaitInvoice>(entity =>
        {
            entity.Property(e => e.ForfaitInvoiceId).ValueGeneratedNever();
        });

        modelBuilder.Entity<ForfaitInvoiceDetail>(entity =>
        {
            entity.Property(e => e.ForfaitInvoiceDetailId).ValueGeneratedNever();

            entity.HasOne(d => d.ForfaitInvoice).WithMany(p => p.ForfaitInvoiceDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ForfaitInvoiceDetail_ForfaitInvoice");

            entity.HasOne(d => d.Patient).WithMany(p => p.ForfaitInvoiceDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ForfaitInvoiceDetail_Patient");
        });

        modelBuilder.Entity<ForfaitInvoiceElectronicMessage>(entity =>
        {
            entity.Property(e => e.ForfaitInvoiceElectronicMessageId).ValueGeneratedNever();

            entity.HasOne(d => d.ForfaitInvoice).WithMany(p => p.ForfaitInvoiceElectronicMessages)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ForfaitInvoice_ElectronicMessage");
        });

        modelBuilder.Entity<ForfaitInvoicePatientInvoicedService>(entity =>
        {
            entity.Property(e => e.ForfaitInvoicePatientInvoicedServiceId).ValueGeneratedNever();

            entity.HasOne(d => d.ForfaitInvoiceDetail).WithMany(p => p.ForfaitInvoicePatientInvoicedServices)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ForfaitInvoicePatientInvoicedService_ForfaitInvoiceDetail");
        });

        modelBuilder.Entity<ForfaitInvoiceReInvoiceablePeriod>(entity =>
        {
            entity.Property(e => e.ForfaitInvoiceReInvoiceablePeriodId).ValueGeneratedNever();

            entity.HasOne(d => d.ForfaitInvoice).WithMany(p => p.ForfaitInvoiceReInvoiceablePeriods).HasConstraintName("FK_ForfaitInvoiceReInvoiceablePeriod_ForfaitInvoice");

            entity.HasOne(d => d.Patient).WithMany(p => p.ForfaitInvoiceReInvoiceablePeriods)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ForfaitInvoiceReInvoiceablePeriodPatientId");
        });

        modelBuilder.Entity<ForfaitMedicalCareServiceFee>(entity =>
        {
            entity.Property(e => e.ForfaitMedicalCareServiceFeeId).ValueGeneratedNever();

            entity.HasOne(d => d.ExternalApplication).WithMany(p => p.ForfaitMedicalCareServiceFees)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ForfaitMedicalCareServiceFee_ExternalApplication");
        });

        modelBuilder.Entity<ForfaitPatientHistory>(entity =>
        {
            entity.HasKey(e => e.ForfaitPatientHistoryId).IsClustered(false);

            entity.Property(e => e.ForfaitPatientHistoryId).ValueGeneratedNever();

            entity.HasOne(d => d.ExternalApplication).WithMany(p => p.ForfaitPatientHistories)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ForfaitPatientHistory_ExternalApplication");

            entity.HasOne(d => d.Patient).WithMany(p => p.ForfaitPatientHistories)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ForfaitPatientHistory_Patient");
        });

        modelBuilder.Entity<ForfaitPendingInvoicingItem>(entity =>
        {
            entity.Property(e => e.PendingInvoiceItemId).ValueGeneratedNever();

            entity.HasOne(d => d.Patient).WithMany(p => p.ForfaitPendingInvoicingItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ForfaitPendingInvoicingItem_Patient");
        });

        modelBuilder.Entity<InsuranceInfo>(entity =>
        {
            entity.HasOne(d => d.Patient).WithMany().HasConstraintName("FK_InsuranceInfo_Patient");

            entity.HasOne(d => d.Thirdparty).WithMany().HasConstraintName("FK_InsuranceInfo_Thirdparty");
        });

        modelBuilder.Entity<Invoice>(entity =>
        {
            entity.HasKey(e => e.InvoiceId).IsClustered(false);

            entity.HasIndex(e => new { e.ExternalApplicationId, e.InvoiceDate }, "IX_Invoice_ExtAppId_InvoiceDate").IsClustered();

            entity.Property(e => e.InvoiceId).ValueGeneratedNever();

            entity.HasOne(d => d.ExternalApplication).WithMany(p => p.Invoices)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Invoice_ExternalApplication");

            entity.HasOne(d => d.ThirdParty).WithMany(p => p.Invoices).HasConstraintName("FK_Invoice_ThirdParty");
        });

        modelBuilder.Entity<InvoiceLine>(entity =>
        {
            entity.HasKey(e => e.InvoiceLineId).IsClustered(false);

            entity.HasIndex(e => new { e.InvoiceId, e.SequenceNr }, "IX_InvoiceLine_InvoiceId_SeqNr")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.InvoiceLineId).ValueGeneratedNever();

            entity.HasOne(d => d.Attest).WithMany(p => p.InvoiceLines)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InvoiceLine_Attest");

            entity.HasOne(d => d.Invoice).WithMany(p => p.InvoiceLines)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InvoiceLine_Invoice");
        });

        modelBuilder.Entity<InvoiceSetting>(entity =>
        {
            entity.Property(e => e.CoverTransferBox).HasDefaultValue(true);
            entity.Property(e => e.ReminderDueDateTresholdLevel1).HasDefaultValue((short)1);

            entity.HasOne(d => d.DefaultInvoiceTemplate).WithMany().HasConstraintName("FK_InvoiceSettings_InvoiceTemplate");

            entity.HasOne(d => d.DefaultReminderTemplate).WithMany().HasConstraintName("FK_InvoiceSettings_ReminderTemplate");
        });

        modelBuilder.Entity<InvoiceTemplate>(entity =>
        {
            entity.Property(e => e.InvoiceTemplateId).ValueGeneratedNever();
            entity.Property(e => e.AddresseeBoxVisibilityType).HasDefaultValue((short)3);
            entity.Property(e => e.AddresseeBoxX).HasDefaultValue((short)1);
            entity.Property(e => e.AddresseeBoxY).HasDefaultValue((short)1);
            entity.Property(e => e.ContentBoxY).HasDefaultValue((short)1);
            entity.Property(e => e.ContentBoxYauto).HasDefaultValue(true);
            entity.Property(e => e.InfoBoxVisible).HasDefaultValue(true);
            entity.Property(e => e.InfoBoxX).HasDefaultValue((short)1);
            entity.Property(e => e.InfoBoxY).HasDefaultValue((short)1);
            entity.Property(e => e.PrePrinted).HasDefaultValue(true);
            entity.Property(e => e.SenderBoxCbenumberVisible).HasDefaultValue(true);
            entity.Property(e => e.SenderBoxEmailVisible).HasDefaultValue(true);
            entity.Property(e => e.SenderBoxNihiiNumberVisible).HasDefaultValue(true);
            entity.Property(e => e.SenderBoxTelephoneVisible).HasDefaultValue(true);
            entity.Property(e => e.SenderBoxTenantNameVisible).HasDefaultValue(true);
            entity.Property(e => e.SenderBoxVisibilityType).HasDefaultValue((short)3);
            entity.Property(e => e.SenderBoxWebsiteVisible).HasDefaultValue(true);
            entity.Property(e => e.SenderBoxX).HasDefaultValue((short)1);
            entity.Property(e => e.SenderBoxY).HasDefaultValue((short)1);
            entity.Property(e => e.TransferBoxAddresseeVisible).HasDefaultValue(true);
            entity.Property(e => e.TransferBoxAmountVisible).HasDefaultValue(true);
            entity.Property(e => e.TransferBoxBeneficiaryBankAccountNumberVisible).HasDefaultValue(true);
            entity.Property(e => e.TransferBoxBeneficiaryVisible).HasDefaultValue(true);
            entity.Property(e => e.TransferBoxReferenceVisible).HasDefaultValue(true);
            entity.Property(e => e.TransferBoxVisibilityType).HasDefaultValue((short)1);
            entity.Property(e => e.TransferBoxX).HasDefaultValue((short)1);
            entity.Property(e => e.TransferBoxY).HasDefaultValue((short)1);

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.InvoiceTemplates)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_InvoiceTemplate_Beneficiary");
        });

        modelBuilder.Entity<Language>(entity =>
        {
            entity.Property(e => e.LanguageCode).ValueGeneratedNever();
        });

        modelBuilder.Entity<LatestEfactReferenceNumberForAttest>(entity =>
        {
            entity.HasKey(e => e.AttestId).HasName("LatestEFactReferenceNumberForAttests_PK");

            entity.Property(e => e.AttestId).ValueGeneratedNever();
        });

        modelBuilder.Entity<MailerQueue>(entity =>
        {
            entity.HasKey(e => e.ItemId).IsClustered(false);

            entity.Property(e => e.ItemId).ValueGeneratedNever();

            entity.HasOne(d => d.ExternalApplication).WithMany(p => p.MailerQueues)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MailerQueue_ExternalApplication");
        });

        modelBuilder.Entity<MailerQueueAttachment>(entity =>
        {
            entity.HasKey(e => e.AttachmentId).IsClustered(false);

            entity.Property(e => e.AttachmentId).ValueGeneratedNever();

            entity.HasOne(d => d.MailItem).WithMany(p => p.MailerQueueAttachments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MailerQueueAttachment_MailerQueue");
        });

        modelBuilder.Entity<MedicalCareServiceRelation>(entity =>
        {
            entity.HasKey(e => e.PrestationRelationId)
                .HasName("PK_PrestationRelation")
                .IsClustered(false);

            entity.HasIndex(e => new { e.PrestationXId, e.ValidFrom, e.PrestationRelationCode, e.PrestationYId }, "IX_PrestationRelation_PrestX_Id_ValidFrom_RelationCode_PrestY_Id")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.PrestationRelationId).ValueGeneratedNever();

            entity.HasOne(d => d.PrestationRelationCodeNavigation).WithMany(p => p.MedicalCareServiceRelations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrestationRelation_PrestationRelationCodeType");

            entity.HasOne(d => d.PrestationX).WithMany(p => p.MedicalCareServiceRelationPrestationXes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrestationRelation_PrestationX");

            entity.HasOne(d => d.PrestationY).WithMany(p => p.MedicalCareServiceRelationPrestationies)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrestationRelation_PrestationY");
        });

        modelBuilder.Entity<MedicalHouseBankAccountInfo>(entity =>
        {
            entity.HasKey(e => e.MedicalHouseBankAccountInfoId).IsClustered(false);

            entity.Property(e => e.MedicalHouseBankAccountInfoId).ValueGeneratedNever();

            entity.HasOne(d => d.MedicalHouseSettings).WithMany(p => p.MedicalHouseBankAccountInfos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MedicalHouseBankAccountInfo_MedicalHouseSettings");
        });

        modelBuilder.Entity<MedicalHouseSetting>(entity =>
        {
            entity.Property(e => e.MedicalHouseSettingsId).ValueGeneratedNever();
        });

        modelBuilder.Entity<MemberDataHistory>(entity =>
        {
            entity.HasKey(e => e.MemberDataHistoryId).HasName("PK__MemberDa__4EC718D239C0385F");

            entity.Property(e => e.MemberDataHistoryId).ValueGeneratedNever();

            entity.HasOne(d => d.ExternalApplication).WithMany(p => p.MemberDataHistories)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MemberDataHistory_ExternalApplication");

            entity.HasOne(d => d.MemberDataRequest).WithMany(p => p.MemberDataHistories)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MemberDataHistory_MemberDataRequest");

            entity.HasOne(d => d.Patient).WithMany(p => p.MemberDataHistories)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MemberDataHistory_Patient");
        });

        modelBuilder.Entity<MemberDataRequest>(entity =>
        {
            entity.Property(e => e.MemberDataRequestId).ValueGeneratedNever();

            entity.HasOne(d => d.ExternalApplication).WithMany(p => p.MemberDataRequests)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MemberDataRequest_ExternalApplication");
        });

        modelBuilder.Entity<MemoCode>(entity =>
        {
            entity.Property(e => e.MemoCodeId).ValueGeneratedNever();
        });

        modelBuilder.Entity<MemoCodeMedicalCareService>(entity =>
        {
            entity.HasKey(e => e.MemoCodeMedicalCareServiceId).HasName("PK_MemoCodeGroup");

            entity.Property(e => e.MemoCodeMedicalCareServiceId).ValueGeneratedNever();

            entity.HasOne(d => d.MemoCode).WithMany(p => p.MemoCodeMedicalCareServices)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MemoCodeMedicalCareService_MemoCode");
        });

        modelBuilder.Entity<OfficialOverriddenMedicalCareServiceFee>(entity =>
        {
            entity.Property(e => e.OfficialOverriddenMedicalCareServiceFeeId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.OrderId)
                .HasName("PK_Order")
                .IsClustered(false);

            entity.Property(e => e.OrderId).ValueGeneratedNever();

            entity.HasOne(d => d.FirstAttest).WithMany(p => p.Orders).HasConstraintName("FK_Orders_Attest");

            entity.HasOne(d => d.PatientCarePlan).WithMany(p => p.Orders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_PatientCarePlan");
        });

        modelBuilder.Entity<OverriddenOfficialFeesForConventionedCareProvider>(entity =>
        {
            entity.HasKey(e => e.OverriddenOfficialFeesForConventionedCareProvidersId).HasName("PK__Overridd__1C26B8DCD3E80758");

            entity.Property(e => e.OverriddenOfficialFeesForConventionedCareProvidersId).ValueGeneratedNever();

            entity.HasOne(d => d.CareProvider).WithMany(p => p.OverriddenOfficialFeesForConventionedCareProviders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Overridde__CareP__490FC9A0");
        });

        modelBuilder.Entity<Patient>(entity =>
        {
            entity.HasKey(e => e.PatientId).IsClustered(false);

            entity.HasIndex(e => new { e.ExternalApplicationId, e.ExternalPatientId }, "IX_Patient_ExternalApplicationId_ExternalPatientId")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.PatientId).ValueGeneratedNever();

            entity.HasOne(d => d.ExternalApplication).WithMany(p => p.Patients)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Patient_ExternalApplication");
        });

        modelBuilder.Entity<PatientCarePlan>(entity =>
        {
            entity.HasKey(e => e.PatientCarePlanId).IsClustered(false);

            entity.Property(e => e.PatientCarePlanId).ValueGeneratedNever();
            entity.Property(e => e.AtTheExpenseOf).HasDefaultValue(1);
            entity.Property(e => e.PercentageCoPayment).HasDefaultValue(100);
            entity.Property(e => e.SendToAssurmed).HasDefaultValue(true);

            entity.HasOne(d => d.ExternalApplication).WithMany(p => p.PatientCarePlans)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientCarePlan_ExternalApplication");

            entity.HasOne(d => d.Patient).WithMany(p => p.PatientCarePlans)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientCarePlan_Patient");
        });

        modelBuilder.Entity<PatientCarePlanAgreement>(entity =>
        {
            entity.HasKey(e => e.PatientCarePlanAgreementId).IsClustered(false);

            entity.Property(e => e.PatientCarePlanAgreementId).ValueGeneratedNever();

            entity.HasOne(d => d.PatientCarePlan).WithMany(p => p.PatientCarePlanAgreements)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientCarePlanAgreement_PatientCarePlan");
        });

        modelBuilder.Entity<PatientCarePlanAgreementProperty>(entity =>
        {
            entity.Property(e => e.PatientCarePlanAgreementPropertiesId).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.PatientCarePlanAgreement).WithMany(p => p.PatientCarePlanAgreementProperties)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientCarePlanAgreementProperties_PatientCarePlanAgreement");
        });

        modelBuilder.Entity<PatientCarePlanExternalVisit>(entity =>
        {
            entity.HasKey(e => e.PatientCarePlanExternalVisitId).IsClustered(false);

            entity.Property(e => e.PatientCarePlanExternalVisitId).ValueGeneratedNever();

            entity.HasOne(d => d.Order).WithMany(p => p.PatientCarePlanExternalVisits).HasConstraintName("FK_PatientCarePlanExternalVisit_Order");

            entity.HasOne(d => d.PatientCarePlan).WithMany(p => p.PatientCarePlanExternalVisits)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PatientCarePlanExternalVisit_PatientCarePlan");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.Property(e => e.PaymentId).ValueGeneratedNever();
            entity.Property(e => e.PaymentType).HasDefaultValue(1);

            entity.HasOne(d => d.Attest).WithMany(p => p.Payments).HasConstraintName("FK_Payment_Attest");

            entity.HasOne(d => d.CollectingUser).WithMany(p => p.Payments).HasConstraintName("FK_Payment_User");

            entity.HasOne(d => d.ForfaitInvoice).WithMany(p => p.Payments).HasConstraintName("FK_Payment_ForfaitInvoice");

            entity.HasOne(d => d.Invoice).WithMany(p => p.Payments).HasConstraintName("FK_Payment_Invoice");

            entity.HasOne(d => d.TarificationSession).WithMany(p => p.Payments).HasConstraintName("FK_Payment_TarificationSession");
        });

        modelBuilder.Entity<PaymentInvitation>(entity =>
        {
            entity.HasKey(e => e.PaymentInvitationId).IsClustered(false);

            entity.Property(e => e.PaymentInvitationId).ValueGeneratedNever();
        });

        modelBuilder.Entity<PaymentInvitationPayable>(entity =>
        {
            entity.HasKey(e => new { e.PaymentInvitationId, e.PayableId, e.PayableType }).IsClustered(false);

            entity.HasOne(d => d.PaymentInvitation).WithMany(p => p.PaymentInvitationPayables)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PaymentInvitationPayablese_PaymentInvitation");
        });

        modelBuilder.Entity<Physician>(entity =>
        {
            entity.HasKey(e => e.PhysicianId).IsClustered(false);

            entity.HasIndex(e => new { e.ExternalApplicationId, e.ExternalPhysicianId }, "IX_Physician_ExternalApplicationId_ExternalPhysicianId")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.PhysicianId).ValueGeneratedNever();
            entity.Property(e => e.DefaultAtTheExpenseOf).HasDefaultValue(1);
            entity.Property(e => e.DefaultPercentageCoPayment).HasDefaultValue(100);
            entity.Property(e => e.DefaultPriceTypeCode).HasDefaultValue("");
            entity.Property(e => e.DefaultRoundingStrategy).HasDefaultValue(1);
            entity.Property(e => e.EfactPucCode).IsFixedLength();
            entity.Property(e => e.EveningStartsAt).HasDefaultValueSql("((648000000000.))");
            entity.Property(e => e.NightEndsAt).HasDefaultValueSql("((287990000000.))");
            entity.Property(e => e.NightStartsAt).HasDefaultValueSql("((756000000000.))");
            entity.Property(e => e.SupplementFrom).HasDefaultValue(new TimeOnly(18, 0, 0));
            entity.Property(e => e.SupplementStill).HasDefaultValue(new TimeOnly(8, 0, 0));
            entity.Property(e => e.UseTimeBasedOnCallDetermination).HasDefaultValue(true);
            entity.Property(e => e.WeekendEndDay).HasDefaultValue(1);
            entity.Property(e => e.WeekendEndTime).HasDefaultValueSql("((287990000000.))");
            entity.Property(e => e.WeekendStartDay).HasDefaultValue(6);
            entity.Property(e => e.WeekendStartTime).HasDefaultValueSql("((288000000000.))");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.Physicians).HasConstraintName("FK_Physician_Beneficiary");

            entity.HasOne(d => d.ExternalApplication).WithMany(p => p.Physicians)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Physician_ExternalApplication");
        });

        modelBuilder.Entity<PhysicianSettingsOb>(entity =>
        {
            entity.HasKey(e => e.PhysicianSettingsId)
                .HasName("PK_PhysicianSettings")
                .IsClustered(false);

            entity.Property(e => e.PhysicianSettingsId).ValueGeneratedNever();

            entity.HasOne(d => d.Physician).WithOne(p => p.PhysicianSettingsOb)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PhysicianSettings");
        });

        modelBuilder.Entity<Prestation>(entity =>
        {
            entity.HasKey(e => e.PrestationId).IsClustered(false);

            entity.HasIndex(e => e.NomenclatureNr, "IX_Prestation_NomenclatureNr")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.PrestationId).ValueGeneratedNever();

            entity.HasOne(d => d.Chapter).WithMany(p => p.Prestations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Prestation_Chapter");

            entity.HasOne(d => d.PrestationTypeCodeNavigation).WithMany(p => p.Prestations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Prestation_PrestationType");

            entity.HasOne(d => d.UsageCodeNavigation).WithMany(p => p.Prestations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Prestation_UsageType");
        });

        modelBuilder.Entity<PrestationCoefficientValue>(entity =>
        {
            entity.HasKey(e => e.PrestationCoefficientValueId).IsClustered(false);

            entity.HasIndex(e => new { e.PrestationId, e.ValidationDate, e.LetterKey }, "IX_PrestationCoefficientValue_PrestationId_ValDate_LetterKey")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.PrestationCoefficientValueId).ValueGeneratedNever();

            entity.HasOne(d => d.Prestation).WithMany(p => p.PrestationCoefficientValues)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrestationCoefficientValue_Prestation");
        });

        modelBuilder.Entity<PrestationGroup>(entity =>
        {
            entity.HasKey(e => e.PrestationGroupId).IsClustered(false);

            entity.HasIndex(e => new { e.ExternalApplicationId, e.UserId, e.MemoCode }, "IX_PrestationGroup_ExternalApplicationId_UserId_MemoCode")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.PrestationGroupId).ValueGeneratedNever();

            entity.HasOne(d => d.ExternalApplication).WithMany(p => p.PrestationGroups)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrestationGroup_ExternalApplication");

            entity.HasOne(d => d.User).WithMany(p => p.PrestationGroups).HasConstraintName("FK_PrestationGroup_User");
        });

        modelBuilder.Entity<PrestationGroupItem>(entity =>
        {
            entity.HasKey(e => e.PrestationGroupItemId).IsClustered(false);

            entity.HasIndex(e => new { e.PrestationGroupId, e.SequenceNr }, "IX_PrestationGroupItem_PrestationGroupId_SequenceNr")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.PrestationGroupItemId).ValueGeneratedNever();

            entity.HasOne(d => d.PrestationGroup).WithMany(p => p.PrestationGroupItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrestationGroupItem_PrestationGroup");

            entity.HasOne(d => d.Prestation).WithMany(p => p.PrestationGroupItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrestationGroupItem_Prestation");
        });

        modelBuilder.Entity<PrestationName>(entity =>
        {
            entity.HasKey(e => e.PrestationNameId).IsClustered(false);

            entity.HasIndex(e => new { e.PrestationId, e.LanguageCode }, "IX_PrestationName_PrestationId_LanguageCode")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.PrestationNameId).ValueGeneratedNever();

            entity.HasOne(d => d.LanguageCodeNavigation).WithMany(p => p.PrestationNames)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrestationName_Language");

            entity.HasOne(d => d.Prestation).WithMany(p => p.PrestationNames)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrestationName_Prestation");
        });

        modelBuilder.Entity<PrestationPrice>(entity =>
        {
            entity.HasKey(e => e.PrestationPriceId).IsClustered(false);

            entity.HasIndex(e => new { e.PrestationId, e.ValidationDate, e.PriceTypeId }, "IX_PrestationPrice_PrestationId_ValidationDate_PriceTypeId")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.PrestationPriceId).ValueGeneratedNever();

            entity.HasOne(d => d.Prestation).WithMany(p => p.PrestationPrices)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrestationPrice_Prestation");

            entity.HasOne(d => d.PriceType).WithMany(p => p.PrestationPrices)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrestationPrice_PriceType");
        });

        modelBuilder.Entity<PrestationRelationCodeType>(entity =>
        {
            entity.HasKey(e => e.PrestationRelationCode).HasName("PK_PrestationRelationCode");

            entity.Property(e => e.PrestationRelationCode).ValueGeneratedNever();
        });

        modelBuilder.Entity<PrestationType>(entity =>
        {
            entity.Property(e => e.PrestationTypeCode).ValueGeneratedNever();
        });

        modelBuilder.Entity<PriceTypeDescription>(entity =>
        {
            entity.HasOne(d => d.LanguageCodeNavigation).WithMany(p => p.PriceTypeDescriptions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PriceTypeDescription_Language");

            entity.HasOne(d => d.PriceType).WithMany(p => p.PriceTypeDescriptions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PriceTypeDescription_PriceType");
        });

        modelBuilder.Entity<PriceTypeRelation>(entity =>
        {
            entity.HasKey(e => e.PriceTypeRelationId).IsClustered(false);

            entity.Property(e => e.PriceTypeRelationId).ValueGeneratedNever();

            entity.HasOne(d => d.PriceTypeRelationCodeNavigation).WithMany(p => p.PriceTypeRelations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PriceTypeRelation_PriceTypeRelationCodeType");

            entity.HasOne(d => d.PriceTypeX).WithMany(p => p.PriceTypeRelationPriceTypeXes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PriceTypeRelation_PriceTypeX");

            entity.HasOne(d => d.PriceTypeY).WithMany(p => p.PriceTypeRelationPriceTypeYs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PriceTypeRelation_PriceTypeY");
        });

        modelBuilder.Entity<PriceTypeRelationCodeType>(entity =>
        {
            entity.Property(e => e.PriceTypeRelationCode).ValueGeneratedNever();
        });

        modelBuilder.Entity<PrinterSetting>(entity =>
        {
            entity.HasKey(e => e.PrinterSettingsId).IsClustered(false);

            entity.HasIndex(e => new { e.PrinterName, e.ExternalApplicationId, e.UserId }, "IX_PrinterSettings_PrinterName_ApplicationId_UserId")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.PrinterSettingsId).ValueGeneratedNever();

            entity.HasOne(d => d.AttestPrintLayout).WithMany(p => p.PrinterSettings).HasConstraintName("FK_PrinterSettings_AttestPrintLayout");

            entity.HasOne(d => d.User).WithMany(p => p.PrinterSettings).HasConstraintName("FK_PrinterSettings_User");
        });

        modelBuilder.Entity<Projection>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Projections_PK");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<RelativePrestationCode>(entity =>
        {
            entity.HasKey(e => e.RelativePrestationCodeId).IsClustered(false);

            entity.Property(e => e.RelativePrestationCodeId).ValueGeneratedNever();

            entity.HasOne(d => d.Prestation).WithMany(p => p.RelativePrestationCodes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RelativePrestationCode_Prestation");
        });

        modelBuilder.Entity<Reminder>(entity =>
        {
            entity.Property(e => e.ReminderId).ValueGeneratedNever();

            entity.HasOne(d => d.CreatedByUser).WithMany(p => p.Reminders)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Reminder_User");

            entity.HasOne(d => d.ReminderTemplate).WithMany(p => p.Reminders)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Reminder_ReminderTemplate");

            entity.HasMany(d => d.Invoices).WithMany(p => p.Reminders)
                .UsingEntity<Dictionary<string, object>>(
                    "ReminderInvoice",
                    r => r.HasOne<Invoice>().WithMany()
                        .HasForeignKey("InvoiceId")
                        .HasConstraintName("FK_ReminderInvoice_Invoice"),
                    l => l.HasOne<Reminder>().WithMany()
                        .HasForeignKey("ReminderId")
                        .HasConstraintName("FK_ReminderInvoice_Reminder"),
                    j =>
                    {
                        j.HasKey("ReminderId", "InvoiceId");
                        j.ToTable("Reminder_Invoice");
                    });
        });

        modelBuilder.Entity<ReminderTemplate>(entity =>
        {
            entity.Property(e => e.ReminderTemplateId).ValueGeneratedNever();
            entity.Property(e => e.AddresseeBoxVisibilityType).HasDefaultValue((short)1);
            entity.Property(e => e.AddresseeBoxX).HasDefaultValue((short)1);
            entity.Property(e => e.AddresseeBoxY).HasDefaultValue((short)1);
            entity.Property(e => e.ContentBoxY).HasDefaultValue((short)1);
            entity.Property(e => e.ContentBoxYauto).HasDefaultValue(true);
            entity.Property(e => e.InfoBoxVisible).HasDefaultValue(true);
            entity.Property(e => e.InfoBoxX).HasDefaultValue((short)1);
            entity.Property(e => e.InfoBoxY).HasDefaultValue((short)1);
            entity.Property(e => e.PrePrinted).HasDefaultValue(true);
            entity.Property(e => e.SenderBoxCbenumberVisible).HasDefaultValue(true);
            entity.Property(e => e.SenderBoxEmailVisible).HasDefaultValue(true);
            entity.Property(e => e.SenderBoxNihiiNumberVisible).HasDefaultValue(true);
            entity.Property(e => e.SenderBoxTelephoneVisible).HasDefaultValue(true);
            entity.Property(e => e.SenderBoxTenantNameVisible).HasDefaultValue(true);
            entity.Property(e => e.SenderBoxVisibilityType).HasDefaultValue((short)1);
            entity.Property(e => e.SenderBoxWebsiteVisible).HasDefaultValue(true);
            entity.Property(e => e.SenderBoxX).HasDefaultValue((short)1);
            entity.Property(e => e.SenderBoxY).HasDefaultValue((short)1);
            entity.Property(e => e.TransferBoxAddresseeVisible).HasDefaultValue(true);
            entity.Property(e => e.TransferBoxAmountVisible).HasDefaultValue(true);
            entity.Property(e => e.TransferBoxBeneficiaryBankAccountNumberVisible).HasDefaultValue(true);
            entity.Property(e => e.TransferBoxBeneficiaryVisible).HasDefaultValue(true);
            entity.Property(e => e.TransferBoxReferenceVisible).HasDefaultValue(true);
            entity.Property(e => e.TransferBoxVisibilityType).HasDefaultValue((short)1);
            entity.Property(e => e.TransferBoxX).HasDefaultValue((short)1);
            entity.Property(e => e.TransferBoxY).HasDefaultValue((short)1);

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.ReminderTemplates)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ReminderTemplate_Beneficiary");
        });

        modelBuilder.Entity<RetrocessionSetting>(entity =>
        {
            entity.Property(e => e.RetrocessionSettingId).ValueGeneratedNever();

            entity.HasOne(d => d.ExternalApplication).WithMany(p => p.RetrocessionSettings).HasConstraintName("FK_RetrocessionSetting_ExternalApplication");

            entity.HasOne(d => d.Physician).WithMany(p => p.RetrocessionSettings).HasConstraintName("FK_RetrocessionSetting_Physician");
        });

        modelBuilder.Entity<SchemaInfo>(entity =>
        {
            entity.HasKey(e => e.Version).HasName("PK__SchemaIn__0F54013551D115FF");

            entity.Property(e => e.Version).ValueGeneratedNever();
        });

        modelBuilder.Entity<SchemaVersion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_SchemaVersions_Id");
        });

        modelBuilder.Entity<Site>(entity =>
        {
            entity.HasKey(e => e.SiteId).HasName("PK__Site__B9DCB963D6B80E76");

            entity.Property(e => e.SiteId).ValueGeneratedNever();

            entity.HasOne(d => d.ExternalApplication).WithMany(p => p.Sites)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Site_ExternalApplication");
        });

        modelBuilder.Entity<TariffedService>(entity =>
        {
            entity.HasKey(e => e.TariffedServiceId).HasName("PK_TarificationSessionMedicalCareService");

            entity.Property(e => e.TariffedServiceId).ValueGeneratedNever();
            entity.Property(e => e.AtTheExpenseOf).HasDefaultValue(0);
            entity.Property(e => e.EfactMaxCountException)
                .HasDefaultValueSql("(NULL)")
                .IsFixedLength();
            entity.Property(e => e.HospitalServiceCode).IsFixedLength();
            entity.Property(e => e.LeftRightDesignation).IsFixedLength();
            entity.Property(e => e.Letter).IsFixedLength();

            entity.HasOne(d => d.TariffedOnCallService).WithMany(p => p.InverseTariffedOnCallService).HasConstraintName("FK_TariffedService_TariffedService");
        });

        modelBuilder.Entity<TarificationProfile>(entity =>
        {
            entity.Property(e => e.TarificationProfileId).ValueGeneratedNever();

            entity.HasOne(d => d.PrinterSettings).WithMany(p => p.TarificationProfiles).HasConstraintName("FK_TarificationProfile_PrinterSettings");

            entity.HasOne(d => d.User).WithMany(p => p.TarificationProfiles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TarificationProfile_User");
        });

        modelBuilder.Entity<TarificationSession>(entity =>
        {
            entity.Property(e => e.TarificationSessionId).ValueGeneratedNever();
            entity.Property(e => e.PercentageCoPayment).HasDefaultValue(100);

            entity.HasOne(d => d.ExternalApplication).WithMany(p => p.TarificationSessions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TarificationSession_ExternalApplication");

            entity.HasOne(d => d.Order).WithMany(p => p.TarificationSessions).HasConstraintName("FK_TarificationSession_Order");

            entity.HasOne(d => d.PatientCarePlan).WithMany(p => p.TarificationSessions).HasConstraintName("FK_TarificationSession_PatientCarePlan");

            entity.HasOne(d => d.Patient).WithMany(p => p.TarificationSessions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TarificationSession_Patient");

            entity.HasOne(d => d.PatientInsuranceInstitute).WithMany(p => p.TarificationSessions).HasConstraintName("FK_TarificationSession_ThirdParty");

            entity.HasOne(d => d.Physician).WithMany(p => p.TarificationSessionPhysicians)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TarificationSession_Physician");

            entity.HasOne(d => d.ResponsiblePhysician).WithMany(p => p.TarificationSessionResponsiblePhysicians)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TarificationSession_ResponsiblePhysician");

            entity.HasOne(d => d.Site).WithMany(p => p.TarificationSessions).HasConstraintName("FK_TarificationSession_Site");

            entity.HasOne(d => d.SuppliedAidTypeNavigation).WithMany(p => p.TarificationSessions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TarificationSession_UsageCode");

            entity.HasOne(d => d.WorkAccident).WithMany(p => p.TarificationSessions).HasConstraintName("FK_Tarificationsession_Workaccident");
        });

        modelBuilder.Entity<TarificationSessionContext>(entity =>
        {
            entity.HasOne(d => d.TarificationSession).WithMany(p => p.TarificationSessionContexts).HasConstraintName("FK_TarificationSessionContext_TarificationSession");
        });

        modelBuilder.Entity<TarifiedItem>(entity =>
        {
            entity.HasKey(e => e.TarifiedItemId).IsClustered(false);

            entity.Property(e => e.TarifiedItemId).ValueGeneratedNever();
            entity.Property(e => e.HospitalServiceCode).IsFixedLength();
            entity.Property(e => e.LeftRightDesignation).IsFixedLength();

            entity.HasOne(d => d.RegistrationModeNavigation).WithMany(p => p.TarifiedItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TarifiedItem_TarifiedPrestationRegistrationMode");

            entity.HasOne(d => d.TarificationSession).WithMany(p => p.TarifiedItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TarifiedItem_TarificationSession");
        });

        modelBuilder.Entity<TarifiedPrestationGroupItem>(entity =>
        {
            entity.HasKey(e => e.TarifiedPrestationGroupItemId).IsClustered(false);

            entity.Property(e => e.TarifiedPrestationGroupItemId).ValueGeneratedNever();

            entity.HasOne(d => d.PrestationGroup).WithMany(p => p.TarifiedPrestationGroupItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TarifiedPrestationGroupItem_PrestationGroup");

            entity.HasOne(d => d.TarifiedPrestationGroupItemNavigation).WithOne(p => p.TarifiedPrestationGroupItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TarifiedPrestationGroupItem_TarifiedItem");
        });

        modelBuilder.Entity<TarifiedPrestationGroupPrestationLine>(entity =>
        {
            entity.HasKey(e => e.TarifiedPrestationGroupPrestationLineId).IsClustered(false);

            entity.HasIndex(e => new { e.TarifiedPrestationGroupItemId, e.SequenceNr }, "IX_TarifiedPrestGroupPrestLine_TarifiedPrestGroupItemId_SeqNr")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.TarifiedPrestationGroupPrestationLineId).ValueGeneratedNever();

            entity.HasOne(d => d.Prestation).WithMany(p => p.TarifiedPrestationGroupPrestationLines)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TarifiedPrestationGroupPrestationLine_Prestation");

            entity.HasOne(d => d.TarifiedPrestationGroupItem).WithMany(p => p.TarifiedPrestationGroupPrestationLines)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TarPrestationGroupPrestationLine_TarPrestationGroupItem");
        });

        modelBuilder.Entity<TarifiedPrestationItem>(entity =>
        {
            entity.HasKey(e => e.TarifiedPrestationItemId)
                .HasName("PK_TarifiedPrestationProperties")
                .IsClustered(false);

            entity.Property(e => e.TarifiedPrestationItemId).ValueGeneratedNever();

            entity.HasOne(d => d.Prestation).WithMany(p => p.TarifiedPrestationItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TarifiedPrestationItem_Prestation");

            entity.HasOne(d => d.TarifiedPrestationItemNavigation).WithOne(p => p.TarifiedPrestationItem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TarifiedPrestationItem_TarifiedItem");
        });

        modelBuilder.Entity<TarifiedPrestationRegistrationMode>(entity =>
        {
            entity.Property(e => e.RegistrationModeCode).ValueGeneratedNever();
        });

        modelBuilder.Entity<ThirdParty>(entity =>
        {
            entity.HasKey(e => e.ThirdPartyId).IsClustered(false);

            entity.HasIndex(e => new { e.ExternalApplicationId, e.ExternalThirdPartyId, e.ThirdPartyType }, "IX_ThirdParty_ExtAppId_ExternalThirdPartyId_ThirdPartyType")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.ThirdPartyId).ValueGeneratedNever();

            entity.HasOne(d => d.ExternalApplication).WithMany(p => p.ThirdParties)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ThirdParty_ExternalApplication");
        });

        modelBuilder.Entity<UpdateLog>(entity =>
        {
            entity.HasKey(e => e.UpdateLogId).IsClustered(false);

            entity.HasIndex(e => e.ExecutionDate, "IX_UpdateLog_ExecutionDate")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.UpdateLogId).ValueGeneratedNever();
        });

        modelBuilder.Entity<UpdateLogLine>(entity =>
        {
            entity.HasKey(e => e.UpdateLogLineId).IsClustered(false);

            entity.Property(e => e.UpdateLogLineId).ValueGeneratedNever();

            entity.HasOne(d => d.UpdateLog).WithMany(p => p.UpdateLogLines)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UpdateLogLine_UpdateLog");
        });

        modelBuilder.Entity<UsageType>(entity =>
        {
            entity.Property(e => e.UsageTypeCode).ValueGeneratedNever();
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).IsClustered(false);

            entity.HasIndex(e => new { e.ExternalApplicationId, e.UserId }, "IX_User_ExternalApplicationId_ExternalUserId")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.UserId).ValueGeneratedNever();

            entity.HasOne(d => d.ExternalApplication).WithMany(p => p.Users)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_User_ExternalApplication");
        });

        modelBuilder.Entity<UserPrintOption>(entity =>
        {
            entity.Property(e => e.UserPrintOptionsId).ValueGeneratedNever();

            entity.HasOne(d => d.TarificationProfile).WithOne(p => p.UserPrintOption)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserPrintOptions_TarificationProfile");
        });

        modelBuilder.Entity<UserSetting>(entity =>
        {
            entity.Property(e => e.UserSettingsId).ValueGeneratedNever();
            entity.Property(e => e.UseEfact).HasDefaultValue(false);

            entity.HasOne(d => d.User).WithMany(p => p.UserSettings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserSettings_User");
        });

        modelBuilder.Entity<VwGlobalSessionInfoForAttest>(entity =>
        {
            entity.ToView("vwGlobalSessionInfoForAttests");
        });

        modelBuilder.Entity<WorkAccident>(entity =>
        {
            entity.Property(e => e.WorkAccidentId).ValueGeneratedNever();

            entity.HasOne(d => d.PatientCarePlan).WithMany(p => p.WorkAccidents).HasConstraintName("FK_Workaccident_PatientCarePlan");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
