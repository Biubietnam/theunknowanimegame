using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000AD1 RID: 2769
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MGLAPEBCMOO : IMessage<MGLAPEBCMOO>, IMessage, IEquatable<MGLAPEBCMOO>, IDeepCloneable<MGLAPEBCMOO>, IBufferMessage
	{
		// Token: 0x1700226F RID: 8815
		// (get) Token: 0x06007AA8 RID: 31400 RVA: 0x00144CE3 File Offset: 0x00142EE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MGLAPEBCMOO> Parser
		{
			get
			{
				return MGLAPEBCMOO._parser;
			}
		}

		// Token: 0x17002270 RID: 8816
		// (get) Token: 0x06007AA9 RID: 31401 RVA: 0x00144CEA File Offset: 0x00142EEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MGLAPEBCMOOReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002271 RID: 8817
		// (get) Token: 0x06007AAA RID: 31402 RVA: 0x00144CFC File Offset: 0x00142EFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MGLAPEBCMOO.Descriptor;
			}
		}

		// Token: 0x06007AAB RID: 31403 RVA: 0x00144D03 File Offset: 0x00142F03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MGLAPEBCMOO()
		{
		}

		// Token: 0x06007AAC RID: 31404 RVA: 0x00144D0C File Offset: 0x00142F0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MGLAPEBCMOO(MGLAPEBCMOO other) : this()
		{
			this.cDAJGLIIBII_ = ((other.cDAJGLIIBII_ != null) ? other.cDAJGLIIBII_.Clone() : null);
			this.basicInfo_ = ((other.basicInfo_ != null) ? other.basicInfo_.Clone() : null);
			this.eGDLHHBBFPA_ = other.eGDLHHBBFPA_;
			this.oPCLEDOBIKK_ = other.oPCLEDOBIKK_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007AAD RID: 31405 RVA: 0x00144D80 File Offset: 0x00142F80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MGLAPEBCMOO Clone()
		{
			return new MGLAPEBCMOO(this);
		}

		// Token: 0x17002272 RID: 8818
		// (get) Token: 0x06007AAE RID: 31406 RVA: 0x00144D88 File Offset: 0x00142F88
		// (set) Token: 0x06007AAF RID: 31407 RVA: 0x00144D90 File Offset: 0x00142F90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PunkLordBattleRecordList CDAJGLIIBII
		{
			get
			{
				return this.cDAJGLIIBII_;
			}
			set
			{
				this.cDAJGLIIBII_ = value;
			}
		}

		// Token: 0x17002273 RID: 8819
		// (get) Token: 0x06007AB0 RID: 31408 RVA: 0x00144D99 File Offset: 0x00142F99
		// (set) Token: 0x06007AB1 RID: 31409 RVA: 0x00144DA1 File Offset: 0x00142FA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PunkLordMonsterBasicInfo BasicInfo
		{
			get
			{
				return this.basicInfo_;
			}
			set
			{
				this.basicInfo_ = value;
			}
		}

		// Token: 0x17002274 RID: 8820
		// (get) Token: 0x06007AB2 RID: 31410 RVA: 0x00144DAA File Offset: 0x00142FAA
		// (set) Token: 0x06007AB3 RID: 31411 RVA: 0x00144DB2 File Offset: 0x00142FB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EGDLHHBBFPA
		{
			get
			{
				return this.eGDLHHBBFPA_;
			}
			set
			{
				this.eGDLHHBBFPA_ = value;
			}
		}

		// Token: 0x17002275 RID: 8821
		// (get) Token: 0x06007AB4 RID: 31412 RVA: 0x00144DBB File Offset: 0x00142FBB
		// (set) Token: 0x06007AB5 RID: 31413 RVA: 0x00144DC3 File Offset: 0x00142FC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PunkLordAttackerStatus OPCLEDOBIKK
		{
			get
			{
				return this.oPCLEDOBIKK_;
			}
			set
			{
				this.oPCLEDOBIKK_ = value;
			}
		}

		// Token: 0x06007AB6 RID: 31414 RVA: 0x00144DCC File Offset: 0x00142FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MGLAPEBCMOO);
		}

		// Token: 0x06007AB7 RID: 31415 RVA: 0x00144DDC File Offset: 0x00142FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MGLAPEBCMOO other)
		{
			return other != null && (other == this || (object.Equals(this.CDAJGLIIBII, other.CDAJGLIIBII) && object.Equals(this.BasicInfo, other.BasicInfo) && this.EGDLHHBBFPA == other.EGDLHHBBFPA && this.OPCLEDOBIKK == other.OPCLEDOBIKK && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007AB8 RID: 31416 RVA: 0x00144E50 File Offset: 0x00143050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.cDAJGLIIBII_ != null)
			{
				num ^= this.CDAJGLIIBII.GetHashCode();
			}
			if (this.basicInfo_ != null)
			{
				num ^= this.BasicInfo.GetHashCode();
			}
			if (this.EGDLHHBBFPA != 0U)
			{
				num ^= this.EGDLHHBBFPA.GetHashCode();
			}
			if (this.OPCLEDOBIKK != PunkLordAttackerStatus.None)
			{
				num ^= this.OPCLEDOBIKK.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007AB9 RID: 31417 RVA: 0x00144EDA File Offset: 0x001430DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007ABA RID: 31418 RVA: 0x00144EE2 File Offset: 0x001430E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007ABB RID: 31419 RVA: 0x00144EEC File Offset: 0x001430EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.cDAJGLIIBII_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.CDAJGLIIBII);
			}
			if (this.basicInfo_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.BasicInfo);
			}
			if (this.OPCLEDOBIKK != PunkLordAttackerStatus.None)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.OPCLEDOBIKK);
			}
			if (this.EGDLHHBBFPA != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.EGDLHHBBFPA);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007ABC RID: 31420 RVA: 0x00144F80 File Offset: 0x00143180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.cDAJGLIIBII_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CDAJGLIIBII);
			}
			if (this.basicInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BasicInfo);
			}
			if (this.EGDLHHBBFPA != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EGDLHHBBFPA);
			}
			if (this.OPCLEDOBIKK != PunkLordAttackerStatus.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.OPCLEDOBIKK);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007ABD RID: 31421 RVA: 0x00145008 File Offset: 0x00143208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MGLAPEBCMOO other)
		{
			if (other == null)
			{
				return;
			}
			if (other.cDAJGLIIBII_ != null)
			{
				if (this.cDAJGLIIBII_ == null)
				{
					this.CDAJGLIIBII = new PunkLordBattleRecordList();
				}
				this.CDAJGLIIBII.MergeFrom(other.CDAJGLIIBII);
			}
			if (other.basicInfo_ != null)
			{
				if (this.basicInfo_ == null)
				{
					this.BasicInfo = new PunkLordMonsterBasicInfo();
				}
				this.BasicInfo.MergeFrom(other.BasicInfo);
			}
			if (other.EGDLHHBBFPA != 0U)
			{
				this.EGDLHHBBFPA = other.EGDLHHBBFPA;
			}
			if (other.OPCLEDOBIKK != PunkLordAttackerStatus.None)
			{
				this.OPCLEDOBIKK = other.OPCLEDOBIKK;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007ABE RID: 31422 RVA: 0x001450B0 File Offset: 0x001432B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007ABF RID: 31423 RVA: 0x001450BC File Offset: 0x001432BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 90U)
				{
					if (num == 42U)
					{
						if (this.cDAJGLIIBII_ == null)
						{
							this.CDAJGLIIBII = new PunkLordBattleRecordList();
						}
						input.ReadMessage(this.CDAJGLIIBII);
						continue;
					}
					if (num == 90U)
					{
						if (this.basicInfo_ == null)
						{
							this.BasicInfo = new PunkLordMonsterBasicInfo();
						}
						input.ReadMessage(this.BasicInfo);
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.OPCLEDOBIKK = (PunkLordAttackerStatus)input.ReadEnum();
						continue;
					}
					if (num == 120U)
					{
						this.EGDLHHBBFPA = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002F13 RID: 12051
		private static readonly MessageParser<MGLAPEBCMOO> _parser = new MessageParser<MGLAPEBCMOO>(() => new MGLAPEBCMOO());

		// Token: 0x04002F14 RID: 12052
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F15 RID: 12053
		public const int CDAJGLIIBIIFieldNumber = 5;

		// Token: 0x04002F16 RID: 12054
		private PunkLordBattleRecordList cDAJGLIIBII_;

		// Token: 0x04002F17 RID: 12055
		public const int BasicInfoFieldNumber = 11;

		// Token: 0x04002F18 RID: 12056
		private PunkLordMonsterBasicInfo basicInfo_;

		// Token: 0x04002F19 RID: 12057
		public const int EGDLHHBBFPAFieldNumber = 15;

		// Token: 0x04002F1A RID: 12058
		private uint eGDLHHBBFPA_;

		// Token: 0x04002F1B RID: 12059
		public const int OPCLEDOBIKKFieldNumber = 12;

		// Token: 0x04002F1C RID: 12060
		private PunkLordAttackerStatus oPCLEDOBIKK_;
	}
}
