using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007FB RID: 2043
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetSingleRedDotParamGroupScRsp : IMessage<GetSingleRedDotParamGroupScRsp>, IMessage, IEquatable<GetSingleRedDotParamGroupScRsp>, IDeepCloneable<GetSingleRedDotParamGroupScRsp>, IBufferMessage
	{
		// Token: 0x170019AC RID: 6572
		// (get) Token: 0x06005B1E RID: 23326 RVA: 0x000F2B47 File Offset: 0x000F0D47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetSingleRedDotParamGroupScRsp> Parser
		{
			get
			{
				return GetSingleRedDotParamGroupScRsp._parser;
			}
		}

		// Token: 0x170019AD RID: 6573
		// (get) Token: 0x06005B1F RID: 23327 RVA: 0x000F2B4E File Offset: 0x000F0D4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetSingleRedDotParamGroupScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170019AE RID: 6574
		// (get) Token: 0x06005B20 RID: 23328 RVA: 0x000F2B60 File Offset: 0x000F0D60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetSingleRedDotParamGroupScRsp.Descriptor;
			}
		}

		// Token: 0x06005B21 RID: 23329 RVA: 0x000F2B67 File Offset: 0x000F0D67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetSingleRedDotParamGroupScRsp()
		{
		}

		// Token: 0x06005B22 RID: 23330 RVA: 0x000F2B70 File Offset: 0x000F0D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetSingleRedDotParamGroupScRsp(GetSingleRedDotParamGroupScRsp other) : this()
		{
			this.groupId_ = other.groupId_;
			this.panelId_ = other.panelId_;
			this.eMOCKDJPBCB_ = ((other.eMOCKDJPBCB_ != null) ? other.eMOCKDJPBCB_.Clone() : null);
			this.retcode_ = other.retcode_;
			this.aCPLFDCNGKO_ = other.aCPLFDCNGKO_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005B23 RID: 23331 RVA: 0x000F2BE0 File Offset: 0x000F0DE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetSingleRedDotParamGroupScRsp Clone()
		{
			return new GetSingleRedDotParamGroupScRsp(this);
		}

		// Token: 0x170019AF RID: 6575
		// (get) Token: 0x06005B24 RID: 23332 RVA: 0x000F2BE8 File Offset: 0x000F0DE8
		// (set) Token: 0x06005B25 RID: 23333 RVA: 0x000F2BF0 File Offset: 0x000F0DF0
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

		// Token: 0x170019B0 RID: 6576
		// (get) Token: 0x06005B26 RID: 23334 RVA: 0x000F2BF9 File Offset: 0x000F0DF9
		// (set) Token: 0x06005B27 RID: 23335 RVA: 0x000F2C01 File Offset: 0x000F0E01
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

		// Token: 0x170019B1 RID: 6577
		// (get) Token: 0x06005B28 RID: 23336 RVA: 0x000F2C0A File Offset: 0x000F0E0A
		// (set) Token: 0x06005B29 RID: 23337 RVA: 0x000F2C12 File Offset: 0x000F0E12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KKCABEAAPJC EMOCKDJPBCB
		{
			get
			{
				return this.eMOCKDJPBCB_;
			}
			set
			{
				this.eMOCKDJPBCB_ = value;
			}
		}

		// Token: 0x170019B2 RID: 6578
		// (get) Token: 0x06005B2A RID: 23338 RVA: 0x000F2C1B File Offset: 0x000F0E1B
		// (set) Token: 0x06005B2B RID: 23339 RVA: 0x000F2C23 File Offset: 0x000F0E23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x170019B3 RID: 6579
		// (get) Token: 0x06005B2C RID: 23340 RVA: 0x000F2C2C File Offset: 0x000F0E2C
		// (set) Token: 0x06005B2D RID: 23341 RVA: 0x000F2C34 File Offset: 0x000F0E34
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

		// Token: 0x06005B2E RID: 23342 RVA: 0x000F2C3D File Offset: 0x000F0E3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetSingleRedDotParamGroupScRsp);
		}

		// Token: 0x06005B2F RID: 23343 RVA: 0x000F2C4C File Offset: 0x000F0E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetSingleRedDotParamGroupScRsp other)
		{
			return other != null && (other == this || (this.GroupId == other.GroupId && this.PanelId == other.PanelId && object.Equals(this.EMOCKDJPBCB, other.EMOCKDJPBCB) && this.Retcode == other.Retcode && this.ACPLFDCNGKO == other.ACPLFDCNGKO && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005B30 RID: 23344 RVA: 0x000F2CCC File Offset: 0x000F0ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GroupId != 0U)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this.PanelId != 0U)
			{
				num ^= this.PanelId.GetHashCode();
			}
			if (this.eMOCKDJPBCB_ != null)
			{
				num ^= this.EMOCKDJPBCB.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.ACPLFDCNGKO != 0U)
			{
				num ^= this.ACPLFDCNGKO.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005B31 RID: 23345 RVA: 0x000F2D6C File Offset: 0x000F0F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005B32 RID: 23346 RVA: 0x000F2D74 File Offset: 0x000F0F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005B33 RID: 23347 RVA: 0x000F2D80 File Offset: 0x000F0F80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Retcode);
			}
			if (this.PanelId != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.PanelId);
			}
			if (this.ACPLFDCNGKO != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.ACPLFDCNGKO);
			}
			if (this.GroupId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.GroupId);
			}
			if (this.eMOCKDJPBCB_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.EMOCKDJPBCB);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005B34 RID: 23348 RVA: 0x000F2E30 File Offset: 0x000F1030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GroupId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GroupId);
			}
			if (this.PanelId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PanelId);
			}
			if (this.eMOCKDJPBCB_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EMOCKDJPBCB);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.ACPLFDCNGKO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ACPLFDCNGKO);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005B35 RID: 23349 RVA: 0x000F2ED0 File Offset: 0x000F10D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetSingleRedDotParamGroupScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GroupId != 0U)
			{
				this.GroupId = other.GroupId;
			}
			if (other.PanelId != 0U)
			{
				this.PanelId = other.PanelId;
			}
			if (other.eMOCKDJPBCB_ != null)
			{
				if (this.eMOCKDJPBCB_ == null)
				{
					this.EMOCKDJPBCB = new KKCABEAAPJC();
				}
				this.EMOCKDJPBCB.MergeFrom(other.EMOCKDJPBCB);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.ACPLFDCNGKO != 0U)
			{
				this.ACPLFDCNGKO = other.ACPLFDCNGKO;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005B36 RID: 23350 RVA: 0x000F2F74 File Offset: 0x000F1174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005B37 RID: 23351 RVA: 0x000F2F80 File Offset: 0x000F1180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 64U)
				{
					if (num == 40U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 64U)
					{
						this.PanelId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.ACPLFDCNGKO = input.ReadUInt32();
						continue;
					}
					if (num == 112U)
					{
						this.GroupId = input.ReadUInt32();
						continue;
					}
					if (num == 122U)
					{
						if (this.eMOCKDJPBCB_ == null)
						{
							this.EMOCKDJPBCB = new KKCABEAAPJC();
						}
						input.ReadMessage(this.EMOCKDJPBCB);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002352 RID: 9042
		private static readonly MessageParser<GetSingleRedDotParamGroupScRsp> _parser = new MessageParser<GetSingleRedDotParamGroupScRsp>(() => new GetSingleRedDotParamGroupScRsp());

		// Token: 0x04002353 RID: 9043
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002354 RID: 9044
		public const int GroupIdFieldNumber = 14;

		// Token: 0x04002355 RID: 9045
		private uint groupId_;

		// Token: 0x04002356 RID: 9046
		public const int PanelIdFieldNumber = 8;

		// Token: 0x04002357 RID: 9047
		private uint panelId_;

		// Token: 0x04002358 RID: 9048
		public const int EMOCKDJPBCBFieldNumber = 15;

		// Token: 0x04002359 RID: 9049
		private KKCABEAAPJC eMOCKDJPBCB_;

		// Token: 0x0400235A RID: 9050
		public const int RetcodeFieldNumber = 5;

		// Token: 0x0400235B RID: 9051
		private uint retcode_;

		// Token: 0x0400235C RID: 9052
		public const int ACPLFDCNGKOFieldNumber = 9;

		// Token: 0x0400235D RID: 9053
		private uint aCPLFDCNGKO_;
	}
}
