using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000277 RID: 631
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueQueryDiceInfo : IMessage<ChessRogueQueryDiceInfo>, IMessage, IEquatable<ChessRogueQueryDiceInfo>, IDeepCloneable<ChessRogueQueryDiceInfo>, IBufferMessage
	{
		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x06001C1A RID: 7194 RVA: 0x00050708 File Offset: 0x0004E908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueQueryDiceInfo> Parser
		{
			get
			{
				return ChessRogueQueryDiceInfo._parser;
			}
		}

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x06001C1B RID: 7195 RVA: 0x0005070F File Offset: 0x0004E90F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueQueryDiceInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x06001C1C RID: 7196 RVA: 0x00050721 File Offset: 0x0004E921
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueQueryDiceInfo.Descriptor;
			}
		}

		// Token: 0x06001C1D RID: 7197 RVA: 0x00050728 File Offset: 0x0004E928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueQueryDiceInfo()
		{
		}

		// Token: 0x06001C1E RID: 7198 RVA: 0x00050754 File Offset: 0x0004E954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueQueryDiceInfo(ChessRogueQueryDiceInfo other) : this()
		{
			this.sus_ = other.sus_.Clone();
			this.dicePhase_ = other.dicePhase_;
			this.diceList_ = other.diceList_.Clone();
			this.surfaceIdList_ = other.surfaceIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001C1F RID: 7199 RVA: 0x000507B7 File Offset: 0x0004E9B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueQueryDiceInfo Clone()
		{
			return new ChessRogueQueryDiceInfo(this);
		}

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x06001C20 RID: 7200 RVA: 0x000507BF File Offset: 0x0004E9BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<uint, bool> Sus
		{
			get
			{
				return this.sus_;
			}
		}

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x06001C21 RID: 7201 RVA: 0x000507C7 File Offset: 0x0004E9C7
		// (set) Token: 0x06001C22 RID: 7202 RVA: 0x000507CF File Offset: 0x0004E9CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueNousDicePhase DicePhase
		{
			get
			{
				return this.dicePhase_;
			}
			set
			{
				this.dicePhase_ = value;
			}
		}

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x06001C23 RID: 7203 RVA: 0x000507D8 File Offset: 0x0004E9D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ChessRogueDice> DiceList
		{
			get
			{
				return this.diceList_;
			}
		}

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x06001C24 RID: 7204 RVA: 0x000507E0 File Offset: 0x0004E9E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> SurfaceIdList
		{
			get
			{
				return this.surfaceIdList_;
			}
		}

		// Token: 0x06001C25 RID: 7205 RVA: 0x000507E8 File Offset: 0x0004E9E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueQueryDiceInfo);
		}

		// Token: 0x06001C26 RID: 7206 RVA: 0x000507F8 File Offset: 0x0004E9F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueQueryDiceInfo other)
		{
			return other != null && (other == this || (this.Sus.Equals(other.Sus) && this.DicePhase == other.DicePhase && this.diceList_.Equals(other.diceList_) && this.surfaceIdList_.Equals(other.surfaceIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001C27 RID: 7207 RVA: 0x00050870 File Offset: 0x0004EA70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.Sus.GetHashCode();
			if (this.DicePhase != ChessRogueNousDicePhase.None)
			{
				num ^= this.DicePhase.GetHashCode();
			}
			num ^= this.diceList_.GetHashCode();
			num ^= this.surfaceIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001C28 RID: 7208 RVA: 0x000508DF File Offset: 0x0004EADF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001C29 RID: 7209 RVA: 0x000508E7 File Offset: 0x0004EAE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001C2A RID: 7210 RVA: 0x000508F0 File Offset: 0x0004EAF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.diceList_.WriteTo(ref output, ChessRogueQueryDiceInfo._repeated_diceList_codec);
			this.surfaceIdList_.WriteTo(ref output, ChessRogueQueryDiceInfo._repeated_surfaceIdList_codec);
			if (this.DicePhase != ChessRogueNousDicePhase.None)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.DicePhase);
			}
			this.sus_.WriteTo(ref output, ChessRogueQueryDiceInfo._map_sus_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001C2B RID: 7211 RVA: 0x00050960 File Offset: 0x0004EB60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.sus_.CalculateSize(ChessRogueQueryDiceInfo._map_sus_codec);
			if (this.DicePhase != ChessRogueNousDicePhase.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.DicePhase);
			}
			num += this.diceList_.CalculateSize(ChessRogueQueryDiceInfo._repeated_diceList_codec);
			num += this.surfaceIdList_.CalculateSize(ChessRogueQueryDiceInfo._repeated_surfaceIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001C2C RID: 7212 RVA: 0x000509D8 File Offset: 0x0004EBD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueQueryDiceInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.sus_.MergeFrom(other.sus_);
			if (other.DicePhase != ChessRogueNousDicePhase.None)
			{
				this.DicePhase = other.DicePhase;
			}
			this.diceList_.Add(other.diceList_);
			this.surfaceIdList_.Add(other.surfaceIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001C2D RID: 7213 RVA: 0x00050A47 File Offset: 0x0004EC47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001C2E RID: 7214 RVA: 0x00050A50 File Offset: 0x0004EC50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 24U)
				{
					if (num == 10U)
					{
						this.diceList_.AddEntriesFrom(ref input, ChessRogueQueryDiceInfo._repeated_diceList_codec);
						continue;
					}
					if (num == 24U)
					{
						goto IL_49;
					}
				}
				else
				{
					if (num == 26U)
					{
						goto IL_49;
					}
					if (num == 80U)
					{
						this.DicePhase = (ChessRogueNousDicePhase)input.ReadEnum();
						continue;
					}
					if (num == 98U)
					{
						this.sus_.AddEntriesFrom(ref input, ChessRogueQueryDiceInfo._map_sus_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_49:
				this.surfaceIdList_.AddEntriesFrom(ref input, ChessRogueQueryDiceInfo._repeated_surfaceIdList_codec);
			}
		}

		// Token: 0x04000BBB RID: 3003
		private static readonly MessageParser<ChessRogueQueryDiceInfo> _parser = new MessageParser<ChessRogueQueryDiceInfo>(() => new ChessRogueQueryDiceInfo());

		// Token: 0x04000BBC RID: 3004
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000BBD RID: 3005
		public const int SusFieldNumber = 12;

		// Token: 0x04000BBE RID: 3006
		private static readonly MapField<uint, bool>.Codec _map_sus_codec = new MapField<uint, bool>.Codec(FieldCodec.ForUInt32(8U, 0U), FieldCodec.ForBool(16U, false), 98U);

		// Token: 0x04000BBF RID: 3007
		private readonly MapField<uint, bool> sus_ = new MapField<uint, bool>();

		// Token: 0x04000BC0 RID: 3008
		public const int DicePhaseFieldNumber = 10;

		// Token: 0x04000BC1 RID: 3009
		private ChessRogueNousDicePhase dicePhase_;

		// Token: 0x04000BC2 RID: 3010
		public const int DiceListFieldNumber = 1;

		// Token: 0x04000BC3 RID: 3011
		private static readonly FieldCodec<ChessRogueDice> _repeated_diceList_codec = FieldCodec.ForMessage<ChessRogueDice>(10U, ChessRogueDice.Parser);

		// Token: 0x04000BC4 RID: 3012
		private readonly RepeatedField<ChessRogueDice> diceList_ = new RepeatedField<ChessRogueDice>();

		// Token: 0x04000BC5 RID: 3013
		public const int SurfaceIdListFieldNumber = 3;

		// Token: 0x04000BC6 RID: 3014
		private static readonly FieldCodec<uint> _repeated_surfaceIdList_codec = FieldCodec.ForUInt32(26U);

		// Token: 0x04000BC7 RID: 3015
		private readonly RepeatedField<uint> surfaceIdList_ = new RepeatedField<uint>();
	}
}
