delete from ActiveTimers
delete from ClientMatterBatches
delete from ClientBatches
delete from SearchEngineUserPreferences

delete from Errors
delete from notes
delete from emails
delete from TodoItems
delete from conversations
delete from PhoneMessages
delete from MattersCalendarEntries_Statutes
delete from CalendarEntriesUsers
delete from CalendarEntries
delete from Documents

delete from CommunicatorChannelMessages
delete from CommunicatorChannels
delete from CommunicatorMessages

delete from InvoicedActivityAmounts
delete from Activities

delete from BillingAudits
delete from PaymentsInvoices
delete from LedgerEntries where ID > 0
delete from Invoices where ID > 0


delete from MatterFieldSelectOptions
delete from MattersCustomFields
delete from MatterFields


delete from ContactFieldSelectOptions
delete from ContactsCustomFields
delete from ContactFields


delete from ContactsMatters

delete from UserRecentMatters

delete from MatterTrustAccounts where MatterID > 0
delete from MatterBudget where MatterID > 0
delete from MatterEvents
Update Matters set CurrentMatterWorkFlowStatusHistoryId = null
delete from  MatterWorkFlowStatusHistory
delete from Matters where ID > 0


delete from ClientTrustLedgerEntries
delete from ClientTrustAccounts where ClientId >= 2
delete from Clients where ID >= 2


delete from DocumentTemplates

delete from UserRates where UserID in (
	select ID from Users where UserName not in ('NULLUSER', 'RocketAdmin')
) 

delete from UsersPreferences
delete from TargetHours
delete from Logins
delete from AtlasUserRoles where UserId in (
	select ID from Users where UserName not in ('NULLUSER', 'RocketAdmin')
)
delete from UsersRoles where UserId in (
	select ID from Users where UserName not in ('NULLUSER', 'RocketAdmin')
)

delete from Users where UserName not in ('NULLUSER', 'RocketAdmin')
delete from Contacts where ID > 0 and ID not in(select Id from Users) and ID not in (Select ContactID from Clients) and ID not in (Select ContactID from Firm)

delete from WorkflowPracticeArea where Name <> 'Default' and Name != 'New Matter Type'


