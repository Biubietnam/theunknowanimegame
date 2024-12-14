using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001301 RID: 4865
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeOffRelicCsReq : IMessage<TakeOffRelicCsReq>, IMessage, IEquatable<TakeOffRelicCsReq>, IDeepCloneable<TakeOffRelicCsReq>, IBufferMessage
	{
		// Token: 0x17003D02 RID: 15618
		// (get) Token: 0x0600D911 RID: 55569 RVA: 0x00242A84 File Offset: 0x00240C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeOffRelicCsReq> Parser
		{
			get
			{
				return TakeOffRelicCsReq._parser;
			}
		}

		// Token: 0x17003D03 RID: 15619
		// (get) Token: 0x0600D912 RID: 55570 RVA: 0x00242A8B File Offset: 0x00240C8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeOffRelicCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003D04 RID: 15620
		// (get) Token: 0x0600D913 RID: 55571 RVA: 0x00242A9D File Offset: 0x00240C9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeOffRelicCsReq.Descriptor;
			}
		}

		// Token: 0x0600D914 RID: 55572 RVA: 0x00242AA4 File Offset: 0x00240CA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeOffRelicCsReq()
		{
		}

		// Token: 0x0600D915 RID: 55573 RVA: 0x00242AB7 File Offset: 0x00240CB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeOffRelicCsReq(TakeOffRelicCsReq other) : this()
		{
			this.relicTypeList_ = other.relicTypeList_.Clone();
			this.avatarId_ = other.avatarId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D916 RID: 55574 RVA: 0x00242AED File Offset: 0x00240CED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeOffRelicCsReq Clone()
		{
			return new TakeOffRelicCsReq(this);
		}

		// Token: 0x17003D05 RID: 15621
		// (get) Token: 0x0600D917 RID: 55575 RVA: 0x00242AF5 File Offset: 0x00240CF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> RelicTypeList
		{
			get
			{
				return this.relicTypeList_;
			}
		}

		// Token: 0x17003D06 RID: 15622
		// (get) Token: 0x0600D918 RID: 55576 RVA: 0x00242AFD File Offset: 0x00240CFD
		// (set) Token: 0x0600D919 RID: 55577 RVA: 0x00242B05 File Offset: 0x00240D05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AvatarId
		{
			get
			{
				return this.avatarId_;
			}
			set
			{
				this.avatarId_ = value;
			}
		}

		// Token: 0x0600D91A RID: 55578 RVA: 0x00242B0E File Offset: 0x00240D0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeOffRelicCsReq);
		}

		// Token: 0x0600D91B RID: 55579 RVA: 0x00242B1C File Offset: 0x00240D1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeOffRelicCsReq other)
		{
			return other != null && (other == this || (this.relicTypeList_.Equals(other.relicTypeList_) && this.AvatarId == other.AvatarId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D91C RID: 55580 RVA: 0x00242B6C File Offset: 0x00240D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.relicTypeList_.GetHashCode();
			if (this.AvatarId != 0U)
			{
				num ^= this.AvatarId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D91D RID: 55581 RVA: 0x00242BB9 File Offset: 0x00240DB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D91E RID: 55582 RVA: 0x00242BC1 File Offset: 0x00240DC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D91F RID: 55583 RVA: 0x00242BCC File Offset: 0x00240DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AvatarId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.AvatarId);
			}
			this.relicTypeList_.WriteTo(ref output, TakeOffRelicCsReq._repeated_relicTypeList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D920 RID: 55584 RVA: 0x00242C1C File Offset: 0x00240E1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.relicTypeList_.CalculateSize(TakeOffRelicCsReq._repeated_relicTypeList_codec);
			if (this.AvatarId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AvatarId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D921 RID: 55585 RVA: 0x00242C70 File Offset: 0x00240E70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeOffRelicCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.relicTypeList_.Add(other.relicTypeList_);
			if (other.AvatarId != 0U)
			{
				this.AvatarId = other.AvatarId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D922 RID: 55586 RVA: 0x00242CBD File Offset: 0x00240EBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D923 RID: 55587 RVA: 0x00242CC8 File Offset: 0x00240EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 48U && num != 50U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.relicTypeList_.AddEntriesFrom(ref input, TakeOffRelicCsReq._repeated_relicTypeList_codec);
					}
				}
				else
				{
					this.AvatarId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400568F RID: 22159
		private static readonly MessageParser<TakeOffRelicCsReq> _parser = new MessageParser<TakeOffRelicCsReq>(() => new TakeOffRelicCsReq());

		// Token: 0x04005690 RID: 22160
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005691 RID: 22161
		public const int RelicTypeListFieldNumber = 6;

		// Token: 0x04005692 RID: 22162
		private static readonly FieldCodec<uint> _repeated_relicTypeList_codec = FieldCodec.ForUInt32(50U);

		// Token: 0x04005693 RID: 22163
		private readonly RepeatedField<uint> relicTypeList_ = new RepeatedField<uint>();

		// Token: 0x04005694 RID: 22164
		public const int AvatarIdFieldNumber = 1;

		// Token: 0x04005695 RID: 22165
		private uint avatarId_;
	}
}
