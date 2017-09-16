<?xml version="1.0" encoding="utf-8"?>
<Dsl xmlns:dm0="http://schemas.microsoft.com/VisualStudio/2008/DslTools/Core" dslVersion="1.0.0.0" Id="10960b28-2a5c-4690-bc14-a4463850e3d4" Description="Description for Ufba.Ev.Ev" Name="Ev" DisplayName="Ev" Namespace="Ufba.Ev" ProductName="Ev" CompanyName="Ufba" PackageGuid="623cb3cb-ecfa-457c-8465-c0634384012d" PackageNamespace="Ufba.Ev" xmlns="http://schemas.microsoft.com/VisualStudio/2005/DslTools/DslDefinitionModel">
  <Classes>
    <DomainClass Id="2f5d49ad-6ddd-4b45-bfe7-98718ee823d3" Description="The root in which all other elements are embedded. Appears as a diagram." Name="EvModel" DisplayName="Ev Model" Namespace="Ufba.Ev">
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
        <DomainProperty Id="978af1b3-2cbf-4733-98a7-7abac848a18a" Description="Description for Ufba.Ev.Option.Type" Name="Type" DisplayName="Type" DefaultValue="" IsElementName="true">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
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
      </ElementMergeDirectives>
    </DomainClass>
    <DomainClass Id="a1d03807-55e4-4045-acb7-598e4eefae80" Description="Description for Ufba.Ev.Function" Name="Function" DisplayName="Function" Namespace="Ufba.Ev">
      <Properties>
        <DomainProperty Id="119461ac-c927-4f97-bb68-11eee99e5d16" Description="Description for Ufba.Ev.Function.Name" Name="Name" DisplayName="Name">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
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
  </Types>
  <Shapes>
    <GeometryShape Id="2ab20784-2c55-4ce9-ae4f-00710a4b6863" Description="Shape used to represent ExampleElements on a Diagram." Name="OptionShape" DisplayName="Option Shape" Namespace="Ufba.Ev" FixedTooltipText="Option Shape" FillColor="0, 192, 192" OutlineColor="113, 111, 110" InitialWidth="2" InitialHeight="0.75" OutlineThickness="0.01" Geometry="Rectangle">
      <Notes>The shape has a text decorator used to display the Name property of the mapped ExampleElement.</Notes>
      <ShapeHasDecorators Position="Center" HorizontalOffset="0" VerticalOffset="0">
        <TextDecorator Name="NameDecorator" DisplayName="Name Decorator" DefaultText="NameDecorator" />
      </ShapeHasDecorators>
    </GeometryShape>
    <GeometryShape Id="9e94b808-f9f7-45db-89e1-5c609151267f" Description="Description for Ufba.Ev.FunctionShape" Name="FunctionShape" DisplayName="Function Shape" Namespace="Ufba.Ev" FixedTooltipText="Function Shape" FillColor="DarkRed" InitialHeight="1" Geometry="Rectangle">
      <ShapeHasDecorators Position="InnerTopLeft" HorizontalOffset="0" VerticalOffset="0">
        <TextDecorator Name="Name" DisplayName="Name" DefaultText="Name" />
      </ShapeHasDecorators>
    </GeometryShape>
  </Shapes>
  <Connectors>
    <Connector Id="ce04cb6b-f0cc-46b9-8ed0-eacd62889875" Description="Connector between the ExampleShapes. Represents ExampleRelationships on the Diagram." Name="ExampleConnector" DisplayName="Example Connector" Namespace="Ufba.Ev" FixedTooltipText="Example Connector" Color="Fuchsia" TargetEndStyle="EmptyArrow" Thickness="0.01">
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
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="Option" MonikerAttributeName="type" SerializeId="true" MonikerElementName="optionMoniker" ElementName="option" MonikerTypeName="OptionMoniker">
        <DomainClassMoniker Name="Option" />
        <ElementData>
          <XmlPropertyData XmlName="type" IsMonikerKey="true">
            <DomainPropertyMoniker Name="Option/Type" />
          </XmlPropertyData>
          <XmlRelationshipData UseFullForm="true" RoleElementName="functions">
            <DomainRelationshipMoniker Name="OptionHasFunctions" />
          </XmlRelationshipData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="EvModelHasElements" MonikerAttributeName="" SerializeId="true" MonikerElementName="evModelHasElementsMoniker" ElementName="evModelHasElements" MonikerTypeName="EvModelHasElementsMoniker">
        <DomainRelationshipMoniker Name="EvModelHasElements" />
      </XmlClassData>
      <XmlClassData TypeName="OptionShape" MonikerAttributeName="" SerializeId="true" MonikerElementName="optionShapeMoniker" ElementName="optionShape" MonikerTypeName="OptionShapeMoniker">
        <GeometryShapeMoniker Name="OptionShape" />
      </XmlClassData>
      <XmlClassData TypeName="ExampleConnector" MonikerAttributeName="" SerializeId="true" MonikerElementName="exampleConnectorMoniker" ElementName="exampleConnector" MonikerTypeName="ExampleConnectorMoniker">
        <ConnectorMoniker Name="ExampleConnector" />
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
        <DomainClassMoniker Name="Option" />
        <ParentElementPath>
          <DomainPath>EvModelHasElements.EvModel/!EvModel</DomainPath>
        </ParentElementPath>
        <DecoratorMap>
          <TextDecoratorMoniker Name="OptionShape/NameDecorator" />
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="Option/Type" />
            </PropertyPath>
          </PropertyDisplayed>
        </DecoratorMap>
        <GeometryShapeMoniker Name="OptionShape" />
      </ShapeMap>
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
    </ShapeMaps>
    <ConnectorMaps>
      <ConnectorMap>
        <ConnectorMoniker Name="ExampleConnector" />
        <DomainRelationshipMoniker Name="OptionHasFunctions" />
        <DecoratorMap>
          <TextDecoratorMoniker Name="ExampleConnector/Var" />
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
      <ConnectionTool Name="OptionRelationship" ToolboxIcon="resources\exampleconnectortoolbitmap.bmp" Caption="OptionRelationship" Tooltip="Drag between ExampleElements to create an ExampleRelationship" HelpKeyword="ConnectExampleRelationF1Keyword">
        <ConnectionBuilderMoniker Name="Ev/OptionConn" />
      </ConnectionTool>
      <ElementTool Name="FunctionElement" ToolboxIcon="C:\Users\ana.ufba\Downloads\Language4\Language4\Dsl\Resources\ImplementationTool.bmp" Caption="FunctionElement" Tooltip="Function Element" HelpKeyword="FunctionElement">
        <DomainClassMoniker Name="Function" />
      </ElementTool>
    </ToolboxTab>
    <Validation UsesMenu="false" UsesOpen="false" UsesSave="false" UsesLoad="false" />
    <DiagramMoniker Name="EvDiagram" />
  </Designer>
  <Explorer ExplorerGuid="32284ea2-41db-409c-b31b-4df79fabcf65" Title="Ev Explorer">
    <ExplorerBehaviorMoniker Name="Ev/EvExplorer" />
  </Explorer>
</Dsl>