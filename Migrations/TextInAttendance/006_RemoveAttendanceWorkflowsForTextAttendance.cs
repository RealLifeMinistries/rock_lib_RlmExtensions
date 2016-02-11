﻿using Rock.Plugin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.reallifeministries.RockExtensions.Migrations
{
    [MigrationNumber(8, "1.2.0")]
    class _006_RemoveAttendanceWorkflowsForTextAttendance : Migration
    {
        public override void Down()
        {
            
        }

        public override void Up()
        {
            RockMigrationHelper.UpdateEntityType("Rock.Model.Workflow", "3540E9A7-FE30-43A9-8B0A-A372B63DFC93", true, true);
            RockMigrationHelper.UpdateEntityType("Rock.Model.WorkflowActivity", "2CB52ED0-CB06-4D62-9E2C-73B60AFA4C9F", true, true);
            RockMigrationHelper.UpdateEntityType("Rock.Model.WorkflowActionType", "23E3273A-B137-48A3-9AFF-C8DC832DDCA6", true, true);
            RockMigrationHelper.UpdateEntityType("com.reallifeministries.RockExtensions.Workflow.Action.RemoveLastAttendanceFromPerson", "935CC5E6-DDFB-48C3-816D-892AF2EE2A19", false, true);
            RockMigrationHelper.UpdateEntityType("com.reallifeministries.RockExtensions.Workflow.Action.SetAttributeFromPersonLava", "85D1DBFE-9F3F-486A-BF2C-60146A8D97F8", false, true);
            RockMigrationHelper.UpdateEntityType("com.reallifeministries.RockExtensions.Workflow.Action.ValidateAttendanceCode", "550458E4-BBBF-4E47-955E-1DBE79352E7D", false, true);
            RockMigrationHelper.UpdateEntityType("Rock.Workflow.Action.ActivateActivity", "38907A90-1634-4A93-8017-619326A4A582", false, true);
            RockMigrationHelper.UpdateEntityType("Rock.Workflow.Action.SetAttributeToInitiator", "4EEAC6FA-B838-410B-A8DD-21A364029F5D", false, true);
            RockMigrationHelper.UpdateEntityType("Rock.Workflow.Action.SetAttributeValue", "C789E457-0783-44B3-9D8F-2EBAB5F11110", false, true);
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("38907A90-1634-4A93-8017-619326A4A582", "1EDAFDED-DFE6-4334-B019-6EECBA89E05A", "Active", "Active", "Should Service be used?", 0, @"False", "E8ABD802-372C-47BE-82B1-96F50DB5169E"); // Rock.Workflow.Action.ActivateActivity:Active
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("38907A90-1634-4A93-8017-619326A4A582", "739FD425-5B8C-4605-B775-7E4D9D4C11DB", "Activity", "Activity", "The activity type to activate", 0, @"", "02D5A7A5-8781-46B4-B9FC-AF816829D240"); // Rock.Workflow.Action.ActivateActivity:Activity
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("38907A90-1634-4A93-8017-619326A4A582", "A75DFC58-7A1B-4799-BF31-451B2BBE38FF", "Order", "Order", "The order that this service should be used (priority)", 0, @"", "3809A78C-B773-440C-8E3F-A8E81D0DAE08"); // Rock.Workflow.Action.ActivateActivity:Order
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("4EEAC6FA-B838-410B-A8DD-21A364029F5D", "1EDAFDED-DFE6-4334-B019-6EECBA89E05A", "Active", "Active", "Should Service be used?", 0, @"False", "7A7B2369-901E-4838-852F-2AB42ABC9EBA"); // Rock.Workflow.Action.SetAttributeToInitiator:Active
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("4EEAC6FA-B838-410B-A8DD-21A364029F5D", "33E6DF69-BDFA-407A-9744-C175B60643AE", "Person Attribute", "PersonAttribute", "The attribute to set to the initiator.", 0, @"", "047336EA-EA6F-46D7-9F32-FB67D2C9DA32"); // Rock.Workflow.Action.SetAttributeToInitiator:Person Attribute
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("4EEAC6FA-B838-410B-A8DD-21A364029F5D", "A75DFC58-7A1B-4799-BF31-451B2BBE38FF", "Order", "Order", "The order that this service should be used (priority)", 0, @"", "8960D3B2-25B4-41BD-84D8-2C88779271F4"); // Rock.Workflow.Action.SetAttributeToInitiator:Order
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("550458E4-BBBF-4E47-955E-1DBE79352E7D", "1EDAFDED-DFE6-4334-B019-6EECBA89E05A", "Active", "Active", "Should Service be used?", 0, @"False", "C9FC261D-84BF-41F7-9636-734EAAF0FD86"); // com.reallifeministries.RockExtensions.Workflow.Action.ValidateAttendanceCode:Active
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("550458E4-BBBF-4E47-955E-1DBE79352E7D", "9C204CD0-1233-41C5-818A-C5DA439445AA", "UserInputCode", "UserInputCode", "The code submitted by the user", 0, @"", "0FC7338D-F75D-401F-8F03-ADDA92315A3B"); // com.reallifeministries.RockExtensions.Workflow.Action.ValidateAttendanceCode:UserInputCode
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("550458E4-BBBF-4E47-955E-1DBE79352E7D", "A75DFC58-7A1B-4799-BF31-451B2BBE38FF", "Order", "Order", "The order that this service should be used (priority)", 0, @"", "18BA2FE7-7620-42CE-8FD8-727A26683B81"); // com.reallifeministries.RockExtensions.Workflow.Action.ValidateAttendanceCode:Order
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("85D1DBFE-9F3F-486A-BF2C-60146A8D97F8", "1EDAFDED-DFE6-4334-B019-6EECBA89E05A", "Active", "Active", "Should Service be used?", 0, @"False", "8DE0F372-4B1C-4612-B318-E598E4CC17F8"); // com.reallifeministries.RockExtensions.Workflow.Action.SetAttributeFromPersonLava:Active
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("85D1DBFE-9F3F-486A-BF2C-60146A8D97F8", "33E6DF69-BDFA-407A-9744-C175B60643AE", "Attribute", "Attribute", "The workflow attribute you will be setting", 0, @"", "40FF47A2-9682-4545-BDF3-171B5F6B8A5C"); // com.reallifeministries.RockExtensions.Workflow.Action.SetAttributeFromPersonLava:Attribute
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("85D1DBFE-9F3F-486A-BF2C-60146A8D97F8", "33E6DF69-BDFA-407A-9744-C175B60643AE", "PersonAttribute", "PersonAttribute", "The workflow attribute containing the person.", 0, @"", "CF19BB9A-EA5B-43E5-89A1-FA416F430761"); // com.reallifeministries.RockExtensions.Workflow.Action.SetAttributeFromPersonLava:PersonAttribute
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("85D1DBFE-9F3F-486A-BF2C-60146A8D97F8", "9C204CD0-1233-41C5-818A-C5DA439445AA", "Lava", "Lava", "Lava to use when setting the attribute.  Normal Workflow merge fields will be available, as well as: {{Person}} which will be the Person model corresponding to the selected Person Attribute", 0, @"", "52930E88-A86E-47AE-BB1D-9937692BBF74"); // com.reallifeministries.RockExtensions.Workflow.Action.SetAttributeFromPersonLava:Lava
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("85D1DBFE-9F3F-486A-BF2C-60146A8D97F8", "A75DFC58-7A1B-4799-BF31-451B2BBE38FF", "Order", "Order", "The order that this service should be used (priority)", 0, @"", "E7527DBD-32B1-47CE-8D22-142EDE32BD7D"); // com.reallifeministries.RockExtensions.Workflow.Action.SetAttributeFromPersonLava:Order
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("935CC5E6-DDFB-48C3-816D-892AF2EE2A19", "1EDAFDED-DFE6-4334-B019-6EECBA89E05A", "Active", "Active", "Should Service be used?", 0, @"False", "FEC77FF4-3395-4D8B-919E-DD0EFBC91B87"); // com.reallifeministries.RockExtensions.Workflow.Action.RemoveLastAttendanceFromPerson:Active
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("935CC5E6-DDFB-48C3-816D-892AF2EE2A19", "33E6DF69-BDFA-407A-9744-C175B60643AE", "PersonAttribute", "PersonAttribute", "The workflow attribute containing the person.", 0, @"", "C53D4FFF-17E3-4664-A7A8-CADBC990A42A"); // com.reallifeministries.RockExtensions.Workflow.Action.RemoveLastAttendanceFromPerson:PersonAttribute
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("935CC5E6-DDFB-48C3-816D-892AF2EE2A19", "A75DFC58-7A1B-4799-BF31-451B2BBE38FF", "Order", "Order", "The order that this service should be used (priority)", 0, @"", "98757E75-86DA-4170-B71A-ECAB9F29DB59"); // com.reallifeministries.RockExtensions.Workflow.Action.RemoveLastAttendanceFromPerson:Order
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("C789E457-0783-44B3-9D8F-2EBAB5F11110", "1EDAFDED-DFE6-4334-B019-6EECBA89E05A", "Active", "Active", "Should Service be used?", 0, @"False", "D7EAA859-F500-4521-9523-488B12EAA7D2"); // Rock.Workflow.Action.SetAttributeValue:Active
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("C789E457-0783-44B3-9D8F-2EBAB5F11110", "33E6DF69-BDFA-407A-9744-C175B60643AE", "Attribute", "Attribute", "The attribute to set the value of.", 0, @"", "44A0B977-4730-4519-8FF6-B0A01A95B212"); // Rock.Workflow.Action.SetAttributeValue:Attribute
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("C789E457-0783-44B3-9D8F-2EBAB5F11110", "3B1D93D7-9414-48F9-80E5-6A3FC8F94C20", "Text Value|Attribute Value", "Value", "The text or attribute to set the value from. <span class='tip tip-lava'></span>", 1, @"", "E5272B11-A2B8-49DC-860D-8D574E2BC15C"); // Rock.Workflow.Action.SetAttributeValue:Text Value|Attribute Value
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("C789E457-0783-44B3-9D8F-2EBAB5F11110", "A75DFC58-7A1B-4799-BF31-451B2BBE38FF", "Order", "Order", "The order that this service should be used (priority)", 0, @"", "57093B41-50ED-48E5-B72B-8829E62704C8"); // Rock.Workflow.Action.SetAttributeValue:Order
            RockMigrationHelper.UpdateWorkflowType(false, true, "Text Remove Attendance Record", "Number '5' in the text attendance system", "BF7F6EDD-1AA6-442C-BBE2-226591F78D4C", "Work", "fa fa-list-ol", 0, true, 0, "A74396B8-4723-4BE7-9F4A-14506C921FC8"); // Text Remove Attendance Record
            RockMigrationHelper.UpdateWorkflowTypeAttribute("A74396B8-4723-4BE7-9F4A-14506C921FC8", "E4EAB7B2-0B76-429B-AFE4-AD86D7428C70", "FromPerson", "FromPerson", "", 0, @"", "38C52F6F-E08A-4FCF-BD87-AEA0F7C50CC1"); // Text Remove Attendance Record:FromPerson
            RockMigrationHelper.UpdateWorkflowTypeAttribute("A74396B8-4723-4BE7-9F4A-14506C921FC8", "9C204CD0-1233-41C5-818A-C5DA439445AA", "FromPersonAttendanceCode", "FromPersonAttendanceCode", "", 1, @"", "8F7DEFBC-9B37-41C8-93FA-6896FE9703AD"); // Text Remove Attendance Record:FromPersonAttendanceCode
            RockMigrationHelper.UpdateWorkflowTypeAttribute("A74396B8-4723-4BE7-9F4A-14506C921FC8", "9C204CD0-1233-41C5-818A-C5DA439445AA", "AttendanceKey", "AttendanceKey", "", 3, @"", "6C319361-6841-4A22-9EA3-CFDDBBDB469E"); // Text Remove Attendance Record:AttendanceKey
            RockMigrationHelper.UpdateWorkflowTypeAttribute("A74396B8-4723-4BE7-9F4A-14506C921FC8", "9C204CD0-1233-41C5-818A-C5DA439445AA", "AttendanceCode", "AttendanceCode", "", 4, @"", "D3B602DA-25A0-41E0-8624-2047EC8C2D4C"); // Text Remove Attendance Record:AttendanceCode
            RockMigrationHelper.UpdateWorkflowTypeAttribute("A74396B8-4723-4BE7-9F4A-14506C921FC8", "9C204CD0-1233-41C5-818A-C5DA439445AA", "FromPhone", "FromPhone", "", 2, @"", "5062C47D-5572-4629-8881-1C51E09BC8A4"); // Text Remove Attendance Record:FromPhone
            RockMigrationHelper.UpdateWorkflowTypeAttribute("A74396B8-4723-4BE7-9F4A-14506C921FC8", "9C204CD0-1233-41C5-818A-C5DA439445AA", "SMSResponse", "SMSResponse", "", 5, @"", "FDFD5160-C2C0-4DA1-8131-FE7BE65C677B"); // Text Remove Attendance Record:SMSResponse
            RockMigrationHelper.AddAttributeQualifier("8F7DEFBC-9B37-41C8-93FA-6896FE9703AD", "ispassword", @"False", "CF17CB45-FF85-4AE9-A2E1-96A5314D4247"); // Text Remove Attendance Record:FromPersonAttendanceCode:ispassword
            RockMigrationHelper.AddAttributeQualifier("6C319361-6841-4A22-9EA3-CFDDBBDB469E", "ispassword", @"False", "482D3353-37F7-4F90-97D0-4F136E3CFCF7"); // Text Remove Attendance Record:AttendanceKey:ispassword
            RockMigrationHelper.AddAttributeQualifier("D3B602DA-25A0-41E0-8624-2047EC8C2D4C", "ispassword", @"False", "3E41C5BA-594E-422E-A4E0-94CD3EBF19DD"); // Text Remove Attendance Record:AttendanceCode:ispassword
            RockMigrationHelper.AddAttributeQualifier("5062C47D-5572-4629-8881-1C51E09BC8A4", "ispassword", @"False", "A6EBCFAB-8C1F-4DC5-8438-7C92ECF215F6"); // Text Remove Attendance Record:FromPhone:ispassword
            RockMigrationHelper.AddAttributeQualifier("FDFD5160-C2C0-4DA1-8131-FE7BE65C677B", "ispassword", @"False", "AC4D29DD-137D-414B-9D4A-8E2DB82E00A5"); // Text Remove Attendance Record:SMSResponse:ispassword
            RockMigrationHelper.UpdateWorkflowActivityType("A74396B8-4723-4BE7-9F4A-14506C921FC8", true, "Validate Attendance Code", "validates a correct attendance code", true, 0, "70A5E5F0-F8DD-4D2C-ABE1-885F1D83D711"); // Text Remove Attendance Record:Validate Attendance Code
            RockMigrationHelper.UpdateWorkflowActivityType("A74396B8-4723-4BE7-9F4A-14506C921FC8", true, "Remove From Current Attendance", "Removes the person from the current attendance", false, 1, "C255985A-A395-4975-8AB6-3910CC88A31C"); // Text Remove Attendance Record:Remove From Current Attendance
            RockMigrationHelper.UpdateWorkflowActionType("70A5E5F0-F8DD-4D2C-ABE1-885F1D83D711", "Activate Remove From Attendance", 3, "38907A90-1634-4A93-8017-619326A4A582", true, false, "", "D3B602DA-25A0-41E0-8624-2047EC8C2D4C", 64, "", "DD4E1E3C-66E8-4462-96C8-59FBB912C210"); // Text Remove Attendance Record:Validate Attendance Code:Activate Remove From Attendance
            RockMigrationHelper.UpdateWorkflowActionType("C255985A-A395-4975-8AB6-3910CC88A31C", "Send SMS Message", 1, "C789E457-0783-44B3-9D8F-2EBAB5F11110", true, false, "", "", 1, "", "8341ED44-451B-4BA8-BAAC-85FC64E779E4"); // Text Remove Attendance Record:Remove From Current Attendance:Send SMS Message
            RockMigrationHelper.UpdateWorkflowActionType("70A5E5F0-F8DD-4D2C-ABE1-885F1D83D711", "initiate person", 0, "4EEAC6FA-B838-410B-A8DD-21A364029F5D", true, false, "", "", 1, "", "50FAAFF9-C24B-4E80-9E93-BC6A5AE98727"); // Text Remove Attendance Record:Validate Attendance Code:initiate person
            RockMigrationHelper.UpdateWorkflowActionType("70A5E5F0-F8DD-4D2C-ABE1-885F1D83D711", "get Attendance Code from Person", 1, "85D1DBFE-9F3F-486A-BF2C-60146A8D97F8", true, false, "", "", 1, "", "EAF92D28-EA7E-4A55-9280-3EAB8742C6E5"); // Text Remove Attendance Record:Validate Attendance Code:get Attendance Code from Person
            RockMigrationHelper.UpdateWorkflowActionType("C255985A-A395-4975-8AB6-3910CC88A31C", "Remove Last Attendance From person", 0, "935CC5E6-DDFB-48C3-816D-892AF2EE2A19", true, false, "", "", 1, "", "5FC8D82D-EFBF-457E-8416-03CB6E17C695"); // Text Remove Attendance Record:Remove From Current Attendance:Remove Last Attendance From person
            RockMigrationHelper.UpdateWorkflowActionType("70A5E5F0-F8DD-4D2C-ABE1-885F1D83D711", "Validate code", 2, "550458E4-BBBF-4E47-955E-1DBE79352E7D", true, false, "", "", 1, "", "4F52CFA6-AF2E-4DA9-86B1-FA074F21BE65"); // Text Remove Attendance Record:Validate Attendance Code:Validate code
            RockMigrationHelper.AddActionTypeAttributeValue("50FAAFF9-C24B-4E80-9E93-BC6A5AE98727", "7A7B2369-901E-4838-852F-2AB42ABC9EBA", @"False"); // Text Remove Attendance Record:Validate Attendance Code:initiate person:Active
            RockMigrationHelper.AddActionTypeAttributeValue("50FAAFF9-C24B-4E80-9E93-BC6A5AE98727", "047336EA-EA6F-46D7-9F32-FB67D2C9DA32", @"38c52f6f-e08a-4fcf-bd87-aea0f7c50cc1"); // Text Remove Attendance Record:Validate Attendance Code:initiate person:Person Attribute
            RockMigrationHelper.AddActionTypeAttributeValue("50FAAFF9-C24B-4E80-9E93-BC6A5AE98727", "8960D3B2-25B4-41BD-84D8-2C88779271F4", @""); // Text Remove Attendance Record:Validate Attendance Code:initiate person:Order
            RockMigrationHelper.AddActionTypeAttributeValue("EAF92D28-EA7E-4A55-9280-3EAB8742C6E5", "CF19BB9A-EA5B-43E5-89A1-FA416F430761", @"38c52f6f-e08a-4fcf-bd87-aea0f7c50cc1"); // Text Remove Attendance Record:Validate Attendance Code:get Attendance Code from Person:PersonAttribute
            RockMigrationHelper.AddActionTypeAttributeValue("EAF92D28-EA7E-4A55-9280-3EAB8742C6E5", "40FF47A2-9682-4545-BDF3-171B5F6B8A5C", @"8f7defbc-9b37-41c8-93fa-6896fe9703ad"); // Text Remove Attendance Record:Validate Attendance Code:get Attendance Code from Person:Attribute
            RockMigrationHelper.AddActionTypeAttributeValue("EAF92D28-EA7E-4A55-9280-3EAB8742C6E5", "52930E88-A86E-47AE-BB1D-9937692BBF74", @"{{ Person.LastAttendanceCode }}"); // Text Remove Attendance Record:Validate Attendance Code:get Attendance Code from Person:Lava
            RockMigrationHelper.AddActionTypeAttributeValue("EAF92D28-EA7E-4A55-9280-3EAB8742C6E5", "E7527DBD-32B1-47CE-8D22-142EDE32BD7D", @""); // Text Remove Attendance Record:Validate Attendance Code:get Attendance Code from Person:Order
            RockMigrationHelper.AddActionTypeAttributeValue("EAF92D28-EA7E-4A55-9280-3EAB8742C6E5", "8DE0F372-4B1C-4612-B318-E598E4CC17F8", @"False"); // Text Remove Attendance Record:Validate Attendance Code:get Attendance Code from Person:Active
            RockMigrationHelper.AddActionTypeAttributeValue("4F52CFA6-AF2E-4DA9-86B1-FA074F21BE65", "C9FC261D-84BF-41F7-9636-734EAAF0FD86", @"False"); // Text Remove Attendance Record:Validate Attendance Code:Validate code:Active
            RockMigrationHelper.AddActionTypeAttributeValue("4F52CFA6-AF2E-4DA9-86B1-FA074F21BE65", "0FC7338D-F75D-401F-8F03-ADDA92315A3B", @"{{Workflow.FromPersonAttendanceCode}}"); // Text Remove Attendance Record:Validate Attendance Code:Validate code:UserInputCode
            RockMigrationHelper.AddActionTypeAttributeValue("4F52CFA6-AF2E-4DA9-86B1-FA074F21BE65", "18BA2FE7-7620-42CE-8FD8-727A26683B81", @""); // Text Remove Attendance Record:Validate Attendance Code:Validate code:Order
            RockMigrationHelper.AddActionTypeAttributeValue("DD4E1E3C-66E8-4462-96C8-59FBB912C210", "E8ABD802-372C-47BE-82B1-96F50DB5169E", @"False"); // Text Remove Attendance Record:Validate Attendance Code:Activate Remove From Attendance:Active
            RockMigrationHelper.AddActionTypeAttributeValue("DD4E1E3C-66E8-4462-96C8-59FBB912C210", "3809A78C-B773-440C-8E3F-A8E81D0DAE08", @""); // Text Remove Attendance Record:Validate Attendance Code:Activate Remove From Attendance:Order
            RockMigrationHelper.AddActionTypeAttributeValue("DD4E1E3C-66E8-4462-96C8-59FBB912C210", "02D5A7A5-8781-46B4-B9FC-AF816829D240", @"C255985A-A395-4975-8AB6-3910CC88A31C"); // Text Remove Attendance Record:Validate Attendance Code:Activate Remove From Attendance:Activity
            RockMigrationHelper.AddActionTypeAttributeValue("5FC8D82D-EFBF-457E-8416-03CB6E17C695", "FEC77FF4-3395-4D8B-919E-DD0EFBC91B87", @"False"); // Text Remove Attendance Record:Remove From Current Attendance:Remove Last Attendance From person:Active
            RockMigrationHelper.AddActionTypeAttributeValue("5FC8D82D-EFBF-457E-8416-03CB6E17C695", "C53D4FFF-17E3-4664-A7A8-CADBC990A42A", @"38c52f6f-e08a-4fcf-bd87-aea0f7c50cc1"); // Text Remove Attendance Record:Remove From Current Attendance:Remove Last Attendance From person:PersonAttribute
            RockMigrationHelper.AddActionTypeAttributeValue("5FC8D82D-EFBF-457E-8416-03CB6E17C695", "98757E75-86DA-4170-B71A-ECAB9F29DB59", @""); // Text Remove Attendance Record:Remove From Current Attendance:Remove Last Attendance From person:Order
            RockMigrationHelper.AddActionTypeAttributeValue("8341ED44-451B-4BA8-BAAC-85FC64E779E4", "D7EAA859-F500-4521-9523-488B12EAA7D2", @"False"); // Text Remove Attendance Record:Remove From Current Attendance:Send SMS Message:Active
            RockMigrationHelper.AddActionTypeAttributeValue("8341ED44-451B-4BA8-BAAC-85FC64E779E4", "44A0B977-4730-4519-8FF6-B0A01A95B212", @"fdfd5160-c2c0-4da1-8131-fe7be65c677b"); // Text Remove Attendance Record:Remove From Current Attendance:Send SMS Message:Attribute
            RockMigrationHelper.AddActionTypeAttributeValue("8341ED44-451B-4BA8-BAAC-85FC64E779E4", "57093B41-50ED-48E5-B72B-8829E62704C8", @""); // Text Remove Attendance Record:Remove From Current Attendance:Send SMS Message:Order
            RockMigrationHelper.AddActionTypeAttributeValue("8341ED44-451B-4BA8-BAAC-85FC64E779E4", "E5272B11-A2B8-49DC-860D-8D574E2BC15C", @"Thank you. Please remember to fill out a connection card."); // Text Remove Attendance Record:Remove From Current Attendance:Send SMS Message:Text Value|Attribute Value
        }
    }
}
