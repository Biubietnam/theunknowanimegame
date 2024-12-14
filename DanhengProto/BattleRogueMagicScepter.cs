using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000FF RID: 255
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BattleRogueMagicScepter : IMessage<BattleRogueMagicScepter>, IMessage, IEquatable<BattleRogueMagicScepter>, IDeepCloneable<BattleRogueMagicScepter>, IBufferMessage
	{
		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000B5E RID: 2910 RVA: 0x00021964 File Offset: 0x0001FB64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BattleRogueMagicScepter> Parser
		{
			get
			{
				return BattleRogueMagicScepter._parser;
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000B5F RID: 2911 RVA: 0x0002196B File Offset: 0x0001FB6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BattleRogueMagicScepterReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000B60 RID: 2912 RVA: 0x0002197D File Offset: 0x0001FB7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattleRogueMagicScepter.Descriptor;
			}
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x00021984 File Offset: 0x0001FB84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleRogueMagicScepter()
		{
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x000219A4 File Offset: 0x0001FBA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleRogueMagicScepter(BattleRogueMagicScepter other) : this()
		{
			this.scepterId_ = other.scepterId_;
			this.rogueMagicUnitInfoList_ = other.rogueMagicUnitInfoList_.Clone();
			this.level_ = other.level_;
			this.trenchCount_ = other.trenchCount_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x00021A02 File Offset: 0x0001FC02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleRogueMagicScepter Clone()
		{
			return new BattleRogueMagicScepter(this);
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000B64 RID: 2916 RVA: 0x00021A0A File Offset: 0x0001FC0A
		// (set) Token: 0x06000B65 RID: 2917 RVA: 0x00021A12 File Offset: 0x0001FC12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ScepterId
		{
			get
			{
				return this.scepterId_;
			}
			set
			{
				this.scepterId_ = value;
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000B66 RID: 2918 RVA: 0x00021A1B File Offset: 0x0001FC1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BattleRogueMagicUnit> RogueMagicUnitInfoList
		{
			get
			{
				return this.rogueMagicUnitInfoList_;
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000B67 RID: 2919 RVA: 0x00021A23 File Offset: 0x0001FC23
		// (set) Token: 0x06000B68 RID: 2920 RVA: 0x00021A2B File Offset: 0x0001FC2B
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

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000B69 RID: 2921 RVA: 0x00021A34 File Offset: 0x0001FC34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<uint, uint> TrenchCount
		{
			get
			{
				return this.trenchCount_;
			}
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x00021A3C File Offset: 0x0001FC3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattleRogueMagicScepter);
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x00021A4C File Offset: 0x0001FC4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattleRogueMagicScepter other)
		{
			return other != null && (other == this || (this.ScepterId == other.ScepterId && this.rogueMagicUnitInfoList_.Equals(other.rogueMagicUnitInfoList_) && this.Level == other.Level && this.TrenchCount.Equals(other.TrenchCount) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x00021AC0 File Offset: 0x0001FCC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ScepterId != 0U)
			{
				num ^= this.ScepterId.GetHashCode();
			}
			num ^= this.rogueMagicUnitInfoList_.GetHashCode();
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			num ^= this.TrenchCount.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x00021B34 File Offset: 0x0001FD34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x00021B3C File Offset: 0x0001FD3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x00021B48 File Offset: 0x0001FD48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ScepterId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.ScepterId);
			}
			this.rogueMagicUnitInfoList_.WriteTo(ref output, BattleRogueMagicScepter._repeated_rogueMagicUnitInfoList_codec);
			if (this.Level != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Level);
			}
			this.trenchCount_.WriteTo(ref output, BattleRogueMagicScepter._map_trenchCount_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x00021BC4 File Offset: 0x0001FDC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ScepterId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ScepterId);
			}
			num += this.rogueMagicUnitInfoList_.CalculateSize(BattleRogueMagicScepter._repeated_rogueMagicUnitInfoList_codec);
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			num += this.trenchCount_.CalculateSize(BattleRogueMagicScepter._map_trenchCount_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x00021C40 File Offset: 0x0001FE40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattleRogueMagicScepter other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ScepterId != 0U)
			{
				this.ScepterId = other.ScepterId;
			}
			this.rogueMagicUnitInfoList_.Add(other.rogueMagicUnitInfoList_);
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			this.trenchCount_.MergeFrom(other.trenchCount_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x00021CB2 File Offset: 0x0001FEB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x00021CBC File Offset: 0x0001FEBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 18U)
				{
					if (num == 8U)
					{
						this.ScepterId = input.ReadUInt32();
						continue;
					}
					if (num == 18U)
					{
						this.rogueMagicUnitInfoList_.AddEntriesFrom(ref input, BattleRogueMagicScepter._repeated_rogueMagicUnitInfoList_codec);
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Level = input.ReadUInt32();
						continue;
					}
					if (num == 34U)
					{
						this.trenchCount_.AddEntriesFrom(ref input, BattleRogueMagicScepter._map_trenchCount_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040004C3 RID: 1219
		private static readonly MessageParser<BattleRogueMagicScepter> _parser = new MessageParser<BattleRogueMagicScepter>(() => new BattleRogueMagicScepter());

		// Token: 0x040004C4 RID: 1220
		private UnknownFieldSet _unknownFields;

		// Token: 0x040004C5 RID: 1221
		public const int ScepterIdFieldNumber = 1;

		// Token: 0x040004C6 RID: 1222
		private uint scepterId_;

		// Token: 0x040004C7 RID: 1223
		public const int RogueMagicUnitInfoListFieldNumber = 2;

		// Token: 0x040004C8 RID: 1224
		private static readonly FieldCodec<BattleRogueMagicUnit> _repeated_rogueMagicUnitInfoList_codec = FieldCodec.ForMessage<BattleRogueMagicUnit>(18U, BattleRogueMagicUnit.Parser);

		// Token: 0x040004C9 RID: 1225
		private readonly RepeatedField<BattleRogueMagicUnit> rogueMagicUnitInfoList_ = new RepeatedField<BattleRogueMagicUnit>();

		// Token: 0x040004CA RID: 1226
		public const int LevelFieldNumber = 3;

		// Token: 0x040004CB RID: 1227
		private uint level_;

		// Token: 0x040004CC RID: 1228
		public const int TrenchCountFieldNumber = 4;

		// Token: 0x040004CD RID: 1229
		private static readonly MapField<uint, uint>.Codec _map_trenchCount_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8U, 0U), FieldCodec.ForUInt32(16U, 0U), 34U);

		// Token: 0x040004CE RID: 1230
		private readonly MapField<uint, uint> trenchCount_ = new MapField<uint, uint>();
	}
}
