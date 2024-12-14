using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007F9 RID: 2041
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetSingleRedDotParamGroupCsReq : IMessage<GetSingleRedDotParamGroupCsReq>, IMessage, IEquatable<GetSingleRedDotParamGroupCsReq>, IDeepCloneable<GetSingleRedDotParamGroupCsReq>, IBufferMessage
	{
		// Token: 0x170019A5 RID: 6565
		// (get) Token: 0x06005B05 RID: 23301 RVA: 0x000F271D File Offset: 0x000F091D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetSingleRedDotParamGroupCsReq> Parser
		{
			get
			{
				return GetSingleRedDotParamGroupCsReq._parser;
			}
		}

		// Token: 0x170019A6 RID: 6566
		// (get) Token: 0x06005B06 RID: 23302 RVA: 0x000F2724 File Offset: 0x000F0924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetSingleRedDotParamGroupCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170019A7 RID: 6567
		// (get) Token: 0x06005B07 RID: 23303 RVA: 0x000F2736 File Offset: 0x000F0936
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetSingleRedDotParamGroupCsReq.Descriptor;
			}
		}

		// Token: 0x06005B08 RID: 23304 RVA: 0x000F273D File Offset: 0x000F093D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetSingleRedDotParamGroupCsReq()
		{
		}

		// Token: 0x06005B09 RID: 23305 RVA: 0x000F2745 File Offset: 0x000F0945
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetSingleRedDotParamGroupCsReq(GetSingleRedDotParamGroupCsReq other) : this()
		{
			this.aCPLFDCNGKO_ = other.aCPLFDCNGKO_;
			this.panelId_ = other.panelId_;
			this.groupId_ = other.groupId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005B0A RID: 23306 RVA: 0x000F2782 File Offset: 0x000F0982
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetSingleRedDotParamGroupCsReq Clone()
		{
			return new GetSingleRedDotParamGroupCsReq(this);
		}

		// Token: 0x170019A8 RID: 6568
		// (get) Token: 0x06005B0B RID: 23307 RVA: 0x000F278A File Offset: 0x000F098A
		// (set) Token: 0x06005B0C RID: 23308 RVA: 0x000F2792 File Offset: 0x000F0992
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ACPLFDCNGKO
		{
			get
			{
				return this.aCPLFDCNGKO_;
			}
			set
			{
				this.aCPLFDCNGKO_ = value;
			}
		}

		// Token: 0x170019A9 RID: 6569
		// (get) Token: 0x06005B0D RID: 23309 RVA: 0x000F279B File Offset: 0x000F099B
		// (set) Token: 0x06005B0E RID: 23310 RVA: 0x000F27A3 File Offset: 0x000F09A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PanelId
		{
			get
			{
				return this.panelId_;
			}
			set
			{
				this.panelId_ = value;
			}
		}

		// Token: 0x170019AA RID: 6570
		// (get) Token: 0x06005B0F RID: 23311 RVA: 0x000F27AC File Offset: 0x000F09AC
		// (set) Token: 0x06005B10 RID: 23312 RVA: 0x000F27B4 File Offset: 0x000F09B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GroupId
		{
			get
			{
				return this.groupId_;
			}
			set
			{
				this.groupId_ = value;
			}
		}

		// Token: 0x06005B11 RID: 23313 RVA: 0x000F27BD File Offset: 0x000F09BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetSingleRedDotParamGroupCsReq);
		}

		// Token: 0x06005B12 RID: 23314 RVA: 0x000F27CC File Offset: 0x000F09CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetSingleRedDotParamGroupCsReq other)
		{
			return other != null && (other == this || (this.ACPLFDCNGKO == other.ACPLFDCNGKO && this.PanelId == other.PanelId && this.GroupId == other.GroupId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005B13 RID: 23315 RVA: 0x000F2828 File Offset: 0x000F0A28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ACPLFDCNGKO != 0U)
			{
				num ^= this.ACPLFDCNGKO.GetHashCode();
			}
			if (this.PanelId != 0U)
			{
				num ^= this.PanelId.GetHashCode();
			}
			if (this.GroupId != 0U)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005B14 RID: 23316 RVA: 0x000F2899 File Offset: 0x000F0A99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005B15 RID: 23317 RVA: 0x000F28A1 File Offset: 0x000F0AA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005B16 RID: 23318 RVA: 0x000F28AC File Offset: 0x000F0AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GroupId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.GroupId);
			}
			if (this.ACPLFDCNGKO != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.ACPLFDCNGKO);
			}
			if (this.PanelId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.PanelId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005B17 RID: 23319 RVA: 0x000F2924 File Offset: 0x000F0B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ACPLFDCNGKO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ACPLFDCNGKO);
			}
			if (this.PanelId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PanelId);
			}
			if (this.GroupId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GroupId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005B18 RID: 23320 RVA: 0x000F2994 File Offset: 0x000F0B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetSingleRedDotParamGroupCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ACPLFDCNGKO != 0U)
			{
				this.ACPLFDCNGKO = other.ACPLFDCNGKO;
			}
			if (other.PanelId != 0U)
			{
				this.PanelId = other.PanelId;
			}
			if (other.GroupId != 0U)
			{
				this.GroupId = other.GroupId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005B19 RID: 23321 RVA: 0x000F29F8 File Offset: 0x000F0BF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005B1A RID: 23322 RVA: 0x000F2A04 File Offset: 0x000F0C04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					if (num != 64U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.PanelId = input.ReadUInt32();
						}
					}
					else
					{
						this.ACPLFDCNGKO = input.ReadUInt32();
					}
				}
				else
				{
					this.GroupId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002349 RID: 9033
		private static readonly MessageParser<GetSingleRedDotParamGroupCsReq> _parser = new MessageParser<GetSingleRedDotParamGroupCsReq>(() => new GetSingleRedDotParamGroupCsReq());

		// Token: 0x0400234A RID: 9034
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400234B RID: 9035
		public const int ACPLFDCNGKOFieldNumber = 8;

		// Token: 0x0400234C RID: 9036
		private uint aCPLFDCNGKO_;

		// Token: 0x0400234D RID: 9037
		public const int PanelIdFieldNumber = 12;

		// Token: 0x0400234E RID: 9038
		private uint panelId_;

		// Token: 0x0400234F RID: 9039
		public const int GroupIdFieldNumber = 7;

		// Token: 0x04002350 RID: 9040
		private uint groupId_;
	}
}
