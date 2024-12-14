using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000597 RID: 1431
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FinishSectionIdCsReq : IMessage<FinishSectionIdCsReq>, IMessage, IEquatable<FinishSectionIdCsReq>, IDeepCloneable<FinishSectionIdCsReq>, IBufferMessage
	{
		// Token: 0x17001227 RID: 4647
		// (get) Token: 0x06003FDB RID: 16347 RVA: 0x000AE04C File Offset: 0x000AC24C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FinishSectionIdCsReq> Parser
		{
			get
			{
				return FinishSectionIdCsReq._parser;
			}
		}

		// Token: 0x17001228 RID: 4648
		// (get) Token: 0x06003FDC RID: 16348 RVA: 0x000AE053 File Offset: 0x000AC253
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FinishSectionIdCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001229 RID: 4649
		// (get) Token: 0x06003FDD RID: 16349 RVA: 0x000AE065 File Offset: 0x000AC265
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FinishSectionIdCsReq.Descriptor;
			}
		}

		// Token: 0x06003FDE RID: 16350 RVA: 0x000AE06C File Offset: 0x000AC26C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishSectionIdCsReq()
		{
		}

		// Token: 0x06003FDF RID: 16351 RVA: 0x000AE074 File Offset: 0x000AC274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishSectionIdCsReq(FinishSectionIdCsReq other) : this()
		{
			this.sectionId_ = other.sectionId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003FE0 RID: 16352 RVA: 0x000AE099 File Offset: 0x000AC299
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishSectionIdCsReq Clone()
		{
			return new FinishSectionIdCsReq(this);
		}

		// Token: 0x1700122A RID: 4650
		// (get) Token: 0x06003FE1 RID: 16353 RVA: 0x000AE0A1 File Offset: 0x000AC2A1
		// (set) Token: 0x06003FE2 RID: 16354 RVA: 0x000AE0A9 File Offset: 0x000AC2A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SectionId
		{
			get
			{
				return this.sectionId_;
			}
			set
			{
				this.sectionId_ = value;
			}
		}

		// Token: 0x06003FE3 RID: 16355 RVA: 0x000AE0B2 File Offset: 0x000AC2B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FinishSectionIdCsReq);
		}

		// Token: 0x06003FE4 RID: 16356 RVA: 0x000AE0C0 File Offset: 0x000AC2C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FinishSectionIdCsReq other)
		{
			return other != null && (other == this || (this.SectionId == other.SectionId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003FE5 RID: 16357 RVA: 0x000AE0F0 File Offset: 0x000AC2F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SectionId != 0U)
			{
				num ^= this.SectionId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003FE6 RID: 16358 RVA: 0x000AE12F File Offset: 0x000AC32F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003FE7 RID: 16359 RVA: 0x000AE137 File Offset: 0x000AC337
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003FE8 RID: 16360 RVA: 0x000AE140 File Offset: 0x000AC340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SectionId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.SectionId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003FE9 RID: 16361 RVA: 0x000AE174 File Offset: 0x000AC374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SectionId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SectionId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003FEA RID: 16362 RVA: 0x000AE1B2 File Offset: 0x000AC3B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FinishSectionIdCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SectionId != 0U)
			{
				this.SectionId = other.SectionId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003FEB RID: 16363 RVA: 0x000AE1E3 File Offset: 0x000AC3E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003FEC RID: 16364 RVA: 0x000AE1EC File Offset: 0x000AC3EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SectionId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001960 RID: 6496
		private static readonly MessageParser<FinishSectionIdCsReq> _parser = new MessageParser<FinishSectionIdCsReq>(() => new FinishSectionIdCsReq());

		// Token: 0x04001961 RID: 6497
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001962 RID: 6498
		public const int SectionIdFieldNumber = 4;

		// Token: 0x04001963 RID: 6499
		private uint sectionId_;
	}
}
