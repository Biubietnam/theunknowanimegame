using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B77 RID: 2935
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolySelectOptionCsReq : IMessage<MonopolySelectOptionCsReq>, IMessage, IEquatable<MonopolySelectOptionCsReq>, IDeepCloneable<MonopolySelectOptionCsReq>, IBufferMessage
	{
		// Token: 0x1700245E RID: 9310
		// (get) Token: 0x060081E1 RID: 33249 RVA: 0x001561E1 File Offset: 0x001543E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolySelectOptionCsReq> Parser
		{
			get
			{
				return MonopolySelectOptionCsReq._parser;
			}
		}

		// Token: 0x1700245F RID: 9311
		// (get) Token: 0x060081E2 RID: 33250 RVA: 0x001561E8 File Offset: 0x001543E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolySelectOptionCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002460 RID: 9312
		// (get) Token: 0x060081E3 RID: 33251 RVA: 0x001561FA File Offset: 0x001543FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolySelectOptionCsReq.Descriptor;
			}
		}

		// Token: 0x060081E4 RID: 33252 RVA: 0x00156201 File Offset: 0x00154401
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolySelectOptionCsReq()
		{
		}

		// Token: 0x060081E5 RID: 33253 RVA: 0x00156209 File Offset: 0x00154409
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolySelectOptionCsReq(MonopolySelectOptionCsReq other) : this()
		{
			this.optionId_ = other.optionId_;
			this.eventId_ = other.eventId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060081E6 RID: 33254 RVA: 0x0015623A File Offset: 0x0015443A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolySelectOptionCsReq Clone()
		{
			return new MonopolySelectOptionCsReq(this);
		}

		// Token: 0x17002461 RID: 9313
		// (get) Token: 0x060081E7 RID: 33255 RVA: 0x00156242 File Offset: 0x00154442
		// (set) Token: 0x060081E8 RID: 33256 RVA: 0x0015624A File Offset: 0x0015444A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OptionId
		{
			get
			{
				return this.optionId_;
			}
			set
			{
				this.optionId_ = value;
			}
		}

		// Token: 0x17002462 RID: 9314
		// (get) Token: 0x060081E9 RID: 33257 RVA: 0x00156253 File Offset: 0x00154453
		// (set) Token: 0x060081EA RID: 33258 RVA: 0x0015625B File Offset: 0x0015445B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EventId
		{
			get
			{
				return this.eventId_;
			}
			set
			{
				this.eventId_ = value;
			}
		}

		// Token: 0x060081EB RID: 33259 RVA: 0x00156264 File Offset: 0x00154464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolySelectOptionCsReq);
		}

		// Token: 0x060081EC RID: 33260 RVA: 0x00156272 File Offset: 0x00154472
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolySelectOptionCsReq other)
		{
			return other != null && (other == this || (this.OptionId == other.OptionId && this.EventId == other.EventId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060081ED RID: 33261 RVA: 0x001562B0 File Offset: 0x001544B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.OptionId != 0U)
			{
				num ^= this.OptionId.GetHashCode();
			}
			if (this.EventId != 0U)
			{
				num ^= this.EventId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060081EE RID: 33262 RVA: 0x00156308 File Offset: 0x00154508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060081EF RID: 33263 RVA: 0x00156310 File Offset: 0x00154510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060081F0 RID: 33264 RVA: 0x0015631C File Offset: 0x0015451C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EventId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.EventId);
			}
			if (this.OptionId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.OptionId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060081F1 RID: 33265 RVA: 0x00156378 File Offset: 0x00154578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.OptionId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OptionId);
			}
			if (this.EventId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EventId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060081F2 RID: 33266 RVA: 0x001563D0 File Offset: 0x001545D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolySelectOptionCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.OptionId != 0U)
			{
				this.OptionId = other.OptionId;
			}
			if (other.EventId != 0U)
			{
				this.EventId = other.EventId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060081F3 RID: 33267 RVA: 0x00156420 File Offset: 0x00154620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060081F4 RID: 33268 RVA: 0x0015642C File Offset: 0x0015462C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.OptionId = input.ReadUInt32();
					}
				}
				else
				{
					this.EventId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400318A RID: 12682
		private static readonly MessageParser<MonopolySelectOptionCsReq> _parser = new MessageParser<MonopolySelectOptionCsReq>(() => new MonopolySelectOptionCsReq());

		// Token: 0x0400318B RID: 12683
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400318C RID: 12684
		public const int OptionIdFieldNumber = 14;

		// Token: 0x0400318D RID: 12685
		private uint optionId_;

		// Token: 0x0400318E RID: 12686
		public const int EventIdFieldNumber = 4;

		// Token: 0x0400318F RID: 12687
		private uint eventId_;
	}
}
