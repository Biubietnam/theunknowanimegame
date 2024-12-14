using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012F9 RID: 4857
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeOffEquipmentCsReq : IMessage<TakeOffEquipmentCsReq>, IMessage, IEquatable<TakeOffEquipmentCsReq>, IDeepCloneable<TakeOffEquipmentCsReq>, IBufferMessage
	{
		// Token: 0x17003CEA RID: 15594
		// (get) Token: 0x0600D8B6 RID: 55478 RVA: 0x00241CF8 File Offset: 0x0023FEF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeOffEquipmentCsReq> Parser
		{
			get
			{
				return TakeOffEquipmentCsReq._parser;
			}
		}

		// Token: 0x17003CEB RID: 15595
		// (get) Token: 0x0600D8B7 RID: 55479 RVA: 0x00241CFF File Offset: 0x0023FEFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeOffEquipmentCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003CEC RID: 15596
		// (get) Token: 0x0600D8B8 RID: 55480 RVA: 0x00241D11 File Offset: 0x0023FF11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeOffEquipmentCsReq.Descriptor;
			}
		}

		// Token: 0x0600D8B9 RID: 55481 RVA: 0x00241D18 File Offset: 0x0023FF18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeOffEquipmentCsReq()
		{
		}

		// Token: 0x0600D8BA RID: 55482 RVA: 0x00241D20 File Offset: 0x0023FF20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeOffEquipmentCsReq(TakeOffEquipmentCsReq other) : this()
		{
			this.avatarId_ = other.avatarId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D8BB RID: 55483 RVA: 0x00241D45 File Offset: 0x0023FF45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeOffEquipmentCsReq Clone()
		{
			return new TakeOffEquipmentCsReq(this);
		}

		// Token: 0x17003CED RID: 15597
		// (get) Token: 0x0600D8BC RID: 55484 RVA: 0x00241D4D File Offset: 0x0023FF4D
		// (set) Token: 0x0600D8BD RID: 55485 RVA: 0x00241D55 File Offset: 0x0023FF55
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

		// Token: 0x0600D8BE RID: 55486 RVA: 0x00241D5E File Offset: 0x0023FF5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeOffEquipmentCsReq);
		}

		// Token: 0x0600D8BF RID: 55487 RVA: 0x00241D6C File Offset: 0x0023FF6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeOffEquipmentCsReq other)
		{
			return other != null && (other == this || (this.AvatarId == other.AvatarId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D8C0 RID: 55488 RVA: 0x00241D9C File Offset: 0x0023FF9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0600D8C1 RID: 55489 RVA: 0x00241DDB File Offset: 0x0023FFDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D8C2 RID: 55490 RVA: 0x00241DE3 File Offset: 0x0023FFE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D8C3 RID: 55491 RVA: 0x00241DEC File Offset: 0x0023FFEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AvatarId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.AvatarId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D8C4 RID: 55492 RVA: 0x00241E20 File Offset: 0x00240020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0600D8C5 RID: 55493 RVA: 0x00241E5E File Offset: 0x0024005E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeOffEquipmentCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AvatarId != 0U)
			{
				this.AvatarId = other.AvatarId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D8C6 RID: 55494 RVA: 0x00241E8F File Offset: 0x0024008F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D8C7 RID: 55495 RVA: 0x00241E98 File Offset: 0x00240098
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
					this.AvatarId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005672 RID: 22130
		private static readonly MessageParser<TakeOffEquipmentCsReq> _parser = new MessageParser<TakeOffEquipmentCsReq>(() => new TakeOffEquipmentCsReq());

		// Token: 0x04005673 RID: 22131
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005674 RID: 22132
		public const int AvatarIdFieldNumber = 4;

		// Token: 0x04005675 RID: 22133
		private uint avatarId_;
	}
}
