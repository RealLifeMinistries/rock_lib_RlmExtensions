﻿using Rock.Model;
using Rock.Plugin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.reallifeministries.RockExtensions.Migrations
{
    [MigrationNumber(3, "1.2.0")]
    class _001_StartWorkflowsForTextAttendance : Migration
    {
        public override void Down()
        {
            
        }

        public override void Up()
        {               
            RockMigrationHelper.UpdateEntityType("Rock.Model.Workflow", "3540E9A7-FE30-43A9-8B0A-A372B63DFC93", true, true);
            RockMigrationHelper.UpdateEntityType("Rock.Model.WorkflowActivity", "2CB52ED0-CB06-4D62-9E2C-73B60AFA4C9F", true, true);
            RockMigrationHelper.UpdateEntityType("Rock.Model.WorkflowActionType", "23E3273A-B137-48A3-9AFF-C8DC832DDCA6", true, true);
            RockMigrationHelper.UpdateEntityType("com.reallifeministries.RockExtensions.Workflow.Action.CheckInPersonToGroup", "34B9F1A4-7884-4083-A345-0FE164565AA9", false, true);
            RockMigrationHelper.UpdateEntityType("com.reallifeministries.RockExtensions.Workflow.Action.SetAttributeFromPersonLava", "85D1DBFE-9F3F-486A-BF2C-60146A8D97F8", false, true);
            RockMigrationHelper.UpdateEntityType("com.reallifeministries.RockExtensions.Workflow.Action.ValidateAttendanceCode", "550458E4-BBBF-4E47-955E-1DBE79352E7D", false, true);
            RockMigrationHelper.UpdateEntityType("Rock.Workflow.Action.ActivateActivity", "38907A90-1634-4A93-8017-619326A4A582", false, true);
            RockMigrationHelper.UpdateEntityType("Rock.Workflow.Action.RunSQL", "A41216D6-6FB0-4019-B222-2C29B4519CF4", false, true);
            RockMigrationHelper.UpdateEntityType("Rock.Workflow.Action.SetAttributeToInitiator", "4EEAC6FA-B838-410B-A8DD-21A364029F5D", false, true);
            RockMigrationHelper.UpdateEntityType("Rock.Workflow.Action.SetAttributeValue", "C789E457-0783-44B3-9D8F-2EBAB5F11110", false, true);
            RockMigrationHelper.UpdateEntityType("Rock.Workflow.Action.SetPersonAttribute", "320622DA-52E0-41AE-AF90-2BF78B488552", false, true);
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("320622DA-52E0-41AE-AF90-2BF78B488552", "1EDAFDED-DFE6-4334-B019-6EECBA89E05A", "Active", "Active", "Should Service be used?", 0, @"False", "E5BAC4A6-FF7F-4016-BA9C-72D16CB60184"); // Rock.Workflow.Action.SetPersonAttribute:Active
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("320622DA-52E0-41AE-AF90-2BF78B488552", "33E6DF69-BDFA-407A-9744-C175B60643AE", "Person", "Person", "Workflow attribute that contains the person to update.", 0, @"", "E456FB6F-05DB-4826-A612-5B704BC4EA13"); // Rock.Workflow.Action.SetPersonAttribute:Person
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("320622DA-52E0-41AE-AF90-2BF78B488552", "3B1D93D7-9414-48F9-80E5-6A3FC8F94C20", "Value|Attribute Value", "Value", "The value or attribute value to set the person attribute to. <span class='tip tip-lava'></span>", 2, @"", "94689BDE-493E-4869-A614-2D54822D747C"); // Rock.Workflow.Action.SetPersonAttribute:Value|Attribute Value
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("320622DA-52E0-41AE-AF90-2BF78B488552", "99B090AA-4D7E-46D8-B393-BF945EA1BA8B", "Person Attribute", "PersonAttribute", "The person attribute that should be updated with the provided value.", 1, @"", "8F4BB00F-7FA2-41AD-8E90-81F4DFE2C762"); // Rock.Workflow.Action.SetPersonAttribute:Person Attribute
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("320622DA-52E0-41AE-AF90-2BF78B488552", "A75DFC58-7A1B-4799-BF31-451B2BBE38FF", "Order", "Order", "The order that this service should be used (priority)", 0, @"", "3F3BF3E6-AD53-491E-A40F-441F2AFCBB5B"); // Rock.Workflow.Action.SetPersonAttribute:Order
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("34B9F1A4-7884-4083-A345-0FE164565AA9", "1EDAFDED-DFE6-4334-B019-6EECBA89E05A", "Active", "Active", "Should Service be used?", 0, @"False", "C8AB1F08-B94A-4A05-B0CC-7A315279D0A1"); // com.reallifeministries.RockExtensions.Workflow.Action.CheckInPersonToGroup:Active
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("34B9F1A4-7884-4083-A345-0FE164565AA9", "33E6DF69-BDFA-407A-9744-C175B60643AE", "Attendance Date/Time", "AttendanceDatetime", "The attribute with the date time to use for the attendance. Leave blank to use the current date time.", 2, @"", "82C801A7-0C15-437F-BF53-30ECC451289E"); // com.reallifeministries.RockExtensions.Workflow.Action.CheckInPersonToGroup:Attendance Date/Time
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("34B9F1A4-7884-4083-A345-0FE164565AA9", "33E6DF69-BDFA-407A-9744-C175B60643AE", "Campus", "Campus", "The attribute to set to the Campus of the attendance ", 3, @"", "907C1D7C-DB12-472B-83B1-56F473C1AC16"); // com.reallifeministries.RockExtensions.Workflow.Action.CheckInPersonToGroup:Campus
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("34B9F1A4-7884-4083-A345-0FE164565AA9", "33E6DF69-BDFA-407A-9744-C175B60643AE", "Group", "Group", "The attribute containing the group to get the leader for.", 0, @"", "C78E85FE-D7FC-445A-A177-22122C468EB0"); // com.reallifeministries.RockExtensions.Workflow.Action.CheckInPersonToGroup:Group
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("34B9F1A4-7884-4083-A345-0FE164565AA9", "33E6DF69-BDFA-407A-9744-C175B60643AE", "Person", "Person", "The attribute to set to the person in the group.", 1, @"", "01AC3A18-01E2-41B7-8601-2B2789381D92"); // com.reallifeministries.RockExtensions.Workflow.Action.CheckInPersonToGroup:Person
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("34B9F1A4-7884-4083-A345-0FE164565AA9", "A75DFC58-7A1B-4799-BF31-451B2BBE38FF", "Order", "Order", "The order that this service should be used (priority)", 0, @"", "BD134939-44F1-4E4B-B420-0D049334A3DF"); // com.reallifeministries.RockExtensions.Workflow.Action.CheckInPersonToGroup:Order
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
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("A41216D6-6FB0-4019-B222-2C29B4519CF4", "1D0D3794-C210-48A8-8C68-3FBEC08A6BA5", "SQLQuery", "SQLQuery", "The SQL query to run. <span class='tip tip-lava'></span>", 0, @"", "F3B9908B-096F-460B-8320-122CF046D1F9"); // Rock.Workflow.Action.RunSQL:SQLQuery
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("A41216D6-6FB0-4019-B222-2C29B4519CF4", "1EDAFDED-DFE6-4334-B019-6EECBA89E05A", "Active", "Active", "Should Service be used?", 0, @"False", "A18C3143-0586-4565-9F36-E603BC674B4E"); // Rock.Workflow.Action.RunSQL:Active
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("A41216D6-6FB0-4019-B222-2C29B4519CF4", "33E6DF69-BDFA-407A-9744-C175B60643AE", "Result Attribute", "ResultAttribute", "An optional attribute to set to the scaler result of SQL query.", 1, @"", "56997192-2545-4EA1-B5B2-313B04588984"); // Rock.Workflow.Action.RunSQL:Result Attribute
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("A41216D6-6FB0-4019-B222-2C29B4519CF4", "A75DFC58-7A1B-4799-BF31-451B2BBE38FF", "Order", "Order", "The order that this service should be used (priority)", 0, @"", "FA7C685D-8636-41EF-9998-90FFF3998F76"); // Rock.Workflow.Action.RunSQL:Order
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("C789E457-0783-44B3-9D8F-2EBAB5F11110", "1EDAFDED-DFE6-4334-B019-6EECBA89E05A", "Active", "Active", "Should Service be used?", 0, @"False", "D7EAA859-F500-4521-9523-488B12EAA7D2"); // Rock.Workflow.Action.SetAttributeValue:Active
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("C789E457-0783-44B3-9D8F-2EBAB5F11110", "33E6DF69-BDFA-407A-9744-C175B60643AE", "Attribute", "Attribute", "The attribute to set the value of.", 0, @"", "44A0B977-4730-4519-8FF6-B0A01A95B212"); // Rock.Workflow.Action.SetAttributeValue:Attribute
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("C789E457-0783-44B3-9D8F-2EBAB5F11110", "3B1D93D7-9414-48F9-80E5-6A3FC8F94C20", "Text Value|Attribute Value", "Value", "The text or attribute to set the value from. <span class='tip tip-lava'></span>", 1, @"", "E5272B11-A2B8-49DC-860D-8D574E2BC15C"); // Rock.Workflow.Action.SetAttributeValue:Text Value|Attribute Value
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("C789E457-0783-44B3-9D8F-2EBAB5F11110", "A75DFC58-7A1B-4799-BF31-451B2BBE38FF", "Order", "Order", "The order that this service should be used (priority)", 0, @"", "57093B41-50ED-48E5-B72B-8829E62704C8"); // Rock.Workflow.Action.SetAttributeValue:Order
            RockMigrationHelper.UpdateWorkflowType(false, true, "Start Text Attendance", "Step 1 of the text in attendance. This takes the code input, parses it and validates it. If it's a valid code it records it to the person attribute and sends a successful response, if an invalid code the person receives an invalid response.", "BF7F6EDD-1AA6-442C-BBE2-226591F78D4C", "Work", "fa fa-list-ol", 0, true, 0, "D8354EA7-7DA9-449D-94EE-210C6B9496D8"); // Start Text Attendance
            RockMigrationHelper.UpdateWorkflowTypeAttribute("D8354EA7-7DA9-449D-94EE-210C6B9496D8", "9C204CD0-1233-41C5-818A-C5DA439445AA", "FromPhone", "FromPhone", "", 0, @"", "F84AA34E-7F56-409F-9856-823A7BB37D33"); // Start Text Attendance:FromPhone
            RockMigrationHelper.UpdateWorkflowTypeAttribute("D8354EA7-7DA9-449D-94EE-210C6B9496D8", "9C204CD0-1233-41C5-818A-C5DA439445AA", "ToPhone", "ToPhone", "", 1, @"", "A5276737-7A6B-4D2D-9330-745AE4CFAF8B"); // Start Text Attendance:ToPhone
            RockMigrationHelper.UpdateWorkflowTypeAttribute("D8354EA7-7DA9-449D-94EE-210C6B9496D8", "9C204CD0-1233-41C5-818A-C5DA439445AA", "ReceivedDateTime", "ReceivedDateTime", "", 2, @"", "857DA3A4-D511-41FB-9390-2D837DD76E26"); // Start Text Attendance:ReceivedDateTime
            RockMigrationHelper.UpdateWorkflowTypeAttribute("D8354EA7-7DA9-449D-94EE-210C6B9496D8", "E4EAB7B2-0B76-429B-AFE4-AD86D7428C70", "FromPerson", "FromPerson", "", 3, @"", "95F98482-57BB-4F76-ACA6-9EA54C449569"); // Start Text Attendance:FromPerson
            RockMigrationHelper.UpdateWorkflowTypeAttribute("D8354EA7-7DA9-449D-94EE-210C6B9496D8", "9C204CD0-1233-41C5-818A-C5DA439445AA", "MessageBody", "MessageBody", "", 4, @"", "D40BE1C9-0880-43F8-82BD-50656D24C3D3"); // Start Text Attendance:MessageBody
            RockMigrationHelper.UpdateWorkflowTypeAttribute("D8354EA7-7DA9-449D-94EE-210C6B9496D8", "9C204CD0-1233-41C5-818A-C5DA439445AA", "SMSResponse", "SMSResponse", "", 5, @"", "921AD690-A61B-4F5B-9C30-69E02B4BC0C0"); // Start Text Attendance:SMSResponse
            RockMigrationHelper.UpdateWorkflowTypeAttribute("D8354EA7-7DA9-449D-94EE-210C6B9496D8", "9C204CD0-1233-41C5-818A-C5DA439445AA", "AttendanceKey", "AttendanceKey", "", 6, @"", "F6C1D4B7-837B-4BC4-B41C-4DAC33E35584"); // Start Text Attendance:AttendanceKey
            RockMigrationHelper.UpdateWorkflowTypeAttribute("D8354EA7-7DA9-449D-94EE-210C6B9496D8", "9C204CD0-1233-41C5-818A-C5DA439445AA", "AttendanceCode", "AttendanceCode", "", 7, @"", "6A65911E-4EB6-4073-9565-2F8B0A03AE0B"); // Start Text Attendance:AttendanceCode
            RockMigrationHelper.UpdateWorkflowTypeAttribute("D8354EA7-7DA9-449D-94EE-210C6B9496D8", "9C204CD0-1233-41C5-818A-C5DA439445AA", "FromPersonFirstName", "FromPersonFirstName", "", 8, @"", "665FF922-C62B-4926-8A3F-8EC9A38A6D02"); // Start Text Attendance:FromPersonFirstName
            RockMigrationHelper.UpdateWorkflowTypeAttribute("D8354EA7-7DA9-449D-94EE-210C6B9496D8", "F4399CEF-827B-48B2-A735-F7806FCFE8E8", "AttendanceGroup", "AttendanceGroup", "", 9, @"", "AAE6277D-49DF-4297-B285-069A494BF93C"); // Start Text Attendance:AttendanceGroup
            RockMigrationHelper.UpdateWorkflowTypeAttribute("D8354EA7-7DA9-449D-94EE-210C6B9496D8", "1B71FEF4-201F-4D53-8C60-2DF21F1985ED", "Campus", "Campus", "", 10, @"", "D5F43ACF-29B1-47D4-9AEE-0783F91733C1"); // Start Text Attendance:Campus
            RockMigrationHelper.UpdateWorkflowTypeAttribute("D8354EA7-7DA9-449D-94EE-210C6B9496D8", "9C204CD0-1233-41C5-818A-C5DA439445AA", "ReceivedTime", "ReceivedTime", "", 11, @"", "7A40C0A5-1E3B-433E-89DE-B23537235875"); // Start Text Attendance:ReceivedTime
            RockMigrationHelper.UpdateWorkflowTypeAttribute("D8354EA7-7DA9-449D-94EE-210C6B9496D8", "9C204CD0-1233-41C5-818A-C5DA439445AA", "ReceivedDate", "ReceivedDate", "", 12, @"", "ADA45D52-78E3-4871-82F4-90B388DD5452"); // Start Text Attendance:ReceivedDate
            RockMigrationHelper.AddAttributeQualifier("F84AA34E-7F56-409F-9856-823A7BB37D33", "ispassword", @"False", "BACE9A53-3FA8-481B-8C5D-7A75F7C22D53"); // Start Text Attendance:FromPhone:ispassword
            RockMigrationHelper.AddAttributeQualifier("A5276737-7A6B-4D2D-9330-745AE4CFAF8B", "ispassword", @"False", "90DEC861-7B71-41F7-880C-E39AD16424DF"); // Start Text Attendance:ToPhone:ispassword
            RockMigrationHelper.AddAttributeQualifier("857DA3A4-D511-41FB-9390-2D837DD76E26", "ispassword", @"False", "8F4189D8-6060-47FA-9AAD-5E28D9ABD1EF"); // Start Text Attendance:ReceivedDateTime:ispassword
            RockMigrationHelper.AddAttributeQualifier("D40BE1C9-0880-43F8-82BD-50656D24C3D3", "ispassword", @"False", "A5A8D60E-0070-43EF-86BE-0AB1E4BD0B2B"); // Start Text Attendance:MessageBody:ispassword
            RockMigrationHelper.AddAttributeQualifier("921AD690-A61B-4F5B-9C30-69E02B4BC0C0", "ispassword", @"False", "8EBC1E65-6667-41F4-B7DB-581F2A0C0C56"); // Start Text Attendance:SMSResponse:ispassword
            RockMigrationHelper.AddAttributeQualifier("F6C1D4B7-837B-4BC4-B41C-4DAC33E35584", "ispassword", @"False", "6A9A8058-8A17-4979-8202-2C3654A994FE"); // Start Text Attendance:AttendanceKey:ispassword
            RockMigrationHelper.AddAttributeQualifier("6A65911E-4EB6-4073-9565-2F8B0A03AE0B", "ispassword", @"False", "6BF03B85-E043-49C0-90F3-FF4867B1FDBA"); // Start Text Attendance:AttendanceCode:ispassword
            RockMigrationHelper.AddAttributeQualifier("665FF922-C62B-4926-8A3F-8EC9A38A6D02", "ispassword", @"False", "4C074062-0BAF-43CF-AB54-E535761FA6C4"); // Start Text Attendance:FromPersonFirstName:ispassword
            RockMigrationHelper.AddAttributeQualifier("7A40C0A5-1E3B-433E-89DE-B23537235875", "ispassword", @"False", "F10AA638-E8BC-46F6-9A72-F25540D7EC05"); // Start Text Attendance:ReceivedTime:ispassword
            RockMigrationHelper.AddAttributeQualifier("ADA45D52-78E3-4871-82F4-90B388DD5452", "ispassword", @"False", "317FE215-476F-4553-AD9D-DA7CA11BD1E8"); // Start Text Attendance:ReceivedDate:ispassword
            RockMigrationHelper.UpdateWorkflowActivityType("D8354EA7-7DA9-449D-94EE-210C6B9496D8", true, "Get Input", "", true, 0, "3B825D86-70A8-46F4-934C-DE28C4295591"); // Start Text Attendance:Get Input
            RockMigrationHelper.UpdateWorkflowActivityType("D8354EA7-7DA9-449D-94EE-210C6B9496D8", true, "Validate Text Code", "", false, 1, "657C473D-C52E-44D7-A3C3-0BC3FEDC971A"); // Start Text Attendance:Validate Text Code
            RockMigrationHelper.UpdateWorkflowActionType("3B825D86-70A8-46F4-934C-DE28C4295591", "Activate Validate Text Code", 4, "38907A90-1634-4A93-8017-619326A4A582", true, false, "", "", 1, "", "570A8A9D-BBA9-4134-A7B1-D4DC229CC211"); // Start Text Attendance:Get Input:Activate Validate Text Code
            RockMigrationHelper.UpdateWorkflowActionType("3B825D86-70A8-46F4-934C-DE28C4295591", "Set Campus", 2, "A41216D6-6FB0-4019-B222-2C29B4519CF4", true, false, "", "", 1, "", "721585FA-AE1A-4FD9-8D19-987D94C1D118"); // Start Text Attendance:Get Input:Set Campus
            RockMigrationHelper.UpdateWorkflowActionType("3B825D86-70A8-46F4-934C-DE28C4295591", "Set Attendance Group", 3, "A41216D6-6FB0-4019-B222-2C29B4519CF4", true, false, "", "", 1, "", "95EAACB7-EFD7-47DD-8A93-B0B23264F385"); // Start Text Attendance:Get Input:Set Attendance Group
            RockMigrationHelper.UpdateWorkflowActionType("3B825D86-70A8-46F4-934C-DE28C4295591", "Send SMS Response", 1, "C789E457-0783-44B3-9D8F-2EBAB5F11110", true, false, "", "95F98482-57BB-4F76-ACA6-9EA54C449569", 32, "", "8880718E-6D73-4843-81DE-521C1D6B874B"); // Start Text Attendance:Get Input:Send SMS Response
            RockMigrationHelper.UpdateWorkflowActionType("657C473D-C52E-44D7-A3C3-0BC3FEDC971A", "Send Response Success", 3, "C789E457-0783-44B3-9D8F-2EBAB5F11110", true, false, "", "F6C1D4B7-837B-4BC4-B41C-4DAC33E35584", 64, "", "E47DE542-0C1B-426B-935C-EAAC11D0D631"); // Start Text Attendance:Validate Text Code:Send Response Success
            RockMigrationHelper.UpdateWorkflowActionType("657C473D-C52E-44D7-A3C3-0BC3FEDC971A", "Send Response invalid", 5, "C789E457-0783-44B3-9D8F-2EBAB5F11110", true, false, "", "F6C1D4B7-837B-4BC4-B41C-4DAC33E35584", 32, "", "6D9D4213-03B1-4730-85DC-7A2E56A54A74"); // Start Text Attendance:Validate Text Code:Send Response invalid
            RockMigrationHelper.UpdateWorkflowActionType("3B825D86-70A8-46F4-934C-DE28C4295591", "Set current person", 0, "4EEAC6FA-B838-410B-A8DD-21A364029F5D", true, false, "", "", 1, "", "9AF43825-22D9-4871-ACFF-8621E66B1D47"); // Start Text Attendance:Get Input:Set current person
            RockMigrationHelper.UpdateWorkflowActionType("657C473D-C52E-44D7-A3C3-0BC3FEDC971A", "Set Person Attribute Attendance Code", 4, "320622DA-52E0-41AE-AF90-2BF78B488552", true, false, "", "F6C1D4B7-837B-4BC4-B41C-4DAC33E35584", 64, "", "43D98ED1-D5CD-406A-85F4-FFFDA136AD80"); // Start Text Attendance:Validate Text Code:Set Person Attribute Attendance Code
            RockMigrationHelper.UpdateWorkflowActionType("657C473D-C52E-44D7-A3C3-0BC3FEDC971A", "Get First Name", 0, "85D1DBFE-9F3F-486A-BF2C-60146A8D97F8", true, false, "", "", 1, "", "D603E817-BC49-4A91-8F60-F962C978D5AD"); // Start Text Attendance:Validate Text Code:Get First Name
            RockMigrationHelper.UpdateWorkflowActionType("657C473D-C52E-44D7-A3C3-0BC3FEDC971A", "Check In Person", 2, "34B9F1A4-7884-4083-A345-0FE164565AA9", true, false, "", "F6C1D4B7-837B-4BC4-B41C-4DAC33E35584", 64, "", "674C0321-D6E3-432E-AB0B-8CACB97B56DD"); // Start Text Attendance:Validate Text Code:Check In Person
            RockMigrationHelper.UpdateWorkflowActionType("657C473D-C52E-44D7-A3C3-0BC3FEDC971A", "Validate Attendance Code", 1, "550458E4-BBBF-4E47-955E-1DBE79352E7D", true, false, "", "", 1, "", "61AF05D8-F676-4820-911F-C544E5A4B457"); // Start Text Attendance:Validate Text Code:Validate Attendance Code
            RockMigrationHelper.AddActionTypeAttributeValue("9AF43825-22D9-4871-ACFF-8621E66B1D47", "7A7B2369-901E-4838-852F-2AB42ABC9EBA", @"False"); // Start Text Attendance:Get Input:Set current person:Active
            RockMigrationHelper.AddActionTypeAttributeValue("9AF43825-22D9-4871-ACFF-8621E66B1D47", "047336EA-EA6F-46D7-9F32-FB67D2C9DA32", @"95f98482-57bb-4f76-aca6-9ea54c449569"); // Start Text Attendance:Get Input:Set current person:Person Attribute
            RockMigrationHelper.AddActionTypeAttributeValue("9AF43825-22D9-4871-ACFF-8621E66B1D47", "8960D3B2-25B4-41BD-84D8-2C88779271F4", @""); // Start Text Attendance:Get Input:Set current person:Order
            RockMigrationHelper.AddActionTypeAttributeValue("8880718E-6D73-4843-81DE-521C1D6B874B", "D7EAA859-F500-4521-9523-488B12EAA7D2", @"False"); // Start Text Attendance:Get Input:Send SMS Response:Active
            RockMigrationHelper.AddActionTypeAttributeValue("8880718E-6D73-4843-81DE-521C1D6B874B", "44A0B977-4730-4519-8FF6-B0A01A95B212", @"921ad690-a61b-4f5b-9c30-69e02b4bc0c0"); // Start Text Attendance:Get Input:Send SMS Response:Attribute
            RockMigrationHelper.AddActionTypeAttributeValue("8880718E-6D73-4843-81DE-521C1D6B874B", "57093B41-50ED-48E5-B72B-8829E62704C8", @""); // Start Text Attendance:Get Input:Send SMS Response:Order
            RockMigrationHelper.AddActionTypeAttributeValue("8880718E-6D73-4843-81DE-521C1D6B874B", "E5272B11-A2B8-49DC-860D-8D574E2BC15C", @"We're sorry we could not find the number: {Workflow.FromPhone} in our records, please fill out a connection card."); // Start Text Attendance:Get Input:Send SMS Response:Text Value|Attribute Value
            RockMigrationHelper.AddActionTypeAttributeValue("721585FA-AE1A-4FD9-8D19-987D94C1D118", "F3B9908B-096F-460B-8320-122CF046D1F9", @"DECLARE @campusName nvarchar(100) = '{{ Workflow.Campus }}'
SELECT [Guid] 
FROM [Campus] c
WHERE c.[Name] = @campusName"); // Start Text Attendance:Get Input:Set Campus:SQLQuery
            RockMigrationHelper.AddActionTypeAttributeValue("721585FA-AE1A-4FD9-8D19-987D94C1D118", "A18C3143-0586-4565-9F36-E603BC674B4E", @"False"); // Start Text Attendance:Get Input:Set Campus:Active
            RockMigrationHelper.AddActionTypeAttributeValue("721585FA-AE1A-4FD9-8D19-987D94C1D118", "FA7C685D-8636-41EF-9998-90FFF3998F76", @""); // Start Text Attendance:Get Input:Set Campus:Order
            RockMigrationHelper.AddActionTypeAttributeValue("721585FA-AE1A-4FD9-8D19-987D94C1D118", "56997192-2545-4EA1-B5B2-313B04588984", @"d5f43acf-29b1-47d4-9aee-0783f91733c1"); // Start Text Attendance:Get Input:Set Campus:Result Attribute
            RockMigrationHelper.AddActionTypeAttributeValue("95EAACB7-EFD7-47DD-8A93-B0B23264F385", "F3B9908B-096F-460B-8320-122CF046D1F9", @"DECLARE @groupname nvarchar(100) = '{{Workflow.AttendanceGroup}}'
SELECT [Guid] 
FROM [Group] g
WHERE g.[Name] = @groupname"); // Start Text Attendance:Get Input:Set Attendance Group:SQLQuery
            RockMigrationHelper.AddActionTypeAttributeValue("95EAACB7-EFD7-47DD-8A93-B0B23264F385", "A18C3143-0586-4565-9F36-E603BC674B4E", @"False"); // Start Text Attendance:Get Input:Set Attendance Group:Active
            RockMigrationHelper.AddActionTypeAttributeValue("95EAACB7-EFD7-47DD-8A93-B0B23264F385", "FA7C685D-8636-41EF-9998-90FFF3998F76", @""); // Start Text Attendance:Get Input:Set Attendance Group:Order
            RockMigrationHelper.AddActionTypeAttributeValue("95EAACB7-EFD7-47DD-8A93-B0B23264F385", "56997192-2545-4EA1-B5B2-313B04588984", @"aae6277d-49df-4297-b285-069a494bf93c"); // Start Text Attendance:Get Input:Set Attendance Group:Result Attribute
            RockMigrationHelper.AddActionTypeAttributeValue("570A8A9D-BBA9-4134-A7B1-D4DC229CC211", "E8ABD802-372C-47BE-82B1-96F50DB5169E", @"False"); // Start Text Attendance:Get Input:Activate Validate Text Code:Active
            RockMigrationHelper.AddActionTypeAttributeValue("570A8A9D-BBA9-4134-A7B1-D4DC229CC211", "3809A78C-B773-440C-8E3F-A8E81D0DAE08", @""); // Start Text Attendance:Get Input:Activate Validate Text Code:Order
            RockMigrationHelper.AddActionTypeAttributeValue("570A8A9D-BBA9-4134-A7B1-D4DC229CC211", "02D5A7A5-8781-46B4-B9FC-AF816829D240", @"657C473D-C52E-44D7-A3C3-0BC3FEDC971A"); // Start Text Attendance:Get Input:Activate Validate Text Code:Activity
            RockMigrationHelper.AddActionTypeAttributeValue("D603E817-BC49-4A91-8F60-F962C978D5AD", "CF19BB9A-EA5B-43E5-89A1-FA416F430761", @"95f98482-57bb-4f76-aca6-9ea54c449569"); // Start Text Attendance:Validate Text Code:Get First Name:PersonAttribute
            RockMigrationHelper.AddActionTypeAttributeValue("D603E817-BC49-4A91-8F60-F962C978D5AD", "40FF47A2-9682-4545-BDF3-171B5F6B8A5C", @"665ff922-c62b-4926-8a3f-8ec9a38a6d02"); // Start Text Attendance:Validate Text Code:Get First Name:Attribute
            RockMigrationHelper.AddActionTypeAttributeValue("D603E817-BC49-4A91-8F60-F962C978D5AD", "52930E88-A86E-47AE-BB1D-9937692BBF74", @"{{Person.FirstName}}"); // Start Text Attendance:Validate Text Code:Get First Name:Lava
            RockMigrationHelper.AddActionTypeAttributeValue("D603E817-BC49-4A91-8F60-F962C978D5AD", "E7527DBD-32B1-47CE-8D22-142EDE32BD7D", @""); // Start Text Attendance:Validate Text Code:Get First Name:Order
            RockMigrationHelper.AddActionTypeAttributeValue("D603E817-BC49-4A91-8F60-F962C978D5AD", "8DE0F372-4B1C-4612-B318-E598E4CC17F8", @"False"); // Start Text Attendance:Validate Text Code:Get First Name:Active
            RockMigrationHelper.AddActionTypeAttributeValue("61AF05D8-F676-4820-911F-C544E5A4B457", "C9FC261D-84BF-41F7-9636-734EAAF0FD86", @"False"); // Start Text Attendance:Validate Text Code:Validate Attendance Code:Active
            RockMigrationHelper.AddActionTypeAttributeValue("61AF05D8-F676-4820-911F-C544E5A4B457", "0FC7338D-F75D-401F-8F03-ADDA92315A3B", @"{{ Workflow.MessageBody }}"); // Start Text Attendance:Validate Text Code:Validate Attendance Code:UserInputCode
            RockMigrationHelper.AddActionTypeAttributeValue("61AF05D8-F676-4820-911F-C544E5A4B457", "18BA2FE7-7620-42CE-8FD8-727A26683B81", @""); // Start Text Attendance:Validate Text Code:Validate Attendance Code:Order
            RockMigrationHelper.AddActionTypeAttributeValue("674C0321-D6E3-432E-AB0B-8CACB97B56DD", "C8AB1F08-B94A-4A05-B0CC-7A315279D0A1", @"False"); // Start Text Attendance:Validate Text Code:Check In Person:Active
            RockMigrationHelper.AddActionTypeAttributeValue("674C0321-D6E3-432E-AB0B-8CACB97B56DD", "C78E85FE-D7FC-445A-A177-22122C468EB0", @"aae6277d-49df-4297-b285-069a494bf93c"); // Start Text Attendance:Validate Text Code:Check In Person:Group
            RockMigrationHelper.AddActionTypeAttributeValue("674C0321-D6E3-432E-AB0B-8CACB97B56DD", "BD134939-44F1-4E4B-B420-0D049334A3DF", @""); // Start Text Attendance:Validate Text Code:Check In Person:Order
            RockMigrationHelper.AddActionTypeAttributeValue("674C0321-D6E3-432E-AB0B-8CACB97B56DD", "01AC3A18-01E2-41B7-8601-2B2789381D92", @"95f98482-57bb-4f76-aca6-9ea54c449569"); // Start Text Attendance:Validate Text Code:Check In Person:Person
            RockMigrationHelper.AddActionTypeAttributeValue("674C0321-D6E3-432E-AB0B-8CACB97B56DD", "82C801A7-0C15-437F-BF53-30ECC451289E", @"857da3a4-d511-41fb-9390-2d837dd76e26"); // Start Text Attendance:Validate Text Code:Check In Person:Attendance Date/Time
            RockMigrationHelper.AddActionTypeAttributeValue("674C0321-D6E3-432E-AB0B-8CACB97B56DD", "907C1D7C-DB12-472B-83B1-56F473C1AC16", @"d5f43acf-29b1-47d4-9aee-0783f91733c1"); // Start Text Attendance:Validate Text Code:Check In Person:Campus
            RockMigrationHelper.AddActionTypeAttributeValue("E47DE542-0C1B-426B-935C-EAAC11D0D631", "57093B41-50ED-48E5-B72B-8829E62704C8", @""); // Start Text Attendance:Validate Text Code:Send Response Success:Order
            RockMigrationHelper.AddActionTypeAttributeValue("E47DE542-0C1B-426B-935C-EAAC11D0D631", "D7EAA859-F500-4521-9523-488B12EAA7D2", @"False"); // Start Text Attendance:Validate Text Code:Send Response Success:Active
            RockMigrationHelper.AddActionTypeAttributeValue("E47DE542-0C1B-426B-935C-EAAC11D0D631", "44A0B977-4730-4519-8FF6-B0A01A95B212", @"921ad690-a61b-4f5b-9c30-69e02b4bc0c0"); // Start Text Attendance:Validate Text Code:Send Response Success:Attribute
            RockMigrationHelper.AddActionTypeAttributeValue("E47DE542-0C1B-426B-935C-EAAC11D0D631", "E5272B11-A2B8-49DC-860D-8D574E2BC15C", @"Thank you for your attendance {{ Workflow.FromPersonFirstName }}. Reply back with just the number: 1 Check-in your Family; 2 Prayer request; 3 Join a Homegroup; 4 You need to review your contact info"); // Start Text Attendance:Validate Text Code:Send Response Success:Text Value|Attribute Value
            RockMigrationHelper.AddActionTypeAttributeValue("43D98ED1-D5CD-406A-85F4-FFFDA136AD80", "3F3BF3E6-AD53-491E-A40F-441F2AFCBB5B", @""); // Start Text Attendance:Validate Text Code:Set Person Attribute Attendance Code:Order
            RockMigrationHelper.AddActionTypeAttributeValue("43D98ED1-D5CD-406A-85F4-FFFDA136AD80", "E5BAC4A6-FF7F-4016-BA9C-72D16CB60184", @"False"); // Start Text Attendance:Validate Text Code:Set Person Attribute Attendance Code:Active
            RockMigrationHelper.AddActionTypeAttributeValue("43D98ED1-D5CD-406A-85F4-FFFDA136AD80", "E456FB6F-05DB-4826-A612-5B704BC4EA13", @"95f98482-57bb-4f76-aca6-9ea54c449569"); // Start Text Attendance:Validate Text Code:Set Person Attribute Attendance Code:Person
            RockMigrationHelper.AddActionTypeAttributeValue("43D98ED1-D5CD-406A-85F4-FFFDA136AD80", "8F4BB00F-7FA2-41AD-8E90-81F4DFE2C762", @"4aa6b358-729f-4790-9f13-0271067b76e9"); // Start Text Attendance:Validate Text Code:Set Person Attribute Attendance Code:Person Attribute
            RockMigrationHelper.AddActionTypeAttributeValue("43D98ED1-D5CD-406A-85F4-FFFDA136AD80", "94689BDE-493E-4869-A614-2D54822D747C", @"6a65911e-4eb6-4073-9565-2f8b0a03ae0b"); // Start Text Attendance:Validate Text Code:Set Person Attribute Attendance Code:Value|Attribute Value
            RockMigrationHelper.AddActionTypeAttributeValue("6D9D4213-03B1-4730-85DC-7A2E56A54A74", "D7EAA859-F500-4521-9523-488B12EAA7D2", @"False"); // Start Text Attendance:Validate Text Code:Send Response invalid:Active
            RockMigrationHelper.AddActionTypeAttributeValue("6D9D4213-03B1-4730-85DC-7A2E56A54A74", "44A0B977-4730-4519-8FF6-B0A01A95B212", @"921ad690-a61b-4f5b-9c30-69e02b4bc0c0"); // Start Text Attendance:Validate Text Code:Send Response invalid:Attribute
            RockMigrationHelper.AddActionTypeAttributeValue("6D9D4213-03B1-4730-85DC-7A2E56A54A74", "57093B41-50ED-48E5-B72B-8829E62704C8", @""); // Start Text Attendance:Validate Text Code:Send Response invalid:Order
            RockMigrationHelper.AddActionTypeAttributeValue("6D9D4213-03B1-4730-85DC-7A2E56A54A74", "E5272B11-A2B8-49DC-860D-8D574E2BC15C", @"We are sorry, the code you entered is not correct. Please input the appropriate attendance code."); // Start Text Attendance:Validate Text Code:Send Response invalid:Text Value|Attribute Value
        }
    }
}
