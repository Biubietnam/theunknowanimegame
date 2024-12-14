using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DB5 RID: 3509
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RemoveStuffFromAreaCsReq : IMessage<RemoveStuffFromAreaCsReq>, IMessage, IEquatable<RemoveStuffFromAreaCsReq>, IDeepCloneable<RemoveStuffFromAreaCsReq>, IBufferMessage
	{
		// Token: 0x17002C4C RID: 11340
		// (get) Token: 0x06009CE5 RID: 40165 RVA: 0x001A2040 File Offset: 0x001A0240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RemoveStuffFromAreaCsReq> Parser
		{
			get
			{
				return RemoveStuffFromAreaCsReq._parser;
			}
		}

		// Token: 0x17002C4D RID: 11341
		// (get) Token: 0x06009CE6 RID: 40166 RVA: 0x001A2047 File Offset: 0x001A0247
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RemoveStuffFromAreaCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002C4E RID: 11342
		// (get) Token: 0x06009CE7 RID: 40167 RVA: 0x001A2059 File Offset: 0x001A0259
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveStuffFromAreaCsReq.Descriptor;
			}
		}

		// Token: 0x06009CE8 RID: 40168 RVA: 0x001A2060 File Offset: 0x001A0260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveStuffFromAreaCsReq()
		{
		}

		// Token: 0x06009CE9 RID: 40169 RVA: 0x001A2068 File Offset: 0x001A0268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveStuffFromAreaCsReq(RemoveStuffFromAreaCsReq other) : this()
		{
			this.pOEDFMELAKE_ = other.pOEDFMELAKE_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009CEA RID: 40170 RVA: 0x001A208D File Offset: 0x001A028D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveStuffFromAreaCsReq Clone()
		{
			return new RemoveStuffFromAreaCsReq(this);
		}

		// Token: 0x17002C4F RID: 11343
		// (get) Token: 0x06009CEB RID: 40171 RVA: 0x001A2095 File Offset: 0x001A0295
		// (set) Token: 0x06009CEC RID: 40172 RVA: 0x001A209D File Offset: 0x001A029D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint POEDFMELAKE
		{
			get
			{
				return this.pOEDFMELAKE_;
			}
			set
			{
				this.pOEDFMELAKE_ = value;
			}
		}

		// Token: 0x06009CED RID: 40173 RVA: 0x001A20A6 File Offset: 0x001A02A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveStuffFromAreaCsReq);
		}

		// Token: 0x06009CEE RID: 40174 RVA: 0x001A20B4 File Offset: 0x001A02B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveStuffFromAreaCsReq other)
		{
			return other != null && (other == this || (this.POEDFMELAKE == other.POEDFMELAKE && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009CEF RID: 40175 RVA: 0x001A20E4 File Offset: 0x001A02E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.POEDFMELAKE != 0U)
			{
				num ^= this.POEDFMELAKE.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009CF0 RID: 40176 RVA: 0x001A2123 File Offset: 0x001A0323
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009CF1 RID: 40177 RVA: 0x001A212B File Offset: 0x001A032B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009CF2 RID: 40178 RVA: 0x001A2134 File Offset: 0x001A0334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.POEDFMELAKE != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.POEDFMELAKE);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009CF3 RID: 40179 RVA: 0x001A2168 File Offset: 0x001A0368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.POEDFMELAKE != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.POEDFMELAKE);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009CF4 RID: 40180 RVA: 0x001A21A6 File Offset: 0x001A03A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemoveStuffFromAreaCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.POEDFMELAKE != 0U)
			{
				this.POEDFMELAKE = other.POEDFMELAKE;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009CF5 RID: 40181 RVA: 0x001A21D7 File Offset: 0x001A03D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009CF6 RID: 40182 RVA: 0x001A21E0 File Offset: 0x001A03E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.POEDFMELAKE = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003D01 RID: 15617
		private static readonly MessageParser<RemoveStuffFromAreaCsReq> _parser = new MessageParser<RemoveStuffFromAreaCsReq>(() => new RemoveStuffFromAreaCsReq());

		// Token: 0x04003D02 RID: 15618
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D03 RID: 15619
		public const int POEDFMELAKEFieldNumber = 14;

		// Token: 0x04003D04 RID: 15620
		private uint pOEDFMELAKE_;
	}
}
