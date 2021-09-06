
#pragma warning disable 162

namespace Singleton
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(Singleton.__messagetype_Singleton_POIn)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_Rcv : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_Rcv(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_Rcv(PortType_Rcv p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_Rcv p = new PortType_Rcv(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_Rcv),
            typeof(__messagetype_Singleton_POIn),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(Singleton.__messagetype_Singleton_POIn)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_SndPO : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_SndPO(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_SndPO(PortType_SndPO p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_SndPO p = new PortType_SndPO(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_SndPO),
            typeof(__messagetype_Singleton_POIn),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }
    [Microsoft.XLANGs.BaseTypes.CorrelationTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        new string[] {
            "BTS.ReceivePortName"
        }
    )]
    sealed internal class CorrelationTypeRcvPort : Microsoft.XLANGs.Core.CorrelationType
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        private static Microsoft.XLANGs.BaseTypes.PropertyBase[] _properties = new Microsoft.XLANGs.BaseTypes.PropertyBase[] {
            new BTS.ReceivePortName()
         };
        public override Microsoft.XLANGs.BaseTypes.PropertyBase[] Properties { get { return _properties; } }
        public static Microsoft.XLANGs.BaseTypes.PropertyBase[] PropertiesList { get { return _properties; } }
    }
    //#line 269 "E:\shobh\Work_Wellsky\SingletonProofOfConcept\Singleton\Convoy.odx"
    [Microsoft.XLANGs.BaseTypes.StaticConvoyAttribute(
        0,
        new System.Type[] { typeof(CorrelationTypeRcvPort) }
    )]
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "PortRcv", "Operation_1", -1, 0, true
    )]
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        1, "PortRcv", "Operation_1", -1, 0, false
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(Singleton.PortType_Rcv),
            typeof(Singleton.PortType_SndPO)
        },
        new System.String[] {
            "PortRcv",
            "PortSnd"
        },
        new System.Type[] {
            null,
            null
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceCallTreeAttribute(
        new System.Type[] {
        },
        new System.Type[] {
        },
        new System.Type[] {
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eNone
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class Convoy : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = false;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eNone,
            new System.String[] {
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy()
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(Convoy));
        private static volatile System.Guid[] _activationSubIds;

        private static new object _lockIdentity = new object();

        public static System.Guid UUID { get { return _serviceId; } }
        public override System.Guid ServiceId { get { return UUID; } }

        protected override System.Guid[] ActivationSubGuids
        {
            get { return _activationSubIds; }
            set { _activationSubIds = value; }
        }

        protected override object StaleStateLock
        {
            get { return _lockIdentity; }
        }

        protected override bool HasActivation { get { return true; } }

        internal bool IsExeced = false;

        static Convoy()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment2), 1, 2, 2),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment3), 1, 2, 3)
            };

            _Locks = 0;
            _rootContext = new __Convoy_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[3];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public Convoy(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "Convoy", tracker)
        {
            ConstructorHelper();
        }

        public Convoy(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "Convoy")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>915dc366-3428-4c93-8e3b-7a2663299b82</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>3af22ab9-3d67-49e2-a3cf-f109b25b0270</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>ReceivePOIn</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>WhileShape</shapeType>      <ShapeID>41169341-9830-4bc5-bfbb-bae2f73a13cb</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>LoopInfinite</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ScopeShape</shapeType>      <ShapeID>e768a8c2-242f-4868-9360-3042c11872b0</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Scope_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>1ad7395b-69de-4ed1-b1cc-2a63fc385129</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Expression_IsException</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>e6118d39-d647-49d3-8d11-819ef61a142e</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_MsgOut</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>286de9ab-6f45-4057-b982-db8cf0e7ff2b</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>c9f8c5f0-9e74-4992-ba21-424519ec2059</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>bb430472-3267-41a2-9b6b-35d973d6c5d0</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>SendPOOut</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CatchShape</shapeType>      <ShapeID>41a267ac-4f45-4f34-a4af-4f876ea16a65</ShapeID>      <ParentLink>Scope_Catch</ParentLink>                <shapeText>SystemException</shapeText>                      <ExceptionType>System.Exception</ExceptionType>            
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>2e514450-2197-44ba-8fc0-50d4021e6fcf</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Expression_log</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ListenShape</shapeType>      <ShapeID>c8b7dedd-19c4-471d-89a6-a21243627088</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Listen_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ListenBranchShape</shapeType>      <ShapeID>e538c7de-9fd8-44e5-8c51-000f39a443d6</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>ListenBranch_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>2a4f5302-4d8e-47b2-ba9d-aa601ad526e8</ShapeID>      <ParentLink>ListenBranch_Statement</ParentLink>                <shapeText>ReceiveCovoy</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ListenBranchShape</shapeType>      <ShapeID>23facc12-127c-4e48-8f60-3a6ed5c0e91e</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>ListenBranch_2</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TerminateShape</shapeType>      <ShapeID>a03b82f3-e726-4f44-8142-169c8ec72090</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>TermConvoy</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DelayShape</shapeType>      <ShapeID>f1b54870-181e-422b-928c-7f02fae16eef</ShapeID>      <ParentLink>ListenBranch_Statement</ParentLink>                <shapeText>Delay_10s</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'Convoy'</ActionName><IsAtomic>0</IsAtomic><Line>269</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>281</Line><Position>22</Position><ShapeID>'3af22ab9-3d67-49e2-a3cf-f109b25b0270'</ShapeID>
<Messages>
	<MsgInfo><name>MsgIn</name><part>part</part><schema>Singleton.POIn</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>283</Line><Position>13</Position><ShapeID>'41169341-9830-4bc5-bfbb-bae2f73a13cb'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<ActionName>'??__scope33'</ActionName><IsAtomic>0</IsAtomic><Line>286</Line><Position>17</Position><ShapeID>'e768a8c2-242f-4868-9360-3042c11872b0'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>291</Line><Position>25</Position><ShapeID>'1ad7395b-69de-4ed1-b1cc-2a63fc385129'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>296</Line><Position>25</Position><ShapeID>'e6118d39-d647-49d3-8d11-819ef61a142e'</ShapeID>
<Messages>
	<MsgInfo><name>MsgOut</name><part>part</part><schema>Singleton.POIn</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>303</Line><Position>25</Position><ShapeID>'bb430472-3267-41a2-9b6b-35d973d6c5d0'</ShapeID>
<Messages>
	<MsgInfo><name>MsgOut</name><part>part</part><schema>Singleton.POIn</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>308</Line><Position>25</Position><ShapeID>'41a267ac-4f45-4f34-a4af-4f876ea16a65'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>311</Line><Position>67</Position><ShapeID>'2e514450-2197-44ba-8fc0-50d4021e6fcf'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>317</Line><Position>17</Position><ShapeID>'c8b7dedd-19c4-471d-89a6-a21243627088'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>319</Line><Position>27</Position><ShapeID>'2a4f5302-4d8e-47b2-ba9d-aa601ad526e8'</ShapeID>
<Messages>
	<MsgInfo><name>MsgIn</name><part>part</part><schema>Singleton.POIn</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>326</Line><Position>25</Position><ShapeID>'a03b82f3-e726-4f44-8142-169c8ec72090'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='ebb21175-f258-429c-a2fa-f0ffd5a1317a' LowerBound='1.1' HigherBound='87.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='Singleton' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='fc491db1-135d-42c6-af83-236a4b36226b' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_Rcv' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='28f27296-5c7c-40ca-b20f-3b48be08b99d' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='0f80f304-0563-4d8c-bce6-cd6184fae950' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.17'>
                    <om:Property Name='Ref' Value='Singleton.POIn' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='64e94fdd-8591-426a-bea3-17a9cf4114ce' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_SndPO' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='a1b66e65-a7e1-4a7d-8eb5-a822f00207df' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='9f67c323-e179-4b5c-b595-4d9c6971eda3' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.17'>
                    <om:Property Name='Ref' Value='Singleton.POIn' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='CorrelationType' OID='dbb643d5-95b5-4a6c-b397-205f9704d8aa' ParentLink='Module_CorrelationType' LowerBound='18.1' HigherBound='22.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='CorrelationTypeRcvPort' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PropertyRef' OID='3f4d1ad3-cd1d-47d5-8fc4-f37b0b886a07' ParentLink='CorrelationType_PropertyRef' LowerBound='20.9' HigherBound='20.28'>
                <om:Property Name='Ref' Value='BTS.ReceivePortName' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='PropertyRef_1' />
                <om:Property Name='Signal' Value='False' />
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='10b7bdd5-a89b-4cd9-8059-80744e08c9c4' ParentLink='Module_ServiceDeclaration' LowerBound='22.1' HigherBound='86.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='Convoy' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='CorrelationDeclaration' OID='6a32a49e-4e7a-49d4-8c48-6a8333a21a38' ParentLink='ServiceDeclaration_CorrelationDeclaration' LowerBound='29.1' HigherBound='30.1'>
                <om:Property Name='Type' Value='Singleton.CorrelationTypeRcvPort' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='CorrelationSet' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='StatementRef' OID='74fd2e2b-96e6-4ec9-9fca-20e6f4fc3f60' ParentLink='CorrelationDeclaration_StatementRef' LowerBound='35.59' HigherBound='35.84'>
                    <om:Property Name='Initializes' Value='True' />
                    <om:Property Name='Ref' Value='3af22ab9-3d67-49e2-a3cf-f109b25b0270' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='StatementRef_1' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='StatementRef' OID='c2e76a7f-19b7-48aa-9eb5-461ee339091e' ParentLink='CorrelationDeclaration_StatementRef' LowerBound='73.64' HigherBound='73.78'>
                    <om:Property Name='Initializes' Value='False' />
                    <om:Property Name='Ref' Value='2a4f5302-4d8e-47b2-ba9d-aa601ad526e8' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='StatementRef_2' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='bbfddb06-d5cb-455c-9262-1b4c754c15b9' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='30.1' HigherBound='31.1'>
                <om:Property Name='Type' Value='Singleton.POIn' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MsgIn' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='e6b68124-1e73-440e-8288-3bdf07963752' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='31.1' HigherBound='32.1'>
                <om:Property Name='Type' Value='Singleton.POIn' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MsgOut' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='915dc366-3428-4c93-8e3b-7a2663299b82' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='3af22ab9-3d67-49e2-a3cf-f109b25b0270' ParentLink='ServiceBody_Statement' LowerBound='34.1' HigherBound='36.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='PortRcv' />
                    <om:Property Name='MessageName' Value='MsgIn' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ReceivePOIn' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='While' OID='41169341-9830-4bc5-bfbb-bae2f73a13cb' ParentLink='ServiceBody_Statement' LowerBound='36.1' HigherBound='84.1'>
                    <om:Property Name='Expression' Value='true' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='LoopInfinite' />
                    <om:Property Name='Signal' Value='False' />
                    <om:Element Type='Scope' OID='e768a8c2-242f-4868-9360-3042c11872b0' ParentLink='ComplexStatement_Statement' LowerBound='39.1' HigherBound='69.1'>
                        <om:Property Name='InitializedTransactionType' Value='True' />
                        <om:Property Name='IsSynchronized' Value='False' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Scope_1' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='VariableAssignment' OID='1ad7395b-69de-4ed1-b1cc-2a63fc385129' ParentLink='ComplexStatement_Statement' LowerBound='44.1' HigherBound='49.1'>
                            <om:Property Name='Expression' Value='if ((System.Boolean) xpath(MsgIn, &quot;string(/*[local-name()=&apos;Root&apos; and namespace-uri()=&apos;http://Singleton.POIn&apos;]/*[local-name()=&apos;IsException&apos; and namespace-uri()=&apos;&apos;])&quot;) == true)&#xD;&#xA;{&#xD;&#xA;    throw new System.Exception(&quot;The message has exception flag.&quot;);&#xD;&#xA;}' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Expression_IsException' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Construct' OID='e6118d39-d647-49d3-8d11-819ef61a142e' ParentLink='ComplexStatement_Statement' LowerBound='49.1' HigherBound='56.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='ConstructMessage_MsgOut' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='MessageAssignment' OID='286de9ab-6f45-4057-b982-db8cf0e7ff2b' ParentLink='ComplexStatement_Statement' LowerBound='52.1' HigherBound='55.1'>
                                <om:Property Name='Expression' Value='MsgOut = MsgIn;&#xD;&#xA;MsgOut(*) = MsgIn(*);' />
                                <om:Property Name='ReportToAnalyst' Value='False' />
                                <om:Property Name='Name' Value='MessageAssignment_1' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                            <om:Element Type='MessageRef' OID='c9f8c5f0-9e74-4992-ba21-424519ec2059' ParentLink='Construct_MessageRef' LowerBound='50.35' HigherBound='50.41'>
                                <om:Property Name='Ref' Value='MsgOut' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='Send' OID='bb430472-3267-41a2-9b6b-35d973d6c5d0' ParentLink='ComplexStatement_Statement' LowerBound='56.1' HigherBound='58.1'>
                            <om:Property Name='PortName' Value='PortSnd' />
                            <om:Property Name='MessageName' Value='MsgOut' />
                            <om:Property Name='OperationName' Value='Operation_1' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='SendPOOut' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Catch' OID='41a267ac-4f45-4f34-a4af-4f876ea16a65' ParentLink='Scope_Catch' LowerBound='61.1' HigherBound='67.1'>
                            <om:Property Name='ExceptionName' Value='ex' />
                            <om:Property Name='ExceptionType' Value='System.Exception' />
                            <om:Property Name='IsFaultMessage' Value='False' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='SystemException' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='VariableAssignment' OID='2e514450-2197-44ba-8fc0-50d4021e6fcf' ParentLink='Catch_Statement' LowerBound='64.1' HigherBound='66.1'>
                                <om:Property Name='Expression' Value='System.Diagnostics.EventLog.WriteEntry(&quot;SingletonApp&quot;, &quot;Exception Error: &quot; + ex.Message);' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Expression_log' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Listen' OID='c8b7dedd-19c4-471d-89a6-a21243627088' ParentLink='ComplexStatement_Statement' LowerBound='69.1' HigherBound='83.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Listen_1' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='ListenBranch' OID='e538c7de-9fd8-44e5-8c51-000f39a443d6' ParentLink='ReallyComplexStatement_Branch' LowerBound='69.1' HigherBound='69.1'>
                            <om:Property Name='IsGhostBranch' Value='True' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='ListenBranch_1' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='Receive' OID='2a4f5302-4d8e-47b2-ba9d-aa601ad526e8' ParentLink='ListenBranch_Statement' LowerBound='72.1' HigherBound='73.79'>
                                <om:Property Name='Activate' Value='False' />
                                <om:Property Name='PortName' Value='PortRcv' />
                                <om:Property Name='MessageName' Value='MsgIn' />
                                <om:Property Name='OperationName' Value='Operation_1' />
                                <om:Property Name='OperationMessageName' Value='Request' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='ReceiveCovoy' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='ListenBranch' OID='23facc12-127c-4e48-8f60-3a6ed5c0e91e' ParentLink='ReallyComplexStatement_Branch' LowerBound='69.1' HigherBound='69.1'>
                            <om:Property Name='IsGhostBranch' Value='True' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='ListenBranch_2' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='Terminate' OID='a03b82f3-e726-4f44-8142-169c8ec72090' ParentLink='ComplexStatement_Statement' LowerBound='79.1' HigherBound='81.1'>
                                <om:Property Name='ErrorMessage' Value='&quot;Convoy terminated because no new messages received&quot;;' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='TermConvoy' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                            <om:Element Type='Delay' OID='f1b54870-181e-422b-928c-7f02fae16eef' ParentLink='ListenBranch_Statement' LowerBound='76.1' HigherBound='77.58'>
                                <om:Property Name='Timeout' Value='new System.TimeSpan(0,0,0,10)' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Delay_10s' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                        </om:Element>
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='3469dbec-f9df-48da-acb3-60a1175a120b' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='25.1' HigherBound='27.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Singleton.PortType_Rcv' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='PortRcv' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='LogicalBindingAttribute' OID='2712716b-9e4f-41d4-9e40-0f7b7c2a6f26' ParentLink='PortDeclaration_CLRAttribute' LowerBound='25.1' HigherBound='26.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='40dee888-f661-4a26-b2f7-8809e6c97247' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='27.1' HigherBound='29.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='Singleton.PortType_SndPO' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='PortSnd' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='07669093-da5e-4482-b773-b7399cf0ae04' ParentLink='PortDeclaration_CLRAttribute' LowerBound='27.1' HigherBound='28.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __Convoy_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __Convoy_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "Convoy")
            {
            }

            public override int Index { get { return 0; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[0]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[0]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                Convoy __svc__ = (Convoy)_service;
                __Convoy_root_0 __ctx0__ = (__Convoy_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.PortRcv != null)
                {
                    __svc__.PortRcv.Close(this, null);
                    __svc__.PortRcv = null;
                }
                if (__svc__.PortSnd != null)
                {
                    __svc__.PortSnd.Close(this, null);
                    __svc__.PortSnd = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper1;
        }


        [System.SerializableAttribute]
        public class __Convoy_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __Convoy_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "Convoy")
            {
            }

            public override int Index { get { return 1; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[1]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[1]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                Convoy __svc__ = (Convoy)_service;
                __Convoy_1 __ctx1__ = (__Convoy_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__MsgIn != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__MsgIn);
                    __ctx1__.__MsgIn = null;
                }
                if (__ctx1__ != null && __ctx1__.__CorrelationSet != null)
                    __ctx1__.__CorrelationSet = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("MsgIn")]
            public __messagetype_Singleton_POIn __MsgIn;
            [Microsoft.XLANGs.Core.UserVariableAttribute("MsgOut")]
            public __messagetype_Singleton_POIn __MsgOut;
            [Microsoft.XLANGs.Core.UserVariableAttribute("CorrelationSet")]
            internal Microsoft.XLANGs.Core.Correlation __CorrelationSet;
        }


        [System.SerializableAttribute]
        public class ____scope33_2 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public ____scope33_2(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "??__scope33")
            {
            }

            public override int Index { get { return 2; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[2]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[2]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Microsoft.XLANGs.Core.Segment __seg__;
                Microsoft.XLANGs.Core.FaultReceiveException __fault__;

                __exv__ = _exception;
                if (!(__exv__ is Microsoft.XLANGs.Core.UnknownException))
                {
                    __fault__ = __exv__ as Microsoft.XLANGs.Core.FaultReceiveException;
                    if ((__fault__ == null) && (__exv__ is System.Exception))
                    {
                        __seg__ = _service._segments[3];
                        __seg__.Reset(1);
                        __seg__.PredecessorDone(_service);
                        return true;
                    }
                }

                Finally();
                return false;
            }

            public override void Finally()
            {
                Convoy __svc__ = (Convoy)_service;
                ____scope33_2 __ctx2__ = (____scope33_2)(__svc__._stateMgrs[2]);
                __Convoy_1 __ctx1__ = (__Convoy_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__MsgOut != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__MsgOut);
                    __ctx1__.__MsgOut = null;
                }
                if (__ctx2__ != null)
                    __ctx2__.__ex_0 = null;
                base.Finally();
            }

            internal object __exv__;
            internal System.Exception __ex_0
            {
                get { return (System.Exception)__exv__; }
                set { __exv__ = value; }
            }
        }

        private static Microsoft.XLANGs.Core.CorrelationType[] _correlationTypes = new Microsoft.XLANGs.Core.CorrelationType[] { new CorrelationTypeRcvPort() };
        public override Microsoft.XLANGs.Core.CorrelationType[] CorrelationTypes { get { return _correlationTypes; } }

        private static System.Guid[] _convoySetIds;

        public override System.Guid[] ConvoySetGuids
        {
            get { return _convoySetIds; }
            set { _convoySetIds = value; }
        }

        public static object[] StaticConvoySetInformation
        {
            get {
                return new object[] {
                    new Microsoft.XLANGs.Core.CorrelationType[] { _correlationTypes[0] }
                };
            }
        }

        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("PortRcv")]
        internal PortType_Rcv PortRcv;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("PortSnd")]
        internal PortType_SndPO PortSnd;
        System.Guid __timeout0__;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_Rcv.Operation_1},
                                               typeof(Convoy).GetField("PortRcv", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(Convoy), "PortRcv"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_SndPO.Operation_1},
                                               typeof(Convoy).GetField("PortSnd", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(Convoy), "PortSnd"),
                                               null)
        };

        public override Microsoft.XLANGs.Core.PortInfo[] PortInformation
        {
            get { return _portInfo; }
        }

        static public System.Collections.Hashtable PortsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[_portInfo[0].Name] = _portInfo[0];
                h[_portInfo[1].Name] = _portInfo[1];
                return h;
            }
        }

        public static System.Type[] InvokedServicesTypes
        {
            get
            {
                return new System.Type[] {
                    // type of each service invoked by this service
                };
            }
        }

        public static System.Type[] CalledServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static System.Type[] ExecedServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static object[] StaticSubscriptionsInformation {
            get {
                return new object[2]{
                     new object[5] { _portInfo[0], 0, null , 0, true }
                    , new object[5] { _portInfo[0], 0, null , 0, false }
                };
            }
        }

        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "3af22ab9-3d67-49e2-a3cf-f109b25b0270", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "3af22ab9-3d67-49e2-a3cf-f109b25b0270", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "41169341-9830-4bc5-bfbb-bae2f73a13cb", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "e768a8c2-242f-4868-9360-3042c11872b0", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "00000000-0000-0000-0000-000000000000", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "1ad7395b-69de-4ed1-b1cc-2a63fc385129", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "1ad7395b-69de-4ed1-b1cc-2a63fc385129", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "e6118d39-d647-49d3-8d11-819ef61a142e", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "e6118d39-d647-49d3-8d11-819ef61a142e", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "bb430472-3267-41a2-9b6b-35d973d6c5d0", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "bb430472-3267-41a2-9b6b-35d973d6c5d0", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "41a267ac-4f45-4f34-a4af-4f876ea16a65", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "2e514450-2197-44ba-8fc0-50d4021e6fcf", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "2e514450-2197-44ba-8fc0-50d4021e6fcf", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "41a267ac-4f45-4f34-a4af-4f876ea16a65", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "e768a8c2-242f-4868-9360-3042c11872b0", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "c8b7dedd-19c4-471d-89a6-a21243627088", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "2a4f5302-4d8e-47b2-ba9d-aa601ad526e8", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(19, "2a4f5302-4d8e-47b2-ba9d-aa601ad526e8", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(20, "f1b54870-181e-422b-928c-7f02fae16eef", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(21, "f1b54870-181e-422b-928c-7f02fae16eef", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(22, "a03b82f3-e726-4f44-8142-169c8ec72090", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(23, "c8b7dedd-19c4-471d-89a6-a21243627088", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(24, "41169341-9830-4bc5-bfbb-bae2f73a13cb", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(25, "00000000-0000-0000-0000-000000000000", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.WhileBody),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.While),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Scope),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Throw),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Scope),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Listen),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Delay),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Delay),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Terminate),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Listen),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.While),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.WhileBody),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,25,25,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,3,3,3,4,4,4,16,17,17,17,18,19,17,20,21,22,22,17,17,23,24,24,24,25,25,25,25,};
        public static int[] __progressLocation2 = new int[] { 6,6,6,6,6,7,8,8,9,10,10,10,11,11,11,11,};
        public static int[] __progressLocation3 = new int[] { 12,12,13,13,14,15,15,};

        public static int[][] __progressLocations = new int[4] [] {__progressLocation0,__progressLocation1,__progressLocation2,__progressLocation3};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __Convoy_root_0 __ctx0__ = (__Convoy_root_0)_stateMgrs[0];
            __Convoy_1 __ctx1__ = (__Convoy_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                PortRcv = new PortType_Rcv(0, this);
                PortSnd = new PortType_SndPO(1, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], PortRcv, this);
                __ctx0__.__subWrapper1 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[1], PortRcv, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __Convoy_1(this);
                _stateMgrs[1] = __ctx1__;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                __ctx0__.StartContext(__seg__, __ctx1__);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 3:
                if (!__ctx0__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.Finally();
                ServiceDone(__seg__, (Microsoft.XLANGs.Core.Context)_stateMgrs[0]);
                __ctx0__.OnCommit();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment1(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            bool __condition__;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __Convoy_root_0 __ctx0__ = (__Convoy_root_0)_stateMgrs[0];
            ____scope33_2 __ctx2__ = (____scope33_2)_stateMgrs[2];
            __Convoy_1 __ctx1__ = (__Convoy_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[0],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.__CorrelationSet = new Microsoft.XLANGs.Core.Correlation(this, 0, 0);
                Tracker.FireEvent(__eventLocations[1],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                if (!PortRcv.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__MsgIn != null)
                    __ctx1__.UnrefMessage(__ctx1__.__MsgIn);
                __ctx1__.__MsgIn = new __messagetype_Singleton_POIn("MsgIn", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__MsgIn);
                PortRcv.ReceiveMessage(0, __msgEnv__, __ctx1__.__MsgIn, new Microsoft.XLANGs.Core.Correlation[] { __ctx1__.__CorrelationSet }, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__MsgIn);
                    __edata.PortName = @"PortRcv";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                __condition__ = true;
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 27 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 27;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                __ctx2__ = new ____scope33_2(this);
                _stateMgrs[2] = __ctx2__;
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                __ctx1__.StartContext(__seg__, __ctx2__);
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[16],__eventData[14],_stateMgrs[1].TrackDataStream );
                __ctx2__.Finally();
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[17],__eventData[15],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                __timeout0__ = __ctx1__.PostTimeout(System.DateTime.UtcNow.Add(new System.TimeSpan(0, 0, 0, 10)));
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                {
                    int idx = Microsoft.XLANGs.Core.PortBase.ListenForMessageId(new Microsoft.XLANGs.Core.Subscription[] { LookupSubscription( __timeout0__ ), __ctx0__.__subWrapper1.getSubscription(this) }, __seg__, __ctx1__, out __msgEnv__ , _locations[0]);
                    if (idx < 0) {
                        return Microsoft.XLANGs.Core.StopConditions.Blocked;
                    }
                    else if (idx == 0) {
                        if ( !PostProgressInc( __seg__, __ctx__, 18 ) )
                            return Microsoft.XLANGs.Core.StopConditions.Paused;
                        goto case 18;
                    }
                    else if (idx == 1) {
                        if (__ctx1__.__MsgIn != null)
                            __ctx1__.UnrefMessage(__ctx1__.__MsgIn);
                        __ctx1__.__MsgIn = new __messagetype_Singleton_POIn("MsgIn", __ctx1__);
                        __ctx1__.RefMessage(__ctx1__.__MsgIn);
                        PortRcv.ReceiveMessage(0, __msgEnv__, __ctx1__.__MsgIn, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                        if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                            return Microsoft.XLANGs.Core.StopConditions.Paused;
                        goto case 15;
                    }
                }
                break;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[18],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__MsgIn);
                    __edata.PortName = @"PortRcv";
                    Tracker.FireEvent(__eventLocations[19],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 17;
            case 17:
                if ( !PostProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 23;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[20],__eventData[16],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                if ( !PreProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[21],__eventData[17],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 20;
            case 20:
                if ( !PreProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[22],__eventData[18],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 21;
            case 21:
                RequestTerminate(__ctx1__,"Convoy terminated because no new messages received");
                __seg__.SegmentDone();
                break;
            case 22:
                if ( !PostProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 23;
            case 23:
                DeleteTimeout(LookupSubscription(__timeout0__));
                if ( !PostProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 24;
            case 24:
                if ( !PreProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[23],__eventData[19],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 25;
            case 25:
                if ( !PreProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[24],__eventData[20],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 26;
            case 26:
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 27:
                if ( !PreProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null && __ctx1__.__CorrelationSet != null)
                    __ctx1__.__CorrelationSet = null;
                if (__ctx1__ != null && __ctx1__.__MsgIn != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__MsgIn);
                    __ctx1__.__MsgIn = null;
                }
                if (PortSnd != null)
                {
                    PortSnd.Close(__ctx1__, __seg__);
                    PortSnd = null;
                }
                if (PortRcv != null)
                {
                    PortRcv.Close(__ctx1__, __seg__);
                    PortRcv = null;
                }
                Tracker.FireEvent(__eventLocations[24],__eventData[21],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 28;
            case 28:
                if ( !PreProgressInc( __seg__, __ctx__, 29 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[25],__eventData[22],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 29;
            case 29:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 30;
            case 30:
                if ( !PreProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 31;
            case 31:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment2(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            bool __condition__;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[2];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[2];
            __Convoy_root_0 __ctx0__ = (__Convoy_root_0)_stateMgrs[0];
            ____scope33_2 __ctx2__ = (____scope33_2)_stateMgrs[2];
            __Convoy_1 __ctx1__ = (__Convoy_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                __condition__ = (System.Boolean)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__MsgIn.part, "string(/*[local-name()='Root' and namespace-uri()='http://Singleton.POIn']/*[local-name()='IsException' and namespace-uri()=''])", typeof(System.Boolean));
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 5;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 3;
            case 3:
                if ( !PreProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 4;
            case 4:
                throw new System.Exception("The message has exception flag.");
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[7],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 7;
            case 7:
                {
                    __messagetype_Singleton_POIn __MsgOut = new __messagetype_Singleton_POIn("MsgOut", __ctx1__);

                    __MsgOut.CopyFrom(__ctx1__.__MsgIn);
                    __MsgOut.CopyContextPropertiesFrom(__ctx1__.__MsgIn);

                    if (__ctx1__.__MsgOut != null)
                        __ctx1__.UnrefMessage(__ctx1__.__MsgOut);
                    __ctx1__.__MsgOut = __MsgOut;
                    __ctx1__.RefMessage(__ctx1__.__MsgOut);
                }
                __ctx1__.__MsgOut.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__MsgOut);
                    Tracker.FireEvent(__eventLocations[9],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[10],__eventData[9],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                PortSnd.SendMessage(0, __ctx1__.__MsgOut, null, null, __ctx2__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__MsgOut);
                    __edata.PortName = @"PortSnd";
                    Tracker.FireEvent(__eventLocations[11],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__MsgOut != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__MsgOut);
                    __ctx1__.__MsgOut = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                if (!__ctx2__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx2__.OnCommit();
                goto case 15;
            case 15:
                __seg__.SegmentDone();
                _segments[1].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment3(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[3];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[2];
            ____scope33_2 __ctx2__ = (____scope33_2)_stateMgrs[2];

            switch (__seg__.Progress)
            {
            case 0:
                OnBeginCatchHandler(2);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[12],__eventData[10],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[13],__eventData[11],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                System.Diagnostics.EventLog.WriteEntry("SingletonApp", "Exception Error: " + __ctx2__.__ex_0.Message);
                if (__ctx2__ != null)
                    __ctx2__.__ex_0 = null;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[14],__eventData[12],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[15],__eventData[13],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                __ctx2__.__exv__ = null;
                OnEndCatchHandler(2, __seg__);
                __seg__.SegmentDone();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
        private static Microsoft.XLANGs.Core.CachedObject[] _locations = new Microsoft.XLANGs.Core.CachedObject[] {
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{02957002-CC81-4982-A845-CEDFFD5FA7E1}"))
        };

    }

    [System.SerializableAttribute]
    sealed public class __Singleton_POIn__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Singleton.POIn _schema = new Singleton.POIn();

        public __Singleton_POIn__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "Singleton.POIn",
        new System.Type[]{
            typeof(Singleton.POIn)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Singleton_POIn__)
        },
        0,
        @"http://Singleton.POIn#Root"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_Singleton_POIn : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Singleton_POIn__ part;

        private void __CreatePartWrappers()
        {
            part = new __Singleton_POIn__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_Singleton_POIn(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
