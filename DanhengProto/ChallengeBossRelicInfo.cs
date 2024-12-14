using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200019D RID: 413
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChallengeBossRelicInfo : IMessage<ChallengeBossRelicInfo>, IMessage, IEquatable<ChallengeBossRelicInfo>, IDeepCloneable<ChallengeBossRelicInfo>, IBufferMessage
	{
		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06001288 RID: 4744 RVA: 0x00035A4B File Offset: 0x00033C4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChallengeBossRelicInfo> Parser
		{
			get
			{
				return ChallengeBossRelicInfo._parser;
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06001289 RID: 4745 RVA: 0x00035A52 File Offset: 0x00033C52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChallengeBossRelicInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x0600128A RID: 4746 RVA: 0x00035A64 File Offset: 0x00033C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChallengeBossRelicInfo.Descriptor;
			}
		}

		// Token: 0x0600128B RID: 4747 RVA: 0x00035A6B File Offset: 0x00033C6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeBossRelicInfo()
		{
		}

		// Token: 0x0600128C RID: 4748 RVA: 0x00035A80 File Offset: 0x00033C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeBossRelicInfo(ChallengeBossRelicInfo other) : this()
		{
			this.mainAffixId_ = other.mainAffixId_;
			this.tid_ = other.tid_;
			this.subAffixList_ = other.subAffixList_.Clone();
			this.level_ = other.level_;
			this.uniqueId_ = other.uniqueId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600128D RID: 4749 RVA: 0x00035AE5 File Offset: 0x00033CE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChallengeBossRelicInfo Clone()
		{
			return new ChallengeBossRelicInfo(this);
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x0600128E RID: 4750 RVA: 0x00035AED File Offset: 0x00033CED
		// (set) Token: 0x0600128F RID: 4751 RVA: 0x00035AF5 File Offset: 0x00033CF5
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

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06001290 RID: 4752 RVA: 0x00035AFE File Offset: 0x00033CFE
		// (set) Token: 0x06001291 RID: 4753 RVA: 0x00035B06 File Offset: 0x00033D06
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

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06001292 RID: 4754 RVA: 0x00035B0F File Offset: 0x00033D0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RelicAffix> SubAffixList
		{
			get
			{
				return this.subAffixList_;
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06001293 RID: 4755 RVA: 0x00035B17 File Offset: 0x00033D17
		// (set) Token: 0x06001294 RID: 4756 RVA: 0x00035B1F File Offset: 0x00033D1F
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

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06001295 RID: 4757 RVA: 0x00035B28 File Offset: 0x00033D28
		// (set) Token: 0x06001296 RID: 4758 RVA: 0x00035B30 File Offset: 0x00033D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint UniqueId
		{
			get
			{
				return this.uniqueId_;
			}
			set
			{
				this.uniqueId_ = value;
			}
		}

		// Token: 0x06001297 RID: 4759 RVA: 0x00035B39 File Offset: 0x00033D39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChallengeBossRelicInfo);
		}

		// Token: 0x06001298 RID: 4760 RVA: 0x00035B48 File Offset: 0x00033D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChallengeBossRelicInfo other)
		{
			return other != null && (other == this || (this.MainAffixId == other.MainAffixId && this.Tid == other.Tid && this.subAffixList_.Equals(other.subAffixList_) && this.Level == other.Level && this.UniqueId == other.UniqueId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001299 RID: 4761 RVA: 0x00035BC8 File Offset: 0x00033DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MainAffixId != 0U)
			{
				num ^= this.MainAffixId.GetHashCode();
			}
			if (this.Tid != 0U)
			{
				num ^= this.Tid.GetHashCode();
			}
			num ^= this.subAffixList_.GetHashCode();
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.UniqueId != 0U)
			{
				num ^= this.UniqueId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600129A RID: 4762 RVA: 0x00035C60 File Offset: 0x00033E60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600129B RID: 4763 RVA: 0x00035C68 File Offset: 0x00033E68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600129C RID: 4764 RVA: 0x00035C74 File Offset: 0x00033E74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.subAffixList_.WriteTo(ref output, ChallengeBossRelicInfo._repeated_subAffixList_codec);
			if (this.MainAffixId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.MainAffixId);
			}
			if (this.UniqueId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.UniqueId);
			}
			if (this.Level != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Level);
			}
			if (this.Tid != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Tid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600129D RID: 4765 RVA: 0x00035D18 File Offset: 0x00033F18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MainAffixId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MainAffixId);
			}
			if (this.Tid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Tid);
			}
			num += this.subAffixList_.CalculateSize(ChallengeBossRelicInfo._repeated_subAffixList_codec);
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this.UniqueId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.UniqueId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600129E RID: 4766 RVA: 0x00035DB4 File Offset: 0x00033FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChallengeBossRelicInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MainAffixId != 0U)
			{
				this.MainAffixId = other.MainAffixId;
			}
			if (other.Tid != 0U)
			{
				this.Tid = other.Tid;
			}
			this.subAffixList_.Add(other.subAffixList_);
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			if (other.UniqueId != 0U)
			{
				this.UniqueId = other.UniqueId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600129F RID: 4767 RVA: 0x00035E3D File Offset: 0x0003403D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060012A0 RID: 4768 RVA: 0x00035E48 File Offset: 0x00034048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 16U)
				{
					if (num == 10U)
					{
						this.subAffixList_.AddEntriesFrom(ref input, ChallengeBossRelicInfo._repeated_subAffixList_codec);
						continue;
					}
					if (num == 16U)
					{
						this.MainAffixId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.UniqueId = input.ReadUInt32();
						continue;
					}
					if (num == 40U)
					{
						this.Level = input.ReadUInt32();
						continue;
					}
					if (num == 80U)
					{
						this.Tid = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040007D7 RID: 2007
		private static readonly MessageParser<ChallengeBossRelicInfo> _parser = new MessageParser<ChallengeBossRelicInfo>(() => new ChallengeBossRelicInfo());

		// Token: 0x040007D8 RID: 2008
		private UnknownFieldSet _unknownFields;

		// Token: 0x040007D9 RID: 2009
		public const int MainAffixIdFieldNumber = 2;

		// Token: 0x040007DA RID: 2010
		private uint mainAffixId_;

		// Token: 0x040007DB RID: 2011
		public const int TidFieldNumber = 10;

		// Token: 0x040007DC RID: 2012
		private uint tid_;

		// Token: 0x040007DD RID: 2013
		public const int SubAffixListFieldNumber = 1;

		// Token: 0x040007DE RID: 2014
		private static readonly FieldCodec<RelicAffix> _repeated_subAffixList_codec = FieldCodec.ForMessage<RelicAffix>(10U, RelicAffix.Parser);

		// Token: 0x040007DF RID: 2015
		private readonly RepeatedField<RelicAffix> subAffixList_ = new RepeatedField<RelicAffix>();

		// Token: 0x040007E0 RID: 2016
		public const int LevelFieldNumber = 5;

		// Token: 0x040007E1 RID: 2017
		private uint level_;

		// Token: 0x040007E2 RID: 2018
		public const int UniqueIdFieldNumber = 4;

		// Token: 0x040007E3 RID: 2019
		private uint uniqueId_;
	}
}
