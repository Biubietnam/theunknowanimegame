using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C6F RID: 3183
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OpenTreasureDungeonGridCsReq : IMessage<OpenTreasureDungeonGridCsReq>, IMessage, IEquatable<OpenTreasureDungeonGridCsReq>, IDeepCloneable<OpenTreasureDungeonGridCsReq>, IBufferMessage
	{
		// Token: 0x170027BE RID: 10174
		// (get) Token: 0x06008D76 RID: 36214 RVA: 0x00175F91 File Offset: 0x00174191
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OpenTreasureDungeonGridCsReq> Parser
		{
			get
			{
				return OpenTreasureDungeonGridCsReq._parser;
			}
		}

		// Token: 0x170027BF RID: 10175
		// (get) Token: 0x06008D77 RID: 36215 RVA: 0x00175F98 File Offset: 0x00174198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return OpenTreasureDungeonGridCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170027C0 RID: 10176
		// (get) Token: 0x06008D78 RID: 36216 RVA: 0x00175FAA File Offset: 0x001741AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OpenTreasureDungeonGridCsReq.Descriptor;
			}
		}

		// Token: 0x06008D79 RID: 36217 RVA: 0x00175FB1 File Offset: 0x001741B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OpenTreasureDungeonGridCsReq()
		{
		}

		// Token: 0x06008D7A RID: 36218 RVA: 0x00175FB9 File Offset: 0x001741B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OpenTreasureDungeonGridCsReq(OpenTreasureDungeonGridCsReq other) : this()
		{
			this.nCFAJPAMBGD_ = other.nCFAJPAMBGD_;
			this.eEEABJCNKDO_ = other.eEEABJCNKDO_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008D7B RID: 36219 RVA: 0x00175FEA File Offset: 0x001741EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OpenTreasureDungeonGridCsReq Clone()
		{
			return new OpenTreasureDungeonGridCsReq(this);
		}

		// Token: 0x170027C1 RID: 10177
		// (get) Token: 0x06008D7C RID: 36220 RVA: 0x00175FF2 File Offset: 0x001741F2
		// (set) Token: 0x06008D7D RID: 36221 RVA: 0x00175FFA File Offset: 0x001741FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NCFAJPAMBGD
		{
			get
			{
				return this.nCFAJPAMBGD_;
			}
			set
			{
				this.nCFAJPAMBGD_ = value;
			}
		}

		// Token: 0x170027C2 RID: 10178
		// (get) Token: 0x06008D7E RID: 36222 RVA: 0x00176003 File Offset: 0x00174203
		// (set) Token: 0x06008D7F RID: 36223 RVA: 0x0017600B File Offset: 0x0017420B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EEEABJCNKDO
		{
			get
			{
				return this.eEEABJCNKDO_;
			}
			set
			{
				this.eEEABJCNKDO_ = value;
			}
		}

		// Token: 0x06008D80 RID: 36224 RVA: 0x00176014 File Offset: 0x00174214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OpenTreasureDungeonGridCsReq);
		}

		// Token: 0x06008D81 RID: 36225 RVA: 0x00176022 File Offset: 0x00174222
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OpenTreasureDungeonGridCsReq other)
		{
			return other != null && (other == this || (this.NCFAJPAMBGD == other.NCFAJPAMBGD && this.EEEABJCNKDO == other.EEEABJCNKDO && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008D82 RID: 36226 RVA: 0x00176060 File Offset: 0x00174260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.NCFAJPAMBGD != 0U)
			{
				num ^= this.NCFAJPAMBGD.GetHashCode();
			}
			if (this.EEEABJCNKDO != 0U)
			{
				num ^= this.EEEABJCNKDO.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008D83 RID: 36227 RVA: 0x001760B8 File Offset: 0x001742B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008D84 RID: 36228 RVA: 0x001760C0 File Offset: 0x001742C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008D85 RID: 36229 RVA: 0x001760CC File Offset: 0x001742CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NCFAJPAMBGD != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.NCFAJPAMBGD);
			}
			if (this.EEEABJCNKDO != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.EEEABJCNKDO);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008D86 RID: 36230 RVA: 0x00176128 File Offset: 0x00174328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.NCFAJPAMBGD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NCFAJPAMBGD);
			}
			if (this.EEEABJCNKDO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EEEABJCNKDO);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008D87 RID: 36231 RVA: 0x00176180 File Offset: 0x00174380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OpenTreasureDungeonGridCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.NCFAJPAMBGD != 0U)
			{
				this.NCFAJPAMBGD = other.NCFAJPAMBGD;
			}
			if (other.EEEABJCNKDO != 0U)
			{
				this.EEEABJCNKDO = other.EEEABJCNKDO;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008D88 RID: 36232 RVA: 0x001761D0 File Offset: 0x001743D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008D89 RID: 36233 RVA: 0x001761DC File Offset: 0x001743DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EEEABJCNKDO = input.ReadUInt32();
					}
				}
				else
				{
					this.NCFAJPAMBGD = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003656 RID: 13910
		private static readonly MessageParser<OpenTreasureDungeonGridCsReq> _parser = new MessageParser<OpenTreasureDungeonGridCsReq>(() => new OpenTreasureDungeonGridCsReq());

		// Token: 0x04003657 RID: 13911
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003658 RID: 13912
		public const int NCFAJPAMBGDFieldNumber = 3;

		// Token: 0x04003659 RID: 13913
		private uint nCFAJPAMBGD_;

		// Token: 0x0400365A RID: 13914
		public const int EEEABJCNKDOFieldNumber = 14;

		// Token: 0x0400365B RID: 13915
		private uint eEEABJCNKDO_;
	}
}
