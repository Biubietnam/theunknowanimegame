using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000101 RID: 257
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BattleRogueMagicUnit : IMessage<BattleRogueMagicUnit>, IMessage, IEquatable<BattleRogueMagicUnit>, IDeepCloneable<BattleRogueMagicUnit>, IBufferMessage
	{
		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000B77 RID: 2935 RVA: 0x00021E60 File Offset: 0x00020060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BattleRogueMagicUnit> Parser
		{
			get
			{
				return BattleRogueMagicUnit._parser;
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000B78 RID: 2936 RVA: 0x00021E67 File Offset: 0x00020067
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BattleRogueMagicUnitReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000B79 RID: 2937 RVA: 0x00021E79 File Offset: 0x00020079
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattleRogueMagicUnit.Descriptor;
			}
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x00021E80 File Offset: 0x00020080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleRogueMagicUnit()
		{
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x00021E94 File Offset: 0x00020094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleRogueMagicUnit(BattleRogueMagicUnit other) : this()
		{
			this.magicUnitId_ = other.magicUnitId_;
			this.level_ = other.level_;
			this.dCEDNGLAOJI_ = other.dCEDNGLAOJI_;
			this.diceSlotId_ = other.diceSlotId_;
			this.hGOCMKMFNDG_ = other.hGOCMKMFNDG_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x00021EF9 File Offset: 0x000200F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleRogueMagicUnit Clone()
		{
			return new BattleRogueMagicUnit(this);
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000B7D RID: 2941 RVA: 0x00021F01 File Offset: 0x00020101
		// (set) Token: 0x06000B7E RID: 2942 RVA: 0x00021F09 File Offset: 0x00020109
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MagicUnitId
		{
			get
			{
				return this.magicUnitId_;
			}
			set
			{
				this.magicUnitId_ = value;
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000B7F RID: 2943 RVA: 0x00021F12 File Offset: 0x00020112
		// (set) Token: 0x06000B80 RID: 2944 RVA: 0x00021F1A File Offset: 0x0002011A
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

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000B81 RID: 2945 RVA: 0x00021F23 File Offset: 0x00020123
		// (set) Token: 0x06000B82 RID: 2946 RVA: 0x00021F2B File Offset: 0x0002012B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool DCEDNGLAOJI
		{
			get
			{
				return this.dCEDNGLAOJI_;
			}
			set
			{
				this.dCEDNGLAOJI_ = value;
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000B83 RID: 2947 RVA: 0x00021F34 File Offset: 0x00020134
		// (set) Token: 0x06000B84 RID: 2948 RVA: 0x00021F3C File Offset: 0x0002013C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DiceSlotId
		{
			get
			{
				return this.diceSlotId_;
			}
			set
			{
				this.diceSlotId_ = value;
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000B85 RID: 2949 RVA: 0x00021F45 File Offset: 0x00020145
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<uint, uint> HGOCMKMFNDG
		{
			get
			{
				return this.hGOCMKMFNDG_;
			}
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x00021F4D File Offset: 0x0002014D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattleRogueMagicUnit);
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x00021F5C File Offset: 0x0002015C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattleRogueMagicUnit other)
		{
			return other != null && (other == this || (this.MagicUnitId == other.MagicUnitId && this.Level == other.Level && this.DCEDNGLAOJI == other.DCEDNGLAOJI && this.DiceSlotId == other.DiceSlotId && this.HGOCMKMFNDG.Equals(other.HGOCMKMFNDG) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x00021FDC File Offset: 0x000201DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MagicUnitId != 0U)
			{
				num ^= this.MagicUnitId.GetHashCode();
			}
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.DCEDNGLAOJI)
			{
				num ^= this.DCEDNGLAOJI.GetHashCode();
			}
			if (this.DiceSlotId != 0U)
			{
				num ^= this.DiceSlotId.GetHashCode();
			}
			num ^= this.HGOCMKMFNDG.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x00022074 File Offset: 0x00020274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x0002207C File Offset: 0x0002027C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x00022088 File Offset: 0x00020288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MagicUnitId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.MagicUnitId);
			}
			if (this.Level != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Level);
			}
			if (this.DCEDNGLAOJI)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.DCEDNGLAOJI);
			}
			if (this.DiceSlotId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.DiceSlotId);
			}
			this.hGOCMKMFNDG_.WriteTo(ref output, BattleRogueMagicUnit._map_hGOCMKMFNDG_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x0002212C File Offset: 0x0002032C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MagicUnitId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MagicUnitId);
			}
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this.DCEDNGLAOJI)
			{
				num += 2;
			}
			if (this.DiceSlotId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DiceSlotId);
			}
			num += this.hGOCMKMFNDG_.CalculateSize(BattleRogueMagicUnit._map_hGOCMKMFNDG_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x000221BC File Offset: 0x000203BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattleRogueMagicUnit other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MagicUnitId != 0U)
			{
				this.MagicUnitId = other.MagicUnitId;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			if (other.DCEDNGLAOJI)
			{
				this.DCEDNGLAOJI = other.DCEDNGLAOJI;
			}
			if (other.DiceSlotId != 0U)
			{
				this.DiceSlotId = other.DiceSlotId;
			}
			this.hGOCMKMFNDG_.MergeFrom(other.hGOCMKMFNDG_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x00022245 File Offset: 0x00020445
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x00022250 File Offset: 0x00020450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.MagicUnitId = input.ReadUInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Level = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.DCEDNGLAOJI = input.ReadBool();
						continue;
					}
					if (num == 32U)
					{
						this.DiceSlotId = input.ReadUInt32();
						continue;
					}
					if (num == 42U)
					{
						this.hGOCMKMFNDG_.AddEntriesFrom(ref input, BattleRogueMagicUnit._map_hGOCMKMFNDG_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040004D0 RID: 1232
		private static readonly MessageParser<BattleRogueMagicUnit> _parser = new MessageParser<BattleRogueMagicUnit>(() => new BattleRogueMagicUnit());

		// Token: 0x040004D1 RID: 1233
		private UnknownFieldSet _unknownFields;

		// Token: 0x040004D2 RID: 1234
		public const int MagicUnitIdFieldNumber = 1;

		// Token: 0x040004D3 RID: 1235
		private uint magicUnitId_;

		// Token: 0x040004D4 RID: 1236
		public const int LevelFieldNumber = 2;

		// Token: 0x040004D5 RID: 1237
		private uint level_;

		// Token: 0x040004D6 RID: 1238
		public const int DCEDNGLAOJIFieldNumber = 3;

		// Token: 0x040004D7 RID: 1239
		private bool dCEDNGLAOJI_;

		// Token: 0x040004D8 RID: 1240
		public const int DiceSlotIdFieldNumber = 4;

		// Token: 0x040004D9 RID: 1241
		private uint diceSlotId_;

		// Token: 0x040004DA RID: 1242
		public const int HGOCMKMFNDGFieldNumber = 5;

		// Token: 0x040004DB RID: 1243
		private static readonly MapField<uint, uint>.Codec _map_hGOCMKMFNDG_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8U, 0U), FieldCodec.ForUInt32(16U, 0U), 42U);

		// Token: 0x040004DC RID: 1244
		private readonly MapField<uint, uint> hGOCMKMFNDG_ = new MapField<uint, uint>();
	}
}
