using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000AD RID: 173
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ArchiveData : IMessage<ArchiveData>, IMessage, IEquatable<ArchiveData>, IDeepCloneable<ArchiveData>, IBufferMessage
	{
		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000778 RID: 1912 RVA: 0x000151CF File Offset: 0x000133CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ArchiveData> Parser
		{
			get
			{
				return ArchiveData._parser;
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000779 RID: 1913 RVA: 0x000151D6 File Offset: 0x000133D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ArchiveDataReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x0600077A RID: 1914 RVA: 0x000151E8 File Offset: 0x000133E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ArchiveData.Descriptor;
			}
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x000151EF File Offset: 0x000133EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArchiveData()
		{
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x00015230 File Offset: 0x00013430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArchiveData(ArchiveData other) : this()
		{
			this.archiveEquipmentIdList_ = other.archiveEquipmentIdList_.Clone();
			this.archiveMissingEquipmentIdList_ = other.archiveMissingEquipmentIdList_.Clone();
			this.relicList_ = other.relicList_.Clone();
			this.killMonsterList_ = other.killMonsterList_.Clone();
			this.archiveAvatarIdList_ = other.archiveAvatarIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x000152A9 File Offset: 0x000134A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArchiveData Clone()
		{
			return new ArchiveData(this);
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x0600077E RID: 1918 RVA: 0x000152B1 File Offset: 0x000134B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> ArchiveEquipmentIdList
		{
			get
			{
				return this.archiveEquipmentIdList_;
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x0600077F RID: 1919 RVA: 0x000152B9 File Offset: 0x000134B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> ArchiveMissingEquipmentIdList
		{
			get
			{
				return this.archiveMissingEquipmentIdList_;
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000780 RID: 1920 RVA: 0x000152C1 File Offset: 0x000134C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RelicList> RelicList
		{
			get
			{
				return this.relicList_;
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000781 RID: 1921 RVA: 0x000152C9 File Offset: 0x000134C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MonsterList> KillMonsterList
		{
			get
			{
				return this.killMonsterList_;
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000782 RID: 1922 RVA: 0x000152D1 File Offset: 0x000134D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> ArchiveAvatarIdList
		{
			get
			{
				return this.archiveAvatarIdList_;
			}
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x000152D9 File Offset: 0x000134D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ArchiveData);
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x000152E8 File Offset: 0x000134E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ArchiveData other)
		{
			return other != null && (other == this || (this.archiveEquipmentIdList_.Equals(other.archiveEquipmentIdList_) && this.archiveMissingEquipmentIdList_.Equals(other.archiveMissingEquipmentIdList_) && this.relicList_.Equals(other.relicList_) && this.killMonsterList_.Equals(other.killMonsterList_) && this.archiveAvatarIdList_.Equals(other.archiveAvatarIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x0001537C File Offset: 0x0001357C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.archiveEquipmentIdList_.GetHashCode();
			num ^= this.archiveMissingEquipmentIdList_.GetHashCode();
			num ^= this.relicList_.GetHashCode();
			num ^= this.killMonsterList_.GetHashCode();
			num ^= this.archiveAvatarIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x000153E8 File Offset: 0x000135E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x000153F0 File Offset: 0x000135F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x000153FC File Offset: 0x000135FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.archiveMissingEquipmentIdList_.WriteTo(ref output, ArchiveData._repeated_archiveMissingEquipmentIdList_codec);
			this.archiveEquipmentIdList_.WriteTo(ref output, ArchiveData._repeated_archiveEquipmentIdList_codec);
			this.archiveAvatarIdList_.WriteTo(ref output, ArchiveData._repeated_archiveAvatarIdList_codec);
			this.relicList_.WriteTo(ref output, ArchiveData._repeated_relicList_codec);
			this.killMonsterList_.WriteTo(ref output, ArchiveData._repeated_killMonsterList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x00015474 File Offset: 0x00013674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.archiveEquipmentIdList_.CalculateSize(ArchiveData._repeated_archiveEquipmentIdList_codec);
			num += this.archiveMissingEquipmentIdList_.CalculateSize(ArchiveData._repeated_archiveMissingEquipmentIdList_codec);
			num += this.relicList_.CalculateSize(ArchiveData._repeated_relicList_codec);
			num += this.killMonsterList_.CalculateSize(ArchiveData._repeated_killMonsterList_codec);
			num += this.archiveAvatarIdList_.CalculateSize(ArchiveData._repeated_archiveAvatarIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x000154FC File Offset: 0x000136FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ArchiveData other)
		{
			if (other == null)
			{
				return;
			}
			this.archiveEquipmentIdList_.Add(other.archiveEquipmentIdList_);
			this.archiveMissingEquipmentIdList_.Add(other.archiveMissingEquipmentIdList_);
			this.relicList_.Add(other.relicList_);
			this.killMonsterList_.Add(other.killMonsterList_);
			this.archiveAvatarIdList_.Add(other.archiveAvatarIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x00015579 File Offset: 0x00013779
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x00015584 File Offset: 0x00013784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 34U)
				{
					if (num <= 10U)
					{
						if (num == 8U || num == 10U)
						{
							this.archiveMissingEquipmentIdList_.AddEntriesFrom(ref input, ArchiveData._repeated_archiveMissingEquipmentIdList_codec);
							continue;
						}
					}
					else if (num == 32U || num == 34U)
					{
						this.archiveEquipmentIdList_.AddEntriesFrom(ref input, ArchiveData._repeated_archiveEquipmentIdList_codec);
						continue;
					}
				}
				else if (num <= 58U)
				{
					if (num == 56U || num == 58U)
					{
						this.archiveAvatarIdList_.AddEntriesFrom(ref input, ArchiveData._repeated_archiveAvatarIdList_codec);
						continue;
					}
				}
				else
				{
					if (num == 74U)
					{
						this.relicList_.AddEntriesFrom(ref input, ArchiveData._repeated_relicList_codec);
						continue;
					}
					if (num == 122U)
					{
						this.killMonsterList_.AddEntriesFrom(ref input, ArchiveData._repeated_killMonsterList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040002C5 RID: 709
		private static readonly MessageParser<ArchiveData> _parser = new MessageParser<ArchiveData>(() => new ArchiveData());

		// Token: 0x040002C6 RID: 710
		private UnknownFieldSet _unknownFields;

		// Token: 0x040002C7 RID: 711
		public const int ArchiveEquipmentIdListFieldNumber = 4;

		// Token: 0x040002C8 RID: 712
		private static readonly FieldCodec<uint> _repeated_archiveEquipmentIdList_codec = FieldCodec.ForUInt32(34U);

		// Token: 0x040002C9 RID: 713
		private readonly RepeatedField<uint> archiveEquipmentIdList_ = new RepeatedField<uint>();

		// Token: 0x040002CA RID: 714
		public const int ArchiveMissingEquipmentIdListFieldNumber = 1;

		// Token: 0x040002CB RID: 715
		private static readonly FieldCodec<uint> _repeated_archiveMissingEquipmentIdList_codec = FieldCodec.ForUInt32(10U);

		// Token: 0x040002CC RID: 716
		private readonly RepeatedField<uint> archiveMissingEquipmentIdList_ = new RepeatedField<uint>();

		// Token: 0x040002CD RID: 717
		public const int RelicListFieldNumber = 9;

		// Token: 0x040002CE RID: 718
		private static readonly FieldCodec<RelicList> _repeated_relicList_codec = FieldCodec.ForMessage<RelicList>(74U, EggLink.DanhengServer.Proto.RelicList.Parser);

		// Token: 0x040002CF RID: 719
		private readonly RepeatedField<RelicList> relicList_ = new RepeatedField<RelicList>();

		// Token: 0x040002D0 RID: 720
		public const int KillMonsterListFieldNumber = 15;

		// Token: 0x040002D1 RID: 721
		private static readonly FieldCodec<MonsterList> _repeated_killMonsterList_codec = FieldCodec.ForMessage<MonsterList>(122U, MonsterList.Parser);

		// Token: 0x040002D2 RID: 722
		private readonly RepeatedField<MonsterList> killMonsterList_ = new RepeatedField<MonsterList>();

		// Token: 0x040002D3 RID: 723
		public const int ArchiveAvatarIdListFieldNumber = 7;

		// Token: 0x040002D4 RID: 724
		private static readonly FieldCodec<uint> _repeated_archiveAvatarIdList_codec = FieldCodec.ForUInt32(58U);

		// Token: 0x040002D5 RID: 725
		private readonly RepeatedField<uint> archiveAvatarIdList_ = new RepeatedField<uint>();
	}
}
