using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000ED3 RID: 3795
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicGameItemInfo : IMessage<RogueMagicGameItemInfo>, IMessage, IEquatable<RogueMagicGameItemInfo>, IDeepCloneable<RogueMagicGameItemInfo>, IBufferMessage
	{
		// Token: 0x17002FE4 RID: 12260
		// (get) Token: 0x0600A99A RID: 43418 RVA: 0x001C8C53 File Offset: 0x001C6E53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicGameItemInfo> Parser
		{
			get
			{
				return RogueMagicGameItemInfo._parser;
			}
		}

		// Token: 0x17002FE5 RID: 12261
		// (get) Token: 0x0600A99B RID: 43419 RVA: 0x001C8C5A File Offset: 0x001C6E5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicGameItemInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002FE6 RID: 12262
		// (get) Token: 0x0600A99C RID: 43420 RVA: 0x001C8C6C File Offset: 0x001C6E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicGameItemInfo.Descriptor;
			}
		}

		// Token: 0x0600A99D RID: 43421 RVA: 0x001C8C73 File Offset: 0x001C6E73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicGameItemInfo()
		{
		}

		// Token: 0x0600A99E RID: 43422 RVA: 0x001C8C94 File Offset: 0x001C6E94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicGameItemInfo(RogueMagicGameItemInfo other) : this()
		{
			this.ePKBABNCJDC_ = other.ePKBABNCJDC_;
			this.magicScepterInfoList_ = other.magicScepterInfoList_.Clone();
			this.gameStyleType_ = other.gameStyleType_;
			this.rogueMagicUnitInfoList_ = other.rogueMagicUnitInfoList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A99F RID: 43423 RVA: 0x001C8CF2 File Offset: 0x001C6EF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicGameItemInfo Clone()
		{
			return new RogueMagicGameItemInfo(this);
		}

		// Token: 0x17002FE7 RID: 12263
		// (get) Token: 0x0600A9A0 RID: 43424 RVA: 0x001C8CFA File Offset: 0x001C6EFA
		// (set) Token: 0x0600A9A1 RID: 43425 RVA: 0x001C8D02 File Offset: 0x001C6F02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool EPKBABNCJDC
		{
			get
			{
				return this.ePKBABNCJDC_;
			}
			set
			{
				this.ePKBABNCJDC_ = value;
			}
		}

		// Token: 0x17002FE8 RID: 12264
		// (get) Token: 0x0600A9A2 RID: 43426 RVA: 0x001C8D0B File Offset: 0x001C6F0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueMagicGameScepterInfo> MagicScepterInfoList
		{
			get
			{
				return this.magicScepterInfoList_;
			}
		}

		// Token: 0x17002FE9 RID: 12265
		// (get) Token: 0x0600A9A3 RID: 43427 RVA: 0x001C8D13 File Offset: 0x001C6F13
		// (set) Token: 0x0600A9A4 RID: 43428 RVA: 0x001C8D1B File Offset: 0x001C6F1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GameStyleType
		{
			get
			{
				return this.gameStyleType_;
			}
			set
			{
				this.gameStyleType_ = value;
			}
		}

		// Token: 0x17002FEA RID: 12266
		// (get) Token: 0x0600A9A5 RID: 43429 RVA: 0x001C8D24 File Offset: 0x001C6F24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueMagicGameUnitInfo> RogueMagicUnitInfoList
		{
			get
			{
				return this.rogueMagicUnitInfoList_;
			}
		}

		// Token: 0x0600A9A6 RID: 43430 RVA: 0x001C8D2C File Offset: 0x001C6F2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicGameItemInfo);
		}

		// Token: 0x0600A9A7 RID: 43431 RVA: 0x001C8D3C File Offset: 0x001C6F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicGameItemInfo other)
		{
			return other != null && (other == this || (this.EPKBABNCJDC == other.EPKBABNCJDC && this.magicScepterInfoList_.Equals(other.magicScepterInfoList_) && this.GameStyleType == other.GameStyleType && this.rogueMagicUnitInfoList_.Equals(other.rogueMagicUnitInfoList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A9A8 RID: 43432 RVA: 0x001C8DB0 File Offset: 0x001C6FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EPKBABNCJDC)
			{
				num ^= this.EPKBABNCJDC.GetHashCode();
			}
			num ^= this.magicScepterInfoList_.GetHashCode();
			if (this.GameStyleType != 0U)
			{
				num ^= this.GameStyleType.GetHashCode();
			}
			num ^= this.rogueMagicUnitInfoList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A9A9 RID: 43433 RVA: 0x001C8E24 File Offset: 0x001C7024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A9AA RID: 43434 RVA: 0x001C8E2C File Offset: 0x001C702C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A9AB RID: 43435 RVA: 0x001C8E38 File Offset: 0x001C7038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GameStyleType != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.GameStyleType);
			}
			this.rogueMagicUnitInfoList_.WriteTo(ref output, RogueMagicGameItemInfo._repeated_rogueMagicUnitInfoList_codec);
			this.magicScepterInfoList_.WriteTo(ref output, RogueMagicGameItemInfo._repeated_magicScepterInfoList_codec);
			if (this.EPKBABNCJDC)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.EPKBABNCJDC);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A9AC RID: 43436 RVA: 0x001C8EB4 File Offset: 0x001C70B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EPKBABNCJDC)
			{
				num += 2;
			}
			num += this.magicScepterInfoList_.CalculateSize(RogueMagicGameItemInfo._repeated_magicScepterInfoList_codec);
			if (this.GameStyleType != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameStyleType);
			}
			num += this.rogueMagicUnitInfoList_.CalculateSize(RogueMagicGameItemInfo._repeated_rogueMagicUnitInfoList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A9AD RID: 43437 RVA: 0x001C8F24 File Offset: 0x001C7124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicGameItemInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EPKBABNCJDC)
			{
				this.EPKBABNCJDC = other.EPKBABNCJDC;
			}
			this.magicScepterInfoList_.Add(other.magicScepterInfoList_);
			if (other.GameStyleType != 0U)
			{
				this.GameStyleType = other.GameStyleType;
			}
			this.rogueMagicUnitInfoList_.Add(other.rogueMagicUnitInfoList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A9AE RID: 43438 RVA: 0x001C8F96 File Offset: 0x001C7196
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A9AF RID: 43439 RVA: 0x001C8FA0 File Offset: 0x001C71A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 50U)
				{
					if (num == 24U)
					{
						this.GameStyleType = input.ReadUInt32();
						continue;
					}
					if (num == 50U)
					{
						this.rogueMagicUnitInfoList_.AddEntriesFrom(ref input, RogueMagicGameItemInfo._repeated_rogueMagicUnitInfoList_codec);
						continue;
					}
				}
				else
				{
					if (num == 114U)
					{
						this.magicScepterInfoList_.AddEntriesFrom(ref input, RogueMagicGameItemInfo._repeated_magicScepterInfoList_codec);
						continue;
					}
					if (num == 120U)
					{
						this.EPKBABNCJDC = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004537 RID: 17719
		private static readonly MessageParser<RogueMagicGameItemInfo> _parser = new MessageParser<RogueMagicGameItemInfo>(() => new RogueMagicGameItemInfo());

		// Token: 0x04004538 RID: 17720
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004539 RID: 17721
		public const int EPKBABNCJDCFieldNumber = 15;

		// Token: 0x0400453A RID: 17722
		private bool ePKBABNCJDC_;

		// Token: 0x0400453B RID: 17723
		public const int MagicScepterInfoListFieldNumber = 14;

		// Token: 0x0400453C RID: 17724
		private static readonly FieldCodec<RogueMagicGameScepterInfo> _repeated_magicScepterInfoList_codec = FieldCodec.ForMessage<RogueMagicGameScepterInfo>(114U, RogueMagicGameScepterInfo.Parser);

		// Token: 0x0400453D RID: 17725
		private readonly RepeatedField<RogueMagicGameScepterInfo> magicScepterInfoList_ = new RepeatedField<RogueMagicGameScepterInfo>();

		// Token: 0x0400453E RID: 17726
		public const int GameStyleTypeFieldNumber = 3;

		// Token: 0x0400453F RID: 17727
		private uint gameStyleType_;

		// Token: 0x04004540 RID: 17728
		public const int RogueMagicUnitInfoListFieldNumber = 6;

		// Token: 0x04004541 RID: 17729
		private static readonly FieldCodec<RogueMagicGameUnitInfo> _repeated_rogueMagicUnitInfoList_codec = FieldCodec.ForMessage<RogueMagicGameUnitInfo>(50U, RogueMagicGameUnitInfo.Parser);

		// Token: 0x04004542 RID: 17730
		private readonly RepeatedField<RogueMagicGameUnitInfo> rogueMagicUnitInfoList_ = new RepeatedField<RogueMagicGameUnitInfo>();
	}
}
