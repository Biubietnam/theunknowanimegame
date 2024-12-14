using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003B3 RID: 947
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DisplayRelicInfo : IMessage<DisplayRelicInfo>, IMessage, IEquatable<DisplayRelicInfo>, IDeepCloneable<DisplayRelicInfo>, IBufferMessage
	{
		// Token: 0x17000C16 RID: 3094
		// (get) Token: 0x06002A22 RID: 10786 RVA: 0x000753E7 File Offset: 0x000735E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DisplayRelicInfo> Parser
		{
			get
			{
				return DisplayRelicInfo._parser;
			}
		}

		// Token: 0x17000C17 RID: 3095
		// (get) Token: 0x06002A23 RID: 10787 RVA: 0x000753EE File Offset: 0x000735EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DisplayRelicInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000C18 RID: 3096
		// (get) Token: 0x06002A24 RID: 10788 RVA: 0x00075400 File Offset: 0x00073600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DisplayRelicInfo.Descriptor;
			}
		}

		// Token: 0x06002A25 RID: 10789 RVA: 0x00075407 File Offset: 0x00073607
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DisplayRelicInfo()
		{
		}

		// Token: 0x06002A26 RID: 10790 RVA: 0x0007541C File Offset: 0x0007361C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DisplayRelicInfo(DisplayRelicInfo other) : this()
		{
			this.level_ = other.level_;
			this.tid_ = other.tid_;
			this.type_ = other.type_;
			this.mainAffixId_ = other.mainAffixId_;
			this.subAffixList_ = other.subAffixList_.Clone();
			this.exp_ = other.exp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002A27 RID: 10791 RVA: 0x0007548D File Offset: 0x0007368D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DisplayRelicInfo Clone()
		{
			return new DisplayRelicInfo(this);
		}

		// Token: 0x17000C19 RID: 3097
		// (get) Token: 0x06002A28 RID: 10792 RVA: 0x00075495 File Offset: 0x00073695
		// (set) Token: 0x06002A29 RID: 10793 RVA: 0x0007549D File Offset: 0x0007369D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x17000C1A RID: 3098
		// (get) Token: 0x06002A2A RID: 10794 RVA: 0x000754A6 File Offset: 0x000736A6
		// (set) Token: 0x06002A2B RID: 10795 RVA: 0x000754AE File Offset: 0x000736AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Tid
		{
			get
			{
				return this.tid_;
			}
			set
			{
				this.tid_ = value;
			}
		}

		// Token: 0x17000C1B RID: 3099
		// (get) Token: 0x06002A2C RID: 10796 RVA: 0x000754B7 File Offset: 0x000736B7
		// (set) Token: 0x06002A2D RID: 10797 RVA: 0x000754BF File Offset: 0x000736BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x17000C1C RID: 3100
		// (get) Token: 0x06002A2E RID: 10798 RVA: 0x000754C8 File Offset: 0x000736C8
		// (set) Token: 0x06002A2F RID: 10799 RVA: 0x000754D0 File Offset: 0x000736D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MainAffixId
		{
			get
			{
				return this.mainAffixId_;
			}
			set
			{
				this.mainAffixId_ = value;
			}
		}

		// Token: 0x17000C1D RID: 3101
		// (get) Token: 0x06002A30 RID: 10800 RVA: 0x000754D9 File Offset: 0x000736D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RelicAffix> SubAffixList
		{
			get
			{
				return this.subAffixList_;
			}
		}

		// Token: 0x17000C1E RID: 3102
		// (get) Token: 0x06002A31 RID: 10801 RVA: 0x000754E1 File Offset: 0x000736E1
		// (set) Token: 0x06002A32 RID: 10802 RVA: 0x000754E9 File Offset: 0x000736E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Exp
		{
			get
			{
				return this.exp_;
			}
			set
			{
				this.exp_ = value;
			}
		}

		// Token: 0x06002A33 RID: 10803 RVA: 0x000754F2 File Offset: 0x000736F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DisplayRelicInfo);
		}

		// Token: 0x06002A34 RID: 10804 RVA: 0x00075500 File Offset: 0x00073700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DisplayRelicInfo other)
		{
			return other != null && (other == this || (this.Level == other.Level && this.Tid == other.Tid && this.Type == other.Type && this.MainAffixId == other.MainAffixId && this.subAffixList_.Equals(other.subAffixList_) && this.Exp == other.Exp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002A35 RID: 10805 RVA: 0x00075590 File Offset: 0x00073790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.Tid != 0U)
			{
				num ^= this.Tid.GetHashCode();
			}
			if (this.Type != 0U)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.MainAffixId != 0U)
			{
				num ^= this.MainAffixId.GetHashCode();
			}
			num ^= this.subAffixList_.GetHashCode();
			if (this.Exp != 0U)
			{
				num ^= this.Exp.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002A36 RID: 10806 RVA: 0x00075641 File Offset: 0x00073841
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002A37 RID: 10807 RVA: 0x00075649 File Offset: 0x00073849
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002A38 RID: 10808 RVA: 0x00075654 File Offset: 0x00073854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MainAffixId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.MainAffixId);
			}
			if (this.Tid != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Tid);
			}
			if (this.Exp != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Exp);
			}
			if (this.Level != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Level);
			}
			this.subAffixList_.WriteTo(ref output, DisplayRelicInfo._repeated_subAffixList_codec);
			if (this.Type != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Type);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002A39 RID: 10809 RVA: 0x00075714 File Offset: 0x00073914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this.Tid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Tid);
			}
			if (this.Type != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Type);
			}
			if (this.MainAffixId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MainAffixId);
			}
			num += this.subAffixList_.CalculateSize(DisplayRelicInfo._repeated_subAffixList_codec);
			if (this.Exp != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Exp);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002A3A RID: 10810 RVA: 0x000757C8 File Offset: 0x000739C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DisplayRelicInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			if (other.Tid != 0U)
			{
				this.Tid = other.Tid;
			}
			if (other.Type != 0U)
			{
				this.Type = other.Type;
			}
			if (other.MainAffixId != 0U)
			{
				this.MainAffixId = other.MainAffixId;
			}
			this.subAffixList_.Add(other.subAffixList_);
			if (other.Exp != 0U)
			{
				this.Exp = other.Exp;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002A3B RID: 10811 RVA: 0x00075865 File Offset: 0x00073A65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002A3C RID: 10812 RVA: 0x00075870 File Offset: 0x00073A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 64U)
				{
					if (num == 32U)
					{
						this.MainAffixId = input.ReadUInt32();
						continue;
					}
					if (num == 48U)
					{
						this.Tid = input.ReadUInt32();
						continue;
					}
					if (num == 64U)
					{
						this.Exp = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.Level = input.ReadUInt32();
						continue;
					}
					if (num == 106U)
					{
						this.subAffixList_.AddEntriesFrom(ref input, DisplayRelicInfo._repeated_subAffixList_codec);
						continue;
					}
					if (num == 120U)
					{
						this.Type = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001106 RID: 4358
		private static readonly MessageParser<DisplayRelicInfo> _parser = new MessageParser<DisplayRelicInfo>(() => new DisplayRelicInfo());

		// Token: 0x04001107 RID: 4359
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001108 RID: 4360
		public const int LevelFieldNumber = 10;

		// Token: 0x04001109 RID: 4361
		private uint level_;

		// Token: 0x0400110A RID: 4362
		public const int TidFieldNumber = 6;

		// Token: 0x0400110B RID: 4363
		private uint tid_;

		// Token: 0x0400110C RID: 4364
		public const int TypeFieldNumber = 15;

		// Token: 0x0400110D RID: 4365
		private uint type_;

		// Token: 0x0400110E RID: 4366
		public const int MainAffixIdFieldNumber = 4;

		// Token: 0x0400110F RID: 4367
		private uint mainAffixId_;

		// Token: 0x04001110 RID: 4368
		public const int SubAffixListFieldNumber = 13;

		// Token: 0x04001111 RID: 4369
		private static readonly FieldCodec<RelicAffix> _repeated_subAffixList_codec = FieldCodec.ForMessage<RelicAffix>(106U, RelicAffix.Parser);

		// Token: 0x04001112 RID: 4370
		private readonly RepeatedField<RelicAffix> subAffixList_ = new RepeatedField<RelicAffix>();

		// Token: 0x04001113 RID: 4371
		public const int ExpFieldNumber = 8;

		// Token: 0x04001114 RID: 4372
		private uint exp_;
	}
}
