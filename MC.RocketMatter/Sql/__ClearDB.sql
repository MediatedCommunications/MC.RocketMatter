delete from Errors

delete from ContactsMatters
delete from Matters where ID > 0
delete from Clients where ID >= 2
delete from ClientTrustAccounts where ClientId >= 2
delete from MattersCustomFields
delete from MatterEvents
delete from MatterBudget where MatterID > 0
delete from MatterTrustAccounts
delete from UserRecentMatters
delete from notes
delete from emails
delete from CalendarEntriesUsers
delete from CalendarEntries
delete from TodoItems
delete from conversations
delete from PhoneMessages
delete from Documents
delete from Activities

delete from ContactsCustomFields

delete from CommunicatorChannels
delete from CommunicatorChannelMessages
delete from CommunicatorMessages

delete from BillingAudits
delete from matters where ID > 0
delete from LedgerEntries




delete from UserRates
delete from UsersPreferences
delete from TargetHours
delete from TargetHours
delete from Logins
delete from Users where ID >= 3
delete from Firm
delete from Contacts where ID > 0 and ID not in(select Id from Users) and ID not in (Select ContactID from Clients)

delete from MattersCalendarEntries_Statutes


