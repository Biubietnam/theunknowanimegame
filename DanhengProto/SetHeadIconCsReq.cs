using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001105 RID: 4357
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetHeadIconCsReq : IMessage<SetHeadIconCsReq>, IMessage, IEquatable<SetHeadIconCsReq>, IDeepCloneable<SetHeadIconCsReq>, IBufferMessage
	{
		// Token: 0x170036CF RID: 14031
		// (get) Token: 0x0600C249 RID: 49737 RVA: 0x0020A004 File Offset: 0x00208204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetHeadIconCsReq> Parser
		{
			get
			{
				return SetHeadIconCsReq._parser;
			}
		}

		// Token: 0x170036D0 RID: 14032
		// (get) Token: 0x0600C24A RID: 49738 RVA: 0x0020A00B File Offset: 0x0020820B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetHeadIconCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170036D1 RID: 14033
		// (get) Token: 0x0600C24B RID: 49739 RVA: 0x0020A01D File Offset: 0x0020821D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetHeadIconCsReq.Descriptor;
			}
		}

		// Token: 0x0600C24C RID: 49740 RVA: 0x0020A024 File Offset: 0x00208224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetHeadIconCsReq()
		{
		}

		// Token: 0x0600C24D RID: 49741 RVA: 0x0020A02C File Offset: 0x0020822C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetHeadIconCsReq(SetHeadIconCsReq other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C24E RID: 49742 RVA: 0x0020A051 File Offset: 0x00208251
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetHeadIconCsReq Clone()
		{
			return new SetHeadIconCsReq(this);
		}

		// Token: 0x170036D2 RID: 14034
		// (get) Token: 0x0600C24F RID: 49743 RVA: 0x0020A059 File Offset: 0x00208259
		// (set) Token: 0x0600C250 RID: 49744 RVA: 0x0020A061 File Offset: 0x00208261
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x0600C251 RID: 49745 RVA: 0x0020A06A File Offset: 0x0020826A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetHeadIconCsReq);
		}

		// Token: 0x0600C252 RID: 49746 RVA: 0x0020A078 File Offset: 0x00208278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetHeadIconCsReq other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C253 RID: 49747 RVA: 0x0020A0A8 File Offset: 0x002082A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C254 RID: 49748 RVA: 0x0020A0E7 File Offset: 0x002082E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C255 RID: 49749 RVA: 0x0020A0EF File Offset: 0x002082EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C256 RID: 49750 RVA: 0x0020A0F8 File Offset: 0x002082F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C257 RID: 49751 RVA: 0x0020A12C File Offset: 0x0020832C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C258 RID: 49752 RVA: 0x0020A16A File Offset: 0x0020836A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetHeadIconCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C259 RID: 49753 RVA: 0x0020A19B File Offset: 0x0020839B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C25A RID: 49754 RVA: 0x0020A1A4 File Offset: 0x002083A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004E9E RID: 20126
		private static readonly MessageParser<SetHeadIconCsReq> _parser = new MessageParser<SetHeadIconCsReq>(() => new SetHeadIconCsReq());

		// Token: 0x04004E9F RID: 20127
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004EA0 RID: 20128
		public const int IdFieldNumber = 11;

		// Token: 0x04004EA1 RID: 20129
		private uint id_;
	}
}
