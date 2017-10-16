<?xml version="1.0" encoding="utf-8"?>
<Dsl xmlns:dm0="http://schemas.microsoft.com/VisualStudio/2008/DslTools/Core" dslVersion="1.0.0.0" Id="10960b28-2a5c-4690-bc14-a4463850e3d4" Description="Description for Ufba.Ev.Ev" Name="Ev" DisplayName="Ev" Namespace="Ufba.Ev" ProductName="Ev" CompanyName="Ufba" PackageGuid="623cb3cb-ecfa-457c-8465-c0634384012d" PackageNamespace="Ufba.Ev" xmlns="http://schemas.microsoft.com/VisualStudio/2005/DslTools/DslDefinitionModel">
  <Classes>
    <DomainClass Id="2f5d49ad-6ddd-4b45-bfe7-98718ee823d3" Description="The root in which all other elements are embedded. Appears as a diagram." Name="EvModel" DisplayName="Ev Model" Namespace="Ufba.Ev">
      <Properties>
        <DomainProperty Id="8982ec97-3ed1-4f4b-9a4a-7ce12d2a6219" Description="Description for Ufba.Ev.EvModel.Name" Name="Name" DisplayName="Name">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
        <DomainProperty Id="22d24a26-9ac8-4ef3-8d4c-cdfe7a094e8f" Description="Description for Ufba.Ev.EvModel.Email" Name="Email" DisplayName="Email">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
        <DomainProperty Id="4868407a-5eb0-440e-bb82-34e75cb53fdf" Description="Description for Ufba.Ev.EvModel.Password" Name="Password" DisplayName="Password">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
      </Properties>
      <ElementMergeDirectives>
        <ElementMergeDirective>
          <Notes>Creates an embedding link when an element is dropped onto a model. </Notes>
          <Index>
            <DomainClassMoniker Name="Option" />
          </Index>
          <LinkCreationPaths>
            <DomainPath>EvModelHasElements.Elements</DomainPath>
          </LinkCreationPaths>
        </ElementMergeDirective>
      </ElementMergeDirectives>
    </DomainClass>
    <DomainClass Id="5898829f-1494-4271-a5e2-ba4fc2f46d92" Description="Elements embedded in the model. Appear as boxes on the diagram." Name="Option" DisplayName="Option" Namespace="Ufba.Ev">
      <Properties>
        <DomainProperty Id="fcf806cf-70b3-4de2-a446-55b545ce206e" Description="Description for Ufba.Ev.Option.Option Type" Name="OptionType" DisplayName="Option Type">
          <Type>
            <DomainEnumerationMoniker Name="OptionTypes" />
          </Type>
        </DomainProperty>
      </Properties>
      <ElementMergeDirectives>
        <ElementMergeDirective>
          <Index>
            <DomainClassMoniker Name="Function" />
          </Index>
          <LinkCreationPaths>
            <DomainPath>OptionHasFunctions.Functions</DomainPath>
          </LinkCreationPaths>
        </ElementMergeDirective>
        <ElementMergeDirective>
          <Index>
            <DomainClassMoniker Name="Property" />
          </Index>
          <LinkCreationPaths>
            <DomainPath>OptionHasProperties.Properties</DomainPath>
          </LinkCreationPaths>
        </ElementMergeDirective>
        <ElementMergeDirective>
          <Index>
            <DomainClassMoniker Name="Type" />
          </Index>
          <LinkCreationPaths>
            <DomainPath>OptionHasTypes.Types</DomainPath>
          </LinkCreationPaths>
        </ElementMergeDirective>
      </ElementMergeDirectives>
    </DomainClass>
    <DomainClass Id="a1d03807-55e4-4045-acb7-598e4eefae80" Description="Description for Ufba.Ev.Function" Name="Function" DisplayName="Function" Namespace="Ufba.Ev">
      <Properties>
        <DomainProperty Id="119461ac-c927-4f97-bb68-11eee99e5d16" Description="Description for Ufba.Ev.Function.Name" Name="Name" DisplayName="Name">
          <Type>
            <DomainEnumerationMoniker Name="FunctionTypes" />
          </Type>
        </DomainProperty>
      </Properties>
    </DomainClass>
    <DomainClass Id="6a78b38d-b370-45fc-992c-ce5f1193a4a7" Description="Description for Ufba.Ev.Property" Name="Property" DisplayName="Property" Namespace="Ufba.Ev">
      <Properties>
        <DomainProperty Id="1a60111e-9ed2-4006-87c0-9f9223799b79" Description="Description for Ufba.Ev.Property.Name" Name="Name" DisplayName="Name">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
      </Properties>
    </DomainClass>
    <DomainClass Id="2ac8ebca-adb0-4a57-b9e1-38c93f6f2517" Description="Description for Ufba.Ev.Type" Name="Type" DisplayName="Type" Namespace="Ufba.Ev">
      <Properties>
        <DomainProperty Id="748dea58-1627-4eea-9a80-fb924fc83291" Description="Description for Ufba.Ev.Type.Name" Name="Name" DisplayName="Name">
          <Type>
            <DomainEnumerationMoniker Name="CommandTypes" />
          </Type>
        </DomainProperty>
      </Properties>
    </DomainClass>
  </Classes>
  <Relationships>
    <DomainRelationship Id="4f4a2f72-45fd-4cae-99ba-9e9fdeca8713" Description="Embedding relationship between the Model and Elements" Name="EvModelHasElements" DisplayName="Ev Model Has Elements" Namespace="Ufba.Ev" IsEmbedding="true">
      <Source>
        <DomainRole Id="e35a2fd8-a311-4726-86d1-7d794720a10f" Description="" Name="EvModel" DisplayName="Ev Model" PropertyName="Elements" PropagatesCopy="PropagatesCopyToLinkAndOppositeRolePlayer" PropertyDisplayName="Elements">
          <RolePlayer>
            <DomainClassMoniker Name="EvModel" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="d1ed1b5a-ab31-445b-ba89-748c51afd8f3" Description="" Name="Element" DisplayName="Element" PropertyName="EvModel" Multiplicity="One" PropagatesDelete="true" PropertyDisplayName="Ev Model">
          <RolePlayer>
            <DomainClassMoniker Name="Option" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
    <DomainRelationship Id="7c7047b7-f435-4984-b739-c6603a21f7c1" Description="Description for Ufba.Ev.OptionHasFunctions" Name="OptionHasFunctions" DisplayName="Option Has Functions" Namespace="Ufba.Ev" IsEmbedding="true">
      <Properties>
        <DomainProperty Id="5ac66e02-fcce-4a77-a929-71cc68ea7ac1" Description="Description for Ufba.Ev.OptionHasFunctions.Var" Name="Var" DisplayName="Var">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
      </Properties>
      <Source>
        <DomainRole Id="0610bcea-b612-415d-8cd8-e08b7faf5316" Description="Description for Ufba.Ev.OptionHasFunctions.Option" Name="Option" DisplayName="Option" PropertyName="Functions" PropagatesCopy="PropagatesCopyToLinkAndOppositeRolePlayer" PropertyDisplayName="Functions">
          <RolePlayer>
            <DomainClassMoniker Name="Option" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="7c2c9e35-6364-4e00-bb6a-bb62f0930666" Description="Description for Ufba.Ev.OptionHasFunctions.Function" Name="Function" DisplayName="Function" PropertyName="Option" Multiplicity="One" PropagatesDelete="true" PropertyDisplayName="Option">
          <RolePlayer>
            <DomainClassMoniker Name="Function" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
    <DomainRelationship Id="b2482601-abc8-4721-9401-838659fdefab" Description="Description for Ufba.Ev.OptionHasProperties" Name="OptionHasProperties" DisplayName="Option Has Properties" Namespace="Ufba.Ev" IsEmbedding="true">
      <Source>
        <DomainRole Id="c124a9c1-5a72-41a9-be5e-43f7eac30b47" Description="Description for Ufba.Ev.OptionHasProperties.Option" Name="Option" DisplayName="Option" PropertyName="Properties" PropagatesCopy="PropagatesCopyToLinkAndOppositeRolePlayer" PropertyDisplayName="Properties">
          <RolePlayer>
            <DomainClassMoniker Name="Option" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="8723d0d8-3352-4902-bb66-f51f082d418f" Description="Description for Ufba.Ev.OptionHasProperties.Property" Name="Property" DisplayName="Property" PropertyName="Option" Multiplicity="One" PropagatesDelete="true" PropertyDisplayName="Option">
          <RolePlayer>
            <DomainClassMoniker Name="Property" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
    <DomainRelationship Id="f378e9b2-9af7-454f-8344-2f01eede5025" Description="Description for Ufba.Ev.OptionHasTypes" Name="OptionHasTypes" DisplayName="Option Has Types" Namespace="Ufba.Ev" IsEmbedding="true">
      <Source>
        <DomainRole Id="2badeb65-5ed6-4030-bce6-7bd5bc2ede94" Description="Description for Ufba.Ev.OptionHasTypes.Option" Name="Option" DisplayName="Option" PropertyName="Types" PropagatesCopy="PropagatesCopyToLinkAndOppositeRolePlayer" PropertyDisplayName="Types">
          <RolePlayer>
            <DomainClassMoniker Name="Option" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="365a3858-8efb-4194-ac12-1610c7a17036" Description="Description for Ufba.Ev.OptionHasTypes.Type" Name="Type" DisplayName="Type" PropertyName="Option" Multiplicity="One" PropagatesDelete="true" PropertyDisplayName="Option">
          <RolePlayer>
            <DomainClassMoniker Name="Type" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
  </Relationships>
  <Types>
    <ExternalType Name="DateTime" Namespace="System" />
    <ExternalType Name="String" Namespace="System" />
    <ExternalType Name="Int16" Namespace="System" />
    <ExternalType Name="Int32" Namespace="System" />
    <ExternalType Name="Int64" Namespace="System" />
    <ExternalType Name="UInt16" Namespace="System" />
    <ExternalType Name="UInt32" Namespace="System" />
    <ExternalType Name="UInt64" Namespace="System" />
    <ExternalType Name="SByte" Namespace="System" />
    <ExternalType Name="Byte" Namespace="System" />
    <ExternalType Name="Double" Namespace="System" />
    <ExternalType Name="Single" Namespace="System" />
    <ExternalType Name="Guid" Namespace="System" />
    <ExternalType Name="Boolean" Namespace="System" />
    <ExternalType Name="Char" Namespace="System" />
    <DomainEnumeration Name="OptionTypes" Namespace="Ufba.Ev" Description="Description for Ufba.Ev.OptionTypes">
      <Literals>
        <EnumerationLiteral Description="Description for Ufba.Ev.OptionTypes.User" Name="User" Value="" />
        <EnumerationLiteral Description="Description for Ufba.Ev.OptionTypes.Speaker" Name="Speaker" Value="" />
        <EnumerationLiteral Description="Description for Ufba.Ev.OptionTypes.Organizer" Name="Organizer" Value="" />
        <EnumerationLiteral Description="Description for Ufba.Ev.OptionTypes.Event" Name="Event" Value="" />
        <EnumerationLiteral Description="Description for Ufba.Ev.OptionTypes.Assignment" Name="Assignment" Value="" />
        <EnumerationLiteral Description="Description for Ufba.Ev.OptionTypes.Payment" Name="Payment" Value="" />
        <EnumerationLiteral Description="Description for Ufba.Ev.OptionTypes.Submission" Name="Submission" Value="" />
        <EnumerationLiteral Description="Description for Ufba.Ev.OptionTypes.Reviewer" Name="Reviewer" Value="" />
        <EnumerationLiteral Description="Description for Ufba.Ev.OptionTypes.Activity" Name="Activity" Value="" />
        <EnumerationLiteral Description="Description for Ufba.Ev.OptionTypes.Author" Name="Author" Value="" />
        <EnumerationLiteral Description="Description for Ufba.Ev.OptionTypes.Receipt" Name="Receipt" Value="" />
        <EnumerationLiteral Description="Description for Ufba.Ev.OptionTypes.CheckingCopy" Name="CheckingCopy" Value="" />
      </Literals>
    </DomainEnumeration>
    <DomainEnumeration Name="FunctionTypes" Namespace="Ufba.Ev" Description="Description for Ufba.Ev.FunctionTypes">
      <Literals>
        <EnumerationLiteral Description="Description for Ufba.Ev.FunctionTypes.askCardInfo" Name="askCardInfo" Value="" />
        <EnumerationLiteral Description="Description for Ufba.Ev.FunctionTypes.sendEmailNotification" Name="sendEmailNotification" Value="" />
        <EnumerationLiteral Description="Description for Ufba.Ev.FunctionTypes.assigmentConflictResolver" Name="assigmentConflictResolver" Value="" />
        <EnumerationLiteral Description="Description for Ufba.Ev.FunctionTypes.reportsFrequencyPerActivity" Name="reportsFrequencyPerActivity" Value="" />
        <EnumerationLiteral Description="Description for Ufba.Ev.FunctionTypes.checkingCopyAtestado" Name="checkingCopyAtestado" Value="" />
        <EnumerationLiteral Description="Description for Ufba.Ev.FunctionTypes.reportsListofAuthors" Name="reportsListofAuthors" Value="" />
        <EnumerationLiteral Description="Description for Ufba.Ev.FunctionTypes.checkingCopyCertificado" Name="checkingCopyCertificado" Value="" />
        <EnumerationLiteral Description="Description for Ufba.Ev.FunctionTypes.program" Name="program" Value="" />
        <EnumerationLiteral Description="Description for Ufba.Ev.FunctionTypes.importantDates" Name="importantDates" Value="" />
        <EnumerationLiteral Description="Description for Ufba.Ev.FunctionTypes.generateBoleto" Name="generateBoleto" Value="" />
        <EnumerationLiteral Description="Description for Ufba.Ev.FunctionTypes.reportsFrequencyPerEvent" Name="reportsFrequencyPerEvent" Value="" />
        <EnumerationLiteral Description="Description for Ufba.Ev.FunctionTypes.generateCarne" Name="generateCarne" Value="" />
        <EnumerationLiteral Description="Description for Ufba.Ev.FunctionTypes.sendBugTrackEmail" Name="sendBugTrackEmail" Value="" />
        <EnumerationLiteral Description="Description for Ufba.Ev.FunctionTypes.notificationsDeadline" Name="notificationsDeadline" Value="" />
        <EnumerationLiteral Description="Description for Ufba.Ev.FunctionTypes.interestConflict" Name="interestConflict" Value="" />
        <EnumerationLiteral Description="Description for Ufba.Ev.FunctionTypes.notificationsAceptanceRejection" Name="notificationsAceptanceRejection" Value="" />
        <EnumerationLiteral Description="Description for Ufba.Ev.FunctionTypes.insertAttachment" Name="insertAttachment" Value="" />
      </Literals>
    </DomainEnumeration>
    <DomainEnumeration Name="CommandTypes" Namespace="Ufba.Ev" Description="Description for Ufba.Ev.CommandTypes">
      <Literals>
        <EnumerationLiteral Description="Description for Ufba.Ev.CommandTypes.All" Name="All" Value="" />
        <EnumerationLiteral Description="Description for Ufba.Ev.CommandTypes.Insert" Name="Insert" Value="" />
        <EnumerationLiteral Description="Description for Ufba.Ev.CommandTypes.Update" Name="Update" Value="" />
        <EnumerationLiteral Description="Description for Ufba.Ev.CommandTypes.Search" Name="Search" Value="" />
        <EnumerationLiteral Description="Description for Ufba.Ev.CommandTypes.Remove" Name="Remove" Value="" />
        <EnumerationLiteral Description="Description for Ufba.Ev.CommandTypes.ListAll" Name="ListAll" Value="" />
      </Literals>
    </DomainEnumeration>
  </Types>
  <Shapes>
    <GeometryShape Id="9e94b808-f9f7-45db-89e1-5c609151267f" Description="Description for Ufba.Ev.FunctionShape" Name="FunctionShape" DisplayName="Function Shape" Namespace="Ufba.Ev" FixedTooltipText="Function Shape" FillColor="DarkRed" InitialHeight="0.5" Geometry="Ellipse">
      <ShapeHasDecorators Position="InnerTopLeft" HorizontalOffset="0" VerticalOffset="0">
        <TextDecorator Name="Name" DisplayName="Name" DefaultText="Name" />
      </ShapeHasDecorators>
    </GeometryShape>
    <CompartmentShape Id="1027ef0a-85dd-46fb-9ce6-94cee5533d96" Description="Description for Ufba.Ev.OptionShape" Name="OptionShape" DisplayName="Option Shape" Namespace="Ufba.Ev" FixedTooltipText="Option Shape" FillColor="SkyBlue" InitialHeight="1" Geometry="Rectangle">
      <ShapeHasDecorators Position="InnerTopLeft" HorizontalOffset="0" VerticalOffset="0">
        <TextDecorator Name="Type" DisplayName="Type" DefaultText="Type" />
      </ShapeHasDecorators>
      <Compartment FillColor="Coral" Name="Properties" />
      <Compartment Name="Actions" />
    </CompartmentShape>
  </Shapes>
  <Connectors>
    <Connector Id="ce04cb6b-f0cc-46b9-8ed0-eacd62889875" Description="Connector between the ExampleShapes. Represents ExampleRelationships on the Diagram." Name="OptionConnector" DisplayName="Option Connector" Namespace="Ufba.Ev" FixedTooltipText="Option Connector" Color="Fuchsia" TargetEndStyle="EmptyArrow" Thickness="0.01">
      <ConnectorHasDecorators Position="SourceTop" OffsetFromShape="0" OffsetFromLine="0">
        <TextDecorator Name="Var" DisplayName="Var" DefaultText="Var" />
      </ConnectorHasDecorators>
    </Connector>
  </Connectors>
  <XmlSerializationBehavior Name="EvSerializationBehavior" Namespace="Ufba.Ev">
    <ClassData>
      <XmlClassData TypeName="EvModel" MonikerAttributeName="" SerializeId="true" MonikerElementName="evModelMoniker" ElementName="evModel" MonikerTypeName="EvModelMoniker">
        <DomainClassMoniker Name="EvModel" />
        <ElementData>
          <XmlRelationshipData RoleElementName="elements">
            <DomainRelationshipMoniker Name="EvModelHasElements" />
          </XmlRelationshipData>
          <XmlPropertyData XmlName="name">
            <DomainPropertyMoniker Name="EvModel/Name" />
          </XmlPropertyData>
          <XmlPropertyData XmlName="email">
            <DomainPropertyMoniker Name="EvModel/Email" />
          </XmlPropertyData>
          <XmlPropertyData XmlName="password">
            <DomainPropertyMoniker Name="EvModel/Password" />
          </XmlPropertyData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="Option" MonikerAttributeName="" SerializeId="true" MonikerElementName="optionMoniker" ElementName="option" MonikerTypeName="OptionMoniker">
        <DomainClassMoniker Name="Option" />
        <ElementData>
          <XmlRelationshipData UseFullForm="true" RoleElementName="functions">
            <DomainRelationshipMoniker Name="OptionHasFunctions" />
          </XmlRelationshipData>
          <XmlRelationshipData UseFullForm="true" RoleElementName="properties">
            <DomainRelationshipMoniker Name="OptionHasProperties" />
          </XmlRelationshipData>
          <XmlRelationshipData UseFullForm="true" RoleElementName="types">
            <DomainRelationshipMoniker Name="OptionHasTypes" />
          </XmlRelationshipData>
          <XmlPropertyData XmlName="optionType">
            <DomainPropertyMoniker Name="Option/OptionType" />
          </XmlPropertyData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="EvModelHasElements" MonikerAttributeName="" SerializeId="true" MonikerElementName="evModelHasElementsMoniker" ElementName="evModelHasElements" MonikerTypeName="EvModelHasElementsMoniker">
        <DomainRelationshipMoniker Name="EvModelHasElements" />
      </XmlClassData>
      <XmlClassData TypeName="OptionConnector" MonikerAttributeName="" SerializeId="true" MonikerElementName="optionConnectorMoniker" ElementName="optionConnector" MonikerTypeName="OptionConnectorMoniker">
        <ConnectorMoniker Name="OptionConnector" />
      </XmlClassData>
      <XmlClassData TypeName="EvDiagram" MonikerAttributeName="" SerializeId="true" MonikerElementName="evDiagramMoniker" ElementName="evDiagram" MonikerTypeName="EvDiagramMoniker">
        <DiagramMoniker Name="EvDiagram" />
      </XmlClassData>
      <XmlClassData TypeName="OptionHasFunctions" MonikerAttributeName="" SerializeId="true" MonikerElementName="optionHasFunctionsMoniker" ElementName="optionHasFunctions" MonikerTypeName="OptionHasFunctionsMoniker">
        <DomainRelationshipMoniker Name="OptionHasFunctions" />
        <ElementData>
          <XmlPropertyData XmlName="var">
            <DomainPropertyMoniker Name="OptionHasFunctions/Var" />
          </XmlPropertyData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="Function" MonikerAttributeName="" SerializeId="true" MonikerElementName="functionMoniker" ElementName="function" MonikerTypeName="FunctionMoniker">
        <DomainClassMoniker Name="Function" />
        <ElementData>
          <XmlPropertyData XmlName="name">
            <DomainPropertyMoniker Name="Function/Name" />
          </XmlPropertyData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="FunctionShape" MonikerAttributeName="" SerializeId="true" MonikerElementName="functionShapeMoniker" ElementName="functionShape" MonikerTypeName="FunctionShapeMoniker">
        <GeometryShapeMoniker Name="FunctionShape" />
      </XmlClassData>
      <XmlClassData TypeName="OptionShape" MonikerAttributeName="" SerializeId="true" MonikerElementName="optionShapeMoniker" ElementName="optionShape" MonikerTypeName="OptionShapeMoniker">
        <CompartmentShapeMoniker Name="OptionShape" />
      </XmlClassData>
      <XmlClassData TypeName="Property" MonikerAttributeName="" SerializeId="true" MonikerElementName="propertyMoniker" ElementName="property" MonikerTypeName="PropertyMoniker">
        <DomainClassMoniker Name="Property" />
        <ElementData>
          <XmlPropertyData XmlName="name">
            <DomainPropertyMoniker Name="Property/Name" />
          </XmlPropertyData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="OptionHasProperties" MonikerAttributeName="" SerializeId="true" MonikerElementName="optionHasPropertiesMoniker" ElementName="optionHasProperties" MonikerTypeName="OptionHasPropertiesMoniker">
        <DomainRelationshipMoniker Name="OptionHasProperties" />
      </XmlClassData>
      <XmlClassData TypeName="Type" MonikerAttributeName="" SerializeId="true" MonikerElementName="typeMoniker" ElementName="type" MonikerTypeName="TypeMoniker">
        <DomainClassMoniker Name="Type" />
        <ElementData>
          <XmlPropertyData XmlName="name">
            <DomainPropertyMoniker Name="Type/Name" />
          </XmlPropertyData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="OptionHasTypes" MonikerAttributeName="" SerializeId="true" MonikerElementName="optionHasTypesMoniker" ElementName="optionHasTypes" MonikerTypeName="OptionHasTypesMoniker">
        <DomainRelationshipMoniker Name="OptionHasTypes" />
      </XmlClassData>
    </ClassData>
  </XmlSerializationBehavior>
  <ExplorerBehavior Name="EvExplorer" />
  <ConnectionBuilders>
    <ConnectionBuilder Name="OptionConn">
      <LinkConnectDirective>
        <DomainRelationshipMoniker Name="OptionHasFunctions" />
        <SourceDirectives>
          <RolePlayerConnectDirective>
            <AcceptingClass>
              <DomainClassMoniker Name="Option" />
            </AcceptingClass>
          </RolePlayerConnectDirective>
        </SourceDirectives>
        <TargetDirectives>
          <RolePlayerConnectDirective>
            <AcceptingClass>
              <DomainClassMoniker Name="Function" />
            </AcceptingClass>
          </RolePlayerConnectDirective>
        </TargetDirectives>
      </LinkConnectDirective>
    </ConnectionBuilder>
  </ConnectionBuilders>
  <Diagram Id="18d8ea88-f02a-4da7-b1ae-466c771ae44a" Description="Description for Ufba.Ev.EvDiagram" Name="EvDiagram" DisplayName="Minimal Language Diagram" Namespace="Ufba.Ev">
    <Class>
      <DomainClassMoniker Name="EvModel" />
    </Class>
    <ShapeMaps>
      <ShapeMap>
        <DomainClassMoniker Name="Function" />
        <ParentElementPath>
          <DomainPath>OptionHasFunctions.Option/!Option/EvModelHasElements.EvModel/!EvModel</DomainPath>
        </ParentElementPath>
        <DecoratorMap>
          <TextDecoratorMoniker Name="FunctionShape/Name" />
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="Function/Name" />
            </PropertyPath>
          </PropertyDisplayed>
        </DecoratorMap>
        <GeometryShapeMoniker Name="FunctionShape" />
      </ShapeMap>
      <CompartmentShapeMap>
        <DomainClassMoniker Name="Option" />
        <ParentElementPath>
          <DomainPath>EvModelHasElements.EvModel/!EvModel</DomainPath>
        </ParentElementPath>
        <DecoratorMap>
          <TextDecoratorMoniker Name="OptionShape/Type" />
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="Option/OptionType" />
            </PropertyPath>
          </PropertyDisplayed>
        </DecoratorMap>
        <CompartmentShapeMoniker Name="OptionShape" />
        <CompartmentMap>
          <CompartmentMoniker Name="OptionShape/Actions" />
          <ElementsDisplayed>
            <DomainPath>OptionHasTypes.Types/!Type</DomainPath>
          </ElementsDisplayed>
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="Type/Name" />
            </PropertyPath>
          </PropertyDisplayed>
        </CompartmentMap>
        <CompartmentMap>
          <CompartmentMoniker Name="OptionShape/Properties" />
          <ElementsDisplayed>
            <DomainPath>OptionHasProperties.Properties/!Property</DomainPath>
          </ElementsDisplayed>
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="Property/Name" />
            </PropertyPath>
          </PropertyDisplayed>
        </CompartmentMap>
      </CompartmentShapeMap>
    </ShapeMaps>
    <ConnectorMaps>
      <ConnectorMap>
        <ConnectorMoniker Name="OptionConnector" />
        <DomainRelationshipMoniker Name="OptionHasFunctions" />
        <DecoratorMap>
          <TextDecoratorMoniker Name="OptionConnector/Var" />
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="OptionHasFunctions/Var" />
            </PropertyPath>
          </PropertyDisplayed>
        </DecoratorMap>
      </ConnectorMap>
    </ConnectorMaps>
  </Diagram>
  <Designer CopyPasteGeneration="CopyPasteOnly" FileExtension="visualEv" EditorGuid="9e65415c-6a24-47d4-b4fd-71ab2dce39da">
    <RootClass>
      <DomainClassMoniker Name="EvModel" />
    </RootClass>
    <XmlSerializationDefinition CustomPostLoad="false">
      <XmlSerializationBehaviorMoniker Name="EvSerializationBehavior" />
    </XmlSerializationDefinition>
    <ToolboxTab TabText="Ev">
      <ElementTool Name="OptionElement" ToolboxIcon="resources\exampleshapetoolbitmap.bmp" Caption="OptionElement" Tooltip="Create an ExampleElement" HelpKeyword="CreateExampleClassF1Keyword">
        <DomainClassMoniker Name="Option" />
      </ElementTool>
      <ElementTool Name="FunctionElement" ToolboxIcon="Resources\ImplementationTool.bmp" Caption="FunctionElement" Tooltip="Function Element" HelpKeyword="FunctionElement">
        <DomainClassMoniker Name="Function" />
      </ElementTool>
    </ToolboxTab>
    <Validation UsesMenu="true" UsesOpen="true" UsesSave="true" UsesCustom="true" UsesLoad="true" />
    <DiagramMoniker Name="EvDiagram" />
  </Designer>
  <Explorer ExplorerGuid="32284ea2-41db-409c-b31b-4df79fabcf65" Title="Ev Explorer">
    <ExplorerBehaviorMoniker Name="Ev/EvExplorer" />
  </Explorer>
</Dsl>