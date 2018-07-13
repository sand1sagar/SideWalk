
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/10/2017 11:32:47
-- Generated from EDMX file: C:\Users\ssagar\Documents\Sidewalk Permit\SWPermitSVN\sidewalk.logic\Database\SidewalkDB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [SWPost];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Permit_PermitApplicant]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Permit] DROP CONSTRAINT [FK_Permit_PermitApplicant];
GO
IF OBJECT_ID(N'[dbo].[FK_Permit_PermitStatus]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Permit] DROP CONSTRAINT [FK_Permit_PermitStatus];
GO
IF OBJECT_ID(N'[dbo].[FK_PermitHistory_Permit]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PermitHistory] DROP CONSTRAINT [FK_PermitHistory_Permit];
GO
IF OBJECT_ID(N'[dbo].[FK_PermitPayment_Permit]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PermitPayment] DROP CONSTRAINT [FK_PermitPayment_Permit];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[dtproperties]', 'U') IS NOT NULL
    DROP TABLE [dbo].[dtproperties];
GO
IF OBJECT_ID(N'[dbo].[Permit]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Permit];
GO
IF OBJECT_ID(N'[dbo].[PermitApplicant]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PermitApplicant];
GO
IF OBJECT_ID(N'[dbo].[PermitCostsDetail]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PermitCostsDetail];
GO
IF OBJECT_ID(N'[dbo].[PermitFeeRate]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PermitFeeRate];
GO
IF OBJECT_ID(N'[dbo].[PermitHistory]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PermitHistory];
GO
IF OBJECT_ID(N'[dbo].[PermitPayment]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PermitPayment];
GO
IF OBJECT_ID(N'[dbo].[PermitStatus]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PermitStatus];
GO
IF OBJECT_ID(N'[dbo].[ASSESSOR]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ASSESSOR];
GO
IF OBJECT_ID(N'[dbo].[CCB_DAILY_LICENSES]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CCB_DAILY_LICENSES];
GO
IF OBJECT_ID(N'[dbo].[sw_user]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sw_user];
GO
IF OBJECT_ID(N'[dbo].[sw_posting]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sw_posting];
GO
IF OBJECT_ID(N'[dbo].[qip]', 'U') IS NOT NULL
    DROP TABLE [dbo].[qip];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'dtproperties'
CREATE TABLE [dbo].[dtproperties] (
    [id] int IDENTITY(1,1) NOT NULL,
    [objectid] int  NULL,
    [property] varchar(64)  NOT NULL,
    [value] varchar(255)  NULL,
    [uvalue] nvarchar(255)  NULL,
    [lvalue] varbinary(max)  NULL,
    [version] int  NOT NULL
);
GO

-- Creating table 'Permit'
CREATE TABLE [dbo].[Permit] (
    [PermitID] bigint IDENTITY(1,1) NOT NULL,
    [PermitNo] nvarchar(50)  NULL,
    [PermitIssued] nvarchar(50)  NULL,
    [PermitExtended] nvarchar(50)  NULL,
    [DateIssued] datetime  NULL,
    [DateExpired] datetime  NULL,
    [BuilderBoardNo] nvarchar(50)  NULL,
    [DateCancelled] datetime  NULL,
    [CancelledBy] nvarchar(50)  NULL,
    [LastAction] nvarchar(50)  NULL,
    [ApplicantType] nvarchar(50)  NULL,
    [ContractorID] nvarchar(50)  NULL,
    [AffidavitID] bigint  NULL,
    [TotalFee] decimal(18,2)  NULL,
    [PermitStatus] bigint  NULL,
    [ApplicantID] bigint  NULL,
    [SubmissionDate] datetime  NULL,
    [PropertyAddress] nvarchar(max)  NULL,
    [DateExpiredNew] datetime  NULL,
    [IssuedBy] nvarchar(50)  NULL,
    [DatePermitExtended] datetime  NULL,
    [NEW_AFF] nvarchar(max)  NULL
);
GO

-- Creating table 'PermitApplicant'
CREATE TABLE [dbo].[PermitApplicant] (
    [ApplicantID] bigint IDENTITY(1,1) NOT NULL,
    [ApplicantType] nvarchar(50)  NULL,
    [Name] nvarchar(50)  NULL,
    [Contact] nvarchar(50)  NULL,
    [Address] nvarchar(200)  NULL,
    [City] nvarchar(50)  NULL,
    [State] nvarchar(50)  NULL,
    [Zip] nvarchar(50)  NULL,
    [PhoneNumber] nvarchar(50)  NULL,
    [Email] nvarchar(50)  NULL,
    [PermitID] bigint  NULL,
    [CreatedDate] datetime  NULL,
    [ContactPhoneNumber] nvarchar(50)  NULL
);
GO

-- Creating table 'PermitCostsDetail'
CREATE TABLE [dbo].[PermitCostsDetail] (
    [PermitCostID] bigint IDENTITY(1,1) NOT NULL,
    [AffidavitID] bigint  NULL,
    [CostType] nvarchar(50)  NULL,
    [RepairItem] nvarchar(50)  NULL,
    [Unit] decimal(18,2)  NULL,
    [Rate] decimal(18,2)  NULL,
    [Cost] decimal(18,2)  NULL
);
GO

-- Creating table 'PermitFeeRate'
CREATE TABLE [dbo].[PermitFeeRate] (
    [PermitFeeID] bigint IDENTITY(1,1) NOT NULL,
    [Action_Type] nvarchar(50)  NULL,
    [CurrentRate] decimal(18,2)  NULL,
    [NewEffectiveRate] decimal(18,2)  NULL,
    [Status] bit  NOT NULL
);
GO

-- Creating table 'PermitHistory'
CREATE TABLE [dbo].[PermitHistory] (
    [PermitHistoryID] bigint IDENTITY(1,1) NOT NULL,
    [PermitID] bigint  NULL,
    [Status] nvarchar(100)  NULL,
    [ActivityTime] datetime  NULL,
    [Comments] nvarchar(max)  NULL
);
GO

-- Creating table 'PermitPayment'
CREATE TABLE [dbo].[PermitPayment] (
    [PermitPaymentID] bigint IDENTITY(1,1) NOT NULL,
    [PermitID] bigint  NULL,
    [IssueDate] datetime  NULL,
    [IssuedBy] nvarchar(50)  NULL,
    [PaymentMethod] nvarchar(50)  NULL,
    [ApprovalCode] nvarchar(50)  NULL,
    [CheckNumber] nvarchar(50)  NULL,
    [Notes] nvarchar(500)  NULL
);
GO

-- Creating table 'PermitStatus'
CREATE TABLE [dbo].[PermitStatus] (
    [PermitStatusID] bigint IDENTITY(1,1) NOT NULL,
    [PermitStatusValue] nvarchar(50)  NULL
);
GO

-- Creating table 'ASSESSOR'
CREATE TABLE [dbo].[ASSESSOR] (
    [RNUM] varchar(10)  NULL,
    [STATE_ID] varchar(22)  NULL,
    [NEW_STATE_ID] varchar(22)  NULL,
    [PROPERTY_ID] char(7)  NOT NULL,
    [OWNER1] varchar(35)  NULL,
    [OWNER2] varchar(35)  NULL,
    [OWNER3] varchar(35)  NULL,
    [OWNER_ADDRESS] varchar(35)  NULL,
    [OWNER_CITY] varchar(28)  NULL,
    [OWNER_STATE] char(2)  NULL,
    [OWNER_ZIP] varchar(10)  NULL,
    [SITE_ADDRESS_NUMBER] varchar(11)  NULL,
    [SITE_STREET_DIRECTION] varchar(2)  NULL,
    [SITE_STREET_NAME] varchar(28)  NULL,
    [SITE_STREET_TYPE] varchar(4)  NULL,
    [SITE_UNIT_TYPE] varchar(8)  NULL,
    [SITE_UNIT_NUMBER] varchar(5)  NULL,
    [SITE_ADDRESS_FULL] varchar(37)  NULL,
    [SITE_CITY] varchar(30)  NULL,
    [SITE_STATE] varchar(6)  NULL,
    [SITE_ZIP] varchar(8)  NULL,
    [SITE_CITY_STATE_ZIP] varchar(26)  NULL,
    [INSTRUMENT_NUMBER] varchar(50)  NULL,
    [MAP_NUMBER] varchar(9)  NULL,
    [LEGAL_DESCRIPTION] varchar(250)  NULL,
    [LOT] varchar(23)  NULL,
    [BLOCK] varchar(14)  NULL,
    [TAXCODE] varchar(7)  NULL,
    [PARCEL_SQUARE_FEET] int  NULL,
    [PARCEL_WIDTH_FOOTAGE] int  NULL,
    [PARCEL_LENGTH_FOOTAGE] smallint  NULL,
    [PROPERTY_CODE] varchar(2)  NULL,
    [PROPERTY_CODE_DESC] varchar(50)  NULL,
    [LANDUSE] varchar(4)  NULL,
    [YEAR_BUILT] varchar(10)  NULL,
    [BLDGSQFT] int  NULL,
    [NUMBER_OF_BEDROOMS] int  NULL,
    [NUMBER_OF_STORIES] int  NULL,
    [NUMBER_OF_UNITS] int  NULL,
    [MARKET_VALUE_YEAR1] varchar(4)  NOT NULL,
    [MARKET_VALUE_LAND1] int  NULL,
    [MARKET_VALUE_IMPROVEMENTS1] int  NULL,
    [MARKET_VALUE_TOTAL1] int  NULL,
    [MARKET_EXEMPTION_VALUE1] int  NULL,
    [M50_ASSESSED_VALUE1] int  NULL,
    [ASSESSED_VALUE_YEAR1] varchar(4)  NOT NULL,
    [ASSESSED_VALUE1] int  NULL,
    [MARKET_VALUE_YEAR2] varchar(4)  NOT NULL,
    [MARKET_VALUE_LAND2] int  NULL,
    [MARKET_VALUE_IMPROVEMENTS2] int  NULL,
    [MARKET_VALUE_TOTAL2] int  NULL,
    [MARKET_EXEMPTION_VALUE2] int  NULL,
    [M50_ASSESSED_VALUE2] int  NULL,
    [ASSESSED_VALUE_YEAR2] varchar(4)  NOT NULL,
    [ASSESSED_VALUE2] int  NULL,
    [MARKET_VALUE_YEAR3] varchar(30)  NULL,
    [MARKET_VALUE_LAND3] int  NULL,
    [MARKET_VALUE_IMPROVEMENTS3] int  NULL,
    [MARKET_VALUE_TOTAL3] int  NULL,
    [MARKET_EXEMPTION_VALUE3] int  NULL,
    [M50_ASSESSED_VALUE3] int  NULL,
    [ASSESSED_VALUE_YEAR3] varchar(30)  NULL,
    [ASSESSED_VALUE3] int  NULL,
    [SALEDATE] varchar(30)  NULL,
    [SALEPRICE] int  NULL,
    [EXEMPTION_VALUE_YEAR1] varchar(4)  NOT NULL,
    [EXEMPTION_VALUE_LAND1] decimal(18,0)  NULL,
    [EXEMPTION_VALUE_IMPROVEMENTS1] decimal(18,0)  NULL,
    [EXEMPTION_VALUE_YEAR2] varchar(4)  NOT NULL,
    [EXEMPTION_VALUE_LAND2] decimal(18,0)  NULL,
    [EXEMPTION_VALUE_IMPROVEMENTS2] decimal(18,0)  NULL,
    [EXEMPTION_VALUE_YEAR3] varchar(4)  NOT NULL,
    [EXEMPTION_VALUE_LAND3] decimal(18,0)  NULL,
    [EXEMPTION_VALUE_IMPROVEMENTS3] decimal(18,0)  NULL,
    [COUNTY] varchar(1)  NULL,
    [ACCOUNT_STATUS_CODE] char(1)  NULL,
    [RATIO_CODE] char(3)  NULL,
    [IS_CONDO] tinyint  NULL,
    [PARENT_ID] varchar(22)  NULL,
    [IS_FAKE_PARENT] tinyint  NULL,
    [SAME_OWNER_SITE_ADDR] int  NULL,
    [X_COORD] int  NULL,
    [Y_COORD] int  NULL
);
GO

-- Creating table 'CCB_DAILY_LICENSES'
CREATE TABLE [dbo].[CCB_DAILY_LICENSES] (
    [license_number] bigint  NOT NULL,
    [registration_type] nvarchar(2)  NULL,
    [county_code] int  NULL,
    [business_name] nvarchar(200)  NULL,
    [address] nvarchar(100)  NULL,
    [city] nvarchar(50)  NULL,
    [state] nvarchar(2)  NULL,
    [zip] nvarchar(15)  NULL,
    [business_telephone] bigint  NULL,
    [fax_number] bigint  NULL,
    [s_11] nvarchar(2000)  NULL,
    [s_12] nvarchar(2000)  NULL,
    [s_13] nvarchar(2000)  NULL,
    [ins_co_name] nvarchar(50)  NULL,
    [ins_amount] bigint  NULL,
    [ins_due_to_exp] datetime  NULL,
    [claims_filed] int  NULL,
    [exempt_nonexempt_status] nvarchar(20)  NULL,
    [sic_codes] nvarchar(175)  NULL,
    [endorsements] nvarchar(50)  NULL,
    [r_bond_co_name] nvarchar(50)  NULL,
    [r_bond_amount] bigint  NULL,
    [r_bond_due_to_exp] datetime  NULL,
    [c_bond_co_name] nvarchar(50)  NULL,
    [c_bond_amount] bigint  NULL,
    [c_bond_due_to_exp] datetime  NULL,
    [rmi_name] nvarchar(55)  NULL,
    [lic_exp_date] datetime  NULL,
    [S_29] nvarchar(2000)  NULL
);
GO

-- Creating table 'sw_user'
CREATE TABLE [dbo].[sw_user] (
    [username] char(32)  NOT NULL,
    [batchlistdays] int  NULL
);
GO

-- Creating table 'sw_posting'
CREATE TABLE [dbo].[sw_posting] (
    [aff_no] int  NOT NULL,
    [qtr_sec] varchar(12)  NULL,
    [map_id] varchar(24)  NULL,
    [post_dt] datetime  NULL,
    [acct_period] int  NULL,
    [property_id] varchar(24)  NULL,
    [property_id2] varchar(24)  NULL,
    [property_desc] varchar(255)  NULL,
    [aff_status] int  NULL,
    [owner_name] varchar(40)  NULL,
    [attn1] varchar(40)  NULL,
    [attn2] varchar(40)  NULL,
    [st_no] varchar(24)  NULL,
    [district] varchar(2)  NULL,
    [st_name] varchar(40)  NULL,
    [designator] varchar(4)  NULL,
    [city] varchar(24)  NULL,
    [zip] varchar(10)  NULL,
    [inspector_no] int  NULL,
    [city_owned_flag] char(1)  NULL,
    [owner_resident_flag] char(1)  NULL,
    [service_req_flag] char(1)  NULL,
    [rep_by_city] char(1)  NULL,
    [rep_by_owner] char(1)  NULL,
    [partial_repair] char(1)  NULL,
    [vacant_lot_flag] char(1)  NULL,
    [vacant_desc] varchar(255)  NULL,
    [repair_dt] datetime  NULL,
    [billed_dt] datetime  NULL,
    [bill_flag] char(1)  NULL,
    [hold_until_dt] datetime  NULL,
    [permit_no] int  NULL,
    [permit_issued] varchar(3)  NULL,
    [permit_extended] char(1)  NULL,
    [date_issued] datetime  NULL,
    [date_expired] datetime  NULL,
    [contractor] varchar(40)  NULL,
    [builder_board_no] varchar(6)  NULL,
    [license_no] varchar(10)  NULL,
    [date_cancelled] datetime  NULL,
    [cancelled_by] varchar(10)  NULL,
    [status] char(1)  NULL,
    [last_action] char(1)  NULL,
    [date_added] datetime  NULL,
    [date_updated] datetime  NULL,
    [notes] varchar(255)  NULL,
    [sent_dt] datetime  NULL,
    [NEW_AFF] varchar(20)  NULL,
    [NEW_RepairDueDate] datetime  NULL,
    [NEW_ClearWalk] bit  NULL
);
GO

-- Creating table 'qip'
CREATE TABLE [dbo].[qip] (
    [OBJECTID] int  NOT NULL,
    [AREA] decimal(14,3)  NULL,
    [PERIMETER] decimal(14,3)  NULL,
    [QTRSEC_] decimal(11,0)  NULL,
    [QTRSEC_ID] decimal(11,0)  NULL,
    [QTRNO] nvarchar(4)  NULL,
    [QTRSEC] nvarchar(7)  NULL,
    [SHIFT] nvarchar(1)  NULL,
    [FULLSEC] nvarchar(1)  NULL,
    [EZONE] nvarchar(1)  NULL,
    [FOURSEC] nvarchar(8)  NULL,
    [QTRNUM] smallint  NULL,
    [TOWN] nvarchar(4)  NULL,
    [SECT] nvarchar(6)  NULL,
    [Shape] int  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id], [property] in table 'dtproperties'
ALTER TABLE [dbo].[dtproperties]
ADD CONSTRAINT [PK_dtproperties]
    PRIMARY KEY CLUSTERED ([id], [property] ASC);
GO

-- Creating primary key on [PermitID] in table 'Permit'
ALTER TABLE [dbo].[Permit]
ADD CONSTRAINT [PK_Permit]
    PRIMARY KEY CLUSTERED ([PermitID] ASC);
GO

-- Creating primary key on [ApplicantID] in table 'PermitApplicant'
ALTER TABLE [dbo].[PermitApplicant]
ADD CONSTRAINT [PK_PermitApplicant]
    PRIMARY KEY CLUSTERED ([ApplicantID] ASC);
GO

-- Creating primary key on [PermitCostID] in table 'PermitCostsDetail'
ALTER TABLE [dbo].[PermitCostsDetail]
ADD CONSTRAINT [PK_PermitCostsDetail]
    PRIMARY KEY CLUSTERED ([PermitCostID] ASC);
GO

-- Creating primary key on [PermitFeeID] in table 'PermitFeeRate'
ALTER TABLE [dbo].[PermitFeeRate]
ADD CONSTRAINT [PK_PermitFeeRate]
    PRIMARY KEY CLUSTERED ([PermitFeeID] ASC);
GO

-- Creating primary key on [PermitHistoryID] in table 'PermitHistory'
ALTER TABLE [dbo].[PermitHistory]
ADD CONSTRAINT [PK_PermitHistory]
    PRIMARY KEY CLUSTERED ([PermitHistoryID] ASC);
GO

-- Creating primary key on [PermitPaymentID] in table 'PermitPayment'
ALTER TABLE [dbo].[PermitPayment]
ADD CONSTRAINT [PK_PermitPayment]
    PRIMARY KEY CLUSTERED ([PermitPaymentID] ASC);
GO

-- Creating primary key on [PermitStatusID] in table 'PermitStatus'
ALTER TABLE [dbo].[PermitStatus]
ADD CONSTRAINT [PK_PermitStatus]
    PRIMARY KEY CLUSTERED ([PermitStatusID] ASC);
GO

-- Creating primary key on [PROPERTY_ID], [MARKET_VALUE_YEAR1], [ASSESSED_VALUE_YEAR1], [MARKET_VALUE_YEAR2], [ASSESSED_VALUE_YEAR2], [EXEMPTION_VALUE_YEAR1], [EXEMPTION_VALUE_YEAR2], [EXEMPTION_VALUE_YEAR3] in table 'ASSESSOR'
ALTER TABLE [dbo].[ASSESSOR]
ADD CONSTRAINT [PK_ASSESSOR]
    PRIMARY KEY CLUSTERED ([PROPERTY_ID], [MARKET_VALUE_YEAR1], [ASSESSED_VALUE_YEAR1], [MARKET_VALUE_YEAR2], [ASSESSED_VALUE_YEAR2], [EXEMPTION_VALUE_YEAR1], [EXEMPTION_VALUE_YEAR2], [EXEMPTION_VALUE_YEAR3] ASC);
GO

-- Creating primary key on [license_number] in table 'CCB_DAILY_LICENSES'
ALTER TABLE [dbo].[CCB_DAILY_LICENSES]
ADD CONSTRAINT [PK_CCB_DAILY_LICENSES]
    PRIMARY KEY CLUSTERED ([license_number] ASC);
GO

-- Creating primary key on [username] in table 'sw_user'
ALTER TABLE [dbo].[sw_user]
ADD CONSTRAINT [PK_sw_user]
    PRIMARY KEY CLUSTERED ([username] ASC);
GO

-- Creating primary key on [aff_no] in table 'sw_posting'
ALTER TABLE [dbo].[sw_posting]
ADD CONSTRAINT [PK_sw_posting]
    PRIMARY KEY CLUSTERED ([aff_no] ASC);
GO

-- Creating primary key on [OBJECTID] in table 'qip'
ALTER TABLE [dbo].[qip]
ADD CONSTRAINT [PK_qip]
    PRIMARY KEY CLUSTERED ([OBJECTID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ApplicantID] in table 'Permit'
ALTER TABLE [dbo].[Permit]
ADD CONSTRAINT [FK_Permit_PermitApplicant]
    FOREIGN KEY ([ApplicantID])
    REFERENCES [dbo].[PermitApplicant]
        ([ApplicantID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Permit_PermitApplicant'
CREATE INDEX [IX_FK_Permit_PermitApplicant]
ON [dbo].[Permit]
    ([ApplicantID]);
GO

-- Creating foreign key on [PermitStatus] in table 'Permit'
ALTER TABLE [dbo].[Permit]
ADD CONSTRAINT [FK_Permit_PermitStatus]
    FOREIGN KEY ([PermitStatus])
    REFERENCES [dbo].[PermitStatus]
        ([PermitStatusID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Permit_PermitStatus'
CREATE INDEX [IX_FK_Permit_PermitStatus]
ON [dbo].[Permit]
    ([PermitStatus]);
GO

-- Creating foreign key on [PermitID] in table 'PermitHistory'
ALTER TABLE [dbo].[PermitHistory]
ADD CONSTRAINT [FK_PermitHistory_Permit]
    FOREIGN KEY ([PermitID])
    REFERENCES [dbo].[Permit]
        ([PermitID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PermitHistory_Permit'
CREATE INDEX [IX_FK_PermitHistory_Permit]
ON [dbo].[PermitHistory]
    ([PermitID]);
GO

-- Creating foreign key on [PermitID] in table 'PermitPayment'
ALTER TABLE [dbo].[PermitPayment]
ADD CONSTRAINT [FK_PermitPayment_Permit]
    FOREIGN KEY ([PermitID])
    REFERENCES [dbo].[Permit]
        ([PermitID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PermitPayment_Permit'
CREATE INDEX [IX_FK_PermitPayment_Permit]
ON [dbo].[PermitPayment]
    ([PermitID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------